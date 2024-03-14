namespace SchiffeUndBoote
{
    abstract class Boot : Wasserfahrzeug
    {
        protected Besitzer besitzer;

        protected Boot(string name, Besitzer besitzer, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern) 
            : base(name, laengeInMetern, breiteInMetern, hoheInMetern, tiefgangInMetern)
        {
            this.besitzer = besitzer;
        }

        public Besitzer Besitzer
        {
            get
            {
                return besitzer;
            }

            set
            {
                besitzer = value;
            }
        }
    }
}