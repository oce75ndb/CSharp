Console.WriteLine("Révisez vos tables de multiplications !");

decimal nb1;

while (true) {
    Console.Write("Je souhaite voir la table de ");
    string saisie = Console.ReadLine();
    
    if (saisie == "") {
        break;
    }

    if (!decimal.TryParse(saisie, out nb1)) {
        Console.WriteLine("Veuillez rentrer un nombre valide");
        continue;
    }

    Console.WriteLine($"Voici la table de {saisie} : ");
    for (int i = 1; i <= 10; i++) {
        decimal result = nb1 * i;
        Console.WriteLine($"{nb1} x {i} = {result}");
    }
}
