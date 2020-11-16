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
       
        public static String className = "studentPlaceholder.sqlite3";
        static backend student = new backend(className);
        public static String classNameSafe = "studentPlaceholder";
        OpenFileDialog ofd = new OpenFileDialog();
        static int i = 0;
        static int k = 0;
        static int j = 0;
        static int p = 0;

        public static int studentNumber = student.countID("COSC101");
        static int[] studentList = new int[studentNumber - 1];
        int queue = 0;


        public PickAStudent()
        {
            InitializeComponent();
            this.BackgroundImage = global::Pick_A_Student.Properties.Resources.Light_Blue;
            studentList = student.randomizeArray("COSC101");

        }


        //button for incorrect answers
        private void ThinkingBright_Click(object sender, EventArgs e)
        {
            student.addIncorrect("COSC101", studentList[p]);
            ThinkingBright.Image = Properties.Resources.Thinking_Emoji;

        }

        //button for correct answers
        private void button1_Click(object sender, EventArgs e)
        {
            student.addCorrect("COSC101", studentList[p]);
            button1.Image = Properties.Resources.smilly;

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
            sleeping.Image = Properties.Resources.Sleeping_Emoji1;
        }

        //brings up screen that allows user to select class
        private void ClassChoose_Click(object sender, EventArgs e)
        {
            ofd.Filter = "sqlite3|*.sqlite3";
            if (ofd.ShowDialog() == DialogResult.OK) {
                className = ofd.FileName;
                classNameSafe = ofd.SafeFileName;
                student = new backend(className);
                studentList = student.randomizeArray("COSC101");
            }


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


        }


        //next arrow
        private void NextStudent_Click(object sender, EventArgs e)
        {



            try
            {
                button1.Image = Properties.Resources.dark_smilly1; //correct smily changes back
                ThinkingBright.Image = Properties.Resources.dark_thinking1; //incorrect smily changes back
                sleeping.Image = Properties.Resources.Sleeping_Emoji2;
                String name;
                p = p + 1; // counter variable
                if (p == student.countID("COSC101") - 1)
                {
                    studentList = student.randomizeArray("COSC101");
                    Console.WriteLine("end of queue. Randomizing");
                    p = 0;
                }
                name = student.getStudent("COSC101", studentList[p]);

                //if ID shows name that doesn't exist anymore, goes to next name until pulls ID with legitimate name
                if (name == "null")
                {
                    while (name == "null")
                    {
                        p = p + 1;
                        if (p == student.countID("COSC101"))
                        {
                            p = 0;
                        }

                        name = student.getStudent("COSC101", studentList[p]);

                    }
                }
                //sets textbox in center of screen to student name
                StudentName.Text = name;

                /*queue = p - studentNumber;
                textBox1.Text = queue.ToString();
            */

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Pick A Student must be reloaded to complete database.");
            }
        }

        //this is where the student name goes
        private void StudentName_TextChanged(object sender, EventArgs e)
        {

        }

        //queue number
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newClass_Click(object sender, EventArgs e)
        {
            String newClassName = NewClassTextBox.Text + ".sqlite3";
            student.closeClass();
            student = new backend(newClassName);
        }
    }

}
