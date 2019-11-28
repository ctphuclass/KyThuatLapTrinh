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
			BaiTapMang2Chieu();
			//BaiTapSapXep();
			//BaiTapNhapXuatMangN();
			//BaiTapTimSoNguyenTo();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void BaiTapMang2Chieu()
		{
			int iN, iM;
			int [,] A;
			int i, j;
			int iMin=0,dMin,cMin;
			int iMax=0, dMax, cMax;
			int iCountLe = 0, iCountChan = 0, iCountSoNguyenTo = 0;
			bool bTangDan, bGiamDan;
			
			string sMessage = "";
			Random rnd = new Random();

			iN = InputInt("Nhap N", 3, 20);
			iM = InputInt("Nhap M", 3, 20);
			
			A = new int[iN, iM];
			
			for (i = 0; i < iN; i++) 
			{
				for (j = 0; j < iM; j++) 
				{
					A[i,j] = rnd.Next(-1000,1000);
//					sMessage = String.Format("Nhap phan tu thu A[{0},{1}]",i+1, j+1);
//					A[i,j] = InputInt(sMessage,-1000,1000);
				}
			}
			WriteArray(A, iN, iM);
			
			iMin = A[0,0];
			dMin = 0;
			cMin = 0;
			iMax = A[0,0];
			dMax = 0;
			cMax = 0;
			for (i = 0; i < iN; i++) 
			{
				bTangDan = true;
				bGiamDan = true;
				for (j = 0; j < iM - 1; j++) 
				{
					if(A[i,j]>A[i,j+1])
					{
						bTangDan = false;
					}
					if(A[i,j]<A[i,j+1])
					{
						bGiamDan = false;
					}
					
				}
				
				if(bTangDan == true)
				{
					Console.WriteLine("Dong {0} tang dan.",i+1);
				}
				if(bGiamDan==true)
				{
					Console.WriteLine("Dong {0} giam dan.",i+1);
				}
			}
			
			for (j = 0; j < iM; j++) 
			{
				bTangDan = true;
				bGiamDan = true;
				for (i = 0; i < iN - 1; i++) 
				{
					if(A[i,j]>A[i+1,j])
					{
						bTangDan = false;
					}
					if(A[i,j]<A[i+1,j])
					{
						bGiamDan = false;
					}
					
				}
				if(bTangDan == true)
				{
					Console.WriteLine("Cot {0} tang dan.",j+1);
				}
				if(bGiamDan==true)
				{
					Console.WriteLine("Cot {0} giam dan.",j+1);
				}
				
			}
			for (i = 0; i < iN; i++) 
			{
				for (j = 0; j < iM; j++) 
				{
					if(A[i,j]<iMin)
					{
						iMin = A[i,j];
						dMin = i;
						cMin = j;
					}
					
					if(A[i,j]>iMax)
					{
						iMax = A[i,j];
						dMax = i;
						cMax = j;
					}
					if(A[i,j]%2==0)
					{
						iCountChan = iCountChan + 1;
					}
					else
					{
						iCountLe = iCountLe + 1;
					}
					if(IsSoNguyenTo(A[i,j])==true)
					{
						iCountSoNguyenTo = iCountSoNguyenTo + 1;
						Console.WriteLine("So Nguyen To trong mang tai vi tri A[{1},{2}] la: {0}",A[i,j],i + 1, j + 1);
					}
				}
				
			}
			Console.WriteLine("Gia tri nho nhat trong mang tai vi tri A[{1},{2}] la: {0}",iMin,dMin + 1, cMin + 1);
			Console.WriteLine("Gia tri lon nhat trong mang tai vi tri A[{1},{2}] la: {0}",iMax,dMax + 1, cMax + 1);
			Console.WriteLine("Mang A co {0} phan tu chan, {1} phan tu le, {2} so nguyen to.",iCountChan, iCountLe, iCountSoNguyenTo);
			
			
		}
		
		static void BaiTapSapXep()
		{
			int iN;
			int [] A;
			int i, j;
			int t;
			string sMessage = "";
			iN = InputInt("Nhap N", 3, 20);
			A = new int[iN];
			for (i = 0; i < iN; i++) 
			{
				sMessage = String.Format("Nhap phan tu thu {0}",i+1);
				A[i] = InputInt(sMessage,1,1000);
			}
			WriteArray(A, iN);
			for (i = 0; i <= iN - 2; i++) 
			{
				for (j = i+1; j <= iN - 1; j++) 
				{
//					if(A[i]>A[j])
//					{
//						Console.WriteLine("Hoan Vi vi tri thu {0} va vi tri thu {1}", i+1, j+1);
//						t=A[i];
//						A[i]=A[j];
//						A[j]=t;
//						WriteArray(A, iN);
//						Console.WriteLine("Press any key to continue . . . ");
//						Console.ReadKey(true);
//						
//					}
					
					if((i%2==0) && (j%2==0))
					{
						if( A[i] < A[j] ) // A[j] nho A[i] thi gia tri nho nhat la A[j]
						{
							Console.WriteLine("Hoan Vi vi tri thu {0} va vi tri thu {1}", i+1, j+1);
							t=A[i];
							A[i]=A[j];
							A[j]=t;
						}
						
					}
					if((i%2==1) && (j%2==1))
					{
						if( A[i] > A[j] ) // A[j] nho A[i] thi gia tri nho nhat la A[j]
						{
							Console.WriteLine("Hoan Vi vi tri thu {0} va vi tri thu {1}", i+1, j+1);
							t=A[i];
							A[i]=A[j];
							A[j]=t;
						}
						
					}
						
					
					
				}
				
			}
			WriteArray(A, iN);
		}
		
		static bool IsSoNguyenTo(int piN)
		{
			bool bResult = false;
			if(piN<1)
				return false;
			for (int i = 2; i < piN; i++) 
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
		
		static void BaiTapTimSoNguyenTo()
		{
			int iN;
			int [] A;
			int i;
			string sMessage = "";
			int iViTri = 0, iGiaTri = 0, iCount = 0;
			bool bFlag = false;
			iN = InputInt("Nhap N", 3, 20);
			A = new int[iN];
			for (i = 0; i < iN; i++) 
			{
				sMessage = String.Format("Nhap phan tu thu {0}",i+1);
				A[i] = InputInt(sMessage,2,1000);
			}
			WriteArray(A, iN);
			
			iCount = 0;
			for (i = 0; i < iN; i++) 
			{
				if(IsSoNguyenTo(A[i]))
				{
					iViTri = i;
					iGiaTri = A[i];
					bFlag = true;
					iCount = iCount + 1;
				}
			}
			if(bFlag == true)
			{
				Console.WriteLine("Mang A co so nguyen to tai vi tri {0}: {1}", iViTri+1, iGiaTri);
			}
			else
			{
				Console.WriteLine("Mang A khong co so nguyen to.");
			}
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
		
		static int TimSoDuongDauTien(int [] pA, int piN)
		{
			int i, iResult;
			iResult = -1;
			for (i = 0; i < piN; i++)
			{
				if(pA[i]> 0)
				{
					iResult = pA[i];
					return iResult;
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
		
		static void WriteArray(int [,] pA, int piN, int piM)
		{
			//Console.Write("[ ");
			for (int i = 0; i < piN; i++) 
			{
				for(int j = 0; j<piM; j++)
				{
					if(j<piM-1)
					{
						Console.Write("{0,5} , ", pA[i,j]);
					}
					else
					{
						Console.Write("{0,5}", pA[i,j]);
					}
					
				}
				Console.WriteLine();
			}
			//Console.WriteLine(" ] ");
		}
		
		static void WriteArray(int [] pA, int piN)
		{
			Console.Write("           [ ");
			for (int i = 0; i < piN; i++) 
			{
				if(i<piN-1)
				{
					Console.Write("{0} , ", pA[i]);
				}
				else
				{
					Console.Write("{0}", pA[i]);
				}
			}
			Console.WriteLine(" ] ");
		}
		
		static void WriteArray(double [] pA, int piN)
		{
			Console.Write("           [ ");
			for (int i = 0; i < piN; i++) 
			{
				if(i<piN-1)
				{
					Console.Write("{0} , ", pA[i]);
				}
				else
				{
					Console.Write("{0}", pA[i]);
				}
			}
			Console.WriteLine(" ] ");
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
		
		static double InputDoule(string psMessage, double piMin, double piMax)
		{
			double iResult = 0;
			do{
				Console.Write("{0} [{1},{2}]: ",psMessage,piMin,piMax);
				iResult = double.Parse(Console.ReadLine());
			}while (iResult < piMin || iResult > piMax) ;
			return iResult;
		}
	}
}