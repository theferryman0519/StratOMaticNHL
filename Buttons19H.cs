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

public class Buttons19H : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button ContinueButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene06LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// ContinueButton
		Button ContinueButtonClick = ContinueButton.GetComponent<Button>();
		ContinueButtonClick.onClick.AddListener(ContinueButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- BUTTON FUNCTIONS ---------------
	public void ContinueButtonClicking() {
		// Update All info
		Buttons19D.PowerplayShotTracker = 0;
		PlayerDatabase.GameplayPenaltyOnOff = "Off";
		PlayerDatabase.GameplayPenaltyType = "None";
		PlayerDatabase.GameplayPenaltyTeam = "None";
		PlayerDatabase.GameplayPenaltyPlayer = "None";

		// Go To Faceoff
		Scene06LoadRun.Scene06Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}