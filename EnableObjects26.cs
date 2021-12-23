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

public class EnableObjects26 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image ContinueButton;
	public Text P1LineupTitle;
	public Text P2LineupTitle;
	public Text P1PlayerA;
	public Text P1PlayerB;
	public Text P1PlayerC;
	public Text P2PlayerA;
	public Text P2PlayerB;
	public Text P2PlayerC;

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
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMainObjects();
		EnableScoreboardObjects();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingScoreboard();
		UpdatingPlayerLineups();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
		ContinueButton.enabled = true;
		P1LineupTitle.enabled = true;
		P2LineupTitle.enabled = true;
		P1PlayerA.enabled = true;
		P1PlayerB.enabled = true;
		P1PlayerC.enabled = true;
		P2PlayerA.enabled = true;
		P2PlayerB.enabled = true;
		P2PlayerC.enabled = true;
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
		P1LineupTitle.enabled = false;
		P2LineupTitle.enabled = false;
		P1PlayerA.enabled = false;
		P1PlayerB.enabled = false;
		P1PlayerC.enabled = false;
		P2PlayerA.enabled = false;
		P2PlayerB.enabled = false;
		P2PlayerC.enabled = false;
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

		if (System.Int32.Parse(PlayerDatabase.GameplayPlay) > 30) {
			PlayerDatabase.GameplayPlay = "0";
		}

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

	public void UpdatingPlayerLineups() {
		P1PlayerA.text = PlayerDatabase.P1C1.Replace(" ", "\n");
		P1PlayerB.text = PlayerDatabase.P1LW1.Replace(" ", "\n");
		P1PlayerC.text = PlayerDatabase.P1RW1.Replace(" ", "\n");
		P2PlayerA.text = PlayerDatabase.P2C1.Replace(" ", "\n");
		P2PlayerB.text = PlayerDatabase.P2LW1.Replace(" ", "\n");
		P2PlayerC.text = PlayerDatabase.P2RW1.Replace(" ", "\n");
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}