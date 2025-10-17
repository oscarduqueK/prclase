using UnityEngine;

public class locavai : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 forceDirection = Vector2.right;
        float forceStrenght = 1.0f;

        GetComponent<Rigidbody2D>().AddForce(forceDirection * forceStrenght);
    }
}
