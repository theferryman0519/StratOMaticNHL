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

public class EnableObjects21 : MonoBehaviour {
		
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
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMainObjects();
		EnableScoreboardObjects();
		UpdatePeriodShots();
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
		if (Period.text == "1st Period") {
			ActionText.text = "The 1st period has ended with the score:" + "\n" + 
				PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.GameplayP1Score + "\n" + 
				PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.GameplayP2Score + "\n\n" +
				"The shots on goal for the period:" + "\n" + 
				PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.StatsP1ShotsPeriod1 + "\n" + 
				PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.StatsP2ShotsPeriod1;
		}

		else if (Period.text == "2nd Period") {
			ActionText.text = "The 2nd period has ended with the score:" + "\n" + 
				PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.GameplayP1Score + "\n" + 
				PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.GameplayP2Score + "\n\n" +
				"The shots on goal for the period:" + "\n" + 
				PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.StatsP1ShotsPeriod2 + " (" + PlayerDatabase.GameplayP1Shots + " total)" + "\n" + 
				PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.StatsP2ShotsPeriod2 + " (" + PlayerDatabase.GameplayP2Shots + " total)";
		}

		else if (Period.text == "3rd Period") {
			ActionText.text = "The 3rd period has ended with the score:" + "\n" + 
				PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.GameplayP1Score + "\n" + 
				PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.GameplayP2Score + "\n\n" +
				"The shots on goal for the period:" + "\n" + 
				PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.StatsP1ShotsPeriod3 + " (" + PlayerDatabase.GameplayP1Shots + " total)" + "\n" + 
				PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.StatsP2ShotsPeriod3 + " (" + PlayerDatabase.GameplayP2Shots + " total)";
		}
	}

	public void UpdatePeriodShots() {
		if (PlayerDatabase.GameplayPeriod == "1") {
			PlayerDatabase.StatsP1ShotsPeriod1 = System.Int32.Parse(PlayerDatabase.GameplayP1Shots);
			PlayerDatabase.StatsP2ShotsPeriod1 = System.Int32.Parse(PlayerDatabase.GameplayP2Shots);
		}

		else if (PlayerDatabase.GameplayPeriod == "2") {
			PlayerDatabase.StatsP1ShotsPeriod2 = System.Int32.Parse(PlayerDatabase.GameplayP1Shots) - PlayerDatabase.StatsP1ShotsPeriod1;
			PlayerDatabase.StatsP2ShotsPeriod2 = System.Int32.Parse(PlayerDatabase.GameplayP2Shots) - PlayerDatabase.StatsP2ShotsPeriod1;
		}

		else if (PlayerDatabase.GameplayPeriod == "3") {
			PlayerDatabase.StatsP1ShotsPeriod3 = System.Int32.Parse(PlayerDatabase.GameplayP1Shots) - PlayerDatabase.StatsP1ShotsPeriod1 - PlayerDatabase.StatsP1ShotsPeriod2;
			PlayerDatabase.StatsP2ShotsPeriod3 = System.Int32.Parse(PlayerDatabase.GameplayP2Shots) - PlayerDatabase.StatsP2ShotsPeriod1 - PlayerDatabase.StatsP2ShotsPeriod2;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}