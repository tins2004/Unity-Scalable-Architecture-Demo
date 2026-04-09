using UnityEngine;

public class Gunner : MonoBehaviour
{
    private IGun _gun;

    void Start()
    {
        _gun = new Pistol();
        _gun = new SilencerDecorator(_gun);
        _gun = new LaserDecorator(_gun);
        _gun = new ScopeDecorator(_gun);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _gun.Shoot();
        }
    }
}
