using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_inlämning
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double result = 0;
            double result1 = 0;

            Console.WriteLine("skriv första numret: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Skriv en ny operator: ");
            char Action1 = Console.ReadKey().KeyChar;

            Console.WriteLine("Skriv andra numret; ");
            string input2 = Console.ReadLine();

            Console.WriteLine("Skriv en ny operator: ");
            char Action2 = Console.ReadKey().KeyChar;

            Console.WriteLine("Skriv andra numret; ");
            string input3 = Console.ReadLine();


            //bug test2


            if (Action1 == '+')
            {
                Console.WriteLine(input1 + '+' + input2);
                result = Convert.ToInt32(input1) + Convert.ToInt32(input2);
            }
            else if(Action1 == '-')
            {
                Console.WriteLine(input1 + '-' + input2);
                result = Convert.ToInt32(input1) - Convert.ToInt32(input2);
            }
            else if( Action1 == '*')
            {
                Console.WriteLine(input1 + '*' + input2);
                result = Convert.ToInt32(input2)  *  Convert.ToInt32(input2);
            }
            else if(Action1 == '/')
            {
                Console.WriteLine(input1 + '/' + input2);
                result = Convert.ToInt32(input1) / Convert.ToInt32(input2);
            }






            if(Action2 == '+')
            {
                Console.WriteLine(input3 + '+' + result);
                result1 = result + Convert.ToInt32(input3);
                
            }
            else if(Action2 == '-')
            {
                Console.WriteLine(input3 + '-' + result);
                result1 = result - Convert.ToInt32(input3);
            }
            else if(Action2 == '*')
            {
                Console.WriteLine(input3 + '*' + input2);
                result1 = Convert.ToInt32(input3) * result;
            }
            
            else if(Action2 == '/')
            {
                Console.WriteLine(input3 + '/' + result);
                result1 = result / Convert.ToInt32(input3);
            }


            Console.WriteLine("Resultet: " + input1  + Action1 + input2 + Action2 + input3 + " = " + result1);

        }
    }
}
