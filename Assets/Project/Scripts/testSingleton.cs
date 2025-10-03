using UnityEngine;

public class testSingleton : MonoBehaviour
{
    public static testSingleton Instance {  get; private set; }
    void Start()
    {
        if (Instance == null)
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        Instance = this;
        //Start stuff
    }

    public void SayHi()
    {
        Debug.Log("Nigger");
    }
}
