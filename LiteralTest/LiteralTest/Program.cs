using System;

namespace LiteralTest
{
	class LiteralTest
	{
		static void Main()
		{
			// 指数形式の数値リテラル
			double a = 123e-2;
			Console.WriteLine(a);

			// 16進数形式の数値リテラル
			int b = 0x12AB;
			Console.WriteLine(b);

			// エスケープシーケンスを含んだ文字列リテラル
			string c = "みなさん\nこんにちは";
			Console.WriteLine(c);

			// エスケープシーケンスを無視させた文字列リテラル
			string d = @"みなさん\nこんにちは";
			Console.WriteLine(d);

			// bool型リテラル
			bool e = true;
			bool f = false;
			Console.WriteLine(e);
			Console.WriteLine(f);

		}
	}
}

/*
macではエスケープ文字について¥と\が区別されるらしく、\を使用する必要がありそう
\はopetion + ¥ で出せる
*/