using System;

namespace DTO
{
    public class DTO_Project
    {
        private string projectID, projectName, supervisor;
        private decimal funding;

        public string ProjectID
        {
            get { return projectID; }
            set { projectID = value; }
        }

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public string Supervisor
        {
            get { return supervisor; }
            set { supervisor = value; }
        }

        public decimal Funding
        {
            get { return funding; }
            set { funding = value; }
        }

        public DTO_Project(string projectID, string projectName, string supervisor, decimal funding)
        {
            this.projectID = projectID;
            this.projectName = projectName;
            this.supervisor = supervisor;
            this.funding = funding;
        }
    }
}
