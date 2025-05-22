using System.Xml.Linq;

namespace Task_23_03
{
    internal class Program
    {
        /*в произвольном каталоге удалите все вложенные каталоги с игнорированием наличия содержимого
         */
        static void Main(string[] args)
        {
            Console.Write("Введите путь к существующему каталогу: ");
            string path = Console.ReadLine();
            DirectoryInfo rootDirectory = new DirectoryInfo(path);
            if (rootDirectory.Exists)
            {
                List<DirectoryInfo> directories = rootDirectory.GetDirectories().ToList();
                foreach (DirectoryInfo d in directories)
                {
                    d.Delete(true);
                }
            }
            else
            {
                Console.WriteLine("НЕ существует введенного вами каталога!");
            }
        }
    }
}
