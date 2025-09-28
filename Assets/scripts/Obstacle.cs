using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(0, 0, -velocidad);
    }
}
