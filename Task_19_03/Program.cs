﻿using System.IO;

namespace Task_19_03
{
    internal class Program
    {
        /*3.Напишите консольное приложение, 
         * в котором осуществляется построчный пользовательский ввод 
         * (ввод каждой строки подтверждается нажатием на enter). 
         * количество введенных строк произвольно, ввод завершается при вводе пустой строки. 
            После окончания ввода произведите объединение всех ранее 
            введенных строк в одну с использованием разделителя «-»
            Например:
            Введите строку 1: "Hello"
            Введите строку 2: "world"
            Введите строку 3: "C#"
            Результат: "Hello-world-C#"
         */
        static void Main(string[] args)
        {
            int i = 1;//ввод перечисления для строк
            string result = "";
            //построчный ввод строк
            while (true)
            {
                Console.Write($"Введите строку {i}: ");
                string str = Console.ReadLine();
                if (str == "")
                {            
                    break;
                }
                i++;
                result = string.Join("-", new string[] { result, str });                
            }            
            //вывод строк в одну
            Console.WriteLine($"Результат: {result.Trim('-')}");
        }
    }
}
