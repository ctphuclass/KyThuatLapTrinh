/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 12/10/2019
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * Viet chuong trinh nhap N,M tu ban phim [3,10]
 * Ve Hinh chu nhat hinh sao (*) rong ruot kich thuoc (N,M)
 * 
 */
using System;

namespace BaiTapHam
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			BaiTapChiaHet();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void BaiTapChiaHet()
		{
			int iN;
			Console.WriteLine("Bai Tap Chia Het!");
			iN = InputInt("Nhap N", 2, 1000);
			Console.WriteLine("N = {0}", iN);
			
			if(CoLaSoNguyenTo(iN) == true)
			{
				Console.WriteLine("{0} La so nguyen to", iN);
			}
			else
			{
				Console.WriteLine("{0} khong phai la so nguyen to", iN);
			}
			
		}
		
		static bool CoLaSoNguyenTo(int piN)
		{
			bool bResult = false;
			for (int i = 2; i <= piN - 1 ; i++) 
			{
				if(piN % i == 0)
				{
					bResult = false;
					return bResult;
				}
			}
			bResult = true;
			return bResult;
			
		}
		
		static bool ChiaHetCho3(int piN)
		{
			bool bResult = false;
			if(piN % 3 == 0)
			{
				bResult = true;
			}
			else
			{
				bResult = false;
			}
			return bResult;
		}
		
		static void BaiTapVeHinh()
		{
			int iN, iM;
			Console.WriteLine("Ve Hinh Chu Nhat!");
			
			iN = InputInt("Nhap N", 3, 10);
			
			iM = InputInt("Nhap M", 3, 10);
			
			DrawRectangle(iN, iM);
		}
		
		static int InputInt(string psMessage, int piMin, int piMax)
		{
			int iResult = 0;
			do{
				Console.Write("{0} [{1},{2}]: ", psMessage, piMin, piMax);
				iResult = int.Parse(Console.ReadLine());
			}while (iResult < piMin || iResult > piMax);
			return iResult;
		}
		
		static void DrawRectangle(int piN, int piM)
		{
			for (int i = 0; i < piN; i++) {
				for (int j = 0; j < piM; j++) {
					Console.Write(" * ");
				}
				Console.WriteLine();
			}
		}
		
	}
}