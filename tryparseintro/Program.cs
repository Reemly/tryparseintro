using System;












int Credit = 100;
bool transaction = false;


System.Console.WriteLine("You enter the Horseshoe Pawnshop, what would you like?");

Console.ReadLine();

System.Console.WriteLine($"You have {Credit} Credits to spend.");
Console.ReadLine();


string descision = "";

while (descision != "a" && descision != "b" && descision != "c")
{
    System.Console.WriteLine("List of items:\n A: Rubber duck, 3 Credits\n B: Rubber horse, 6 Credits\n C: Malog baal's Club, 101 Credit.");
    System.Console.WriteLine("What would you like?");
    descision = Console.ReadLine();
    descision = descision.ToLower();
}

// int antal

while (transaction == false)
{







    // hur många?
    // hämta in via readline (antalS)
    // gör en tryparse
    // transaction = int.TryParse(antalS, out antal )
}


// fixa while ( transaction == false), programmet verkar förstört för att när jag lade in dialog i if(c) så hände inget när man kom till den delen, fixa det, kom ihåg att kolla på https://github.com/NTISTHLM-TESPEL-PRR01-2122/TE20B_TryParse/blob/master/TE20B_TryParse/Program.cs.
if (descision == "a")
{


}

if (descision == "b")
{


}

if (descision == "c")
{


}






















