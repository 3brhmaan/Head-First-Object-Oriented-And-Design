using HeadFirstObjectOrientedAndDesign.CH1;
using System.Collections.Generic;
using System.Reflection;

namespace HeadFirstObjectOrientedAndDesign
{
    internal class Program
    {
        public static void initializeInventory(Inventory inventory)
        {
            GuitarSpec spec = new(Builder.FENDER,"Stratocastor",
                         CH1.Type.ELECTRIC,Wood.ALDER, Wood.ALDER);

            inventory.addGuitar("V95693",1499.95, spec);
            
            inventory.addGuitar("V9512",1549.95, spec);
        }
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

			GuitarSpec whatErinLikes =
                    new GuitarSpec(Builder.FENDER, "Stratocastor", CH1.Type.ELECTRIC,
                    Wood.ALDER, Wood.ALDER);

			List<Guitar> matchingGuitars = inventory.search(whatErinLikes);

            if (matchingGuitars.Any())
            {
                Console.WriteLine("Erin, you might like these guitars:");

                foreach(Guitar guitar in matchingGuitars)
                {
					GuitarSpec spec = guitar.getSpec();
					Console.WriteLine("We have a " +
					spec.getBuilder() + " " + spec.getModel() + " " +
					spec.getType() + " guitar:\n " +
					spec.getBackWood() + " back and sides,\n " +
					spec.getTopWood() + " top.\n You can have it for only $" +
                    guitar.getPrice() + "!\n----") ;
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.") ;
            }
        }
    }
}