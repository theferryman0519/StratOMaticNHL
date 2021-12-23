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

public class EnableObjects10B : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image ContinueButton;

	// Scoreboard Objects
	public Image ScoreboardBackground;
	public Text P1Score;
	public Text P2Score;
	public Text P1Shots;
	public Text P2Shots;
	public Text Period;
	public Text Play;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string PlayerGoal;
	public static string PlayerAssistA;
	public static string PlayerAssistB;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMainObjects();
		EnableScoreboardObjects();
		UpdatePlayerNames();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingScoreboard();
		UpdatingActionText();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
		ContinueButton.enabled = true;
	}

	public void EnableScoreboardObjects() {
		ScoreboardBackground.enabled = true;
		P1Score.enabled = true;
		P2Score.enabled = true;
		P1Shots.enabled = true;
		P2Shots.enabled = true;
		Period.enabled = true;
		Play.enabled = true;
	}

// --------------- DISABLING OBEJCTS FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ActionText.enabled = false;
		ContinueButton.enabled = false;
	}

	public void DisableScoreboardObjects() {
		ScoreboardBackground.enabled = false;
		P1Score.enabled = false;
		P2Score.enabled = false;
		P1Shots.enabled = false;
		P2Shots.enabled = false;
		Period.enabled = false;
		Play.enabled = false;
	}

