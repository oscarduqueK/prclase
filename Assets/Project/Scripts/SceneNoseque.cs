using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNoseque : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if (testSingleton.Instance == null)
        //{
        //    Instance = this;
        //    DontDestroyOnLoad(gameObject); // opcional, si quieres que sobreviva a los cambios de escena
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            testSingleton.Instance.SayHi();
        }

        //Load scene 1
        Scene scene = SceneManager.GetSceneByName("s1");
        if (Input.GetKeyDown(KeyCode.Alpha1) && !scene.isLoaded)
        {
            SceneManager.LoadScene("s1", LoadSceneMode.Additive);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && scene.isLoaded)
        {
            SceneManager.UnloadSceneAsync("s1");
        }

        //Load Scene 2
        Scene scenigga = SceneManager.GetSceneByName("s2");
        if (Input.GetKeyDown(KeyCode.Alpha2) && !scenigga.isLoaded)
        {
            SceneManager.LoadScene("s2", LoadSceneMode.Additive);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && scenigga.isLoaded)
        {
            SceneManager.UnloadSceneAsync("s2");
        }

        Scene scenigger = SceneManager.GetSceneByName("JumpScene");
        if (Input.GetKeyDown(KeyCode.Alpha3) && !scenigger.isLoaded)
        {
            SceneManager.LoadScene("JumpScene", LoadSceneMode.Additive);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && scenigger.isLoaded)
        {
            SceneManager.UnloadSceneAsync("JumpScene");
        }
    }
}
