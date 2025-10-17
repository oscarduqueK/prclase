using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeSceneNiiga()
    {
        
        SceneManager.LoadScene("s1", LoadSceneMode.Single);
    }


}
