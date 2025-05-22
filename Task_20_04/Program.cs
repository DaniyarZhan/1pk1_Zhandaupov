namespace Task_20_04
{
    enum VehicleType
    {
        Car,
        Bike,
        Bus,
        Truck,
        Motorcycle
    }
    internal class Program
    {
        /*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
        • Car
        • Bike
        • Bus
        • Truck
        • Motorcycle
        Храните список транспортных средств (можно просто List<VehicleType>). 
        Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
        Реализуйте поиск по типу и вывод информации.
         */
        static void Main(string[] args)
        {
            List<VehicleType> list = new List<VehicleType>();
            var transport1 = VehicleType.Car;
            
        }
        public int CountCar { get;set; }
        public int CountBike { get; set; }
        public int CountBus { get; set; }
        public int CountTruck { get; set; }
        public int CountMotorcycle { get; set; }
        public void CountType()
        {
            Random random = new Random();
            var transport = (VehicleType)random.Next(0,5);
            if (transport == VehicleType.Car)
                CountCar++;
            else if (transport == VehicleType.Bike)
                CountBike++;
            else if (transport == VehicleType.Bus)
                CountBus++;
            else if(transport == VehicleType.Truck)
                CountTruck++;
            else
                CountMotorcycle++;     
        }
        //public VehicleType GetInfo()
        //{
        //    switch ()
        //    {
        //        case VehicleType.Car:
        //            Console.WriteLine($"Машин - {CountCar}");
        //            return VehicleType.Car;
        //        case VehicleType.Bike:
        //            Console.WriteLine($"Велосипедов - {CountBike}");
        //            return VehicleType.Car;
        //        case VehicleType.Bus:
        //            Console.WriteLine($"Автобусов - {CountBus}");
        //            return VehicleType.Car;
        //        case VehicleType.Truck:
        //            Console.WriteLine($"Грузовиков - {CountTruck}");
        //            return VehicleType.Car;
        //        case VehicleType.Motorcycle:
        //            Console.WriteLine($"Мотоциклов - {CountMotorcycle}");
        //            return VehicleType.Car;
        //    }
            
        //}
    }
}
