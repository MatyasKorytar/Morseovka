using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morseovka
{
    class MorseCode
    {
        public Dictionary<char, string> 
        _encodeDictionary = new Dictionary<char, string>()
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

        public Dictionary<string, char> 
        _decodeDictionary = new Dictionary<string, char>();

        public MorseCode()
        {

            foreach (var entry in _encodeDictionary)
            {
                _decodeDictionary.Add(entry.Value, entry.Key);
            }
        }

        public string Encode(string text)
        {
            text = text.ToLower();
            StringBuilder sb = new StringBuilder();

            foreach (var c in text)
            {
                if (_encodeDictionary.ContainsKey(c))
                {
                    sb.Append(_encodeDictionary[c] + " ");
                }
            }

            return sb.ToString().Trim();
        }

        public string Decode(string code)
        {
            StringBuilder sb = new StringBuilder();
            var symbols = code.Split(' ');

            foreach (var symbol in symbols)
            {
                if (_decodeDictionary.ContainsKey(symbol))
                {
                    sb.Append(_decodeDictionary[symbol]);
                }
            }

            return sb.ToString();
        }
    }

}
