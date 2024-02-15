const int MAX = 100;
const int MIN = 1;
const int NOMBRE_MYSTERE = 42;

Console.Write("Veuillez entrer votre prénom : ");
string prenom = Console.ReadLine();

bool trouve = false;
List<int> nombreSaisis = new List<int>();

while(!trouve) {
    int nbSaisi = 0;

    Console.Write("Nombres déjà proposés : ");
    foreach (int nb in nombreSaisis)
    {
            Console.Write($"{nb} ");
    }
    Console.WriteLine(); //passage à la ligne
    Console.WriteLine($"Veuillez entrer un nombre entre {MIN} et {MAX}");
    nbSaisi = int.Parse(Console.ReadLine());
    nombreSaisis.Add(nbSaisi);

    if(nbSaisi == NOMBRE_MYSTERE) {
        Console.WriteLine("Vous avez trouvé !!");
        trouve = true;
    }
    else {
        if(nbSaisi>NOMBRE_MYSTERE)
            Console.WriteLine("Le nombre mystère est plus petit");
        else
            Console.WriteLine("Le nombre mystère est plus grand");
    }
}