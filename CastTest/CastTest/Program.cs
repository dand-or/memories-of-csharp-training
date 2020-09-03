using System;

namespace CastTest
{
	class CastTest
	{
		static void Main()
		{
			// 文字コード65の文字を表示する
			char c = (char)65;
			Console.WriteLine(c);

			// 文字Aの文字コードを表示する
			ushort s = (ushort)'A';
			Console.WriteLine(s);

			// キャストして演算
			double  d1 = 1.23 , d2;
			decimal m1 = 4.56M, m2;
			d2 = d1  + (double)m1;  // double型に揃えて演算する
			m2 = (decimal)d1 + m1;  // decimal型に揃えて演算する
			Console.WriteLine("double型に揃えた結果 = {0}\ndecimal型に揃えた結果 = {1}", d2, m2);
		}
	}
}
