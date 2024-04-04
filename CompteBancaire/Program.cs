using System;

namespace exopoo
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte = new CompteBancaire("Dupont", "Marie", 500, true);
            Console.WriteLine(compte.ToString());
            
            // Créditer compte
            compte.Crediter(3200);

            // Afficher info compte
            compte.Afficher();

            // Débiter compte
            compte.Debiter(1200);

            // Re Afficher info compte
            compte.Afficher();
        }
    }
}