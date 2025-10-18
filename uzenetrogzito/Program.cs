using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace uzenetrogzito
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] fajlok = { "../../11.txt", "../../14.txt", "../../15.txt", "../../16.txt" };

            foreach (var fajl in fajlok)
            {
                File.WriteAllText(fajl, string.Empty);
            }

            Console.WriteLine("Üzenetrögzítés");
            int sernum = 0;
            char[] valid = {
                'a', 'á', 'b', 'c', 'd', 'e', 'é', 'f', 'g', 'h', 'i', 'í',
                'j', 'k', 'l', 'm', 'n', 'o', 'ó', 'ö', 'ő', 'p', 'q', 'r',
                's', 't', 'u', 'ú', 'ü', 'ű', 'v', 'w', 'x', 'y', 'z',
                'A', 'Á', 'B', 'C', 'D', 'E', 'É', 'F', 'G', 'H', 'I', 'Í',
                'J', 'K', 'L', 'M', 'N', 'O', 'Ó', 'Ö', 'Ő', 'P', 'Q', 'R',
                'S', 'T', 'U', 'Ú', 'Ü', 'Ű', 'V', 'W', 'X', 'Y', 'Z'
            };

            while (true)
            {

                Console.Write("Ön neve: ");
                string name = Console.ReadLine();

                bool tf = false;
                string bname = name.ToUpper();
                char[] namech = name.ToCharArray();
                char[] bnamech = bname.ToCharArray();
                char first = bname[0];
                for (int i = 0; i < namech.Length; i++)
                {
                    tf = true;
                    for (int j = 0; j < valid.Length; j++)
                    {
                        if (namech[i] == valid[j]) tf = false;

                    }

                }
                for (int i = 0; i < namech.Length; i++)
                {
                    for (int j = 0; j < bnamech.Length; j++)
                    {
                        if (namech[0] != bname[0]) tf = true;
                        else if (i != 0 && j != 0 && namech[i] == bname[j]) tf = true;

                    }

                }


                if (tf == true)
                {
                    Console.WriteLine("Ez hibás név"); continue;
                }
                Console.Clear();
                decimal choose = 0;
                bool choice = true;
                while (choice)
                {

                    Console.WriteLine("Választási lehetőségek:\n\t11 – titkárság\n\t14 – tanári\n\t15 – kollégium\n\t16 – könyvtár");
                    Console.Write("Választott lehetőség (száma): ");
                    try { choose = decimal.Parse(Console.ReadLine()); }
                    catch { Console.Clear(); Console.WriteLine("Nem számot adott meg!"); continue; }


                    switch (choose)
                    {
                        case 11:
                            Console.Clear();
                            Console.WriteLine($"Ön neve: {name}");
                            Console.WriteLine("Ön a titkárságot választotta");
                            choice = false;
                            break;
                        case 14:
                            Console.Clear();
                            Console.WriteLine($"Ön neve: {name}");
                            Console.WriteLine("Ön a tanárit választotta");
                            choice = false;
                            break;
                        case 15:
                            Console.Clear();
                            Console.WriteLine($"Ön neve: {name}");
                            Console.WriteLine("Ön a kollégiumot választotta");
                            choice = false;
                            break;
                        case 16:
                            Console.Clear();
                            Console.WriteLine($"Ön neve: {name}");
                            Console.WriteLine("Ön a könyvtárt választotta");
                            choice = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine($"Ön neve: {name}");
                            Console.WriteLine("Ön nem megadott számott választott");
                            break;
                    }

                }

                Console.Write("Üzenet: ");
                string message = Console.ReadLine();
                string phnum = "+36";
                Random rnd = new Random();

                for (int i = 0; i < 8; i++)
                {
                    int num = rnd.Next(0, 10);
                    phnum += num;
                }

                bool agree = true;
                while (agree)
                {
                    Console.Clear();
                    Console.Write($"Itt vannak a felvett adatai, ilyen formátumba lesznek továbbíta:\n{sernum + 1};{name};{message};{phnum};{DateTime.Now}\nMegfelel?(I/N): ");
                    char okay = char.Parse(Console.ReadLine().ToUpper());
                    if (okay == 'I')
                    {
                        sernum += 1;
                        switch (choose)
                        {
                            case 11:
                                StreamWriter sw11 = new StreamWriter($"../../11.txt", true, encoding: Encoding.UTF8);
                                sw11.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                                sw11.Close();
                                break;
                            case 14:
                                StreamWriter sw14 = new StreamWriter($"../../14.txt", true, encoding: Encoding.UTF8);
                                sw14.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                                sw14.Close();
                                break;
                            case 15:
                                StreamWriter sw15 = new StreamWriter($"../../15.txt", true, encoding: Encoding.UTF8);
                                sw15.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                                sw15.Close();
                                break;
                            case 16:
                                StreamWriter sw16 = new StreamWriter($"../../16.txt", true, encoding: Encoding.UTF8);
                                sw16.WriteLine($"{sernum};{name};{message};{phnum};{DateTime.Now}");
                                sw16.Close();
                                break;
                            default:
                                Console.WriteLine($"Nem létező számot adott meg: {choose}");
                                sernum -= 1;
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("Az üzenete továbbítva lett");
                        agree = false;
                    }

                    else if (okay == 'N') { Console.Clear(); Console.WriteLine("Üzenet törölve lett"); agree = false; }
                    else
                    {
                        Console.WriteLine("Ilyen válasz nincs!");
                        continue;
                    }
                    Console.Write("Szeretne kilépni?(I/N): ");
                    char exit = char.Parse(Console.ReadLine().ToUpper());
                    if (exit == 'I') Environment.Exit(0);
                    else if (exit == 'N')
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Ilyen válasz nincs!");
                        continue;
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
