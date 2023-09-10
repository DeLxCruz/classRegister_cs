using classRegister.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Students> students = new List<Students>();
        List<Grades> grades = new List<Grades>();
        bool exit = false;

        do
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Menú de Registro de Estudiantes y Notas de Matemáticas");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Registrar Estudiantes");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. Registrar Notas de Estudiantes");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3. Mostrar Notas de Estudiantes");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("4. Salir");

            Console.ResetColor();
            Console.Write("Seleccione una opción: ");

            int option = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                case 1:
                    do
                    {
                        Students student = new Students();

                        Console.Clear();

                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Registrar Estudiantes");
                        Console.ResetColor();
                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.Green;
                        string id = AskId();

                        student.Id = id;
                        grades.Add(new Grades(id, new List<float>(4), new List<float>(3), new List<float>(2)));

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string name = AskName();

                        student.Name = name;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        string email = AskEmail();

                        student.Email = email;

                        Console.ForegroundColor = ConsoleColor.Red;
                        int age = AskAge();

                        while (age < 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("La edad del estudiante no puede ser negativa. Intente nuevamente.");
                            age = AskAge();
                        }

                        student.Age = age;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        string address = AskAddress();

                        student.Address = address;

                        Console.WriteLine("Estudiante registrado con éxito");
                        students.Add(student);

                        Console.WriteLine("¿Desea agregar otro estudiante? (S/N)");
                    } while (Console.ReadLine().Trim().ToUpper() == "S");
                    break;

                case 2:
                    AddGrades(grades);
                    break;

                case 4:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente nuevamente");
                    Console.ReadKey();
                    break;
            }
        } while (!exit);
    }

    static string AskId()
    {
        while (true)
        {
            Console.Write("Ingrese el ID del estudiante (máximo 15 caracteres): ");
            string id = Console.ReadLine();

            if (!string.IsNullOrEmpty(id) && id.Length <= 15)
            {
                return id;
            }
            else
            {
                Console.WriteLine("El ID debe tener entre 1 y 15 caracteres.");
            }
        }
    }

    static string AskName()
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

    static string AskEmail()
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
    static int AskAge()
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

    static string AskAddress()
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

    static void AddGrades(List<Grades> grades)
    {
        Grades grade = new Grades();

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("Ingrese el ID del estudiante: ");

        string id = Console.ReadLine();

        grade.IdStudent = id;

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
                    int option = Convert.ToInt16(Console.ReadLine());

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
            }else
            {
                Console.WriteLine("El ID ingresado no existe.");
                Console.ReadKey();
            }
        }
    }

    static void ShowStudentsGrades(List<Grades> grades)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Ingrese el ID del estudiante: ");

        string id = Console.ReadLine();

        foreach (Grades item in grades)
        {
            if (item.IdStudent == id)
            {
                Console.WriteLine($"Notas de quices: {item.QuizGrades}");
                Console.WriteLine($"Notas de trabajos: {item.HomeworkGrades}");
                Console.WriteLine($"Notas de parciales: {item.ExamGrades}");
            }
        }
    }
}

// El profesor del area de matematicas necesita generar un programa de los estudiantes que se encuentran matriculados la informacion que el docente posee de cada estudiante es la siguiente: 

// codigo longitud mx 15caracteres,
// nombre de estudiante long max 40carac,
// correo electronico con la longitud max de 40carc,
// edad del estudiante,
// direccion long max de 35carac.

// No se conoce la cantidad que se registaron en la asinatura. 
// La universidad tiene como norma que cada estudiante debe presentar:
// 4 quices
// 2 trabajos
// 3 parcilaes.

// las notas equivalen:
// quices equivale 25%
// trabajos equivale al 15%
// los parciales equivale 60%,

// el programa debe permitirle al profesor generar los siguientes reportes. 
// El programa debe permitirle al docente resgistrar notas.



