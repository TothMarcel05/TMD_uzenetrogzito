using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hivottfel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Üzenetek megtekintése:\n\t11 – titkárság\n\t14 – tanári\n\t15 – kollégium\n\t16 – könyvtár\n\t1 – összes\n\t0 – kilépés");
                Console.Write("Válasszon menüpontot: ");
                decimal choose = decimal.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 11:
                        StreamReader sr11 = new StreamReader("../../../11.txt");
                        string line11;
                        Console.WriteLine("--------------------------------------\n\t11 – titkárság\n--------------------------------------");
                        while ((line11 = sr11.ReadLine()) != null) Console.WriteLine(line11);
                        Console.WriteLine();
                        sr11.Close();
                        StreamWriter sw11 = new StreamWriter("../../../11.txt");
                        sw11.Close();
                        continue;
                    case 14:
                        StreamReader sr14 = new StreamReader("../../../14.txt");
                        string line14;
                        Console.WriteLine("--------------------------------------\n\t14 – tanári\n--------------------------------------");
                        while ((line14 = sr14.ReadLine()) != null) Console.WriteLine(line14);
                        Console.WriteLine();
                        sr14.Close();
                        StreamWriter sw14 = new StreamWriter("../../../14.txt");
                        sw14.Close();
                        continue;
                    case 15:
                        StreamReader sr15 = new StreamReader("../../../15.txt");
                        string line15;
                        Console.WriteLine("--------------------------------------\n\t15 – kollégium\n--------------------------------------");
                        while ((line15 = sr15.ReadLine()) != null) Console.WriteLine(line15);
                        Console.WriteLine();
                        sr15.Close();
                        StreamWriter sw15 = new StreamWriter("../../../15.txt");
                        sw15.Close();
                        continue;
                    case 16:
                        StreamReader sr16 = new StreamReader("../../../16.txt");
                        string line16;
                        Console.WriteLine("--------------------------------------\n\t16 – könyvtár\n--------------------------------------");
                        while ((line16 = sr16.ReadLine()) != null) Console.WriteLine(line16);
                        Console.WriteLine();
                        sr16.Close();
                        StreamWriter sw16 = new StreamWriter("../../../16.txt");
                        sw16.Close();
                        continue;
                    case 1:
                        StreamReader sr111 = new StreamReader("../../../11.txt");
                        string line111;
                        Console.WriteLine("--------------------------------------\n\t11 – titkárság\n--------------------------------------");
                        while ((line111 = sr111.ReadLine()) != null) Console.WriteLine(line111);
                        StreamReader sr114 = new StreamReader("../../../14.txt");
                        string line114;
                        Console.WriteLine("--------------------------------------\n\t14 – tanári\n--------------------------------------");
                        while ((line114 = sr114.ReadLine()) != null) Console.WriteLine(line114);
                        StreamReader sr115 = new StreamReader("../../../15.txt");
                        string line115;
                        Console.WriteLine("--------------------------------------\n\t15 – kollégium\n--------------------------------------");
                        while ((line115 = sr115.ReadLine()) != null) Console.WriteLine(line115);
                        Console.WriteLine();
                        StreamReader sr116 = new StreamReader("../../../16.txt");
                        string line116;
                        Console.WriteLine("--------------------------------------\n\t16 – könyvtár\n--------------------------------------");
                        while ((line116 = sr116.ReadLine()) != null) Console.WriteLine(line116);
                        Console.WriteLine();
                        sr111.Close();
                        sr114.Close();
                        sr115.Close();
                        sr116.Close();
                        StreamWriter sw111 = new StreamWriter("../../../11.txt");
                        sw111.Close(); 
                        StreamWriter sw114 = new StreamWriter("../../../14.txt");
                        sw114.Close();
                        StreamWriter sw115 = new StreamWriter("../../../15.txt");
                        sw115.Close();
                        StreamWriter sw116 = new StreamWriter("../../../16.txt");
                        sw116.Close();
                        continue;
                    case 0:
                        continue;

                    default:
                        Console.WriteLine("Ilyen választás nincs");
                        continue;

                }
            }

        }
    }
}
