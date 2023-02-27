using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarPWinForm
{
    public partial class Form3 : Form
    {
        Form1 form1 = new Form1();
        int color = 0;
        public Form3()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnShowEvents_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(OpenForm1);
            t.Start();
            this.Close();
        }
   
        private void OpenForm1()
        {
            Form1 form1 = new Form1();
            if(color == 0)
            {
                form1.BackColor = Color.DarkGray;
            }
            if (color == 1)
            {
                form1.BackColor = Color.Black;
            }
            Application.Run(form1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMotiveD_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            color = 1;
        }

        private void btmMotiveB_Click(object sender, EventArgs e)
        {      
            this.BackColor = Color.DarkGray;
            color = 0;
        }
    }
}
