using System;

namespace OperatorTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// 1行で複数変数に同じ値を
			int a, b, c, d;
			a = b = c = d = 0;
			Console.WriteLine(
				"a = {0},b = {1}, c={2}, d={3}",a,b,c,d);

			// 左シフド
			int e = 0x0F0F0;
			int ans1 = e << 4; ;
			Console.WriteLine(ans1.ToString("X"));
			                  
		    // 右シフド
			int f = 0xF0F0;
			int ans2 = f >> 4; ;
			Console.WriteLine(ans2.ToString("X"));

			// 三項演算子
			int g = -123;
			int ans3 = (g >= 0) ? g : (-g);
			Console.WriteLine(ans3);


			Console.WriteLine(
				"a = {0},b = {1}, c={2}, d={3}", a, b, c, d);

		}
	}
}
