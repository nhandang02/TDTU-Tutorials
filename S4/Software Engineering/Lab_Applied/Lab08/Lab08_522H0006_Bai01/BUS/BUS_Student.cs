using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Student
    {
        DAL_Student student;

        public BUS_Student(string studentID, string fullName, string hometown, DateTime dob, decimal gpa)
        {
            student = new DAL_Student(studentID, fullName, hometown, dob, gpa);
        }

        public void AddQuery()
        {
            student.AddQuery();
        }

        public void UpdateQuery()
        {
            student.UpdateQuery();
        }

        public void DeleteQuery()
        {
            student.DeleteQuery();
        }

        public DataTable SelectQuery()
        {
            return student.SelectQuery();
        }

        public string GetStudentID()
        {
            DataTable tb = student.getStudentDesc(); // Assuming there's a method named getStudentDesc in DAL_Project to retrieve the latest StudentID
            if (tb.Rows.Count > 0)
            {
                string latestStudentID = tb.Rows[0][0].ToString();
                int sequenceNumber = int.Parse(latestStudentID.Substring(2)) + 1;
                string newStudentID = "SV" + sequenceNumber.ToString().PadLeft(3, '0');
                return newStudentID;
            }
            else
            {
                return "SV001";
            }
        }
    }
}
