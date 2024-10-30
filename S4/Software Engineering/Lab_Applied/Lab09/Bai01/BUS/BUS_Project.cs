using DAL;
using System;
using System.Data;

namespace BUS
{
    public class BUS_Project
    {
        DAL_Project project;

        public BUS_Project(string projectID, string projectName, string supervisor, decimal funding)
        {
            project = new DAL_Project(projectID, projectName, supervisor, funding);
        }

        public void AddQuery()
        {
            project.AddQuery();
        }

        public void UpdateQuery()
        {
            project.UpdateQuery();
        }

        public void DeleteQuery()
        {
            project.DeleteQuery();
        }

        public DataTable SelectQuery()
        {
            return project.SelectQuery();
        }

        public string GetProjectID()
        {
            DataTable dt = project.GetProjectDesc();
            if (dt.Rows.Count > 0)
            {
                string latestProjectID = dt.Rows[0][0].ToString();
                int sequenceNumber = int.Parse(latestProjectID.Substring(2)) + 1;
                string newProjectID = "DT" + sequenceNumber.ToString().PadLeft(3, '0');
                return newProjectID;
            }
            else
            {
                return "DT001";
            }
        }
    }
}
