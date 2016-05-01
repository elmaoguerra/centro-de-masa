using UnityEngine;
using System.Collections;

public class CentroMasa : MonoBehaviour {

    private GameObject[] particulas;
    private Rigidbody[] listaRb;
    private float M;
    public Vector3 cm, aux;
    private GameObject camara;
    public int posCam;
    private Rigidbody rb;

	void Start () {
        M = 0;
        posCam = 0;
        cm = new Vector3();
        particulas = GameObject.FindGameObjectsWithTag("Particula");
        camara = GameObject.FindGameObjectWithTag("Camara");
        listaRb = new Rigidbody[particulas.Length];
        rb = GetComponent<Rigidbody>();
		aux =new Vector3();

        int i = 0;
        foreach (GameObject p in particulas)
        {
            Rigidbody rgb = p.GetComponent<Rigidbody>();
            listaRb[i] = rgb;
            M += rgb.mass;
            i++;
        }
        
	}

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            posCam = 0;
        }
        else if (Input.GetKeyDown("2"))
        {
            posCam = 1;
        }

        
    }	
	void FixedUpdate () {
        float force = 2f;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(h, 0f, v);
        rb.transform.Translate(vector * force * Time.deltaTime);
        rb.transform.rotation = camara.transform.rotation;

        aux = new Vector3();
        //Vector3 aux = this.transform.position;
        for (int i = 0; i < particulas.Length; i++)
        {
            //aux += listaRb[i].mass * (rb.transform.position - particulas[i].transform.position);
			aux += listaRb[i].mass * (1.0f / M) * (particulas[i].transform.position - transform.position);
        }
        cm = (aux);
        //cm += transform.position;
		aux =transform.position;
        Debug.Log(cm);
        ubicarCamara();
	}

    private void ubicarCamara()
    {
        if (posCam == 0)
        {
            camara.transform.position = this.transform.position;
            
        }
        else if (posCam == 1)
        {
            camara.transform.position = cm;
        }
    }

	private void calcularCM(Vector3 aux){
		
	}
}
