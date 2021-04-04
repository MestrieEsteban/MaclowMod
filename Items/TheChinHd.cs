using Terraria.ID;
using Terraria.ModLoader;

namespace MaclowMod.Items
{
	public class TheChinHd : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TheChinHd"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Car nous aimons les bonnes vieilles blagues");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/TheChinHd");
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}