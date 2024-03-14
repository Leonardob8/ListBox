namespace SchiffeUndBoote
{
	class Tankschiff : Schiff
	{
		private double ladegewichtInTonnen;

		public Tankschiff(
            string name,
            Land land,
            int laengeInMetern,
            int breiteInMetern,
            int hoheInMetern,
            int tiefgangInMetern,
            double ladegewichtInTonnen,
            int leistungInKw
			): base(name, land, laengeInMetern, breiteInMetern, hoheInMetern, tiefgangInMetern, leistungInKw)
		{
			this.ladegewichtInTonnen = ladegewichtInTonnen;
		}

		public double LadegewichtInTonnen
		{
			get
			{
				return ladegewichtInTonnen;
			}

			set
			{
				ladegewichtInTonnen = value;
			}
		}
	}
}
