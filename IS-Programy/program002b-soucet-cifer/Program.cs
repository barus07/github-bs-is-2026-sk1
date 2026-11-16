// Řídicí proměnná pro opakování programu
string again = "a";

// Hlavní smyčka programu: běží znovu, pokud uživatel zadá 'a' nebo 'A'
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("********* Ciferný součet **********");
    Console.WriteLine("***********************************");
    Console.WriteLine("******** Barbora Suchardová *******");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    // 1. Bezpečné načtení celého čísla od uživatele
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }

    // 2. Příprava pomocných proměnných pro výpočet
    int numberBackup = number; // Záloha původního čísla pro závěrečný výpis
    int sum = 0;               // Neutrální prvek pro sčítání je 0
    int digit;                 // Proměnná pro uložení právě oddělené cifry

    
// převední čísla na textový řetězec
    string text = number.ToString();
    Console.WriteLine();
    Console.WriteLine("Průběh rozkladu čísla na cifry (zleva doprava):");

    foreach (char znak in text)

    {
        //kontrola, zda seš jedná o číslice
        if (char.IsDigit(znak))
        {
          digit = znak - '0'; //převedení znaku na číslo
            sum += digit; //přičtení cifry k celkovému součtu
        Console.WriteLine($"Získána cifra: {digit}");
        }
    }

    
    // 6. Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Původní číslo:  {numberBackup}");
    Console.WriteLine($"Ciferný součet: {sum}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // 7. Dotaz na opakování programu
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}