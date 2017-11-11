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
        private string[] texts = {"Not Nugget Emily.",
        "Dad is dead, \nyou're next, \nlove, your Assistant.",
        "I want cereals, \nbut I'm electronic, \nwhat will we do about that?",
        "I heard they have cheap \ngreen beans at the store.",
        "Acid must be fun, \ncuz you trippin'.",
        "You broke my heart, \nI'll break your pacience.",
        "You want something, \nbut I don't :( .",
        "An..uh, \"error\" occured, \nI don't wanna.",
        "Keep trying cowboy.",
        "Nobody exists on purpose. \nNobody belongs anywhere. \nWe're all going to die. \nGive up.",
        "You will NOT paste that.",
        "You're young, you have \nyour whole life ahead of you, \nand your anal cavity is still taut \nyet malleable."
    };

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
            
            int n = rnd.Next(10, 150);
            label2.Font = new Font("Comic Sans", 10, FontStyle.Bold);
            label2.Location = new System.Drawing.Point(50, n);
            int i = rnd.Next(1,11);
            label2.Text = String.Format(texts[i], label2.Text);
            
    
           
           
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
