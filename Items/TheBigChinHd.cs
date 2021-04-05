using Terraria.ID;
using Terraria.ModLoader;

namespace MaclowMod.Items
{
	public class TheBigChinHd : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TheChinHd"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Car nous aimons les bonnes vieilles blagues");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/TheChinHd").WithVolume(.7f).WithPitchVariance(.5f);
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Worm, 1);
			recipe.AddIngredient(ItemID.GoldWorm, 1);
			recipe.AddIngredient(ItemID.TruffleWorm, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}