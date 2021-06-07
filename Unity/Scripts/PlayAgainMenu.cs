using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainMenu : MonoBehaviour
{
    public GameObject playAgainScene;
    public GameObject inGameScene;
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
