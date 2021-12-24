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

public class Buttons19C : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button StartPowerplayButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene19DLoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// StartPowerplayButton
		Button StartPowerplayButtonClick = StartPowerplayButton.GetComponent<Button>();
		StartPowerplayButtonClick.onClick.AddListener(StartPowerplayButtonClicking);
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
	public void StartPowerplayButtonClicking() {
		// Set After PP Info
		PlayerDatabase.GameplayAssistA = "None";
		PlayerDatabase.GameplayAssistB = "None";
		PlayerDatabase.GameplayGoalScorer = "None";
		PlayerDatabase.GameplayPlay = (System.Int32.Parse(PlayerDatabase.GameplayPlay) + 2).ToString();

		if (System.Int32.Parse(PlayerDatabase.GameplayPlay) > 30) {
			PlayerDatabase.GameplayPlay = "30";
		}

		// Determine Shot Selections
		EnableObjects19D.SplitNumber = Random.Range(1,21);

		if (EnableObjects19D.SplitNumber == 1) {
            EnableObjects19D.DefenseRatingNeed = "LD2";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "Out";
            EnableObjects19D.YesShotSelection3 = "Out";
            EnableObjects19D.YesShotSelection4 = "In";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "C";
            EnableObjects19D.YesShooterSelection2 = "RW";
            EnableObjects19D.YesShooterSelection3 = "Any";
            EnableObjects19D.YesShooterSelection4 = "LW";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "In";
            EnableObjects19D.NoShotSelection4 = "In";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "LW";
            EnableObjects19D.NoShooterSelection2 = "RW";
            EnableObjects19D.NoShooterSelection3 = "RD";
            EnableObjects19D.NoShooterSelection4 = "LD";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 2) {
            EnableObjects19D.DefenseRatingNeed = "LD3";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "In";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "RW";
            EnableObjects19D.YesShooterSelection2 = "LW";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "In";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "LW";
            EnableObjects19D.NoShooterSelection2 = "RD";
            EnableObjects19D.NoShooterSelection3 = "RW";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 3) {
            EnableObjects19D.DefenseRatingNeed = "LD4";
            EnableObjects19D.YesShotSelection1 = "Break";
            EnableObjects19D.YesShotSelection2 = "In";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "LW";
            EnableObjects19D.YesShooterSelection2 = "Any";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "In";
            EnableObjects19D.NoShotSelection2 = "Reb";
            EnableObjects19D.NoShotSelection3 = "None";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "Any";
            EnableObjects19D.NoShooterSelection2 = "LW";
            EnableObjects19D.NoShooterSelection3 = "None";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 4) {
            EnableObjects19D.DefenseRatingNeed = "RD2";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "Out";
            EnableObjects19D.YesShotSelection3 = "Out";
            EnableObjects19D.YesShotSelection4 = "In";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "LD";
            EnableObjects19D.YesShooterSelection2 = "RD";
            EnableObjects19D.YesShooterSelection3 = "LW";
            EnableObjects19D.YesShooterSelection4 = "Any";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "In";
            EnableObjects19D.NoShotSelection4 = "In";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "LD";
            EnableObjects19D.NoShooterSelection2 = "RD";
            EnableObjects19D.NoShooterSelection3 = "RW";
            EnableObjects19D.NoShooterSelection4 = "C";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 5) {
            EnableObjects19D.DefenseRatingNeed = "RD3";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "In";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "LW";
            EnableObjects19D.YesShooterSelection2 = "RW";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "In";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "RW";
            EnableObjects19D.NoShooterSelection2 = "C";
            EnableObjects19D.NoShooterSelection3 = "LW";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 6) {
            EnableObjects19D.DefenseRatingNeed = "RD4";
            EnableObjects19D.YesShotSelection1 = "Break";
            EnableObjects19D.YesShotSelection2 = "In";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "RW";
            EnableObjects19D.YesShooterSelection2 = "C";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "In";
            EnableObjects19D.NoShotSelection2 = "Reb";
            EnableObjects19D.NoShotSelection3 = "None";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "LW";
            EnableObjects19D.NoShooterSelection2 = "C";
            EnableObjects19D.NoShooterSelection3 = "None";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 7) {
            EnableObjects19D.DefenseRatingNeed = "LW2";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "Out";
            EnableObjects19D.YesShotSelection3 = "Out";
            EnableObjects19D.YesShotSelection4 = "In";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "RW";
            EnableObjects19D.YesShooterSelection2 = "LW";
            EnableObjects19D.YesShooterSelection3 = "C";
            EnableObjects19D.YesShooterSelection4 = "C";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "In";
            EnableObjects19D.NoShotSelection4 = "In";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "RW";
            EnableObjects19D.NoShooterSelection2 = "C";
            EnableObjects19D.NoShooterSelection3 = "LW";
            EnableObjects19D.NoShooterSelection4 = "RW";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 8) {
            EnableObjects19D.DefenseRatingNeed = "LW3";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "In";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "C";
            EnableObjects19D.YesShooterSelection2 = "Any";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "In";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "C";
            EnableObjects19D.NoShooterSelection2 = "RW";
            EnableObjects19D.NoShooterSelection3 = "Any";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 9) {
            EnableObjects19D.DefenseRatingNeed = "LW4";
            EnableObjects19D.YesShotSelection1 = "Break";
            EnableObjects19D.YesShotSelection2 = "In";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "LD";
            EnableObjects19D.YesShooterSelection2 = "RW";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "In";
            EnableObjects19D.NoShotSelection2 = "Reb";
            EnableObjects19D.NoShotSelection3 = "None";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "C";
            EnableObjects19D.NoShooterSelection2 = "RW";
            EnableObjects19D.NoShooterSelection3 = "None";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 10) {
            EnableObjects19D.DefenseRatingNeed = "RW2";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "Out";
            EnableObjects19D.YesShotSelection3 = "Out";
            EnableObjects19D.YesShotSelection4 = "In";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "LW";
            EnableObjects19D.YesShooterSelection2 = "C";
            EnableObjects19D.YesShooterSelection3 = "RW";
            EnableObjects19D.YesShooterSelection4 = "RW";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "In";
            EnableObjects19D.NoShotSelection4 = "In";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "C";
            EnableObjects19D.NoShooterSelection2 = "LW";
            EnableObjects19D.NoShooterSelection3 = "C";
            EnableObjects19D.NoShooterSelection4 = "LW";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 11) {
            EnableObjects19D.DefenseRatingNeed = "RW3";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "In";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "Any";
            EnableObjects19D.YesShooterSelection2 = "C";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "In";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "LD";
            EnableObjects19D.NoShooterSelection2 = "LW";
            EnableObjects19D.NoShooterSelection3 = "C";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 12) {
            EnableObjects19D.DefenseRatingNeed = "RW4";
            EnableObjects19D.YesShotSelection1 = "Break";
            EnableObjects19D.YesShotSelection2 = "In";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "RD";
            EnableObjects19D.YesShooterSelection2 = "LW";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "In";
            EnableObjects19D.NoShotSelection2 = "Reb";
            EnableObjects19D.NoShotSelection3 = "None";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "RW";
            EnableObjects19D.NoShooterSelection2 = "Any";
            EnableObjects19D.NoShooterSelection3 = "None";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 13) {
            EnableObjects19D.DefenseRatingNeed = "1All4";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "Out";
            EnableObjects19D.YesShotSelection3 = "Out";
            EnableObjects19D.YesShotSelection4 = "In";
            EnableObjects19D.YesShotSelection5 = "In";
            EnableObjects19D.YesShooterSelection1 = "LW";
            EnableObjects19D.YesShooterSelection2 = "C";
            EnableObjects19D.YesShooterSelection3 = "Any";
            EnableObjects19D.YesShooterSelection4 = "RW";
            EnableObjects19D.YesShooterSelection5 = "Any";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "In";
            EnableObjects19D.NoShotSelection4 = "In";
            EnableObjects19D.NoShotSelection5 = "In";
            EnableObjects19D.NoShooterSelection1 = "LW";
            EnableObjects19D.NoShooterSelection2 = "Any";
            EnableObjects19D.NoShooterSelection3 = "C";
            EnableObjects19D.NoShooterSelection4 = "LD";
            EnableObjects19D.NoShooterSelection5 = "Any";
        }

        else if (EnableObjects19D.SplitNumber == 14) {
            EnableObjects19D.DefenseRatingNeed = "2All4";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "Out";
            EnableObjects19D.YesShotSelection3 = "In";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "LW";
            EnableObjects19D.YesShooterSelection2 = "RW";
            EnableObjects19D.YesShooterSelection3 = "RD";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "Out";
            EnableObjects19D.NoShotSelection4 = "In";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "RW";
            EnableObjects19D.NoShooterSelection2 = "LW";
            EnableObjects19D.NoShooterSelection3 = "C";
            EnableObjects19D.NoShooterSelection4 = "LW";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 15) {
            EnableObjects19D.DefenseRatingNeed = "3All4";
            EnableObjects19D.YesShotSelection1 = "In";
            EnableObjects19D.YesShotSelection2 = "None";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "LW";
            EnableObjects19D.YesShooterSelection2 = "None";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "In";
            EnableObjects19D.NoShotSelection3 = "None";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "C";
            EnableObjects19D.NoShooterSelection2 = "RW";
            EnableObjects19D.NoShooterSelection3 = "None";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 16) {
            EnableObjects19D.DefenseRatingNeed = "4All4";
            EnableObjects19D.YesShotSelection1 = "Break";
            EnableObjects19D.YesShotSelection2 = "None";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "LW";
            EnableObjects19D.YesShooterSelection2 = "None";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "None";
            EnableObjects19D.NoShotSelection2 = "None";
            EnableObjects19D.NoShotSelection3 = "None";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "None";
            EnableObjects19D.NoShooterSelection2 = "None";
            EnableObjects19D.NoShooterSelection3 = "None";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 17) {
            EnableObjects19D.DefenseRatingNeed = "1All4";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "Out";
            EnableObjects19D.YesShotSelection3 = "In";
            EnableObjects19D.YesShotSelection4 = "In";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "RW";
            EnableObjects19D.YesShooterSelection2 = "RD";
            EnableObjects19D.YesShooterSelection3 = "C";
            EnableObjects19D.YesShooterSelection4 = "Any";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "Out";
            EnableObjects19D.NoShotSelection4 = "In";
            EnableObjects19D.NoShotSelection5 = "In";
            EnableObjects19D.NoShooterSelection1 = "LD";
            EnableObjects19D.NoShooterSelection2 = "RW";
            EnableObjects19D.NoShooterSelection3 = "LW";
            EnableObjects19D.NoShooterSelection4 = "LD";
            EnableObjects19D.NoShooterSelection5 = "RD";
        }

        else if (EnableObjects19D.SplitNumber == 18) {
            EnableObjects19D.DefenseRatingNeed = "2All4";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "Out";
            EnableObjects19D.YesShotSelection3 = "In";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "C";
            EnableObjects19D.YesShooterSelection2 = "LD";
            EnableObjects19D.YesShooterSelection3 = "LD";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "Out";
            EnableObjects19D.NoShotSelection3 = "Out";
            EnableObjects19D.NoShotSelection4 = "In";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "RD";
            EnableObjects19D.NoShooterSelection2 = "C";
            EnableObjects19D.NoShooterSelection3 = "RW";
            EnableObjects19D.NoShooterSelection4 = "Any";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 19) {
            EnableObjects19D.DefenseRatingNeed = "3All4";
            EnableObjects19D.YesShotSelection1 = "Out";
            EnableObjects19D.YesShotSelection2 = "None";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "Any";
            EnableObjects19D.YesShooterSelection2 = "None";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "Out";
            EnableObjects19D.NoShotSelection2 = "In";
            EnableObjects19D.NoShotSelection3 = "None";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "Any";
            EnableObjects19D.NoShooterSelection2 = "RD";
            EnableObjects19D.NoShooterSelection3 = "None";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }

        else if (EnableObjects19D.SplitNumber == 20) {
            EnableObjects19D.DefenseRatingNeed = "4All4";
            EnableObjects19D.YesShotSelection1 = "Break";
            EnableObjects19D.YesShotSelection2 = "None";
            EnableObjects19D.YesShotSelection3 = "None";
            EnableObjects19D.YesShotSelection4 = "None";
            EnableObjects19D.YesShotSelection5 = "None";
            EnableObjects19D.YesShooterSelection1 = "RW";
            EnableObjects19D.YesShooterSelection2 = "None";
            EnableObjects19D.YesShooterSelection3 = "None";
            EnableObjects19D.YesShooterSelection4 = "None";
            EnableObjects19D.YesShooterSelection5 = "None";
            EnableObjects19D.NoShotSelection1 = "None";
            EnableObjects19D.NoShotSelection2 = "None";
            EnableObjects19D.NoShotSelection3 = "None";
            EnableObjects19D.NoShotSelection4 = "None";
            EnableObjects19D.NoShotSelection5 = "None";
            EnableObjects19D.NoShooterSelection1 = "None";
            EnableObjects19D.NoShooterSelection2 = "None";
            EnableObjects19D.NoShooterSelection3 = "None";
            EnableObjects19D.NoShooterSelection4 = "None";
            EnableObjects19D.NoShooterSelection5 = "None";
        }
		
		Scene19DLoadRun.Scene19DLoad();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}