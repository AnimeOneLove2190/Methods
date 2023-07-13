using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class TextService
    {
        public string Greetings(string nameOne)
        {
            string helloOne = $"Привет, {nameOne}!";
            return helloOne;
        }
    }
}
