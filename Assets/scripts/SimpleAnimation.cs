using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SimpleAnimation : MonoBehaviour{
    
    
    public Animator AnimationSet;
	public Text InfoText;

    //public GameObject TriggerObject;

	void Start()
	{
		InfoText.enabled=false;
	}

    void OnTriggerStay(Collider other)
	{
		InfoText.enabled=true;
		if (Input.GetKeyDown(KeyCode.F))
        {
            print("F key was pressed");
			AnimationSet.SetTrigger("Open");
        }
	}

    void OnTriggerExit(Collider other)
	{
		 InfoText.enabled=false;
         print("You. Left");
		 AnimationSet.SetTrigger("Close");
	}
    
}