const char LIGNE_HORIZONTALE = '\u2550';
const char LIGNE_VERTICALE = '\u2551';
const char COIN_HAUT_GAUCHE = '\u2554';
const char COIN_HAUT_DROITE = '\u2557';
const char COIN_BAS_DROITE = '\u255D';
const char COIN_BAS_GAUCHE = '\u255A';

encadre("Bonjour je suis océane, \net vous ?");

// Fonction qui affiche un texte dans un rectangle
void encadre(string texte) {
    //Calcul h(nb de lignes) et l(longueur + grande ligne) du texte
    string[] lignes = texte.Split('\n');
    int nb_lignes = lignes.Length;
    Console.WriteLine($"{nb_lignes} lignes");

    int nb_colonnes = 0;
    for (int i = 0; i<lignes.Length; i++) {
        Console.WriteLine(lignes[i] + " " + lignes[i].Length);
        if (lignes[i].Length > nb_colonnes) {
            nb_colonnes = lignes[i].Length;
        }
    }
    Console.WriteLine($"{nb_lignes} lignes et {nb_colonnes} colonnes");

    //Ecriture de la 1ère ligne
    Console.WriteLine(COIN_HAUT_GAUCHE.ToString() + new string (LIGNE_HORIZONTALE, nb_colonnes) + COIN_HAUT_DROITE);
    //Ecriture ligne milieu
    for (int i = 0; i<lignes.Length; i++) {
        //Console.WriteLine(nb_colonnes-lignes[i].Length);
        Console.WriteLine(LIGNE_VERTICALE + lignes[i] + new string(' ', (nb_colonnes-lignes[i].Length)) + LIGNE_VERTICALE);
    }

    //Ecriture de la dernière ligne
    Console.WriteLine(COIN_BAS_GAUCHE + new string (LIGNE_HORIZONTALE, nb_colonnes) + COIN_BAS_DROITE);

}