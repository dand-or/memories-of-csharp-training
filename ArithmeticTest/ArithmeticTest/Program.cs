using System;

namespace ArithmeticTest
{
	class MainClass
	{
		static void Main()
		{
			// 除算の余りを求める
			int a = 10 % 3;
			Console.WriteLine("a =" + a);

			// 符号を反転する
			int b = 123;
			int c = -b;
			Console.WriteLine("c =" + c);

			// 文字列を連結する
			string s1 = "みなさん、";
			string s2 = "こんにちは";
			string s3 = s1 + s2;
			Console.WriteLine("s3 =" + s3);

			// ++演算子を前に置く
			int d = 0;
			int ans = ++d;
			Console.WriteLine("d =" + d);
			Console.WriteLine("ans =" + ans);

			// ++演算子を後に置く
			d = 0;
			ans = d++;
			Console.WriteLine("d =" + d);
			Console.WriteLine("ans =" + ans);


			// --演算子を前に置く
			d = 0;
			ans = --d;
			Console.WriteLine("d =" + d);
			Console.WriteLine("ans =" + ans);

			// --演算子を後に置く
			d = 0;
			ans = d--;
			Console.WriteLine("d =" + d);
			Console.WriteLine("ans =" + ans);
		}
	}
}
