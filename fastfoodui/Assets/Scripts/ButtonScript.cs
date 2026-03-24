using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadSpecificScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    public void LoadNextScene()
    {
       int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
       SceneManager.LoadScene(currentSceneIndex + 1); 
    }
}
