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
        public bool IsActive;
        public string Algorithm;
        public List<dynamic> Results;
        public RedOxAlgorithms(string algorythm)
        {
            Algorithm = AppDomain.CurrentDomain.BaseDirectory + $@"\algorythms\{algorythm}";
        }
        public void SetMolecula()
        {
            
        }
        /// <summary>
        /// Получение значения формулы
        /// </summary>
        /// <param name="alogorythm"></param>
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
