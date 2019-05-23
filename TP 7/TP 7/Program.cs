using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado NuevoEmpleado = new Empleado();

            List<Empleado> Empleados = new List<Empleado>();

            double antiguedad, sueldoBasico = 20000;

            double adicional = 0;

            double sueldoTotal = 0;

            int edad, cargo;
            
            char eleccion;

            for (int i = 0; i<2; i++)
            {
            
                Console.Write("Ingrese su apellido\n");

                NuevoEmpleado.Apellido = Console.ReadLine();


                Console.Write("Ingrese su nombre\n");

                NuevoEmpleado.Nombre = Console.ReadLine();

                Console.Write("Su cargo es : [0]" + Cargo.Auxiliar + "\n [1]" + Cargo.Administrativo + "\n [2]" + Cargo.Ingeniero + "\n [3]" + Cargo.Especialista + "\n [4]" + Cargo.Investigador);
                Console.Write("\n Seleccione utilizando el numero correspondiente\n");

                cargo = int.Parse(Console.ReadLine());

                switch(cargo)
                {
                    case 0:
                        NuevoEmpleado.Cargo = Cargo.Auxiliar;
                        break;

                    case 1:
                        NuevoEmpleado.Cargo = Cargo.Administrativo;
                        break;

                    case 2:
                        NuevoEmpleado.Cargo = Cargo.Ingeniero;
                        break;

                    case 3:
                        NuevoEmpleado.Cargo = Cargo.Especialista;
                        break;

                    case 4:
                        NuevoEmpleado.Cargo = Cargo.Investigador;
                        break;

                    default:
                        Console.Write("No selecciono un cargo valido \n");
                        break;
                }


                Console.Write("Ingrese su genero (masculino/ femenino)\n");

                NuevoEmpleado.Genero = Console.ReadLine();


                Console.Write("Ingrese su fecha de nacimiento\n");

                NuevoEmpleado.FechaDeNacimiento = DateTime.Parse(Console.ReadLine());

                edad = DateTime.Now.Year - NuevoEmpleado.FechaDeNacimiento.Year;

                Console.Write("Su edad es: " + edad + "\n");

                if (NuevoEmpleado.Genero == "masculino")
                {
                    Console.Write("Le faltan " + (65 - edad) + " para jubilarse\n");
                }
                else
                {
                    Console.Write("Le faltan " + (60 - edad) + " para jubilarse\n");
                }


                Console.Write("Ingrese su fecha de ingreso\n");

                NuevoEmpleado.FechaDeIngreso = DateTime.Parse(Console.ReadLine());

                antiguedad = DateTime.Now.Year - NuevoEmpleado.FechaDeIngreso.Year;

                adicional = (antiguedad / 100) * sueldoBasico;


                Console.Write("¿Usted es casado/a? (s/n)\n");

                eleccion = char.Parse(Console.ReadLine());

                if (eleccion.Equals('s'))
                {
                    NuevoEmpleado.EstadoCivil = EstadoCivil.Casado;

                    Console.Write("¿Usted es Ingeniero/a o Especialista? (s/n)\n");

                    eleccion = char.Parse(Console.ReadLine());

                    if (eleccion.Equals('s'))
                    {
                        adicional = adicional + (adicional * 0.5);

                        Console.Write("¿Tiene dos o mas hijos? (S/N)\n");

                        eleccion = char.Parse(Console.ReadLine());

                        if (eleccion.Equals('s'))
                        {
                            adicional = adicional + 5000;
                        }
                    }
                    else
                    {
                        Console.Write("¿Tiene dos o mas hijos? (s/n)\n");

                        eleccion = char.Parse(Console.ReadLine());

                        if (eleccion.Equals('s'))
                        {
                            adicional = adicional + 5000;
                        }
                    }
                }
                else
                {
                    NuevoEmpleado.EstadoCivil = EstadoCivil.Soltero;

                    Console.Write("¿Usted es Ingeniero/a o Especialista? (s/n)\n");

                    eleccion = char.Parse(Console.ReadLine());

                    if (eleccion.Equals('s'))
                    {
                        adicional = adicional + (adicional * 0.5);
                    }
                }

                NuevoEmpleado.Sueldo = sueldoBasico + adicional;

                Console.Write("Su sueldo es de: " + NuevoEmpleado.Sueldo + "\n");

                Empleados.Add(NuevoEmpleado);
            }

            foreach (Empleado unEmpleado in Empleados)
            {
                sueldoTotal = sueldoTotal + unEmpleado.Sueldo;
            }
            
            Console.Write("El gasto total en sueldos es de: " + sueldoTotal + "\n");
            Console.Write("La empresa tiene un total de: " + Empleados.Count() + "\n");

            Console.ReadKey();
        }

        public enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        public enum EstadoCivil
        {
            Casado,
            Soltero
        }

        public struct Empleado
        {
            private string nombre;

            private string apellido;

            private DateTime fechaDeNacimiento;

            private EstadoCivil estadoCivil;

            private string genero;

            private DateTime fechaDeIngreso;

            private double sueldo;

            private Cargo cargo;



            public string Nombre
            {
                get
                {
                    return nombre;
                }

                set
                {
                    nombre = value;
                }
            }

            public string Apellido
            {
                get
                {
                    return apellido;
                }

                set
                {
                    apellido = value;
                }
            }

            public EstadoCivil EstadoCivil
            {
                get
                {
                    return estadoCivil;
                }

                set
                {
                    estadoCivil = value;
                }
            }

            public string Genero
            {
                get
                {
                    return genero;
                }

                set
                {
                    genero = value;
                }
            }

            public DateTime FechaDeIngreso
            {
                get
                {
                    return fechaDeIngreso;
                }

                set
                {
                    fechaDeIngreso = value;
                }
            }

            public double Sueldo
            {
                get
                {
                    return sueldo;
                }

                set
                {
                    sueldo = value;
                }
            }

            public Cargo Cargo
            {
                get
                {
                    return cargo;
                }

                set
                {
                    cargo = value;
                }
            }

            public DateTime FechaDeNacimiento
            {
                get
                {
                    return fechaDeNacimiento;
                }

                set
                {
                    fechaDeNacimiento = value;
                }
            }            
        }
    }
}