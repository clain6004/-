using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class js : MonoBehaviour {

    public float time1;

    public float time2=15f;

    public int time3 = 14;

    static public int life;

    static public bool timeswich = false;

    public RawImage [] rawImage=new RawImage[2];

    float [] damegecolor=new float[3];

    float colortime=0;


    public float colortimemax = 0.005f;


    public AudioClip audioC;

    AudioSource audioSource;

    bool audioclipbool=true;

    bool[] texturebool=new bool[2];

    // Use this for initialization
    void Start () {

        damegecolor[0] = rawImage[0].GetComponent<RawImage>().color.a;

        damegecolor[1] = rawImage[0].GetComponent<RawImage>().color.g;

        damegecolor[2] = rawImage[0].GetComponent<RawImage>().color.b;

        life = 4;

        ds.timem = 3;

        audioSource = GetComponent<AudioSource>();      

        for(int i = 0; i < 2; i++)
        {

            texturebool[i] = false;

        }

	}
	
	// Update is called once per frame
	void Update () {

        time1 += Time.deltaTime;

        if (time1>time2)
        {

            if (ds.times < 14)
            {

                time1 = 0f;

                ds.timem += 1;

                ds.times += 1;

            }

        }

        if (life==1) 
        {


            colortime += colortimemax;

            if (audioclipbool == true)
            {

                audioclipbool = false;

                audioSource.PlayOneShot(audioC);

            }
      
            rawImage[0].GetComponent<RawImage>().color = new Color(damegecolor[0],damegecolor[1],damegecolor[2], colortime);

            if (colortime >= 1)
            {

                texturebool[0] = true;
                
            }

        }

        if (texturebool[0] == true)
        {

            SceneManager.LoadScene("gameover2");

        }

    }
}
