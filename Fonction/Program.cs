int addition(int a, int b) {
    return a+b;
}

Console.WriteLine(addition(1,2));

int factorielle(int a) {
    int c = 1;
    for (int i = 2; i <= a; i++) {
        Console.WriteLine($"i = {i}, c = {c}");
        c = c * i;
    }
    return c;
}

Console.WriteLine(factorielle(8));