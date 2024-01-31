using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Collections;
using Newtonsoft.Json;
using System.Threading;
using RedOx.DataBase;
using static IronPython.Modules._ast;

namespace RedOx.Entity
{
    [Serializable]
    public class Molecula
    {
        public string Molecular { get; set; }
        public double Molarmass { get; set; }
        public List<Ion> Element = new List<Ion>();
        public double Mole { get; set; }
        [NonSerialized]
        private List<double> Molarmasslist;
        public string[] ErrorMessage { get; set; }
        /// <summary>
        /// Основной класс RedOx. Характеристики молекулы
        /// </summary>
        /// <param name="molecular">Название молекулы</param>
        public Molecula(string molecular)
        {
            Molecular = molecular;
            if(molecular != String.Empty || molecular.GetType() != typeof(string))
            {
                Molarmasslist = new List<double>();
                List<string> list = molecular.Split(new char[] { '(', ')', '[', ']' }).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i + 1 != list.Count)
                    {
                        if (int.TryParse(list[i + 1], out int n))
                        {
                            Ion ion = new Ion(list[i], int.Parse(list[i + 1]));
                            Element.Add(ion);
                            list.RemoveAt(i + 1);
                            ErrorMessage.Append(ion.ErrorMessage);
                        }
                        else
                        {
                            Ion ion = new Ion(list[i], 1);
                            Element.Add(ion);
                            ErrorMessage.Append(ion.ErrorMessage);
                            continue;
                        }
                    }
                    else
                    {
                        Ion ion = new Ion(list[i], 1);
                        Element.Add(ion);
                        ErrorMessage.Append(ion.ErrorMessage);
                        continue;
                    }
                }
                Molarmass = Molarmasslist.Sum();
            }
            else
            {
                ErrorMessage.Append($"\n {DateTime.Now} - Некорректный ввод данных. Тип данных Molecula.molecular - {molecular.GetType()}");
            }
        }
        public void GetJsonMolecula(Molecula mol, string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    fs.Close();
                    string json = JsonConvert.SerializeObject(mol, Formatting.Indented);
                    File.AppendAllText(path, json);
                }
            }
            catch
            {
                ErrorMessage.Append("Отказано в пути к папке");
            }
        }
        public int RedOxFeature()
        {
            return 0;
        }
        /// <summary>
        /// Выводит список всех связей в молекуле
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> TypeOfBound()
        {
            Dictionary<string,int> list = new Dictionary<string, int>();
            foreach(Ion ion in Element)
            {
                for(int i = 0; i < ion.atoms.Count - 1; i++)
                {
                    if((ion.atoms[i].IsMetal == false && ion.atoms[i].IsMetal == true) || 
                        (ion.atoms[i].IsMetal == true && ion.atoms[i].IsMetal == false))
                    {
                        list.Add($"{ion.atoms[i].AtomName} - {ion.atoms[i+1].AtomName}", -1); //Ионная связь
                    }
                    else if (ion.atoms[i].IsMetal == true && ion.atoms[i].IsMetal == true)
                    {
                        list.Add($"{ion.atoms[i].AtomName} - {ion.atoms[i + 1].AtomName}", 0); //Металлическая связь
                    }
                    else
                    {
                        list.Add($"{ion.atoms[i].AtomName}  -  {ion.atoms[i + 1].AtomName}", 1); //Ковалентная связь
                    }
                }
            }
            return list;
        }
    }
}
