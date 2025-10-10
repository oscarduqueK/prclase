using UnityEngine;

public class InfoSaver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        PlayerPrefs.SetFloat("Niga", 10.0f);
        PlayerPrefs.SetInt("Niga", 10);
        PlayerPrefs.SetString("Niga", "Niga");
        PlayerPrefs.SetFloat("Niga", 10.0f);
        Debug.Log("Polla");

        //int value = PlayerPrefs.SetInt("Niga", 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
