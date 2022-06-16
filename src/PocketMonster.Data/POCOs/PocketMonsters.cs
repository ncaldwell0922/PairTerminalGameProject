
    public class PocketMonsters
    {
        public PocketMonsters() {}

        public PocketMonsters(int id, Elements e, string name)
        {
            ID = id;
            Element = e;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Elements Element { get; set; }
        public string Color
        {
            get
            {
                if(Element == Elements.Grass)
                {
                    return "green";
                }
                else if(Element == Elements.Fire)
                {
                    return "red";
                }
                else if(Element == Elements.Water)
                {
                    return "blue";
                }
                else if(Element == Elements.Normal)
                {
                    return "gray";
                }
                else if (Element == Elements.Poison)
                {
                    return "purple";
                }
                else if(Element == Elements.Bug)
                {
                    return "orange";
                }
                else if(Element == Elements.Electric)
                {
                    return "yellow";
                }
                else
                {
                    return "white";
                }
            }
        }
    }
