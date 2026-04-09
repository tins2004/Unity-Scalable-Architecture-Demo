using NUnit.Framework;
using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField] private EquipmentFactory equipmentFactory;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            equipmentFactory.CreateWeapon().Attack();
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            equipmentFactory.CreateShield().Defend();
        }
    }
}
