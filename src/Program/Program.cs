using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Abuelo = new Person("Abuelo", 85);                        Person Abuelo = new Person("Abuelo", 75);
            Person Abuela = new Person("Abuela", 88);
            Person Madre = new Person("Madre", 65);
            Person Padre = new Person("Padre", 60);
            Person Hijo = new Person("Hijo", 25);
            Person Hija = new Person("Hija", 34);
            Person Nieta = new Person("Nieta", 5);
            Person Nieto = new Person("Nieto", 3);
            Node Node = new Node();//nodo hoja
           

            AbueloNode.AddChildren(Padre);
            AbuelaNode.AddChildren(Madre);
            MadreNode.AddChildren(Padre);
            PadreNode.AddChildren(Madre);
            HijaNode.AddChildren(Padre);
            HijoNode.AddChildren(Madre);
            NietoNode.AddChildren(Padre);
            NietaNode.AddChildren(Madre);
          

            // visitar el árbol aquí

        }
    }
}
