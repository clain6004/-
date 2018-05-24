using System.Collections;
using UnityEngine;

public class cs : MonoBehaviour {

    public float s=10.0f;
    public float gr=20.0f;
    public float jumped=8.0f;

    private Vector3 moveD=Vector3.zero;

    CharacterController a;

    public float sliit = 1f;

    Animator ani;

    Vector3 collc;

    float collh;

    float slit = 0f;


	// Use this for initialization
	void Start () {
		
        a=GetComponent<CharacterController>();

        collc = a.center;

        collh = a.height;

        ani = GetComponent<Animator>();



	}
	
	// Update is called once per frame
	void Update () {

        bool isjump = Input.GetKey(KeyCode.Space);

        bool isslli = Input.GetKey(KeyCode.DownArrow);

        ani.SetBool("IsGround",a.isGrounded);

        if (slit > 0)
        {

            slit -= Time.deltaTime;

        }

        ani.SetFloat("slif", slit);

        AnimatorStateInfo state = ani.GetCurrentAnimatorStateInfo(0);

        if(state.nameHash==Animator.StringToHash("base Layer.sli")) {

            Vector3 newa = collc;

            newa.y *= 0.5f;

            a.center = newa;

            a.height = collh * 0.5f;

        }
        else
        {

            a.center = collc;

            a.height = collh;

        }



        if(a.isGrounded){

            moveD =new Vector3(Input.GetAxis("Horizontal"),0,0);

moveD=transform.TransformDirection(moveD);

            moveD *=s;

            if (isjump)
            {

                ani.SetTrigger("JumpStart");

            }

            if (isslli && slit <= 0)
            {

                ani.SetTrigger("sli");

                slit = sliit;

                ani.SetFloat("slif", slit);

            }

            if (Input.GetButton("Jump"))
            {

                moveD.y = jumped;

            }
            }

        moveD.y-=gr*Time.deltaTime;

        a.Move(moveD*Time.deltaTime);

}




	}
