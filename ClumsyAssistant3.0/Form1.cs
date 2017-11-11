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
            Notification n = new Notification();

            n.ShowNotification("My first notification", "Calin loves ducks", 1000);
            Thread.Sleep(500);
            n.ShowNotification("My first notification2", "Calin loves ducks", 1000);
            Thread.Sleep(500);
            n.ShowNotification("My first notification3", "Calin loves ducks", 1000);
        }

            
    }
}
