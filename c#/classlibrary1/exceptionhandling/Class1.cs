using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    class Class1
    {
       public  void readinput()
        {
            try
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                int num;
                if(int.TryParse("2", out num))//converting  string to int and returns bool
                {
                    Console.WriteLine("success");
                }
                int c = Convert.ToInt32(a) / Convert.ToInt32(b);
                Console.WriteLine(c.ToString());
            } 
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("inner exception", ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("inner exception", ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("inner exception", ex);
            }
        }
      

    }
}
