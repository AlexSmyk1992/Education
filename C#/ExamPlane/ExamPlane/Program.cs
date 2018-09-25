using System;

namespace ExamPlane
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Тренажер пилота самолета\n");
                Plane plane = new Plane();
                int penaltySave = 0;
                Console.WriteLine("Введите количество диспетчеров:");
                var count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    AddDisp(plane);
                }
                Console.Clear();
                KeyControlHelper();
                Console.WriteLine(plane.GetCurrentState());
                while (true)
                {
                    var k = Console.ReadKey(true);
                    if (k.Key == ConsoleKey.UpArrow)
                    {
                        plane.FlightHigher(k.Modifiers.HasFlag(ConsoleModifiers.Shift));
                    }
                    else if (k.Key == ConsoleKey.DownArrow)
                    {
                        plane.FlightLower(k.Modifiers.HasFlag(ConsoleModifiers.Shift));
                    }
                    else if (k.Key == ConsoleKey.RightArrow)
                    {
                        plane.Acceleration(k.Modifiers.HasFlag(ConsoleModifiers.Shift));
                    }
                    else if (k.Key == ConsoleKey.LeftArrow)
                    {
                        plane.Braking(k.Modifiers.HasFlag(ConsoleModifiers.Shift));
                    }
                    if (!CheckPlaneGrounded(plane, penaltySave))
                    {
                        Console.Clear();
                        foreach (var d in plane.Dispatchers)
                        {
                            Console.WriteLine(d.PrintRecommHeight());
                        }
                        Console.WriteLine(plane.GetCurrentState());
                    }                    
                    if (k.Key == ConsoleKey.D1)
                    {
                        AddDisp(plane);
                    }
                    if (k.Key == ConsoleKey.D2)
                    {
                        DelDisp(plane);
                    }
                    if (k.Key == ConsoleKey.D3)
                    {
                        penaltySave=DelDisp(plane);

                    }
                    if (k.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("Всего доброго! Нажмите 'Enter' для выхода из программы");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
                Console.ReadKey();
            }
        } 
        public static bool CheckPlaneGrounded(Plane p,int pen)
        {
            if (p.Speed == 0 && p.Heigth == 0 && !p.OnGround) // если скорость и высота = 0, и взлетел
            {
                p.OnGround = true;//сел
                Console.Clear();
                Console.WriteLine("Самолет приземлился!");
                int penaltySum = 0;
                for (int i = 0; i < p.Dispatchers.Count; i++)
                {
                    penaltySum = +p.Dispatchers[i].Penalty;
                }
                int penaltyTtotal = penaltySum + pen;
                Console.WriteLine("Общая суммa штрафных баллов - {0}", penaltyTtotal);
                Console.WriteLine("Для выхода из программы, нажмите '0'\n");                
                return true;                
            }
            return false;
        }  
        public static void AddDisp(Plane p)
        {
            Console.WriteLine("Введите имя нового диспетчера:");
            string name = Console.ReadLine();
            Dispatcher disp = new Dispatcher(name);
            p.Dispatchers.Add(disp);
            p.StateChanged += disp.Plane_StateChanged;            
        }
        public static int DelDisp(Plane p)
        {
            Console.WriteLine("Введите имя диспетчера:");            
            string name = Console.ReadLine();
            var delDisp =p.Dispatchers.Find(disp => disp.DispName == name);
            int penaltySaving = delDisp.Penalty;
            p.Dispatchers.RemoveAll(dispDelete=> dispDelete.DispName==name);
            Console.WriteLine("Диспетчер {0} удален.Продолжайте полет!", name);
            Console.WriteLine("Полет продолжится после нажатия клавиш управления:\n");
            return penaltySaving;
        }
        public static void KeyControlHelper()
        {
            Console.WriteLine("Управление самолетом:\n Набор высоты: Uparrow - +250 м, Shift+Uparrow - +500 м\n Снижение высоты: Downarrow - -250м, Shift+Downarrow - -500 м");
            Console.WriteLine(" Ускорение: Rightarrow - +50 км/ч, Shift+Rightarrow - +150 км/ч\n Снижение скорости: Leftarrow - -50 км/ч, Shift+Leftarrow - -150 км/ч");
            Console.WriteLine("Для добавления нового диспетчера, нажмите '1'\n");
            Console.WriteLine("Для удаления диспетчера, нажмите '2'\n");
            Console.WriteLine("Для вывода подсказок клавиш управления, нажмите '3'\n");
            Console.WriteLine("Для выхода из программы, нажмите '0'\n");
            Console.WriteLine("Полет начнется после нажатия клавиш управления:\n");
        }
    }
}