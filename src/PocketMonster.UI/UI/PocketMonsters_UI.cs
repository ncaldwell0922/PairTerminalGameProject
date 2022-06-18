using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class PocketMonsters_UI
    {
        private readonly Backpack_Lists _lRepo = new Backpack_Lists();
        // private readonly PMCenters _sRepo = new PMCenters();
        public readonly PointDexitron_Dictionary _dRepo = new PointDexitron_Dictionary();

        public void Run()
        {
            SeedData();
            RunApplication();
        }

        private void SeedData()
        {
            PocketMonsters bulbasaur = new PocketMonsters(1, Elements.Grass, "Bulbasaur");
            PocketMonsters ivysaur = new PocketMonsters(2, Elements.Grass, "Ivysaur");
            PocketMonsters venusaur = new PocketMonsters(3, Elements.Grass, "Venusaur");
            PocketMonsters charmander = new PocketMonsters(4, Elements.Fire, "Charmander");
            PocketMonsters charmeleon = new PocketMonsters(5, Elements.Fire, "Charmeleon");
            PocketMonsters charizard = new PocketMonsters(6, Elements.Fire, "Charizard");
            PocketMonsters squirtle = new PocketMonsters(7, Elements.Water, "Squirtle");
            PocketMonsters wartorle = new PocketMonsters(8, Elements.Water, "Wartorle");
            PocketMonsters blastoise = new PocketMonsters(9, Elements.Water, "Blastoise");
            PocketMonsters caterpie = new PocketMonsters(10, Elements.Bug, "Caterpie");
            PocketMonsters metapod = new PocketMonsters(11, Elements.Bug, "Metapod");
            PocketMonsters butterfree = new PocketMonsters(12, Elements.Bug, "Butterfree");
            PocketMonsters weedle = new PocketMonsters(13, Elements.Bug, "Weedle");
            PocketMonsters kakuna = new PocketMonsters(14, Elements.Bug, "Kakuna");
            PocketMonsters beedrill = new PocketMonsters(15, Elements.Bug, "Beedrill");
            PocketMonsters pidgey = new PocketMonsters(16, Elements.Normal, "Pidgey");
            PocketMonsters pidgeotto = new PocketMonsters(17, Elements.Normal, "Pidgeotto");
            PocketMonsters pidgeot = new PocketMonsters(18, Elements.Normal, "Pidgeot");
            PocketMonsters rattata = new PocketMonsters(19, Elements.Normal, "Rattata");
            PocketMonsters raticate = new PocketMonsters(20, Elements.Normal, "Raticate");
            PocketMonsters spearow = new PocketMonsters(21, Elements.Normal, "Spearow");
            PocketMonsters fearow = new PocketMonsters(22, Elements.Normal, "Fearow");
            PocketMonsters ekans = new PocketMonsters(23, Elements.Poison, "Ekans");
            PocketMonsters arbok = new PocketMonsters(24, Elements.Poison, "Arbok");
            PocketMonsters pikachu = new PocketMonsters(25, Elements.Grass, "Pikachu");

            _dRepo.AddPMToDictionary(bulbasaur);
            _dRepo.AddPMToDictionary(ivysaur);
            _dRepo.AddPMToDictionary(venusaur);
            _dRepo.AddPMToDictionary(charmander);
            _dRepo.AddPMToDictionary(charmeleon);
            _dRepo.AddPMToDictionary(charizard);
            _dRepo.AddPMToDictionary(squirtle);
            _dRepo.AddPMToDictionary(wartorle);
            _dRepo.AddPMToDictionary(blastoise);
            _dRepo.AddPMToDictionary(caterpie);
            _dRepo.AddPMToDictionary(metapod);
            _dRepo.AddPMToDictionary(butterfree);
            _dRepo.AddPMToDictionary(weedle);
            _dRepo.AddPMToDictionary(kakuna);
            _dRepo.AddPMToDictionary(beedrill);
            _dRepo.AddPMToDictionary(pidgey);
            _dRepo.AddPMToDictionary(pidgeotto);
            _dRepo.AddPMToDictionary(pidgeotto);
            _dRepo.AddPMToDictionary(rattata);
            _dRepo.AddPMToDictionary(raticate);
            _dRepo.AddPMToDictionary(spearow);
            _dRepo.AddPMToDictionary(fearow);
            _dRepo.AddPMToDictionary(ekans);
            _dRepo.AddPMToDictionary(arbok);
            _dRepo.AddPMToDictionary(pikachu);

        }

        private void RunApplication()
        {
            bool isRunning = true;
            while(isRunning)
            {

            // Title Screen and Instructions
            System.Console.WriteLine("\tPOCKET MONSTERS \n" +
            "This game is about aventure, monsters that fit into your pocket and defeating your arch nemesis \n" +
            "for his title of POCKET MONSTER Champion \n"+
            "=================================================================== \n" +
            "\tHOW TO PLAY:" +
            "1. Enter your name. \n" +
            "2. Select a starting POCKET MONSTER. \n" +
            "3. Navigate through the world, where you could encounter wild POCKET MONSTERS that you can collect, \n" +
            "as well as POCKET MONSTER CENTERS where you can add or trade your POCKET MONSTERS. \n" +
            // "4. For reference, you have a Utility Belt that will be your monsters you can battle with and \n" +
            // "you have a Backpack that you can store additional monster and trade out for one on your Utility Belt. \n" +
            // "5. You may only carry THREE monsters on your Utility Belt and TEN monsters in your BackPack. \n" 
            "===================================================================================================== \n");
            PressAnyKey();
            PressXToExit();

            Console.Clear();
            // Enter Name
            System.Console.WriteLine("Please enter your name: \n");
            string userName = Console.ReadLine();
            System.Console.WriteLine($"Hello {userName}! \n");

            // Select starting POCKET MONSTER
            
            System.Console.WriteLine("Please select your starting POCKET MONSTER: \n" +
            "1. Bulbasaur  \n" +
            "2. Charmander \n" +
            "3. Squirle \n");

            int numInput = int.Parse(Console.ReadLine());
            Console.Clear();


            if(numInput == 1)
            {
                System.Console.WriteLine("Are you sure you wanted Bulbasaur? y/n \n");
                string selectPM = Console.ReadLine().ToLower();
                PocketMonsters starterPMOne = _dRepo.GetPMByKey(1);

                if(selectPM == "y")
                {
                    _dRepo.DeletePocketMonster(1);
                    _lRepo.AddPMToList(starterPMOne);
                    System.Console.WriteLine("Congrats! Bulbasaur has been added to your Backpack!");
                    
                }
                else
                {
                    System.Console.WriteLine("Failed to add that monster to your inventory.");;
                }

            }
            else if(numInput == 2)
            {
                System.Console.WriteLine("Are you sure you wanted Charmander? y/n \n");
                string selectPM = Console.ReadLine().ToLower();
                PocketMonsters starterPMTwo = _dRepo.GetPMByKey(4);

                if(selectPM == "y")
                {
                    _dRepo.DeletePocketMonster(4);
                    _lRepo.AddPMToList(starterPMTwo);
                    System.Console.WriteLine("Congrats! Charmander has been added to your Backpack!");
                    
                }
                else
                {
                    System.Console.WriteLine("Failed to add that monster to your inventory.");;
                }

            }
            else if(numInput == 3)
            {
                System.Console.WriteLine("Are you sure you wanted Squirtle? y/n \n");
                string selectPM = Console.ReadLine().ToLower();
                PocketMonsters starterPMThree = _dRepo.GetPMByKey(7);

                if(selectPM == "y")
                {
                    _dRepo.DeletePocketMonster(7);
                    _lRepo.AddPMToList(starterPMThree);
                    System.Console.WriteLine("Congrats! Squirtle has been added to your Backpack!");
                    
                }
                else
                {
                    System.Console.WriteLine("Failed to add that monster to your inventory.");;
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Selection.");
            }

            PressAnyKey();

            Console.Clear();
            System.Console.WriteLine($"{userName}, you now have a new companion to start your adventure. \n" +
            "Now it's time to leave home and make your way to the local POCKET MONSTER Gym to battle your rival \n " +
            "for title of Champion!");
            PressAnyKey();

            directSelectOne();
            }
        }

        
            // Encounters
            // private void firstEncounter()
            // {
            //     Console.Clear();
                
            //     System.Console.WriteLine("You step outside to a beautiful sunny day ready for adventure when \n" +
            //     $"all of a sudden, you come across a {randPM}. With all your skills, you capture it and \n" +
            //     "add it to your backpack.");

            //     PressAnyKey();


            // }
            // private void secondEncounter();
            // {

            // }

            // private void thirdEncounter()
            // {

            // }

            // private void fourthEncounter()
            // {

            // }

            // Direction Selections
            private void directSelectOne()
            {
                Console.Clear();

                System.Console.WriteLine("You have come to a T in the road. Both directions look promising. \n" +
                "Which way do you want to go? \n" +
                "Left \n" +
                "Right \n");

                bool input = true;
                    while(input)
                    {
                        string choiceOne;
                        choiceOne = Console.ReadLine().ToLower();
                        switch(choiceOne)
                            {
                                case "left":
                                case "l":
                                    directSelectTwoLeft();
                                    break;
                                case "right":
                                case "r":
                                    directSelectTwoRight();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectTwoLeft()
            {
                Console.Clear();

                System.Console.WriteLine("The road ahead bends to the right. Looks like that is \n" +
                "the only path available. Which way would you like to travel? \n" +
                "Right \n" +
                "Go Back \n");
                
                bool input = true;
                    while(input)
                    {
                        string choiceTwoLeft;
                        choiceTwoLeft = Console.ReadLine().ToLower();
                        switch(choiceTwoLeft)
                            {
                                case "right":
                                case "r":
                                    directSelectThree();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectOne();
                                    break;
                                default:
                                System.Console.WriteLine("Invalid Input. Try again..");
                                input = true;
                                break;
                            }
                    }
            }

            private void directSelectTwoRight()
            {
                Console.Clear();

                System.Console.WriteLine("Another T in the road! You can see a field to your right \n" +
                "and another pathway to your left. Which way would you like to go? \n" +
                "Left \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceTwoRight;
                        choiceTwoRight = Console.ReadLine().ToLower();
                        switch(choiceTwoRight)
                            {
                                case "left":
                                case "l":
                                    directSelectSeven();
                                    break;
                                case "right":
                                case "r":
                                    deadEndOne();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectOne();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectThree()
            {
                Console.Clear();

                System.Console.WriteLine("The path ahead seems to just keep going. \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceThree;
                        choiceThree = Console.ReadLine().ToLower();
                        switch(choiceThree)
                            {
                                case "straight":
                                case "s":
                                    // secondEncounter();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTwoLeft();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectFour()
            {
                Console.Clear();

                System.Console.WriteLine("As you leave the Monster Center, the path \n" +
                "goes up a hill. As it comes down the other side, it veers to the right. \n" +
                "Which way would you like to go? \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceFour;
                        choiceFour = Console.ReadLine().ToLower();
                        switch(choiceFour)
                            {
                                case "right":
                                case "r":
                                    directSelectFive();
                                    break;
                                case "go back":
                                case "back":
                                    // MonsterCenterOne();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectFive()
            {
                Console.Clear();

                System.Console.WriteLine("You keep following the path in front of you. \n" +
                "You can't see other options other than go back the way you came. \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceFour;
                        choiceFour = Console.ReadLine().ToLower();
                        switch(choiceFour)
                            {
                                case "straight":
                                case "s":
                                    deadEndTwo();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectFour();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectSeven()
            {
                Console.Clear();

                System.Console.WriteLine("The path starts to lead into a small forest. \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceSeven;
                        choiceSeven = Console.ReadLine().ToLower();
                        switch(choiceSeven)
                            {
                                case "straight":
                                case "s":
                                    directSelectEight();
                                    break;
                                case "right":
                                case "r":
                                    // MonsterCenterTwo();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTwoRight();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectEight()
            {
                Console.Clear();

                System.Console.WriteLine("The path gets darker as the trees cover more of the \n" +
                "sky. The route has split off in different directions. \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Straight \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceEight;
                        choiceEight = Console.ReadLine().ToLower();
                        switch(choiceEight)
                            {
                                case "left":
                                case "l":
                                    deadEndThree();
                                    break;
                                case "straight":
                                case "s":
                                    // thirdEncounter();
                                    break;
                                case "right":
                                case "r":
                                    directSelectTwelve();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTwoLeft();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectNine()
            {
                Console.Clear();

                System.Console.WriteLine("The path is dark and it's getting hard to see. \n" + 
                "What you can see is that the route has split off in different directions again. \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Straight \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceNine;
                        choiceNine = Console.ReadLine().ToLower();
                        switch(choiceNine)
                            {
                                case "left":
                                case "l":
                                    deadEndFour();
                                    break;
                                case "straight":
                                case "s":
                                    deadEndFive();
                                    break;
                                case "right":
                                case "r":
                                    directSelectTen();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectEight();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectTen()
            {
                Console.Clear();

                System.Console.WriteLine("You finally reach the end of the forest and you see the  \n" +
                "bright blue sky you hadn't seen for awhile. The path curves to left ahead. \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceTen;
                        choiceTen = Console.ReadLine().ToLower();
                        switch(choiceTen)
                            {
                                case "left":
                                case "l":
                                    directSelectEleven();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectNine();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectEleven()
            {
                System.Console.WriteLine("As the path comes to an end see a few different paths. \n" + 
                "To your left looks like more road and creatures lurking about, to your right you can \n" +
                "see the signs for a Monster Center and directly in front of you is the town's Pocket \n" +
                "Monster Gym. \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Straight \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceEleven;
                        choiceEleven = Console.ReadLine().ToLower();
                        switch(choiceEleven)
                            {
                                case "left":
                                case "l":
                                    deadEndNine();
                                    break;
                                case "straight":
                                case "s":
                                    gymLeaderBattle();
                                    break;
                                case "right":
                                case "r":
                                    MonsterCenterThree();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTen();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectTwelve()
            {
                Console.Clear();

                System.Console.WriteLine("As the path twists and turns through the trees,  \n" +
                "it takes a sharp left turn between two giant bushes. \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceTwelve;
                        choiceTwelve = Console.ReadLine().ToLower();
                        switch(choiceTwelve)
                            {
                                case "left":
                                case "l":
                                    directSelectThirteen();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectEight();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectThirteen()
            {
                Console.Clear();

                System.Console.WriteLine("Another T in the road! Both paths look dark and scary.\n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceThirteen;
                        choiceThirteen = Console.ReadLine().ToLower();
                        switch(choiceThirteen)
                            {
                                case "left":
                                case "l":
                                    deadEndSix();
                                    break;
                                case "right":
                                case "r":
                                    deadEndSeven();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTwelve();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectFourteen()
            {
                Console.Clear();

                System.Console.WriteLine("The path turns into a straight shot to what \n" +
                "looks to be a clearing ahead. The road is really long though... \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceFourteen;
                        choiceFourteen = Console.ReadLine().ToLower();
                        switch(choiceFourteen)
                            {
                                case "straight":
                                case "s":
                                    directSelectFifteen();
                                    break;
                                case "go back":
                                case "back":
                                    MonsterCenterTwo();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectFifteen()
            {
                Console.Clear();

                System.Console.WriteLine("The path just keeps going... \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceFifteen;
                        choiceFifteen = Console.ReadLine().ToLower();
                        switch(choiceFifteen)
                            {
                                case "straight":
                                case "s":
                                    directSelectSixteen();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectFourteen();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectSixteen()
            {
                Console.Clear();

                System.Console.WriteLine("and going... \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceSixteen;
                        choiceSixteen = Console.ReadLine().ToLower();
                        switch(choiceSixteen)
                            {
                                case "straight":
                                case "s":
                                    directSelectSeventeen();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectFifteen();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectSeventeen()
            {
                Console.Clear();

                System.Console.WriteLine("aaaannndddd going......it looks like there might be \n" +
                "something ahead. \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceSeventeen;
                        choiceSeventeen = Console.ReadLine().ToLower();
                        switch(choiceSeventeen)
                            {
                                case "straight":
                                case "s":
                                    deadEndEight();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectSixteen();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }





            // Dead Ends
            private void deadEndOne()
            {
                Console.Clear();

                System.Console.WriteLine("The road ends at a nice serene field full of \n" +
                "wildflowers and... well thats about it. You should try another path. \n" +
                " \n" +
                "Go back");

                bool input = true;
                    while(input)
                    {
                        string deadEndNum1;
                        deadEndNum1 = Console.ReadLine().ToLower();
                        switch(deadEndNum1)
                            {
                                case "go back":
                                case "back":
                                    directSelectTwoRight();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void deadEndTwo()
            {
                Console.Clear();

                System.Console.WriteLine("As you enjoy the beauty of nature, you miss \n" +
                "the giant hole in the ground. You fall in the hole and break you leg. It takes \n" +
                "a couple of hours for someone to find you and take you to get help. You must \n" +
                "continue this adventure another time. \n" +
                " \n");

                PressAnyKeyGameOver();
            }

            private void deadEndThree()
            {
                Console.Clear();

                System.Console.WriteLine("You come to a lake in the forest. A light breeze \n" +
                "creates ripples on the water. A pretty sight but unfortunately there is nowhere \n" +
                "else to go from here. It's a pretty big lake. You should try another path. \n" +
                " \n" +
                "Go back");

                bool input = true;
                    while(input)
                    {
                        string deadEndNum2;
                        deadEndNum2 = Console.ReadLine().ToLower();
                        switch(deadEndNum2)
                            {
                                case "go back":
                                case "back":
                                    directSelectEight();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void deadEndFour()
            {
                Console.Clear();
                //Fourth Encounter
                System.Console.WriteLine("As the path gets smaller, the trees get closer and then  \n" +
                "path disappears. You notice something hiding in the bushes. \n");


                System.Console.WriteLine("There is nothing else to see here. You should try another path. \n" +
                " \n" +
                "Go back");

                bool input = true;
                    while(input)
                    {
                        string deadEndNum4;
                        deadEndNum4 = Console.ReadLine().ToLower();
                        switch(deadEndNum4)
                            {
                                case "go back":
                                case "back":
                                    directSelectNine();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void deadEndFive()
            {
                Console.Clear();

                System.Console.WriteLine("The path gets narrow and the trees around are drawing \n" +
                "closer but you push through trying to get to the other side. You are fighting so hard \n" +
                "to get through the vegetation that you don't notice the steep cliff. You slip and fall \n" +
                "breaking your legs. A couple hours later you are luckily air-lifted from the forest. \n " +
                "You must continue this adventure another time. \n" +
                " \n");

                PressAnyKeyGameOver();
            }

            private void deadEndSix()
            {
                Console.Clear();

                System.Console.WriteLine("The path slowly starts to disappear and you find \n" +
                "yourself surrounded by vegetation and trees. Doesn't seem like there is \n" +
                "a way through it. You should try another path. \n" +
                " \n" +
                "Go back");

                bool input = true;
                    while(input)
                    {
                        string deadEndNum6;
                        deadEndNum6 = Console.ReadLine().ToLower();
                        switch(deadEndNum6)
                            {
                                case "go back":
                                case "back":
                                    directSelectThirteen();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void deadEndSeven()
            {
                Console.Clear();

                System.Console.WriteLine("One the path lies one giant Snorlax, who seems to \n" +
                "be in a deep sleep. On either side of him are thick and thorny vines. There isn't \n" +
                "anyway to go forward from here. You should try another path. \n" +
                " \n" +
                "Go back");

                bool input = true;
                    while(input)
                    {
                        string deadEndNum7;
                        deadEndNum7 = Console.ReadLine().ToLower();
                        switch(deadEndNum7)
                            {
                                case "go back":
                                case "back":
                                    directSelectThirteen();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void deadEndEight()
            {
                Console.Clear();

                System.Console.WriteLine("As you are strolling along on this long route you \n" +
                "come across a field. In the distance you see some wild Pocket Monsters. As \n" +
                "you walk across the field, the grass comes up to your knees and it gets \n" +
                "harder to walk. All of a sudden, you step in a trap that was laid out for \n" +
                "a mosnster and it breaks your leg. A local traveler spots you and calls for help. \n" +
                "Emergency services rescue you and take you to the nearest hospital. \n" +
                "You must continue this adventure another time. \n" +
                
                " \n");

                PressAnyKeyGameOver();
            }




            //Pocket Monster Centers
            // private void MonsterCenterOne()
            // {

            // }
            // private void MonsterCenterTwo()
            // {

            // }
            // private void MonsterCenterThree()
            // {

            // }


        //HELPER METHODS
        // private PocketMonsters PMInDictionary(int id)
        // {
        //     Dictionary<PocketMonsters> pocketMonsters = _dRepo.GetMonster();
        //     foreach(PocketMonsters p in pocketMonsters)
        //     {
        //         if(p.ID == id)
        //         {
        //             return p;
        //         }
        //     }
        //     return null;
        // }

        private void PressAnyKey()
        {
            System.Console.WriteLine("Press ANY KEY to continue...");
            Console.ReadLine();
        }
        
        private void PressXToExit()
        {
            System.Console.WriteLine("Press X to exit the game...");
            string userInput = Console.ReadLine().ToLower();

            if(userInput == "x")
            {
                Console.Clear();
                System.Console.WriteLine("Thanks for playing!");
                PressAnyKey();
                Environment.Exit(0);
            }
            
        }

        private void PressAnyKeyGameOver()
        {
            System.Console.WriteLine("Game Over \n" +
            "Would you like to try again or exit the game? \n" +
            "Try Again \n" +
            "Exit Game \n");


                bool input = true;
                    while(input)
                    {
                        string gameOver;
                        gameOver = Console.ReadLine().ToLower();
                        switch(gameOver)
                            {
                                case "try again":
                                    directSelectOne();
                                    break;
                                case "exit game":
                                case "exit":
                                    Console.Clear();
                                    System.Console.WriteLine("Thanks for playing!");
                                    PressAnyKey();
                                    Environment.Exit(0);
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
        }
    }
    
