using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaclowMod.NPCs.Boss
{
    [AutoloadBossHead]
    class TheSteph144Hz : ModNPC
    {
        public float targetX  = 0;
        public float targetY  = 0;

        public int   vMax     = 0;
        public float vAccel   = 0;
        public float tVel     = 0;
        public float vMag     = 0;


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Steph 144Hz");
        }
        public override void SetDefaults()
        {
            vMax = 15;
            vAccel = .2f;
            npc.aiStyle = 0;  //5 is the flying AI
            npc.defense = 50;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 230;
            npc.height = 450;
            npc.lifeMax = 700000;
            npc.damage = 200;
            //animationType = NPCID.DemonEye;   //this boss will behavior like the DemonEye
            //Main.npcFrameCount[npc.type] = 1;    //boss frame/animation 
            npc.value = Item.buyPrice(0, 40, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.buffImmune[24] = true;
            npc.netAlways = true;
            npc.HitSound = SoundID.NPCHit7;
            npc.DeathSound = SoundID.NPCDeath5;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/steph");
        }
        public override void AI()
        {
            Player player = Main.player[npc.target];
            targetX = player.Center.X;
            targetY = player.Center.Y;

            float dist = Vector2.Distance(npc.Center, Main.player[npc.target].Center);
            tVel = dist / 20;
            if (vMag < vMax && vMag < tVel)
            {
                vMag += vAccel;
            }
            if (vMag > tVel)
            {
                vMag -= vAccel;
            }

            if (dist != 0)
            {
                Vector2 tPos;
                tPos.X = targetX;
                tPos.Y = targetY;
                npc.velocity = npc.DirectionTo(tPos) * vMag;
            }
        }

        public override void OnHitPlayer(Player player, int dmgDealt, bool crit)
        {

        }

        public override void BossLoot(ref string name, ref int potionType)
        {
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
        }
    }
}
