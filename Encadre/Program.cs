encadre("Bonjour je suis océane, \net vous ?");

// Fonction qui affiche un texte dans un rectangle
void encadre(string texte) {
    //Calcul h(nb de lignes) et l(longueur + grande ligne) du texte
    string[] lignes = texte.Split('\n');
    Console.WriteLine(lignes[0]);
    Console.WriteLine(lignes[1]);
}