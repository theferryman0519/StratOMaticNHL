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

public class Buttons26D : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button ContinueButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int AddedRoundNumber;
	public static int AddedP1Score;
	public static int AddedP2Score;
	public static int AddedP1ShootoutGoal;
	public static int AddedP2ShootoutGoal;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene26BLoadRun;
	public SceneChange Scene21BLoadRun;
	
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
		if (EnableObjects26B.ShootoutTurnString == "P1") {
			AddedP1ShootoutGoal = System.Int32.Parse(PlayerDatabase.GameplayP1ShootoutGoals);
			AddedP1ShootoutGoal = AddedP1ShootoutGoal + 1;
			PlayerDatabase.GameplayP1ShootoutGoals = AddedP1ShootoutGoal.ToString();
			EnableObjects26B.ShootoutTurnString = "P2";
			Scene26BLoadRun.Scene26BLoad();
		}

		else if (EnableObjects26B.ShootoutTurnString == "P2") {
			if (EnableObjects26B.ShootoutRoundInt >= 3) {
				AddedP2ShootoutGoal = System.Int32.Parse(PlayerDatabase.GameplayP2ShootoutGoals);
				AddedP2ShootoutGoal = AddedP2ShootoutGoal + 1;
				PlayerDatabase.GameplayP2ShootoutGoals = AddedP2ShootoutGoal.ToString();
				
				if (System.Int32.Parse(PlayerDatabase.GameplayP1ShootoutGoals) == System.Int32.Parse(PlayerDatabase.GameplayP2ShootoutGoals)) {
					AddedRoundNumber = EnableObjects26B.ShootoutRoundInt;
					AddedRoundNumber = AddedRoundNumber + 1;
					EnableObjects26B.ShootoutRoundInt = AddedRoundNumber;
					EnableObjects26B.ShootoutTurnString = "P1";
					Scene26BLoadRun.Scene26BLoad();
				}

				else {
					if (System.Int32.Parse(PlayerDatabase.GameplayP1ShootoutGoals) > System.Int32.Parse(PlayerDatabase.GameplayP2ShootoutGoals)) {
						AddedP1Score = System.Int32.Parse(PlayerDatabase.GameplayP1Score);
						AddedP1Score = AddedP1Score + 1;
						PlayerDatabase.GameplayP1Score = AddedP1Score.ToString();
						PlayerDatabase.GameplayPlay = "0";
						PlayerDatabase.GameplayP1ShootoutGoals = "0";
						PlayerDatabase.GameplayP2ShootoutGoals = "0";
						PlayerDatabase.GameplayPeriod = "0";
						Scene21BLoadRun.Scene21BLoad();
					}

					else {
						AddedP2Score = System.Int32.Parse(PlayerDatabase.GameplayP2Score);
						AddedP2Score = AddedP2Score + 1;
						PlayerDatabase.GameplayP2Score = AddedP2Score.ToString();
						PlayerDatabase.GameplayPlay = "0";
						PlayerDatabase.GameplayP1ShootoutGoals = "0";
						PlayerDatabase.GameplayP2ShootoutGoals = "0";
						PlayerDatabase.GameplayPeriod = "0";
						Scene21BLoadRun.Scene21BLoad();
					}
				}
			}

			else if (EnableObjects26B.ShootoutRoundInt >= 18) {
				EnableObjects26B.ShootoutRoundInt = 0;
				PlayerDatabase.GameplayPlay = "0";
				PlayerDatabase.GameplayP1ShootoutGoals = "0";
				PlayerDatabase.GameplayP2ShootoutGoals = "0";
				PlayerDatabase.GameplayPeriod = "0";
				Scene21BLoadRun.Scene21BLoad();
			}

			else {
				AddedRoundNumber = EnableObjects26B.ShootoutRoundInt;
				AddedRoundNumber = AddedRoundNumber + 1;
				EnableObjects26B.ShootoutRoundInt = AddedRoundNumber;
				AddedP2ShootoutGoal = System.Int32.Parse(PlayerDatabase.GameplayP2ShootoutGoals);
				AddedP2ShootoutGoal = AddedP2ShootoutGoal + 1;
				PlayerDatabase.GameplayP2ShootoutGoals = AddedP2ShootoutGoal.ToString();
				EnableObjects26B.ShootoutTurnString = "P1";
				Scene26BLoadRun.Scene26BLoad();
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}