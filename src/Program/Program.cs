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
            
        Node<Person> AbueloNode = new Node<Person>(Abuelo);
        Node<Person> AbuelaNode = new Node<Person>(Abuela);
        Node<Person> MadreNode = new Node<Person>(Madre);
        Node<Person> PadreNode = new Node<Person>(Padre);
        Node<Person> HijoNode = new Node<Person>(Hijo);
        Node<Person> HijaNode = new Node<Person>(Hija);
        Node<Person> NietaNode = new Node<Person>(Nieta);
        Node<Person> NietoNode = new Node<Person>(Nieto);


           

            AbueloNode.AddChildren(PadreNode);
            AbuelaNode.AddChildren(MadreNode);
            PadreNode.AddChildren(HijoNode);
            MadreNode.AddChildren(HijaNode);
            HijoNode.AddChildren(NietoNode);
            HijaNode.AddChildren(NietaNode);

            // visitar el árbol aquí

        }
    }
}
