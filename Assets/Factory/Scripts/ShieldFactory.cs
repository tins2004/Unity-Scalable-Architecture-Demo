using UnityEngine;

public interface IShield
{
    void Defend();

    static IShield CreateDefault()
    {
        return new WoodShield();
    }
}

public class WoodShield : IShield
{
    public void Defend()
    {
        Debug.Log("Blocking with the Wood Shield!");
    }
}

public abstract class ShieldFactory : ScriptableObject
{
    public abstract IShield CreateShield();
}
