using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
// for light script using UnityEngine.Events;
public class HologramInteraction : MonoBehaviour{

	public List<GameObject> HighlightObjects;
	public int HighlightAmount = 1;
	public Light AssignedLight; 
	public Material basematerial;
	public Material highlightmaterial;
	private Dictionary<Renderer, Material> MatLibrary;
	public Text InfoText; 

	//public UnityEvent lightActivate;

	//have a unity action to turn back all materials. 
	//on F Key press on one of the displays assigned area switches materials. 
	//light intensity ebbs and fades. 
	//One turns on, others turn off. 
	//event? 

	void start (){
		 print("Start ran");
		 //PopulateMaterials();
	}

	private void PopulateMaterials()
    {
		print("this ran");
        MatLibrary = new Dictionary<Renderer, Material>();

        foreach(GameObject obj in HighlightObjects)
        {
            MatLibrary.Add(obj.GetComponent<Renderer>(), obj.GetComponent<Renderer>().material);
        }
    }

	public void OnTriggerStay(Collider other) 
	{
		InfoText.enabled=true;
		if (Input.GetKeyDown(KeyCode.F))
        {
            print("F key was pressed");
			ActivateMaterials();
        }
		print("I'm In");
	}

	 void OnTriggerExit(Collider other)
	{
		 InfoText.enabled=false;
         print("You. Left");
	}

	public void ActivateMaterials() 
	{
		print("This is working");
		for (int i = 0; i < HighlightAmount; i++)
		{foreach(GameObject obj in HighlightObjects)
            {
                obj.GetComponent<Renderer>().material = highlightmaterial;
            }
		}
	}
	  
}