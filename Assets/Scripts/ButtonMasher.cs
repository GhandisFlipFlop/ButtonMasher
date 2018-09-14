using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // Sound that will play when we click on the button
    public AudioSource gameOverSound; // Sound that will play when the game time = 0
    public TextMesh ScoreText; //Display text for the player score
    public TextMesh TimerText; //Display text for the time remaining
    public float gameLength; // How many seconds will the game last
    public TextMesh MessageText; // Display a message to the player

    private float TimerLabel = 0; // Numeric Time Values for our remaining time
    private int ScoreLabel = 0; // Numeric Data values of our Score
    private bool gameRunning = false;

	// Use this for initialization
	    void Start () {

        Debug.Log("Start method was called");
        

    } // End of Start()

    // Update is called once per frame
        void Update () {

        Debug.Log("Update method was called ");
        
        // Update the numerical time remaining
        TimerLabel = TimerLabel - Time.deltaTime;

        // Update the visual time remaining
        TimerText.text = (Mathf.CeilToInt(TimerLabel)).ToString();

        // Check if we have run out of time
        if (TimerLabel <= 0)
        {
            if (gameRunning == true)
            {
                gameOverSound.Play();

                // show the player their score
                MessageText.text = " Time Up! You Scored = " + ScoreLabel.ToString();
            } // end of if gameRunning = true
            
            gameRunning = false;
            TimerLabel = 0;

        } // End of if statement when time <= 0

    } // End of Update()



    // Responds to event from Unity that the object has been clicked
    private void OnMouseDown()
    {
        Debug.Log("onMouseDown method was called");
        // Check if the game is still running
        if (gameRunning == true)
        {
            // Trigger our click sound causing buttonClick audio to play
            clickSound.Play();
            // Increase the player score by 1 point
            ScoreLabel = ScoreLabel + 1;
            // Update visual score
            ScoreText.text = ScoreLabel.ToString();
        } // End of if gameRunning
        else
        {
            // game is not running and we clicked button
            gameRunning = true;
            
            // set the timer to the full length of our game
            TimerLabel = gameLength;
            
            // tell the player what to do
            MessageText.text = "mash the button";

            // reset the score
            ScoreLabel = 0;

            //update visual score
            ScoreText.text = ScoreLabel.ToString();
        }
       
    } // End of onMouseDown()



} // End of ButtonMasher class
