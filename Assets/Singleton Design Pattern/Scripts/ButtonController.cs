using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(ButtonOnClick);
    }

    private void ButtonOnClick()
    {
        GameManagerHasSingleton.instance.AddScore();
        FindAnyObjectByType<GameManagerHasnotSingleton>().AddScore();

        string currentSceneName = SceneManager.GetActiveScene().name;
        currentSceneName = currentSceneName.Substring(0, currentSceneName.Length - 1) + (currentSceneName[^1] == '1' ? '2' : '1');
        SceneManager.LoadScene(currentSceneName);
    }
}
