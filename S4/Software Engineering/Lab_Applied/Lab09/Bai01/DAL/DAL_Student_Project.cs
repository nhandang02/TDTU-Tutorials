using DTO;
using System;
using System.Data;

namespace DAL
{
    public class DAL_StudentProject
    {
        DTO_StudentProject studentProject;

        public DAL_StudentProject(string studentID, string projectID, string internshipPlace, int distance, decimal results)
        {
            studentProject = new DTO_StudentProject(studentID, projectID, internshipPlace, distance, results);
        }

        public void AddQuery()
        {
            string query = "INSERT INTO Student_Project VALUES ('" + studentProject.StudentID + "', '" + studentProject.ProjectID + "', N'" + studentProject.InternshipPlace + "', " + studentProject.Distance.ToString() + ", " + studentProject.Results.ToString() + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateQuery()
        {
            string query = "UPDATE Student_Project SET InternshipPlace = N'" + studentProject.InternshipPlace + "', Distance = " + studentProject.Distance.ToString() + ", Results = " + studentProject.Results.ToString() + " WHERE StudentID = '" + studentProject.StudentID + "' AND ProjectID = '" + studentProject.ProjectID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteQuery()
        {
            string query = "DELETE FROM Student_Project WHERE StudentID = '" + studentProject.StudentID + "' AND ProjectID = '" + studentProject.ProjectID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectQuery()
        {
            string query = "SELECT * FROM Student_Project";
            return Connection.SelectQuery(query);
        }

        // Additional method to get student projects by student ID
        public DataTable GetStudentProjects(string studentID)
        {
            string query = "SELECT * FROM Student_Project WHERE StudentID = '" + studentID + "'";
            return Connection.SelectQuery(query);
        }

        // Additional method to get project interns by project ID
        public DataTable GetProjectInterns(string projectID)
        {
            string query = "SELECT * FROM Student_Project WHERE ProjectID = '" + projectID + "'";
            return Connection.SelectQuery(query);
        }
    }
}
