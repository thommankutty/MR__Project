using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zAxisAnimationController : MonoBehaviour {

    public Animator armAnim;

    // testing for sounds
    public AudioClip musicClipOne;
    // public AudioClip musicClipTwo;
    public AudioSource musicSourceOne;
    // public AudioSource musicSourceTwo;

    // Use this for initialization
    void Start () {

        armAnim = GetComponent<Animator>();

        // testing 
        musicSourceOne.clip = musicClipOne;
        // musicSourceTwo.clip = musicClipTwo;
    }
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKeyDown("z"))
        {
            armAnim.Play("zAxisAnimation_out");

            // testing
            musicSourceOne.Play();
           // musicSourceTwo.Play();
        };

        if (Input.GetKeyDown("x"))
        {
            armAnim.Play("zAxisAnimationIn");
        }

    }
}
