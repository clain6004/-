using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class textjs : MonoBehaviour {

    int[] ranking = new int[3];

    static public int score;

    bool update=false;

    public Text[] text=new Text[3];

	// Use this for initialization
	void Start () {

        score = CUI.scoretime2;

	}
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < 3; i++)
        {

            ranking[i] = PlayerPrefs.GetInt("time" + i, score);

        }

        for (int i = 0; i < 3; i++)
        {

            if (update)
            {

                PlayerPrefs.SetInt("time"+i, ranking[i - 1]);
             

            }
           else if (score > ranking[i])
            {

                PlayerPrefs.SetInt("time" + i,score);

                update = true;

            }

            

        }

            text[0].text= PlayerPrefs.GetInt("time0",ranking[0]).ToString();

            text[1].text = PlayerPrefs.GetInt("time1", ranking[1]).ToString();

            text[2].text = PlayerPrefs.GetInt("time2", ranking[2]).ToString();

	}

   
}
