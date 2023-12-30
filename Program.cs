/*
Desafio de usar un metodo que muestre el numero mayor:

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("Tiraste con dobles por lo que se x2 bonus al Total!");
    total *= 2;
    Console.WriteLine($"Ahora obtienes {total}");
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("Oh vaya que suerte! Felicitaciones tiraste triple, ahora tienes x3 bonus al total!");
    total *= 3;
    Console.WriteLine($"Ahora obtienes {total}");
}

if (total > 14)
{
    Console.WriteLine("Ganaste");
}

else
{
    Console.WriteLine("Perdiste");
}