using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class PocketMonsters_UI
    {
        




        public void Run()
        {
            SeedData();
            RunApplication();
        }

        private void SeedData()
        {
            PocketMonster bulbasaur = new PocketMonster(1, Elements.Grass, "Bulbasaur");
            PocketMonster ivysaur = new PocketMonster(2, Elements.Grass, "Ivysaur");
            PocketMonster venusaur = new PocketMonster(3, Elements.Grass, "Venusaur");
            PocketMonster charmander = new PocketMonster(4, Elements.Fire, "Charmander");
            PocketMonster charmeleon = new PocketMonster(5, Elements.Fire, "Charmeleon");
            PocketMonster charizard = new PocketMonster(6, Elements.Fire, "Charizard");
            PocketMonster squirtle = new PocketMonster(7, Elements.Water, "Squirtle");
            PocketMonster wartorle = new PocketMonster(8, Elements.Water, "Wartorle");
            PocketMonster blastoise = new PocketMonster(9, Elements.Water, "Blastoise");
            PocketMonster caterpie = new PocketMonster(10, Elements.Bug, "Caterpie");
            PocketMonster metapod = new PocketMonster(11, Elements.Bug, "Metapod");
            PocketMonster butterfree = new PocketMonster(12, Elements.Bug, "Butterfree");
            PocketMonster weedle = new PocketMonster(13, Elements.Bug, "Weedle");
            PocketMonster kakuna = new PocketMonster(14, Elements.Bug, "Kakuna");
            PocketMonster beedrill = new PocketMonster(15, Elements.Bug, "Beedrill");
            PocketMonster pidgey = new PocketMonster(16, Elements.Normal, "Pidgey");
            PocketMonster pidgeotto = new PocketMonster(17, Elements.Normal, "Pidgeotto");
            PocketMonster pidgeot = new PocketMonster(18, Elements.Normal, "Pidgeot");
            PocketMonster rattata = new PocketMonster(19, Elements.Normal, "Rattata");
            PocketMonster raticate = new PocketMonster(20, Elements.Normal, "Raticate");
            PocketMonster spearow = new PocketMonster(21, Elements.Normal, "Spearow");
            PocketMonster fearow = new PocketMonster(22, Elements.Normal, "Fearow");
            PocketMonster ekans = new PocketMonster(23, Elements.Poison, "Ekans");
            PocketMonster arbok = new PocketMonster(24, Elements.Poison, "Arbok");
            PocketMonster pikachu = new PocketMonster(25, Elements.Grass, "Pikachu");

            
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while(isRunning)
            {

            // Title Screen and Instructions
            System.Console.WriteLine("\tPOCKET MONSTERS \n" +
            "This game is about aventure, monsters that fit into your pocket and defeating your arch nemesis \n" +
            "for his title of POCKET MONSTER Champion"+
            "=============================================================================================== \n" +
            "\tHOW TO PLAY:" +
            "1. Enter your name. \n" +
            "2. Select a starting POCKET MONSTER. \n" +
            "3. Navigate through the world, where you could encounter wild POCKET MONSTERS that you can collect, \n" +
            "as well as POCKET MONSTER CENTERS where you can add or trade your POCKET MONSTERS. \n" +
            "4. For reference, you have a Utility Belt that will be your monsters you can battle with and \n" +
            "you have a Backpack that you can store additional monster and trade out for one on your Utility Belt. \n" +
            "5. You may only carry THREE monsters on your Utility Belt and TEN monsters in your BackPack. \n" +
            "===================================================================================================== \n" +
            "\tBATTLE SYSTEM: \n" +
            "-Each POCKET MONSTER has an Element that defines them. Each element will defeat one element but \n" +
            "can be defeated by another. \n" +
            "i.e. Electric => Bug => Posion => Normal => Water => Fire => Grass => Electric... \n" +
            "===================================================================================================== \n");
            PressAnyKey();

            Console.Clear();
            // Enter Name
            System.Console.WriteLine("Please enter your name: \n");
            string userName = Console.ReadLine();
            System.Console.WriteLine($"Hello {userName}! \n");

            // Select starting POCKET MONSTER
            System.Console.WriteLine("Please select your starting POCKET MONSTER: \n" +
            "1. Bulbasaur \n" +
            "2. Charmander \n" +
            "3. Squirle \n");

            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                    AddPMOneToList();
                    break;
                case "2":
                    AddPMTwoToList();
                    break;
                case "3":
                    AddPMThreeToList();
                    break;
                default:
                    System.Console.WriteLine("Invalid Selection");
                    break;
            }


            }
        }
        private void AddPMOneToList()
        {

        }
        private void AddPMTwoToList()
        {

        }
        private void AddPMThreeToList()
        {

        }
        private bool CloseApplication()
        {
            Console.Clear();
            System.Console.WriteLine("Thank you for playing!!!");
            PressAnyKeyToExit();
            return false;
        }
        private void PressAnyKey()
        {
            System.Console.WriteLine("Press ANY KEY to continue...");
            Console.ReadLine();
        }
        
        private void PressAnyKeyToExit()
        {
            System.Console.WriteLine("Press ANY Key to exit the game...");
            Console.ReadLine();
        }
    }
    
