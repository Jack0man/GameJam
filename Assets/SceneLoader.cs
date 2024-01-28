using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string nextSceneName = "_Envuirement_"; // Replace with the name of your next scene

    void Start()
    {
        // Invoke the LoadNextScene method after 10 seconds
        Invoke("LoadNextScene", 10f);
    }

    void LoadNextScene()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }
}