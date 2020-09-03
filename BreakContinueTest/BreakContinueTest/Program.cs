using System;

namespace BreakContinueTest
{
	class BreakContinueTest
	{
		static void Main()
		{
			// キー入力された整数が素数かどうか判定
			Console.Write("整数を入力してください");
			string s1 = Console.ReadLine();
			int n = Int32.Parse(s1);
			string ans1 = "素数です";

			for (int i = 2; i <= (n / 2); i++)
			{
				// 余りが0なら素数ではない
				if (n % i == 0)
				{
					ans1 = "素数ではありません";

					// for文を抜ける
					break;
				}
			}
			Console.WriteLine("{0}は{1}", n, ans1);

			// テストの平均点を求める
			int goukei = 0;		// 得点の合計
			int n1 = 0;			// テストを受けた人数
			int n2 = 0;         // テストを受けなかった人数
			double heikin;      // 平均点

			for (int i = 1; i <= 5; i++)
			{
				Console.Write("学籍番号{0}はテストを受けましたか（Y/N)", i);
				string ans2 = Console.ReadLine();
				if (ans2 != "Y" && ans2 != "y")
				{
					// テストを受けなかった人数をカウント
					n2++;

					// 以降の処理をスキップする
					continue;
				}

				// 得点を入力する
				Console.Write("得点を入力してください");
				string s2 = Console.ReadLine();
				goukei += Int32.Parse(s2);

				// テストを受けた人数をカウント
				n1++;
			}

			// 平均点を表示する
			Console.WriteLine("テストを受けた人数：" + n1);
			if (n1 != 0)
			{
				heikin = goukei / (double)n1;
			}
			else
			{
				heikin = 0;
			}
			Console.WriteLine("平均点：" + heikin);
			Console.WriteLine("テストを受けなかった人数：" + n2);
		}
	}
}
