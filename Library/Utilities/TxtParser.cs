using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public class TxtParser
    {
        private static char delimiter = ':';

        // funkcija ParseTxtFile vraca recnik parsiranih vrednosti gde je kljuc naziv funckije, a vrednost je konekcioni string
        public static Dictionary<string, string> ParseTxtFile(string filePath)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    int indexOfDelimiter = line.IndexOf(delimiter);

                    if (indexOfDelimiter != -1)
                    {
                        string key = line.Substring(0, indexOfDelimiter).Trim();             
                        string value = line.Substring(indexOfDelimiter + 1).Trim();
        
                        dictionary[key] = value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error with parsing txt! " + ex.Message);
            }

            return dictionary;
        }
    }
}
