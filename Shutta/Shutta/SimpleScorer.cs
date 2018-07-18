using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    class SimpleScorer : Scorer
    {
        protected override int CalculateScore(Player p)
        {
            return p.cards[0].Number + p.cards[1].Number;
        }
    }
}
