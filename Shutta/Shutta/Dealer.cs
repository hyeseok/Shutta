// architecture (HTML + CSS)
// coder
// programmer (developer)
// architecture
// tester (!= Quality Assurance), Unit Test
// Project Manager / Product Manager

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
            _cards.Clear(); // 20개씩 만든 카드를 초기화해서 다시 1번째 배열부터 정렬
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
            }
                _cards = _cards.OrderBy(x => Guid.NewGuid()).ToList();
                _currentIndex = 0;
        }// end of Shuffle()

        //카드 1장 주기1
        private int _currentIndex = 0;
        
        public Card GetCard()
        {
            Card card = _cards[_currentIndex];
            _currentIndex++;
            //Console.WriteLine($"인덱스 갯수는 : {_currentIndex}");
            return card;
        }
    }
}