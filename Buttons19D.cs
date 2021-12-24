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

public class Buttons19D : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button ShotButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int PowerplayShotTracker;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene19ELoadRun;
	public SceneChange Scene19HLoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        PowerplayShotTracker = 1;

		// ShotButton
		Button ShotButtonClick = ShotButton.GetComponent<Button>();
		ShotButtonClick.onClick.AddListener(ShotButtonClicking);
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
	public void ShotButtonClicking() {
		if (EnableObjects19D.FinalShotSelection1 == "None") {
			Scene19HLoadRun.Scene19HLoad();
		}

		else if (EnableObjects19D.FinalShotSelection1 != "None") {
			Scene19ELoadRun.Scene19ELoad();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}