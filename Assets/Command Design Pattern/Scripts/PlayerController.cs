using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float BOARDSPACING = 1f;

    [SerializeField] private LayerMask obstacleLayer;
    
    public void Move(Vector3 movement)
    {
        transform.position = transform.position + movement;
    }   

    public bool IsValidMove(Vector3 movement)
    {
        return !Physics.Raycast(transform.position, movement, BOARDSPACING, obstacleLayer);
    }
}
