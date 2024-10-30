
namespace DTO
{
    public class DTO_Student
    {
        private string studentID, fullName, hometown;
        private DateTime dob;
        private decimal gpa;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Hometown
        {
            get { return hometown; }
            set { hometown = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public decimal GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public DTO_Student(string studentID, string fullName, string hometown, DateTime dob, decimal gpa)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.hometown = hometown;
            this.dob = dob;
            this.gpa = gpa;
        }
    }
}
