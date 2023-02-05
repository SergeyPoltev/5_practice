namespace practice
{
    internal class Program
    {
        private static int cost = 0;
        static void Main()
        {
            Order form = new Order();
            form.type = new string[]
            {"Круг - ","Квадрат - ", "Сердце - ", "Ромб - "};
            form.cost = new int[]
                {300, 400, 500, 600};

            Order decoration = new Order();
            decoration.type = new string[]
            { "Шоколадный - ", "Ванильный - ","Карамельный - " };
            decoration.cost = new int[]
                {150, 200,300 };

            Order size = new Order();
            size.type = new string[]
            {"Большой - ","Маленький -", "Средний - "};
            size.cost = new int[]
                {300, 150,200 };

            Order korz = new Order();
            korz.type = new string[]
            {"Один - ","Два -","Три - " };
            korz.cost = new int[]
                {300, 350,450 };

            Order[] categories = new Order[] { form, decoration, size, korz };
            vvod(categories);

        }
        static void vvod(Order[] Two)
        {


            int b = 1;
            Order name = new Order(); ;
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Escape)
            {
                ConsoleKeyInfo clav = Console.ReadKey();


                while (clav.Key != ConsoleKey.Enter)
                {
                    if (clav.Key == ConsoleKey.UpArrow)
                    {
                        b--;
                    }
                    else if (clav.Key == ConsoleKey.DownArrow)
                    {
                        b++;
                    }
                    Console.Clear();
                    Console.WriteLine("Заказ тортов в глазури, на ваш выбор");
                    Console.WriteLine("Выберете параметр торта");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("  Форма");
                    Console.WriteLine("  Декор");
                    Console.WriteLine("  Размер");
                    Console.WriteLine("  Количество коржей");
                    Console.WriteLine("Цена: " + cost);
                    Console.WriteLine("  Конец заказа");
                    Console.SetCursorPosition(0, b);
                    Console.WriteLine("->");
                    clav = Console.ReadKey();

                    if (clav.Key == ConsoleKey.Escape)
                    {
                        File.AppendAllText("C:\\Users\\Сергей\\Desktop\\1.txt","\n"+"Заказ от "+DateTime.Now+"\n"+"Цена заказа: "+cost.ToString()+"\n");
                        break;
                    }
                }
                int pos = 0;
                clav = Console.ReadKey();
                while (clav.Key != ConsoleKey.Enter)
                {
                    if (clav.Key == ConsoleKey.UpArrow)
                    {
                        pos--;
                    }
                    else if (clav.Key == ConsoleKey.DownArrow)
                    {
                        pos++;
                    }
                    Console.Clear();

                    for (int i = 0; i < Two[b - 3].cost.Length; i++)
                    {
                        Console.Write("  " + Two[b - 3].type[i]);
                        Console.WriteLine("  " + Two[b - 3].cost[i]);

                    }
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    clav = Console.ReadKey();
                }
                cost += Two[b - 3].cost[pos];
            }
        }
    }
}
