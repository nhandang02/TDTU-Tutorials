using System;

namespace DTO
{
    public class DTO_StudentProject
    {
        private string studentID, projectID, internshipPlace;
        private int distance;
        private decimal results;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string ProjectID
        {
            get { return projectID; }
            set { projectID = value; }
        }

        public string InternshipPlace
        {
            get { return internshipPlace; }
            set { internshipPlace = value; }
        }

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public decimal Results
        {
            get { return results; }
            set { results = value; }
        }

        public DTO_StudentProject(string studentID, string projectID, string internshipPlace, int distance, decimal results)
        {
            this.studentID = studentID;
            this.projectID = projectID;
            this.internshipPlace = internshipPlace;
            this.distance = distance;
            this.results = results;
        }
    }
}
