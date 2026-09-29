using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer_Practice_2
{
    public class PhoneBook
    {
        public Dictionary<string, string> phoneBook = new();

        public string this[string index]
        {
            get
            {
                return phoneBook[index];
            }

            set
            {
                phoneBook[index] = value;
            }
        }
    }
}
