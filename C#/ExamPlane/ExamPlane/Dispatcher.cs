using System;

namespace ExamPlane
{
    class Dispatcher
    {
        public string DispName { get; set; }
        public int RecommHeight { get; private set; }
        public int WeatherRand { get; private set; }
        public int Penalty { get; set; }
        private static Random _rnd = new Random();

        public Dispatcher(string dispName)
        {           
            WeatherRand = _rnd.Next(-200, 200);
            DispName = dispName; 
        }   
        public void RecommHeightCalc(int speed)
        {
            RecommHeight = ((7 * speed) - WeatherRand);            
        }
        public string PrintRecommHeight()
        {
            return String.Format("Диспетчер {0} Рекомендуемая высота {1} м, штрафные очки: {2}", DispName, RecommHeight, Penalty);
        }
        public void PenaltyCalc(int height,int speed)
        {
            var diffHeight = Math.Abs(height - RecommHeight);
            var diffSpeed = speed - 1000;
            if (diffHeight < 600 && diffHeight > 300)
            {
                Penalty += 25;
            }
            if (diffHeight < 1000 && diffHeight > 600)
            {
                Penalty += 50;
            }
            if (diffHeight > 1000)
            {
                throw new Exception("Самолет разбился!");
            }
            if (diffSpeed > 0)
            {
                Console.WriteLine("Немедленно снизьте скорость!");
                Penalty += 100;
            }
            if (Penalty >= 1000)
            {
                throw new Exception("Непригоден к полетам!");
            }            
        }        
        public void Plane_StateChanged(object sender, EventArgs e) //принимает в sender объект Plane
        {
            var p = (Plane)sender;
            if (p.Speed >= 50)
            {
                RecommHeightCalc(p.Speed);  
                PenaltyCalc(p.Heigth, p.Speed);               
            }
            if (p.Heigth < 0)
            {
                throw new Exception("Самолет разбился!");
            }            
        }
    }
}