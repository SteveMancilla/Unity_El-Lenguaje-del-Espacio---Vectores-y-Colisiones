using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal") * velocidad;
        rb.linearVelocity = new Vector3(movimientoHorizontal, rb.linearVelocity.y, rb.linearVelocity.z);
    }
}
