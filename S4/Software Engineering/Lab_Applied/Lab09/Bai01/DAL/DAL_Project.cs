using DTO;
using System;
using System.Data;

namespace DAL
{
    public class DAL_Project
    {
        DTO_Project project;

        public DAL_Project(string projectID, string projectName, string supervisor, decimal funding)
        {
            project = new DTO_Project(projectID, projectName, supervisor, funding);
        }

        public void AddQuery()
        {
            string query = "INSERT INTO Project VALUES ('" + project.ProjectID + "', N'" + project.ProjectName + "', N'" + project.Supervisor + "', " + project.Funding.ToString() + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateQuery()
        {
            string query = "UPDATE Project SET ProjectName = N'" + project.ProjectName + "', Supervisor = N'" + project.Supervisor + "', Funding = " + project.Funding.ToString() + " WHERE ProjectID = '" + project.ProjectID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteQuery()
        {
            string query = "DELETE FROM Project WHERE ProjectID = '" + project.ProjectID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectQuery()
        {
            string query = "SELECT * FROM Project";
            return Connection.SelectQuery(query);
        }

        // Get DataTable desc order
        public DataTable GetProjectDesc()
        {
            string query = "SELECT TOP 1 ProjectID FROM Project ORDER BY ProjectID DESC";
            return Connection.SelectQuery(query);
        }
    }
}
