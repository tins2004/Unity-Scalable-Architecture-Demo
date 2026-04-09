using UnityEngine;

[RequireComponent(typeof(StateManager))]
public class Solider : MonoBehaviour
{
    [SerializeField] StateManager _stateManager;
    private void Start()
    {
        _stateManager = GetComponent<StateManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _stateManager.ChangeSate(new DefendState());
        }
        else
        {
            _stateManager.ChangeSate(new IdleState());
        }
    }
}
