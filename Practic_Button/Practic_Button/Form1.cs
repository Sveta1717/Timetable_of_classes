using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void MyButton()
        {
            Button b2 = new Button();
            b2.Location = new System.Drawing.Point(this.ClientRectangle.Width / 2 - 125 / 2, this.ClientRectangle.Height / 2 - 32);
            b2.Size = new Size(125, 32);
            b2.TabIndex = 0;
            b2.Text = "TEXT";
            b2.UseVisualStyleBackColor = true;
            
            Controls.Add(b2);
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            MyButton();
        }
    }
}
