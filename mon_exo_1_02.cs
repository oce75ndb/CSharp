
Console.WriteLine("Entrez les coefficients a, b et c :");

decimal a = Convert.ToDecimal(Console.ReadLine());
decimal b = Convert.ToDecimal(Console.ReadLine());
decimal c = Convert.ToDecimal(Console.ReadLine());

SolveEquation(a, b, c);
Console.WriteLine("Appuyer sur une touche pour quitter");
Console.ReadLine();

static void SolveEquation(decimal a, decimal b, decimal c) {
    if (a == 0)
    {
        if (b != 0)
        {
            decimal solution = -c / b;
            Console.WriteLine("Solution : " + solution);
        }
        else if (c != 0)
        {
            Console.WriteLine("Pas de solution.");
        }
        else
        {
            Console.WriteLine("Infiniment de solutions.");
        }
    }
    else
    {
        decimal discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("Pas de solution réelle.");
        }
        else if (discriminant == 0)
        {
            decimal solution = -b / (2 * a);
            Console.WriteLine("Solution unique : " + solution);
        }
        else
        {
            decimal racine1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            decimal racine2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Deux solutions réelles distinctes : " + racine1 + " et " + racine2);
        }
    }
}