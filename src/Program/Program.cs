using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Abuelo = new Person("Abuelo", 85);                        
            Person Abuela = new Person("Abuela", 88);
            Person Madre = new Person("Madre", 65);
            Person Padre = new Person("Padre", 60);
            Person Hijo = new Person("Hijo", 25);
            Person Hija = new Person("Hija", 34);
            Person Nieta = new Person("Nieta", 5);
            Person Nieto = new Person("Nieto", 3);
            
            Node AbueloNode = new Node(Abuelo);//nodo hoja
            Node AbuelaNode = new Node(Abuela);//nodo hoja
            Node MadreNode = new Node(Madre);
            Node PadreNode = new Node (Padre);
            Node HijoNode = new Node (Hijo);
            Node HijaNode = new Node(Hija);
            Node NietaNode= new Node (Nieta);
            Node NietoNode= new Node (Nieto);

           

            AbueloNode.AddChildren(PadreNode);
            AbuelaNode.AddChildren(MadreNode);
            PadreNode.AddChildren(HijoNode);
            MadreNode.AddChildren(HijaNode);
            HijoNode.AddChildren(NietoNode);

            // visitar el árbol aquí

        }
    }
}
