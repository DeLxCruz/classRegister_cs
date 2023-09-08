using classRegister.Entities;

internal class Program
{
    private static void Main(string[] args)
    {   
        List<Students> students = new List<Students>();

        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Menú de Registro de Estudiantes y Notas de Matematicas");
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
                Students student = new Students();

                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Registrar Estudiantes");
                Console.ResetColor();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese el código del estudiante: ");
                string id = Console.ReadLine();
                if (id.Length >= 0 && id.Length <= 15)
                {
                    student.Id = id;
                } else
                {
                    Console.WriteLine("");
                    Console.WriteLine("El código del estudiante no puede ser mayor a 15 caracteres");
                    Console.ReadKey();
                }
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ingrese el nombre del estudiante: ");
                string name = Console.ReadLine();
                if (name.Length >= 0 && name.Length <= 40)
                {
                    student.Name = name;
                } else
                {
                    Console.WriteLine("");
                    Console.WriteLine("El nombre del estudiante no puede ser mayor a 40 caracteres");
                    Console.ReadKey();
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Ingrese el correo del estudiante: ");
                string email = Console.ReadLine();
                if (email.Length >= 0 && email.Length <= 40)
                {
                    student.Email = email;
                } else
                {
                    Console.WriteLine("");
                    Console.WriteLine("El correo del estudiante no puede ser mayor a 40 caracteres");
                    Console.ReadKey();
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ingrese la edad del estudiante: ");
                int age = Convert.ToInt16(Console.ReadLine());
                student.Age = age;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ingrese la dirección del estudiante: ");
                string address = Console.ReadLine();
                if (address.Length >= 0 && address.Length <= 35)
                {
                    student.Address = address;
                } else
                {
                    Console.WriteLine("");
                    Console.WriteLine("La dirección del estudiante no puede ser mayor a 35 caracteres");
                    Console.ReadKey();
                }

                Console.WriteLine("Estudiante registrado con éxito");
                Console.ReadKey();
                students.Add(student);
                break;
            
            default:
                Console.WriteLine("Opción no válida, intente nuevamente");
                Console.ReadKey();
                break;
        }
    }
}

//El profesor del area de matematicas necesita generar un programa que le permita registrar los estudiantes que se encuentran matriculados, la informacion que el docente posee de cada estudiante es la siguiente: 

//Codigo Estudiante(Con longitud maxima de 15 caracteres) 
//nombre del estudiante(con longitud maxima de 40 caracteres) 
//correo electronico(maxima de 40 caracteres) 
//edad del estudiante y direccion(con una longitud de 35 caracteres).

//No se conoce la cantidad de estudiantes que se registraron en la asignatura.
//La universidad tiene como norma que cada estudiante debe presentar 4 quices, 2 trabajos y 3 parciales,las notas de los quices equivalen al 25%,los trabajos equivalen al 15% y los parciales equivalen al 60%, el programa debe permitirle al profesor generar los siguientes reportes: Listado general de notas del grupo, paginado por 10 estudiantes.

//El programa debe permitirle al docente realizar todo el proceso de registro de notas por quices y trabajos parciales.
//Realizarlo con Listas



