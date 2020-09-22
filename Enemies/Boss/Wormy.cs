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
            npc.npcSlots = 1;
            npc.frameCounter = 16;
            npc.width = 18;
            npc.height = 40;
            npc.type = -1;
            npc.aiStyle = 6;
            npc.timeLeft = 800;
            npc.damage = 40;
            npc.defense = 20;
            npc.HitSound = SoundID.NPCHit14;
            npc.DeathSound = SoundID.NPCDeath13;
            npc.lifeMax = 300;
            npc.value = 3000;
            npc.friendly = false;
            npc.boss = true;
            NPC.SpawnNPC();
        }
        public void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(10) == 0)
            {
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemID.BeeGun);
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
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
