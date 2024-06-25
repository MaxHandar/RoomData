using System;
using RoomData;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрос имени комнаты, высоты и количества стен/окон/дверей у пользователя
            Console.WriteLine("Введите имя комнаты:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите высоту комнаты:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество стен в комнате:");
            int numberOfWalls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество окон в комнате:");
            int numberOfWindows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество дверей в комнате:");
            int numberOfDoors = Convert.ToInt32(Console.ReadLine());

            // Инициализация комнаты
            Room RoomExample = new Room(name, height, numberOfWalls, numberOfWindows, numberOfDoors);
            RoomExample.SetWalls();
            RoomExample.SetDoors();
            RoomExample.SetWindows();
            RoomExample.CalculateFloorPerimeter();
            RoomExample.CalculateFloorArea();
            RoomExample.CalculateWallsArea();

            // Задание параметров стен
            foreach (var wall in RoomExample.Walls)
            {
                Console.WriteLine($"точка перес. - ({wall.ConnectionPoint.X} ,{wall.ConnectionPoint.Y} ):  ширина - {wall.Width}; угол - {wall.AngleToNextWall}");
            }

            // Вывод информации о комнате
            Console.WriteLine($"Комната '{RoomExample.Name}' инициализирована с площадью пола {RoomExample.FloorArea}, площадью стен - {RoomExample.WallsArea} и периметром {RoomExample.FloorPerimeter}");
        }
    }
}
