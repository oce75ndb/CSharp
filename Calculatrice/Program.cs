Console.WriteLine("Bienvenue dans la calculatrice !");

decimal result = 0;

while (true) {

    Console.Write("Entrez un nombre : ");
    decimal nb1 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Entrez un opérateur (+, -, *, /) : ");
    string op = Console.ReadLine();

    Console.Write("Entrez le deuxième nombre : ");
    decimal nb2 = Convert.ToDecimal(Console.ReadLine());

    switch (op) {

        case "+":
            result =  nb1 +  nb2;
            break;
        case "-":
            result =  nb1 -  nb2;
            break;
        case "*":
            result =  nb1 *  nb2;
            break;
        case "/":
            result =  nb1 /  nb2;
            break;
        default:
            Console.WriteLine("Opérateur invalide.");
            break;
    }

    Console.WriteLine($"Le résultat de {nb1} {op} {nb2} = {result}");
}

