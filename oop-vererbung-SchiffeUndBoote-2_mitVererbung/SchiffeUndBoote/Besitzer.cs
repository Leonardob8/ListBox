namespace SchiffeUndBoote
{
	class Besitzer
	{
		private string vorname;
		private string nachname;
		private string strasse;
		private string hausnummer;
		private string plz;
		private string ort;
		private Land land;

		public Besitzer(string vorname, string nachname, string strasse, string hausnummer, string plz, string ort, Land land)
		{
			this.vorname = vorname;
			this.nachname = nachname;
			this.strasse = strasse;
			this.hausnummer = hausnummer;
			this.plz = plz;
			this.ort = ort;
			this.land = land;
		}

        public Besitzer(string vorname, string nachname, string strasse, string hausnummer, string plz, string ort)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.strasse = strasse;
            this.hausnummer = hausnummer;
            this.plz = plz;
            this.ort = ort;

        }

        public string Vorname
		{
			set
			{
				this.vorname = value; 
			}
			get
			{
				return vorname;
			}
		}
		public string Nachname
		{
			set
			{
				this.nachname = value;
			}
			get
			{
				return nachname;
			}
		}
		public string Strasse
		{
			set 
			{
				this.strasse = value;
			}

			get
			{
				return strasse;
			}
		}
		public string Hausnummer
		{
			set
			{
				this.hausnummer = value;
			}

			get
			{
				return hausnummer;
			}
		}
		public string Plz
		{
			set
			{
				this.plz = value;
			}

			get
			{
				return plz;
			}
		}
		public string Ort
		{
			set
			{
				this.ort = value;
			}

			get
			{
				return ort;
			}
		}
		public Land Land
		{
			get
			{
				return land;
			}
		}
	}
}