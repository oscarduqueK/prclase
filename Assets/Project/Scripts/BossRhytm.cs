using UnityEngine;
using UnityEngine.Timeline;
using System.Collections;

public class BossRhytm : MonoBehaviour
{
    [Header("Partes de la canción")]
    public AudioSource chords;
    public AudioSource drums;
    public AudioSource bounce;
    public AudioSource trumpet;
    public AudioSource master;


    [Header("Duración de cada fase (segundos)")]
    public float phaseDuration = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(MusicBattleSequence());
    }

    // Update is called once per frame

    IEnumerator MusicBattleSequence()
    {
        // --- Fase 1: La calma antes de la tormenta ---
        Debug.Log("Fase 1: El silencio tenso antes del combate...");
        chords.Play();
        yield return new WaitForSeconds(phaseDuration);

        // --- Fase 2: Primer enfrentamiento ---
        Debug.Log("Fase 2: Entran los tambores de guerra...");
        drums.Play();
        yield return new WaitForSeconds(phaseDuration);

        // --- Fase 3: La batalla se intensifica ---
        Debug.Log("Fase 3: El ritmo rebota y todo se descontrola...");
        bounce.Play();
        yield return new WaitForSeconds(phaseDuration);

        // --- Fase 4: El héroe contraataca ---
        Debug.Log("Fase 4: La trompeta marca el contraataque...");
        trumpet.Play();
        yield return new WaitForSeconds(phaseDuration);

        // --- Fase 5: El clímax ---
        Debug.Log("Fase 5: Todos los instrumentos suenan al unísono.");
        master.Play(); // o simplemente deja sonar todos los anteriores
        yield return new WaitForSeconds(phaseDuration);

        // --- Fase final: la calma vuelve ---
        Debug.Log("Fin: El combate termina, el silencio regresa...");
        chords.Stop();
        drums.Stop();
        bounce.Stop();
        trumpet.Stop();
        master.Stop();
    }
}
