using System;

namespace ArrayClassTest
{
	class MainClass
	{
		static void Main()
		{
			// ソートされてない配列を用意
			int[] a = { 2, 4, 1, 666, 34, 232, 10, 1000, 5 };

			// 昇順にソートした結果を表示
			Console.Write("昇順ソート：");
			Array.Sort(a);
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + ",");
			}
			Console.WriteLine();

			// ここからリバースすることで降順ソート
			Console.Write("降順ソート：");
			Array.Reverse(a);
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + ",");
			}
			Console.WriteLine();
		}
	}
}
