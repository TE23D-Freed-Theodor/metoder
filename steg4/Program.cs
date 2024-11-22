/*

Skapa en metod som, när den anropas, skriver ut "Hello, World" 32 gånger. Använd en loop (while eller for) för att sköta upprepningen. Döp metoden till "Hello32".
Skapa en metod som anropas med en integer som parameter. Skriv ut kvadraten av denna integer.
Skapa en metod som anropas med två doubles eller floats som parametrar. Metoden ska returnera resultatet av den ena parametern multiplicerad med den andra. Döp metoden till "Multi".
Skapa en metod för att räkna ut arean på en rätvinklig triangel. Den ska ta emot två doubles eller floats och returnera samma datatyp. Döp metoden till "RightTriangleArea".
Skapa en metod som, på motsvarande sätt, räknar ut arean för en cirkel.
Skapa en metod som hämtar in tal från användaren via konsollen (ReadLine). Skapa en loop inuti metoden som inte avslutas förrän användaren skrivit in något som är ett tal. Metoden ska returnera en int som är det tal användaren skrivit in. Metoden ska inte ta emot några parametrar. Döp metoden till GetNumberInput.
Skapa en metod som du döper till GetChoice och som tar emot tre strings som parametrar. Skriv ut de tre stringvärdena så att användaren ser dem. Metoden ska sedan låta användaren välja mellan de tre, t.ex. genom att skriva 1, 2 eller 3. Metoden ska inte avslutas innan användaren skrivit in ett giltigt svar. Metoden ska returnera en int som motsvarar användarens val.
Förbättra: Gör så att metoden istället tar emot en string-array som parameter. Använd en loop för att skriva ut de olika stringvärdena och bygg om metoden så att den inte bara fungerar för tre alternativ utan för det antal som stoppas in i arrayen; om man t.ex. stoppar in en string-array med fyra värden så ska användaren få välja mellan fyra olika alternativ.


*/

static void hello32() {
    for (int i = 0; i < 32; i++) {
        Console.WriteLine("Hello, World");
    }
}

static void kvadrat(int x) {
    x *= x;
    Console.WriteLine(x);
}

static void multiplikation(double första, double andra) {
    Console.WriteLine(första * andra);
}

static void triangel(double bredd, double höjd) {
    Console.WriteLine(bredd*höjd/2);
}

static void cirkel(double radie) {
    Console.WriteLine(radie*radie*3.14);
}


static int GetNumberInput()
{
    int number; // Variabel för att lagra det konverterade talet
    while (true)
    {
        Console.Write("Skriv in ett heltal: ");
        string input = Console.ReadLine();

        // Försök att konvertera input till ett heltal
        if (int.TryParse(input, out number))
        {
            return number; // Returnera om det är ett giltigt tal
            break;
        }
        else
        {
            Console.WriteLine("Ogiltigt värde. Försök igen!");
        }
    }
}

static int GetChoice(string[] alternativ)
{
    while (true)
    {
        Console.WriteLine("Vilket alternativ väljer du?");
        
        // Skriv ut alternativen dynamiskt
        for (int i = 0; i < alternativ.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {alternativ[i]}");
        }

        Console.Write("Skriv in numret för ditt val: ");
        string val = Console.ReadLine();

        int valnummer;
        if (int.TryParse(val, out valnummer) && valnummer >= 1 && valnummer <= alternativ.Length)
        {
            return valnummer; // Returnera användarens val som ett index
        }
        else
        {
            Console.WriteLine("Ogiltigt val. Försök igen!"); // Hantera ogiltig input
        }
    }
}

// Anrop av metoden
string[] alternativ = { "Äpple", "Banan", "Körsbär", "Druva" };
int val = GetChoice(alternativ);
Console.WriteLine($"Du valde: {alternativ[val - 1]}");

Console.ReadLine();