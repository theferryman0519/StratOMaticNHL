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

public class Buttons05 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button StartGameButton;
	
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
		// StartGameButton
		Button StartGameButtonClick = StartGameButton.GetComponent<Button>();
		StartGameButtonClick.onClick.AddListener(StartGameButtonClicking);
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
    public void StartGameButtonClicking() {
		// Set Gameplay Information
		PlayerDatabase.GameplayPeriod = "1";
		PlayerDatabase.GameplayPlay = "0";
		PlayerDatabase.GameplayLine = "1";
		PlayerDatabase.GameplayPossession = "None";
		PlayerDatabase.GameplayP1Score = "0";
		PlayerDatabase.GameplayP2Score = "0";
		PlayerDatabase.GameplayP1Shots = "0";
		PlayerDatabase.GameplayP2Shots = "0";
		PlayerDatabase.GameplayPenaltyOnOff = "Off";
		PlayerDatabase.GameplayPenaltyType = "None";
		PlayerDatabase.GameplayPenaltyTeam = "None";
		PlayerDatabase.GameplayPenaltyPlayer = "None";
		PlayerDatabase.GameplayGoalScorer = "None";
		PlayerDatabase.GameplayAssistA = "None";
		PlayerDatabase.GameplayAssistB = "None";

		// Set Gameplay Stats
		PlayerDatabase.StatsP1FaceoffsWon = 0;
		PlayerDatabase.StatsP2FaceoffsWon = 0;
		PlayerDatabase.StatsP1Powerplays = 0;
		PlayerDatabase.StatsP2Powerplays = 0;
		PlayerDatabase.StatsP1ShotsPeriod1 = 0;
		PlayerDatabase.StatsP1ShotsPeriod2 = 0;
		PlayerDatabase.StatsP1ShotsPeriod3 = 0;
		PlayerDatabase.StatsP1ShotsPeriod4 = 0;
		PlayerDatabase.StatsP2ShotsPeriod1 = 0;
		PlayerDatabase.StatsP2ShotsPeriod2 = 0;
		PlayerDatabase.StatsP2ShotsPeriod3 = 0;
		PlayerDatabase.StatsP2ShotsPeriod4 = 0;
		ScoringDatabase.GoalList.Clear();
		ScoringDatabase.AssistListA.Clear();
		ScoringDatabase.AssistListB.Clear();

		// Start New Game
		Scene06LoadRun.Scene06Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}