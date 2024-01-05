/*
using System.Security.Cryptography.X509Certificates;

string[] estudiantes = {"Sophia","Andrew","Emma","Logan"};

int[] notasEstudiantesConCreditos = new int[10];

int[] notasEstudiantesExamenes = new int[10];

int puntajeCreditosExtra = 10;

string estudianteLetraActual = "";

int[] notasSophia = {90,86,87,98,100,94,90};
int[] notasAndrew = {92,89,81,96,90,89};
int[] notasEmma = {90,85,87,98,68,89,89,89};
int[] notasLogan = {90,95,87,88,96,96};

int materiasActuales = 5;


Console.WriteLine("Student\t\tNota Examen\tNota Global\t\tCreditos Extra\n");

    foreach (string nombres in estudiantes)
    {

        string estudiante = nombres;

        if (estudiante == "Sophia")
            notasEstudiantesConCreditos = notasSophia; 

        else if (estudiante == "Andrew")
            notasEstudiantesConCreditos = notasAndrew; 

        else if (estudiante == "Emma")
            notasEstudiantesConCreditos = notasEmma; 

        else if (estudiante == "Logan")
            notasEstudiantesConCreditos = notasLogan;
        
        if (estudiante == "Sophia")
            notasEstudiantesExamenes = notasSophia;

        else if (estudiante == "Andrew")
            notasEstudiantesExamenes = notasAndrew; 

        else if (estudiante == "Emma")
            notasEstudiantesExamenes = notasEmma; 

        else if (estudiante == "Logan")
            notasEstudiantesExamenes = notasLogan;
        
            int sumDeNotasAsignaturas = 0;

            int sumSoloExamenes = 0;

            int sumSoloCreditos = 0;

            int sumCreditos = 0;

            decimal notasDeEstudiantesGlobal = 0;

            decimal notasSoloExamenes = 0;

            decimal soloCreditos = 0;

            decimal puntajeTotalCreditosExtra =0;

            int totalNotas = 0;

            int materiasCursadas = 0;

            int totalDeNotasCreditos = 0;

            foreach (int notasExamenes in notasEstudiantesExamenes)
            { 
                materiasCursadas++;
                sumSoloExamenes += notasExamenes;

                if (materiasCursadas >= 5)
                    break;
            }

            foreach (int totalCreditos in notasEstudiantesExamenes)
            { 
                totalDeNotasCreditos++;
                sumCreditos += totalCreditos;
            }

            foreach (int puntosCreditos in notasEstudiantesExamenes.Skip(5))
            {
                sumSoloCreditos += puntosCreditos;
            }

            foreach (int score in notasEstudiantesConCreditos)
            {
                totalNotas += 1;

                if(totalNotas <= materiasActuales)
                sumDeNotasAsignaturas += score;

                else
                sumDeNotasAsignaturas += score / 10;
            }
        
           //Ecuaciones.
           notasDeEstudiantesGlobal = (decimal)sumDeNotasAsignaturas / materiasActuales;

           notasSoloExamenes = (decimal)sumSoloExamenes / materiasActuales;

           soloCreditos = (decimal) sumSoloCreditos / puntajeCreditosExtra / materiasActuales;

           puntajeTotalCreditosExtra = sumCreditos / totalDeNotasCreditos;

            //Calculo de los grados por letras
            if (notasDeEstudiantesGlobal >= 97)
            estudianteLetraActual = "A+";

            else if (notasDeEstudiantesGlobal >= 93)
            estudianteLetraActual = "A";

            else if (notasDeEstudiantesGlobal >= 90)
            estudianteLetraActual = "A-";

            else if (notasDeEstudiantesGlobal >= 87)
            estudianteLetraActual = "B+";

            else if (notasDeEstudiantesGlobal >= 83)
            estudianteLetraActual = "B";

            else if (notasDeEstudiantesGlobal >= 80)
            estudianteLetraActual = "B-";

            Console.WriteLine($"{estudiante}\t\t{notasSoloExamenes}\t\t{notasDeEstudiantesGlobal}\t{estudianteLetraActual}\t\t{puntajeTotalCreditosExtra} ({soloCreditos}pts)");
    }
*/


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] estudiantes = { "Sophia", "Andrew", "Emma", "Logan" };

        Dictionary<string, int[]> notasEstudiantes = new Dictionary<string, int[]>
        {
            {"Sophia", new int[] {90, 86, 87, 98, 100, 94, 90}},
            {"Andrew", new int[] {92, 89, 81, 96, 90, 89}},
            {"Emma", new int[] {90, 85, 87, 98, 68, 89, 89, 89}},
            {"Logan", new int[] {90, 95, 87, 88, 96, 96}}
        };

        Console.WriteLine("Student\t\tNota Examen\tNota Global\t\tCreditos Extra\n");

        foreach (string estudiante in estudiantes)
        {
            int[] notasEstudiantesConCreditos = notasEstudiantes[estudiante];
            int[] notasEstudiantesExamenes = notasEstudiantesConCreditos.Take(5).ToArray();
            int[] puntosCreditos = notasEstudiantesConCreditos.Skip(5).ToArray();

            decimal notasDeEstudiantesGlobal = CalcularPromedio(notasEstudiantesConCreditos, 5);
            decimal notasSoloExamenes = CalcularPromedio(notasEstudiantesExamenes, 5);
            decimal soloCreditos = CalcularPuntajeCreditosExtra(puntosCreditos, 10) / 5;
            decimal puntajeTotalCreditosExtra = CalcularPuntajeCreditosExtra(notasEstudiantesConCreditos, 10) / notasEstudiantesConCreditos.Length;

            string estudianteLetraActual = ObtenerGradoPorLetra(notasDeEstudiantesGlobal);

            MostrarResultado(estudiante, notasSoloExamenes, notasDeEstudiantesGlobal, estudianteLetraActual, puntajeTotalCreditosExtra, soloCreditos);
        }
    }

    static decimal CalcularPromedio(int[] notas, int materias)
    {
        return (decimal)notas.Take(materias).Sum() / materias;
    }

    static decimal CalcularPuntajeCreditosExtra(int[] puntosCreditos, int puntajeCreditosExtra)
    {
        return (decimal)puntosCreditos.Sum() / puntajeCreditosExtra;
    }

    static string ObtenerGradoPorLetra(decimal notasDeEstudiantesGlobal)
    {
        if (notasDeEstudiantesGlobal >= 97) return "A+";
        if (notasDeEstudiantesGlobal >= 93) return "A";
        if (notasDeEstudiantesGlobal >= 90) return "A-";
        if (notasDeEstudiantesGlobal >= 87) return "B+";
        if (notasDeEstudiantesGlobal >= 83) return "B";
        if (notasDeEstudiantesGlobal >= 80) return "B-";

        return "C"; // Otra clasificación para notas más bajas
    }

    static void MostrarResultado(string estudiante, decimal notasSoloExamenes, decimal notasDeEstudiantesGlobal, string estudianteLetraActual, decimal puntajeTotalCreditosExtra, decimal soloCreditos)
    {
        Console.WriteLine($"{estudiante}\t\t{notasSoloExamenes}\t\t{notasDeEstudiantesGlobal}\t{estudianteLetraActual}\t\t{puntajeTotalCreditosExtra} ({soloCreditos}pts)");
    }
}

