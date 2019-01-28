using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HologramInteraction : MonoBehaviour{
    
    public GameObject AssignedBuildingArea;
	public Light AssignedLight; 
	public Material basematerial;
	public Material highlightmaterial;

	//have a bool for either material. 
	//on mouse click on one of the displays assigned area switches materials. 
	//light intensity ebbs and fades. 
	//One turns on, others turn off. 
	//event? 

	void OnMouseDown()
	{
		
	}
	  
}