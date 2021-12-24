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

public class Buttons21 : MonoBehaviour {
		
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
	public SceneChange Scene21BLoadRun;
	public SceneChange Scene26LoadRun;
	
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
		if (PlayerDatabase.GameplayPeriod == "1") {
			PlayerDatabase.GameplayPeriod = "2";
			PlayerDatabase.GameplayPlay = "0";
			PlayerDatabase.GameplayAssistA = "None";
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayGoalScorer = "None";
			Scene06LoadRun.Scene06Load();
		}

		else if (PlayerDatabase.GameplayPeriod == "2") {
			PlayerDatabase.GameplayPeriod = "3";
			PlayerDatabase.GameplayPlay = "0";
			PlayerDatabase.GameplayAssistA = "None";
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayGoalScorer = "None";
			Scene06LoadRun.Scene06Load();
		}

		else if (PlayerDatabase.GameplayPeriod == "3") {
			// if (System.Int32.Parse(PlayerDatabase.GameplayP1Score) == System.Int32.Parse(PlayerDatabase.GameplayP2Score)) {
			// 	PlayerDatabase.GameplayAssistA = "None";
			// 	PlayerDatabase.GameplayAssistB = "None";
			// 	PlayerDatabase.GameplayGoalScorer = "None";
			// 	PlayerDatabase.GameplayPlay = "0";
			// 	PlayerDatabase.GameplayPeriod = "5";
			// 	Scene26LoadRun.Scene26Load();
			// }

			// else {
			// 	PlayerDatabase.GameplayAssistA = "None";
			// 	PlayerDatabase.GameplayAssistB = "None";
			// 	PlayerDatabase.GameplayGoalScorer = "None";
			// 	Scene21BLoadRun.Scene21BLoad();
			// }

			PlayerDatabase.GameplayAssistA = "None";
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayGoalScorer = "None";
			Scene21BLoadRun.Scene21BLoad();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}