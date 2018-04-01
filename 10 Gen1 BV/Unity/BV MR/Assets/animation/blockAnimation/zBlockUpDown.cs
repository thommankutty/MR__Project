using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zBlockUpDown : MonoBehaviour {


    public Animator upDownAnim;
    // Use this for initialization
    void Start() {
        upDownAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown("q"))
        {
            upDownAnim.Play("blockAnimationUpDown");
        }
    } }
