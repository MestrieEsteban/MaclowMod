using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaclowMod.Items
{
    public class Steph : ModItem
    {
        public override void SetDefaults()
        {
            item.width = item.height = 16;
            item.rare = ItemRarityID.Cyan;
            item.maxStack = 99;

            item.useStyle = ItemUseStyleID.HoldingUp;
            item.useTime = item.useAnimation = 20;

            item.noMelee = true;
            item.consumable = true;
            item.autoReuse = false;

            item.UseSound = SoundID.Item43;
        }

        public override bool CanUseItem(Player player)
        {
            if (!NPC.AnyNPCs(mod.NPCType("TheSteph144Hz")))
                return true;
            return false;
        }
        public override bool UseItem(Player player)
        {
            Main.NewText("Ta fait 3 fois le tour du parking ?", 255, 60, 255);
            Main.PlaySound(SoundID.Roar, (int)player.Center.X, (int)player.Center.Y, 0);
            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y - 600, mod.NPCType("TheSteph144Hz"));
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
