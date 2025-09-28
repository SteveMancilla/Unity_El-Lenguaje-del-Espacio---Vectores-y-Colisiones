using UnityEngine;

public class VectorVisualizer : MonoBehaviour
{
    public Transform objetivo;

    private void OnDrawGizmos()
    {
        if (objetivo == null) return;

        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * 2f);

        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.up * 2f);

        Vector3 direccionObjetivo = objetivo.position - transform.position;

        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, direccionObjetivo);

        Vector3 direccionNormalizada = direccionObjetivo.normalized;
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position + new Vector3(0, 0.1f, 0), direccionNormalizada * 2f);
    }
}
