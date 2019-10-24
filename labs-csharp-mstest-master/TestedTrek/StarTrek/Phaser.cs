namespace StarTrek
{
    public class Phaser : Weapon
    {
        public Phaser()
        {
            RemainingAmmo = 10000;
        }

        public override bool Missed(int distance)
        {
            return distance > 4000;
        }

        public override bool HasRemainingAmmo()
        {
            int amount = Galaxy.Amount;
            return RemainingAmmo >= amount;
        }

        public override void DecreaseAmmo()
        {
            RemainingAmmo -= Galaxy.Amount;
        }

        public override void WriteHitMessage(int distance, int damage)
        {
            Galaxy.WriteLine("Phasers hit Klingon at " + distance + " sectors with " + damage + " units");
        }

        public override void WriteMissedMessage(int distance)
        {
            Galaxy.WriteLine("Klingon out of range of phasers at " + distance + " sectors...");
        }

        public override void WriteNoAmmoMessage()
        {
            Galaxy.WriteLine("Insufficient energy to fire phasers!");
        }

        public override int GetDamage()
        {
            int amount = Galaxy.Amount;
            var distance = Galaxy.Target.Distance();
            var damage = amount - (((amount / 20) * distance / 200) + Game.Rnd(200));
            
            if (damage < 1)
                damage = 1;

            return damage;
        }
    }
}