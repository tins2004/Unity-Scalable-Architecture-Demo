using UnityEngine;

public class IdleState : IState
{
    public void Enter()
    {
        Debug.Log("Idle Enter State");
    }

    public void Execute()
    {
        Debug.Log("Idle Execute State");

    }

    public void Exit()
    {
        Debug.Log("Idle Exit State");
    }
}
