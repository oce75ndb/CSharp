Console.WriteLine("Nombre Mystère");

// Définir un nombre mystère entre 1 et 100 sous forme de constante entière
// Demander le nom du user et afficher msg de bienvenue
// Demander un nombre au user

const int Max = 100;

Console.Write("Veuillez entrer votre prénom : ");
string prenom = Console.ReadLine();

Console.Write("Veuillez entrer un nombre : ");
string nb = Console.ReadLine();

Console.WriteLine($"Hello {prenom}, bon retour parmis nous ! ");
Console.WriteLine($"Votre nombre est {nb}.");