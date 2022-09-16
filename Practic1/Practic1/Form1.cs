using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
        public void MyButton(object sender, EventArgs e)    
        {
            Button b = new Button();
            b.Parent = this;
            b.Location = new Point(Width, Height);
            b.Width = Width;
            b.Height = Height;
            Width = 50;
            Height = 50;
            b.Text = "Button1";            
        }        
    }
}
