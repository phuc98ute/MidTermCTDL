using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        public int x=-1;

        private void Form2_Load(object sender, EventArgs e)
        {
            cbboxList.Items.Add("Auto");
            cbboxList.Items.Add("Mannual");
            cbboxList.SelectedItem = "Auto";
        }



        private void cbboxList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if((cbboxList.SelectedItem).ToString()=="Auto")
            {
                x = 0;
                return;
            }
            if((cbboxList.SelectedItem).ToString() == "Mannual")
            {
                x = 1;
            }
        }
    }
}
