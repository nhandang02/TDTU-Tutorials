using DTO;
using System.Data;

namespace DAL
{
    public class DAL_Student
    {
        DTO_Student student;

        public DAL_Student(string studentID, string fullName, string hometown, DateTime dob, decimal gpa)
        {
            student = new DTO_Student(studentID, fullName, hometown, dob, gpa);
        }

        public void AddQuery()
        {
            string query = "INSERT INTO student VALUES ('" + student.StudentID + "', N'" + student.FullName + "', N'" + student.Hometown + "', '" + student.DOB.ToString("yyyy-MM-dd") + "', " + student.GPA.ToString().Replace(',', '.') + ")";
            Connection.actionQuery(query);
        }

        public void UpdateQuery()
        {
            string query = "UPDATE student SET FullName = N'" + student.FullName + "', Hometown = N'" + student.Hometown + "', DOB = '" + student.DOB.ToString("yyyy-MM-dd") + "', GPA = " + student.GPA.ToString().Replace(',', '.') + " WHERE StudentID = '" + student.StudentID + "'";
            Connection.actionQuery(query);
        }

        public void DeleteQuery()
        {
            string query = "DELETE FROM student WHERE StudentID = '" + student.StudentID + "'";
            Connection.actionQuery(query);
        }

        public DataTable SelectQuery()
        {
            string query = "SELECT * FROM student";
            return Connection.selectQuery(query);
        }
        public DataTable getStudentDesc()
        {
            string s = "select top 1 StudentID from Student order by StudentID desc";
            return Connection.selectQuery(s);
        }
    }

}
