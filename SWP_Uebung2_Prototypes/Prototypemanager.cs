using System;
using System.IO;
using Microsoft.Extensions.Configuration;

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

            public void ManageMonsters()
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false);

                IConfiguration config = builder.Build();
            Monster m1 = new Monster();

            m1.hitpoints = Convert.ToInt32(config["Monster:hitpoints"]);
            m1.speed = Convert.ToInt32(config["Monster:speed"]);
            m1.fear = config["Monster:fear"];
            m1.type = Convert.ToInt32(config["Monster:SwampMonster:type"]);
            m1.attackpoints = Convert.ToInt32(config["Monster:SwampMonster:attackpoints"]);
            m1.color = config["Monster:SwampMonster:color"];

            Console.WriteLine(m1.ToString());

            Monster m2 = (Monster)m1.Clone();
            m2.type = Convert.ToInt32(config["Monster:FireMonster:type"]);
            m2.attackpoints = Convert.ToInt32(config["Monster:FireMonster:attackpoints"]);
            m2.color = config["Monster:FireMonster:color"];

            Console.WriteLine(m2.ToString());

        }
        
    }
}