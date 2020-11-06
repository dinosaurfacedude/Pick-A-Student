using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pick_A_Student
{
    public partial class ChooseClass : Form
    {
        static int x = 0;
        public ChooseClass()
        {
            InitializeComponent();
        }

        private void AddClass_Click(object sender, EventArgs e)
        {
            RadioButton rb = new RadioButton();
            rb.Text = "class " + x;

            Point a = new Point(560, 55 + (x * 10));
            rb.Location = a;
            this.Controls.Add(rb);
            x++;
        }
    }
}
