using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBehaviour : MonoBehaviour
{

    Animator m_Animator;
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
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.RightArrow))
        {
            //set to walk
            m_Animator.SetTrigger("walk");
        }
        else
        {
            m_Animator.SetTrigger("idle");
        }

    }
}
