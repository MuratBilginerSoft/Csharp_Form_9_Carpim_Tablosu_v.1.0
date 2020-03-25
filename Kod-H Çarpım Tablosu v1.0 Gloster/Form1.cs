using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kod_H_Çarpım_Tablosu_v1._0_Gloster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x;

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    x = j * i;
                    string a = i + "*" + j + "=" + x;
                    listBox1.Items.Add(a);
                }
                listBox1.Items.Add("\n");
            }
        }
    }
}
