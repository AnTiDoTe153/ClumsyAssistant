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

namespace ClumsyAssistant3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Processes p = new Processes();
            p.Start();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            int n = rnd.Next(10, 190);
            label2.Font = new Font("Arial", 10, FontStyle.Bold);
            label2.Location = new System.Drawing.Point(50, n);
            label2.Text = String.Format("Whatever default message \nyou'd like.", label2.Text);
            
    
           
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label2_Click_1(sender, e);
        }
    }
}
