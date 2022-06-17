

    public class Backpack_Lists
    {
        private readonly List<PocketMonsters> _listRepo = new List<PocketMonsters>();
        public bool AddPMToList(PocketMonsters pocketMonster)
        {

                if(pocketMonster != null)
                {
                        _listRepo.Add(pocketMonster);
                        return true;
                }

                return false;
        }

        public List<PocketMonsters> GetAllBeltMonsters()
        {
            return _listRepo;
        }
    }

