using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class fade : MonoBehaviour {

    float damegecolor;

    float damegecolor2;

    float damegecolor3;

  static public float colortime;

  public float colortimemax=30f;

    // Use this for initialization
    void Start () {

        damegecolor = GetComponent<RawImage>().color.r;

        damegecolor2 = GetComponent<RawImage>().color.g;

        damegecolor3 = GetComponent<RawImage>().color.b;

        GetComponent<RawImage>().color= new Color(0, 0, 0, 0f); 

    }
	
	// Update is called once per frame
	void Update () {


        if (cs.danegeswich == true)
        {

            colortime +=  colortimemax;

GetComponent<RawImage>().color = new Color(damegecolor, damegecolor2, damegecolor3, colortime);

            if(colortime>=1)

            cs.danegeswich = false;

        }else if (cs.danegeswich == false)
        {

            colortime -= colortimemax;

            GetComponent<RawImage>().color = new Color(damegecolor, damegecolor2, damegecolor3, colortime);

            if (colortime <= 0)
            {

                colortime = 0;

            }

        }

  
        
        }

	}

