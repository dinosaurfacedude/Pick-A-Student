using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pick_A_Student
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChooseClass());
            */
            backend test = new backend();

            //test.createTable("COSC101");
            String name = test.getStudent("COSC101", 1);
            test.randomizeArray("COSC101");
           // Console.WriteLine(name);
            //test.insertStudent("COSC101", "Daniel");
            
            
            //test.countID("COSC101");
            //test.addCorrect("COSC101", 1);
            //test.deleteTable("COSC101");
        
        }
    }
}
