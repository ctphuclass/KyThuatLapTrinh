/*
 * Created by SharpDevelop.
 * User: VienDong
 * Date: 11/21/2019
 * Time: 8:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiTapStruct
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			//BaiTapDiem();
			BaiTapPhanSo();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void BaiTapDiem()
		{			
			DIEM A, B;
			A = NhapDiem();
			B = NhapDiem();
			XuatDiem(A);
			XuatDiem(B);
			Console.WriteLine("Khoang cach cua 2 diem tren la {0}", KhoangCach(A,B));
		}
		
		static void BaiTapPhanSo()
		{
			PHANSO A, B, C, D;
			A = NhapPhanSo();
			B = NhapPhanSo();
			C = CongPhanSo(A,B);
			D = A + B;
			XuatPhanSo(A);
			Console.WriteLine("+");
			XuatPhanSo(B);
			Console.WriteLine("=");
			XuatPhanSo(C);
			XuatPhanSo(D);
			
		}
		
		static PHANSO CongPhanSo(PHANSO psA, PHANSO psB)
		{
			PHANSO psResult;
			psResult.TuSo = psA.TuSo*psB.MauSo + psB.TuSo * psA.MauSo ;
			psResult.MauSo = (psA.MauSo*psB.MauSo);
			psResult = ToiGian(psResult);
			return psResult;			
		}
		
		static PHANSO TruPhanSo(PHANSO psA, PHANSO psB)
		{
			PHANSO psResult;
			psResult.TuSo = psA.TuSo*psB.MauSo - psB.TuSo * psA.MauSo ;
			psResult.MauSo = (psA.MauSo*psB.MauSo);
			psResult = ToiGian(psResult);
			return psResult;			
		}

		static PHANSO NhanPhanSo(PHANSO psA, PHANSO psB)
		{
			PHANSO psResult;
			psResult.TuSo = psA.TuSo*psB.TuSo;
			psResult.MauSo = (psA.MauSo*psB.MauSo);
			psResult = ToiGian(psResult);
			return psResult;			
		}

		static PHANSO ChiaPhanSo(PHANSO psA, PHANSO psB)
		{
			PHANSO psResult;
			psResult.TuSo = psA.TuSo*psB.MauSo;
			psResult.MauSo = (psA.MauSo*psB.TuSo);
			psResult = ToiGian(psResult);
			return psResult;			
		}
		
		static PHANSO ToiGian(PHANSO psA)
		{
			PHANSO psResult;
			
			psResult.TuSo = psA.TuSo / USCLN(psA.TuSo, psA.MauSo);
			psResult.MauSo = psA.MauSo / USCLN(psA.TuSo, psA.MauSo);
			return psResult;
		}
		static PHANSO NhapPhanSo()
		{
			PHANSO psResult;
			Console.Write("Nhap Tu So:");
			psResult.TuSo = int.Parse(Console.ReadLine());
			Console.Write("Nhap Mau So:");
			psResult.MauSo = int.Parse(Console.ReadLine());
			return psResult;
		}
		static void XuatPhanSo(PHANSO psA)
		{
			Console.WriteLine("({0} / {1})", psA.TuSo, psA.MauSo);
		}
		
		static double KhoangCach(DIEM pA, DIEM pB)
		{
			double dResult = 0;
			dResult = Math.Sqrt(((pA.X - pB.X)*(pA.X-pB.X)) + ((pA.Y - pB.Y)*(pA.Y - pB.Y)));
			return dResult;
		}
		
		static DIEM NhapDiem()
		{
			DIEM dResult;
			Console.Write("Nhap X:");
			dResult.X = double.Parse(Console.ReadLine());
			Console.Write("Nhap Y:");
			dResult.Y = double.Parse(Console.ReadLine());
			return dResult;
		}
		static void XuatDiem(DIEM pDiem)
		{
			Console.WriteLine("({0} , {1})", pDiem.X, pDiem.Y);
		}
		
		static int USCLN(int piA, int piB)
		{
			int iResult = 1;
			int i,SoNhoHon;
			
			if(piA > piB)
			{
				SoNhoHon = piB;
			}
			else
			{
				SoNhoHon = piA;
			}
			
			for (i = SoNhoHon; i>1; i-- ) 
			{
				if((piB % i == 0)&&(piA % i == 0))
				{
					iResult = i;
					return iResult;
				}
			}
			
			return iResult;
		}
	}
	
	
	
	
	
	
	struct PHANSO
	{
		public int TuSo;
		public int MauSo;
		
		public static PHANSO operator +(PHANSO psA, PHANSO psB)
		{
			PHANSO psResult;
			psResult.TuSo = psA.TuSo*psB.MauSo + psB.TuSo * psA.MauSo ;
			psResult.MauSo = (psA.MauSo*psB.MauSo);
			psResult = ToiGian(psResult);
			return psResult;			
		}
		static int USCLN(int piA, int piB)
		{
			int iResult = 1;
			int i,SoNhoHon;
			
			if(piA > piB)
			{
				SoNhoHon = piB;
			}
			else
			{
				SoNhoHon = piA;
			}
			
			for (i = SoNhoHon; i>1; i-- ) 
			{
				if((piB % i == 0)&&(piA % i == 0))
				{
					iResult = i;
					return iResult;
				}
			}
			
			return iResult;
		}
		static PHANSO ToiGian(PHANSO psA)
		{
			PHANSO psResult;
			psResult.TuSo = psA.TuSo / USCLN(psA.TuSo, psA.MauSo);
			psResult.MauSo = psA.MauSo / USCLN(psA.TuSo, psA.MauSo);
			return psResult;
		}
	}
	
	struct DIEM
	{
		public double X;
		public double Y;
	}
}