using System.Collections;
using UnityEngine;

public class fade : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        Debug.Log("Start");
        yield return new WaitUntil(delegate { return Input.GetKeyDown(KeyCode.Space); } );
        Debug.Log("Ended");
    }
}
