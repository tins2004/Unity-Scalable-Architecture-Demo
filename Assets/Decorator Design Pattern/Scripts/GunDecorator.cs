using UnityEngine;

public abstract class GunDecorator : IGun
{
    public IGun _gun;

    public GunDecorator(IGun gun)
    {
        _gun = gun;
    } 

    public virtual void Shoot()
    {
        _gun.Shoot();
    }
}
