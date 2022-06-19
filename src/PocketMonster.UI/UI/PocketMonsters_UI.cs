using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class PocketMonsters_UI
    {

        public void Run()
        {
            RunApplication();
        }
        private void RunApplication()
        {
            bool isRunning = true;
            while(isRunning)
            {

            // Title Screen and Instructions
            System.Console.WriteLine("\tPOCKET MONSTERS ADVENTURE GAME \n" +
            "================================================ \n" +
            "\tHOW TO PLAY:\n" +
            "1. Enter your name. \n" +
            "2. Navigate through the world \n" +
            "3. Beware of dead ends(some cause a game over) \n" +
            "================================================ \n");
            PressAnyKey();

            Console.Clear();
            // Enter Name
            System.Console.WriteLine("Please enter your name: \n");
            string userName = Console.ReadLine();
            System.Console.WriteLine($"Hello {userName}! \n");

            Console.Clear();
            System.Console.WriteLine($"Hello {userName}! Welcome to the world of POCKET MONSTERS, that is in no way related to that \n" +
            "other world made by Nintendo. It's full of exciting adventures but can be a little hard to navigate. \n" +
            "That being said, you have received an urgent message from Professor Maple telling you to come to his laboratory.\n " +
            "You gather your things and head out the door!");
            PressAnyKey();

            directSelectZero();
            }
        }


            // Direction Selections
            
            private void directSelectHome()
            {
                Console.Clear();

                System.Console.WriteLine("Not sure why you are back home. The adventure is the other \n" +
                "way. Are you tired already? You can end the game here if you would like or start your \n" +
                "adventure again. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Front Door \n" +
                "Exit Game \n");

                bool input = true;
                    while(input)
                    {
                        string choiceHome;
                        choiceHome = Console.ReadLine().ToLower();
                        switch(choiceHome)
                            {
                                case "front door":
                                case "door":
                                    directSelectZero();
                                    break;
                                case "exit":
                                case "x":
                                    PressXToExit();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }
            
            private void directSelectZero()
            {
                Console.Clear();

                System.Console.WriteLine("You step outside to a bright and sunny day. There is a small \n" +
                "path to the left and a path straight ahead. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Left \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceZero;
                        choiceZero = Console.ReadLine().ToLower();
                        switch(choiceZero)
                            {
                                case "straight":
                                case "s":
                                    directSelectOne();
                                    break;
                                case "left":
                                case "l":
                                    directSelectZeroOne();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectHome();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectZeroOne()
            {
                Console.Clear();

                System.Console.WriteLine("This path seems to follow around your home. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceZeroOne;
                        choiceZeroOne = Console.ReadLine().ToLower();
                        switch(choiceZeroOne)
                            {
                                case "left":
                                case "l":
                                    directSelectZeroTwo();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectZero();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectZeroTwo()
            {
                Console.Clear();

                System.Console.WriteLine("Congratulations. You have found your backyard. It's \n" +
                "nice back here. But you should try another path. \n"+
                " \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceZeroTwo;
                        choiceZeroTwo = Console.ReadLine().ToLower();
                        switch(choiceZeroTwo)
                            {
                                case "go back":
                                case "back":
                                    directSelectZeroOne();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }
            private void directSelectOne()
            {
                Console.Clear();

                System.Console.WriteLine("You have come to a T in the road. Both directions look promising. \n" +
                " \n" +
                "Which way would you like to go? \n" +
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
                "the only path available. \n" +
                " \n" +
                "Which way would you like to travel? \n" +
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
                "and another pathway to your left. \n " +
                " \n" +
                "Which way would you like to go? \n" +
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
                " \n" +
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
                                    directSelectFour();
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

                System.Console.WriteLine("The path goes up a hill. A couple of wild \n" +
                "Spraytles try to race you to the top. They are fast but you are faster. \n" +
                "As the hill comes down the other side, it comes to a T. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceFour;
                        choiceFour = Console.ReadLine().ToLower();
                        switch(choiceFour)
                            {
                                case "left":
                                case "l":
                                    directSelectEighteen();
                                    break;
                                case "right":
                                case "r":
                                    directSelectFive();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectThree();
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
                "You can't see other options other than going straight or to \n" +
                "go back the way you came. \n" +
                " \n" +
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
                "Some wild Soabs seem to be leadng the way in. \n" +
                " \n" +
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
                                    directSelectFourteen();
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
                " \n" +
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
                                    directSelectNine();
                                    break;
                                case "right":
                                case "r":
                                    directSelectTwelve();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectSeven();
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
                " \n" +
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
                "A group of Wigglypoofs dance and sing at the curve. It almost seems like they are luring you. \n" +
                " \n" +
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
                System.Console.WriteLine("As the path comes to an end see a two different paths. \n" + 
                "To your left looks like more road and creatures lurking about and directly in front \n" +
                "of you, you see a sign for the city. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Straight \n" +
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
                                    finish();
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
                " \n" +
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
                "You can see lots of glowing eyes between the trees. You should get going soon! \n" +
                " \n"+
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

                System.Console.WriteLine("The path turns left and then into a straight shot to what \n" +
                "looks to be a clearing ahead. The road is really long though... \n" +
                " \n" +
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
                                    directSelectSeven();
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
                " \n" +
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
                " \n" +
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
                " \n" +
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

            private void directSelectEighteen()
            {
                Console.Clear();

                System.Console.WriteLine("As the path winds, it doesn't seem to go nowhere but \n" +
                "forward. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceEighteen;
                        choiceEighteen = Console.ReadLine().ToLower();
                        switch(choiceEighteen)
                            {
                                case "straight":
                                case "s":
                                    directSelectNineteen();
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

            private void directSelectNineteen()
            {
                Console.Clear();

                System.Console.WriteLine("You have come to yet another T in the road. The path \n" +
                "to the left seems safe and you can feel a breeze. The path to the right takes you  \n" +
                "to the mountain. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceNineteen;
                        choiceNineteen = Console.ReadLine().ToLower();
                        switch(choiceNineteen)
                            {
                                case "left":
                                case "l":
                                    directSelectTwenty();
                                    break;
                                case "right":
                                case "r":
                                    deadEndTen();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectEighteen();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectTwenty()
            {
                Console.Clear();

                System.Console.WriteLine("The path continues for a bit until it reaches a right \n" +
                "turn that leads to the base of the mountain. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceTwenty;
                        choiceTwenty = Console.ReadLine().ToLower();
                        switch(choiceTwenty)
                            {
                                case "right":
                                case "r":
                                    directSelectTwentyOne();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectNineteen();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectTwentyOne()
            {
                Console.Clear();

                System.Console.WriteLine("As you continue to climb, the air gets a bit thinner.\n" +
                "A couple of Monkeez scale the mountain with ease. The only path you see is forward. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceTwentyOne;
                        choiceTwentyOne = Console.ReadLine().ToLower();
                        switch(choiceTwentyOne)
                            {
                                case "straight":
                                case "s":
                                    directSelectTwentyTwo();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTwenty();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectTwentyTwo()
            {
                Console.Clear();

                System.Console.WriteLine("You come to a landing and the path branches in a few directions. \n" +
                "You can see a bit of vegetation to the left, a cave opening in front of you and to the right \n" +
                "the path narrows with a sign saying 'CAVE SHORTCUT AHEAD' written on it. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Straight \n" +
                "Right \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceTwentyTwo;
                        choiceTwentyTwo = Console.ReadLine().ToLower();
                        switch(choiceTwentyTwo)
                            {
                                case "left":
                                case "l":
                                    deadEndEleven();
                                    break;
                                case "straight":
                                case "s":
                                    directSelectTwentyThree();
                                    break;
                                case "right":
                                case "r":
                                    directSelectTwentyFour();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTwentyOne();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectTwentyThree()
            {
                Console.Clear();

                System.Console.WriteLine("You enter the cave and either it's really small or you're really tall.  \n" +
                "Either way you have to crouch a bit to make your way through. You see a pathway in front of you \n" +
                "and you think you can make it through if you duck low enough through it. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceTwentyThree;
                        choiceTwentyThree = Console.ReadLine().ToLower();
                        switch(choiceTwentyThree)
                            {
                                case "straight":
                                case "s":
                                    deadEndTwelve();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTwentyTwo();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectTwentyFour()
            {
                Console.Clear();

                System.Console.WriteLine("The path hugs the side of the cave. It doesn't look like  \n" +
                "Anyone has been on it in quite sometime. Another sign marked 'CAVE SHORTCUT' is pointing \n" +
                "forward. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Straight \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceTwentyFour;
                        choiceTwentyFour = Console.ReadLine().ToLower();
                        switch(choiceTwentyFour)
                            {
                                case "straight":
                                case "s":
                                    directSelectTwentyFive();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTwentyTwo();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void directSelectTwentyFive()
            {
                Console.Clear();

                System.Console.WriteLine("The path is basically non-existent at this point but \n" +
                "another sign marked 'CAVE SHORTCUT THIS WAY' pointing to your left assures you that \n" +
                "you are going the right way. \n" +
                " \n" +
                "Which way would you like to go? \n" +
                "Left \n" +
                "Go Back \n");

                bool input = true;
                    while(input)
                    {
                        string choiceTwentyFive;
                        choiceTwentyFive = Console.ReadLine().ToLower();
                        switch(choiceTwentyFive)
                            {
                                case "left":
                                case "l":
                                    deadEndThirteen();
                                    break;
                                case "go back":
                                case "back":
                                    directSelectTwentyFour();
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
                "wildflowers and wild Butterfrezs and... well thats about it. \n" +
                " \n" +
                "You should try another path. \n" +
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
                "the giant hole in the ground dug out by a nearby Plowlett. You fall in the hole and break you leg. \n" +
                "It takes a couple of hours for someone to find you and take you to get help. \n" +
                "You must continue this adventure another time. \n" +
                " \n");

                PressAnyKeyGameOver();
            }

            private void deadEndThree()
            {
                Console.Clear();

                System.Console.WriteLine("You come to a lake in the forest. A light breeze \n" +
                "creates ripples on the water. A group of Outlandishes frolic around the shore and \n" +
                "Battletortles play in the water. A pretty sight but unfortunately there is nowhere \n" +
                "else to go from here. It's a pretty big lake. \n" +
                " \n" +
                "You should try another path. \n" +
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
                
                System.Console.WriteLine("At the end of the path you see a Roarlithe in a charging stance. \n" +
                "It looks like he might come at you if you don't leave soon. \n" +
                " \n" +
                "You should try another path. \n" +
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
                "break your legs. A couple hours later you are luckily air-lifted from the forest. \n " +
                "You must continue this adventure another time. \n" +
                " \n");

                PressAnyKeyGameOver();
            }

            private void deadEndSix()
            {
                Console.Clear();

                System.Console.WriteLine("The path slowly starts to disappear and you find \n" +
                "yourself surrounded by vegetation and trees. Doesn't seem like there is \n" +
                "a way through it. \n" +
                " \n" +
                "You should try another path. \n" +
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

                System.Console.WriteLine("One the path lies one giant Sleepylax, who seems to \n" +
                "be in a deep sleep. On either side of him are thick and thorny vines. There isn't \n" +
                "anyway to go forward from here. \n" +
                " \n" +
                "You should try another path. \n" +
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
                "come across a field. In the distance you see some wild POCKET MONSTERS frolicing about. As \n" +
                "you walk across the field, the grass comes up to your knees and it gets \n" +
                "harder to walk. All of a sudden, you step in a trap that was laid out for \n" +
                "a mosnster and it breaks your leg. A local traveler spots you and calls for help. \n" +
                "Emergency services rescue you and take you to the nearest hospital. \n" +
                "You must continue this adventure another time. \n" +
                " \n");

                PressAnyKeyGameOver();
            }

            private void deadEndNine()
            {
                Console.Clear();
            
                System.Console.WriteLine("As you turn down the path, you see something in \n" +
                "the distance sitting on a tree stump. It's a cute little Electrichu. Cute as \n" +
                "they are, they tend to get really dangerous when you get close. \n" +
                " \n" +
                "You should try another path \n" +
                "Go back");

                bool input = true;
                    while(input)
                    {
                        string deadEndNum9;
                        deadEndNum9 = Console.ReadLine().ToLower();
                        switch(deadEndNum9)
                            {
                                case "go back":
                                case "back":
                                    directSelectEleven();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void deadEndTen()
            {
                Console.Clear();
            
                System.Console.WriteLine("Going down the path you come to a cliff. It's far too \n" +
                "steep to traverse. \n" +
                " \n" +
                "You should try another path \n" +
                "Go back");

                bool input = true;
                    while(input)
                    {
                        string deadEndNum10;
                        deadEndNum10 = Console.ReadLine().ToLower();
                        switch(deadEndNum10)
                            {
                                case "go back":
                                case "back":
                                    directSelectNineteen();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void deadEndEleven()
            {
                Console.Clear();
            
                System.Console.WriteLine("As you turn down the path, you see something in \n" +
                "the distance sitting on a tree stump. It's a cute little Electrichu. Cute as \n" +
                "they are, they tend to get really dangerous when you get close. \n" +
                " \n" +
                "You should try another path \n" +
                "Go back");

                bool input = true;
                    while(input)
                    {
                        string deadEndNum11;
                        deadEndNum11 = Console.ReadLine().ToLower();
                        switch(deadEndNum11)
                            {
                                case "go back":
                                case "back":
                                    directSelectTwentyTwo();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void deadEndTwelve()
            {
                Console.Clear();
            
                System.Console.WriteLine("You duck under a low hanging rock then you come face to \n" +
                "with a Rockler. He doesn't look happy to see you. He swings to give you a punch but \n" +
                "you dodge it. Unfortunately the Rockler hits the side of the cave and causes a cave in. \n" +
                "You miss the heavy chunk of fall out but during your escape you trip and fall and large \n" +
                "rocks and boulders cruch your legs, breaking them. Luckily some nearby hikers here the \n" +
                "commotion, find you and call emergency services. \n" +
                "You must continue this adventure another time. \n" +
                " \n");

                PressAnyKeyGameOver();

                
            }

            private void deadEndThirteen()
            {
                Console.Clear();
            
                System.Console.WriteLine("You turn the corner and see a hole in the mountain side. \n" +
                "You try to shimmy through the opening but the  \n" +
                "hole is too small for you to get through. \n" +
                " \n" +
                "You should try another path \n" +
                "Go back");

                bool input = true;
                    while(input)
                    {
                        string deadEndNum13;
                        deadEndNum13 = Console.ReadLine().ToLower();
                        switch(deadEndNum13)
                            {
                                case "go back":
                                case "back":
                                    directSelectTwentyFive();
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid Input. Try again..");
                                    input = true;
                                    break;
                            }
                    }
            }

            private void finish()
            {
                Console.Clear();

                System.Console.WriteLine("duh dun nun nun duuuuhhhhhhh \n" +
                "Congratulations on making it to see Professor Maple. \n" +
                "It seems like he might have another adventure for you.");

                PressAnyKey();
                PressXToExit();
            }

        

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
    
