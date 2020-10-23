using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Pick_A_Student
{
    class backend
    {
        public SQLiteConnection myConnection;

        public backend()
        {
            myConnection = new SQLiteConnection("Data Source = studentData.sqlite3");

            //Checks if database exists
            if (!File.Exists("studentData.sqlite3")){
                SQLiteConnection.CreateFile("studentData.sqlite3");
            }
            myConnection.Open(); 
        }

        //when called, creates a table 
        public void createTable(String tableName)
        {
            String command = "CREATE TABLE IF NOT EXISTS " + tableName + "(id INT, name varchar(20), CORRECT INT, INCORRECT INT, MISSING INT)";
            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            myCommand.ExecuteNonQuery();
        }

        public void deleteTable(String tableName)
        {
            String command = "DROP TABLE " + tableName;
            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            myCommand.ExecuteNonQuery();


        }


        //inserts a student, gives ID from countStudent()
        public void insertStudent(String tableName, String studentName)
        {
            int i = countID(tableName) + 1;
            

            String command = "INSERT INTO " + tableName + " (ID, NAME) VALUES (" + i + ", '" + studentName + "')";
            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            myCommand.ExecuteNonQuery();
        }


        //adds one to the number of correct answers
        public void addCorrect(String tableName, int studentID)
        {
            SQLiteDataReader result;
            int correct;
            String command = "select correct from " + tableName + " where id = [" + studentID + "]";
            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            result = myCommand.ExecuteReader();

            correct = result.GetInt16(0);

            Console.WriteLine("CORRECT NUMBERS: " + correct);
        }

        //counts the total number of entries in a table
        public int countID(String tableName)
        {
            int count = 0;
            int result;
            String command = "SELECT COUNT(*) FROM " + tableName;
            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            result = Convert.ToInt32(myCommand.ExecuteScalar());
            Console.WriteLine("result is: ");
            Console.WriteLine(result);

            return count;
        }

    }
}
