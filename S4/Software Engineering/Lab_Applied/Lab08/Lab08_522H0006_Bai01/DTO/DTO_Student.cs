namespace DTO
{
    public class DTO_Student
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public string Hometown { get; set; }
        public DateTime DOB { get; set; }
        public decimal GPA { get; set; }

        public DTO_Student(string studentID, string fullName, string hometown, DateTime dob, decimal gpa)
        {
            StudentID = studentID;
            FullName = fullName;
            Hometown = hometown;
            DOB = dob;
            GPA = gpa;
        }
    }
}