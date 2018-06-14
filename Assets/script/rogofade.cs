using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rogofade : MonoBehaviour {

    float [] textcolor=new float[3];

    float [] textcolor2 = new float[3];

    float [] textcolor3 = new float[3];

    float[] backcolor = new float[5];

    float[] backcolor2 = new float[5];

    float[] backcolor3 = new float[5];

    float [] time_=new float[1];

    float [] colortime = new float[4];

    public float colortimemax = 0.007f;

    public RawImage[] rawImages = new RawImage[3];

    public Text[] texts = new Text[5];

    public float fedetime=1.0f;

 public AudioClip se;

    public AudioClip se2;

    bool [] rogoswich =new bool[4];

    bool [] inputswich=new bool[4];

    bool[] senceswich=new bool[4];

    public AudioClip rogoodio;

    public AudioClip rogoodio2;

    bool audiobool=false;

    bool audiobool2 = false;

    float audiotime;

    float audiotime2;

    AudioSource audioSource;

    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();

        for (int i = 0; i < 3; i++)
        {

            textcolor[i] = rawImages[i].GetComponent<RawImage>().color.r;

            textcolor2[i] = rawImages[i].GetComponent<RawImage>().color.g;

            textcolor3[i] = rawImages[i].GetComponent<RawImage>().color.b;

        }

        for (int i = 0; i <= 4; i++)
        {

            backcolor[i] = texts[i].GetComponent<Text>().color.r;

            backcolor2[i] = texts[i].GetComponent<Text>().color.g;

            backcolor3[i] = texts[i].GetComponent<Text>().color.b;

        }

        for (int i = 0; i <= 3; i++)
        {

            colortime[i] = 0.0f;

        }


        for (int i=0; i < 3; i++)
        {
            rogoswich[i] = false;

            inputswich[i] = false;

            senceswich[i] = false;

        }
    }

    // Update is called once per frame
    void Update() {

        if (rogoswich[0] == false) {

            colortime[0] += colortimemax;

            audiobool = true;

            if (colortime[0] >= 1f)
            {

                    rogoswich[0] = true;

                audioSource.PlayOneShot(rogoodio);

                
            }

        } else
        {



            if (Input.anyKeyDown)
            {



                inputswich[0] = true;


            }

            if (inputswich[0] == true)
            {

                colortime[0] -= colortimemax;

                senceswich[0] = true;

            }

        }



        if (senceswich[0] == true)
        {

            if (rogoswich[1] == false)
            {

                time_[0] += Time.deltaTime;

                if (time_[0] >= 3)
                {

                    colortime[1] += colortimemax;

                }

                if (colortime[1] >= 1f)
                {

 time_[0] = 0;
                    rogoswich[1] = true;

                    audioSource.PlayOneShot(rogoodio2);

                }

            }
            else
            {

                if (Input.anyKeyDown)
                {

                    inputswich[1] = true;


                }

                if (inputswich[1] == true)
                {

                    colortime[1] -= colortimemax;

                    senceswich[1] = true;

                }

            }

        }

        if (senceswich[1] == true)
        {

            if (rogoswich[2] == false)
            {

                

                time_[0] += Time.deltaTime;

                if (time_[0] >= 3)
                {

                    audiobool2 = true;

                    colortime[2] += colortimemax;

                }

                if (colortime[2] >= 1f)
                {

                    rogoswich[2] = true;

                }

            }
            else
            {

                if (Input.anyKeyDown)
                {

                    inputswich[2] = true;


                }

                if (inputswich[2] == true)
                {

                    colortime[2] -= colortimemax;

                    senceswich[2] = true;



                }

            }

        }

        if (senceswich[2] == true)
        {

            if (rogoswich[3] == false)
            {

                colortime[3] += colortimemax;

                if (colortime[3] >= 1f)
                {

                    rogoswich[3] = true;

                }

            }
            else
            {

                SceneManager.LoadScene("title");

            }

        }

        for (int i = 0; i < 2; i++) { 

        rawImages[i].GetComponent<RawImage>().color = new Color(textcolor[i], textcolor2[i], textcolor3[i], colortime[i]);

    }

        rawImages[2].GetComponent<RawImage>().color = new Color(textcolor[2], textcolor2[2], textcolor3[2], colortime[3]);

        texts[0].GetComponent<Text>().color = new Color(backcolor[0], backcolor2[0], backcolor3[0], colortime[0]);

    for(int i = 1; i < 5; i++)
        {

            texts[i].GetComponent<Text>().color = new Color(backcolor[i], backcolor2[i], backcolor3[i], colortime[2]);

        }

        if (audiobool == true)
        {

            audiotime += Time.deltaTime;

            if (audiotime <= 0.1)
            {

                audiobool = false;

                audioSource.PlayOneShot(se);

                audiotime = 0;
            }
            }

        if (audiobool2 == true)
        {

            audiotime2 += Time.deltaTime;

            if (audiotime2 <= 0.04)
            {

                audiobool2 = false;

                audioSource.PlayOneShot(se2);
            }
        }

    }
}
