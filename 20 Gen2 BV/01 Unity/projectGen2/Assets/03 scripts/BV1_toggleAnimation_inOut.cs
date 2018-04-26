using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BV1_toggleAnimation_inOut : MonoBehaviour {

	// declare the anim
	public Animator anim;
	Ray ray;
	RaycastHit hit;



	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}


	// Update is called once per frame
	// playAnimation
	void Update () {

		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
			
		{
			if (hit.collider.name == "playAnimation") 
			{
				anim.Play ("21BV1cameraAnimation");
				//play bv1LightHeadOut
				anim.Play ("bv1LightHeadOut");
			}
		}
		
		//21BV1Animation_reset

		if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(1))

		{
			if (hit.collider.name == "playAnimation") 
			{
				anim.Play ("21BV1Animation_reset");
			}
		}

		
	}
}

