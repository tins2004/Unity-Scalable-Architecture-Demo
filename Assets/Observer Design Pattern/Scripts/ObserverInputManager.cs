using UnityEngine;

public class ObserverInputManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Observer.Notify("UpdateUI", 10, 12, 3, 5);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Observer.Notify("UpdateUI", 2, 0, 0);
        }
    }
}
