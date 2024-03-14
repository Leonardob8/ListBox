namespace SchiffeUndBoote
{
	class Containerschiff : Schiff
    {
        private int anzahlContainer;

		public Containerschiff(
            string name,
            Land land,
            int laengeInMetern,
            int breiteInMetern,
            int hoheInMetern,
            int tiefgangInMetern,
            int anzahlContainer,
            int leistungInKw
			):base(name, land, laengeInMetern,breiteInMetern, hoheInMetern, tiefgangInMetern, leistungInKw)
		{
			this.anzahlContainer = anzahlContainer;
		}

        public int AnzahlContainer
		{
			get
			{
				return anzahlContainer;
			}

			set
			{
				anzahlContainer = value;
			}
		}
    }
}
