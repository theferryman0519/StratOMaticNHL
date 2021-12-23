using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System.Data;
using System.IO;
using System.Net;

public class EnableObjects01C : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// All Objects
	public Image BackgroundImage;
	public Image MiniLogo;
	public Text ActionText;
	public Image BackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableAllObjects();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (Buttons01B.LogSignErrorInt == 1) {
			ActionText.text = "You have entered an incorrect Username. Please go back and enter a correct Username or Sign Up.";
		}

		else if (Buttons01B.LogSignErrorInt == 2) {
			ActionText.text = "You have entered a Username that has already been taken. If that is you, please enter it and Log In. If not, please enter a new Username that has not been used yet.";
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBJECTS FUNCTION ---------------
	public void EnableAllObjects() {
		BackgroundImage.enabled = true;
		MiniLogo.enabled = true;
		ActionText.enabled = true;
		BackButton.enabled = true;
	}

// --------------- DISABLING OBJECTS FUNCTION ---------------
	public void DisableAllObjects() {
		BackgroundImage.enabled = false;
		MiniLogo.enabled = false;
		ActionText.enabled = false;
		BackButton.enabled = false;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}