// --------------- UPDATING TEXT FUNCTIONS ---------------
	public void UpdatingScoreboard() {
		P1Score.text = PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.GameplayP1Score;
		P2Score.text = PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.GameplayP2Score;
		P1Shots.text = PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.GameplayP1Shots + " shots";
		P2Shots.text = PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.GameplayP2Shots + " shots";
		Play.text = "Play: " + PlayerDatabase.GameplayPlay;

		if (PlayerDatabase.GameplayPeriod == "1") {
			Period.text = "1st Period";
		}

		else if (PlayerDatabase.GameplayPeriod == "2") {
			Period.text = "2nd Period";
		}

		else if (PlayerDatabase.GameplayPeriod == "3") {
			Period.text = "3rd Period";
		}

		else if (PlayerDatabase.GameplayPeriod == "4") {
			Period.text = "Overtime";
		}

		else if (PlayerDatabase.GameplayPeriod == "5") {
			Period.text = "Shootout";
		}
	}

	public void UpdatingLines() {
		if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 0) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 10)) {
			PlayerDatabase.GameplayLine = "F1D1";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 10) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 12)) {
			PlayerDatabase.GameplayLine = "F2D1";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 12) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 19)) {
			PlayerDatabase.GameplayLine = "F2D2";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 19) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 25)) {
			PlayerDatabase.GameplayLine = "F3D2";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 19) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 25)) {
			PlayerDatabase.GameplayLine = "F3D2";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 25) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 26)) {
			PlayerDatabase.GameplayLine = "F3D3";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 26) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 31)) {
			PlayerDatabase.GameplayLine = "F4D3";
		}
	}

	public void UpdatingActionText() {
		// Unassisted
		if ((PlayerAssistA == "None") && (PlayerAssistB == "None")) {
			ActionText.text = "We have a good goal!" + "\n\n" + "Goal scored by " + PlayerGoal + "\n\n" + "The goal was unassisted";
		}

		// 1 Assist
		else if ((PlayerAssistA != "None") && (PlayerAssistB == "None")) {
			ActionText.text = "We have a good goal!" + "\n\n" + "Goal scored by " + PlayerGoal + "\n\n" + "The goal was assisted by " + PlayerAssistA;
		}

		// 2 Assist
		else if ((PlayerAssistA != "None") && (PlayerAssistB != "None")) {
			ActionText.text = "We have a good goal!" + "\n\n" + "Goal scored by " + PlayerGoal + "\n\n" + "The goal was assisted by " + PlayerAssistA + " and by " + PlayerAssistB;
		}
	}

	public void UpdatePlayerNames() {
		// Goal Scorer
		if (PlayerDatabase.GameplayGoalScorer == "P1C1") {
			PlayerGoal = PlayerDatabase.P1C1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1C2") {
			PlayerGoal = PlayerDatabase.P1C2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1C3") {
			PlayerGoal = PlayerDatabase.P1C3;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1C4") {
			PlayerGoal = PlayerDatabase.P1C4;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1LW1") {
			PlayerGoal = PlayerDatabase.P1LW1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1LW2") {
			PlayerGoal = PlayerDatabase.P1LW2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1LW3") {
			PlayerGoal = PlayerDatabase.P1LW3;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1LW4") {
			PlayerGoal = PlayerDatabase.P1LW4;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1RW1") {
			PlayerGoal = PlayerDatabase.P1RW1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1RW2") {
			PlayerGoal = PlayerDatabase.P1RW2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1RW3") {
			PlayerGoal = PlayerDatabase.P1RW3;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1RW4") {
			PlayerGoal = PlayerDatabase.P1RW4;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1LD1") {
			PlayerGoal = PlayerDatabase.P1LD1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1LD2") {
			PlayerGoal = PlayerDatabase.P1LD2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1LD3") {
			PlayerGoal = PlayerDatabase.P1LD3;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1RD1") {
			PlayerGoal = PlayerDatabase.P1RD1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1RD2") {
			PlayerGoal = PlayerDatabase.P1RD2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P1RD3") {
			PlayerGoal = PlayerDatabase.P1RD3;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2C1") {
			PlayerGoal = PlayerDatabase.P2C1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2C2") {
			PlayerGoal = PlayerDatabase.P2C2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2C3") {
			PlayerGoal = PlayerDatabase.P2C3;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2C4") {
			PlayerGoal = PlayerDatabase.P2C4;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2LW1") {
			PlayerGoal = PlayerDatabase.P2LW1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2LW2") {
			PlayerGoal = PlayerDatabase.P2LW2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2LW3") {
			PlayerGoal = PlayerDatabase.P2LW3;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2LW4") {
			PlayerGoal = PlayerDatabase.P2LW4;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2RW1") {
			PlayerGoal = PlayerDatabase.P2RW1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2RW2") {
			PlayerGoal = PlayerDatabase.P2RW2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2RW3") {
			PlayerGoal = PlayerDatabase.P2RW3;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2RW4") {
			PlayerGoal = PlayerDatabase.P2RW4;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2LD1") {
			PlayerGoal = PlayerDatabase.P2LD1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2LD2") {
			PlayerGoal = PlayerDatabase.P2LD2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2LD3") {
			PlayerGoal = PlayerDatabase.P2LD3;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2RD1") {
			PlayerGoal = PlayerDatabase.P2RD1;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2RD2") {
			PlayerGoal = PlayerDatabase.P2RD2;
		}

		else if (PlayerDatabase.GameplayGoalScorer == "P2RD3") {
			PlayerGoal = PlayerDatabase.P2RD3;
		}

		else {
			PlayerGoal = "None";
		}

		// Assist A
		if (PlayerDatabase.GameplayAssistA == "P1C1") {
			PlayerAssistA = PlayerDatabase.P1C1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1C2") {
			PlayerAssistA = PlayerDatabase.P1C2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1C3") {
			PlayerAssistA = PlayerDatabase.P1C3;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1C4") {
			PlayerAssistA = PlayerDatabase.P1C4;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1LW1") {
			PlayerAssistA = PlayerDatabase.P1LW1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1LW2") {
			PlayerAssistA = PlayerDatabase.P1LW2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1LW3") {
			PlayerAssistA = PlayerDatabase.P1LW3;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1LW4") {
			PlayerAssistA = PlayerDatabase.P1LW4;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1RW1") {
			PlayerAssistA = PlayerDatabase.P1RW1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1RW2") {
			PlayerAssistA = PlayerDatabase.P1RW2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1RW3") {
			PlayerAssistA = PlayerDatabase.P1RW3;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1RW4") {
			PlayerAssistA = PlayerDatabase.P1RW4;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1LD1") {
			PlayerAssistA = PlayerDatabase.P1LD1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1LD2") {
			PlayerAssistA = PlayerDatabase.P1LD2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1LD3") {
			PlayerAssistA = PlayerDatabase.P1LD3;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1RD1") {
			PlayerAssistA = PlayerDatabase.P1RD1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1RD2") {
			PlayerAssistA = PlayerDatabase.P1RD2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P1RD3") {
			PlayerAssistA = PlayerDatabase.P1RD3;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2C1") {
			PlayerAssistA = PlayerDatabase.P2C1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2C2") {
			PlayerAssistA = PlayerDatabase.P2C2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2C3") {
			PlayerAssistA = PlayerDatabase.P2C3;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2C4") {
			PlayerAssistA = PlayerDatabase.P2C4;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2LW1") {
			PlayerAssistA = PlayerDatabase.P2LW1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2LW2") {
			PlayerAssistA = PlayerDatabase.P2LW2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2LW3") {
			PlayerAssistA = PlayerDatabase.P2LW3;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2LW4") {
			PlayerAssistA = PlayerDatabase.P2LW4;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2RW1") {
			PlayerAssistA = PlayerDatabase.P2RW1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2RW2") {
			PlayerAssistA = PlayerDatabase.P2RW2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2RW3") {
			PlayerAssistA = PlayerDatabase.P2RW3;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2RW4") {
			PlayerAssistA = PlayerDatabase.P2RW4;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2LD1") {
			PlayerAssistA = PlayerDatabase.P2LD1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2LD2") {
			PlayerAssistA = PlayerDatabase.P2LD2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2LD3") {
			PlayerAssistA = PlayerDatabase.P2LD3;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2RD1") {
			PlayerAssistA = PlayerDatabase.P2RD1;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2RD2") {
			PlayerAssistA = PlayerDatabase.P2RD2;
		}

		else if (PlayerDatabase.GameplayAssistA == "P2RD3") {
			PlayerAssistA = PlayerDatabase.P2RD3;
		}

		else {
			PlayerAssistA = "None";
		}

		// Assist B
		if (PlayerDatabase.GameplayAssistB == "P1C1") {
			PlayerAssistB = PlayerDatabase.P1C1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1C2") {
			PlayerAssistB = PlayerDatabase.P1C2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1C3") {
			PlayerAssistB = PlayerDatabase.P1C3;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1C4") {
			PlayerAssistB = PlayerDatabase.P1C4;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1LW1") {
			PlayerAssistB = PlayerDatabase.P1LW1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1LW2") {
			PlayerAssistB = PlayerDatabase.P1LW2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1LW3") {
			PlayerAssistB = PlayerDatabase.P1LW3;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1LW4") {
			PlayerAssistB = PlayerDatabase.P1LW4;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1RW1") {
			PlayerAssistB = PlayerDatabase.P1RW1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1RW2") {
			PlayerAssistB = PlayerDatabase.P1RW2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1RW3") {
			PlayerAssistB = PlayerDatabase.P1RW3;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1RW4") {
			PlayerAssistB = PlayerDatabase.P1RW4;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1LD1") {
			PlayerAssistB = PlayerDatabase.P1LD1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1LD2") {
			PlayerAssistB = PlayerDatabase.P1LD2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1LD3") {
			PlayerAssistB = PlayerDatabase.P1LD3;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1RD1") {
			PlayerAssistB = PlayerDatabase.P1RD1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1RD2") {
			PlayerAssistB = PlayerDatabase.P1RD2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P1RD3") {
			PlayerAssistB = PlayerDatabase.P1RD3;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2C1") {
			PlayerAssistB = PlayerDatabase.P2C1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2C2") {
			PlayerAssistB = PlayerDatabase.P2C2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2C3") {
			PlayerAssistB = PlayerDatabase.P2C3;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2C4") {
			PlayerAssistB = PlayerDatabase.P2C4;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2LW1") {
			PlayerAssistB = PlayerDatabase.P2LW1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2LW2") {
			PlayerAssistB = PlayerDatabase.P2LW2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2LW3") {
			PlayerAssistB = PlayerDatabase.P2LW3;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2LW4") {
			PlayerAssistB = PlayerDatabase.P2LW4;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2RW1") {
			PlayerAssistB = PlayerDatabase.P2RW1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2RW2") {
			PlayerAssistB = PlayerDatabase.P2RW2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2RW3") {
			PlayerAssistB = PlayerDatabase.P2RW3;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2RW4") {
			PlayerAssistB = PlayerDatabase.P2RW4;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2LD1") {
			PlayerAssistB = PlayerDatabase.P2LD1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2LD2") {
			PlayerAssistB = PlayerDatabase.P2LD2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2LD3") {
			PlayerAssistB = PlayerDatabase.P2LD3;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2RD1") {
			PlayerAssistB = PlayerDatabase.P2RD1;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2RD2") {
			PlayerAssistB = PlayerDatabase.P2RD2;
		}

		else if (PlayerDatabase.GameplayAssistB == "P2RD3") {
			PlayerAssistB = PlayerDatabase.P2RD3;
		}

		else {
			PlayerAssistB = "None";
		}

		// Duplicates
		if (PlayerAssistA == PlayerAssistB) {
			PlayerAssistB = "None";
		}

		if (PlayerGoal == PlayerAssistB) {
			PlayerAssistB = "None";
		}

		if (PlayerGoal == PlayerAssistA) {
			PlayerAssistA = PlayerAssistB;
			PlayerAssistB = "None";
		}

		// Different Teams
		if (PlayerDatabase.GameplayGoalScorer.Contains("P1")) {
			if (PlayerDatabase.GameplayAssistA.Contains("P1")) {
				if (PlayerDatabase.GameplayAssistB.Contains("P1")) {
					// Do Nothing
				}

				else {
					PlayerAssistB = "None";
				}
			}

			else {
				PlayerAssistB = "None";
				PlayerAssistA = "None";
			}
		}

		else if (PlayerDatabase.GameplayGoalScorer.Contains("P2")) {
			if (PlayerDatabase.GameplayAssistA.Contains("P2")) {
				if (PlayerDatabase.GameplayAssistB.Contains("P2")) {
					// Do Nothing
				}

				else {
					PlayerAssistB = "None";
				}
			}

			else {
				PlayerAssistB = "None";
				PlayerAssistA = "None";
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}