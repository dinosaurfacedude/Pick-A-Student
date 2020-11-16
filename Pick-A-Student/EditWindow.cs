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
    public partial class EditWindow : Form
    {
        
        //i will be tied to the length of the class array that is loaded into the program at the start
        static int i = 1;
        static int t = 1;
        static String className = "COSC101";
        static backend student = new backend(PickAStudent.className);
        static String name = student.getStudent(className, 1);
        static int studentNumber = student.countID("COSC101");
        static int[] studentList = new int[studentNumber];
        public EditWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Thinking2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditWindow_Load(object sender, EventArgs e)
        {
            ClassName.Text = PickAStudent.classNameSafe;

            Console.WriteLine(PickAStudent.className);
            for (int t = 1; t < student.countID("COSC101"); t++)
            {
                

                String name = student.getStudent(className, t);
                Console.WriteLine("STUDENT NAME IS " + name);
                String corr = student.getCorrect(className, t).ToString();
                String incorr = student.getIncorrect(className, t).ToString();
                String none = student.getMissing(className, t).ToString();

                if (name != "null")
                {
                 
                    //all 3 editable text boxes to be added
                    TextBox Student = new TextBox();
                    TextBox correct = new TextBox();
                    TextBox wrong = new TextBox();
                    TextBox thinking = new TextBox();

                    Student.Text = name;
                    correct.Text = corr;
                    wrong.Text = incorr;
                    thinking.Text = none;

                    Point p = new Point(61, 82 + i);
                    Point d = new Point(369, 82 + i);
                    Point o = new Point(515, 82 + i);
                    Point l = new Point(663, 82 + i);
                    Student.Location = p;
                    correct.Location = d;
                    wrong.Location = o;
                    thinking.Location = l;


                    Size s = new Size(210, 34);
                    Size q = new Size(52, 37);
                    Student.Size = s;
                    correct.Size = q;
                    wrong.Size = q;
                    thinking.Size = q;

                    Student.BringToFront();
                    this.Controls.Add(Student);
                    this.Controls.Add(correct);
                    this.Controls.Add(wrong);
                    this.Controls.Add(thinking);
                }
                else
                {
                    while(name == "null")
                    {
                        t = t + 1;
                        name = student.getStudent("COSC101", t);
                       
                    }
                }
                i = i + 30;
                t++;
            }

        }

        private void Student1_TextChanged(object sender, EventArgs e)
        {

        }


        //name of class
        private void ClassName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {

        }

        
        //add student button
        private void Add_Click_1(object sender, EventArgs e)
        {
            
            //all 3 editable text boxes to be added
            TextBox tb = new TextBox();
            TextBox ca = new TextBox();
            TextBox wa = new TextBox();
            TextBox st = new TextBox();
            tb.Text = "Student " + t;
            ca.Text = "0";
            wa.Text = "0";
            st.Text = "0";
           
            Point p = new Point(61, 82 + i);
            Point d = new Point(369, 82 + i);
            Point o = new Point(515, 82 + i);
            Point l = new Point(663, 82 + i);
            tb.Location = p;
            ca.Location = d;
            wa.Location = o;
            st.Location = l;


            Size s = new Size(210, 34);
            Size q = new Size(52, 37);
            tb.Size = s;
            ca.Size = q;
            wa.Size = q;
            st.Size = q;

            tb.BringToFront();
            this.Controls.Add(tb);
            this.Controls.Add(ca);
            this.Controls.Add(wa);
            this.Controls.Add(st);
            i = i + 30;
            t++;

            student.insertStudent(className, tb.Text);
        
        }

        private void Save_Click(object sender, EventArgs e)
        {
            PickAStudent.studentNumber = student.countID("COSC101");
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            String name = studentDelete.Text;
            TextBox deletedStudent = new TextBox();
            student.deleteStudent(className, name);
        }

        private void toChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeTo_TextChanged(object sender, EventArgs e)
        {

        }


        //update button
        private void button1_Click(object sender, EventArgs e)
        {
            String oldName = toChange.Text;
            String newName = changeTo.Text;
            student.updateStudent(className, oldName, newName);
        }
    }
}
