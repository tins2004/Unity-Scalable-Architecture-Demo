using UnityEngine;

public class DefendState : IState
{
    public void Enter()
    {
        Debug.Log("Defend Enter State");
    }

    public void Execute()
    {
        Debug.Log("Defend Execute State");

    }

    public void Exit()
    {
        Debug.Log("Defend Exit State");
    }
}
