using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetName
{


    class Program
    {
        static void Main(string[] args)
        {

           

                // This changes the background to White if the color is black and sets the forground color to black (text)
                if (Console.BackgroundColor == ConsoleColor.Black)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                }


                // This is a beep
                Console.Beep();

                // This is the welcome screen logo

                Console.WriteLine(@"  __  __       _____     _ ");
                Console.WriteLine(@"|  \/  |     |  __ \   | |  ");
                Console.WriteLine(@"| \  / |_   _| |__) |__| |_ ");
                Console.WriteLine(@"| |\/| | | | |  ___/ _ \ __|");
                Console.WriteLine(@"| |  | | |_| | |  |  __/ |_ ");
                Console.WriteLine(@"|_|  |_|\__, |_|   \___|\__|");
                Console.WriteLine(@"         __/ |         ");
                Console.WriteLine(@"        |___/       ");

                Console.WriteLine(@"_____________________ ");
                Console.WriteLine(@"Please choose your pet");
                Console.WriteLine(@"_____________________");






                // This enables the background music and is disabled for now as the sound file has to be in the right directory to work. 
                //if you want to play the background sound place the soundfile in your directory of your choosing


            // This sets the background track, make sure its in the right directory, this will change as you your directory will be different 
            // The background track is called Background.wav and is in the zip folder. This background track was created by a team of students inclduing myself two years ago at a coding camp. 
            
            // I have rights to use this track but it is under copyright as Seedlings. Please do not share this background music track publically with anyone without given consent from myself and the other students who created it. :) 
                 var myPlayer = new System.Media.SoundPlayer();
                 myPlayer.SoundLocation = @"C:\Users\pg09Jaxon\Desktop\MyPetFinal\Background.wav";
                 myPlayer.Play();

                


            // This is where you select what animal you want. 

                Console.WriteLine("1. I want a Dog" +

                Environment.NewLine + "2. I want a Cat" +

                Environment.NewLine + "3. I want a Bear");

                var ans = Console.ReadLine();

                int choice = 0;

                if (int.TryParse(ans, out choice))
                {

                    switch (choice)
                    {

                        case 1:

                            // Prints Dog
                            Console.WriteLine("Congrats you just got a Dog :)");
                            Console.WriteLine(@"Press enter to confirm your pet as a Dog ");
                            Console.Beep();

                            Console.ReadLine();
                            break;

                        case 2:

                            // Prints Cat
                            Console.WriteLine("Congrats you just got a Cat :)");
                            Console.WriteLine(@"Press enter to confirm your pet as a Cat ");
                            Console.Beep();

                            Console.ReadLine();
                            break;

                        case 3:

                            // Prints Bear
                            Console.WriteLine("Awesome you just got a Bear, get ready to go for fun adventures with your Bear! :D");
                            Console.WriteLine(@"Press enter to confirm your pet as a Bear ");
                            Console.Beep();

                            Console.ReadLine();
                            break;


                        default:

                            // Console will print this message if the user enters a number that is not listed
                            Console.WriteLine("Thats not a valid selection" +


                                Environment.NewLine + "");

                            // Console will beep (4) times alerting the user that the selection is invalid 
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();



                            Console.ReadKey();

                            break;

                    }

                }

                else
                {
                    // Console prints numbers only if the user enters a letter 
                    Console.WriteLine("Numbers Only" +


                        //Console prints this as well on a new line to tell the user that  they must use a number
                      Environment.NewLine + "You must only use a number to choose a option");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();


                    Console.ReadKey();

                }


               
                // Name the pet here
                Console.WriteLine(@"___________________________");
                Console.WriteLine(@" Please Name Your New Pet");
                Console.WriteLine(@"___________________________");
                Console.Beep();


                // This string sets the name of the pet
                string newName = Console.ReadLine();
                pet oMyPet = new pet(newName);
                Console.Beep();
                Console.Beep();

            

                // Press enter to feed your pet
                oMyPet.Eat();

              
                Console.WriteLine(@" ____                 _     __          _   ");
                Console.WriteLine(@"|  _ \               | |   / _|        | |  ");
                Console.WriteLine(@"| |_) |_ __ ___  __ _| | _| |_ __ _ ___| |_ ");
                Console.WriteLine(@"|  _ <| '__/ _ \/ _` | |/ /  _/ _` / __| __|");
                Console.WriteLine(@"| |_) | | |  __/ (_| |   <| || (_| \__ \ |_ ");
                Console.WriteLine(@"|____/|_|  \___|\__,_|_|\_\_| \__,_|___/\__|");
          






                Console.WriteLine("______________________________");
                Console.Beep();


                //Console pauses here
                Console.ReadLine();


                // Console prints that the pet is fed
                oMyPet.FedPet();
                Console.Beep();
                Console.Beep();


                // Console pauses here
                Console.ReadLine();



                //

                // Loops entire application
                while (true)
                {

                    // This is the start of a new day. The user can do two actions every day before it reloads the game and starts another day.
                Console.WriteLine(@"___________________________");
                Console.WriteLine(@" Its a new sunny day what would you like to do?");
                Console.WriteLine(@"___________________________");

                Console.WriteLine("1. Take your pet for a walk" +

                Environment.NewLine + "2. Go on a road trip" +

                Environment.NewLine + "3. Go hiking" +

                Environment.NewLine + "4. Go swimming" +

                Environment.NewLine + "5. Go chase cats" +

                Environment.NewLine + "6. Make your pet do a flip");



                var and = Console.ReadLine();

                int choice2 = 0;

                if (int.TryParse(and, out choice2))
                {

                    switch (choice2)
                    {

                        case 1:
                            Console.WriteLine("You are now walking your pet in the park :)");
                            Console.WriteLine(@"Its a beautiful day and your pet is happy ");
                            Console.Beep();
                            Console.Beep();

                            oMyPet.Happy();


                            Console.ReadLine();



                            break;

                        case 2:

                            Console.WriteLine("Yayy lets go roadtrippin :D ");

                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine("We are in Vancouver now, press enter");




                            Console.WriteLine(@"__      __ ");
                            Console.WriteLine(@"\ \    / /");
                            Console.WriteLine(@"\ \  / /_ _ _ __   ___ ___  _   ___   _____ _ __ ");
                            Console.WriteLine(@" \ \/ / _` | '_ \ / __/ _ \| | | \ \ / / _ \ '__|");
                            Console.WriteLine(@"  \  / (_| | | | | (_| (_) | |_| |\ V /  __/ |   ");
                            Console.WriteLine(@"   \/ \__,_|_| |_|\___\___/ \__,_| \_/ \___|_|   ");

                            // Console Beeps twice
                            Console.Beep();
                            Console.Beep();



                            Console.ReadLine();
                            Console.WriteLine("__________________________________");
                            Console.WriteLine("Now we are in Seattle, press enter");
                            Console.WriteLine("__________________________________");
                            Console.ReadLine();

                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine("Look its the Space Needle, press enter");

                            Console.WriteLine(@"  _____            _   _   _    ");
                            Console.WriteLine(@" / ____|          | | | | | |  ");
                            Console.WriteLine(@"| (___   ___  __ _| |_| |_| | ");
                            Console.WriteLine(@" \___ \ / _ \/ _` | __| __| |/ _ \");
                            Console.WriteLine(@" ____) |  __/ (_| | |_| |_| |  __/");
                            Console.WriteLine(@"|_____/ \___|\__,_|\__|\__|_|\___|");

                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("I wonder where we are now, wait look it's The Golden Gate Bridge , press enter");
                            Console.WriteLine("_______________________________________________________________________________");

                            Console.ReadLine();

                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine(@"  _____               ______                    _              ");
                            Console.WriteLine(@" / ____|             |  ____|                  (_)            ");
                            Console.WriteLine(@"| (___   __ _ _ __   | |__ _ __ __ _ _ __   ___ _ ___  ___ ___  ");
                            Console.WriteLine(@" \___ \ / _` | '_ \  |  __| '__/ _` | '_ \ / __| / __|/ __/ _ \ ");
                            Console.WriteLine(@" __) | (_| | | | | | |  | | | (_| | | | | (__| \__ \ (_| (_) |");
                            Console.WriteLine(@"|_____/ \__,_|_| |_| |_|  |_|  \__,_|_| |_|\___|_|___/\___\___/ ");


                            // Console Beeps twice
                            Console.Beep();
                            Console.Beep();


                            Console.WriteLine("_________________________");
                            oMyPet.sleep();
                            Console.WriteLine("_________________________");
                            Console.Beep();

                            Console.ReadLine();
                            break;


                        case 3:
                            Console.WriteLine("Okay lets go for a hike");
                            Console.WriteLine(@" I love hiking, it keeps me fit ");
                            Console.Beep();
                            Console.Beep();

                            oMyPet.Happy();


                            Console.ReadLine();



                            break;


                        case 4:
                            Console.WriteLine("Lets go swimming and cool off");
                            Console.WriteLine(@"Where should we go swimming though? ");
                            Console.Beep();
                            Console.Beep();


                            //

                            Console.WriteLine("1. Swimming Pool" +

                            Environment.NewLine + "2. The Ocean" +

                            Environment.NewLine + "3. The Lake");

                            var petswim = Console.ReadLine();

                            int petswimchoice = 0;

                            if (int.TryParse(petswim, out petswimchoice))
                            {

                                switch (petswimchoice)
                                {

                                    case 1:


                                        // Prints Swimming Pool option
                                        Console.WriteLine("________________________");
                                        Console.WriteLine("Okay lets go to the pool");
                                        Console.WriteLine("________________________");
                                        Console.WriteLine("I love the pool ");
                                        Console.Beep();
                                        Console.WriteLine("");

                                        Console.ReadLine();
                                        break;

                                    case 2:

                                        // Prints Ocean option 
                                        Console.WriteLine("Okay lets go to the ocean");
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();
                                        Console.WriteLine(@"arrived Lets go swimming");
                                        Console.Beep();
                                        Console.Beep();
                                        Console.WriteLine(@"Yay this is so much fun");
                                        Console.WriteLine(@"I love the water");


                                        Console.ReadLine();
                                        break;

                                    case 3:

                                        // Prints Lake Option
                                        Console.WriteLine("Okay lets go to the lake");
                                        Console.WriteLine(@"");
                                        Console.WriteLine(@"Driving to the lake");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the lake");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the lake");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the lake");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the lake");
                                        Console.Beep();
                                        Console.WriteLine(@"arrived at the pool");
                                        Console.Beep();
                                        Console.Beep();
                                        Console.WriteLine(@"Yay this is so much fun");
                                        Console.WriteLine(@"I love the water");


                                        Console.Beep();
                                        Console.ReadLine();
                                        break;


                                    default:

                                        // Console will print this message if the user enters a number that is not listed
                                        Console.WriteLine("OKAY" +


                                            Environment.NewLine + "");

                                        // Console will beep (4) times alerting the user that the selection is invalid 
                                        Console.Beep();
                                        Console.Beep();
                                        Console.Beep();
                                        Console.Beep();



                                        Console.ReadKey();

                                        break;

                                }

                            }
                            //


                            oMyPet.Happy();


                            Console.ReadLine();



                            break;


                        case 5:
                            Console.WriteLine("Yes lets go chase some cats ");
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing almost caught one  ");
                            Console.Beep();
                            Console.WriteLine(@" ooooh a cookie ");
                            Console.Beep();
                            Console.WriteLine(@" cookie ");
                            Console.Beep();
                            Console.WriteLine(@" okay back to chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();

                            Console.WriteLine(@" I got a cat!!");
                            Console.Beep();
                            Console.WriteLine(@"lets be friends ");




                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine("________________________");
                            oMyPet.Happy();
                            Console.WriteLine("________________________");


                            Console.ReadLine();



                            break;


                        case 6:

                            Console.WriteLine("Your pet did 1 flip");
                            Console.Beep();
                            Console.WriteLine(@"and another 2 flips");

                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine(@"__          ________          __");
                            Console.WriteLine(@"\ \        / / __ \ \        / /");
                            Console.WriteLine(@" \ \  /\  / / |  | \ \  /\  / / ");
                            Console.WriteLine(@"  \ \/  \/ /| |  | |\ \/  \/ /  ");
                            Console.WriteLine(@"   \  /\  / | |__| | \  /\  /   ");
                            Console.WriteLine(@"    \/  \/   \____/   \/  \/    ");

                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();



                            oMyPet.Drink();
                            Console.Beep();
                            Console.ReadLine();


                            oMyPet.Happy();
                            Console.Beep();
                            Console.ReadLine();

                            break;


                        default:
                            // Console will print this message if the user enters a number that is not listed
                            Console.WriteLine("Thats not a valid selection" +


                                Environment.NewLine + "");

                            // Console will beep (4) times alerting the user that the selection is invalid 
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();

                            Console.ReadKey();

                            break;

                    }

                }

                else
                {

                    // Console prints numbers only if the user enters a letter 
                    Console.WriteLine("Numbers Only" +


                        //Console prints this as well on a new line to tell the user that  they must use a number
                      Environment.NewLine + "You must only use a number to choose a option");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();


                    Console.ReadKey();

                }


                    // Repeat Code above so that the pet can do two things per day before a new day begins (START)


                Console.WriteLine(@"___________________________");
                Console.WriteLine(@" That was fun, what would you like to do for the rest of the day?");
                Console.WriteLine(@"___________________________");

                Console.WriteLine("1. Take your pet for a walk" +

                Environment.NewLine + "2. Go on a road trip" +

                Environment.NewLine + "3. Go hiking" +

                Environment.NewLine + "4. Go swimming" +

                Environment.NewLine + "5. Go chase cats" +

                Environment.NewLine + "6. Make your pet do a flip");



                var newday = Console.ReadLine();

                int newdaychoice = 0;

                if (int.TryParse(newday, out newdaychoice))
                {

                    switch (newdaychoice)
                    {

                        case 1:
                            Console.WriteLine("You are now walking your pet in the park :)");
                            Console.WriteLine(@"Its a beautiful day and your pet is happy ");
                            Console.Beep();
                            Console.Beep();

                            oMyPet.Happy();


                            Console.ReadLine();



                            break;

                        case 2:

                            Console.WriteLine("Yayy lets go roadtrippin :D ");

                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine("We are in Vancouver now, press enter");




                            Console.WriteLine(@"__      __ ");
                            Console.WriteLine(@"\ \    / /");
                            Console.WriteLine(@"\ \  / /_ _ _ __   ___ ___  _   ___   _____ _ __ ");
                            Console.WriteLine(@" \ \/ / _` | '_ \ / __/ _ \| | | \ \ / / _ \ '__|");
                            Console.WriteLine(@"  \  / (_| | | | | (_| (_) | |_| |\ V /  __/ |   ");
                            Console.WriteLine(@"   \/ \__,_|_| |_|\___\___/ \__,_| \_/ \___|_|   ");

                            // Console Beeps twice
                            Console.Beep();
                            Console.Beep();



                            Console.ReadLine();
                            Console.WriteLine("__________________________________");
                            Console.WriteLine("Now we are in Seattle, press enter");
                            Console.WriteLine("__________________________________");
                            Console.ReadLine();

                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine("Look its the Space Needle, press enter");

                            Console.WriteLine(@"  _____            _   _   _    ");
                            Console.WriteLine(@" / ____|          | | | | | |  ");
                            Console.WriteLine(@"| (___   ___  __ _| |_| |_| | ");
                            Console.WriteLine(@" \___ \ / _ \/ _` | __| __| |/ _ \");
                            Console.WriteLine(@" ____) |  __/ (_| | |_| |_| |  __/");
                            Console.WriteLine(@"|_____/ \___|\__,_|\__|\__|_|\___|");

                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("I wonder where we are now, wait look it's The Golden Gate Bridge , press enter");
                            Console.WriteLine("_______________________________________________________________________________");

                            Console.ReadLine();

                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine(@"  _____               ______                    _              ");
                            Console.WriteLine(@" / ____|             |  ____|                  (_)            ");
                            Console.WriteLine(@"| (___   __ _ _ __   | |__ _ __ __ _ _ __   ___ _ ___  ___ ___  ");
                            Console.WriteLine(@" \___ \ / _` | '_ \  |  __| '__/ _` | '_ \ / __| / __|/ __/ _ \ ");
                            Console.WriteLine(@" __) | (_| | | | | | |  | | | (_| | | | | (__| \__ \ (_| (_) |");
                            Console.WriteLine(@"|_____/ \__,_|_| |_| |_|  |_|  \__,_|_| |_|\___|_|___/\___\___/ ");


                            // Console Beeps twice
                            Console.Beep();
                            Console.Beep();


                            Console.WriteLine("_________________________");
                            oMyPet.sleep();
                            Console.WriteLine("_________________________");
                            Console.Beep();

                            Console.ReadLine();
                            break;


                        case 3:
                            Console.WriteLine("Okay lets go for a hike");
                            Console.WriteLine(@" I love hiking, it keeps me fit ");
                            Console.Beep();
                            Console.Beep();

                            oMyPet.Happy();


                            Console.ReadLine();



                            break;


                        case 4:
                            Console.WriteLine("Lets go swimming and cool off");
                            Console.WriteLine(@"Where should we go swimming though? ");
                            Console.Beep();
                            Console.Beep();


                            //

                            Console.WriteLine("1. Swimming Pool" +

                            Environment.NewLine + "2. The Ocean" +

                            Environment.NewLine + "3. The Lake");

                            var petswim = Console.ReadLine();

                            int petswimchoice = 0;

                            if (int.TryParse(petswim, out petswimchoice))
                            {

                                switch (petswimchoice)
                                {

                                    case 1:


                                        // Prints Swimming Pool option
                                        Console.WriteLine("________________________");
                                        Console.WriteLine("Okay lets go to the pool");
                                        Console.WriteLine("________________________");
                                        Console.WriteLine(@"I love the pool ");
                                        Console.Beep();

                                        Console.ReadLine();
                                        break;

                                    case 2:

                                        // Prints Ocean option 
                                        Console.WriteLine("Okay lets go to the ocean");
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the ocean");
                                        Console.Beep();

                                        Console.ReadLine();
                                        break;

                                    case 3:

                                        // Prints Lake Option
                                        Console.WriteLine("Okay lets go to the lake");
                                        Console.WriteLine(@"");
                                        Console.WriteLine(@"Driving to the lake");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the lake");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the lake");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the lake");
                                        Console.Beep();
                                        Console.WriteLine(@"Driving to the lake");


                                        Console.Beep();
                                        Console.ReadLine();
                                        break;


                                    default:

                                        // Console will print this message if the user enters a number that is not listed
                                        Console.WriteLine("OKAY" +


                                            Environment.NewLine + "");

                                        // Console will beep (4) times alerting the user that the selection is invalid 
                                        Console.Beep();
                                        Console.Beep();
                                        Console.Beep();
                                        Console.Beep();



                                        Console.ReadKey();

                                        break;

                                }

                            }
                            //


                            oMyPet.Happy();


                            Console.ReadLine();



                            break;


                        case 5:
                            Console.WriteLine("Yes lets go chase some cats ");
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing almost caught one  ");
                            Console.Beep();
                            Console.WriteLine(@" ooooh a cookie ");
                            Console.Beep();
                            Console.WriteLine(@" cookie ");
                            Console.Beep();
                            Console.WriteLine(@" okay back to chasing ");
                            Console.Beep();
                            Console.WriteLine(@" chasing ");
                            Console.Beep();

                            Console.WriteLine(@" I got a cat!!");
                            Console.Beep();
                            Console.WriteLine(@"lets be friends ");




                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine("________________________");
                            oMyPet.Happy();
                            Console.WriteLine("________________________");


                            Console.ReadLine();



                            break;


                        case 6:

                            Console.WriteLine("Your pet did 1 flip");
                            Console.Beep();
                            Console.WriteLine(@"and another 2 flips");

                            Console.Beep();
                            Console.Beep();

                            Console.WriteLine(@"__          ________          __");
                            Console.WriteLine(@"\ \        / / __ \ \        / /");
                            Console.WriteLine(@" \ \  /\  / / |  | \ \  /\  / / ");
                            Console.WriteLine(@"  \ \/  \/ /| |  | |\ \/  \/ /  ");
                            Console.WriteLine(@"   \  /\  / | |__| | \  /\  /   ");
                            Console.WriteLine(@"    \/  \/   \____/   \/  \/    ");

                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();



                            oMyPet.Drink();
                            Console.Beep();
                            Console.ReadLine();


                            oMyPet.Happy();
                            Console.Beep();
                            Console.ReadLine();

                            break;


                        default:
                            // Console will print this message if the user enters a number that is not listed
                            Console.WriteLine("Thats not a valid selection" +


                                Environment.NewLine + "");

                            // Console will beep (4) times alerting the user that the selection is invalid 
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();

                            Console.ReadKey();

                            break;

                    }

                }

                else
                {

                    // Console prints numbers only if the user enters a letter 
                    Console.WriteLine("Numbers Only" +


                        //Console prints this as well on a new line to tell the user that  they must use a number
                      Environment.NewLine + "You must only use a number to choose a option");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();


                    Console.ReadKey();

                }


                    // Repeat Code above so that the pet can do two things per day before a new day begins (END)









                // End of day starts here
                Console.WriteLine("____________________________________");
                Console.WriteLine("Press enter to put your pet to sleep");
                Console.WriteLine("_____________________________________");
                Console.ReadLine();

                Console.Beep();
                Console.Beep();

                Console.WriteLine("________________________");
                oMyPet.BedTime();
                Console.WriteLine("________________________");


                Console.ReadLine();
                Console.Beep();
                // End of start day, new day will occur repeating the code above in a while loop




            }


        }

    } // End of while loop

} // End of App



