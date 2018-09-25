using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Game
    {
        public List<Player> Players { get; private set; } // лист игроков
        private List<Card> Deck { get; set; } // колода карт
        
        public Game()
        {                                                 //приводит к CardType 
           
            Deck = new List<Card>();
            Players = new List<Player>();
            foreach (CardTypes t in Enum.GetValues(typeof(CardTypes)))
            {
                foreach (CardValues v in Enum.GetValues(typeof(CardValues)))
                {
                    Deck.Add(new Card(t, v));  //создал карту, запихиваем масти и значение в список карт
                }
            }
        }  
        private void ShuffleDeck() //перетасовка
        {
            Random rnd = new Random();
            for (int k = 0; k <= 10; k++)
            {
                for (int i = Deck.Count - 1; i >= 1; i--)
                {
                    int j = rnd.Next(i + 1);
                    var temp = Deck[j];
                    Deck[j] = Deck[i];
                    Deck[i] = temp;
                }
            }
        }
        private void DistrCards() // раздача карт
        {           
            if (Players.Count<2 || Players.Count>6) // проверка
            {
                throw new Exception("Неправильное количество игроков!");
            } 
            foreach (var p in Players) //чистит карты
            {
                p.Cards.Clear(); // начало игры, у всех нет карт
                p.RoundsPlayed = 0;// у каждого перед началом игры 0 сыгранных раундов
            }
            int i = 0;
            foreach (var c in Deck)
            {                                       //раздает
                Players[i].Cards.Add(c); //в список карт игрока кладу карту
                i++;
                if (i >= Players.Count)
                    i = 0; // проверяет количество игроков, если раздали всем игрокам по 1 карте то начинаем раздавать сначала первому игроку
            }
        }
        public Player Play()
        {
            ShuffleDeck();
            DistrCards();
            while (true) 
            {
                var table = new List<Tuple<Player, Card>>();
                foreach (var p in Players)
                {
                    var playerCard = p.GiveNextCard();
                    if (playerCard == null)
                    {
                        continue; // если нет карт, continue и переходит к след игроку
                    }                   
                    table.Add(new Tuple<Player, Card>(p, playerCard)); // кладем текущего игрока "p" и его карту на стол 
                }
                 // сортирует по убыванию, использует compareto по value.
                var maxTupleCard = table.OrderByDescending(t => t.Item2).First(); //отсортировать table по убывнию и  достань первый элемент тюпла(p,playercard) после сортировке(по значению)
                var roundWinner = maxTupleCard.Item1;  // в roundwinner кладем item1(победителя) из maxTupleCard 
                foreach (var t in table)
                {
                    roundWinner.Cards.Add(t.Item2); // победителю, скормить все карты, которые были на столе 
                }
                Player gameWinner = null;
                foreach (var p in Players) // проверка есть ли победитель
                {
                    if(p.Cards.Count!=0)
                        p.RoundsPlayed++;
                   if (p.Cards.Count == Deck.Count) // если у плейера макс карт, вернуть победителя:
                    {
                        gameWinner =p; // cохранить победителя игры
                    }
                }

                OnRoundPlayed();
                if(gameWinner != null)
                {
                    return gameWinner;
                }
            }
        }
        public event EventHandler RoundPlayed;
        private  void OnRoundPlayed()        {

            if (RoundPlayed !=null)
            {
                RoundPlayed(this, EventArgs.Empty);
            }
        }
    }
}