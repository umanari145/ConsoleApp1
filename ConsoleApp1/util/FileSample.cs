using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1.util
{
    class FileSample
    {
        public FileSample()
        {
            Console.WriteLine(System.Environment.CurrentDirectory);
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());

			char delimiter = Path.DirectorySeparatorChar;
			string filePath = @System.Environment.CurrentDirectory + $"{delimiter}storage{delimiter}data.txt";

			//読み込み
			//this.readFile(filePath);
			//１行ずづの読み込み
			//this.readSingleFile(filePath);
			//更新
			this.updateFile(filePath);
		}

		//１行ずつ
        public void readFile(string filePath)
        {
			try
			{
				//Console.WriteLine(filePath);
				// 読み込みたいテキストを開く
				using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("UTF-8")))
				{
					// テキストファイルをString型で読み込みコンソールに表示
					String line = sr.ReadToEnd();
					Console.WriteLine(line);
				}
			}
			catch (IOException e)
			{
				// ファイルを読み込めない場合エラーメッセージを表示
				Console.WriteLine("ファイルを読み込めませんでした");
				Console.WriteLine(e.Message);
			}
		}

		public void readSingleFile(string filePath)
        {
			try
			{
				// 読み込みたいテキストを開く
				using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("UTF-8")))
				{
					// テキストファイルをString型で読み込みコンソールに表示
					while (sr.Peek() != -1)
					{
						Console.WriteLine(sr.ReadLine());
						Console.WriteLine("1行終わり");
					}
				}
			}
			catch(IOException e)
			{
				// ファイルを読み込めない場合エラーメッセージを表示
				Console.WriteLine("1行ずつファイルを読み込めませんでした");
				Console.WriteLine(e.Message);
			}
		}

		public void updateFile(string filePath)
		{
			try
			{
				// 読み込みたいテキストを開く
				using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("UTF-8")))
				{
					sw.WriteLine("本日は晴天なり");
				}
			}
			catch (IOException e)
			{
				// ファイルを読み込めない場合エラーメッセージを表示
				Console.WriteLine("1行ずつファイルをかきこめませんでした");
				Console.WriteLine(e.Message);
			}
		}
	}
}
