using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqDemo
{   class NombreCompleto
    {
       public string nombre { get; set; }
        public string apellido { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var estudiantes = new[]
{
                new
                {
                    EstudianteID = 1,
                    Nombre = "Héctor",
                    ApellidoPaterno = "Pérez",
                    Universidad = "Real de Brasil"
                },
                new
                {
                    EstudianteID = 2,
                    Nombre = "Ana",
                    ApellidoPaterno = "Nepomuceno",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 3,
                    Nombre = "Pedro",
                    ApellidoPaterno = "Sánchez",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 4,
                    Nombre = "José",
                    ApellidoPaterno = "Infante",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 5,
                    Nombre = "Regina",
                    ApellidoPaterno = "Bustamante",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 6,
                    Nombre = "Rodrigo",
                    ApellidoPaterno = "Jiménez",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 7,
                    Nombre = "Miguel",
                    ApellidoPaterno = "Hernández",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 8,
                    Nombre = "Marilyn",
                    ApellidoPaterno = "Monroe",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 9,
                    Nombre = "Leonardo",
                    ApellidoPaterno = "Estrada",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 10,
                    Nombre = "Ricardo",
                    ApellidoPaterno = "Rojas",
                    Universidad = "Real de Brasil"
                },
            };

            var universidades = new[]
            {
                new
                {
                    Universidad = "Real de Brasil",
                    Ciudad = "Brasilia",
                    Pais = "Brasil"
                },
                new
                {
                    Universidad = "Oxford",
                    Ciudad = "Oxford",
                    Pais = "Reino Unido"
                },
                new
                {
                    Universidad = "Harvard",
                    Ciudad = "Cambridge",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "Brooklyn",
                    Ciudad = "Nueva York",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "UNAM",
                    Ciudad = "Ciudad de México",
                    Pais = "México"
                },
            };

            //IEnumerable<string> nombreEstudiante = estudiantes.Select(e => $"{e.Nombre},{e.ApellidoPaterno}");
            //IEnumerable<NombreCompleto> nombreEstudiante = estudiantes.Select(e => new NombreCompleto
            //{ nombre = e.Nombre,
            //  apellido = e.ApellidoPaterno
            //});
            //Tipo anonimo
            //var nombreEstudiante = estudiantes.Select(e => new 
            // {
            //     nombre = e.Nombre,
            //     apellido = e.ApellidoPaterno
            // });
            //la misma consulta con operadores de lenguaje
            // var nombreEstudiante = from nombres in estudiantes select nombres.Nombre;
            var nombreEstudiante = from nombres in estudiantes select new { nombres.Nombre, nombres.ApellidoPaterno };
            foreach (var nombre in nombreEstudiante)
            {
                Console.WriteLine(nombre);
            }
            //192 Filtra universidades de Eu
            //var universidadesEu = universidades.Where(e => e.Pais == "Estados Unidos").Select(e => e.Universidad);

            var universidadesEu = from univ in universidades
                                  where string.Equals(univ.Pais, "Estados Unidos")
                                  select (univ.Universidad);
            foreach (var u in universidadesEu)
            {
                {
                    Console.WriteLine(u);
                }
            }

            //194 Ordenando en forma alfabetica
            // IEnumerable<string> nombreUniversidades = universidades.OrderBy(u => u.Universidad).Select(u => u.Universidad);
            //IEnumerable<string> nombreUniversidades = universidades.OrderByDescending(u => u.Universidad)
            //    .ThenBy(u =>u.Pais)
            //    .Select(u => u.Universidad);

            var nombreUniversidades = from u in universidades
                                      orderby u.Universidad descending
                                      select u.Universidad;

            foreach (var u in nombreUniversidades)
            {
                {
                    Console.WriteLine(u);
                }
            }

            //Group By
            //var universidadesPais = universidades.GroupBy(u => u.Pais);

            var universidadesPais = from u in universidades
                                    group u by u.Pais;

            foreach (var grupo in universidadesPais)
            {
                Console.WriteLine($"Universidades: {grupo.Key} \t {grupo.Count()}");
                foreach (var g in grupo)
                {
                    Console.WriteLine($"\t {g.Universidad}");
                }
            }
            //Metodos de Resumen
            //  int universidad = universidades.Select(u => u.Pais).Distinct().Count();
            int universidad = (from u in universidades
                               select u.Pais).Distinct().Count();
            Console.WriteLine(universidad);
            ////jOIN
            //var join = estudiantes.Select(e => new
            //    { e.Nombre,
            //      e.ApellidoPaterno,
            //      e.Universidad
            //      }).Join(universidades,e => 
            //      e.Universidad, 
            //      u => u.Universidad,
            //      (e,u)=> new {e.Nombre,e.ApellidoPaterno,u.Pais}
            //      );
            var join = from u in universidades
                       join e in estudiantes
                       on u.Universidad equals e.Universidad
                       select new
                       {
                           e.Nombre,
                           e.ApellidoPaterno,
                           u.Universidad,
                           u.Pais
                       };
            foreach (var fila in join)
            {
                Console.WriteLine(fila);
            }
           // Queremos tomar 2 filas de estudiantes, salta 1 y tomar los siguintes 2 elementos
            var est = estudiantes.Skip(1).Take(2);
            foreach (var e in est)
            {
                Console.WriteLine(e);
            }

            var cualquiera = estudiantes.Any(x => x.Nombre.StartsWith("H"));

            var todos = estudiantes.All(x => x.Nombre != null);
            var primero = estudiantes.First(x => x.Nombre.StartsWith("H"));

            var primeros = estudiantes.FirstOrDefault(x => x.Nombre.StartsWith("z"));

            //198
            var estudiante = estudiantes.Select(x => x.Nombre).ToList();
            foreach(var e in estudiante)
            {
                Console.WriteLine(e);
            }
            estudiantes[0] = new
            {
                EstudianteID = 1,
                Nombre = "H",
                ApellidoPaterno = "Pé",
                Universidad = "Real"
            };
            foreach (var e in estudiante)
            {
                Console.WriteLine(e);
            }
        }
    }
}
