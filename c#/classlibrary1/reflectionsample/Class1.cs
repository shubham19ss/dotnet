using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflectionsample
{
    class Class1
    {
        public static void print()
        {
            Type t = Type.GetType("reflectionsample.Program");
            object instance = Activator.CreateInstance(t);
            MethodInfo minfo = t.GetMethod("GetFullName");
            string[] str = new string[1];
            str[0] = "hello";
           // str[1] = "world";
            minfo.Invoke(instance, str);
       
        }
    }
}
