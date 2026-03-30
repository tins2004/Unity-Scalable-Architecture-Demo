using UnityEngine;

public class DemoLoger : MonoBehaviour
{
    private void Start()
    {
        Observer.AddListener("UpdateUI", OnUpdateUI);
    }

    private void OnDestroy()
    {
        Observer.RemoveListener("UpdateUI", OnUpdateUI);
    }

    private void OnUpdateUI(params object[] datas)
    {
        foreach (var data in datas)
        {
            Debug.Log("UI Update " + data);
        }
    }
}
