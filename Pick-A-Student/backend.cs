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
            

            String command = "INSERT INTO " + tableName + " (id, name, correct, incorrect, missing) VALUES (" + i + ", '" + studentName + "', 0, 0, 0)";
            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            myCommand.ExecuteNonQuery();
        }


        //adds one to the number of correct answers
        public void addCorrect(String tableName, int studentID)
        {
            SQLiteDataReader result;
            int correct;
            String command = "select correct from " + tableName + " where id = " + studentID;
            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            result = myCommand.ExecuteReader();

            //checks if query has rows
            if (result.HasRows)
            {
                result.Read();
                correct = result.GetInt16(0);

                Console.WriteLine("CORRECT NUMBERS: " + correct);

                correct += 1;

                command = "update " + tableName + " set correct = " + correct + " where id = " + studentID;

                myCommand = new SQLiteCommand(command, myConnection);
                myCommand.ExecuteNonQuery();

            }

        }

        public void addIncorrect(String tableName, int studentID)
        {
            SQLiteDataReader result;
            int incorrect;
            String command = "select incorrect from " + tableName + " where id = " + studentID;
            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            result = myCommand.ExecuteReader();

            //checks if query has rows
            if (result.HasRows)
            {
                result.Read();
                incorrect = result.GetInt16(0);

                Console.WriteLine("INCORRECT NUMBERS: " + incorrect);

                incorrect += 1;

                command = "update " + tableName + " set incorrect = " + incorrect + " where id = " + studentID;

                myCommand = new SQLiteCommand(command, myConnection);
                myCommand.ExecuteNonQuery();

            }

        }


        //gets the name of the student called
        public String getStudent(String tableName, int studentID)
        {
            String name;
            String command = "select name from " + tableName + " where id = " + studentID;
            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            SQLiteDataReader result;
            result = myCommand.ExecuteReader();

            if (result.HasRows)
            {
                result.Read();
                name = result.GetString(0);
                return name;
            }

            //if nothing in database, returns null.
            return "null";
        }


        public int[] randomizeArray(String tableName)
        {

            int n = countID(tableName);
            Console.WriteLine("length of array is " + n);
            int i = 0;
            int [] studentList = new int[n];
            int id = 0;
            Random rand = new Random();

            while (i < n)
            {
                
                id = rand.Next(1, n + 1);
                if (!studentList.Contains(id))
                {
                    studentList[i] = id;
                    i++;
                    Console.WriteLine("random int is " + id);
                }
            }
            
            return studentList;
        }



        //counts the total number of entries in a table
        public int countID(String tableName)
        {
            
            int result;
            String command = "SELECT COUNT(*) FROM " + tableName; //my SQL query

            SQLiteCommand myCommand = new SQLiteCommand(command, myConnection);
            result = Convert.ToInt32(myCommand.ExecuteScalar()); //grabs number from data structure with executescalar, and converts it to int
            Console.WriteLine("result is: ");
            Console.WriteLine(result);

            return result;
        }

    }
}
