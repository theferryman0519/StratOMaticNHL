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

public class Buttons19F : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button ContinueButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int UpdatedShotTracker;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene19ELoadRun;
	public SceneChange Scene19HLoadRun;
	
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
		// Update Shot Tracker
		UpdatedShotTracker = Buttons19D.PowerplayShotTracker + 1;

		// Determine Next Shot
		if (UpdatedShotTracker == 2) {
			if (EnableObjects19D.FinalShotSelection2 == "None") {
				Scene19HLoadRun.Scene19HLoad();
			}

			else {
				Buttons19D.PowerplayShotTracker = UpdatedShotTracker;
				Scene19ELoadRun.Scene19ELoad();
			}
		}

		else if (UpdatedShotTracker == 3) {
			if (EnableObjects19D.FinalShotSelection3 == "None") {
				Scene19HLoadRun.Scene19HLoad();
			}

			else {
				Buttons19D.PowerplayShotTracker = UpdatedShotTracker;
				Scene19ELoadRun.Scene19ELoad();
			}
		}

		else if (UpdatedShotTracker == 4) {
			if (EnableObjects19D.FinalShotSelection4 == "None") {
				Scene19HLoadRun.Scene19HLoad();
			}

			else {
				Buttons19D.PowerplayShotTracker = UpdatedShotTracker;
				Scene19ELoadRun.Scene19ELoad();
			}
		}

		else if (UpdatedShotTracker == 5) {
			if (EnableObjects19D.FinalShotSelection5 == "None") {
				Scene19HLoadRun.Scene19HLoad();
			}

			else {
				Buttons19D.PowerplayShotTracker = UpdatedShotTracker;
				Scene19ELoadRun.Scene19ELoad();
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}