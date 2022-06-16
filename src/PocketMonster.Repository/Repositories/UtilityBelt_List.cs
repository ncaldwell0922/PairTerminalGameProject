

    public class OUtilityBelt
    {
        public bool AddPMToList(PocketMonster pocketMonster)
        {

                if(pocketMonster != null)
                {
                        _listRepo.Add(pocketMonster.ID);
                        return true;
                }

                return false;
        }
    }

