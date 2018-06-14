using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textcolor : MonoBehaviour {

    public Text anytext;

    float backcolor;

    float backcolor2;

    float backcolor3;

    float textcolors;

    float textcolors2;

    float textcolors3;

    float colortime = 1f;

    public float colortimemax = 0.01f;

    bool senceswich = false;

    bool fadeswich = true;

    public AudioClip audioClip;

    AudioSource audioSource;

    bool audiobool=false;

    float audiotime;

    // Use this for initialization
    void Start () {

        backcolor = GetComponent<RawImage>().color.r;

        backcolor2 = GetComponent<RawImage>().color.g;

        backcolor3 = GetComponent<RawImage>().color.b;

        textcolors = anytext.GetComponent<Text>().color.r;

        textcolors2 = anytext.GetComponent<Text>().color.g;

        textcolors3 = anytext.GetComponent<Text>().color.b;

        audioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

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

                audiobool = true;

                senceswich = true;


            }

            if (audiobool == true)
            {

                audiotime += Time.deltaTime;

                if (audiotime >= 0.1)
                {

                    audiobool = false;

                    audioSource.PlayOneShot(audioClip);

                }

            }

            if (senceswich)
            {

                colortime += colortimemax;

                if (colortime >= 1)
                {

                    colortime = 1;

                    SceneManager.LoadScene("Main");

                }

            }

        
        }

    GetComponent<RawImage>().color = new Color(backcolor, backcolor2, backcolor3, colortime);

            anytext.color = new Color(textcolors, textcolors2, textcolors3, Mathf.PingPong(Time.time, 1));

	}
}
