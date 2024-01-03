/*
Desafio de usar un metodo que muestre el numero mayor:

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
*/

/* juego de dados

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("Oh vaya que suerte! Felicitaciones tiraste triple, ahora tienes x3 bonus al total!");
        total *= 3;
        Console.WriteLine($"Ahora obtienes {total}");
    } 
    else
    {
    Console.WriteLine("Tiraste con dobles por lo que se x2 bonus al Total!");
    total *= 2;
    Console.WriteLine($"Ahora obtienes {total}");
    }
}



if (total >= 40)
{
    Console.WriteLine("Ganaste un auto nuevo");
}

else if (total >= 20)
{
    Console.WriteLine("Ganaste una computadora nueva");
}
else if (total >= 10)
{
    Console.WriteLine("Ganaste un pan");
}
else
{
    Console.WriteLine("Premio de consolacion ganaste un gatito");
}

*/

/* creacion de IF y ELSE IF

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage1 = 10;
int discountPercentage2 = 20;

// Your code goes herec

 if (daysUntilExpiration == 0)
 {
    Console.WriteLine("Tu subscripcion ha expirado");
    
 }

else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Tu subscripcion termina en un 1 dia");
    Console.WriteLine($"Renueve ahora y obtendra {discountPercentage2}%");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Tu subscripcion expira en {daysUntilExpiration} dias");
    Console.WriteLine($"Renueve ahora y obtendra {discountPercentage1}%");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Tu subscripcion expirara pronto, por favor renuevala");
}
*/

//Arreglos
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// mal: fraudulentOrderIDs[3] = "D000";
*/
/*
string[] fraudulentOrderIDs = {"A123","B456","C789"};

Console.WriteLine($"Primero: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Segundo: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Tercero: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reasignar numero: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/

/*
using System.Runtime.CompilerServices;

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Categoria {bin} = {items} de articulos (En total hay: {sum})");
    
}

Console.WriteLine($"Tenemos {sum} de articulos en inventario de {inventory.Length} categorias diferentes");
*/

/* Hacer un recorrido para extraer el arreglo los que empiezan por B

string[] elements = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

string pedidos = "";

foreach(string element in elements)
{
    pedidos = element;

    if (pedidos.StartsWith("B"))
    {
        Console.WriteLine($"The {pedidos} fraudes!!!");
    }
    
}
*/

/*
using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
*/

string[] estudiantes = {"sophia","Andrew","Emma","Logan"};
 
decimal[] notasSophia = {90,86,87,98,100};
decimal[] notasAndrew = {92,89,81,96,90};
decimal[] notasEmma = {90,85,87,98,68};
decimal[] nortasLogan = {90,95,87,88,96};


int sumSophia = 0;
int sumAndrew = 0;
int sumEmma= 0;
int sumLogan = 0;



Console.WriteLine("Student\t\tGrade");
//double totalSophia = 0;

int totalDeAsignaturas = 5;

    foreach (string nombres in estudiantes)
    {
        Console.WriteLine($"{nombres}");
    }


 /*if (sumSophia >= 90 && sumSophia < 93)
    {
        Console.WriteLine ($"Sophia:\t\t{sumSophia}\t A-");
    }
    else {

    }*/










