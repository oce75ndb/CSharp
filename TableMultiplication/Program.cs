Console.WriteLine("Révisez vos tables de multiplications !");

while (true) {
    Console.Write("Je souhaite voir la table de ");
    string saisie = Console.ReadLine();

    if (saisie == "") {
        break;
    }
    
    decimal nb1 = Convert.ToDecimal(saisie);

    Console.WriteLine($"Voici la table de {saisie} :");
    
    for (int i = 1; i <= 10; i++) {
        decimal result = nb1 * i;
        Console.WriteLine($"{nb1} x {i} = {result}");
    }
}

