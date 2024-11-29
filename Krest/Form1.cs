using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 800;
            this.Width = 900;
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            sender.GetType().GetProperty("Text").SetValue(sender, "x");
        
        }
    }
}
