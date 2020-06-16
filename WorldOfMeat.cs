using Terraria.ModLoader;

namespace WorldOfMeat
{
	class WorldOfMeat : Mod
	{
		public WorldOfMeat()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
