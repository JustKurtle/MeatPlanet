using Terraria.ModLoader;

namespace MeatPlanet
{
	class MeatPlanet : Mod
	{
		public MeatPlanet()
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
