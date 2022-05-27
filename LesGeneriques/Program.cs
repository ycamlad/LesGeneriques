using System;

namespace LesGeneriques
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SalleService ss = new SalleService();
            ss.Create(new Salle("A","Salle 1"));
            ss.Create(new Salle("B", "Salle 2"));
            ss.Create(new Salle("C", "Salle 3"));
            ss.Create(new Salle("A", "Salle 4"));

            Console.WriteLine("La liste des salles :");
            foreach (Salle salle in ss.FindAll())
                Console.WriteLine("\t" + salle);
        }
    }
}