﻿ using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupImperialist: MonoBehaviour {

	

	
     void OnTriggerEnter(Collider other) {
		 
		GameObject go2 = GameObject.Find("polySurface11");
		GunGlow gunglow = go2.GetComponent<GunGlow>(); 
		
		gunglow.baseColor = Color.red;
		gunglow.intensity = 3.0f;
		//gunglow.mat.SetColor = ("_EmissionColor", Color.red);
		
		

		
		
        Destroy(gameObject);

     }
 }