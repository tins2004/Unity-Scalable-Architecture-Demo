using UnityEngine;

public class MoveCommand : ICommand
{
    private readonly PlayerController _playerController;
    private readonly Vector3 movement;

    public MoveCommand(PlayerController playerController, Vector3 moveVector)
    {
        _playerController = playerController;
        movement = moveVector;
    }

    public void Execute()
    {
        _playerController.Move(movement);
    }

    public void Undo()
    {
        _playerController.Move(-movement);
    }
}
