using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public class Card
    {
        public int Number;
        public bool IsKwang;

        public string ToText()
        {
            string text = Number.ToString(); //ex) 3 -> "3"

            if (IsKwang)
            {
                text += "K";
            }
            return text;
        }
    }
}