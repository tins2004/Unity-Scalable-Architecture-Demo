using UnityEngine;

public class GameManagerHasSingleton : MonoBehaviour
{
    public static GameManagerHasSingleton instance { get; private set; }
    
    private int count = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log($"<color=green>[Singleton]</color> Khởi tạo Instance thành công trên: {gameObject.name} (ID: {gameObject.GetInstanceID()})");
        }
        else
        {
            Debug.Log($"<color=red>[Singleton]</color> Phát hiện bản sao trùng lặp! Đang hủy đối tượng: {gameObject.name} (ID: {gameObject.GetInstanceID()})");
            Destroy(gameObject);
        }
    }

    

    public void AddScore()
    {
        count += 10;
        Debug.Log($"<color=yellow>[GameManager]</color> Score hiện tại: {count}");
    }
}
