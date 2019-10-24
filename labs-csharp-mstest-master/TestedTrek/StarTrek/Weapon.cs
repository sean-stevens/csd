namespace StarTrek
{
    public abstract class Weapon
    {
        public Galaxy Galaxy { get; set; }

        public int RemainingAmmo { get; set; }

        public void Fire(Galaxy wg)
        {
            Galaxy = wg;
            Klingon enemy = wg.Target;

            if (HasRemainingAmmo())
            {
                int distance = enemy.Distance();

                if (Missed(distance))
                {
                    WriteMissedMessage(distance);
                }
                else
                {
                    int damage = GetDamage();
                    WriteHitMessage(distance, damage);
                    Hit(wg, damage, enemy);
                }

                DecreaseAmmo();
            }
            else
            {
                WriteNoAmmoMessage();
            }
        }

        public abstract void DecreaseAmmo();

        public abstract int GetDamage();

        public abstract bool HasRemainingAmmo();
        
        public abstract bool Missed(int distance);

        public abstract void WriteNoAmmoMessage();

        public abstract void WriteMissedMessage(int distance);

        public abstract void WriteHitMessage(int distance, int damage);

        protected void Hit(Galaxy wg, int damage, Klingon enemy)
        {
            if (damage < enemy.GetEnergy())
            {
                enemy.SetEnergy(enemy.GetEnergy() - damage);
                wg.WriteLine("Klingon has " + enemy.GetEnergy() + " remaining");
            }
            else
            {
                wg.WriteLine("Klingon destroyed!");
                enemy.Delete();
            }
        }
    }
}