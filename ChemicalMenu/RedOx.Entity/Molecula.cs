namespace RedOx.Entity
{
    [Serializable]
    public class Molecula : IChemPartical
    {
        public string Molecular { get; set; }
        public double Molarmass { get; set; }
        public List<Ion> Element = new List<Ion>();
        private MoleculaList _moleculaList = new MoleculaList();
        public double Mole { get; set; }
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

        public void SetQuantumParams()
        {
            throw new NotImplementedException();
        }

        public void ConcatPartical()
        {
            throw new NotImplementedException();
        }

        public void GetQuantumParams()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Выводит список всех связей в молекуле
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetBounds()
        {
            // TODO: Переработать данный элемент кода, с упором на химическую природу атома
            Dictionary<string,int> list = new Dictionary<string, int>();
            foreach(Ion ion in Element)
            {
                
            }
            return list;
        }
    }
}
