using UnityEngine;

public class LaserDecorator : GunDecorator
{
    public LaserDecorator(IGun gun) : base(gun) { }

    public override void Shoot()
    {
        base.Shoot();
        Debug.Log("[Gun has Laser]");
    }
}
