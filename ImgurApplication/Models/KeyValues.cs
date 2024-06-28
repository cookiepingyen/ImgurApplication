using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApplication.Models
{
    public class KeyValues
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public string ValueString { get; set; }

        public KeyValues(string Key, int Value)
        {
            this.Key = Key;
            this.Value = Value;
        }

        public KeyValues(string Key, string ValueString)
        {
            this.Key = Key;
            this.ValueString = ValueString;
        }
    }
}
