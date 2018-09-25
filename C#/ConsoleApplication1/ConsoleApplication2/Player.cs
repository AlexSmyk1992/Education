using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Player
    {
        private Random _rnd = new Random();
        public int RoundsPlayed { get; set; }
        public int Number
        {
            get;
            private set;
        }
        public List<Card> Cards { get; private set; }

        public Player(int n)
        {
            Cards = new List<Card>();
            Number = n;
        }
        public Card GiveNextCard()
        {
            if (Cards.Count == 0)
                return null;   //если список карт пуcтой - возвращает null
            int j = _rnd.Next(Cards.Count);
            var c = Cards[j]; // в "с" поместили карту из карт игрока            
            Cards.RemoveAt(j); //удалили ее из списка карт игрока
            return c; //возвращаем ее, для последующего добавления в <tuple>
        }
        public override string ToString()
        {
            return String.Format("{0} Player: Количество карт-{1}", Number, Cards.Count);
        }
    }
}