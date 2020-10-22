using System;
using System.Runtime.InteropServices.ComTypes;

namespace kan_slänga
{
    class Program

    {
        static int checkpoint = 0;

        static void rum0()
        {
            Console.WriteLine(" The door is locked! See if one of your three keys will open it.");
            Console.Write("Enter a number (1-3): ");


            string keyChoice = Console.ReadLine();

            //Respone to the preferred key choice
            switch (keyChoice)
            {

                case "1":
                    Console.WriteLine("It is a big room with two big corridors. Press enter to continue. ");
                    Console.ReadLine();
                    Console.Clear();
                    rum1();

                    break;


                case "2":
                    Console.Clear();
                    Console.WriteLine(" You choose the second key. The door doesn't open.\n TRY ANOTHER KEY");

                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine(" You choose the second key. The door doesn't open.\n TRY ANOTHER KEY");

                    break;
            }
        }
        static void rum1()
        {
            Console.WriteLine("Type 1 to go to the left corridor and 2 to go to the right corridor");
            string whichhall = Console.ReadLine();
            switch (whichhall)
            {

                case "1":
                    Console.Clear();
                    Console.WriteLine("You walked in to the right corridor but its 5 different doors. Press enter to   continue");
                    Console.ReadLine();
                    rum2();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("You walked to the wrong corridors and you step in a trap. Try again.");
                    break;
            }

        }

        static void rum2()
        {
            Console.Clear();
            Console.WriteLine("which door do you step in. chose a number between 1-5");
            string onetofive = Console.ReadLine();
            switch (onetofive)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Wrong door! Try again.");
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Wrong door! Try again.");
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Wrong door! Try again.");
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Right door! Press enter to continue.");
                    Console.ReadLine();
                    rum3();
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Wrong door! Try again.");
                    break;
            }
        }
        static void rum3()
        {
            Console.WriteLine("when you come in to the room behind the door you see a bomb. Its going to explode. You need to type down the code so the bomb dont blow yu up");
            Console.WriteLine("the code is 4344939493");
            string lösenord = "";
            string rättlösenord = "4344939493";
            lösenord = Console.ReadLine();
            if (lösenord == rättlösenord)
            {

                Console.WriteLine("You typed in the right password. Click enter to continue.");
                Console.ReadLine();
                rum4();

            }

            else if (lösenord != rättlösenord)
            {
                Console.WriteLine("You typed in the wrong code.");

                {

                }



            }
        }
        static void rum4()
        {
            Console.Clear();
            Console.WriteLine("When you have typed in the code on the bomb you see a glass of water. You are so thirsty so you take all of it in a half second");
            Console.WriteLine(" but then you fell pain in the head and you got poisoned by the water. On a     black table infront of you, you see to pills. 1 of the pill is poison and one are the  the cure Press 1 to take the red pill. Press 2 to take the blue pill. ");
            string pill = Console.ReadLine();
            switch (pill)
            {
                case "1":
                    Console.WriteLine("You took the wrong pill and you feel the pain in your body before everything going dark.");
                    break;

                case "2":
                    Console.WriteLine("You took the right pillaidulasd and the pain going away. You have also reached the checkpoint. Press enter to continue");
                    Console.ReadLine();
                    rum5();
                    break;
            }
        }
        static void rum5()
        {
            checkpoint = 5;
            Console.Clear();
            Console.WriteLine("");



        }
        static void rum_1() {
            Console.Write("Type OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine();
            string capDoor = doorChoice.ToUpper();
            Console.WriteLine();

            if (capDoor == "OPEN")
            {
                rum0();

            }
            else if (capDoor == "KNOCK")
            {
                Console.WriteLine(" No one answer");

            }
        }
        static void Main(string[] args)
            {
                bool running = true;
                while (running == true)
                {
                   switch (checkpoint)
                {
                    case 0:
                        rum_1();
                        break;
                    case 5:
                        rum5();
                        break;
                }

                    

                }




            }
        }
    }