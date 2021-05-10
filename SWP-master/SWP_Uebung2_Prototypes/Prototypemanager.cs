using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;


namespace SWP_Uebung2_Prototypes
{
    public sealed class Prototypemanager
    {
        private static Prototypemanager instance = null;

        public static Prototypemanager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Prototypemanager();
                }

                return instance;
            }
        }

        //public void ManageMonsters()
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json", optional: false);

        //    IConfiguration config = builder.Build();
        //    Monster m1 = new Monster();

        //    m1.hitpoints = Convert.ToInt32(config["Monster:hitpoints"]);
        //    m1.speed = Convert.ToInt32(config["Monster:speed"]);
        //    m1.fear = config["Monster:fear"];
        //    m1.type = Convert.ToInt32(config["Monster:SwampMonster:type"]);
        //    m1.attackpoints = Convert.ToInt32(config["Monster:SwampMonster:attackpoints"]);
        //    m1.color = config["Monster:SwampMonster:color"];

        //    Console.WriteLine(m1.ToString());

        //    Monster m2 =  m1.Clone() as Monster;
        //    m2.type = Convert.ToInt32(config["Monster:FireMonster:type"]);
        //    m2.attackpoints = Convert.ToInt32(config["Monster:FireMonster:attackpoints"]);
        //    m2.color = config["Monster:FireMonster:color"];

        //    Console.WriteLine(m2.ToString());
        //}


        public void ManageMonsters()
        {
            StreamReader r = new StreamReader("monster.json");
            string json = r.ReadToEnd();
            List<Monster> monsters = JsonConvert.DeserializeObject<List<Monster>>(json);
             r.Close();

             Monster m1 = monsters[0];

             Monster m2 = m1.Clone() as Monster;
             m2.name = monsters[1].name;
             m2.hitpoints = monsters[1].hitpoints;
             m2.color = monsters[1].color;
             m2.fear = monsters[1].fear;
             m2.type = monsters[1].type;

             Monster m3 = m1.Clone() as Monster;
             m3.name = monsters[2].name;
             m3.hitpoints = monsters[2].hitpoints;
             m3.color = monsters[2].color;
             m3.fear = monsters[2].fear;
             m3.type = monsters[2].type;

             Monster m4 = m1.Clone() as Monster;
             m4.name = monsters[3].name;
             m4.hitpoints = monsters[3].hitpoints;
             m4.color = monsters[3].color;
             m4.fear = monsters[3].fear;
             m4.type = monsters[3].type;

             Console.WriteLine(m1.ToString());
             Console.WriteLine(m2.ToString());
             Console.WriteLine(m3.ToString());
             Console.WriteLine(m4.ToString());

            StreamReader reader = new StreamReader("sword.json");
             string jsonReader = reader.ReadToEnd();
             List<Sword> swords = JsonConvert.DeserializeObject<List<Sword>>(jsonReader);
             reader.Close();

             Sword s1 = swords[0];

             Sword s2= s1.Clone() as Sword;
             s2.name = swords[1].name;
             s2.damage = swords[1].damage;
             s2.defense = swords[1].defense;
             s2.magic = swords[1].magic;

             Sword s3= s1.Clone() as Sword;
             s3.name = swords[2].name;
             s3.damage = swords[2].damage;
             s3.defense = swords[2].defense;
             s3.magic = swords[2].magic;

             Sword s4 = s1.Clone() as Sword;
             s4.name = swords[3].name;
             s4.damage = swords[3].damage;
             s4.defense = swords[3].defense;
             s4.magic = swords[3].magic;

             Sword s5 = s1.Clone() as Sword;
             s5.name = swords[4].name;
             s5.damage = swords[4].damage;
             s5.defense = swords[4].defense;
             s5.magic = swords[4].magic;

             Console.WriteLine(s1.ToString());
             Console.WriteLine(s2.ToString());
             Console.WriteLine(s3.ToString());
             Console.WriteLine(s4.ToString());
             Console.WriteLine(s5.ToString());

        }
    }
}