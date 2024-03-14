using System;

namespace SchiffeUndBoote
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            Land china = new Land("China", "CH");
            Land deutschland = new Land ("Deutschland", "D");
            Land uk = new Land("United Kindgom", "UK");

            Besitzer chef = new Besitzer("Sherlock", "Holmes", "Baker Street", "221B", "NW1", "London", uk);

            List<Wasserfahrzeug> wasserfahrzeuge = new List<Wasserfahrzeug>(); //Polymorphie!
            wasserfahrzeuge.Add(new Containerschiff("Ever Given", china, 400,59, 33, 16, 20124, 59300));
            wasserfahrzeuge.Add(new Tankschiff("CABO SOUNION", deutschland, 229, 32, 15, 8, 40000, 20000));
            wasserfahrzeuge.Add(new Segelboot("Unsinkbar II", chef, 5, 3, 2, 1, 5.0));
            wasserfahrzeuge.Add(new Motorboot("Unsink-Bar", chef, 16, 5, 5, 3, 25.0));
  
            foreach(Wasserfahrzeug w in wasserfahrzeuge)
            {
                Console.WriteLine(w.Name +"\t" + w.GetType().Name);
            }

            Application.Run(new Form1());
        }
    }
}