using System.Runtime.InteropServices;

namespace Task_23_01
{
    internal class Program
    {
        /*пользователь вводит путь к существующему каталогу, 
         * строку с названием новой папки и число - определяющее количество создаваемых каталогов.
         * в сущесвующем каталоги создаются папки с введенным названием и нужным количество. 
         * к концу имени каталога примисывается число - уникальный номер каталога
         */
        static void Main(string[] args)
        {
            Console.Write("Введите путь к существующему каталогу: ");
            string path = Console.ReadLine();
            Console.Write("Введите название новой папки: ");
            string name = Console.ReadLine();
            Console.Write("Введите количество новых папок: ");
            int count = Convert.ToInt32(Console.ReadLine());

            if (Directory.Exists(path))
            {
                DirectoryInfo rootPath = new DirectoryInfo(path);
                for (int i = 1; i <= count; i++)
                {
                    rootPath.CreateSubdirectory(name + i);
                }
            } 
            else
            {
                Console.WriteLine("НЕ существует введенного вами каталога!");
            }
        }
    }
}
