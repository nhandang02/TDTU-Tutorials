using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_StudentProject
    {
        private DAL_StudentProject dalStudentProject;

        public BUS_StudentProject(string studentID, string FullName, string ProjectID, string InternshipPlace, int Distance, decimal Results)
        {
            dalStudentProject = new DAL_StudentProject(studentID, FullName, ProjectID, InternshipPlace, Distance, Results);
        }

        public DataTable SelectAllStudentProject()
        {
            return dalStudentProject.SelectAllStudentProject();
        }

        public DataTable SelectStudentProjectByID(string projectID)
        {
            return dalStudentProject.SelectStudentProjectByID(projectID);
        }



    }
}