using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class startfede : MonoBehaviour
{

    float damegecolor;

    float damegecolor2;

    float damegecolor3;

    float colortime = 1f;

    public float colortimemax = 0.007f;

    float time_;

    public Text starttext;

    float textcolor;

    float textcolor2;

    float textcolor3;

    public float colortime2;

    public float colortimemax2;

    float counttime = 4.0f;

    public int counttime2;

    bool colorc=false;

    // Use this for initialization
    void Start()
    {

        damegecolor = GetComponent<RawImage>().color.r;

        damegecolor2 = GetComponent<RawImage>().color.g;

        damegecolor3 = GetComponent<RawImage>().color.b;

        textcolor = starttext.GetComponent<Text>().color.r;

        textcolor2 = starttext.GetComponent<Text>().color.g;

        textcolor3 = starttext.GetComponent<Text>().color.b;



    }

    // Update is called once per frame
    void Update()
    {

        time_ += Time.deltaTime;

        counttime -= Time.deltaTime;

      int counttime2 = (int)counttime;

        starttext.text = counttime2.ToString();

        if (time_ >= 4)
        {

            starttext.GetComponent<Text>().text = "GO";

        }
        if (time_ >= 5)
        {

            colortime -= colortimemax;

            if (colortime <= 0)
            {

                colortime = 0;

                bool colorc = true;
            }
        }

        starttext.GetComponent<Text>().color = new Color(textcolor, textcolor2, textcolor3, colortime);

        GetComponent<RawImage>().color = new Color(damegecolor, damegecolor2, damegecolor3, colortime);

        if (colorc)
        {


        }

    }
  
}
