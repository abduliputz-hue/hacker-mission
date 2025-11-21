using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections.Generic;
using System.Text.Json;
// using data;


class HackerMission
{
    public static bool progress = false;
    public static string backEndUser = "";

    static void GameOver()
    {
        // HUGE ASCII

        Console.WriteLine(@" 
 ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ 
      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     
                                                     ░                   ");

    }

    // Typing effect
    static void TypingEffect(string text, int delay)
    {
        foreach (char x in text)
        {
            Console.Write(x);
            Thread.Sleep(delay);
        }
    }

    public static void data()
    {
    }

    public static void BackEndUserProtocol()
    {
        TypingEffect("YOU ARE THE BACK-END USER : \n\n", 50);
        TypingEffect("WHAT IS YOUR NAME : ", 50);

        backEndUser = Console.ReadLine();
        TypingEffect("NOW SET PASSWORD : ", 50);

        Console.ReadLine();

        TypingEffect($"\n\nWELCOME BACK : {backEndUser}\n\n", 50);
    }


    public static string GenerateRandomWord(int min = 5, int max = 8)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz1234567890'#!§$%&/()=?";
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
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("== Password Cracker ==");
        Console.ResetColor();


        // FIXED

        TypingEffect("\n" + $"Trying...{GenerateRandomWord()}" + "\n", 30);
        TypingEffect("" + $"Trying...{GenerateRandomWord()}" + "\n", 30);
        TypingEffect("" + $"Trying...{GenerateRandomWord()}" + "\n", 30);
        TypingEffect("" + $"Trying...{GenerateRandomWord()}" + "\n", 30);

        Console.ForegroundColor = ConsoleColor.Red;
        TypingEffect("\nError [BruteForce SYS Crashed] \n", 50);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        TypingEffect("\nPossible Matched Password: \n", 50);
        Console.ResetColor();


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
                Console.Clear();
                progress = true;
                PhasesList();
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
            "1 - Password Cracker", "2 - Bypass Firewall", "3 - BlurTracks"
        };
        List<string> phases2 = new List<string>()
        {
            "1 - Password Cracker", "2 - Bypass Firewall", "3 - BlurTracks", "4 - See Data", "5 - Sell Data"
        };

