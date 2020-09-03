using System;

namespace BoolTest
{
	class MainClass
	{
		static void Main()
		{
			// bool型い対する論理演算子
			int a = 1;
			int b = 2;
			if ((a > 0) && (b > 0))
			{
				Console.WriteLine("if文の処理");
			}

			while ((a > 0) || (b > 0))
			{
				Console.WriteLine("while文の処理");
				a--;
				b--;
			}

			// 整数データを対象とした論理演算子
			int c;
			c = 0xAF & 0xF0;    // 下位桁をゼロクリアする
			Console.WriteLine(c.ToString("X"));
			                  
			c = 0xB0 | 0x0F;    // 下位桁い1をセット
			Console.WriteLine(c.ToString("X"));

			c = 0xCF ^ 0x0F;    // 下位桁を反転
			Console.WriteLine(c.ToString("X"));

			c = ~0x0F0F0F0F;    // 全ての桁を反転する
			Console.WriteLine(c.ToString("X"));
		}
	}
}
