using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Ex3__WinForms
{
    public partial class Form1 : Form
    {
        static int counter = 0;
        public Form1()
        {
            InitializeComponent();
            MouseEnter += (object sender, EventArgs e) => {
                Text = "Входов мыши: " + ++counter;
                BackColor = Form.DefaultBackColor;
            };
            MouseClick += (object sender, MouseEventArgs e) =>
            {

            }
        }


    }
}
