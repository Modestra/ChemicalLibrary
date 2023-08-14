using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace EnviromentCore
{
    /// <summary>
    /// Класс, запускающий алгоритмы, написанные на языке Python
    /// </summary>
    public class RedOxAlgorithms
    {
        ScriptEngine engine = Python.CreateEngine();
        public string Algorithm; //Название алгоритма 
        public List<dynamic> Results; //Полученные данные с алгоритмов
        public RedOxAlgorithms(string algorythm)
        {
            Algorithm = AppDomain.CurrentDomain.BaseDirectory + $@"\algorythms\{algorythm}";
        }
        /// <summary>
        /// Получение значения формулы
        /// </summary>
        /// <param name="formula"></param>
        /// <returns>Значение, полученное в ходе обработки функции</returns>
        public object GetValues(string formula, object input)
        {
            ScriptScope scope = engine.CreateScope();
            engine.ExecuteFile(Algorithm, scope);
            dynamic script = scope.GetVariable(formula);
            if(input.GetType() == typeof(List<>))
            {
                foreach(var item in input as List<dynamic>)
                {
                   
                }
                return Results;
            }
            else
            {
                return script(input);
            }
        }
        
    }
}
