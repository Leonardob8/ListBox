namespace SchiffeUndBoote
{
    abstract class Schiff : Wasserfahrzeug
    {
        protected Land land;
        protected int leistungInKw;

        protected Schiff(string name, Land land, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, int leistungInKw)
            :base(name, laengeInMetern, breiteInMetern, hoheInMetern, tiefgangInMetern)
        {
            this.land = land;
            this.leistungInKw = leistungInKw;
        }

        public Land Land
        {
            get
            {
                return land;
            }

            set
            {
                land = value;
            }
        }

        public int LeistungInKw
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