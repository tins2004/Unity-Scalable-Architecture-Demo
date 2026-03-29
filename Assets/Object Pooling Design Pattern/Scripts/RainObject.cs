using UnityEngine;

public class RainObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindFirstObjectByType<ObjectPool>().ReturnObject(this.gameObject);
    }
}
