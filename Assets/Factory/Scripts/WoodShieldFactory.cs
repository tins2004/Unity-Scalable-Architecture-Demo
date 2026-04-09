using UnityEngine;

[CreateAssetMenu(fileName = "WoodShieldFactory", menuName = "Shield Factory/Wood Shield")]
public class WoodShieldFactory : ShieldFactory
{
    private IShield shield;

    public override IShield CreateShield()
    {
        if (shield == null)
        {
            shield = new WoodShield();
        }

        return shield;
    }
}
