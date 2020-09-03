using System;

namespace Int32DoubleTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int a, b;
			string s;

			// キーボードあら２つの数値を入力する
			s = Console.ReadLine();
			a = Int32.Parse(s);
			s = Console.ReadLine();
			b = Int32.Parse(s);

			// 加算結果お10進数と16進数で表示
			int c = a + b;
			Console.WriteLine("加算結果10進数：" + c.ToString());
			Console.WriteLine("加算結果16進数：" + c.ToString("X"));

			// 加算結果の逆数をdouble型で求め、指数形式で表示する
			double d = 1.0 / c;
			Console.WriteLine("逆数を指数形式で表示：" + d.ToString("E"));
		}
	}
}
