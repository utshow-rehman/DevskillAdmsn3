using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = GetName();
            Console.WriteLine(name);
        }

        public static string GetName()
        {
            // Remove NotImplementedException and add code here.
            // GetObject returns an object which has Name property
            // Get that value and return that.
            var name = GetObject(); 
            string str1=Convert.ToString(name);
            string f="";
            int c = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == '='|| str1[i] == ',')
                {
                    if (c==1)
                        break;
                    c = 1;
                }

                else if (c == 1)
                {
                   // Console.WriteLine(str1[i]);
                    f += str1[i];
                }
                
                
            }

           
            return f;
        }

        public static object GetObject()
        {
            return new { Name = "Camera",Price = 200 };
        }
    }
}
