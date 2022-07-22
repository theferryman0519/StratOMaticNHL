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

public class GameplayGoal : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int GoalInt;
	public static int RandomizeSplitNumber;
	public static int AddedGoal;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene10BLoadRun;
	public SceneChange Scene10CLoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void RunGameplayGoal() {
		// Randomize Split Number
		RandomizeSplitNumber = Random.Range(1,21);

		if (RandomizeSplitNumber <= GoalInt) {
			if ((PlayerDatabase.GameplayPossession != "P1G") && (PlayerDatabase.GameplayPossession != "P2G")) {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					AddedGoal = System.Int32.Parse(PlayerDatabase.GameplayP1Score);
					AddedGoal = AddedGoal + 1;
					PlayerDatabase.GameplayP1Score = AddedGoal.ToString();
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					AddedGoal = System.Int32.Parse(PlayerDatabase.GameplayP2Score);
					AddedGoal = AddedGoal + 1;
					PlayerDatabase.GameplayP2Score = AddedGoal.ToString();
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P1G") {
				AddedGoal = System.Int32.Parse(PlayerDatabase.GameplayP2Score);
				AddedGoal = AddedGoal + 1;
				PlayerDatabase.GameplayP2Score = AddedGoal.ToString();
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				AddedGoal = System.Int32.Parse(PlayerDatabase.GameplayP1Score);
				AddedGoal = AddedGoal + 1;
				PlayerDatabase.GameplayP1Score = AddedGoal.ToString();
			}

			Scene10BLoadRun.Scene10BLoad();
		}

		else {
			Scene10CLoadRun.Scene10CLoad();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}