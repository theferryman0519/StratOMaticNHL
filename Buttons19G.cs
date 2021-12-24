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

public class Buttons19G : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button ContinueButton;
	public Text ActionText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int AddedGoal;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene19HLoadRun;
	public SceneChange Scene19ELoadRun;
	
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
		if (ActionText.text.Contains("Short-handed")) {
			if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
				AddedGoal = System.Int32.Parse(PlayerDatabase.GameplayP1Score);
				AddedGoal = AddedGoal + 1;
				PlayerDatabase.GameplayP1Score = AddedGoal.ToString();
			}

			else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
				AddedGoal = System.Int32.Parse(PlayerDatabase.GameplayP2Score);
				AddedGoal = AddedGoal + 1;
				PlayerDatabase.GameplayP2Score = AddedGoal.ToString();
			}

			Buttons19D.PowerplayShotTracker = 2;
			Scene19ELoadRun.Scene19ELoad();
		}

		else {
			if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
				AddedGoal = System.Int32.Parse(PlayerDatabase.GameplayP1Score);
				AddedGoal = AddedGoal + 1;
				PlayerDatabase.GameplayP1Score = AddedGoal.ToString();
			}

			else if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
				AddedGoal = System.Int32.Parse(PlayerDatabase.GameplayP2Score);
				AddedGoal = AddedGoal + 1;
				PlayerDatabase.GameplayP2Score = AddedGoal.ToString();
			}

			Scene19HLoadRun.Scene19HLoad();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}