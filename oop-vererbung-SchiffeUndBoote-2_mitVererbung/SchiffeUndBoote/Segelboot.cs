namespace SchiffeUndBoote
{
	class Segelboot : Boot
	{
		private double segelflaecheInQm2;

		public Segelboot(string name, Besitzer besitzer, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, double segelflaecheInQm2)
			: base(name, besitzer, laengeInMetern, breiteInMetern, hoheInMetern, tiefgangInMetern)
		{
			this.segelflaecheInQm2 = segelflaecheInQm2;
		}
		public double SegelflaecheInQm2
		{
			get
			{
				return segelflaecheInQm2;
			}

			set
			{
				segelflaecheInQm2 = value;
			}
		}

		
	}
}
