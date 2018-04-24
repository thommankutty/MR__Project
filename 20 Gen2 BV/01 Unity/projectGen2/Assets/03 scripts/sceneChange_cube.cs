using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange_cube : MonoBehaviour {



				Ray ray;
				RaycastHit hit;

				void Update()
				{
					ray = Camera.main.ScreenPointToRay(Input.mousePosition);
					if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
					{
			if (hit.collider.name == "playButton") 
						{
				SceneManager.LoadScene("00 welcomeScene");
						}
					}
				}
			}
