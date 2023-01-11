// See https://aka.ms/new-console-template for more information
using Morseovka;
using System.Text;
MorseCode pep = new MorseCode();
Console.WriteLine(pep.Encode("pepe"));
Console.WriteLine(pep.Decode(".--. . .--. ."));