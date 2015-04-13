﻿namespace Engine
{
    using Engine.Interfaces;

    public class Location : IPersonalization , IPersonalizationExtension
    {
        //Properties
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Item ItemRequiredToEnter { get; private set; }

        public Quest QuestAvailableHere { get; set; }

        public Monster MonsterLivingHere { get; set; }

        public Location LocationToNorth { get; set; }

        public Location LocationToEast { get; set; }

        public Location LocationToSouth { get; set; }

        public Location LocationToWest { get; set; }

        //Constructor
        public Location(int id, string name, string description,
            Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.ItemRequiredToEnter = itemRequiredToEnter;
            this.QuestAvailableHere = questAvailableHere;
            this.MonsterLivingHere = monsterLivingHere;
        }
    }
}
