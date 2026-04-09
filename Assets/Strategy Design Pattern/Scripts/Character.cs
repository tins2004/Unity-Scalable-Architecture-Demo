using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    private IMovementStrategy _movementStrategy;

    void Start()
    {
        SetMovementStrategy(new WalkMovement());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetMovementStrategy(new WalkMovement());
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetMovementStrategy(new FlyMovement());
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _movementStrategy.Move();
        }

    }
    private void SetMovementStrategy(IMovementStrategy strategy)
    {
        _movementStrategy = strategy;
    }
}
