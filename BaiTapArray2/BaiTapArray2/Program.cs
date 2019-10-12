/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 12/10/2019
 * Time: 8:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapArray2
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			BaiTap2();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void BaiTap2()
		{
			int iN, iMin, iMax, i;
			int [] A; //Khai bao bien A la mot mang chua biet so phan tu
			string sMessage = "";
			int iDuongLonNhat, iAmNhoNhat;
			int iCount;
			iMin = 3;
			iMax = 20;
			iN = InputInt("Nhap N", iMin, iMax);
			
			//Console.WriteLine("N={0}",iN);
			
			A = new int[iN]; //Khai bao mang A co N phan tu
			
			iMin = -1000;
			iMax = 1000;
			//Nhap phan tu thu 1, 2, 3 (i+1)
			for (i = 0; i < iN; i++) 
			{
				sMessage = string.Format("Nhap phan tu thu {0}", i+1);
				A[i] = InputInt(sMessage, iMin, iMax);
			}
			
			WriteArray(A, iN);
			iDuongLonNhat = -1;
			iAmNhoNhat = 1;
			iCount = 0;
			for (i = 0; i < iN; i++) 
			{
				if(A[i]>0 && A[i] > iDuongLonNhat)
				{
					iDuongLonNhat = A[i];
				}
				if(A[i]<0 && A[i] < iAmNhoNhat)
				{
					iAmNhoNhat = A[i];
				}
				if(IsSoChinhPhuong(A[i]))
				{
					iCount = iCount + 1;
				}
			}
			
			if(iDuongLonNhat > 0)
			{
				Console.WriteLine("So duong lon nhat la: {0}", iDuongLonNhat);
			}
			else
			{
				Console.WriteLine("Mang A khong co so duong");
			}
			
			if(iAmNhoNhat < 0)
			{
				Console.WriteLine("So am nho nhat la: {0}", iAmNhoNhat);
			}
			else
			{
				Console.WriteLine("Mang A khong co so am");
			}
			
			if(iCount > 0)
			{
				Console.WriteLine("Mang A co {0} so chinh phuong", iCount);
			}
			else
			{
				Console.WriteLine("Mang A khong co so chinh phuong");
			}
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
		
		static bool IsSoChinhPhuong(int piN)
		{
			bool bResult = false;
			for (int i = 1; i <= piN/2; i++) {
				if(i*i == piN)
				{
					bResult = true;
					break;
				}
			}
			return bResult;
		}
	}
}