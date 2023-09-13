namespace classRegister.Entities
{
    public class Grades
    {

        private List<float> quizGrades = new List<float>();

        private List<float> examGrades = new List<float>();

        private List<float> homeworkGrades = new List<float>();


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

        public Grades( List<float> quizGrades, List<float> examGrades, List<float> homeworkGrades)
        {
            this.quizGrades = quizGrades;
            this.examGrades = examGrades;
            this.homeworkGrades = homeworkGrades;
        }
    }
}