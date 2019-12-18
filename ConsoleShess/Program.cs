using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleShess
{
 
    class Block
    {
        public uint count;
        public uint lvl;

    }

    class Spec
    {      
        public Block Cloud = new Block();
        public Block Crystal = new Block();
        public Block Desert = new Block();
        public Block Electric = new Block();
        public Block Glacial = new Block();
        public Block Inferno = new Block();
        public Block Light = new Block();
        public Block Mountain = new Block();
        public Block Ocean = new Block();
        public Block Poison = new Block();
        public Block Shadow = new Block();
        public Block Steel = new Block();
        public Block Variable = new Block();
        public Block Woodland = new Block();

        public Block Alchemist = new Block();
        public Block Assassin = new Block();
        public Block Avatar = new Block();
        public Block Berserker = new Block();
        public Block Blademaster = new Block();
        public Block Druid = new Block();
        public Block Mage = new Block();
        public Block Mystic = new Block();
        public Block Predator = new Block();
        public Block Ranger = new Block();
        public Block Soulbound = new Block();
        public Block Summoner = new Block();
        public Block Warden = new Block();
        public Block Qiyana = new Block();

        public string[] team = new string[10];      
        public uint CountLevel { get; set; }
    }
    
    partial class Program
    {
 
        static void Calculated(int[] buf, IList<Spec> listBuf)
        {
            Spec spec = new Spec();
          
            for (int i = 0; i < buf.Length; i++)
            {
                Champion champion = champions[buf[i]];
                spec.team[i] = champion.Name;

                Origin origin = champion.Origin;
                Class _class = champion.Class;
                for (int iter = 0; iter < 2; iter++)
                {
                    switch (origin)
                    {
                        case Origin.Cloud: spec.Cloud.count += 1; break;
                        case Origin.Crystal: spec.Crystal.count += 1; break;
                        case Origin.Desert: spec.Desert.count += 1; break;
                        case Origin.Electric: spec.Electric.count += 1; break;
                        case Origin.Glacial: spec.Glacial.count += 1; break;
                        case Origin.Inferno: spec.Inferno.count += 1; break;
                        case Origin.Light: spec.Light.count += 1; break;
                        case Origin.Mountain: spec.Mountain.count += 1; break;
                        case Origin.Ocean: spec.Ocean.count += 1; break;
                        case Origin.Poison: spec.Poison.count += 1; break;
                        case Origin.Shadow: spec.Shadow.count += 1; break;
                        case Origin.Steel: spec.Steel.count += 1; break;
                        case Origin.Variable: spec.Variable.count += 1; break;
                        case Origin.Woodland: spec.Woodland.count += 1; break;
                        case Origin.Qiyana: spec.Qiyana.count += 1; break;
                    }
                    switch (_class)
                    {
                        case Class.Alchemist: spec.Alchemist.count += 1; break;
                        case Class.Assassin: spec.Assassin.count += 1; break;
                        case Class.Avatar: spec.Avatar.count += 1; break;
                        case Class.Berserker: spec.Berserker.count += 1; break;
                        case Class.Blademaster: spec.Blademaster.count += 1; break;
                        case Class.Druid: spec.Druid.count += 1; break;
                        case Class.Mage: spec.Mage.count += 1; break;
                        case Class.Mystic: spec.Mystic.count += 1; break;
                        case Class.Predator: spec.Predator.count += 1; break;
                        case Class.Ranger: spec.Ranger.count += 1; break;
                        case Class.Soulbound: spec.Soulbound.count += 1; break;
                        case Class.Summoner: spec.Summoner.count += 1; break;
                        case Class.Warden: spec.Warden.count += 1; break;
                    }
                    origin = champion.Origin2;
                    _class = champion.Class2;
                }             
            }
            if (spec.Qiyana.count > 1) return;

            //Подсчет бафов
            spec.Cloud.lvl = spec.Cloud.count >= 4 ? 3u : spec.Cloud.count == 3 ? 2u : spec.Cloud.count == 2 ? 1u : 0;
            spec.Crystal.lvl = spec.Crystal.count >= 4 ? 2u : spec.Crystal.count >= 2 ? 1u : 0;
            spec.Desert.lvl = spec.Desert.count >= 4 ? 2u : spec.Desert.count >= 2 ? 1u : 0;
            spec.Electric.lvl = spec.Electric.count >= 4 ? 3u : spec.Electric.count == 3 ? 2u : spec.Electric.count == 2 ? 1u : 0;
            spec.Glacial.lvl = spec.Glacial.count >= 6 ? 3u : spec.Glacial.count >= 4 ? 2u : spec.Glacial.count >= 2 ? 1u : 0;
            spec.Inferno.lvl = spec.Inferno.count >= 9 ? 3u : spec.Inferno.count >= 6 ? 2u : spec.Inferno.count >= 3 ? 1u : 0;
            spec.Light.lvl = spec.Light.count >= 9 ? 3u : spec.Light.count >= 6 ? 2u : spec.Light.count >= 3 ? 1u : 0;
            spec.Mountain.lvl = spec.Mountain.count >= 2 ? 1u : 0;
            spec.Ocean.lvl = spec.Ocean.count >= 6 ? 3u : spec.Ocean.count >= 4 ? 2u : spec.Ocean.count >= 2 ? 1u : 0;
            spec.Poison.lvl = spec.Poison.count >= 3 ? 1u : 0;
            spec.Shadow.lvl = spec.Shadow.count >= 6 ? 2u : spec.Shadow.count >= 3 ? 1u : 0;
            spec.Steel.lvl = spec.Steel.count >= 4 ? 3u : spec.Steel.count == 3 ? 2u : spec.Steel.count == 2 ? 1u : 0;
            spec.Woodland.lvl = spec.Woodland.count >= 3 ? 1u : 0;          

            spec.Alchemist.lvl = spec.Alchemist.count >= 1 ? 1u : 0;
            spec.Assassin.lvl = spec.Assassin.count >= 6 ? 2u : spec.Assassin.count >= 3 ? 1u : 0;
            spec.Avatar.lvl = spec.Avatar.count >= 1 ? 1u : 0;
            spec.Berserker.lvl = spec.Berserker.count >= 6 ? 2u : spec.Berserker.count >= 3 ? 1u : 0;
            spec.Druid.lvl = spec.Druid.count >= 2 ? 1u : 0;
            spec.Mage.lvl = spec.Mage.count >= 6 ? 2u : spec.Mage.count >= 3 ? 1u : 0;
            spec.Mystic.lvl = spec.Mystic.count >= 4 ? 2u : spec.Mystic.count >= 2 ? 1u : 0;
            spec.Predator.lvl = spec.Predator.count >= 3 ? 1u : 0;
            spec.Ranger.lvl = spec.Ranger.count >= 6 ? 3u : spec.Ranger.count >= 4 ? 2u : spec.Ranger.count >= 2 ? 1u : 0;
            spec.Soulbound.lvl = spec.Soulbound.count >= 2 ? 1u : 0;
            spec.Summoner.lvl = spec.Summoner.count >= 6 ? 2u : spec.Summoner.count >= 3 ? 1u : 0;
            spec.Warden.lvl = spec.Warden.count >= 6 ? 3u : spec.Warden.count >= 4 ? 2u : spec.Warden.count >= 2 ? 1u : 0;


            //отключить бафы
            //spec.Ogre.lvl = 0;
            //spec.Demon.lvl = 0;
            //spec.Dwarf.lvl = 0;
            //
            spec.CountLevel =
                spec.Cloud.lvl +
                spec.Crystal.lvl +
                spec.Desert.lvl +
                spec.Electric.lvl +
                spec.Glacial.lvl +
                spec.Inferno.lvl +
                spec.Light.lvl +
                spec.Mountain.lvl +
                spec.Ocean.lvl +
                spec.Poison.lvl +
                spec.Shadow.lvl +
                spec.Steel.lvl +
                spec.Woodland.lvl +
                //spec.Alchemist.lvl +
                spec.Assassin.lvl +
                spec.Avatar.lvl +
                spec.Berserker.lvl +
                spec.Druid.lvl +
                spec.Mage.lvl +
                spec.Mystic.lvl +
                spec.Predator.lvl +
                spec.Ranger.lvl +
                spec.Soulbound.lvl +
                spec.Summoner.lvl +
                spec.Warden.lvl;

            
            //if(spec.CountLevel >=8)
           
            //listBuf.Add(spec);
            //if(spec.CountLevel >= 5 && spec.Electric.lvl >=1 && spec.Warden.lvl >= 1 && spec.Glacial.lvl >= 1) listBuf.Add(spec);
            if (spec.CountLevel >= 6) listBuf.Add(spec);
            //int flag = 1;
            //for (int i = 0; i < spec.team.Length; i++)
            //{
            //    //if (spec.team[i] == "Beastmaster") flag++;
            //    //if (spec.team[i] == "Chaos Knight") flag++;
            //    //if (spec.team[i] == "Luna") flag++;
            //    //if (spec.team[i] == "Abbadon") flag++;                                            
            //    //if (spec.team[i] == "Omniknight") flag++;
            //    //if (spec.team[i] == "Dragon knight") flag++;
            //}
            ////listBuf.Add(spec);
            //if (flag == 1 
            //    && spec.Assassin.lvl == 1
            //    ) listBuf.Add(spec);
        }
        
        

        static void Main()
        {
            IList<Spec> listBuf = new List<Spec>();

            rec(0, 0, listBuf);

            Spec[] Total = listBuf.Where(s => s.CountLevel >= 2).ToArray();
            for(int i=0; i< Total.Length; i++)
            {
                Console.WriteLine(string.Join(",", Total[i].team) + Total[i].CountLevel);
            }
            Console.WriteLine("----------");
            Console.ReadKey();
        }

        static int k = 7, //позиций
            n = 40; //кол-во элементов
        static int[] buf = new int[k];
        static void rec(int ind, int begin, IList<Spec> listBuf)
        {
            //n = listBuf.Count;
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
