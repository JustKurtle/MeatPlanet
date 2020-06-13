using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Materials
{
	public class Skin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skin");
		}
		public override void SetDefaults()
        {
            item.width = 36;
            item.height = 34;
            item.value = 0;
            item.rare = 0;
            item.maxStack = 1;
        }
	}
}
