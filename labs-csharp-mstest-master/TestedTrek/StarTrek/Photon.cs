
namespace StarTrek
{
    public class Photon : Weapon
    {        
        public Photon()
        {
            RemainingAmmo = 8;
        }

        public override bool Missed(int distance)
        {
            return (Game.Rnd(4) + ((distance / 500) + 1) > 7);
        }

        public override bool HasRemainingAmmo()
        {
            return RemainingAmmo > 0;
        }

        public override void DecreaseAmmo()
        {
            RemainingAmmo -= 1;
        }

        public override void WriteHitMessage(int distance, int damage)
        {
            Galaxy.WriteLine("Photons hit Klingon at " + distance + " sectors with " + damage + " units");
        }

        public override void WriteMissedMessage(int distance)
        {
            Galaxy.WriteLine("Torpedo missed Klingon at " + distance + " sectors...");
        }

        public override void WriteNoAmmoMessage()
        {
            Galaxy.WriteLine("No more photon torpedoes!");
        }

        public override int GetDamage()
        {
            return 800 + Game.Rnd(50);
        }
    }
}