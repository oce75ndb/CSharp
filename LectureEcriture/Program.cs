// Demander le nom de l'utilisateur et afficher un message de bienvenue personnalisé

Console.Write("Veuillez entrer votre prénom : ");
string prenom = Console.ReadLine();

Console.WriteLine($"Hello {prenom}, bon retour parmis nous ! ");

Console.Write("Appuyez sur une touche pour quitter");
Console.ReadKey();

string saisie = Console.ReadLine();

int n = saisie * 2;
Console.WriteLine(n);
