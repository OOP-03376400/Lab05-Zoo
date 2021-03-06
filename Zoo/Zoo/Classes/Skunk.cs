﻿using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Skunk : Carnivore
    {
        // backing stores
        // redirect targets for unwanted property 'set' inputs
        private bool _garbageBool = true;
        private string _garbageString = "";

        // inherited properties overrides
        public override string Species
        {
            get { return "skunk"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse
        {
            get { return false; }
            set { _garbageBool = value; }
        }

        public override bool Stinky
        {
            get { return true; }
            set { _garbageBool = value; }
        }


        /// <summary>
        /// Reports a successful meal
        /// </summary>
        /// <param name="critter"> the critter that will be eaten </param>
        /// <returns> confirmation of meal </returns>
        public override bool Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am a skunk, and I ate a {critter.Species}. It was tasty.");
            return true;
        }

        /// <summary>
        /// Instantiates new class instance for each baby;
        /// Reports births to console;
        /// Returns number of babies
        /// </summary>
        /// <param name="babies"> number of babies </param>
        /// <returns> number of babies </returns>
        public override int GiveBirth(int babies)
        {
            for (int i = 0; i < babies; i++)
            {
                new Skunk();
            }
            Console.WriteLine($"Skunk babies are kinda adorable.... just look at these {babies}!");
            return babies;
        }
    }
}
