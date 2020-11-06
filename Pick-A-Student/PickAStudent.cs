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

namespace Pick_A_Student
{

   
    public partial class PickAStudent : Form
    {
<<<<<<< HEAD
        String StudentClass = "cosc101";
        backend student = new backend();
=======
>>>>>>> parent of 6a16b61... Added reference to backend in project browser
        public PickAStudent()
        {
            InitializeComponent();
        }

        private void ThinkingBright_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var newForm = new EditWindow();
            newForm.Show();
        }

        private void sleeping_Click(object sender, EventArgs e)
        {

        }

        private void ClassChoose_Click(object sender, EventArgs e)
        {
            var newForm = new ChooseClass();
            newForm.Show();
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
