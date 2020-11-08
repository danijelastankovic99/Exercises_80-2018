using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_80_2018
{
    public partial class ExerciseResult : Form
    {
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


        private void ExerciseResult_Load(object sender, EventArgs e)
        {

        }
    }
}
