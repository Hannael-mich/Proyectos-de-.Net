/*using System;

namespace ProyectiHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo miBabieca = new Caballo("babieca");
            
            Humano miJuan = new Humano("Juan");

            Gorila miCopito = new Gorila("Copito");


            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;

            almacenAnimales[1] = miJuan;

            almacenAnimales[2] = miCopito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Mamiferos miMamifero = new Mamiferos("");

            miMamifero.respirar();

        }
    }

    class Mamiferos
    {

        public Mamiferos(Stream nombre)
        {
            nombreServivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas ");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreServivo);
        }

        private String nombreServivo;
    }


    class Caballo : Mamiferos
    {
        public Caballo (String nombre);
    }
}*/

using System;

// Definición de la interfaz IVehiculo
public interface IVehiculo
{
    void Arrancar();
    void Detener();
    void Acelerar();
    void Girar();
}

public interface IObjeto
{
    void prueba1();
    void prueba2();
    void prueba3();
    void prueba4();


}

// Clase que implementa la interfaz IVehiculo
public class Coche : IVehiculo, IObjeto
{
    public void Arrancar()
    {
        Console.WriteLine("El coche ha arrancado.");
    }

    public void Detener()
    {
        Console.WriteLine("El coche se ha detenido.");
    }

    public void Acelerar()
    {
        Console.WriteLine("El coche está acelerando.");
    }

    public void Girar()
    {
        Console.WriteLine("El coche está girando.");
    }

    public void prueba1()
    {
        Console.WriteLine("Solo es una prueba");
    }

    public void prueba2()
    {
        Console.WriteLine("Segunda prueba");
    }

    public void prueba3()
    {
        Console.WriteLine("Tercera prueba");
    }

    public void prueba4()
    {
        Console.WriteLine("Cuarta prueba");
    }

    public void algo()
    {
        Console.WriteLine("Hola");
    }

    public int numero { get; set; }


}

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Coche
        Coche miCoche = new Coche();

        Coche suCoche = new Coche();

        Coche elCoche = new Coche();

        // Utilizar la instancia a través de la interfaz IVehiculo
        Console.WriteLine("Usando el coche:");
        miCoche.Arrancar();
        miCoche.Acelerar();
        miCoche.Girar();
        miCoche.Detener();


        Console.WriteLine("\nSe esta usando su coche:");
        suCoche.prueba1();
        suCoche.prueba2();
        suCoche.prueba3();
        suCoche.prueba4();

        

        suCoche.algo();

        suCoche.numero=15;

        elCoche.numero = 32;


        Console.WriteLine("Valor de su coche " + suCoche.numero);
        Console.WriteLine("\nEl valor del coche " + elCoche.numero);

        suCoche.numero = 100;

        Console.WriteLine("\nSe modifico el valor de su coche " + suCoche.numero);
    }
}


