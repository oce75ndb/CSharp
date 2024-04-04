using System;

namespace exopoo
{
    public class CompteBancaire
    {
        // Privés
        private decimal _solde;
        private bool _actif;

        // Propriétés en lecture seule
        public decimal Solde { get { return _solde; } }
        public string Nom { get; }
        public string Prenom { get; }
        public bool Actif { get { return _actif; } }

        // Propriété en lecture et écriture
        public decimal DecouvertAutorise { get; set; }

        // Constructeur par défaut
        public CompteBancaire()
        {
            _solde = 0;
            Nom = string.Empty;
            Prenom = string.Empty;
            _actif = false;
            DecouvertAutorise = 0;
        }

        // Constructeur avec paramètres
        public CompteBancaire(string nom, string prenom, decimal decouvertAutorise, bool actif)
        {
            _solde = 0;
            Nom = nom;
            Prenom = prenom;
            _actif = actif;
            DecouvertAutorise = decouvertAutorise;
        }

        // Méthode pour créditer compte
        public void Crediter(decimal montant)
        {
            if (!_actif)
            {
                throw new InvalidOperationException("Le compte n'est pas actif.");
            } 

            _solde += montant;
        }

        // Méthode pour débiter compte
        public void Debiter(decimal montant)
        {
            if (!_actif)
            {
                throw new InvalidOperationException("Le compte n'est pas actif.");
            }

            if (_solde - montant < -DecouvertAutorise)
            {
                throw new InvalidOperationException("Dépassement du découvert autorisé.");
            }

            _solde -= montant;
        }

        // Méthode pour activer compte
        public void Activer()
        {
            _actif = true;
        }

        // Méthode pour désactiver compte
        public void Desactiver()
        {
            _actif = false;
        }

        // Méthode pour afficher info compte
        public void Afficher()
        {
            Console.WriteLine(Nom + " " + Prenom + " - Solde: " + Solde + " - Actif: " + Actif);
        }
    }
}