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

public class EnableObjects19F : MonoBehaviour {
		
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
	public static string SaveOrLoss;
    public static string RandomLoss;
    public static string RandomSave;
    public static int RandomLossInt;
    public static int RandomSaveInt;
    public static string CurrentShooter;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMainObjects();
		EnableScoreboardObjects();
        RandomizeSaveLoss();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingScoreboard();
		DetermineShooter();

        if (SaveOrLoss == "Save") {
            ActionText.text = CurrentShooter + RandomSave;
        }

        else if (SaveOrLoss == "Loss") {
            ActionText.text = CurrentShooter + RandomLoss;
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

    public void RandomizeSaveLoss() {
        // Randomize Ints
        RandomLossInt = Random.Range(1,5);
        RandomSaveInt = Random.Range(1,4);

        // Determine Losses
        if (RandomLossInt == 1) {
            RandomLoss = " lost the puck to the defender before a shot was taken";
        }

        else if (RandomLossInt == 2) {
            RandomLoss = " was driven into the boards by a check without a shot being taken";
        }

        else if (RandomLossInt == 3) {
            RandomLoss = " shot the puck but missed and hit the outside of the net";
        }

        else if (RandomLossInt == 4) {
            RandomLoss = " shot the puck but was blocked by a diving defender";
        }

        // Determine Saves
        if (RandomSaveInt == 1) {
            RandomSave = " shot the puck but was stopped by the goalie's pad";
        }

        else if (RandomSaveInt == 2) {
            RandomSave = " shot the puck and was knocked away by the goalie's blocker";
        }

        else if (RandomSaveInt == 3) {
            RandomSave = " shot the puck but was turned away by the stick of the goalie";
        }
    }

    public void DetermineShooter() {
        if (Buttons19D.PowerplayShotTracker == 1) {
            CurrentShooter = EnableObjects19D.FinalShooterSelection1;
        }

        else if (Buttons19D.PowerplayShotTracker == 2) {
            CurrentShooter = EnableObjects19D.FinalShooterSelection2;
        }

        else if (Buttons19D.PowerplayShotTracker == 3) {
            CurrentShooter = EnableObjects19D.FinalShooterSelection3;
        }

        else if (Buttons19D.PowerplayShotTracker == 4) {
            CurrentShooter = EnableObjects19D.FinalShooterSelection4;
        }

        else if (Buttons19D.PowerplayShotTracker == 5) {
            CurrentShooter = EnableObjects19D.FinalShooterSelection5;
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}