namespace SchiffeUndBoote
{
    abstract class Wasserfahrzeug
    {
        protected string name;
        protected int laengeInMetern;
        protected int breiteInMetern;
        protected int hoheInMetern;
        protected int tiefgangInMetern;
        

        protected Wasserfahrzeug(string name, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern)
        {
            this.name = name;
            this.laengeInMetern = laengeInMetern;
            this.breiteInMetern = breiteInMetern;
            this.hoheInMetern = hoheInMetern;
            this.tiefgangInMetern = tiefgangInMetern;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int LaengeInMetern
        {
            get
            {
                return laengeInMetern;
            }

            set
            {
                laengeInMetern = value;
            }
        }
        public int BreiteInMetern
        {
            get
            {
                return breiteInMetern;
            }

            set
            {
                breiteInMetern = value;
            }
        }
        public int HoheInMetern
        {
            get
            {
                return hoheInMetern;
            }

            set
            {
                hoheInMetern = value;
            }
        }
        public int TiefgangInMetern
        {
            get
            {
                return tiefgangInMetern;
            }

            set
            {
                tiefgangInMetern = value;
            }
        }
    }
}