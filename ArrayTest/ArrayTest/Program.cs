using System;

namespace ArrayTest
{
	class ArrayTest
	{
		static void Main()
		{
			// 要素数5個の1次元配列を宣言する
			int[] a = new int[5];

			// 配列の要素に値を代入する
			a[0] = 10;
			a[1] = 20;
			a[2] = 30;
			a[3] = 40;
			a[4] = 50;

			// 5つの要素の平均値を求めて表示する
			int goukei = 0;
			double heikin;
			for (int i = 0; i < a.Length; i++)
			{
				goukei += a[i];
			}
			heikin = goukei / (double)a.Length;
			Console.WriteLine("平均値：" + heikin);

			// 要素数3*2≡6の2次元配列を宣言し初期化する
			int[,] b = { { 10, 20, 30 }, { 40, 50, 60 } };

			// １行２列目の要素を表示する
			Console.WriteLine("１行２列目：" + b[1, 2]);

			// ジャグ配列を宣言し初期化する
			int[][] d = new int[4][];
			d[0] = new int[] { 10, 20, 30 };
			d[1] = new int[] { 11, 12, 13, 14, 54 };
			d[2] = new int[] { 21, 22 };
			d[3] = new int[] { 31, 32, 33, 34 };

			// 1番目の配列の要素数を表示
			Console.WriteLine("1番目の愛列の要素数：" + d[1].Length);

			// 1番目の配列の4番目の要素を表示
			Console.WriteLine("1番目の配列の4番目の要素：" + d[1][4]);
		}
	}
}
