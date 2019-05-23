using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> Empleados = new List<Empleado>();

            double sueldoBasico = 20000;

            double adicional = 0;

            char eleccion;

            string nombre;

            Console.Write("Ingrese su apellido");

            Console.ReadLine(Empleado.Nombre);


        }

        public enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            especialista,
            Investigador
        }

        public enum EstadoCivil
        {
            Casado,
            Soltero
        }

        public struct Empleado
        {
            public string nombre;

            public string apellido;

            public DateTime fechaDeNacimiento;

            public int edad;

            public string estadoCivil;

            public string genero;

            public DateTime fechaDeIngreso;

            public double sueldo;

            public string cargo;



            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }

            public int Edad(int fechaDeNacimiento)
            {
                return edad = DateTime.Today.AddTicks(-fechaDeNacimiento).Year - 1;
            }

            public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
            public string Genero { get => genero; set => genero = value; }
            public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
            public double Sueldo { get => sueldo; set => sueldo = value; }
            public string Cargo { get => cargo; set => cargo = value; }
        }
    }
}
