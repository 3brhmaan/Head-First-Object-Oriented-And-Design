﻿using HeadFirstObjectOrientedAndDesign.CH1;
using HeadFirstObjectOrientedAndDesign.CH2;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace HeadFirstObjectOrientedAndDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
			DogDoor door = new DogDoor();
			Remote remote = new Remote(door);

			Console.WriteLine("Fido barks to go outside...");
			remote.PressButton();

            Console.WriteLine("\nFido has gone outside...");
			remote.PressButton();

            Console.WriteLine("\nFido’s all done...");
			remote.PressButton();

            Console.WriteLine("\nFido’s back inside...");
			remote.PressButton();
		}
    }
}