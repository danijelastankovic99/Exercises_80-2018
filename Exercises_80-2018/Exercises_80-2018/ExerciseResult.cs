using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_80_2018
{
    public partial class ExerciseResult : Form
    {

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ExerciseResult()
        {
            InitializeComponent();
        }
        class Student
        {
            public int Id { get; set; }
            public string StudentName { get; set; }
            public string StudentIndex { get; set; }
            public int Points { get; set; }
        }


        private void listBoxExerciseResults_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void ExerciseResult_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;

            List<Student> students = new List<Student>();

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM dbo.ExerciseResult";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Student student = new Student();
                student.Id = sqlDataReader.GetInt32(0);
                student.StudentName = sqlDataReader.GetString(1);
                student.StudentIndex = sqlDataReader.GetString(2);
                student.Points = sqlDataReader.GetInt32(3);
                students.Add(student);
            }
            sqlConnection.Close();
            foreach (Student s in students)
            {
                listBoxExerciseResults.Items.Add(s.Id + ". " +
                s.StudentName + " " + s.StudentIndex + " - " + s.Points);
            }

        }
    }
}

