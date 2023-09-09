using classRegister.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Students> students = new List<Students>();
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



