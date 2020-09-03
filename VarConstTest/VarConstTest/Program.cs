using System;

namespace VarConstTest
{
	class VarConstTest
	{
		static void Main()
		{
			int a;          // int型お変数aを宣言する（値は代入しない）
			a = 123;        // 変数aに値を代入する

			int b = 456;    // int型の変数bを宣言し、値を代入する
			b = a;          // 変数bに変数aを代入する

			int c = 789, d; // 同じデータ型のc,dを宣言し、cに値を代入する
			d = a + b + c;  // 変数dにa + b + cの演算結果を代入する

			// 変数の値を表示する
			Console.WriteLine("変数の値　　：　a = {0}, b = {1}, c = {2}", a, b, c);
			Console.WriteLine("演算結果の値：　d = " + d);

			// 定数を宣言し初期値を代入する
			const double PI = 3.14;

			// 定数の値を表示する
			Console.WriteLine("定数の値　　：　PI = " + PI);
		}
	}
}
