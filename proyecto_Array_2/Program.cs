using System.Security.Cryptography.X509Certificates;

string[] estudiantes = {"Sophia","Andrew","Emma","Logan"};

int[] notasEstudiantes = new int[10];

string estudianteLetraActual = "";

int[] notasSophia = {90,86,87,98,100,94,90};
int[] notasAndrew = {92,89,81,96,90,89};
int[] notasEmma = {90,85,87,98,68,89, 89, 89};
int[] notasLogan = {90,95,87,88,96,96};

int materiasActuales = 5;


Console.WriteLine("Student\t\tNota Examen\tNota Global\t\tCreditos Extra\n");

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

            int creditosExtra = 0;

            int notaExamen = 0;

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

            Console.WriteLine($"{estudiante}\t\t{notaExamen}\t\t{notasDeEstudiantesActual}\t{estudianteLetraActual}");
    }


