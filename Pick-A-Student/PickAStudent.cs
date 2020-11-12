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
    public partial class PickAStudent : Form
    {
        static backend student = new backend();

        static int i = 0;
        static int k = 0;
        static int j = 0;
        static int p = 0;
        static int studentNumber = student.countID("COSC101");
        static int[] studentList = new int[studentNumber - 1];
        int queue = 0;


        public PickAStudent()
        {
            InitializeComponent();
            studentList = student.randomizeArray("COSC101");
        }


        //button for incorrect answers
        private void ThinkingBright_Click(object sender, EventArgs e)
        {
            student.addIncorrect("COSC101", studentList[p]);
            if (j == 1) { }
            else if (i == 1) { }
            else if (k == 0)
            {
                ThinkingBright.Image = Properties.Resources.Thinking_Emoji;
                button1.Refresh();
                button1.Visible = true;
                k = 1;
            }

            else if (k == 1)
            { 
                ThinkingBright.Image = Properties.Resources.dark_thinking1;
                button1.Refresh();
                button1.Visible = true;
                k = 0;
            }

        }

        //button for correct answers
        private void button1_Click(object sender, EventArgs e)
        {
            student.addCorrect("COSC101", studentList[p]);
            if (k == 1) { }
            else if (j == 1) { }
            
            else if (i ==0)
            {
                button1.Image = Properties.Resources.smilly;
                button1.Refresh();
                button1.Visible = true;
                i = 1;
            }
            else if (i == 1)
            {
                button1.Image = Properties.Resources.dark_smilly1;
                button1.Refresh();
                button1.Visible = true;
                i = 0;
            }

        }

        //edit button
        private void Edit_Click(object sender, EventArgs e)
        {
            var EditWindow = new EditWindow();
            EditWindow.Show();
        }

        private void sleeping_Click(object sender, EventArgs e)
        {
            student.addSleep("COSC101", studentList[p]);
           
            if (k == 1) { }
            else if (i == 1) { }
            else if (j == 0)
            {
                sleeping.Image = Properties.Resources.Sleeping_Emoji1;
                sleeping.Refresh();
                sleeping.Visible = true;
                j = 1;

            }
            else
            {
                sleeping.Image = Properties.Resources.Sleeping_Emoji2;
                sleeping.Refresh();
                sleeping.Visible = true;
                j = 0;
            }
        }

        //brings up screen that allows user to select class
        private void ClassChoose_Click(object sender, EventArgs e)
        {
            var newForm = new ChooseClass();
            newForm.Show();
        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            var About = new About();
            About.Show();
        }

        private void PickAStudent_Load(object sender, EventArgs e)
        {
            var newForm = new ChooseClass();
            newForm.BringToFront();
            newForm.Show();
         
        }


        //next arrow
        private void NextStudent_Click(object sender, EventArgs e)
        {
          
            p = p + 1; // counter variable
            if(p == studentNumber)
            {
                studentList = student.randomizeArray("COSC101");
                Console.WriteLine("end of queue. Randomizing");
                p = 0;
            }
            StudentName.Text = student.getStudent("COSC101", studentList[p]);
            queue = studentNumber - p;
            textBox1.Text = queue.ToString();
        }

        //this is where the student name goes
        private void StudentName_TextChanged(object sender, EventArgs e)
        {

        }

        //queue number
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
