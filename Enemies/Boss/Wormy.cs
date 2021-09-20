using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Gecko.Enemies.Boss
{
    public class Wormy : ModNPC
    {
        public void NPCData()
        {
            NPC.npcSlots = 1;
            NPC.frameCounter = 16;
            NPC.width = 18;
            NPC.height = 40;
            NPC.type = -1;
            NPC.aiStyle = 6;
            NPC.timeLeft = 800;
            NPC.damage = 40;
            NPC.defense = 20;
            NPC.HitSound = SoundID.NPCHit14;
            NPC.DeathSound = SoundID.NPCDeath13;
            NPC.lifeMax = 300;
            NPC.value = 3000;
            NPC.friendly = false;
            NPC.boss = true;
            NPC.SpawnNPC();
        }
        public static void NPCLoot(NPC NPC)
        {
            if (Main.rand.Next(10) == 0)
            {
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemID.BeeGun);
                int choice = dropChooser;
                Item.NewItem(NPC.getRect(), choice);
            }
        }   
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedBoss2 && !Main.dayTime)
                return base.SpawnChance(spawnInfo);
            else return 0;
        }
    }
}
