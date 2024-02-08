Console.WriteLine("Nombre Mystère");

// Définir un nombre mystère entre 1 et 100 sous forme de constante entière
// Demander le nom du user et afficher msg de bienvenue
// Demander un nombre au user

const int NOMBRE_MYSTERE = 89;
const int MIN = 0;
const int MAX = 100;

Console.Write("Veuillez entrer votre prénom : ");
string prenom = Console.ReadLine();

Console.Write($"Veuillez entrer un nombre entre {MIN} et {MAX} : ");
string chaine = Console.ReadLine();

int nb = int.Parse(chaine);

Console.WriteLine($"Hello {prenom}, bon retour parmis nous ! ");

if (nb == NOMBRE_MYSTERE) {
    Console.WriteLine($"Bravo le nombre mystère est bien {NOMBRE_MYSTERE}.");
} else {
    Console.WriteLine($"Essaye encore !");
}