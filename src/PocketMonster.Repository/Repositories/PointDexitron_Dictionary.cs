using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class PointDexitron_Dictionary
    {
        private readonly Dictionary<int, PocketMonsters> _dictionaryRepo = new Dictionary<int, PocketMonsters>();

        private int _count = 0;

        public bool AddPMToDictionary(PocketMonsters pocketMonsters)
        {
            if(pocketMonsters is null)
            {
                return false;
            }

            _count++;
            pocketMonsters.ID = _count;
            _dictionaryRepo.Add(pocketMonsters.ID, pocketMonsters);

            return true;
        }

        public Dictionary<int, PocketMonsters> GetMonster()
        {
            return _dictionaryRepo;
        }

        public PocketMonsters GetPMByKey(int keyInput)
        {
            foreach(KeyValuePair<int, PocketMonsters> pocketMonsters in _dictionaryRepo)
            {
                if(pocketMonsters.Key == keyInput)
                {
                    return pocketMonsters.Value;
                }
            }

            return null;
        }

        public bool UpdatePMData(int keyInput, PocketMonsters newPMData)
        {
            var oldPMData = GetPMByKey(keyInput);

            if(oldPMData is null)
            {
                return false;
            }

            oldPMData.ID = newPMData.ID;
            oldPMData.Element = newPMData.Element;
            oldPMData.Name = newPMData.Name;
            return true;
        }

        public bool DeletePocketMonster(int keyInput)
        {
            var oldPM = GetPMByKey(keyInput);

            if(oldPM is null)
            {
                return false;
            }

            _dictionaryRepo.Remove(oldPM.ID);
            return true;
        }

    }
