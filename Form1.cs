using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerApp
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int fontSize = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            int red = rand.Next(0, 256);
            int green = rand.Next(0, 256);
            int blue = rand.Next(0, 256);

            FirstButton.BackColor = Color.Purple;
            FirstButton.Width -= 5;
            FirstButton.Height -= 5;
            FirstButton.Top = rand.Next(0, 300);
            FirstButton.Left = rand.Next(0, 300);
            FirstButton.BackColor = Color.FromArgb(red, green, blue);
            FirstButton.Font = new Font("Arial", fontSize, FontStyle.Bold);
            fontSize -= 1;
        }
    }
}
