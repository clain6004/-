using System.Collections;
using UnityEngine;

public class cs : MonoBehaviour {

    public float s=10.0f;
    public float gr=20.0f;
    public float jumped=8.0f;

    private Vector3 moveD=Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        CharacterController controller=GetComponent<CharacterController>();
        if(controller.isGrounded){

            moveD=new Vector3(Input.GetAxis("Horizontal"),0,0);
moveD=transform.TransformDirection(moveD);
            moveD*=s;
            if(Input.GetButton("Jump"))
            moveD.y=jumped;

            }

        moveD.y-=gr*Time.deltaTime;
        controller.Move(moveD*Time.deltaTime);

}




	}
