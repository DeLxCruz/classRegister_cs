namespace classRegister.Entities
{
    public class Grades 
    {
        private string idStudent;

        private List<float> quizGrades = new List<float>(4);

        private List<float> examGrades = new List<float>(3);

        private List<float> homeworkGrades = new List<float>(2);

        public string IdStudent
        {
            get => idStudent;
            set => idStudent = value;
        }

        public List<float> QuizGrades
        {
            get => quizGrades;
            set => quizGrades = value;
        }

        public List<float> ExamGrades
        {
            get => examGrades;
            set => examGrades = value;
        }

        public List<float> HomeworkGrades
        {
            get => homeworkGrades;
            set => homeworkGrades = value;
        }

        public Grades()
        {
        }

        public Grades(string idStudent, List<float> quizGrades, List<float> examGrades, List<float> homeworkGrades)
        {
            this.idStudent = idStudent;
            this.quizGrades = quizGrades;
            this.examGrades = examGrades;
            this.homeworkGrades = homeworkGrades;
        }
    }
}