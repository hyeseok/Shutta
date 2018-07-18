using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public abstract class Scorer
    {
        /// <summary>
        /// 승자를 찾는다.
        /// </summary>
        /// <param name="p0">플레이어 0</param>
        /// <param name="p1">플레이어 1</param>
        /// <returns>두 플레이어 중 승자를 반환. 만약 무승부면 null을 반환</returns>
        public Player GetWinner(Player p0, Player p1)
        {
            int score0 = CalculateScore(p0);
            int score1 = CalculateScore(p1);

            if (score0 > score1)
                return p0;
            else if (score1 > score0)
                return p1;
            else
                return null;
        }

        private int _starategyType;

        protected abstract int CalculateScore(Player p);
    }
}
