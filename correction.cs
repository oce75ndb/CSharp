// ax + b = 0

//Soit on met les float ici, soit on les mets direct dans les lignes suivantes.

//float a;
//float b;

Console.WriteLine("Entrez la valeur de a : ");
float a = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Entrez la valeur de b : ");
float b = Convert.ToSingle(Console.ReadLine());

float x = -b/a;
Console.WriteLine($"x prend la valeur {x}");