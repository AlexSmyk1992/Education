using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApplication2
{
    class Program
    {
        public static List<Player> Loosers;
        private static int RoundsCount;
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var g = new Game();
            Console.WriteLine("сколько игроков?");
            g.RoundPlayed += RoundPlayedHandler;
            int pCount; //количество игроков
            if (!Int32.TryParse(Console.ReadLine(), out pCount))
            {
                Console.WriteLine("Неверный ввод");
                return;
            }
            for (int i = 0; i < pCount; i++)
            {
                g.Players.Add(new Player(i + 1));
            }
            RoundsCount = 0;
            Loosers = new List<Player>();
            var winner = g.Play();
            Console.WriteLine("Победитель - {0}", winner.Number);
            Console.WriteLine("Количество ходов - {0}", RoundsCount);
            foreach (var l in Loosers)
            {
                Console.WriteLine("Проигравший - {0} за {1} раундов", l.Number, l.RoundsPlayed + 1); // выводит проигравшего, в RoundPlayedHandler добавляет
            }
            TimeOfGameEnder(stopWatch);
            Console.ReadLine();
        }
        private static void RoundPlayedHandler(object sender, EventArgs e)
        {
            RoundsCount++;
            var g = (Game)sender; // передали класс game заполненый(карты игроки и тд)
            Console.WriteLine("Раунд: " + RoundsCount); //
            foreach (var p in g.Players)
            {

                if (p.Cards.Count == 0 && !Loosers.Contains(p)) //Если у игрока нет карт и он не в списке лузеров добавить в лузера
                    Loosers.Add(p);
                Console.Write(p + " ");//тоже самое /*Console.Write(p + " ") = p.ToString()+" "*/!!!!!!!!!!!!!!!!!!!! write когда мы в Player переопределили p.to.String вызывает как там переопределено
            }

            Console.WriteLine();
        }
        private static void TimeOfGameEnder(Stopwatch stopWatch)
        {
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Время игры: " + elapsedTime);
        }
    }
}