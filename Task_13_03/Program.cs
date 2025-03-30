using static Task_13_03.Car;

namespace Task_13_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("Иван", "Иванов");
            //Console.WriteLine(student.GetInfo());


            //Student student2 = new Student("Сергей", "Петров", "Иванович", new DateTime(2005, 10, 05));
            //Console.WriteLine(student2.GetInfo());

            Car st = new Car();
            st.Name = "Петр";
            st.Surname = "Иванов";
            st.Patronomyc = null;
            st.Birthday = DateTime.Now;

            Console.WriteLine(st.GetInfo());
        }
    }
}
