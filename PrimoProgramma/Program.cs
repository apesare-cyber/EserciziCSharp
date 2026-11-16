
int num1, num2;

Console.WriteLine("Inserisci un numero intero: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci un altro numero intero: ");
num2 = int.Parse(Console.ReadLine());

int somma = num1 + num2;
Console.WriteLine("La somma dei due numeri è: " + somma);

int diff = num1 - num2;
Console.WriteLine("La differenza dei due numeri è: " + diff);

int prodotto = num1 * num2;
Console.WriteLine("Il prodotto dei due numeri è: " + prodotto);

int quoz = num1 / num2;
Console.WriteLine("Il quoziente dei due numeri è: " + quoz);

int resto = num1 % num2;
Console.WriteLine("Il resto della divisione dei due numeri è:  " + resto);

double quozVirgola = (double)num1 / num2; //Cast a double per ottenere il quoziente con la virgola. Num1 diventà double solo per questa operazione, non cambia il tipo di num1.
Console.WriteLine("Il quoziente dei due numeri è: " + quozVirgola);

