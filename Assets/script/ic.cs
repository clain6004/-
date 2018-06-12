using System.Collections;
using UnityEngine;

public class ic : MonoBehaviour {

    public GameObject p;

    public GameObject o;

    float i = 0.0f;

    float im = 3.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        i += Time.deltaTime;

        if (i > im) {

            Instantiate(o, p.transform.position, p.transform.rotation);

            i = 0;


        }

	}
}
