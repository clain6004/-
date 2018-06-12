using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class CUI : MonoBehaviour
{

    public Text timew;

    public Text life;

    [SerializeField]

    static public float ttime;

    [SerializeField]

    public int minue = 0;

    public float ttimeold;

    public string lifetext;

    float tiememax;

    public float swithtime = 3.0f;

    public Text score;

    float scoretime;

    static public int scoretime2;

   

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (js.timeswich==true)
        {

            ttime += Time.deltaTime;

            tiememax += Time.deltaTime;

            scoretime += Time.deltaTime;

            int scoretime2 = (int)scoretime * 10;

            if (ttime >= 60f)
            {

                minue++;

                ttime = ttime - 60;

            }

            if ((int)ttime != (int)ttimeold)
            {

                timew.GetComponent<Text>().text = minue.ToString("00") + ":" + ((int)ttime).ToString("00");

            }

            ttimeold = ttime;

            score.GetComponent<Text>().text = scoretime2.ToString();

            switch (js.life)
            {

                case 1:

                    lifetext = "";

                    break;

                case 2:

                    lifetext = "-";

                    break;

                case 3:

                    lifetext = "--";

                    break;

                case 4:

                    lifetext = "---";

                    break;

            }

            life.GetComponent<Text>().text = lifetext;

        }

    }
}

