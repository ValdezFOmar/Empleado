using System;
using System.Collections.Generic;



namespace Empleado
{

    class Empleado
    {
        //Campos
        private string nombre;
        private int salario;
        
        //Propiedades (encapsula campos y usar propiedades)
        public string Nombre { get => nombre; set => nombre = value; }
        public int Salario { get => salario; set => salario = value; }

        //Constructores
        public Empleado()
        {
            Nombre = "No existe";
        }

        //Sobrecargar los metodos
        public Empleado(string nom, int Salario)
        {
            Nombre = nom;
            this.Salario = Salario;
        }

        public Empleado(string nom)
        {
            Nombre = nom;
            this.Salario = 0;
        }
        //Metodos
        public void Imprime()
        {
            Console.WriteLine($"{Nombre}, {Salario}");
        }

        
    }  


    class Program
    {
        static void Main(string[] args)
        {
            //Lista(Se pueden seguir agregando elementos a diferencia de un alegro.)
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add( new Empleado("Joe", 123000));
            empleados.Add(new Empleado("Tom", 123000));
            empleados.Add(new Empleado("Ana", 200000));

            //Inicializacion
            //Empleado e1 = new Empleado("Tom", 123000);
            //Empleado e2 = new Empleado("Ana");

            empleados[0].Imprime();
            empleados[1].Imprime();
            empleados[2].Imprime();

            Empleado empdelmes = empleados[2];
            empdelmes.Imprime();

            //Despliegue en consola
            //e1.Imprime();
            //e2.Imprime();

            Console.ReadKey();
        }
    }
}
