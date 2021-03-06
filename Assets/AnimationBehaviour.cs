using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBehaviour : MonoBehaviour
{

    public Animator m_Animator;
    // Start is called before the first frame update

    //create controls to control demon model
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>(); //set animator
    }

    // Update is called once per frame
    void Update()
    {
        //if button pressed set trigger
        if (Input.GetKey(KeyCode.W))
        {
            //set to walk
            m_Animator.SetTrigger("walk");
        }
        else if (Input.GetKey(KeyCode.R))
        {
            //set to run
            m_Animator.SetTrigger("run");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //set to attack
            m_Animator.SetTrigger("attack");
        }
        else if (Input.GetKey(KeyCode.E))
        {
            //set to jump
            m_Animator.SetTrigger("jump");
        }
        else
        {
            m_Animator.SetTrigger("idle");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            //set to walk
            Application.Quit();
        }

    }
}


