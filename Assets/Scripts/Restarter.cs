using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.RestartAction += ReloadScene;
    }

    private void OnDisable()
    {
        GameEvents.RestartAction -= ReloadScene;
    }

    private void ReloadScene() 
    {
        SceneManager.LoadScene("Game");
    }
}
