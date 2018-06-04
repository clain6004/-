using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class CUI : MonoBehaviour {

    public GameObject unity;
   
    public Text time;

    public Text score;
    [SerializeField]
    public float ttime;
    [SerializeField]
    public int minue=0;

    public float ttimeold;

    public float sc=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ttime +=Time.deltaTime;

        sc += Time.deltaTime*100 ;

        if (ttime >= 60f)
        {

            minue++;

            ttime = ttime - 60;


        }

        if ((int)ttime != (int)ttimeold)
        {

            time.GetComponent<Text>().text = minue.ToString("00")+":"+((int)ttime).ToString("00");

        }

        ttimeold = ttime;

        score.GetComponent<Text>().text = sc.ToString();

	}
}
