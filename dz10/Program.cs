using System;

class Program
{
    static void Main(string[] args)
    {
        Avto bmw = new BMW();
        Avto toyota = new Toyota();

        while (true)
        {
            Console.WriteLine("1: Газувати BMW");
            Console.WriteLine("2: Тормозити BMW");
            Console.WriteLine("3: Газувати Toyota");
            Console.WriteLine("4: Тормозити Toyota");
            Console.WriteLine("5: Газувати обидва автомобiлi");
            Console.WriteLine("6: Тормозити обидва автомобiлi");
            Console.WriteLine("7: Показати швидкiсть BMW");
            Console.WriteLine("8: Показати швидкiсть Toyota");
            Console.WriteLine("9: Показати швидкiсть обох автомобiлiв");
            Console.WriteLine("0: Вийти");

            Console.Write("Введiть команду: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    bmw.Gazui();
                    Console.WriteLine("Ви натиснули на газ BMW!");
                    break;
                case "2":
                    bmw.Tormozi();
                    Console.WriteLine("Ви натиснули на гальма BMW!");
                    break;
                case "3":
                    toyota.Gazui();
                    Console.WriteLine("Ви натиснули на газ Toyota!");
                    break;
                case "4":
                    toyota.Tormozi();
                    Console.WriteLine("Ви натиснули на гальма Toyota!");
                    break;
                case "5":
                    bmw.Gazui();
                    toyota.Gazui();
                    Console.WriteLine("Ви натиснули на газ обох автомобiлiв!");
                    break;
                case "6":
                    bmw.Tormozi();
                    toyota.Tormozi();
                    Console.WriteLine("Ви натиснули на гальма обох автомобiлiв!");
                    break;
                case "7":
                    Console.WriteLine($"Швидкiсть BMW: {bmw.Shvudkist}");
                    break;
                case "8":
                    Console.WriteLine($"Швидкiсть Toyota: {toyota.Shvudkist}");
                    break;
                case "9": 
                    Console.WriteLine($"Швидкiсть BMW: {bmw.Shvudkist}");
                    Console.WriteLine($"Швидкiсть Toyota: {toyota.Shvudkist}");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Невiрна команда!");
                    break;
            }

            Console.WriteLine();
        }
    }
}



