namespace Task_23_02
{
    internal class Program
    {
        /*осуществите полный анализ каталогов в произвольной папке:
        название
        полный путь
        дата создания
        корневой каталог
         */
        static void Main(string[] args)
        {
            Console.Write("Введите путь к существующему каталогу: ");
            string path = Console.ReadLine();
            if (Directory.Exists(path))
            {
                var directory = new DirectoryInfo(path);
                Console.WriteLine($"название: {directory.Name}\nполный путь: {directory.FullName}\n" +
                    $"дата создания: {directory.CreationTime}\nкорневой каталог: {directory.Root}");
            }
            else
            {
                Console.WriteLine("НЕ существует введенного вами каталога!");
            }
        }
    }
}
