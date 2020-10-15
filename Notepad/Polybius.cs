using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public class Polibian
    {

        static List<List<string>> polybius = new List<List<string>>{

          new List<string>{ "A", "B", "C", "D", "E"},

          new List<string> {"F", "G", "H", "I", "K"},

          new List<string> {"L", "M", "N", "O", "P"},

          new List<string> {"Q", "R", "S", "T", "U"},

           new List<string>{"V", "W", "X", "Y", "Z"}
        };

        static public string encodeText(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < 5; ++j)
                {
                    for (int k = 0; k < 5; ++k)
                    {
                        if (polybius[j][k] == text[i].ToString())
                            result += polybius[(j + 1) % 5][k];
                    }
                }
            }
            return result;
        }

        static public string decodeText(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < 5; ++j)
                {
                    for (int k = 0; k < 5; ++k)
                    {
                        if (polybius[j][k] == text[i].ToString())
                            result += polybius[(j + 4) % 5][k];
                    }
                }
            }
            return result;
        }
    }
}
