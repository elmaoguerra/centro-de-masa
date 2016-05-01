using UnityEngine;
using System.Collections;

public class MovCamara : MonoBehaviour {

    public float minX = -360.0f;
    public float maxX = 360.0f;

    public float minY = -45.0f;
    public float maxY = 45.0f;

    public float sensX = 100.0f;
    public float sensY = 100.0f;

    float rotationY = 0.0f;
    float rotationX = 0.0f;

	// Use this for initialization
	void Start () {
	
	}

	
	
	void FixedUpdate () {

	    rotationX += Input.GetAxis ("Mouse X") * sensX * Time.deltaTime;
        rotationY += Input.GetAxis ("Mouse Y") * sensY * Time.deltaTime;
        rotationY = Mathf.Clamp (rotationY, minY, maxY);
        this.transform.localEulerAngles = new Vector3 (-rotationY, rotationX, 0);
	}
}
