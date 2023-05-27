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
        public RedOxAlgorithms()
        {
           
        }
        public void SetMolecula()
        {
            engine.ExecuteFile(AppDomain.CurrentDomain.BaseDirectory);
        }
        
    }
}
