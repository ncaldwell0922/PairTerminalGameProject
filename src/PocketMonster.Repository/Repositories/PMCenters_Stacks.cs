using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class PMCenters
    {
        private readonly Stack<PocketMonsters> _stacksRepo = new Stack<PocketMonsters>();

        public bool AddPMToStack(PocketMonsters pocketMonsters)
        {
            if(pocketMonsters is null)
            {
                _stacksRepo.Push(pocketMonsters);
                return true;
            }

            return false;
        }

        // public PocketMonsters GetPocketMonsters()
        // {
        //     if(_stacksRepo.Count() > 0)
        //     {
        //         PocketMonsters pocketMonsters = _stacksRepo.Peek(PointDexitron_Dictionary);
        //         return pocketMonsters;
        //     }

        //     return null;
        // }
    }
