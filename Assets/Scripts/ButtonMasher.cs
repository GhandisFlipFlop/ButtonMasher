using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // Sound that will play when we click on the button
    public TextMesh ScoreText; //Display text for the player score
    private int ScoreLabel = 0; // Numeric Data values of our Score

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
        // Increase the player score by 1 point
        ScoreLabel = ScoreLabel + 1;
        // Update visual score
        ScoreText.text = ScoreLabel.ToString();
    } // End of onMouseDown()



} // End of ButtonMasher class
