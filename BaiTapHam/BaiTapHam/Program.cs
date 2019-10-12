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
			int iN, iM;
			Console.WriteLine("Ve Hinh Chu Nhat!");
			
			iN = InputInt("Nhap N", 3, 10);
			iM = InputInt("Nhap M", 3, 10);
			DrawRectangle(iN, iM);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
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