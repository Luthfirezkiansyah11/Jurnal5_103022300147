﻿namespace Jurnal5_103022300147
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 30;
            int c = 22;
            PemrosesData pD = new PemrosesData();
            Console.WriteLine("Angka Terbesar adalah: " + pD.DapatkanNilaiTerbesar(10, 30, 22));


            SimpleDataBase<int> sgc = new SimpleDataBase<int>();

            sgc.AddNewData(10);
            sgc.AddNewData(20);
            sgc.AddNewData(30);

            sgc.PrintAllData();

        }
    }
}
