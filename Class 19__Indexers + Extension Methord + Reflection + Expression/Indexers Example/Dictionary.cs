using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers_Example
{
    public class Dictionary
    {
        private Dictionary<string, string> data = new();

        public string this[string key]
        {
            get => data[key];
            set => data[key] = value;
        }
    }
}
