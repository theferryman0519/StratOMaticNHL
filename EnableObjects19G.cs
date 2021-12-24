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

public class EnableObjects19G : MonoBehaviour {
		
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
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingScoreboard();

		if ((Buttons19D.PowerplayShotTracker == 1) && (EnableObjects19D.FinalShotSelection1.Contains("Breakaway"))) {
			ActionText.text = "Short-handed goal scored by " + EnableObjects19D.FinalShooterSelection1 + "\n\n" + "The goal was unassisted";
		}

		else if (Buttons19D.PowerplayShotTracker == 1) {
			ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection1 + "\n\n" + "The goal was unassisted";
		}

		else if ((Buttons19D.PowerplayShotTracker == 2) && (EnableObjects19D.FinalShotSelection1.Contains("Breakaway"))) {
			ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection2 + "\n\n" + "The goal was unassisted";
		}

		else if (Buttons19D.PowerplayShotTracker == 2) {
			if (EnableObjects19D.FinalShooterSelection2 == EnableObjects19D.FinalShooterSelection1) {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection2 + "\n\n" + "The goal was unassisted";
			}

			else {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection2 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection1;
			}
		}

		else if ((Buttons19D.PowerplayShotTracker == 3) && (EnableObjects19D.FinalShotSelection1.Contains("Breakaway"))) {
			if (EnableObjects19D.FinalShooterSelection3 == EnableObjects19D.FinalShooterSelection2) {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection3 + "\n\n" + "The goal was unassisted";
			}

			else {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection3 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection2;
			}
		}

		else if (Buttons19D.PowerplayShotTracker == 3) {
			if (EnableObjects19D.FinalShooterSelection3 == EnableObjects19D.FinalShooterSelection2) {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection3 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection1;
			}

			else if (EnableObjects19D.FinalShooterSelection3 == EnableObjects19D.FinalShooterSelection1) {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection3 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection2;
			}

			else {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection3 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection2 + " and by " + EnableObjects19D.FinalShooterSelection1;
			}
		}

		else if (Buttons19D.PowerplayShotTracker == 4) {
			if (EnableObjects19D.FinalShooterSelection4 == EnableObjects19D.FinalShooterSelection3) {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection4 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection2;
			}

			else if (EnableObjects19D.FinalShooterSelection4 == EnableObjects19D.FinalShooterSelection2) {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection3 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection3;
			}

			else {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection4 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection3 + " and by " + EnableObjects19D.FinalShooterSelection2;
			}
		}

		else if (Buttons19D.PowerplayShotTracker == 5) {
			if (EnableObjects19D.FinalShooterSelection5 == EnableObjects19D.FinalShooterSelection4) {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection5 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection3;
			}

			else if (EnableObjects19D.FinalShooterSelection5 == EnableObjects19D.FinalShooterSelection3) {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection5 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection4;
			}

			else {
				ActionText.text = "Powerplay goal scored by " + EnableObjects19D.FinalShooterSelection5 + "\n\n" + "Assisted by " + EnableObjects19D.FinalShooterSelection4 + " and by " + EnableObjects19D.FinalShooterSelection3;
			}
		}
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
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}