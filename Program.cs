using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Jugador
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Club { get; set; }
}

public class Jugador_Descendido : Jugador, IJugadorDescendido
    {
       
        
        public void Descender() 
        {
            Console.WriteLine( "Me fui a la B");
        }
        
        public void Quemar()
        {
            Console.WriteLine("Quemé mi cancha");
        }
        public void Noquemar()
        {
        Console.WriteLine("Pero no quemé mi cancha");
        }

}

interface IJugadorDescendido
    {
        void Descender();
        void Quemar();
        void Noquemar();
    }


class Program
{
    static void Main(string[] args)
    {
        Jugador_Descendido Francisco = new Jugador_Descendido();
        Console.WriteLine("Hola soy Francisco");
        Francisco.Descender();
        Francisco.Quemar();

        Jugador_Descendido Jorge = new Jugador_Descendido();
        Console.WriteLine("Hola soy Jorge");
        Jorge.Descender();
        Jorge.Noquemar();
        
    }
}