using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class js : MonoBehaviour {

    public float time1;

    public float time2=4f;

    public int time3 = 14;

    static public int life;

    static public bool timeswich = false;

    // Use this for initialization
    void Start () {

        life = 4;

        ds.timem = 3;

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

            SceneManager.LoadScene("gameover");

        }

	}
}
