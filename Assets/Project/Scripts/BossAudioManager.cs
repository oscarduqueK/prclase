using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class BossAudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixerSnapshot[] snapshots;
    AudioSource musicSource;

    int bpm = 128;
    //float initialDelay = 0.0f;

    float beatTime;

    public Image image;

    private void Awake()
    {
        beatTime = 1.0f / bpm;
    }

    private float GetBeatTimeRate()
    {
        float songTime = musicSource.time;
        float currentBeat = songTime / beatTime;
        float result = Mathf.Sin(currentBeat * 360 * Mathf.Deg2Rad);
        return result;
    }

    // Update is called once per frame
    void Update()
    {
        image.GetComponent<RectTransform>().localScale = Vector3.one * (1.0f + 0.5f * GetBeatTimeRate());

        for (int i = 0; i < snapshots.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                snapshots[i].TransitionTo(0.5f);
            }
        }
    }
}
