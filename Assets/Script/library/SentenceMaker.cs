using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class SentenceMaker
    {
        private int num;

        public string getSentence()
        {
            num++;
            switch (num)
            {
                case 1: return "ABCDE";
                case 2: return "HOGE";
                case 3: return "TEST";
                case 4: return "AAAA";
                case 5: return "DEDEDE";
                default: return "";
            }
        }
    }
}
