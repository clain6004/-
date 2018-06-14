using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameovercs : MonoBehaviour {

    float [] backcolor=new float[3];

    float []  textcolors=new float[3];

    public Text anytext;

    float colortime = 1f;

    public float colortimemax = 0.01f;

    bool senceswich = false;

    bool fadeswich = true;

    static public float score;

    public Text scoretext;

    // Use this for initialization
    void Start () {

        backcolor[0] = GetComponent<RawImage>().color.r;

        backcolor [1]= GetComponent<RawImage>().color.g;

        backcolor[2] = GetComponent<RawImage>().color.b;

        textcolors [0]= anytext.GetComponent<Text>().color.r;

        textcolors [1]= anytext.GetComponent<Text>().color.g;

        textcolors [2]= anytext.GetComponent<Text>().color.b;

        score = CUI.scorerun();

    }
	
	// Update is called once per frame
	void Update () {

 

  scoretext.GetComponent<Text>().text =score.ToString();

        if (fadeswich == true) 
        {

            colortime -= colortimemax;

            if (colortime <= 0)
            {

                fadeswich = false;

                colortime = 0;

            }

        }
        else
        {

            if (Input.anyKey)
            {

                senceswich = true;

            }

            if (senceswich)
            {

                colortime += colortimemax;

                if (colortime >= 1)
                {

                    colortime = 1;

                    SceneManager.LoadScene("title");

                }

            }


        }

        GetComponent<RawImage>().color = new Color(backcolor[0], backcolor[1], backcolor[2], colortime);

        anytext.color = new Color(textcolors[0], textcolors[1], textcolors[2], Mathf.PingPong(Time.time, 1));

    }
}
