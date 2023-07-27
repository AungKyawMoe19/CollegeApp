namespace CollegeApp.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>
        {
            new Student
            {
                Id = 1,
                StudentName = "AKM",
                Email = "akm@gmail.com",
                Address = "MDY"
            },
            new Student
            {
                Id = 2,
                StudentName = "Will",
                Email = "Will@gmail.com",
                Address = "YGN"
            }

        };
    }
}
