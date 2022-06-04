using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   //Dichos nombres son las propiedades
               Caballo gabieca = new Caballo("Babieca");

               Humano Juan = new Humano("Juan");

               Gorilla copito = new Gorilla("Copito");

               //principio de susitucion (es siempre un...) para saber si un caballo, humano etc es siempre un mamifero
               //aqui se lee al reves ya que lo que se guarda es un objeto caballo, por lo que un caballo es siempre un mamifero
               //pero un mamifero no es siempre un caballo por lo que puede guardar otros objetos como humanos y gorillas
               Mamiferos Animal = new Caballo("Bucefalo");
               //hay que tener cuenta con esto ya que solo heredara los metodos y propiedades de mamifero
               Mamiferos persona = new Humano("Lenny");
               //si se utiliza con una instancia si se sutituye
               Animal = gabieca;
               //Obeject es la clase cosmica que siempre esta por encima de todo
               //El principio de sustitucion viene muy bien para los arrays ya que puede almacenear diferentes mamiferos

               Mamiferos[] almacenAnimales = new Mamiferos[3];

               almacenAnimales[0] = Juan;
               almacenAnimales[1] = copito;
               almacenAnimales[2] = gabieca;

               //aqui se nota mas el virtual y el override, no llama a otro metodo sino al mismo pero sobreescrito
               //esto es polimorfismo, adquiere diferentes formas dependiendo del contexto
               for (int i = 0; i < 3; i++)
               {
                   almacenAnimales[i].pensar();
               }
               ballena wally = new ballena("No soy wally");
               wally.getNombre();

               Console.WriteLine("Numero de patas de mi gabieca {0}", gabieca.numeroPatas());

               */

            Lagartiza juancho = new Lagartiza("Juanchito");

            juancho.Respirar();

            juancho.getNombre();

            Humano Juan = new Humano("Juan");

            Juan.Respirar();

            Juan.getNombre();

        }
    }
    //Es como un conjunto de reglas que le pones a la clase para que se desarrole
    //En la interfaz se define el comportamiento de la clase que la implemente y luego cada clase
    // desarrolla como se implementara
    interface IMamiferos
    {
        //los metodos de la interfaces simplemente se declaran ni tampoco necesitan modificadores de acceso
        //Todo lo descrito en el metodo debe coincidir exctamente
        int numeroPatas();
    }
    //en la clases abstratas hay que desarrollar al menos un metodo abtrascto para que sea abstracta
    //funcionan similar a la interfaz es como una fucion entre interfaz y clase donde hereda y tambien obliga
    abstract class Animales
    {//esto hace que solo sea accesible desde la misma clase y de las clases que hereda
        //publica de las que lo heredan, privado de otras clases
        public void Respirar() => Console.WriteLine("Soy capaz de respirar");

        public abstract void getNombre();

    }

    class Lagartiza : Animales
    {
        public Lagartiza(string nombre)
        {
            nombreReptil = nombre;
        }
        private string nombreReptil;

        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es " + nombreReptil);
        }
    }

    class Mamiferos:Animales
    {
        //esto es un metodo de acceso
        // esto es encapsulacion y basicamente dice que accede desde la propia clase o contexto igual que algunos elementos
        // de la derecha y algunas clases permites que se dividadan en modulas y trabajar cada una por su lado
        private string nombreMamifero;

        //Las propiedades, parametros o datos de los constructores son heredados
        //se utiliza en la creacion del metodo estado nombre(valor nombre):base(nombre){} para llamas dichos datos
        // para herdedar una clase es utiliza el subclase:SuperClase

        

        

        public Mamiferos(String nombre)
        {
            nombreMamifero = nombre;
        }
        public override void getNombre() => Console.WriteLine("El nombre del mamifero es: " + nombreMamifero);
        

        public void CuidarCrias() => Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");

        //virtual hace que el metodo sea visto para ser sobreescritos
        public virtual void pensar() => Console.WriteLine("Estoy pensando de modo basico xd");
    }
    class ballena : Mamiferos
    {
        public ballena(string nombreBallena) : base(nombreBallena)
        {

        }
        public void gluglu() => Console.WriteLine("Soy glugluglu");
    }
    class Caballo : Mamiferos, IMamiferos
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }
        public void Galopear() => Console.WriteLine("Soy capaz de galopear");

        public int numeroPatas()
        {
            return 4;
        }

    }
    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
        //si ponemos new antes del public el metodo se crea como nuevo metodo con el mismo nombre
        //si ponemos override (que se traduce mas o menos como sobre-escritura) el metodo se modifica en ves de ser uno nuevo
        public override void pensar() => Console.WriteLine("Soy capaz de pensar");
    }
    // sealed sirve para que no herede la clase
     sealed class Gorilla : Mamiferos

    {
        public Gorilla(string nombreGorilla) : base(nombreGorilla)
        {

        }
        public  void Trepar() => Console.WriteLine("Soy capaz de trepar");

        // lo mismo pasa con el sealed
        public sealed override void pensar() => Console.WriteLine("Soy capaz de pensar epicamente");
    }

    /*class chimpance:Gorilla
    {
        public chimpance(string nombreChimpance):base(nombreChimpance)
        {

        }
    }*/
}
