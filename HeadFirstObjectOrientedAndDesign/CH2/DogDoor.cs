using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstObjectOrientedAndDesign.CH2
{
	public class DogDoor
	{
        bool open { get; set; }

        public DogDoor() =>
            this.open = false;
        public void Open()
        {
            Console.WriteLine("The dog door opens");
            open = true;
        }
		public void Close()
		{
			Console.WriteLine("The dog door Closes");
			open = false;
		}
        public bool IsOpen() =>
             open;
	}
}
