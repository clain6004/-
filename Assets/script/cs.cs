﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class cs : MonoBehaviour
{

    public float s = 10.0f;
    public float gr = 20.0f;
    public float jumped = 8.0f;

    static public Vector3 moveD = Vector3.zero;

    CharacterController character;

    public float sliit = 1f;

    Animator ani;

    Vector3 characterCenter;

    float characterHeight;

    float slit = 0f;

    float timeswich;

    public float timemax = 2.0f;

    static public bool danegeswich;

    public AudioClip jampse;

    public AudioClip hitse;

    public AudioClip runse;

    AudioSource audioSource;

    int audioswich=0;

    bool audioswichbool=true;

    float setime;

    // Use this for initialization
    void Start()
    {

        character = GetComponent<CharacterController>();

        characterCenter = character.center;

        characterHeight = character.height;

        ani = GetComponent<Animator>();

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        setime+=Time.deltaTime;

        if (audioswichbool == true)
        {

            if (setime >= 2.5)
            {

                setime = 0;

                audioSource.PlayOneShot(runse);


            }

        }else if (audioswichbool == false)
        {

            switch (audioswich)
            {

                case 1:

  audioswichbool = true;

                    audioSource.PlayOneShot(jampse);

                    break;

                case 2:

                    audioswichbool = true;

                    audioSource.PlayOneShot(hitse);

                    break;

            }

        }

       

        timeswich += Time.deltaTime;

        bool isjump = Input.GetButton("Jump");

        bool isslli = Input.GetKey(KeyCode.DownArrow);

        ani.SetBool("IsGround", character.isGrounded);

        if (slit > 0)
        {

            slit -= Time.deltaTime;

        }

        ani.SetFloat("slif", slit);

        AnimatorStateInfo state = ani.GetCurrentAnimatorStateInfo(0);

        if (state.fullPathHash == Animator.StringToHash("base Layer.sli"))
        {

            Vector3 newcharacterCenter = characterCenter;

            newcharacterCenter.y *= 0.5f;

            character.center = newcharacterCenter;

            character.height = characterHeight * 0.5f;

        }
        else
        {

            character.center = characterCenter;

            character.height = characterHeight;

        }



        if (character.isGrounded)
        {

            moveD = new Vector3(Input.GetAxis("Horizontal") * 0.4f, 0, 0);

            moveD = transform.TransformDirection(moveD);

            moveD *= s;

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

                audioswich = 1;

                audioswichbool = false;

                moveD.y = jumped;

            }
        }

            moveD.y -= gr * Time.deltaTime;

            character.Move(moveD * Time.deltaTime);
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (js.life >= 2)
        {

            if (other.gameObject.tag == "d")
            {

                if (timeswich >= timemax)
                {

                    danegeswich = true;

                    timeswich = 0;

                    js.life -= 1;

                    audioswich = 2;

                    audioswichbool = false;

                }


                }      
            }

        }

    }

