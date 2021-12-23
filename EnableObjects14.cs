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

public class EnableObjects14 : MonoBehaviour {
		
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
	public static int LineChangeTime;
	
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
		LineChangeTime = 0;
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingScoreboard();
		UpdatingLines();
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
		if (PlayerDatabase.GameplayPlay == "10") {
			ActionText.text = "It's time for a forward line change." + "\n\n" + "Line 1 Forwards" + "\n" + "to" + "\n" + "Line 2 Forwards";
		}

		else if (PlayerDatabase.GameplayPlay == "12") {
			ActionText.text = "It's time for a defense line change." + "\n\n" + "Line 1 Defense" + "\n" + "to" + "\n" + "Line 2 Defense";
		}

		else if (PlayerDatabase.GameplayPlay == "19") {
			ActionText.text = "It's time for a forward line change." + "\n\n" + "Line 2 Forwards" + "\n" + "to" + "\n" + "Line 3 Forwards";
		}

		else if (PlayerDatabase.GameplayPlay == "25") {
			ActionText.text = "It's time for a defense line change." + "\n\n" + "Line 2 Defense" + "\n" + "to" + "\n" + "Line 3 Defense";
		}

		else if (PlayerDatabase.GameplayPlay == "26") {
			ActionText.text = "It's time for a forward line change." + "\n\n" + "Line 3 Forwards" + "\n" + "to" + "\n" + "Line 4 Forwards";
		}
	}

// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}