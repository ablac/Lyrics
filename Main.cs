using System;

namespace Lyrics
{
    class Program
    {
        static void Main(string[] args)
        {
            //show song title and artist
            string nl = "\r\n";
            string artist = "Ariana Grande";
            string song = "Positions";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(nl + song + " by " + artist + nl);
            Console.ResetColor();

            //repeatable strings
            string Line1 = "Switching them positions for you";
            string Line2 = "Cooking in the kitchen and I'm in the bedroom";
            string Line3 = "I'm in the Olympics way I'm jumping through hoops";
            string Line4 = "Know my love infinite nothing I wouldn't do";
            string Line5 = "That I won't do, switching for you";

            //display using WriteLine
            Console.WriteLine("Heaven sent you to me");
            Console.WriteLine("I'm just hoping I don't repeat history");
            Console.WriteLine("Boy I'm tryna meet your mama" + nl);

            Console.WriteLine("On a Sunday");
            Console.WriteLine("Then make a lotta love");
            Console.WriteLine("On a Monday (Ah, ah)");
            Console.WriteLine("Never need no (No)");
            Console.WriteLine("No one else, babe");
            Console.WriteLine("'Cause I'll be" + nl);

            Console.WriteLine(Line1 + nl + Line2 + nl + Line3 + nl + Line4 + nl + Line5 + nl);

            Console.WriteLine("Perfect, perfect");
            Console.WriteLine("You're too good to be true (You're too good to be true)");
            Console.WriteLine("But I get tired of running");
            Console.WriteLine("Fuck it, now I'm running with you (with you)" + nl);

            Console.WriteLine("Said boy I'm tryna meet your mama");
            Console.WriteLine("On a Sunday");
            Console.WriteLine("Then make a lotta love");
            Console.WriteLine("On a Monday (Ah, ah)");
            Console.WriteLine("Never need no (No)");
            Console.WriteLine("No one else babe");
            Console.WriteLine("'Cause I'll be" + nl);

            Console.WriteLine(Line1 + nl + Line2 + nl + Line3 + nl + Line4 + nl + Line5 + nl + Line2 + nl + Line3 + nl + Line4 + nl + Line5 + nl);

            Console.WriteLine("This some shit that I");
            Console.WriteLine("Usually don't do (Yeah)");
            Console.WriteLine("But for you I kinda");
            Console.WriteLine("Kinda want to");
            Console.WriteLine("'Cause you're down for me");
            Console.WriteLine("And I'm down too");
            Console.WriteLine("(And I'm down too)");
            Console.WriteLine("Yeah I'm down too");
            Console.WriteLine("Switching them positions for you" + nl);

            Console.WriteLine("This some shit that I (Yeah)");
            Console.WriteLine("Usually don't do (Don't do)");
            Console.WriteLine("But for you I kinda");
            Console.WriteLine("Kinda want to");
            Console.WriteLine("'Cause you're down for me");
            Console.WriteLine("And I'm down too");
            Console.WriteLine("'Cause you're down for me" + nl);

            Console.WriteLine(Line1 + nl + Line2 + nl + Line3 + " (Jumping, jumping)" + nl + Line4 + nl + Line5 + " (Ooh whoa)" + nl + Line2 + nl + Line3 + nl + Line4 + " (I wouldn't do)" + nl + Line5 + nl);
            //stops program from automatically closing after text displays.
            Console.ReadLine();
        }
    }
}