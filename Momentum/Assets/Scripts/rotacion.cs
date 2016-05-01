using UnityEngine;
using System.Collections;

public class rotacion : MonoBehaviour
{

    private Vector3 r;
    private float t;
    public Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        r = new Vector3(0, 0, 0);
        this.transform.position = r;
        t = 0;
    }

    void FixedUpdate()
    {
        cirunferencia(5f, 2f);
    }

    void cirunferencia(float radio, float omega)
    {
        t += Time.deltaTime;

        r.x = radio * Mathf.Cos(omega * t);
        r.y = 3;
        r.z = radio * Mathf.Sin(omega * t);
        rb.transform.position = r;
    }
}
