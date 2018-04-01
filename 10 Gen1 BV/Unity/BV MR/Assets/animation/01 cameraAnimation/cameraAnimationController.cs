using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAnimationController : MonoBehaviour {

    //declare the animator
    public Animator cameraAnim;
    // declare audio source
    public AudioClip cameraAudioClipOne;
    // public AudioClip cameraAudioClipTwo;
    public AudioSource cameraAudioSourceOne;
    // public AudioSource cameraAudioSourceTwo;


    // Use this for initialization
    void Start () {
        // get the component
        cameraAnim = GetComponent<Animator>();
        cameraAudioSourceOne.clip = cameraAudioClipOne;
        // cameraAudioSourceTwo.clip = cameraAudioClipTwo;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("a"))
        {
            cameraAnim.Play("cameraAnimationOut");

            cameraAudioSourceOne.Play();
            // cameraAudioSourceTwo.Play();
        };

        if (Input.GetKeyDown("s"))
        {
            cameraAnim.Play("cameraAnimationIn");
        }
		
	}
}
