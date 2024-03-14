namespace SchiffeUndBoote
{
	class Motorboot : Boot
    {
        private double leistungInKw;

		public Motorboot(string name, Besitzer besitzer, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, double leistungInKw)
			:base(name, besitzer, laengeInMetern, breiteInMetern, hoheInMetern, tiefgangInMetern)
		{
			this.leistungInKw = leistungInKw;
		}

        public double LeistungInKw
		{
			get
			{
				return leistungInKw;
			}

			set
			{
				leistungInKw = value;
			}
		}

		
	}
}
