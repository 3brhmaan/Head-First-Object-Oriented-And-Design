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
        public void addGuitar(String serialNumber, double price,
                Builder builder, String model,
                Type type, Wood backWood, Wood topWood)
        {
			GuitarSpec guitarSpec = new(builder, model, type, backWood, topWood);
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

		#region search Older Version 1
		//public Guitar search(Guitar searchGuitar)
		//{
		//    foreach(Guitar guitar in guitars)
		//    {
		//        // Ignore serial number since that’s unique
		//        // Ignore price since that’s unique


		//        String builder = searchGuitar.getBuilder();
		//        if ((builder is not null) && !(builder.Equals("")) && !(builder.Equals(guitar.getBuilder())))
		//            continue;

		//        String model = searchGuitar.getModel();
		//        if ((model is not null) && !(model.Equals("")) && !(model.Equals(guitar.getModel())))
		//            continue;

		//        String type = searchGuitar.getType();
		//        if ((type is not null) && !(searchGuitar.Equals("")) && !(type.Equals(guitar.getType())))
		//            continue;

		//        String backWood = searchGuitar.getBackWood();
		//        if ((backWood is not null) && !(backWood.Equals("")) && !(backWood.Equals(guitar.getBackWood())))
		//            continue;

		//        String topWood = searchGuitar.getTopWood();
		//        if ((topWood is not null) && !(topWood.Equals("")) && !(topWood.Equals(guitar.getTopWood())))
		//            continue;

		//        // This Return Should Exsist But It Doesn't
		//        //return guitar;
		//    }
		//    return null;
		//}
		#endregion

		#region Search Older Version 2
		//public List<Guitar> search(Guitar searchGuitar)
		//      {
		//          List<Guitar> matchingGuitars = new List<Guitar>();
		//          foreach (Guitar guitar in guitars)
		//          {
		//              // Ignore serial number since that’s unique
		//              // Ignore price since that’s unique


		//              if (!(searchGuitar.getBuilder().Equals(guitar.getBuilder())))
		//                  continue;

		//              string model = searchGuitar.getModel().ToLower();
		//              if ((model is not null) && !(model.Equals("")) && !(model.Equals(guitar.getModel().ToLower())))
		//                  continue;

		//              if (!(searchGuitar.getType().Equals(guitar.getType())))
		//                  continue;

		//              if (!(searchGuitar.getBackWood().Equals(guitar.getBackWood())))
		//                  continue;

		//              if (!(searchGuitar.getTopWood().Equals(guitar.getTopWood())))
		//                  continue;

		//              matchingGuitars.Add(guitar);
		//          }

		//          return matchingGuitars;
		//      }
		#endregion
		public List<Guitar> search(GuitarSpec searchSpec)
		{
			List<Guitar> matchingGuitars = new List<Guitar>();
			foreach (Guitar guitar in guitars)
			{
				GuitarSpec guitarSpec = guitar.getSpec();

				if (!(searchSpec.Equals(guitarSpec)))
					continue;

				matchingGuitars.Add(guitar);
			}

			return matchingGuitars;
		}

	}
}
