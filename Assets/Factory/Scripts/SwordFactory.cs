using UnityEngine;

[CreateAssetMenu(fileName = "SwordFactory", menuName = "Weapon Factory/Sword")]
public class SwordFactory : WeaponFactory
{
    private IWeapon weapon;

    public override IWeapon CreateWeapon()
    {
        if (weapon == null)
        {
            weapon = new Sword();
        }

        return weapon;
    }
}
