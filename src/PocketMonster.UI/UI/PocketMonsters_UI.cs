using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class PocketMonsters_UI
    {
        private readonly Backpack_Lists _lRepo = new Backpack_Lists();
        // private readonly PMCenters_Stacks _sRepo = new PMCenters_Stacks();
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
            "for his title of POCKET MONSTER Champion /n"+
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
                    System.Console.WriteLine($"Congrats! {starterPMOne} has been added to your Utility Belt!");
                    
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
                    System.Console.WriteLine($"Congrats! {starterPMTwo} has been added to your Utility Belt!");
                    
                }
                else
                {
                    System.Console.WriteLine("Failed to add that monster to your inventory.");;
                }

            }
            else if(numInput == 3)
            {
                System.Console.WriteLine("Are you sure you wanted Charmander? y/n \n");
                string selectPM = Console.ReadLine().ToLower();
                PocketMonsters starterPMThree = _dRepo.GetPMByKey(7);

                if(selectPM == "y")
                {
                    _dRepo.DeletePocketMonster(7);
                    _lRepo.AddPMToList(starterPMThree);
                    System.Console.WriteLine($"Congrats! {starterPMThree} has been added to your Utility Belt!");
                    
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


            }
        }
            //First Encounter
            private void firstEncounter()
            {
                Console.Clear();

                string choiceOne;

                System.Console.WriteLine("");

            }
        
        
        
        // private bool CloseApplication()
        // {
        //     Console.Clear();
        //     System.Console.WriteLine("Thank you for playing!!!");
        //     PressAnyKeyToExit();
        //     return false;
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
        
        // private void PressAnyKeyToExit()
        // {
        //     System.Console.WriteLine("Press ANY Key to exit the game...");
        //     Console.ReadLine();
        // }
    }
    
