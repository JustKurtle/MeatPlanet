using Terraria.ModLoader;

namespace WOM
{
	class WOM : Mod
	{
		public WOM()
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
