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

public class EnableObjects01B : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// All Objects
	public Image BackgroundImage;
	public Image MiniLogo;
	public Text ActionText;
	public Text LogInUser;
	public Image LogInUserInput;
	public Text LogInUserPlace;
	public Text LogInUserText;
	public Image LogInButton;
	public Text SignUpUser;
	public Image SignUpUserInput;
	public Text SignUpUserPlace;
	public Text SignUpUserText;
	public Text SignUpName;
	public Image SignUpNameInput;
	public Text SignUpNamePlace;
	public Text SignUpNameText;
	public Image SignUpButton;
	
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
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBJECTS FUNCTION ---------------
	public void EnableAllObjects() {
		BackgroundImage.enabled = true;
		MiniLogo.enabled = true;
		ActionText.enabled = true;
		LogInUser.enabled = true;
		LogInUserInput.enabled = true;
		LogInUserPlace.enabled = true;
		LogInUserText.enabled = true;
		LogInButton.enabled = true;
		SignUpUser.enabled = true;
		SignUpUserInput.enabled = true;
		SignUpUserPlace.enabled = true;
		SignUpUserText.enabled = true;
		SignUpName.enabled = true;
		SignUpNameInput.enabled = true;
		SignUpNamePlace.enabled = true;
		SignUpNameText.enabled = true;
		SignUpButton.enabled = true;
	}

// --------------- DISABLING OBJECTS FUNCTION ---------------
	public void DisableAllObjects() {
		BackgroundImage.enabled = false;
		MiniLogo.enabled = false;
		ActionText.enabled = false;
		LogInUser.enabled = false;
		LogInUserInput.enabled = false;
		LogInUserPlace.enabled = false;
		LogInUserText.enabled = false;
		LogInButton.enabled = false;
		SignUpUser.enabled = false;
		SignUpUserInput.enabled = false;
		SignUpUserPlace.enabled = false;
		SignUpUserText.enabled = false;
		SignUpName.enabled = false;
		SignUpNameInput.enabled = false;
		SignUpNamePlace.enabled = false;
		SignUpNameText.enabled = false;
		SignUpButton.enabled = false;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}