using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Fixed Update es pa físicas
    private void FixedUpdate()
    {
        Vector2 forceDirection = Vector2.right;
        float forceStrenght = 10.0f;

        GetComponent<Rigidbody2D>().AddForce(forceDirection * forceStrenght);
    }
}
