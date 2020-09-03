using System;

namespace LoopTest
{
	class MainClass
	{
		static void Main()
		{
			int[] a = { 10, 20, 30, 40, 50 };
			int sum;

			// for文を使った集計
			sum = 0;
			for (int i = 0 ; i < a.Length ; i++)
			{
				sum += a[i];
			}
			Console.WriteLine("for total = " + sum);

			// foreachを使った集計
			sum = 0;
			foreach (int buf in a)
			{
				sum += buf;
			}
			Console.WriteLine("foreach total = " + sum);

			// 入れ子のforループでかけ算九九
			for (int i = 1; i <= 9; i++)
			{
				Console.Write(i + "の段：");
				for (int j = 1; j <= 9; j++)
				{
					Console.Write((i * j) + " ");
				}
				Console.WriteLine();
			}

			// 入れ子ループで２次元配列を集計
			int [,] b = { {10,20,30,40,50}
					   	 ,{11,21,31,41,51}
						 ,{12,22,32,42,52}};
			sum = 0;
			for (int i = 0; i < b.GetLength(0); i++)
			{
				for (int j = 0; j < b.GetLength(1); j++)
				{
					sum += b[i, j];
				}
			}
			Console.WriteLine("２次元配列集計：" + sum);
		}		
	}
}
