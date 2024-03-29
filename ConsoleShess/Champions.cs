﻿namespace ConsoleShess
{
    class Champion
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public Origin Origin { get; set; }
        public Origin Origin2 { get; set; }
        public Class Class { get; set; }
        public Class Class2 { get; set; }
        public uint Cost { get; set; }
    }

    partial class Program
    {
        static public Champion[] champions =
        {
            //Cost 1
            new Champion { Id =  0, Name="Diana",        Origin = Origin.Inferno,    Origin2 = Origin.none,  Class = Class.Assassin,    Class2 = Class.none,    Cost = 1 },
            new Champion { Id =  1, Name="Ivern",        Origin = Origin.Woodland,   Origin2 = Origin.none, Class = Class.Druid,       Class2 = Class.none,    Cost = 1 },
            new Champion { Id =  2, Name="Kog'Maw",      Origin = Origin.Poison,     Origin2 = Origin.none, Class = Class.Predator,    Class2 = Class.none,    Cost = 1 },
            new Champion { Id =  3, Name="Maokai",       Origin = Origin.Woodland,   Origin2 = Origin.none, Class = Class.Druid,       Class2 = Class.none,    Cost = 1 },
            new Champion { Id =  4, Name="Nasus",        Origin = Origin.Light,      Origin2 = Origin.none, Class = Class.Warden,      Class2 = Class.none,    Cost = 1 },
            new Champion { Id =  5, Name="Ornn",         Origin = Origin.Electric,   Origin2 = Origin.none,Class = Class.Warden,      Class2 = Class.none,    Cost = 1 },
            new Champion { Id =  6, Name="Renekton",     Origin = Origin.Desert,     Origin2 = Origin.none,Class = Class.Berserker,   Class2 = Class.none,    Cost = 1 },
            new Champion { Id =  7, Name="Taliyah",      Origin = Origin.Mountain,   Origin2 = Origin.none,Class = Class.Mage,        Class2 = Class.none,    Cost = 1 },
            new Champion { Id =  8, Name="Vayne",        Origin = Origin.Light,      Origin2 = Origin.none,Class = Class.Ranger,      Class2 = Class.none,    Cost = 1 },
            new Champion { Id =  9, Name="Vladimir",     Origin = Origin.Ocean,      Origin2 = Origin.none,Class = Class.Mage,        Class2 = Class.none,    Cost = 1 },
            new Champion { Id = 10, Name="Warwick",      Origin = Origin.Glacial,    Origin2 = Origin.none,Class = Class.Predator,    Class2 = Class.none,    Cost = 1 },
            new Champion { Id = 11, Name="Zyra",         Origin = Origin.Inferno,    Origin2 = Origin.none,Class = Class.Summoner,    Class2 = Class.none,    Cost = 1 },
            
            
            //Cost 2
            new Champion { Id = 12, Name="Braum",        Origin = Origin.Glacial,    Origin2 = Origin.none,Class = Class.Warden,      Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 13, Name="Jax",          Origin = Origin.Light,      Origin2 = Origin.none,Class = Class.Berserker,   Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 14, Name="Leblanc",      Origin = Origin.Woodland,   Origin2 = Origin.none,Class = Class.Mage,        Class2 = Class.Assassin,    Cost = 2 },
            new Champion { Id = 15, Name="Malzahar",     Origin = Origin.Shadow,     Origin2 = Origin.none,Class = Class.Summoner,    Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 16, Name="Neeko",        Origin = Origin.Woodland,   Origin2 = Origin.none,Class = Class.Druid,       Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 17, Name="Rek'Sai",      Origin = Origin.Steel,      Origin2 = Origin.none,Class = Class.Predator,    Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 18, Name="Senna",        Origin = Origin.Shadow,     Origin2 = Origin.none,Class = Class.Soulbound,   Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 19, Name="Skarner",      Origin = Origin.Crystal,    Origin2 = Origin.none,Class = Class.Predator,    Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 20, Name="Syndra",       Origin = Origin.Ocean,      Origin2 = Origin.none,Class = Class.Mage,        Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 21, Name="Thresh",       Origin = Origin.Ocean,      Origin2 = Origin.none,Class = Class.Warden,      Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 22, Name="Varus",        Origin = Origin.Inferno,    Origin2 = Origin.none,Class = Class.Ranger,      Class2 = Class.none,        Cost = 2 },
            new Champion { Id = 23, Name="Volibear",     Origin = Origin.Electric,   Origin2 = Origin.Glacial,  Class = Class.Berserker, Class2 = Class.none,      Cost = 2 },
            new Champion { Id = 24, Name="Yasuo",        Origin = Origin.Cloud,      Origin2 = Origin.none,Class = Class.Blademaster,   Class2 = Class.none,        Cost = 2 },
            
            
            //Cost 3
            new Champion { Id = 25, Name="Aatrox",   Origin = Origin.Light,     Origin2 = Origin.none,  Class = Class.Blademaster,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 26, Name="Azir",     Origin = Origin.Desert,    Origin2 = Origin.none,  Class = Class.Summoner,      Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 27, Name="Dr. Mundo",   Origin = Origin.Poison,  Origin2 = Origin.none,  Class = Class.Berserker,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 28, Name="Ezreal",   Origin = Origin.Glacial,  Origin2 = Origin.none,  Class = Class.Ranger,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 29, Name="Kindred",   Origin = Origin.Shadow,  Origin2 = Origin.Inferno,  Class = Class.Ranger,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 30, Name="Nautilus",   Origin = Origin.Ocean,  Origin2 = Origin.none,  Class = Class.Warden,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 31, Name="Nocturne",   Origin = Origin.Steel,  Origin2 = Origin.none,  Class = Class.Assassin,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 32, Name="Qiyana Cloud",   Origin = Origin.Cloud,  Origin2 = Origin.Qiyana,  Class = Class.Assassin,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 33, Name="Qiyana Inferno",   Origin = Origin.Inferno,  Origin2 = Origin.Qiyana,  Class = Class.Assassin,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 34, Name="Qiyana Mountain",   Origin = Origin.Mountain,  Origin2 = Origin.Qiyana,  Class = Class.Assassin,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 35, Name="Qiyana Ocean",   Origin = Origin.Ocean,  Origin2 = Origin.Qiyana,  Class = Class.Assassin,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 36, Name="Sion",   Origin = Origin.Shadow,  Origin2 = Origin.none,  Class = Class.Berserker,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 37, Name="Sivir",   Origin = Origin.Desert,  Origin2 = Origin.none,  Class = Class.Blademaster,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 38, Name="Soraka",   Origin = Origin.Light,  Origin2 = Origin.none,  Class = Class.Mystic,   Class2 = Class.none,  Cost = 3 },
            new Champion { Id = 39, Name="Veigar",   Origin = Origin.Shadow,  Origin2 = Origin.none,  Class = Class.Mage,   Class2 = Class.none,  Cost = 3 },
            
            //Cost 4
            new Champion { Id = 40, Name="Annie",   Origin = Origin.Inferno,  Origin2 = Origin.none,  Class = Class.Summoner,   Class2 = Class.none,  Cost = 4 },
            new Champion { Id = 41, Name="Ashe",   Origin = Origin.Crystal,  Origin2 = Origin.none,  Class = Class.Ranger,   Class2 = Class.none,  Cost = 4 },
            new Champion { Id = 42, Name="Brand",   Origin = Origin.Inferno,  Origin2 = Origin.none,  Class = Class.Mage,   Class2 = Class.none,  Cost = 4 },
            new Champion { Id = 43, Name="Janna",   Origin = Origin.Cloud,  Origin2 = Origin.none,  Class = Class.Mystic,   Class2 = Class.none,  Cost = 4 },
            new Champion { Id = 44, Name="Kha'Zix",   Origin = Origin.Desert,  Origin2 = Origin.none,  Class = Class.Assassin,   Class2 = Class.none,  Cost = 4 },
            new Champion { Id = 45, Name="Lucian",   Origin = Origin.Light,  Origin2 = Origin.none,  Class = Class.Soulbound,   Class2 = Class.none,  Cost = 4 },
            new Champion { Id = 46, Name="Malphite",   Origin = Origin.Mountain,  Origin2 = Origin.none,  Class = Class.Warden,   Class2 = Class.none,  Cost = 4 },
            new Champion { Id = 47, Name="Olaf",   Origin = Origin.Glacial,  Origin2 = Origin.none,  Class = Class.Berserker,   Class2 = Class.none,  Cost = 4 },
            new Champion { Id = 48, Name="Twitch",   Origin = Origin.Poison,  Origin2 = Origin.none,  Class = Class.Ranger,   Class2 = Class.none,  Cost = 4 },
            new Champion { Id = 49, Name="Yorick",   Origin = Origin.Light,  Origin2 = Origin.none,  Class = Class.Summoner,   Class2 = Class.none,  Cost = 4 },
            
            //Cost 5
            new Champion { Id = 50, Name="Amumu",   Origin = Origin.Inferno,  Origin2 = Origin.none,  Class = Class.Warden,   Class2 = Class.none,  Cost = 5 },
            new Champion { Id = 51, Name="Master Yi",   Origin = Origin.Shadow,  Origin2 = Origin.none,  Class = Class.Mystic,   Class2 = Class.Blademaster,  Cost = 5 },
            new Champion { Id = 52, Name="Nami",   Origin = Origin.Ocean,  Origin2 = Origin.none,  Class = Class.Mystic,   Class2 = Class.none,  Cost = 5 },
            new Champion { Id = 53, Name="Singed",   Origin = Origin.Poison,  Origin2 = Origin.none,  Class = Class.Alchemist,   Class2 = Class.none,  Cost = 5 },
            new Champion { Id = 54, Name="Taric",   Origin = Origin.Crystal,  Origin2 = Origin.none,  Class = Class.Warden,   Class2 = Class.none,  Cost = 5 },
            new Champion { Id = 55, Name="Zed",   Origin = Origin.Electric,  Origin2 = Origin.none,  Class = Class.Summoner,   Class2 = Class.Assassin,  Cost = 5 },
            
        };

    }
}
