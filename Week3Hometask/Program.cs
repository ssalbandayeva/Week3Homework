using System.Reflection;
using System.Xml.Linq;

namespace Week3Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Umumi emek haqqinizi daxil edin: ");
            int grossSalary = int.Parse(Console.ReadLine());
            //float netSalary = grossSalary;
            Console.WriteLine("Aile veziyyetiniz? (s/e/d)");
            char maritalStatus = char.Parse(Console.ReadLine());


            //float netSalary;
            //Console.WriteLine($"Net emek haqqiniz: {netSalary} ");



            if (maritalStatus == 'e')
            {
                grossSalary += 50; //2050

                Console.WriteLine("Usaqlarinizin sayini daxil edin: ");
                int countOfChild = int.Parse(Console.ReadLine());

                if (countOfChild == 1)
                {
                    grossSalary += countOfChild * 30; //2080
                }

                else if (countOfChild == 2)
                {
                    grossSalary += countOfChild * 25; //2105
                }

                else if (countOfChild == 3)
                {
                    grossSalary += countOfChild * 20; //2125
                }

                else
                {
                    grossSalary += countOfChild * 15; //2140 ve ya 2155
                }

            }



            Console.WriteLine("Elillik? (b/x)");
            char disability = char.Parse(Console.ReadLine());

            Console.WriteLine(grossSalary);
            }
        }
    }