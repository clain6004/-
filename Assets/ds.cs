using System.Collections;
using UnityEngine;

public class ds : MonoBehaviour
{

    float tmp;

    float ti = 0.0f;

    public float tim = 5.0f;

    public GameObject one;

    public GameObject two;

    public GameObject three;

    public GameObject a;

    public GameObject b;

    public GameObject c;

    public GameObject d;

    public int item;

    public int itemm = 13;

    public GameObject prehab;

    static public int timem;

    public int timep=2;

    static public int times=1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ti += Time.deltaTime;

        if (ti > tim)
        {

            ti = 0.0f;

            item = Random.Range(1, itemm);

            if (item <= 3)
            {

                prehab = a;

            }
            else if (item > 3 && item < 7)
            {

                prehab = b;

            }
            else if (item < 10 && item > 6)
            {

                prehab = c;

            } else if (item < 14 && item > 9)
            {

                prehab = d;

            }

            int w = Random.Range(1, 4);

          


          
                switch (w)
                {

                    case 1:

                        Instantiate(prehab, one.transform.position, prehab.transform.rotation);

                        break;

                    case 2:

                        Instantiate(prehab, two.transform.position, prehab.transform.rotation);

                        break;

                    case 3:

                        Instantiate(prehab, three.transform.position, prehab.transform.rotation);

                        break;


                }
            
     

       int timep=Random.Range(times,timem);

            switch (timep)
            {

                case 1:

                    tim =5.0f;

                    break;

                case 2:

                    tim = 4.5f;

                    break;

                case 3:

                    tim = 4.0f;

                    break;

                case 4:

                    tim = 3.5f;

                    break;

                case 5:

                    tim = 3.0f;

                    break;

                case 6:

                    tim = 2.5f;

                    break;

                case 7:

                    tim = 2.0f;

                    break;

            }


        }
    }
}


	

