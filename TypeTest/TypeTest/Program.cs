using System;

namespace TypeTest
{
	class MainClass
	{
		static void Main()
		{
			// オブジェクトの互換性をチェック
			object obj = "こんにちは";
			if (obj is string)
			{
				Console.WriteLine("型検査の結果：" + (obj is string));

				// オブジェクトの型変換お行う
				string s = obj as string;
				Console.WriteLine("型変換の結果：" + s);
			}

			// intのサイズを表示
			Console.WriteLine("intのサイズ：" + sizeof(int));

			// intの型を表示
			Console.WriteLine("intの型：" + typeof(int));
		}
	}
}
