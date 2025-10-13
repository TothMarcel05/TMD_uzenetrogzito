using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzenetrogzito
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sernum = 0;
            while (true)
            {
                Console.Write("Kérek egy nevet: ");
                string name = Console.ReadLine();       
                Console.WriteLine("Választási lehetőségek:\n\t11 – titkárság\n\t14 – tanári\n\t15 – kollégium\n\t16 – könyvtár");
                Console.Write("Kérek egy számot (választott mellék): ");
                decimal choose = decimal.Parse(Console.ReadLine());

                Console.Write("Üzenet: ");
                string message = Console.ReadLine();
                string phnum = "+36";
                Random rnd = new Random();

                for (int i = 0; i < 8; i++)
                {
                    int num = rnd.Next(0, 10);
                    phnum += num;
                }
                Console.WriteLine("Telefonszáma: " + phnum);

                switch (choose)
                {
                    case 11:
                        StreamWriter sw11 = new StreamWriter($"../../11.txt", true, encoding: Encoding.UTF8);
                        sernum += 1;
                        sw11.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                        Console.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                        sw11.Close();
                        continue;
                    case 14:
                        StreamWriter sw14 = new StreamWriter($"../../14.txt", true, encoding: Encoding.UTF8);
                        sernum += 1;
                        sw14.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                        Console.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                        sw14.Close();
                        continue;
                    case 15:
                        StreamWriter sw15 = new StreamWriter($"../../15.txt", true, encoding: Encoding.UTF8);
                        sernum += 1;
                        sw15.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                        Console.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                        sw15.Close();
                        continue;
                    case 16:
                        StreamWriter sw16 = new StreamWriter($"../../16.txt", true, encoding: Encoding.UTF8);
                        sernum += 1;
                        sw16.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                        Console.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                        sw16.Close();
                        continue;
                    default:
                        Console.WriteLine($"Nem létező számot adott meg: {choose}");
                        continue;
                }
             
            }
          

            Console.ReadKey();
        }
    }
}
