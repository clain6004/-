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

                    tim =16.0f;

                    break;

                case 2:

                    tim = 15.5f;

                    break;

                case 3:

                    tim =15.0f;

                    break;

                case 4:

                    tim = 14.5f;

                    break;

                case 5:

                    tim = 14.0f;

                    break;

                case 6:

                    tim = 13.5f;

                    break;

                case 7:

                    tim = 13.0f;

                    break;

                case 8:

                    tim = 12.5f;

                    break;

                case 9:

                    tim = 12.0f;

                    break;

                case 10:

                    tim = 11.5f;

                    break;

                case 11:

                    tim = 11.0f;

                    break;

                case 12:

                    tim = 10.5f;

                    break;

                case 13:

                    tim =10.0f;

                    break;

                case 14:

                    tim = 9.5f;

                    break;

                case 15:

                    tim = 9.0f;

                    break;

                case 16:

                    tim = 8.5f;

                    break;

                case 17:

                    tim = 8.0f;

                    break;

                case 18:

                    tim = 7.5f;

                    break;

                case 19:

                    tim = 7.0f;

                    break;

                case 20:

                    tim = 6.5f;

                    break;

                case 21:

                    tim = 6.0f;

                    break;

                case 22:

                    tim = 5.5f;

                    break;

                case 23:

                    tim = 5.0f;

                    break;

                case 24:

                    tim = 4.5f;

                    break;

                case 25:

                    tim = 4.0f;

                    break;

            }


        }
    }
}


	

