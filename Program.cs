using System;

namespace New_folderICE03
{
    class Program
    {
        static void Main(string[] args)
        {//placing all of my variables for my text
            Console.WriteLine("Hello World!");
            int age = 48;
            int yearBorn =1971;
            String nameOfHighSchool= "John Marshall";
            int yearIGraduatedFromHighSchool = 1989;
            String myMothersName="Rosa Rivera";
            String myFathersName="Ramon Rivera";
            int numberOfCreditsIAmTaking= 13;
            String nameOfProgramIAmIn= "Mobile Application Development";
            String myFirstName= "Hector";
            String myLastName= "Rivera";
            //Beginning my text for ICE03
            Console.WriteLine("Hi! My name is " + myFirstName + " " + myLastName + ". I'm " + age + " years old.");
            Console.WriteLine ("");
            Console.WriteLine ("I went to " + nameOfHighSchool + " and graduated in " + yearIGraduatedFromHighSchool + ".");
            Console.WriteLine ("A very loooong time after, I decided to come to NTID for college.");
            Console.WriteLine ("Both my Mom " + myMothersName + " and Dad " + myFathersName + " thought NTID would be a great choice for me.");
            Console.WriteLine ("");
            Console.WriteLine ("So, now I'm a student here at RIT/NTID. I'm in the " + nameOfProgramIAmIn + " program, taking " + numberOfCreditsIAmTaking + " credits. That's pretty crazy for someone who was born in " + yearBorn + ".");




        }
    }
}
