using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class rogofade : MonoBehaviour {

    float [] textcolor=new float[2];

    float [] textcolor2 = new float[2];

    float [] textcolor3 = new float[2];

    float time_;

    float colortime = 1f;

    public float colortimemax = 0.007f;

    public RawImage[] rawImages = new RawImage[2];

    public Text[] texts = new Text[5];

    public float fedetime=1.0f;

    // Use this for initialization
    void Start () {

        textcolor[0] =rawImages[0].GetComponent<RawImage>().color.r;

        textcolor2[0] = rawImages[0].GetComponent<RawImage>().color.g;

        textcolor3[0] = rawImages[0].GetComponent<RawImage>().color.b;

    }
	
	// Update is called once per frame
	void Update () {

        colortime += colortimemax;

        if (colortime >= 1)
        {

            colortime = 1;

   time_ += Time.deltaTime;

            if (time_ >=fedetime)
            {



            }

        }

       rawImages[0].GetComponent<RawImage>().color = new Color(textcolor[0],textcolor2[0],textcolor3[0], colortime);

    }
}
