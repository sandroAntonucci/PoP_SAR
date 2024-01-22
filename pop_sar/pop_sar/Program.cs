using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        // Creació de constants per a missatges

        const string MsgInputDay = "Introdueix el dia: ";
        const string MsgInputMonth = "Introdueix el mes: ";
        const string MsgInputYear = "Introdueix l'any: ";
        const string MsgInvalidInput = "El format no és correcte";
        const string MsgValidInput = "La data és correcta";

        // Creació d'ints a una línia i en anglès
        int day, month, year;

        // Es guarda el dia el mes i l'any
        Console.Write(MsgInputDay);
        day = Convert.ToInt32(Console.ReadLine());

        Console.Write(MsgInputMonth);
        month = Convert.ToInt32(Console.ReadLine());

        Console.Write(MsgInputYear);
        year = Convert.ToInt32(Console.ReadLine());

        // Operador ternari per al missatge a l'usuari
        Console.WriteLine(validate(day, month, year) ? MsgValidInput : MsgInvalidInput);
    
    }

    public static bool validate(int day, int month, int year)
    {

        // Es fa tot a un mateix if
        if (day < 1 || day > 31 || month < 1 || month > 12) return false;

        // determinem la quantitat de dies del mes:

        int totalDaysMonth = 0;

        switch (month)
        {

            case 1:

            case 3:

            case 5:

            case 7:

            case 8:

            case 10:

            case 12: totalDaysMonth = 31; break;

            case 4:

            case 6:

            case 9:

            case 11: totalDaysMonth = 30; break;

            case 2: // verifica l'any de traspàs

                // Cada 4 anys, no 400
                if (year % 4 == 0) totalDaysMonth = 29;
                else totalDaysMonth = 28;

                break;

        }

        // Es fa el return directament comprovant si el dia sobrepassa els dies totals del mes
        return !(day > totalDaysMonth);

    }
}