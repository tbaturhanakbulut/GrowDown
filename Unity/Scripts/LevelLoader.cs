using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public float i = 1f;
    public Animator transition;
    // Update is called once per frame
    public void LoadGame()
    {
        StartCoroutine(LoadGameMain());
    }
    private IEnumerator LoadGameMain()
    {
        
        transition.SetTrigger("Trigger");
        
        
        yield return new WaitForSeconds(i);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }
}
