using System;
using StarTrek;
using Untouchables;

public class Game
{    
    private readonly Phaser phaser = new Phaser();
    private readonly Photon photon = new Photon();

    public int EnergyRemaining()
    {
        return phaser.RemainingAmmo;
    }

    public int Torpedoes
    {
        set => photon.RemainingAmmo = value;
        get => photon.RemainingAmmo;
    }

    public void FireWeapon(WebGadget wg)
    {
        FireWeapon(new Galaxy(wg));
    }

    public void FireWeapon(Galaxy wg)
    {
        if (wg.IsPhaser)
        {
            phaser.Fire(wg);
        }
        else if (wg.IsPhoton)
        {
            photon.Fire(wg);
        }
    }

    // note we made generator public in order to mock it
    // it's ugly, but it's telling us something about our *design!* ;-)
    public static Random generator = new Random();
    public static int Rnd(int maximum)
    {
        return generator.Next(maximum);
    }
}