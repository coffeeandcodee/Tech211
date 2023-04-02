using System;
using System.Net.Http;

namespace MoreTypes_Lib;
/*date.ToString("yy/dd/MMM")*/

public enum Suit
{
    HEARTS = 'H', CLUBS = 'C', DIAMONDS = 'D', SPADES ='S'
}

public class DateTimeEnumsExercises
{
    // returns a person's age at a given date, given their birth date.
    public static int AgeAt(DateTime birthDate, DateTime date)
    {
        if(birthDate.Ticks > date.Ticks)
        {
            throw new ArgumentException("Error - birthDate is in the future");
        }
        int age = date.Year - birthDate.Year;
        if (date.DayOfYear < birthDate.DayOfYear)
            age -= 1;
        return age;
    }
    // returns a date formatted in the manner specified by the unit test
    public static string FormatDate(DateTime date)
    {
        /* .ToString(/customFormat/) */
        return date.ToString("yy/dd/MMM");
    }

    // returns the name of the month corresponding to a given date
    public static string GetMonthString(DateTime date)
    {
        return date.ToString("MMMM");
    }

    // see unit tests for requirements
    public static string Fortune(Suit suit)
    {

        string message = "";
        switch (suit)
        {
            case Suit.HEARTS: message = "You've broken my heart"; break;
            case Suit.DIAMONDS: message = "Diamonds are a girls best friend"; break;
            case Suit.CLUBS: message = "And the seventh rule is if this is your first night at fight club, you have to fight."; break;
            case Suit.SPADES: message = "Bucket and spade"; break;
        }

        return message;
    }
}
