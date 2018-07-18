using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public class BasicScorer : Scorer
    {
        private int _starategyType;
        protected override int CalculateScore(Player p)
        {

            if (_starategyType == 0)
            {
                return p.cards[0].Number + p.cards[1].Number;
            }
            else if (_starategyType == 1)
            {
                int score = p.cards[0].Number + p.cards[1].Number;
                score = score % 10;

                if (p.cards[0].Number == p.cards[1].Number)
                    score += 100;

                if (p.cards[0].IsKwang && p.cards[1].IsKwang)
                    score += 10000;

                return score;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
