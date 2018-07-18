using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public class Dealer
    {
        //public Card[] Cards = new Card[20];
        private List<Card> _cards = new List<Card>(); 

        private List<int> _kwangNumbers = new List<int> { 1, 3, 8 };

        //카드 섞기 구현
        public void Shuffle()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Card card = new Card();
                    card.Number = i+1;
                    card.IsKwang = false;

                    if (j == 0)
                    {
                        if (_kwangNumbers.Contains(card.Number))
                            card.IsKwang = true;

                        _cards.Add(card);
                    }
                }

                _cards = _cards.OrderBy(x => Guid.NewGuid()).ToList();

                _index = 0;
            }
        }// end of Shuffle()

        //카드 1장 주기1
        private int _index = 0;
        
        public Card GetCard()
        {
            Card card = _cards[_index];
            _index++;
            return card;
        }
    }
}