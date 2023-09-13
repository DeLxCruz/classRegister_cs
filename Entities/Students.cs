namespace classRegister.Entities
{
    public class Students:Grades
    {
        private string id;

        private string name;

        private string email;

        private int age;

        private string address;

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public Students():base()
        {
        }

        public Students(string id, string name, string email, int age, string address, List<float> quizGrades, List<float> examGrades, List<float> homeworkGrades):base(quizGrades,examGrades,homeworkGrades)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.age = age;
            this.address = address;
            this.QuizGrades = quizGrades;
            this.ExamGrades = examGrades;
            this.HomeworkGrades = homeworkGrades;
        }

    }
}