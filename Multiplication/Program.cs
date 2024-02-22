const char LIGNE_HORIZONTALE = '\u2550';
const char LIGNE_VERTICALE = '\u2551';
const char COIN_HAUT_GAUCHE = '\u2554';
const char COIN_HAUT_DROITE = '\u2557';
const char COIN_BAS_DROITE = '\u255D';
const char COIN_BAS_GAUCHE = '\u255A';

/*const int NB_LIGNES = 15;
const int NB_COLONNES = 25;*/

Rectangles(2, 20);


void Rectangles(int ligne, int colonne) {
    //Ligne 1
    Console.WriteLine();
    Console.Write(COIN_HAUT_GAUCHE);
    for (int i=0; i<colonne; i++) {
        Console.Write(LIGNE_HORIZONTALE);
    }
    Console.WriteLine(COIN_HAUT_DROITE);

    //Lignes Intermediaires
    for (int i=0; i<ligne; i++) {
        Console.Write(LIGNE_VERTICALE);
       // for (int j=0; j<colonne;j++) {
        Console.Write("   Je suis océane   ");
        //}
        Console.WriteLine(LIGNE_VERTICALE);
    }

    //Dernière Ligne
    Console.Write(COIN_BAS_GAUCHE);
    for (int i=0; i<colonne; i++) {
        Console.Write(LIGNE_HORIZONTALE);
    }
    Console.WriteLine(COIN_BAS_DROITE);
}

