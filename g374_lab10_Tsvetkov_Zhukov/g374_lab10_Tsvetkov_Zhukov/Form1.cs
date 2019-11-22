using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g374_lab10_Tsvetkov_Zhukov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_374_Tsvetkov_ZhukovDataSet.FIO' table. You can move, or remove it, as needed.
            this.fIOTableAdapter.Fill(this._374_Tsvetkov_ZhukovDataSet.FIO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new _374_Tsvetkov_ZhukovDataSetTableAdapters.FIOTableAdapter().Update(_374_Tsvetkov_ZhukovDataSet);
            
        }
    }
}
