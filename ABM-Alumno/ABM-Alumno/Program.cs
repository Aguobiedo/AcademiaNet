using Microsoft.EntityFrameworkCore;

namespace ABM_Alumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Gestión de Alumnos - Universidad");
                Console.WriteLine("1. Crear Alumno");
                Console.WriteLine("2. Leer Alumno");
                Console.WriteLine("3. Actualizar Alumno");
                Console.WriteLine("4. Eliminar Alumno");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearAlumno();
                        break;
                    case "2":
                        LeerAlumno();
                        break;
                    case "3":
                        ActualizarAlumno();
                        break;
                    case "4":
                        EliminarAlumno();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("Operación completada. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void CrearAlumno()
        {
            using (var context = new UniversidadContext())
            {
                Console.WriteLine("Creación de un nuevo Alumno");

                Console.Write("Ingrese el Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el Apellido: ");
                string apellido = Console.ReadLine();

                Console.Write("Ingrese el Legajo: ");
                int legajo;
                while (!int.TryParse(Console.ReadLine(), out legajo))
                {
                    Console.Write("Legajo no válido. Ingrese un número entero: ");
                }

                Console.Write("Ingrese la Dirección: ");
                string direccion = Console.ReadLine();

                var nuevoAlumno = new Alumno
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Legajo = legajo,
                    Direccion = direccion
                };

                context.Alumnos.Add(nuevoAlumno);
                context.SaveChanges();

                Console.WriteLine("Alumno creado exitosamente. Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void LeerAlumno()
        {
            using (var context = new UniversidadContext())
            {
                Console.WriteLine("Lectura de un Alumno");

                Console.Write("Ingrese el Legajo del Alumno a buscar: ");
                int legajo;
                while (!int.TryParse(Console.ReadLine(), out legajo))
                {
                    Console.Write("Legajo no válido. Ingrese un número entero: ");
                }

                var alumno = context.Alumnos.FirstOrDefault(a => a.Legajo == legajo);

                if (alumno != null)
                {
                    Console.WriteLine($"ID: {alumno.Id}, Nombre: {alumno.Nombre}, Apellido: {alumno.Apellido}, Legajo: {alumno.Legajo}, Dirección: {alumno.Direccion}");
                }
                else
                {
                    Console.WriteLine("Alumno no encontrado.");
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void ActualizarAlumno()
        {
            using (var context = new UniversidadContext())
            {
                Console.WriteLine("Actualización de un Alumno");

                Console.Write("Ingrese el Legajo del Alumno a actualizar: ");
                int legajo;
                while (!int.TryParse(Console.ReadLine(), out legajo))
                {
                    Console.Write("Legajo no válido. Ingrese un número entero: ");
                }

                var alumno = context.Alumnos.FirstOrDefault(a => a.Legajo == legajo);

                if (alumno != null)
                {
                    Console.Write("Ingrese el nuevo Nombre (actual: {0}): ", alumno.Nombre);
                    string nombre = Console.ReadLine();
                    if (!string.IsNullOrEmpty(nombre)) alumno.Nombre = nombre;

                    Console.Write("Ingrese el nuevo Apellido (actual: {0}): ", alumno.Apellido);
                    string apellido = Console.ReadLine();
                    if (!string.IsNullOrEmpty(apellido)) alumno.Apellido = apellido;

                    Console.Write("Ingrese la nueva Dirección (actual: {0}): ", alumno.Direccion);
                    string direccion = Console.ReadLine();
                    if (!string.IsNullOrEmpty(direccion)) alumno.Direccion = direccion;

                    context.SaveChanges();
                    Console.WriteLine("Alumno actualizado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Alumno no encontrado.");
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
        static void EliminarAlumno()
        {
            using (var context = new UniversidadContext())
            {
                Console.WriteLine("Eliminación de un Alumno");

                Console.Write("Ingrese el Legajo del Alumno a eliminar: ");
                int legajo;
                while (!int.TryParse(Console.ReadLine(), out legajo))
                {
                    Console.Write("Legajo no válido. Ingrese un número entero: ");
                }

                var alumno = context.Alumnos.FirstOrDefault(a => a.Legajo == legajo);

                if (alumno != null)
                {
                    context.Alumnos.Remove(alumno);
                    context.SaveChanges();
                    Console.WriteLine("Alumno eliminado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Alumno no encontrado.");
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
        public class Alumno
        {
            public int Id { get; set; }
            public string Apellido { get; set; }
            public string Nombre { get; set; }
            public int Legajo { get; set; }
            public string Direccion { get; set; }
        }
        internal class UniversidadContext: DbContext
        {
            public DbSet<Alumno> Alumnos { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Universidad;Integrated Security=true");
            }
            internal UniversidadContext()
            {
                this.Database.EnsureCreated();
            }

        }
    }
}
