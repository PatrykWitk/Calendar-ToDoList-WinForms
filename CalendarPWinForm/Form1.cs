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
    public partial class Form1 : Form
    {
        int x = 0;
        public Form1()
        {
            InitializeComponent();        
        }

        public class MyRow
        {
            public string note{ get; set; }
            public string date { get; set; }
        }

        //Lista przechowująca tymczasowo wydarzenia
        private static List<Event> events = new List<Event>();


        //String dla ścieżki do pliku
        static string file = "eventsFile.txt";


        private void Form1_Load(object sender, EventArgs e)
        {
            FileManager.Load(file, events);
            foreach(var ev in events)
            {
                dgv.Rows.Add(ev.note, ev.dateofMeet.ToString("D"));
            }
        }

        private void LoadEvents()
        {
            List<Event> rows = new List<Event>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                Event myRow = new Event();
                myRow.note = (string)row.Cells["name"].Value;
                myRow.dateofMeet = DateTime.Parse((string)row.Cells["date"].Value);
                rows.Add(myRow);
            }
            FileManager.Export(file, rows);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.Rows.Add(txtEvent.Text, dtDate.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
        }
        
        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEd_Click(object sender, EventArgs e)
        {
            if(dgv.CurrentRow != null)
            {
                dgv.CurrentRow.Cells["name"].Value = txtEvent.Text;
                dgv.CurrentRow.Cells["date"].Value = dtDate.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoadEvents();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoadEvents();
                Thread t = new Thread(OpenForm3);
                t.Start();
            this.Close();

        }
        private void OpenForm3()
        {
            Application.Run(new Form3());
        }

        private void dgv_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
