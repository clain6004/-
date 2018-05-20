using System.Collections;
using UnityEngine;

public class ms : MonoBehaviour {
    public float s=3.0f;

    public float i = 0.0f;

    public float im = 20.0f;

	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {

        i += Time.deltaTime;


       Vector3 moved=new Vector3(0,0,-s);
      transform.Translate(moved*s*Time.deltaTime);

        if (i > im)
        {

            Destroy(gameObject);



        }


	}




}
