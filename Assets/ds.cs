using System.Collections;
using UnityEngine;

public class ds : MonoBehaviour {

    float ti = 0.0f;

    float tim=5.0f;


    public GameObject one;

    public GameObject a;

    public GameObject b;

    public GameObject c;

    public GameObject d;

    public GameObject e;

   

    // Use this for initialization
    void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {

        ti += Time.deltaTime;

        if (ti > tim)
        {
             

                if (Random.Range(1,6) == 1)
                {

                    Instantiate(a, one.transform.position, one.transform.rotation);

                    ti = 0;

               

                 

                }else if (Random.Range(1, 6) == 2)
                {

                    Instantiate(b, one.transform.position, one.transform.rotation);

                    ti = 0;

             



                }
                else if (Random.Range(1, 6) == 3)
                {

                    Instantiate(c, one.transform.position, one.transform.rotation);

                    ti = 0;

             

                  

                }
                else if (Random.Range(1, 6) == 4)
                {

                    Instantiate(d, one.transform.position, one.transform.rotation);

                    ti = 0;

             

                  

                }
                else if (Random.Range(1, 6) == 5)
                {

                    Instantiate(e, one.transform.position, one.transform.rotation);

                    ti = 0;

         

                 

                }

                }
        ti = 0.0f;

      
            }


   
    }





	

