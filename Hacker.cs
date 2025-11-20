using System;
using System.Runtime.InteropServices;
using System.Threading;

class HackerMission
{
    // Typing effect
    static void TypingEffect(string text, int delay)
    {
        foreach (char x in text)
        {
            Console.Write(x);
            Thread.Sleep(delay);
        }
    }

    public static void BackEndUserProtocol()
    {
        TypingEffect("YOU ARE THE BACK-END USER : \n\n", 50);
        TypingEffect("WHAT IS YOUR NAME : ", 50);

        string backEndUser = Console.ReadLine();
        TypingEffect("NOW SET PASSWORD : ", 50);

        string backEndUserPassword = Console.ReadLine();

        TypingEffect($"\n\nWELCOME BACK : {backEndUser}\n\n", 50);

    }

    public static string GenerateRandomWord(int min = 3, int max = 8)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz";
        Random rand = Random.Shared;

        int length = rand.Next(min, max);
        char[] word = new char[length];

        for (int i = 0; i < length; i++)
            word[i] = chars[rand.Next(chars.Length)];

        return new string(word);
    }

    static void FirewallBypass()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("== Firewall Bypass ==\n");
        Console.ResetColor();
        TypingEffect("Bypassing firewall layers...\n\n", 40);

        for (int i = 1; i <= 10; i++)
        {
            TypingEffect($"Injecting spoof packets...{i}0%\n", 1);
        }
        TypingEffect("\nBypass complete!\n", 50);
        Console.ReadLine();
    }

    static void BlurTracks()
    {
        Console.Clear();
        Console.WriteLine("== Blur Tracks ==");
        TypingEffect("Deleting logs...\n", 60);
        TypingEffect("Spoofing IP...\n", 60);
        TypingEffect("Tracks blurred.\n", 60);
        Console.ReadLine();
    }
    static void CrackPassword()
    {
        Console.Clear();
        Console.WriteLine("== Password Cracker ==");


        // FIXED

        TypingEffect("\n" + $"Trying...{GenerateRandomWord()}" + "\n", 30);
        TypingEffect("" + $"Trying...{GenerateRandomWord()}" + "\n", 30);
        TypingEffect("" + $"Trying...{GenerateRandomWord()}" + "\n", 30);
        TypingEffect("" + $"Trying...{GenerateRandomWord()}" + "\n", 30);

        TypingEffect("\nError[BruteForce SYS Crashed]\n", 50);

        TypingEffect("\nPossible Matched Password: \n", 50);



        List<string> passwords = new List<string>()
        {
            "alpha123", "dragon", "matrix42"
        };
        while (true)
        {

            foreach (string password in passwords)
            {
                TypingEffect("\n" + "- " + password, 50);
            }

            Random rand = new Random();
            string RandomPassword = passwords[rand.Next(passwords.Count)];

            TypingEffect("\n\nPassword : ", 50);

            string UserInput = Console.ReadLine();

            Console.WriteLine("\nYou Chose " + UserInput);

            if (UserInput != RandomPassword)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                TypingEffect("\nWrong Password...Try Again...\n", 70);
                TypingEffect("\nINTRUSION DETECTED....PASSWORD CHANGED.....\n", 100);
                Console.ResetColor();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                TypingEffect("\nBypass Completed.............\n", 100);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                TypingEffect("\n\nATTENTION : FIREWALLS ACTIVATED BY SYS.............", 100);
                Console.ResetColor();
                FirewallBypass();
                break;
            }
        }
    }


    static void ShowMenu()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n  Hack Mission - Game made by Karunji Studio\n");
        Console.ResetColor();

        Console.WriteLine(@"
   ---------------------
   |  01 = Start       |
   ---------------------
   |  02 = Tutorial    |
   ---------------------
   |  03 = Exit        |
   ---------------------
");

        TypingEffect("Select: ", 70);
    }

    public static void PhasesList()
    {

        List<string> phases = new List<string>()
        {
            "1 - Password Cracker", "2 - Bypass Firewall", "3 - BlurTracks", "4 - FUCK the g0v"
        };

        foreach (string phase in phases)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypingEffect("\n" + phase, 50);
        }

        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor= ConsoleColor.Black;
        TypingEffect("\n\nSelect Tool : ", 30);
        string userChoice = Console.ReadLine();
        Console.ResetColor();

        switch (userChoice)
        {
            case "1":
                CrackPassword();
                break;

            case "2":
                FirewallBypass();
                break;

            case "3":
                BlurTracks();
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid selection. Try again.");
                Console.ResetColor();
                Thread.Sleep(800);
                break;
        }
    }

    public static void Story()
    {
        Console.ForegroundColor= ConsoleColor.Cyan;
        TypingEffect("\n/\n\n", 10);
        TypingEffect("In 2041, the government’s ultra-secure network AegisNet hides a secret protocol called Project Helix\n\n", 40);
        TypingEffect("an AI that can silently take [ MESSAGE HIDDEN ]\n\n", 60);
        TypingEffect("After a cryptic warning from an insider ", 60);
        TypingEffect("you as a hacker known as Cipher—\n\n", 40);
        TypingEffect("must break into AegisNet to stop Helix from [ MESSAGE HIDDEN ].\n\n", 60);
        TypingEffect("But once inside, you discover [ MESSAGE HIDDEN ] and [ MESSAGE HIDDEN ]\n\n\n", 40);
        Console.Clear();
        TypingEffect("...........[ INTRUSION DETECTED ]............\n\n", 20);
        Thread.Sleep(700);
        TypingEffect("AL1CE : Cypher..This is Al1ce...\n\n", 20);
        Thread.Sleep(1000);
        TypingEffect("Cypher : Al1ce ??...How did you get into this SERVER ?\n\n", 20);
        Thread.Sleep(1200);
        TypingEffect("AL1CE : There is NO TIME..The Job is FUCKED. You need to LEAVE NOW !!!\n\n", 20);
        Thread.Sleep(1200);
        TypingEffect("Cypher : Wait What THE FUCK ! I can't UNLINK\n\n", 20);
        Thread.Sleep(1200);
        TypingEffect("AL1CE : FUCK It's too late, JUST whatever you do do not §&%$§ [ VOICE LOCKED ]\n\n", 20);
        Thread.Sleep(1200);
        TypingEffect("Cypher : al1ce...al1ce....fuck...im...losing...my....neurolink....NEED....TO...FUCKING....ESCAPE\n\n\n", 20);
        Thread.Sleep(2000);
        TypingEffect("Cypher :  ACTIVATING BACK-END USER PROTOCOL ", 50);

        Thread.Sleep(2000);

        Console.Clear();
        BackEndUserProtocol();

        TypingEffect(".\n", 30);
        TypingEffect("..\n", 30);
        TypingEffect("...\n", 30);
        TypingEffect("....\n", 30);
        TypingEffect(".....\n\n", 30);
        TypingEffect("YOU MUST CRACK THE DATABASE AND HIDE YOUR TRACKS.............", 60);
        Thread.Sleep(2000);
        Console.Clear();
        Console.ResetColor();
    }

    static void Main()
    {
        while (true)
        {
            ShowMenu();
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                case "01":
                    Console.Clear();
                    Story();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Mission Start\n");
                    Console.ResetColor();
                    PhasesList();  
                    break;

                case "2":
                case "02":
                    Console.Clear();
                    TypingEffect("Tutorial: Choose 01 to start, 03 to exit.\n", 50);
                    Console.ReadLine();
                    break;

                case "3":
                case "03":
                    TypingEffect("Exiting...", 80);
                    Thread.Sleep(500);
                    return;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Try again.");
                    Console.ResetColor();
                    Thread.Sleep(800);
                    break;
            }
        }
    }
}
