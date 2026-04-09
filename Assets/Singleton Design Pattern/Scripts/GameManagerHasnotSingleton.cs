using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerHasnotSingleton : MonoBehaviour
{
    private int count = 0;

    public void AddScore()
    {
        count += 10;
        Debug.Log($"<color=gray>[GameManager]</color> Score hiện tại: {count}");
    }
}
