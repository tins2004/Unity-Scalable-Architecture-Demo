using UnityEngine;

public class SilencerDecorator : GunDecorator
{
    public SilencerDecorator(IGun gun) : base(gun) { }

    public override void Shoot()
    {
        base.Shoot();
        Debug.Log("[Gun has Silencer]");
    }
}
