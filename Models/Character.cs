﻿using DataStructuresFinalProjectWebAppVang.unused;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructuresFinalProjectWebAppVang
{
    public class Character
    {
        // This class is for creating the characters so we can put it into the LinkedList/Queue
        public string Id { get; set; }
        public string Name { get; set; }
        public string Vision{ get; set; }
        public string Weapon{ get; set; }
        public string LastSeen { get; set; }
        public string Region { get; set; }
        public string ImageName { get; set; }
        public LinkedList<Character> CharacterList { get; set; }
        public Character()
        {
            this.Name = "NPC";
            this.Vision = "Visionless";
            this.Weapon = "N/A";
            this.LastSeen = "Today";
            this.Region = "Teyvat";
            this.ImageName = "NPC.png";
        }
        public Character(string name, string vision, string weapon, string lastSeen, string region)
        {
            this.Name = name;
            this.Vision = vision;
            this.Weapon = weapon;
            this.LastSeen = lastSeen;
            this.Region = region;
        }

        public Character(string name, string vision, string weapon, string lastSeen, string region, string imgname)
        {
            this.Name = name;
            this.Vision = vision;
            this.Weapon = weapon;
            this.LastSeen = lastSeen;
            this.Region = region;
            this.ImageName = imgname;
            
        }
        public void Add(Character newChar)
        {
            CharacterList.AddLast(newChar);
        }
    }
}