using UnityEngine;
using System.Collections;

public class loauidoscript : MonoBehaviour
{
    public AudioSource[] audioSources;
    public float tiempoPorGrupo = 5f;
    private int indiceActual = 0;

    void Start()
    {
        StartCoroutine(RotarAudios());
    }

    IEnumerator RotarAudios()
    {
        while (true)
        {
            // Detener todos
            foreach (var source in audioSources)
                source.Stop();

            // Reproducir el actual
            audioSources[indiceActual].Play();

            yield return new WaitForSeconds(tiempoPorGrupo);

            indiceActual = (indiceActual + 1) % audioSources.Length;
        }
    }
}
