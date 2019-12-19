using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

        public uint ClearSinergy { get; set; }

        public void Clear()
        {
            Cloud.count = 0; Cloud.lvl = 0;
            Crystal.count = 0; Crystal.lvl = 0;
            Desert.count = 0; Desert.lvl = 0;
            Electric.count = 0; Electric.lvl = 0;
            Glacial.count = 0; Glacial.lvl = 0;
            Inferno.count = 0; Inferno.lvl = 0;
            Light.count = 0; Light.lvl = 0;
            Mountain.count = 0; Mountain.lvl = 0;
            Ocean.count = 0; Ocean.lvl = 0;
            Poison.count = 0; Poison.lvl = 0;
            Shadow.count = 0; Shadow.lvl = 0;
            Steel.count = 0; Steel.lvl = 0;
            Variable.count = 0; Variable.lvl = 0;
            Woodland.count = 0; Woodland.lvl = 0;

            Alchemist.count = 0; Alchemist.lvl = 0;
            Assassin.count = 0; Assassin.lvl = 0;
            Avatar.count = 0; Avatar.lvl = 0;
            Berserker.count = 0; Berserker.lvl = 0;
            Blademaster.count = 0; Blademaster.lvl = 0;
            Druid.count = 0; Druid.lvl = 0;
            Mage.count = 0; Mage.lvl = 0;
            Mystic.count = 0; Mystic.lvl = 0;
            Predator.count = 0; Predator.lvl = 0;
            Ranger.count = 0; Ranger.lvl = 0;
            Soulbound.count = 0; Soulbound.lvl = 0;
            Summoner.count = 0; Summoner.lvl = 0;
            Warden.count = 0; Warden.lvl = 0;
            Qiyana.count = 0; Qiyana.lvl = 0;

            CountLevel = 0;
            ClearSinergy = 0;
            team = new string[10];
        }
    }
    
    partial class Program
    {
 
        static void Calculated(int[] buf, Spec spec)
        {
            //spec.Cloud.count = 0; spec.Cloud.lvl = 0;
            //spec.Crystal.count = 0; spec.Crystal.lvl = 0;
            //spec.Desert.count = 0; spec.Desert.lvl = 0;
            //spec.Electric.count = 0; spec.Electric.lvl = 0;
            //spec.Glacial.count = 0; spec.Glacial.lvl = 0;
            //spec.Inferno.count = 0; spec.Inferno.lvl = 0;
            //spec.Light.count = 0; spec.Light.lvl = 0;
            //spec.Mountain.count = 0; spec.Mountain.lvl = 0;
            //spec.Ocean.count = 0; spec.Ocean.lvl = 0;
            //spec.Poison.count = 0; spec.Poison.lvl = 0;
            //spec.Shadow.count = 0; spec.Shadow.lvl = 0;
            //spec.Steel.count = 0; spec.Steel.lvl = 0;
            //spec.Variable.count = 0; spec.Variable.lvl = 0;
            //spec.Woodland.count = 0; spec.Woodland.lvl = 0;

            //spec.Alchemist.count = 0; spec.Alchemist.lvl = 0;
            //spec.Assassin.count = 0; spec.Assassin.lvl = 0;
            //spec.Avatar.count = 0; spec.Avatar.lvl = 0;
            //spec.Berserker.count = 0; spec.Berserker.lvl = 0;
            //spec.Blademaster.count = 0; spec.Blademaster.lvl = 0;
            //spec.Druid.count = 0; spec.Druid.lvl = 0;
            //spec.Mage.count = 0; spec.Mage.lvl = 0;
            //spec.Mystic.count = 0; spec.Mystic.lvl = 0;
            //spec.Predator.count = 0; spec.Predator.lvl = 0;
            //spec.Ranger.count = 0; spec.Ranger.lvl = 0;
            //spec.Soulbound.count = 0; spec.Soulbound.lvl = 0;
            //spec.Summoner.count = 0; spec.Summoner.lvl = 0;
            //spec.Warden.count = 0; spec.Warden.lvl = 0;
            //spec.Qiyana.count = 0; spec.Qiyana.lvl = 0;

            //spec.CountLevel = 0;
            //spec.ClearSinergy = 0;

            spec.Clear();
            //spec = new Spec();
            for (int i = 0; i < buf.Length; i++)
            {
                Champion champion = champions[buf[i]];
                spec.team[i] = champion.Name;
               
                switch (champion.Origin)
                {
                    case Origin.Light: spec.Light.count++; break;       //7
                    case Origin.Inferno: spec.Inferno.count++; break;   //7 + 1
                    case Origin.Shadow: spec.Shadow.count++; break;     //6
                    case Origin.Ocean: spec.Ocean.count++; break;       //5 + 1
                    case Origin.Glacial: spec.Glacial.count++; break;   //5
                    case Origin.Desert: spec.Desert.count++; break;     //4
                    case Origin.Poison: spec.Poison.count++; break;     //4
                    case Origin.Woodland: spec.Woodland.count++; break; //4                    
                    case Origin.Crystal: spec.Crystal.count++; break;   //3                       
                    case Origin.Electric: spec.Electric.count++; break; //3
                    case Origin.Cloud: spec.Cloud.count++; break;       //2 + 1
                    case Origin.Mountain: spec.Mountain.count++; break; //2 + 1                                                                     
                    case Origin.Steel: spec.Steel.count++; break;       //2
                    case Origin.Variable: spec.Variable.count++; break; //2                                               
                }
                switch (champion.Origin2)
                {
                    case Origin.none: break;
                    case Origin.Glacial: spec.Glacial.count++; break;
                    case Origin.Inferno: spec.Inferno.count++; break;
                    case Origin.Qiyana: spec.Qiyana.count++; break;     
                }

                switch (champion.Class)
                {
                    case Class.Alchemist: spec.Alchemist.count++; break;
                    case Class.Assassin: spec.Assassin.count++; break;
                    case Class.Avatar: spec.Avatar.count++; break;
                    case Class.Berserker: spec.Berserker.count++; break;
                    case Class.Blademaster: spec.Blademaster.count++; break;
                    case Class.Druid: spec.Druid.count++; break;
                    case Class.Mage: spec.Mage.count++; break;
                    case Class.Mystic: spec.Mystic.count++; break;
                    case Class.Predator: spec.Predator.count++; break;
                    case Class.Ranger: spec.Ranger.count++; break;
                    case Class.Soulbound: spec.Soulbound.count++; break;
                    case Class.Summoner: spec.Summoner.count++; break;
                    case Class.Warden: spec.Warden.count++; break;
                }
                switch (champion.Class2)
                {
                    case Class.none: break;
                    case Class.Assassin: spec.Assassin.count++; break;
                    case Class.Blademaster: spec.Blademaster.count++; break;
                }              
            }
            if (spec.Qiyana.count > 1) return;

            //Подсчет бафов
            spec.Cloud.lvl = spec.Cloud.count > 1 ? spec.Cloud.count > 2 ? spec.Cloud.count > 3 ? 3u :2u :1u :0;
            spec.Crystal.lvl = spec.Crystal.count > 1 ? spec.Crystal.count > 3 ? 2u :1u :0;
            spec.Desert.lvl = spec.Desert.count > 1 ? spec.Desert.count > 3 ? 2u :1u :0;
            spec.Electric.lvl = spec.Electric.count > 1 ? spec.Electric.count > 2 ? spec.Electric.count > 3 ? 3u :2u :1u :0;
            spec.Glacial.lvl = spec.Glacial.count > 1 ? spec.Glacial.count > 3 ? spec.Glacial.count > 5 ? 3u :2u :1u :0;
            spec.Inferno.lvl = spec.Inferno.count > 2 ? spec.Inferno.count > 5 ? spec.Inferno.count > 8 ? 3u :2u :1u :0;
            spec.Light.lvl = spec.Light.count > 2 ? spec.Light.count > 5 ? spec.Light.count > 8 ? 3u :2u :1u :0;
            spec.Mountain.lvl = spec.Mountain.count > 1 ? 1u :0;
            spec.Ocean.lvl = spec.Ocean.count > 1 ? spec.Ocean.count > 3 ? spec.Ocean.count > 5 ? 3u :2u :1u :0;
            spec.Poison.lvl = spec.Poison.count > 2 ? 1u :0;
            spec.Shadow.lvl = spec.Shadow.count > 2 ? spec.Shadow.count > 5 ? 2u :1u :0;
            spec.Steel.lvl = spec.Steel.count > 1 ? spec.Steel.count > 2 ? spec.Steel.count > 3 ? 3u :2u :1u :0;
            spec.Woodland.lvl = spec.Woodland.count > 2 ? 1u :0;

            spec.Assassin.lvl = spec.Assassin.count > 2 ? spec.Assassin.count > 5 ? 2u :1u :0;
            spec.Berserker.lvl = spec.Berserker.count > 2 ? spec.Berserker.count > 5 ? 2u :1u :0;
            spec.Blademaster.lvl = spec.Blademaster.count > 1 ? spec.Blademaster.count > 3 ? spec.Blademaster.count > 5 ? 3u :2u :1u :0;
            spec.Druid.lvl = spec.Druid.count > 1 ? 1u :0;
            spec.Mage.lvl = spec.Mage.count > 2 ? spec.Mage.count > 5 ? 2u :1u :0;
            spec.Mystic.lvl = spec.Mystic.count > 1 ? spec.Mystic.count > 3 ? 2u :1u :0;
            spec.Predator.lvl = spec.Predator.count > 2 ? 1u : 0;
            spec.Ranger.lvl = spec.Ranger.count > 1 ? spec.Ranger.count > 3 ? spec.Ranger.count > 5 ? 3u :2u :1u :0;          
            spec.Soulbound.lvl = spec.Soulbound.count > 1 ? 1u :0;
            spec.Summoner.lvl = spec.Summoner.count > 2 ? spec.Summoner.count > 5 ? 2u :1u :0;
            spec.Warden.lvl = spec.Warden.count > 1 ? spec.Warden.count > 3 ? spec.Warden.count > 5 ? 3u :2u :1u :0;

            uint[] arr_20 = { 2, 0 };
            uint[] arr_4320 = { 4, 3, 2, 0 };
            uint[] arr_420 = { 4, 2, 0 };
            uint[] arr_6420 = { 6, 4, 2, 0 };
            uint[] arr_9630 = { 9, 6, 3, 0 };
            if (!arr_4320.Contains(spec.Cloud.count)) spec.ClearSinergy++;
            if (!arr_420.Contains(spec.Crystal.count)) spec.ClearSinergy++;
            if (!arr_420.Contains(spec.Desert.count)) spec.ClearSinergy++;
            if (!arr_4320.Contains(spec.Electric.count)) spec.ClearSinergy++;
            if (!arr_6420.Contains(spec.Glacial.count)) spec.ClearSinergy++;
            if (!arr_9630.Contains(spec.Inferno.count)) spec.ClearSinergy++;
            if (!arr_9630.Contains(spec.Light.count)) spec.ClearSinergy++;
            if (!arr_420.Contains(spec.Mountain.count)) spec.ClearSinergy++;
            if (!arr_6420.Contains(spec.Ocean.count)) spec.ClearSinergy++;
            if (!arr_9630.Contains(spec.Poison.count)) spec.ClearSinergy++;
            if (!arr_9630.Contains(spec.Shadow.count)) spec.ClearSinergy++;
            if (!arr_4320.Contains(spec.Steel.count)) spec.ClearSinergy++;
            if (!arr_9630.Contains(spec.Woodland.count)) spec.ClearSinergy++;

            if (!arr_9630.Contains(spec.Assassin.count)) spec.ClearSinergy++;
            if (!arr_9630.Contains(spec.Berserker.count)) spec.ClearSinergy++;
            if (!arr_6420.Contains(spec.Blademaster.count)) spec.ClearSinergy++;
            if (!arr_20.Contains(spec.Druid.count)) spec.ClearSinergy++;
            if (!arr_9630.Contains(spec.Mage.count)) spec.ClearSinergy++;
            if (!arr_6420.Contains(spec.Mystic.count)) spec.ClearSinergy++;
            if (!arr_9630.Contains(spec.Predator.count)) spec.ClearSinergy++;
            if (!arr_6420.Contains(spec.Ranger.count)) spec.ClearSinergy++;
            if (!arr_6420.Contains(spec.Soulbound.count)) spec.ClearSinergy++;
            if (!arr_9630.Contains(spec.Summoner.count)) spec.ClearSinergy++;
            if (!arr_6420.Contains(spec.Warden.count)) spec.ClearSinergy++;

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
                spec.Assassin.lvl +
                spec.Berserker.lvl +
                spec.Druid.lvl +
                spec.Mage.lvl +
                spec.Mystic.lvl +
                spec.Predator.lvl +
                spec.Ranger.lvl +
                spec.Soulbound.lvl +
                spec.Summoner.lvl +
                spec.Warden.lvl;

            if (spec.CountLevel >= 1 && spec.ClearSinergy == 0) Console.WriteLine(string.Join(",", spec.team) + spec.CountLevel);
        }
        
        
        static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
        
            rec(0, 0);
            
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine("----------");
            Console.WriteLine("RunTime {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.ReadKey();
        }

        static int k = 7, //позиций
            n = 56; //кол-во элементов
        static int[] buf = new int[k];
        static void rec(int ind, int begin)
        {
            Spec spec = new Spec();
            for (int i = begin; i < n; i++)
            {
                buf[ind] = i;
                if (ind + 1 < k) rec(ind + 1, buf[ind] + 1);
                else
                {
                    Calculated(buf, spec);
                }
            }
        }
    }
}
