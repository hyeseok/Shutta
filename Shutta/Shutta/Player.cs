using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public class Player
    {
        public Player(int no)
        {
            No = no;
            Money = 500;
        }
        public int No;
        public int Money;

        public List<Card> cards = new List<Card>();

        public void TakeCard(Card card)
        {
            cards.Add(card);
        }
    }
}