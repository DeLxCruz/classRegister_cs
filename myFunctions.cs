using System.Globalization;
using classRegister.Entities;

namespace classRegister
{
    public static class MyFunctions
    {
        public static string AskId(List<Students> students)
        {
            while (true)
            {
                Console.Write("Ingrese el ID del estudiante (máximo 15 caracteres): ");
                string id = Console.ReadLine();

                if (!string.IsNullOrEmpty(id) && id.Length <= 15)
                {
                    if (!students.Any(student => student.Id == id))
                    {
                        return id;
                    }
                    else
                    {
                        Console.WriteLine("El ID ingresado ya existe.");
                    }
                }
                else
                {
                    Console.WriteLine("El ID debe tener entre 1 y 15 caracteres.");
                }
            }
        }

        public static string AskName()
        {
            while (true)
            {
                Console.Write("Ingrese el nombre del estudiante (máximo 40 caracteres): ");
                string name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name) && name.Length <= 40)
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("El nombre debe tener entre 1 y 40 caracteres.");
                }
            }
        }

        public static string AskEmail()
        {
            while (true)
            {
                Console.Write("Ingrese el correo electrónico del estudiante (máximo 40 caracteres): ");
                string email = Console.ReadLine();

                if (!string.IsNullOrEmpty(email) && email.Length <= 40)
                {
                    return email;
                }
                else
                {
                    Console.WriteLine("El correo electrónico debe tener entre 1 y 40 caracteres.");
                }
            }
        }
        public static int AskAge()
        {
            int age;

            while (true)
            {
                Console.Write("Ingrese la edad del estudiante: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("La edad del estudiante debe ser un número.");
                }
            }
        }

        public static string AskAddress()
        {
            while (true)
            {
                Console.Write("Ingrese la dirección del estudiante (máximo 35 caracteres): ");
                string address = Console.ReadLine();

                if (!string.IsNullOrEmpty(address) && address.Length <= 35)
                {
                    return address;
                }
                else
                {
                    Console.WriteLine("La dirección debe tener entre 1 y 35 caracteres.");
                }
            }
        }

        public static void AddGrades(List<Grades> grades)
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Ingrese el ID del estudiante: ");

            string id = Console.ReadLine();

            Grades studentGrades = grades.FirstOrDefault(grade => grade.IdStudent == id);

            if (studentGrades == null)
            {
                Console.WriteLine("El ID ingresado no existe.");
                Console.ReadKey();
                return;
            }

            foreach (Grades item in grades)
            {
                if (item.IdStudent == id)
                {
                    bool exitGrades = false;
                    do
                    {
                        Console.Clear();

                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Registrar Notas de Estudiantes");
                        Console.ResetColor();
                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("1. Registrar Notas de Quices");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("2. Registrar Notas de Trabajos");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("3. Registrar Notas de Parciales");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("4. Salir");

                        Console.ResetColor();
                        Console.Write("Seleccione una opción: ");
                        int option;
                        bool validOption = int.TryParse(Console.ReadLine(), out option);

                        if (!validOption)
                        {
                            Console.WriteLine("Opción no válida, intente nuevamente");
                            Console.ReadKey();
                            continue;
                        }

                        switch (option)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Ingrese las notas de los quices: ");
                                for (int i = 0; i < 4; i++)
                                {
                                    bool validGrade = false;
                                    float quizGrade = 0.0f;

                                    while (!validGrade)
                                    {
                                        Console.Write($"Quiz {i + 1}: ");
                                        string quiz = Console.ReadLine();

                                        if (string.IsNullOrEmpty(quiz))
                                        {
                                            quizGrade = 0.0f;
                                            validGrade = true;
                                            Console.WriteLine("Por defecto se asignó la nota 0.0");
                                        }
                                        else if (float.TryParse(quiz, NumberStyles.Float, CultureInfo.InvariantCulture, out quizGrade))
                                        {
                                            if (quizGrade == (int)quizGrade)
                                            {
                                                quizGrade = (float)Math.Round(quizGrade, 1);
                                            }

                                            if (quizGrade >= 0.0f && quizGrade <= 5.0f)
                                            {
                                                validGrade = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("La nota debe estar entre 0.0 y 5.0.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("La nota debe ser un número válido.");
                                        }
                                    }

                                    item.QuizGrades.Add(quizGrade);
                                }


                                Console.WriteLine("Notas de quices registradas con éxito");
                                Console.ReadKey();
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("Ingrese las notas de los trabajos: ");
                                for (int i = 0; i < 2; i++)
                                {
                                    bool validGrade = false;
                                    float homeworkGrade = 0.0f;

                                    while (!validGrade)
                                    {
                                        Console.Write($"Trabajo {i + 1}: ");
                                        string homework = Console.ReadLine();

                                        if (string.IsNullOrEmpty(homework))
                                        {
                                            homeworkGrade = 0.0f;
                                            validGrade = true;
                                            Console.WriteLine("Por defecto se asignó la nota 0.0");
                                        }
                                        else if (float.TryParse(homework, NumberStyles.Float, CultureInfo.InvariantCulture, out homeworkGrade))
                                        {
                                            if (homeworkGrade >= 0.0f && homeworkGrade <= 5.0f)
                                            {
                                                validGrade = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("La nota debe estar entre 0.0 y 5.0.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("La nota debe ser un número válido.");
                                        }
                                    }

                                    item.HomeworkGrades.Add(homeworkGrade);
                                }
                                Console.WriteLine("Notas de trabajos registradas con éxito");
                                Console.ReadKey();
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Ingrese las notas de los parciales: ");
                                for (int i = 0; i < 3; i++)
                                {
                                    bool validGrade = false;
                                    float examGrade = 0.0f;

                                    while (!validGrade)
                                    {
                                        Console.Write($"Parcial {i + 1}: ");
                                        string exam = Console.ReadLine();

                                        if (string.IsNullOrEmpty(exam))
                                        {
                                            examGrade = 0.0f;
                                            validGrade = true;
                                            Console.WriteLine("Por defecto se asignó la nota 0.0");
                                        }
                                        else if (float.TryParse(exam, NumberStyles.Float, CultureInfo.InvariantCulture, out examGrade))
                                        {
                                            if (examGrade >= 0.0f && examGrade <= 5.0f)
                                            {
                                                validGrade = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("La nota debe estar entre 0.0 y 5.0.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("La nota debe ser un número válido.");
                                        }
                                    }

                                    item.ExamGrades.Add(examGrade);
                                }
                                Console.WriteLine("Notas de parciales registradas con éxito");
                                Console.ReadKey();
                                break;

                            case 4:
                                exitGrades = true;
                                break;

                            default:
                                Console.WriteLine("Opción no válida, intente nuevamente");
                                Console.ReadKey();
                                break;
                        }
                    } while (!exitGrades);
                }
                else
                {
                    Console.WriteLine("El ID ingresado no existe.");
                    Console.ReadKey();
                }
            }
        }

        public static void ShowStudentsGrades(List<Grades> grades)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Ingrese el ID del estudiante: ");

            string id = Console.ReadLine();

            var studentGrades = grades.FirstOrDefault(grade => grade.IdStudent == id);

            if (studentGrades == null)
            {
                Console.WriteLine("El ID ingresado no existe.");
            }
            else
            {
                Console.WriteLine($"Notas de quices: {string.Join(", ", studentGrades.QuizGrades)}");
                Console.WriteLine($"Notas de trabajos: {string.Join(", ", studentGrades.HomeworkGrades)}");
                Console.WriteLine($"Notas de parciales: {string.Join(", ", studentGrades.ExamGrades)}");
            }
        }
    }
}