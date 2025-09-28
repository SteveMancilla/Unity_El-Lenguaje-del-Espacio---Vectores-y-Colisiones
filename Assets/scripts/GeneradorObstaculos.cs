using UnityEngine;

public class GeneradorObstaculos : MonoBehaviour
{
    public GameObject obstaculoPrefab;
    public Transform generarCubos;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "jugador")
        {
            print("Hay una colision con " + other.name + " en " + this.gameObject.name);
            Instantiate(obstaculoPrefab, generarCubos.position, Quaternion.identity);
        }
        
    }
}
