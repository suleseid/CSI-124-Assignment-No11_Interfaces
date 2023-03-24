using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_124_Assignment_No11_Interfaces
{
    public partial class IEnumerableExample : MainWindow
    {
        ClassRoster prog124;

        public IEnumerableExample()
        {
            InitializeComponent();
            prog124 = new ClassRoster();
            prog124.AddStudent(new Student("Will", "Cram"));
            prog124.AddStudent(new Student("Dylan", "Register"));

            DisplayStudents();
        }

        public void DisplayStudents()
        {
            foreach (Student student in prog124)
            {
               lbStudents.Items.Add(student);   
            }
        }
    }
}
