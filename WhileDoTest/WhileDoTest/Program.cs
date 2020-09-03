using System;

namespace WhileDoTest
{
	class MainClass
	{
		static void Main()
		{
			// whileでforっぽくするbad code
			int[] a = { 10, 20, 30, 40, 50 };
			int sum = 0;
			int i = 0;
			while (i < a.Length)
			{
				sum += a[i];
				i++;
			}
			Console.WriteLine(sum);

			// do whileで1,2,3いずれかが入力されるまで繰り返す処理
			int ans;
			string s;
			do
			{
				Console.WriteLine("1,2,3のいずれかを入力してください");
				s = Console.ReadLine();
				ans = Int32.Parse(s);
			} while (ans < 1 || ans > 3);
			Console.WriteLine("あなたが選んだ値：" + ans);
		}
	}
}