        if (progress == false)
        {
            foreach (string phase in phases)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                TypingEffect("\n" + phase, 50);
                Console.ResetColor();
            }
        }

        if (progress == true)
        {
            foreach (string phase in phases2)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                TypingEffect("\n" + phase, 50);
                Console.ResetColor();
            }
        }


        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        TypingEffect("\n\nSelect Tool : ", 30);
        string userChoice = Console.ReadLine();
        Console.ResetColor();

        if (progress == false)
        {
            switch (userChoice)
            {
                case "1":
                    CrackPassword();
                    break;

                case "2":
                    if (progress == true)
                    {
                        FirewallBypass();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        TypingEffect("To bypass the Firewall you need the PASSWORD!!!", 50);
                        Console.ResetColor();
                        Thread.Sleep(500);
                        Console.Clear();
                        PhasesList();
                    }

                    break;

                case "3":
                    if (progress == true)
                    {
                        BlurTracks();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        TypingEffect("No Tracks Found on The Network.....", 50);
                        Console.ResetColor();
                        Thread.Sleep(500);
                        Console.Clear();
                        PhasesList();
                    }

                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Try again.");
                    Console.ResetColor();
                    Thread.Sleep(800);
                    break;
            }
        }

        if (progress == true)
        {
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
                case "4":

                    Console.Clear();

                    Console.Clear();
                    PhasesList();
                    break;
                case "5":
                    sell_data();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Try again.");
                    Console.ResetColor();
                    Thread.Sleep(800);
                    break;
            }
        }
    }


    public static void sell_data()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("-----Chat With Specter -----");
        Console.ResetColor();
        Thread.Sleep(500);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("[You] - 21:14 ");
        Console.ResetColor();
        TypingEffect("Are you Specter?\n\n", 100);
        Thread.Sleep(500);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("[Specter] - 21:14 ");
        Console.ResetColor();
        TypingEffect("Depends. Who’s asking?\n\n", 100);
        Thread.Sleep(500);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("[You] - 21:15 ");
        Console.ResetColor();
        TypingEffect("Someone who was told you have “the package.”\nI have the access code. Sending now.\n\n", 100);
        Thread.Sleep(500);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("[System] - 21:15. ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        TypingEffect("Buyer47 ", 100);
        Console.ResetColor();
        TypingEffect("sent a file: ", 100);
        Console.ForegroundColor = ConsoleColor.Blue;
        TypingEffect("access.key", 100);
        Console.ResetColor();
        Thread.Sleep(500);


    }

    public static void Story()
    {
        static void Cypher()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            TypingEffect($"[ You ] : ", 20);
            Console.ResetColor();
            Console.ReadLine();
        }



        static void UserInput()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            TypingEffect("ACTIVATE [ yes | no ] : ", 30);
            Console.ResetColor();
            string condition = Console.ReadLine();

            switch (condition)
            {
                case "yes":
                    BackEndUserProtocol();
                    break;
                case "no":
                    GameOver();
                    break;

            }
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        TypingEffect("\n/\n\n", 10);
        TypingEffect(
            "In 2041, the government’s ultra-secure network AegisNet hides a secret protocol called",
            40);
        Console.ForegroundColor = ConsoleColor.Red;
        TypingEffect(" Project Helix\n\n", 40);
        Console.ForegroundColor = ConsoleColor.Cyan;
        TypingEffect("an AI that can silently take ", 60);
        Console.ForegroundColor= ConsoleColor.Red;
        TypingEffect("[ MESSAGE HIDDEN ]\n\n", 60);
        Console.ResetColor(); 
        Console.ForegroundColor = ConsoleColor.Cyan;
        TypingEffect("After a cryptic warning from an insider ", 60);
        TypingEffect("YOU as a hacker known as Cipher—\n\n", 40);
        TypingEffect("must break into AegisNet to stop Helix from ", 60);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Red;
        TypingEffect("[ MESSAGE HIDDEN ]\n\n", 60);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        TypingEffect("But once inside, you discover ", 40);
        Console.ForegroundColor = ConsoleColor.Red;
        TypingEffect("[ MESSAGE HIDDEN ]", 40);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        TypingEffect(" and ", 40);
        Console.ForegroundColor = ConsoleColor.Red;
        TypingEffect("[ MESSAGE HIDDEN ]\n\n\n", 40);
        Console.ResetColor();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        TypingEffect("...........[ INTRUSION DETECTED ]............\n\n", 20);
        Console.ResetColor();
        Thread.Sleep(700);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        TypingEffect("[ AL1CE ] : ", 20);
        Console.ResetColor();
        TypingEffect("Cypher..This is Al1ce...\n\n", 20);
        Thread.Sleep(1000);
        TypingEffect($"{Cypher}", 20);
        Thread.Sleep(1200);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        TypingEffect("[ AL1CE ] : ", 20);
        Console.ResetColor();
        TypingEffect("There is NO TIME..The Job is FUCKED. You need to LEAVE NOW !!!\n\n", 20);
        Thread.Sleep(1200);
        TypingEffect($"{Cypher}", 20);
        Thread.Sleep(1200);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        TypingEffect("[ AL1CE ] : ", 20);
        Console.ResetColor();
        TypingEffect($"{Cypher}", 20);
        Thread.Sleep(1200);
        TypingEffect($"{Cypher}", 20);

        Thread.Sleep(1200);
        TypingEffect("You are losing the NETLINK.....[ ACTIVATE BACK-END USER ]", 30);

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
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("BY: ");
                    Console.WriteLine(@"

██╗  ██╗ █████╗ ██████╗ ██╗   ██╗███╗   ██╗     ██╗██╗       
██║ ██╔╝██╔══██╗██╔══██╗██║   ██║████╗  ██║     ██║██║       
█████╔╝ ███████║██████╔╝██║   ██║██╔██╗ ██║     ██║██║       
██╔═██╗ ██╔══██║██╔══██╗██║   ██║██║╚██╗██║██   ██║██║       
██║  ██╗██║  ██║██║  ██║╚██████╔╝██║ ╚████║╚█████╔╝██║       
╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝ ╚════╝ ╚═╝       

");
                    Thread.Sleep(2500);
                    Console.Clear();
                    TypingEffect("Exiting...", 80);
                    Console.ResetColor();
                    Thread.Sleep(500);
                    return;
                case "99":
                    progress = true; // DEV MODDER FULL LEVEL
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Dev Mode!!!");
                    Thread.Sleep(1200);
                    Console.ResetColor();
                    Console.Clear();
                    PhasesList();
                    break;

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
