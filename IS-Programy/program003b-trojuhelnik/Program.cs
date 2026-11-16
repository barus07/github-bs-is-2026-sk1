string again = "a";

// Řídicí cyklus aplikace:
// .ToLower() převede vstup na malá písmena, takže program pokračuje při zadání 'a' i 'A'.
// Jakýkoliv jiný vstup program ukončí.
while (again.ToLower() == "a") 
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpis řady čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("**** Barbora Suchardová *****");
    Console.WriteLine("****************************");
    Console.WriteLine();


    // 1. načtení výšky
    Console.Write("Zadejte výšku obrazce (celé kladné číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné číslo. Zadejte výšku znovu: ");
        Console.ResetColor();
    }



    // 4. Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Výška: {height}");
    Console.WriteLine("====================================");
    Console.WriteLine();

 // Zde budeme pokračovat konkrétním algoritmem
    /* 
    
    výška 4

    * 
    * * 
    * * * 
    * * * * 
    
    */
    
    // Jádro vykreslovacího algoritmu
    // Vnější cyklus, který nám bude hlídat počet řádků (shora dolů)
    for(int i = 1; i <= height; i++)
    {
        // Vnitřní cyklus, který se nám postará o to, aby se v každém řádku vykreslil správný počet znaků
        for (int j = 1; j <= i; j++){
            Console.Write("* ");
        }
        Console.WriteLine();
    }
// 5. Dotaz na opakování programu
Console.WriteLine();
Console.WriteLine("Chcete program spustit znovu? (a/n)");       
again = Console.ReadLine();
}
