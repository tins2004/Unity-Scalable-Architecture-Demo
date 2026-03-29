using UnityEngine;

public class RainObjectManager : MonoBehaviour
{
    [SerializeField] private ObjectPool rainObjectPool;
    [SerializeField] private int rainZoneSize;

    private float spawnTimer = 0f;
    private float spawnInterval = 0.5f;

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0f;

            GameObject obj = rainObjectPool.GetObject();

            obj.transform.localPosition = new Vector3(Random.Range(1, rainZoneSize), obj.transform.position.y, Random.Range(1, rainZoneSize));
        }
    }
}
