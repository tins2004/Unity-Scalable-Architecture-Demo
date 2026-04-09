using UnityEngine;

[CreateAssetMenu(fileName = "BowFactory", menuName = "Weapon Factory/Bow")]
public class BowFactory : WeaponFactory
{
    private IWeapon weapon;

    public override IWeapon CreateWeapon()
    {
        if (weapon == null)
        {
            weapon = new Bow();
        }

        return weapon;
    }
}
