using System;

namespace BangCuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int iN, iMin, iMax;
            Console.WriteLine("Chuong trinh in Bang Cuu Chuong");
            iMin = 2;
            iMax = 10;
            do{
                Console.Write("Nhap N [{0},{1}]: ",iMin,iMax);
                iN = int.Parse(Console.ReadLine());
            }while(iN<iMin||iN>iMax);
            for(int i = 1;i<=10;i=i+1)
            {
                Console.WriteLine("{0} * {1} = {2}", iN, i, i*iN);
            }
            Console.Write("Press any key to exit.");
            Console.ReadKey(true);

        }
    }
}
