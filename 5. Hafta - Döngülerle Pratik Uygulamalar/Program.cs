using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngülerle_Pratik_Uygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 tane yildiz yazdirma

            //for (int i = 0; i <= 10; i++) 
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 tane yildiz yazdirma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}



            #endregion

            #region Alt alta 10 tane yildiz olusturma Her Satirda 10 yildiz
            //for (int i=0; i<=10; i++)
            //{
            //    for (int a=0; a<=10; a++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Dik Ucgen
            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Ters Dik ucgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Dik ve Ters Dik Ucgen Beraber
            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();    
            //}
            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for(int j = n-1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = n-1;  i >= 1; i--)
            //{
            //    for (int j = n-1;j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1;k <= 2 * i - 1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Piramit
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for(int j = n-i; j> 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();


            //}
            #endregion

            #region Ters Piramit
            int n = 5;

            for(int i = n; i >= 1; i--)
            {
                // bosluklar
                for(int k = n-i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                // yildizlar 
                for(int j = 1 ; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            Console.Read();
        }
    }
}
