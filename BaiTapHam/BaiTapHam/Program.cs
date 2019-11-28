/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 10/24/2019
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapHam
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
//			Console.WriteLine("Input N= {0}, Input M ={1}",InputInt("Nhap N", 100, 1000),InputInt("Nhap M", 100, 1000));
			int iN;
			
			
			iN = InputInt("Nhap N", 2, 50);
			
			Console.WriteLine("Tong {0} so la {1}", iN, SumToN(iN));
			Console.WriteLine("Tong {0} so la {1}", iN, SumToN1(iN));
			Console.WriteLine("Giai Thua {0} so la {1}", iN, GiaiThua(iN));
			
//			if(SoNguyenTo(iN))
//			{
//				Console.WriteLine("{0} la so nguyen to", iN);
//			}
//			else
//			{
//				Console.WriteLine("{0} khong phai la so nguyen to", iN);
//			}
			
//			for (int i = 1; i <= iN/2; i++) 
//			{
//				if((iN%i==0)&&(i%2==1))
//				{
//					Console.WriteLine("{0} la uoc so le cua {1}", i, iN);
//				}
//			}
//			 
			//Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
		
		static int SumToN(int piN)
		{
			int iResult = 0;
			for (int i = 1; i <= piN; i++) 
			{
				iResult = iResult + i;
			}
			return iResult;
		}
		
		static int SumToN1(int piN)
		{
			int iResult = 0;
			if(piN == 1)
			{
				iResult = 1;
			}
			else
			{
				iResult = SumToN1(piN - 1) + piN;
			}
			return iResult;
		}
		
		static int GiaiThua(int piN)
		{
			int iResult = 1;
			for (int i = 1; i <= piN; i++) {
				iResult = iResult * i;
			}
			return iResult;
		}
		
		static bool SoNguyenTo(int piN)
		{
			bool bResult = false;
			for (int i = 2; i <= piN/2; i++) 
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
		
		static int InputInt(string psMessage, int piMin, int piMax)
		{
			int iResutl = 0;
			do
			{
				Console.Write("{0} [{1},{2}]: ", psMessage, piMin, piMax);
				iResutl = int.Parse(Console.ReadLine());
				
			}while(iResutl < piMin || iResutl > piMax);
			return iResutl;
		}
		
		static void VeThap(int iX, int iY, int [] iA, int iN)
		{
			
			for (int i = 0; i < iN; i++) 
			{
				
				for (int j = 0; j < iA[i]; j++) {
					Console.SetCursorPosition(iX+j, iY+i);
					Console.Write("*");
				}
				//Console.WriteLine();
			}
		}
		
		
	}
}