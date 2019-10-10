/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 05/10/2019
 * Time: 9:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapArray
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			//BaiTapNhapXuatMangN();
			BaiTapTimSoNguyenTo();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static bool IsSoNguyenTo(int piN)
		{
			bool bResult = false;
			
			return bResult;
		}
		
		static void BaiTapTimSoNguyenTo()
		{
			int iN;
			int [] A;
			int i;
			string sMessage = "";
			iN = InputInt("Nhap N", 3, 20);
			A = new int[iN];
			for (i = 0; i < iN; i++) 
			{
				sMessage = String.Format("Nhap phan tu thu {0}",i+1);
				A[i] = InputInt(sMessage,2,1000);
			}
			WriteArray(A, iN);
		}
		
		static void BaiTapNhapXuatMangN()
		{
			int iN;
			int [] A;
			int i;
			string sMessage = "";
			iN = InputInt("Nhap N", 2, 20);
			A = new int[iN];
			for (i = 0; i < iN; i++) 
			{
				sMessage = String.Format("Nhap phan tu thu {0}",i+1);
				A[i] = InputInt(sMessage,1,100);
			}
			WriteArray(A, iN);
			Console.WriteLine("Gia tri lon nhat trong mang la: {0} tai vi tri {1}."
			                  ,TimGiaTriLonNhat(A,iN),TimViTriGiaTriLonNhat(A,iN) + 1);
		}
		static int TimGiaTriLonNhat(int [] pA, int piN)
		{
			int i, iResult;
			iResult = pA[0];
			for (i = 0; i < piN; i++)
			{
				if(pA[i]> iResult)
				{
					iResult = pA[i];
				}
			}
			return iResult;
		}
		static int TimViTriGiaTriLonNhat(int [] pA, int piN)
		{
			int i, iResult;
			iResult = 0;
			for (i = 0; i < piN; i++)
			{
				if(pA[i]> pA[iResult])
				{
					iResult = i;
				}
			}
			return iResult;
		}
		
		static void WriteArray(int [] pA, int piN)
		{
			Console.Write("[");
			for (int i = 0; i < piN; i++) 
			{
				if(i<piN-1)
				{
					Console.Write("{0},", pA[i]);
				}
				else
				{
					Console.Write("{0}", pA[i]);
				}
			}
			Console.WriteLine("]");
		}
		static int InputInt(string psMessage, int piMin, int piMax)
		{
			int iResult = 0;
			do{
				Console.Write("{0} [{1},{2}]: ",psMessage,piMin,piMax);
				iResult = int.Parse(Console.ReadLine());
			}while (iResult < piMin || iResult > piMax) ;
			return iResult;
		}
	}
}