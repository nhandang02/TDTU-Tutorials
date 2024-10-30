using DAL;
using System;
using System.Data;

namespace BUS
{
    public class BUS_StudentProject
    {
        DAL_StudentProject studentProject;

        public BUS_StudentProject(string studentID, string projectID, string internshipPlace, int distance, decimal results)
        {
            studentProject = new DAL_StudentProject(studentID, projectID, internshipPlace, distance, results);
        }

        public void AddQuery()
        {
            studentProject.AddQuery();
        }

        public void UpdateQuery()
        {
            studentProject.UpdateQuery();
        }

        public void DeleteQuery()
        {
            studentProject.DeleteQuery();
        }

        public DataTable SelectQuery()
        {
            return studentProject.SelectQuery();
        }

        // Additional method to get student projects by student ID
        public DataTable GetStudentProjects(string studentID)
        {
            return studentProject.GetStudentProjects(studentID);
        }

        // Additional method to get project interns by project ID
        public DataTable GetProjectInterns(string projectID)
        {
            return studentProject.GetProjectInterns(projectID);
        }
    }
}
