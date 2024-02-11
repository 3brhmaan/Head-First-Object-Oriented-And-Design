using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstObjectOrientedAndDesign.CH1
{
    public class Inventory
    {
        List<Guitar> guitars;
        public Inventory() =>
            guitars = new List<Guitar>();
        public void addGuitar(String serialNumber, double price, GuitarSpec guitarSpec)
        {
            Guitar guitar = new Guitar(serialNumber, price, guitarSpec);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(String serialNumber)
        {
            foreach(Guitar guitar in  guitars)
            {
                if (guitar.getSerialNumber().Equals(serialNumber))
                    return guitar;
            }
            return null;
        }
		public List<Guitar> search(GuitarSpec searchSpec)
		{
			List<Guitar> matchingGuitars = new List<Guitar>();
			foreach (Guitar guitar in guitars)
			{
				GuitarSpec guitarSpec = guitar.getSpec();

				if (searchSpec.Equals(guitarSpec))
				    matchingGuitars.Add(guitar);
			}

			return matchingGuitars ;
		}

	}
}
