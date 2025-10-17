using UnityEngine;
using System.Collections;

public class hexagon : MonoBehaviour
{
    private float maxRotationTime = 1.0f;
    private float currentRotationTime = 0.0f;
    [SerializeField] private float dps = 30.0f;

    [SerializeField] private AnimationCurve rotationCurve;
    [SerializeField] private AnimationCurve scaleCurve;
    [SerializeField] private Gradient colorGradient;
    


    // Update is called once per frame
    void Update()
    {
        currentRotationTime += Time.deltaTime;
        float t = currentRotationTime / maxRotationTime;

        t = t - (int)t;

        float rotationlerpValue = rotationCurve.Evaluate(t);
        transform.rotation = Quaternion.Euler(0, 0, dps * rotationlerpValue);

        float scaleLerpValue = scaleCurve.Evaluate(t);
        transform.localScale = Vector3.one + Vector3.one * scaleLerpValue;

        Color colorLerpValue = colorGradient.Evaluate(t);
        GetComponent<SpriteRenderer>().color = colorLerpValue;


        //float framerotation = dps * Time.deltaTime;
        //transform.rotation *= Quaternion.Euler(0.0f, 0.0f, framerotation);
    }
}
