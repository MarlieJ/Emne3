using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Letter
    {
        public string Text { get; private set; }
        public Character LetterSender { get; private set; }
       // public Character LetterReciever { get; private set; }
        public Letter(string text, Character lettersender)
        {
            Text = text;
            LetterSender = lettersender;
           // LetterReciever = letterReciever;

        }
    }
}
