using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

    private Rigidbody rb;
    private float t = 0;
    private Vector3 v;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        //v = new Vector3(1.5f, 0, 0);
        rb.AddForce(transform.right * 15f, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {

	
	}

    void FixedUpdate()
    {
        //Vector3 r = rb.transform.position;
        //t += Time.deltaTime;
        //r += (v * t);
        //rb.transform.position = r;
        //Debug.Log(rb.transform.position * Time.deltaTime);
    }

    void OnCollisionEnter()
    {
        
        //rb.AddForce(transform.right * 5f, ForceMode.VelocityChange);
        //rb.AddTorque(transform.right * 5000f);
        //rb.useGravity = true;
    }
}
