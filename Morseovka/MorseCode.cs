using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morseovka
{
    class MorseCode
    {
        public Dictionary<char, string> EncodeSlovnik = new Dictionary<char, string>()
    {
        {'a', ".-"},
        {'b', "-..."},
        {'c', "-.-."},
        {'d', "-.."},
        {'e', "."},
        {'f', "..-."},
        {'g', "--."},
        {'h', "...."},
        {'i', ".."},
        {'j', ".---"},
        {'k', "-.-"},
        {'l', ".-.."},
        {'m', "--"},
        {'n', "-."},
        {'o', "---"},
        {'p', ".--."},
        {'q', "--.-"},
        {'r', ".-."},
        {'s', "..."},
        {'t', "-"},
        {'u', "..-"},
        {'v', "...-"},
        {'w', ".--"},
        {'x', "-..-"},
        {'y', "-.--"},
        {'z', "--.."},
        {'0', "-----"},
        {'1', ".----"},
        {'2', "..---"},
        {'3', "...--"},
        {'4', "....-"},
        {'5', "....."},
        {'6', "-...."},
        {'7', "--..."},
        {'8', "---.."},
        {'9', "----."}
    };

        public Dictionary<string, char> DekoderSlovnik = new Dictionary<string, char>();

        public MorseCode()
        {
            foreach (var entry in EncodeSlovnik)
            {
                DekoderSlovnik.Add(entry.Value, entry.Key);
            }
        }

        public string Encode(string text)
        {
            StringBuilder Final = new StringBuilder();

            foreach (var x in text)
            {
                if (EncodeSlovnik.ContainsKey(x))
                { 
                    { Final.Append(EncodeSlovnik[x] + " "); }
                }
            }

            return Final.ToString();
        } 

        public string Decode(string morseovka)
        {
            StringBuilder Final = new StringBuilder();
            var Moorseovka = morseovka.Split(' ');
            foreach (var x in Moorseovka)
            {
                if (DekoderSlovnik.ContainsKey(x))
                {
                    Final.Append(DekoderSlovnik[x]);
                }
            }

            return Final.ToString();
        }
    }

}
