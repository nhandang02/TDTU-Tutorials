using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_StudentProject
    {
        private DTO_StudentProject studentProject;

        public DAL_StudentProject(string studentID, string FullName, string ProjectID, string InternshipPlace, int Distance, decimal Results)
        {
            studentProject = new DTO_StudentProject(studentID, FullName, ProjectID, InternshipPlace, Distance, Results);
        }

        public DataTable SelectAllStudentProject()
        {
            string query = "SELECT Student_Project.*, Student.FullName FROM Student_Project INNER JOIN Student ON Student.StudentID = Student_Project.StudentID";
            return Connection.selectQuery(query);
        }

        public DataTable SelectStudentProjectByID(string studentID)
        {
            string query = $"SELECT Student_Project.*, Student.FullName FROM Student_Project INNER JOIN Student ON Student.StudentID = Student_Project.StudentID WHERE Student_Project.StudentID = '{studentID}'";
            return Connection.selectQuery(query);
        }


    }
 }