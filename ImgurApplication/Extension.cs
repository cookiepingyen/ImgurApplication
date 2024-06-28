using ImgurApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurApplication
{
    public static class Extension
    {

        public static void SetCombox(this ComboBox comboBox, List<KeyValues> list, string value = "Value")
        {
            comboBox.DataSource = list;
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = value;
        }


    }
}
