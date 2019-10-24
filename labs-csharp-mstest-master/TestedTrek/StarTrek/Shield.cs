using System;

namespace StarTrek
{
    public class Shield
    {
        private bool isUp = false;

        public Shield()
        {
        }

        public int EnergyLevel()
        {
            return 8000;
        }

        public bool IsUp()
        {
            return isUp;
        }

        public void Raise()
        {
            isUp = true;
        }
    }
}