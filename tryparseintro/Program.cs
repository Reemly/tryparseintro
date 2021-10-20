using System;












int Credit = 100;

System.Console.WriteLine("You enter the Horseshoe Pawnshop, what would you like?");

Console.ReadLine();
System.Console.WriteLine($"You have {Credit} Credits to spend.");
Console.ReadLine();

System.Console.WriteLine("List of items:\n A: Rubber duck, 33 Credits\n B: Rubber horse, 6 Credits\n C: Malog baal's Club, 101 Credit.");
System.Console.WriteLine("What would you like?");
string descision = Console.ReadLine();
descision = descision.ToLower();

// Jag vill använda tryparse fast vet inte hur, man ska ju kuna köpa flera av varorna, kanse går på lärforum. kanske gör dialog om man försöker köpa C, eftersom man går in i skuld med -1 så kanske du dör eller något, ganska enkelt med en If sats bara.

if (descision == "a")
{


}

if (descision == "b")
{


}

if (descision == "c")
{


}














