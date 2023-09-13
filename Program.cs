using classRegister.Entities;


namespace classRegister
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            List<Grades> grades = new List<Grades>();
            bool exit = false;

            try
            {
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
                                string id = MyFunctions.AskId(students);

                                student.Id = id;
                                grades.Add(new Grades(id, new List<float>(), new List<float>(), new List<float>()));

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                string name = MyFunctions.AskName();

                                student.Name = name;

                                Console.ForegroundColor = ConsoleColor.Blue;
                                string email = MyFunctions.AskEmail();

                                student.Email = email;

                                Console.ForegroundColor = ConsoleColor.Red;
                                int age = MyFunctions.AskAge();

                                while (age < 0)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("La edad del estudiante no puede ser negativa. Intente nuevamente.");
                                    age = MyFunctions.AskAge();
                                }

                                student.Age = age;

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                string address = MyFunctions.AskAddress();

                                student.Address = address;

                                Console.WriteLine("Estudiante registrado con éxito");
                                students.Add(student);

                                Console.WriteLine("¿Desea agregar otro estudiante? (S/N)");
                            } while (Console.ReadLine().Trim().ToUpper() == "S");
                            break;

                        case 2:
                            MyFunctions.AddGrades(grades);
                            break;

                        case 3:
                            MyFunctions.ShowStudentsGrades(grades);
                            Console.ReadKey();
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
            catch (System.Exception)
            {
                Console.WriteLine("Ocurrió un error inesperado, intente nuevamente");
                throw;
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



