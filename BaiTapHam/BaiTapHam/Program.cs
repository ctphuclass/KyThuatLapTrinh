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
			//BaiTapSoNguyenTo();
			BaiTapGiaiPhuongTrinh();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void BaiTapGiaiPhuongTrinh()
		{
			Console.WriteLine("Giai phuong trinh bac 2");
			double dA,dB,dC,dX1,dX2;
			int iSoNghiem;
			dA = InputDouble("Nhap A", 1, 1000);
			dB = InputDouble("Nhap B", 1, 1000);
			dC = InputDouble("Nhap C", 1, 1000);
			iSoNghiem = GPTB2(dA, dB, dC, out dX1, out dX2);
			if(iSoNghiem == 0)
			{
				Console.WriteLine("Phuong trinh {0}*X*X + {1}*X + {2} = 0 Vo nghiem",dA,dB,dC);
			}
			else if(iSoNghiem == 1)
			{
				Console.WriteLine("Phuong trinh {0}*X*X + {1}*X + {2} = 0 Co 1 Nghiem X={3}",dA,dB,dC,dX1);
			}
			else
			{
				Console.WriteLine("Phuong trinh {0}*X*X + {1}*X + {2} = 0 Co 2 Nghiem X1={3}, X2={4}",dA,dB,dC,dX1, dX2);
			}
		}
		
		static int GPTB2(double pdA, double pdB, double pdC, out double X1, out double X2)
		{
			int iResult = 0;
			X1 = 0;
			X2 = 0;
			double delta = (pdB * pdB) - (4 * pdA * pdC);
			if (delta < 0) 
			{
				iResult = 0;	
			}else if (delta == 0) 
			{
				iResult = 1;
				X1 = (0-pdB)/(2*pdA);
				X2 = (0-pdB)/(2*pdA);
			}
			else
			{
				iResult = 2;
				X1 = (0-pdB + Math.Sqrt(delta) )/(2*pdA);
				X2 = (0-pdB - Math.Sqrt(delta) )/(2*pdA);
			}
			return iResult;
		}
		
		static void BaiTapSoNguyenTo()
		{
			int iN;
			Console.WriteLine("Bai Tap So Nguyen To!");
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
		
		static double InputDouble(string psMessage, double piMin, double piMax)
		{
			double dResult = 0;
			do{
				Console.Write("{0} [{1},{2}]: ", psMessage, piMin, piMax);
				dResult = double.Parse(Console.ReadLine());
			}while (dResult < piMin || dResult > piMax);
			return dResult;
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