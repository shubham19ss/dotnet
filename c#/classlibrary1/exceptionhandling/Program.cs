using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exceptionhandling
{
    public delegate void delegetaehelper(String s);
    class Program
    {
        static void Main(string[] args)
        {
            //exceptionhandling.Exceptionsample obj = new exceptionhandling.Exceptionsample();
            //obj.ReadFromStream();
            //exceptionhandling.Class1 obj1 = new exceptionhandling.Class1();
            //obj1.readinput();
            delegetaehelper helper  = new delegetaehelper(print);
            helper("shubham");
            Console.Read();
        }
        public static void print(string s)
        {
            Console.WriteLine(s);
        }

    }
    public class Exceptionsample
    {
        public static void print(string s)
        {
           Console.WriteLine(s);
        }
        public  void ReadFromStream()
        {
            StreamReader sr=null;
            try
            {
                sr= new StreamReader(@"C:\Users\cdac\Desktop\read.txt");
                Console.WriteLine(sr.ReadToEnd());
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("please try again");
                ex.GetBaseException();
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
