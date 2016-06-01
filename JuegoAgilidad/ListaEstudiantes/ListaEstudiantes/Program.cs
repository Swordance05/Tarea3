using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstudiantes
{
    class Program
    {
        static int opcion;
        static String[,] arreglo;
        static int leer;
        static int acumulador = 0;




        struct datos
        {

            public String nombre;
            public String sexo;
            public int edad;
            public int id;

        }

        static datos[] matriz;



        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("Cuantos alumnos desea registrar  (Mínimo 5 estudiantes)");
                leer = int.Parse(Console.ReadLine());



            } while (leer < 1);

            //arreglo = new String[leer, 4];

            matriz = new datos[leer];



            do
            {

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Información y censo de estudiantes de la UH");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1° Ingreso de estudiantes");
                Console.WriteLine("2° Modificación de estudiantes");
                Console.WriteLine("3° Borrado de estudiantes");
                Console.WriteLine("4° Búsqueda de estudiantes");
                Console.WriteLine("5° Listado de estudiantes");
                Console.WriteLine("6° Informe clasificación de estudiantes ");
                Console.WriteLine("7° Salir ");
                Console.WriteLine("--------------------------------------------");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {

                    case 1:
                        IngresoEstudiantes();
                        
                        break;

                    case 2:
                        ModificacionEstudiantes();
                        
                        break;

                    case 3:
                        BorradoEstudiantes();
                        
                        break;

                    case 4:
                        BusquedaEstudiante();
                        
                        break;

                    case 5:
                        ListadoEstudiantes();
                        
                        break;

                    case 6:
                        InformeClasificacion();
                        
                        break;

                }

            } while (opcion < 6);

            
        }


        public static void IngresoEstudiantes()
        {



            do
            {

                Console.WriteLine("Ingrese el ID");
                matriz[acumulador].id = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre");
                matriz[acumulador].nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el sexo");
                matriz[acumulador].sexo = Console.ReadLine();

                Console.WriteLine("Ingrese el edad");
                matriz[acumulador].edad = int.Parse(Console.ReadLine());

                Console.WriteLine(matriz[acumulador].id + " " + matriz[acumulador].nombre + " " + matriz[acumulador].sexo + " " + matriz[acumulador].edad);

                acumulador++;




            } while (acumulador < leer);
        }


        public static void ModificacionEstudiantes()
        {

            int respuesta = 0;
            int leer1 = 0;


            Console.WriteLine("Ingrese el ID que desea modificar");
            leer1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < leer; i++)
            {

                if (leer1 == matriz[i].id)
                {

                    Console.WriteLine(matriz[i].id + " " + matriz[i].nombre + " " + matriz[i].sexo + " " + matriz[i].edad);

                    

                        Console.WriteLine("Que dato desea modificar");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("1° Nombre del estudiante");
                        Console.WriteLine("2° Sexo del estudiante");
                        Console.WriteLine("3° Edad del estudiante");

                        respuesta = int.Parse(Console.ReadLine());
                                
                    

                    switch (respuesta)
                    {

                        case 1:

                            Console.WriteLine("Ingrese el nombre");
                            matriz[i].nombre = Console.ReadLine();
                            break;

                        case 2:

                            Console.WriteLine("Ingrese el sexo");
                            matriz[i].sexo = Console.ReadLine();
                            break;

                        case 3:

                            Console.WriteLine("Ingrese la edad");
                            matriz[i].edad = int.Parse(Console.ReadLine());
                            break;


                    }

                    

                }

                else
                {

                    Console.WriteLine("No se encontro el ID del estudiante");


                }
            }
        }


        public static void BorradoEstudiantes()
        {

            int leer2 = 0;

            Console.WriteLine("Ingrese el ID del estudiante que desea eliminar");
            leer2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < leer; i++)
            {

                if (leer2 == matriz[i].id)
                {

                    matriz[i].id = 0;
                    matriz[i].nombre = " ";
                    matriz[i].sexo = " ";
                    matriz[i].edad = 0;

                }

                else
                {

                    Console.WriteLine("No se encontro el ID del estudiante");

                }

            }


        }

        public static void BusquedaEstudiante()
        {

            int leer3 = 0;

            Console.WriteLine("Ingrese el ID del estudiante que desea buscar");
            leer3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < leer3; i++)
            {

                if (leer3 == matriz[i].id)
                {

                    Console.WriteLine("ID: " + matriz[i].id);
                    Console.WriteLine("NOMBRE DEL ESTUDIANTE: " + matriz[i].nombre);
                    Console.WriteLine("SEXO: " + matriz[i].sexo);
                    Console.WriteLine("EDAD: " + matriz[i].edad);


                }

                else
                {

                    Console.WriteLine("No se encontro el ID del estudiante");


                }

            }


        }

        public static void ListadoEstudiantes() {

            Console.WriteLine("============================================");
            Console.WriteLine("            Informe estudiantil             ");
            Console.WriteLine("============================================");
            Console.WriteLine("UNIVERSIDAD UH");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("REG " + "Codigo " + "Nombre " + "Sexo "+ "Edad ");

            for (int i = 0; i < leer; i++) {

                Console.WriteLine(i + 1 + "  " + matriz[i].id + "  " + matriz[i].nombre + "  " + matriz[i].sexo + "  " + matriz[i].edad);

                Console.ReadKey();

                
            }
            Console.Clear();
        }

        public static void InformeClasificacion() {

            int menores = 0, jovenes = 0, adultos = 0, hombres = 0, mujeres = 0;
            String genero = " ";

            Console.WriteLine("===========================================================");
            Console.WriteLine("           Informe Clasificación Estudiantil UH            ");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Clasificación por edad     ||      Clasificación por genero");
            Console.WriteLine("-----------------------------------------------------------");

            for (int y = 0; y < leer; y++){

                if (matriz[y].edad < 18 ) {

                    menores++;

                }

                if (matriz[y].edad >= 18 && matriz[y].edad <= 29) {

                    jovenes++;
                
                }

                if (matriz[y].edad > 30)
                {

                    adultos++;

                }

                genero = matriz[y].sexo.ToLower();

                if (genero.CompareTo("femenino") == 0) {

                    mujeres++;
                
                }

                if (genero.CompareTo("masculino") == 0)
                {

                    hombres++;

                }

                Console.WriteLine("Menores de edad      " + menores);
                Console.WriteLine("Jovenes      "         + jovenes);
                Console.WriteLine("Adultos      "         + adultos);
                Console.WriteLine("                                   " + "Hombres " + hombres);
                Console.WriteLine("                                   " + "Mujeres " + mujeres);
                
                Console.WriteLine("===========================================================");

                Console.WriteLine("Fin de informe");

                Console.ReadKey();

                Console.Clear();
            }

        
        }



    }
}
    

