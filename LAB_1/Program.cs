using System;
using System.IO;

namespace LAB_1
{
    class Program
    {
		
        static void Main(string[] args)
        {
			//Задание 3 кодирование начато
			string message = File.ReadAllText("message.txt");

			int message_len = message.Length;
			int line = message_len / 5;
			int next_char = 0;
			if (message_len % 5 != 0)
			{
				line += 1;
			}

			string str_key = File.ReadAllText("key.txt");
			int[] key = new int[str_key.Length];
			for (int i = 0; i < str_key.Length; i++)
			{
				key[i] = str_key[i] - '0';
			}
			char[,] changed_message = new char[line, 5];
			for (int i = 0; i < line; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					if (next_char == message_len)
					{
						changed_message[i, j] = 'z';
					}
					else
					{
						changed_message[i, j] = message[next_char];
						next_char++;
					}
				}
			}
			message = "";
			foreach (int j in key)
			{
				for (int i = 0; i < line; i++)
				{
					message += changed_message[i, j - 1].ToString();
				}
			}

			try
			{
				StreamWriter sw = new StreamWriter("new_message.txt");

				sw.WriteLine(message);

				sw.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally
			{
				Console.WriteLine("Окончание записи.");
			}
			//Задание 3 - кодирование окончено

			//Задание 3 - расшифровка начата

			//string message = File.ReadAllText("new_message.txt");

			//int message_len = message.Length;
			//int line = message_len / 5;
			//int next_char = 0;
			//char[,] changed_message = new char[line, 5];

			//string str_key = File.ReadAllText("key.txt");

			//int[] key = new int[str_key.Length];

			//for (int i = 0; i < str_key.Length; i++)
			//{
			//	key[i] = str_key[i] - '0';
			//}

			//foreach (int j in key)
			//{
			//	for (int i = 0; i < line; i++)
			//	{
			//		changed_message[i, j - 1] = message[next_char];
			//		next_char++;
			//	}
			//}

			//for (int i = 0; i < line; i++)
			//{
			//	for (int j = 0; j < 5; j++)
			//	{
			//		Console.Write(changed_message[i, j]);
			//	}
			//}
			//Задание 3 - расшифровка окончена

			////Задание 2 - Подсчёт чистоты начат
			//Byte[] message = File.ReadAllBytes("Veni2.docx");
			//int message_len = message.Length;

			//float[] frq = new float[256]; // каждый элемент массива - частота встречаемости байта в выборке
			//for (int s = 0; s < message_len; s++) //проверяем каждое значние выборки
			//{
			//	frq[message[s]] += 1; // заполняем массив
			//}

			//for (int j = 0; j < 255; j++)
			//{
			//	Console.Write( (j+1).ToString() + " - " + (frq[j] / message_len).ToString());
			//	Console.Write('\n');
			//}
			////Задание 2 - Подсчёт чистоты окончен

			////Задание 1 - чтение файла начато
			//Byte[] buff2 = File.ReadAllBytes("Veni2.docx");
			//Console.WriteLine(buff2.Length);
			////Задание 1 - чтение файла закончено
			///




			////Задание 3 кодирование начато
			//string message = File.ReadAllText("message.txt");

			//int message_len = message.Length;
			//int line = message_len / 5;
			//int next_char = 0;
			//if (message_len % 5 != 0)
			//{
			//	line += 1;
			//}

			//string str_key = File.ReadAllText("key.txt");
			//int[] key = new int[str_key.Length];
			//for (int i = 0; i < str_key.Length; i++)
			//{
			//	key[i] = str_key[i] - '0';
			//}
			//char[,] changed_message = new char[line, 5];
			//for (int i = 0; i < line; i++)
			//{
			//	for (int j = 0; j < 5; j++)
			//	{
			//		if (next_char == message_len)
			//		{
			//			changed_message[i, j] = 'z';
			//		}
			//		else
			//		{
			//			changed_message[i, j] = message[next_char];
			//			next_char++;
			//		}
			//	}
			//}
			//message = "";
			//foreach (int j in key)
			//{
			//	for (int i = 0; i < line; i++)
			//	{
			//		message += changed_message[i, j - 1].ToString();
			//	}
			//}

			//try
			//{
			//	StreamWriter sw = new StreamWriter("new_message.txt");

			//	sw.WriteLine(message);

			//	sw.Close();
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine("Exception: " + e.Message);
			//}
			//finally
			//{
			//	Console.WriteLine("Окончание записи.");
			//}
			//Задание 3 - кодирование окончено

			//Задание 3 - расшифровка начата

			//string message = File.ReadAllText("new_message.txt");

			//int message_len = message.Length;
			//int line = message_len / 5;
			//int next_char = 0;
			//char[,] changed_message = new char[line, 5];

			//string str_key = File.ReadAllText("key.txt");

			//int[] key = new int[str_key.Length];

			//for (int i = 0; i < str_key.Length; i++)
			//{
			//	key[i] = str_key[i] - '0';
			//}

			//foreach (int j in key)
			//{
			//	for (int i = 0; i < line; i++)
			//	{
			//		changed_message[i, j - 1] = message[next_char];
			//		next_char++;
			//	}
			//}

			//for (int i = 0; i < line; i++)
			//{
			//	for (int j = 0; j < 5; j++)
			//	{
			//		Console.Write(changed_message[i, j]);
			//	}
			//}
			//Задание 3 - расшифровка окончена
		}
	}
}
