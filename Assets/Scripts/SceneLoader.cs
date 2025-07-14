using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
