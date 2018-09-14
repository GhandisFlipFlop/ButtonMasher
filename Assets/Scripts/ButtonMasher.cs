using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // Sound that will play when we click on the button 

	// Use this for initialization
	    void Start () {

        Debug.Log("Start method was called");

    } // End of Start()

    // Update is called once per frame
        void Update () {

        Debug.Log("Update method was called ");

    } // End of Update()


    // Responds to event from Unity that the object has been clicked
    private void OnMouseDown()
    {
        Debug.Log("onMouseDown method was called");
        // Trigger our click sound causing buttonClick audio to play
        clickSound.Play();

    } // End of onMouseDown()

} // End of ButtonMasher class
