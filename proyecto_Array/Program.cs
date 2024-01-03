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

using System.Security.Cryptography.X509Certificates;

string[] estudiantes = {"Sophia","Andrew","Emma","Logan"};

int[] notasEstudiantes = new int[10];

string estudianteLetraActual = "";

int[] notasSophia = {90,86,87,98,100,94,90};
int[] notasAndrew = {92,89,81,96,90,89};
int[] notasEmma = {90,85,87,98,68,89, 89, 89};
int[] notasLogan = {90,95,87,88,96,96};

int materiasActuales = 5;

Console.WriteLine("Student\t\tGrade");

    foreach (string nombres in estudiantes)
    {
        string estudiante = nombres;

        if (estudiante == "Sophia")
            notasEstudiantes = notasSophia;

        else if (estudiante == "Andrew")
            notasEstudiantes = notasAndrew; 

        else if (estudiante == "Emma")
            notasEstudiantes = notasEmma; 

        else if (estudiante == "Logan")
            notasEstudiantes = notasLogan;
        
            int sumDeNotasAsignaturas = 0;

            decimal notasDeEstudiantesActual = 0;

            int creditosExtra =0;
            
            foreach (int score in notasEstudiantes)
            {
                creditosExtra += 1;

                if(creditosExtra <= materiasActuales)
                sumDeNotasAsignaturas += score;

                else
                sumDeNotasAsignaturas += score / 10;
            }

           notasDeEstudiantesActual = (decimal)sumDeNotasAsignaturas / materiasActuales;

            if (notasDeEstudiantesActual >= 97)
            estudianteLetraActual = "A+";

            else if (notasDeEstudiantesActual >= 93)
            estudianteLetraActual = "A";

            else if (notasDeEstudiantesActual >= 90)
            estudianteLetraActual = "A-";

            else if (notasDeEstudiantesActual >= 87)
            estudianteLetraActual = "B+";

            else if (notasDeEstudiantesActual >= 83)
            estudianteLetraActual = "B";

            else if (notasDeEstudiantesActual >= 80)
            estudianteLetraActual = "B-";

            Console.WriteLine($"{estudiante}\t\t{notasDeEstudiantesActual}\t{estudianteLetraActual}");
    }

    Console.WriteLine("Precione \"Enter\" para continuar");
    Console.ReadLine();

