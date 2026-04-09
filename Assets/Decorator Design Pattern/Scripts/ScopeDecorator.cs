using UnityEngine;

public class ScopeDecorator : GunDecorator
{
    public ScopeDecorator(IGun gun) : base(gun) { }

    public override void Shoot()
    {
        base.Shoot();
        Debug.Log("[Gun has Scope]");
    }
}
