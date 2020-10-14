using System;

namespace prov
{
    public class Böcker
    {
        public int price = 79;
        private string name = "Sagan om ringen";

        public string GetName()
        {
            return name;
        }

        private int rarity = 1;

        private string category = "Fantasy";

        private int actualValue = 79;

        private bool cursed = false;

        Random generator = new Random();



    }
}
