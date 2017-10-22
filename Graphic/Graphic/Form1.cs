using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Graphic
{
    public partial class SelectionSort : Form
    {

        public SelectionSort()
        {
            
            InitializeComponent();
            
        }
        
        void spflash()
        {
            Application.Run(new Form2());
        }

        private void SelectionSort_Load(object sender, EventArgs e)
        {
            btnSort.Enabled = false;
        }
        int n;
        onekey[] A;
        Button[] btn;
        Random rdn = new Random();
        //public int speed = 1;
        public int giancach = 0;
        void creatkey()
        {
            n = int.Parse(textBox1.Text);
            giancach = ((pnBoard.Width - (n * 50)) / (n + 1));
            A = new onekey[n];
            btn = new Button[n];
            Point p = new Point(giancach, (pnBoard.Height / 2)-25);

            for (int i = 0; i < n; i++)
            {
                int gt;
                gt = rdn.Next(1, 30);
                A[i] = new onekey(gt, i, p);
                p = new Point(A[i].p.X + 50 + giancach, A[i].p.Y);
            }
            for (int i = 0; i < n; i++)
            {
                btn[i] = new Button();
                btn[i].BackColor = Color.YellowGreen;
                btn[i].Text = Convert.ToString(A[i].giatri);
                btn[i].Location = A[i].p;
                btn[i].Size = new Size(50, 50);
            }
        }
        void loadpanel()
        {
            for (int i = 0; i < n; i++)
            {
                pnBoard.Controls.Add(btn[i]);
            }
        }
        private void btnCreat_Click(object sender, EventArgs e)
        {
            pnBoard.Controls.Clear();
            creatkey();
            loadpanel();
            btnSort.Enabled = true;
        }
        public int kc = 0;
        public int i = 0;
        public int k1 = 0;
        public int k2 = 0;
        public void dichuyen()
        {
                kc = Math.Abs(btn[A[k1].vt].Location.X - btn[A[k2].vt].Location.X);
                for (int i = 0; i < 50; i = i + 2)
                {
                    //CheckForIllegalCrossThreadCalls = false;
                    btn[A[k1].vt].Location = new Point(btn[A[k1].vt].Location.X, btn[A[k1].vt].Location.Y + 2);
                    btn[A[k2].vt].Location = new Point(btn[A[k2].vt].Location.X, btn[A[k2].vt].Location.Y - 2);
                    Task.Delay(1).Wait();
                }
                for (int i = 0; i < kc; i = i + 2)
                {
                btn[A[k1].vt].Location = new Point(btn[A[k1].vt].Location.X + 2, btn[A[k1].vt].Location.Y);
                    btn[A[k2].vt].Location = new Point(btn[A[k2].vt].Location.X - 2, btn[A[k2].vt].Location.Y);
                    Task.Delay(1).Wait();

                }
                for (int i = 0; i < 50; i = i + 2)
                {
                btn[A[k1].vt].Location = new Point(btn[A[k1].vt].Location.X, btn[A[k1].vt].Location.Y - 2);
                    btn[A[k2].vt].Location = new Point(btn[A[k2].vt].Location.X, btn[A[k2].vt].Location.Y + 2);
                    Task.Delay(1).Wait();
                }
                onekey temp;
                temp = A[k1];
                A[k2] = A[k1];
                A[k1] = temp;
                A[k1].p = btn[A[k1].vt].Location;
                A[k2].p = btn[A[k2].vt].Location;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        public void Selectionsort(onekey[] A, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j].giatri < A[minPos].giatri) minPos = j;
                }
                if (minPos != i)
                {
                    k1 = i;
                    k2 = minPos;
                    dichuyen();
                }
            }
            MessageBox.Show("Da sap xep xong!");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Selectionsort(A, n);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
        }
        
    }
}
