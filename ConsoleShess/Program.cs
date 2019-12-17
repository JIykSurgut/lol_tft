using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleShess
{
    enum Race {
        Beast = 0,
        Demon,
        Dragon,
        Dwarf,
        Elementals,
        Elf,
        Goblin,
        Human,
        Ogre,
        Orc,
        Naga,
        Troll,
        Undead,
        Satir,
        none
    };
    enum _Class {
        Assassin = 0,
        Demon_Hunter,
        Druid,
        Knight,
        Hunter,
        Mage,
        Mech,
        Shaman,
        Warlock,
        Warrior,
        none
    };

    class Hero
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public Race Race { get; set; }
        public Race Race2 { get; set; }
        public Class Class { get; set; }
        public uint Cost { get; set; }
    }

    class Block
    {
        public uint count;
        public uint lvl;

    }

    class Spec
    {
        public Spec()
        {
            Beast = new Block();
            Demon = new Block();
            Dragon = new Block();
            Dwarf = new Block();
            Elementals = new Block();
            Elf = new Block();
            Goblin = new Block();
            Human = new Block();
            Ogre = new Block();
            Orc = new Block();
            Naga = new Block();
            Troll = new Block();
            Undead = new Block();

            Assassin = new Block();
            Demon_Hunter = new Block();
            Druid = new Block();
            Knight = new Block();
            Hunter = new Block();
            Mage = new Block();
            Mech = new Block();
            Shaman = new Block();
            Warlock = new Block();
            Warrior = new Block();
            team = new string[10];
        }

        public string[] team { get; set; }
        public Block Beast { get; set; }
        public Block Demon { get; set; }
        public Block Dragon { get; set; }
        public Block Dwarf { get; set; }
        public Block Elementals { get; set; }
        public Block Elf { get; set; }
        public Block Goblin { get; set; }
        public Block Human { get; set; }
        public Block Ogre { get; set; }
        public Block Orc { get; set; }
        public Block Naga { get; set; }
        public Block Troll { get; set; }
        public Block Undead { get; set; }

        public Block Assassin { get; set; }
        public Block Demon_Hunter { get; set; }
        public Block Druid { get; set; }
        public Block Knight { get; set; }
        public Block Hunter { get; set; }
        public Block Mage { get; set; }
        public Block Mech { get; set; }
        public Block Shaman { get; set; }
        public Block Warlock { get; set; }
        public Block Warrior { get; set; }

        public uint CountLevel { get; set; }
    }
    
    partial class Program
    {
        static public Hero[] listHero =
        {
            new Hero() { Id = 0, Name = "Bounty Hunter", Race = Race.Goblin, Class = Class.Assassin, Race2 = Race.none, Cost = 1 },
            new Hero() { Id = 1, Name = "Clockwerk", Race = Race.Goblin, Class = Class.Mech, Race2 = Race.none, Cost = 1 },
            new Hero() { Id = 2, Name = "Tinker", Race = Race.Goblin, Class = Class.Mech, Race2 = Race.none, Cost = 1},
            new Hero() { Id = 3, Name = "Enchantress", Race = Race.Beast, Class = Class.Druid, Race2 = Race.none, Cost = 1},
            new Hero() { Id = 4, Name = "Tusk", Race = Race.Beast, Class = Class.Warrior, Race2 = Race.none, Cost = 1},
            new Hero() { Id = 5, Name = "Drow ranger", Race = Race.Undead, Class = Class.Hunter, Race2 = Race.none, Cost = 1},
            new Hero() { Id = 6, Name = "Ogre Magic", Race = Race.Ogre, Class = Class.Mage, Race2 = Race.none, Cost = 1},
            new Hero() { Id = 7, Name = "Axe", Race = Race.Orc, Class= Class.Warrior, Race2 = Race.none, Cost = 1},
            new Hero() { Id = 8, Name = "Shadow Shaman", Race = Race.Troll, Class = Class.Shaman, Race2 = Race.none, Cost = 1},
            new Hero() { Id = 9, Name = "Batrider", Race = Race.Troll, Class = Class.Knight, Race2 = Race.none, Cost = 1},
            new Hero() { Id = 10, Name = "Tiny", Race = Race.Elementals, Class = Class.Warrior, Race2 = Race.none, Cost = 1},
            new Hero() { Id = 11, Name = "Anti-mage", Race = Race.Elf, Class = Class.Hunter, Race2 = Race.none, Cost = 1},

            new Hero() { Id = 12, Name = "Timbersaw", Race = Race.Goblin, Class = Class.Mech, Race2 = Race.none, Cost = 2},
            new Hero() { Id = 13, Name = "Queen of Pain", Race = Race.Demon, Class = Class.Assassin, Race2 = Race.none, Cost = 2},
            new Hero() { Id = 14, Name = "Chaos Knight", Race = Race.Demon, Class = Class.Knight, Race2 = Race.none, Cost =2},
            new Hero() { Id = 15, Name = "Puck", Race = Race.Dragon, Race2 = Race.Elf, Class = Class.Mage, Cost = 2},
            new Hero() { Id = 16, Name = "Slardar", Race = Race.Naga, Race2 = Race.none, Class = Class.Warrior, Cost =2},
            new Hero() { Id = 17, Name = "Slark", Race = Race.Naga, Race2 = Race.none, Class = Class.Assassin, Cost = 2},
            new Hero() { Id = 18, Name = "Beastmaster", Race = Race.Orc, Race2 = Race.none, Class = Class.Hunter, Cost = 2},
            new Hero() { Id = 19, Name = "Juggernaut", Race = Race.Orc, Race2 =Race.none, Class = Class.Warrior, Cost = 2},
            new Hero() { Id = 20, Name = "Witch Doctor", Race = Race.Troll, Race2 = Race.none, Class = Class.Warlock, Cost = 2},
            new Hero() { Id = 21, Name = "Crystal Maiden", Race = Race.Human, Race2 = Race.none, Class = Class.Mage, Cost = 2},
            new Hero() { Id = 22, Name = "Morphling", Race = Race.Elementals, Race2 = Race.none, Class = Class.Assassin, Cost = 2},
            new Hero() { Id = 23, Name = "Treant Protection", Race = Race.Elf, Race2 = Race.none, Class = Class.Druid, Cost = 2},
            new Hero() { Id = 24, Name = "Luna", Race= Race.Elf, Race2 = Race.none, Class = Class.Knight, Cost = 2},
            new Hero() { Id = 25, Name = "Furion", Race = Race.Elf, Race2 = Race.none, Class = Class.Druid, Cost = 2},

            new Hero() { Id = 26, Name = "Sniper", Race = Race.Dwarf, Race2 = Race.none, Class = Class.Hunter, Cost = 3},
            new Hero() { Id = 27, Name = "Shadow Fiend", Race = Race.Demon, Race2 = Race.none, Class = Class.Warlock, Cost = 3},
            new Hero() { Id = 28, Name = "Terrorblade", Race= Race.Demon, Race2 = Race.none, Class = Class.Hunter, Cost = 3},
            new Hero() { Id = 29, Name = "Viper", Race=Race.Dragon, Race2 = Race.none, Class = Class.Assassin, Cost = 3},
            new Hero() { Id = 30, Name = "Lycan", Race = Race.Beast, Race2 = Race.Human, Class = Class.Warrior, Cost = 3},
            new Hero() { Id = 31, Name = "Venomancer", Race =Race.Beast, Race2 = Race.none, Class = Class.Warlock, Cost = 3},
            new Hero() { Id = 32, Name = "Sand King", Race = Race.Beast, Race2 = Race.none, Class = Class.Assassin, Cost = 3},
            new Hero() { Id = 33, Name = "Abbadon", Race = Race.Undead, Race2 = Race.none, Class = Class.Knight, Cost = 3},
            new Hero() { Id = 34, Name = "Riki", Race = Race.Satir, Race2 = Race.none, Class = Class.Assassin, Cost = 3},
            new Hero() { Id = 35, Name = "Omniknight", Race = Race.Human, Race2 = Race.none, Class = Class.Knight, Cost = 3},
            new Hero() { Id = 36, Name = "Lina", Race = Race.Human, Race2 = Race.none, Class = Class.Mage, Cost = 3},
            new Hero() { Id = 37, Name = "Razor", Race = Race.Elementals, Race2 = Race.none, Class = Class.Mage, Cost = 3},
            new Hero() { Id = 38, Name = "Windranger", Race = Race.Elf, Race2 = Race.none, Class = Class.Hunter, Cost = 3},
            new Hero() { Id = 39, Name = "Phantom Assasin", Race = Race.Elf, Race2 = Race.none, Class = Class.Assassin, Cost = 3},
            new Hero() { Id = 40, Name = "Mirana", Race = Race.Elf, Race2 = Race.none, Class = Class.Hunter, Cost = 3},

            new Hero() { Id = 41, Name = "Alchemist", Race = Race.Goblin, Race2 = Race.none, Class = Class.Warlock, Cost = 4},
            new Hero() { Id = 42, Name = "Doom", Race = Race.Demon, Race2 = Race.none, Class = Class.Warrior, Cost = 4},
            new Hero() { Id = 43, Name = "Lone Druid", Race = Race.Beast, Race2 = Race.none, Class = Class.Druid, Cost = 4},
            new Hero() { Id = 44, Name = "Medusa", Race = Race.Naga, Race2 = Race.none, Class = Class.Hunter, Cost = 4},
            new Hero() { Id = 45, Name = "Necrophos", Race = Race.Undead, Race2= Race.none, Class = Class.Warlock, Cost = 4},
            new Hero() { Id = 46, Name = "Disruptor", Race = Race.Orc, Race2 = Race.none, Class = Class.Shaman, Cost = 4},
            new Hero() { Id = 47, Name = "Troll Warlord", Race = Race.Troll, Race2 = Race.none, Class = Class.Warrior, Cost =4},
            new Hero() { Id = 48, Name = "Kunka", Race = Race.Human, Race2 = Race.none, Class = Class.Warrior, Cost = 4},
            new Hero() { Id = 49, Name = "Keeper of the light", Race = Race.Human, Race2 = Race.none, Class = Class.Mage, Cost = 4},
            new Hero() { Id = 50, Name = "Dragon knight", Race = Race.Dragon, Race2 = Race.Human, Class = Class.Knight, Cost = 4},
            new Hero() { Id = 51, Name = "Templar Assasin", Race = Race.Elf, Race2 = Race.none, Class = Class.Assassin, Cost = 4},

            new Hero() { Id = 52, Name = "Techies", Race = Race.Goblin, Race2 = Race.none, Class = Class.Mech, Cost = 5},
            new Hero() { Id = 53, Name = "Gyrocopter", Race = Race.Dwarf, Race2 = Race.none, Class = Class.Mech, Cost = 5},
            new Hero() { Id = 54, Name = "Tidehunter", Race = Race.Naga, Race2 = Race.none, Class = Class.Hunter, Cost = 5},
            new Hero() { Id = 55, Name = "Lich", Race = Race.Undead, Race2 = Race.none, Class = Class.Mage, Cost = 5},
            new Hero() { Id = 56, Name = "Death Prophet", Race = Race.Undead, Race2 = Race.none, Class = Class.Warlock, Cost = 5},
            new Hero() { Id = 57, Name = "Enigma", Race = Race.Elementals, Race2 = Race.none, Class = Class.Warlock, Cost = 5}
            
        };


        static void Calculated(int[] buf, IList<Spec> listBuf)
        {
            Spec spec = new Spec();
          
            for (int i = 0; i < buf.Length; i++)
            {
                Hero hero = listHero[buf[i]];
                spec.team[i] = hero.Name;
                switch (hero.Race)
                {
                    case Race.Beast:        spec.Beast.count += 1;      break;
                    case Race.Demon:        spec.Demon.count += 1;      break;
                    case Race.Dragon:       spec.Dragon.count += 1;     break;
                    case Race.Dwarf:        spec.Dwarf.count += 1;      break;
                    case Race.Elementals:   spec.Elementals.count += 1; break;
                    case Race.Elf:          spec.Elf.count += 1;        break;
                    case Race.Goblin:       spec.Goblin.count += 1;     break;
                    case Race.Human:        spec.Human.count += 1;      break;
                    case Race.Naga:         spec.Naga.count += 1;       break;
                    case Race.Ogre:         spec.Ogre.count += 1;       break;
                    case Race.Orc:          spec.Orc.count += 1;        break;
                    case Race.Troll:        spec.Troll.count += 1;      break;
                    case Race.Undead:       spec.Undead.count += 1;     break;
                    case Race.Satir:                                    break;
                }
                switch (hero.Class)
                {
                    case Class.Assassin: spec.Assassin.count += 1; break;
                    case Class.Demon_Hunter: spec.Demon_Hunter.count += 1; break;
                    case Class.Druid: spec.Druid.count += 1; break;
                    case Class.Hunter: spec.Hunter.count += 1; break;
                    case Class.Knight: spec.Knight.count += 1; break;
                    case Class.Mage: spec.Mage.count += 1; break;
                    case Class.Mech: spec.Mech.count += 1; break;
                    case Class.Shaman: spec.Shaman.count += 1; break;
                    case Class.Warlock: spec.Warlock.count += 1; break;
                    case Class.Warrior: spec.Warrior.count += 1; break;
                }
                if (hero.Race2 != Race.none)
                {
                    switch (hero.Race2)
                    {
                        case Race.Beast: spec.Beast.count += 1; break;
                        case Race.Demon: spec.Demon.count += 1; break;
                        case Race.Dragon: spec.Dragon.count += 1; break;
                        case Race.Dwarf: spec.Dwarf.count += 1; break;
                        case Race.Elementals: spec.Elementals.count += 1; break;
                        case Race.Elf: spec.Elf.count += 1; break;
                        case Race.Goblin: spec.Goblin.count += 1; break;
                        case Race.Human: spec.Human.count += 1; break;
                        case Race.Naga: spec.Naga.count += 1; break;
                        case Race.Ogre: spec.Ogre.count += 1; break;
                        case Race.Orc: spec.Orc.count += 1; break;
                        case Race.Troll: spec.Troll.count += 1; break;
                        case Race.Undead: spec.Undead.count += 1; break;
                    }
                }          
            }
            //Подсчет бафов
            spec.Beast.lvl = spec.Beast.count >= 6 ? 3u : spec.Beast.count >= 4 ? 2u : spec.Beast.count >= 2 ? 1u : 0;
            spec.Demon.lvl = spec.Demon.count == 1 ? 1u : 0;
            spec.Dragon.lvl = spec.Dragon.count == 3 ? 1u : 0;
            spec.Dwarf.lvl = spec.Dwarf.count;
            spec.Elementals.lvl = spec.Elementals.count >= 4 ? 2u : spec.Elementals.count >= 2 ? 1u : 0;
            spec.Elf.lvl = spec.Elf.count >= 9 ? 3u : spec.Elf.count >= 6 ? 2u : spec.Elf.count >= 3 ? 1u : 0;
            spec.Goblin.lvl = spec.Goblin.count >= 6 ? 2u : spec.Goblin.count >= 3 ? 1u : 0;
            spec.Human.lvl = spec.Human.count >= 6 ? 3u : spec.Human.count >= 4 ? 2u : spec.Human.count >= 2 ? 1u : 0;
            spec.Ogre.lvl = spec.Ogre.count;
            spec.Orc.lvl = spec.Orc.count >= 4 ? 2u : spec.Orc.count >= 2 ? 1u : 0;
            spec.Naga.lvl = spec.Naga.count >= 4 ? 2u : spec.Naga.count >= 2 ? 1u : 0;
            spec.Troll.lvl = spec.Troll.count >= 4 ? 2u : spec.Troll.count >= 2 ? 1u : 0;
            spec.Undead.lvl = spec.Undead.count >= 4 ? 2u : spec.Undead.count >= 2 ? 1u : 0;

            spec.Assassin.lvl = spec.Assassin.count >= 9 ? 3u : spec.Assassin.count >= 6 ? 2u : spec.Assassin.count >= 3 ? 1u : 0;
            spec.Demon_Hunter.lvl = spec.Demon_Hunter.count;
            spec.Druid.lvl = spec.Druid.count >= 4 ? 2u : spec.Druid.count >= 2 ? 1u : 0;
            spec.Knight.lvl = spec.Knight.count >= 6 ? 3u : spec.Knight.count >= 4 ? 2u : spec.Knight.count >= 2 ? 1u : 0;
            spec.Hunter.lvl = spec.Hunter.count >= 6 ? 2u : spec.Hunter.count >= 3 ? 1u : 0;
            spec.Mage.lvl = spec.Mage.count >= 6 ? 2u : spec.Mage.count >= 3 ? 1u : 0;
            spec.Mech.lvl = spec.Mech.count >= 4 ? 2u : spec.Mech.count >= 2 ? 1u : 0;
            spec.Shaman.lvl = spec.Shaman.count >= 2 ? 1u : 0;
            spec.Warlock.lvl = spec.Warlock.count >= 6 ? 2u : spec.Warlock.count >= 3 ? 1u : 0;
            spec.Warrior.lvl = spec.Warrior.count >= 9 ? 3u : spec.Warrior.count >= 6 ? 2u : spec.Warrior.count >= 3 ? 1u : 0;

            //отключить бафы
            spec.Ogre.lvl = 0;
            spec.Demon.lvl = 0;
            spec.Dwarf.lvl = 0;
            //
            spec.CountLevel =
                spec.Beast.lvl +
                spec.Demon.lvl +
                spec.Dragon.lvl +
                spec.Dwarf.lvl +
                spec.Elementals.lvl +
                spec.Elf.lvl +
                spec.Goblin.lvl +
                spec.Human.lvl +
                spec.Ogre.lvl +
                spec.Orc.lvl +
                spec.Naga.lvl +
                spec.Troll.lvl +
                spec.Undead.lvl +
                spec.Assassin.lvl +
                spec.Demon_Hunter.lvl +
                spec.Druid.lvl +
                spec.Knight.lvl +
                spec.Hunter.lvl +
                spec.Mage.lvl +
                spec.Mech.lvl +
                spec.Shaman.lvl +
                spec.Warlock.lvl +
                spec.Warrior.lvl;

            //if(spec.CountLevel >= 6)listBuf.Add(spec);
            int flag = 1;
            for (int i = 0; i < spec.team.Length; i++)
            {
                //if (spec.team[i] == "Beastmaster") flag++;
                //if (spec.team[i] == "Chaos Knight") flag++;
                //if (spec.team[i] == "Luna") flag++;
                //if (spec.team[i] == "Abbadon") flag++;                                            
                //if (spec.team[i] == "Omniknight") flag++;
                //if (spec.team[i] == "Dragon knight") flag++;
            }
            //listBuf.Add(spec);
            if (flag == 1 
                && spec.Assassin.lvl == 1
                ) listBuf.Add(spec);
        }

        static int k = 4 , n = 58;
        static int[] buf = new int[k];

        static void Main()
        {
            IList<Spec> listBuf = new List<Spec>();

            rec(0, 0, listBuf);

            Spec[] Total = listBuf.Where(s => s.CountLevel >= 3).ToArray();
            for(int i=0; i< Total.Length; i++)
            {
                Console.WriteLine(string.Join(",", Total[i].team));
            }
            Console.ReadKey();
        }

        static void rec(int ind, int begin, IList<Spec> listBuf)
        {
            for (int i = begin; i < n; i++)
            {
                buf[ind] = i;
                if (ind + 1 < k) rec(ind + 1, buf[ind] + 1, listBuf);
                else
                {
                    //Console.WriteLine(string.Join(",", buf));
                    Calculated(buf, listBuf);
                }
            }
        }
    }
}
