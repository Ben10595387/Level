using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SimpleAnimation : MonoBehaviour{
    
    public Animator OpenAnimation;
    public Animator CloseAnimation;
    //public GameObject TriggerObject;

    void OnTriggerEnter(Collider other)
	{
		OpenAnimation.SetTrigger("Open");
	}

    void OnTriggerExit(Collider other)
	{
		CloseAnimation.SetTrigger("Close");
	}
    
}