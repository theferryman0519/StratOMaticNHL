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

public class GameplayFaceoff : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int P1CFaceoffInt;
	public static int P2CFaceoffInt;
	public static int FaceoffSplitNumber;
	public static int FaceoffWinnerAnyInt;
	public static string FaceoffWinner;
	public static string FaceoffPlayerInt;
	public static string FaceoffComputerInt;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene07LoadRun;
	
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
// --------------- GAMEPLAY FUNCTION ---------------
    public void RunGameplayFaceoff() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			// Set P1C Faceoff
			if (PlayerDatabase.GameplayLine == "F1D1") {
				FaceoffPlayerInt = StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C1];
				FaceoffComputerInt = StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C1];
			}

			else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
				FaceoffPlayerInt = StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C2];
				FaceoffComputerInt = StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C2];
			}

			else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
				FaceoffPlayerInt = StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C3];
				FaceoffComputerInt = StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C3];
			}

			else if (PlayerDatabase.GameplayLine == "F4D3") {
				FaceoffPlayerInt = StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C4];
				FaceoffComputerInt = StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C4];
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			// Set P1C Faceoff
			if (PlayerDatabase.GameplayLine == "F1D1") {
				FaceoffPlayerInt = StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				FaceoffComputerInt = StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
			}

			else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
				FaceoffPlayerInt = StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				FaceoffComputerInt = StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
			}

			else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
				FaceoffPlayerInt = StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				FaceoffComputerInt = StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F4D3") {
				FaceoffPlayerInt = StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				FaceoffComputerInt = StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
			}
		}

		// Set Faceoff Int - Player
		if (FaceoffPlayerInt == "+3") {
			P1CFaceoffInt = 3;
		}

		else if (FaceoffPlayerInt == "+2") {
			P1CFaceoffInt = 2;
		}

		else if (FaceoffPlayerInt == "+1") {
			P1CFaceoffInt = 1;
		}

		else if (FaceoffPlayerInt == "0") {
			P1CFaceoffInt = 0;
		}

		// Set Faceoff Int - Computer
		if (FaceoffComputerInt == "+3") {
			P1CFaceoffInt = 3;
		}

		else if (FaceoffComputerInt == "+2") {
			P1CFaceoffInt = 2;
		}

		else if (FaceoffComputerInt == "+1") {
			P1CFaceoffInt = 1;
		}

		else if (FaceoffComputerInt == "0") {
			P1CFaceoffInt = 0;
		}

		// Randomize Split Card
		FaceoffSplitNumber = Random.Range(1,21);

		// Get Faceoff Winner
		if (FaceoffSplitNumber == 1) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 2) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 3) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 4) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 5) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 6) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 7) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 8) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 9) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 10) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 11) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 12) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 13) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 14) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P1ANY";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P2ANY";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 15) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 16) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 17) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P2LD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P1LD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 18) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P2RD";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P1RD";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 19) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P2LW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P1LW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}
		}

		else if (FaceoffSplitNumber == 20) {
			if ((P1CFaceoffInt - P2CFaceoffInt) == 3) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 2) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 1) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == 0) {
				FaceoffWinner = "P2RW";
				PlayerDatabase.StatsP2FaceoffsWon = PlayerDatabase.StatsP2FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -1) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -2) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}

			else if ((P1CFaceoffInt - P2CFaceoffInt) == -3) {
				FaceoffWinner = "P1RW";
				PlayerDatabase.StatsP1FaceoffsWon = PlayerDatabase.StatsP1FaceoffsWon + 1;
			}
		}

		// Set Any Players
		if (FaceoffWinner == "P1ANY") {
			FaceoffWinnerAnyInt = Random.Range(1,5);

			if (FaceoffWinnerAnyInt == 1) {
				FaceoffWinner = "P1LW";
			}

			else if (FaceoffWinnerAnyInt == 2) {
				FaceoffWinner = "P1RW";
			}

			else if (FaceoffWinnerAnyInt == 3) {
				FaceoffWinner = "P1LD";
			}

			else if (FaceoffWinnerAnyInt == 4) {
				FaceoffWinner = "P1RD";
			}
		}

		else if (FaceoffWinner == "P2ANY") {
			FaceoffWinnerAnyInt = Random.Range(1,5);

			if (FaceoffWinnerAnyInt == 1) {
				FaceoffWinner = "P2LW";
			}

			else if (FaceoffWinnerAnyInt == 2) {
				FaceoffWinner = "P2RW";
			}

			else if (FaceoffWinnerAnyInt == 3) {
				FaceoffWinner = "P2LD";
			}

			else if (FaceoffWinnerAnyInt == 4) {
				FaceoffWinner = "P2RD";
			}
		}

		// Set Specific Lines & Possession
		if (PlayerDatabase.GameplayLine == "F1D1") {
			// P1 Winner
			if (FaceoffWinner == "P1LW") {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (FaceoffWinner == "P1RW") {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (FaceoffWinner == "P1LD") {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (FaceoffWinner == "P1RD") {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			// P2 Winner
			if (FaceoffWinner == "P2LW") {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (FaceoffWinner == "P2RW") {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (FaceoffWinner == "P2LD") {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (FaceoffWinner == "P2RD") {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}
		}

		else if (PlayerDatabase.GameplayLine == "F2D1") {
			// P1 Winner
			if (FaceoffWinner == "P1LW") {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (FaceoffWinner == "P1RW") {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (FaceoffWinner == "P1LD") {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (FaceoffWinner == "P1RD") {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			// P2 Winner
			if (FaceoffWinner == "P2LW") {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (FaceoffWinner == "P2RW") {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (FaceoffWinner == "P2LD") {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (FaceoffWinner == "P2RD") {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}
		}

		else if (PlayerDatabase.GameplayLine == "F2D2") {
			// P1 Winner
			if (FaceoffWinner == "P1LW") {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (FaceoffWinner == "P1RW") {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (FaceoffWinner == "P1LD") {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (FaceoffWinner == "P1RD") {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			// P2 Winner
			if (FaceoffWinner == "P2LW") {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (FaceoffWinner == "P2RW") {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (FaceoffWinner == "P2LD") {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (FaceoffWinner == "P2RD") {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}
		}

		else if (PlayerDatabase.GameplayLine == "F3D2") {
			// P1 Winner
			if (FaceoffWinner == "P1LW") {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (FaceoffWinner == "P1RW") {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (FaceoffWinner == "P1LD") {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (FaceoffWinner == "P1RD") {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			// P2 Winner
			if (FaceoffWinner == "P2LW") {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (FaceoffWinner == "P2RW") {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (FaceoffWinner == "P2LD") {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (FaceoffWinner == "P2RD") {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}
		}

		else if (PlayerDatabase.GameplayLine == "F3D3") {
			// P1 Winner
			if (FaceoffWinner == "P1LW") {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (FaceoffWinner == "P1RW") {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (FaceoffWinner == "P1LD") {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (FaceoffWinner == "P1RD") {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			// P2 Winner
			if (FaceoffWinner == "P2LW") {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (FaceoffWinner == "P2RW") {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (FaceoffWinner == "P2LD") {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (FaceoffWinner == "P2RD") {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			// P1 Winner
			if (FaceoffWinner == "P1LW") {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (FaceoffWinner == "P1RW") {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (FaceoffWinner == "P1LD") {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (FaceoffWinner == "P1RD") {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			// P2 Winner
			if (FaceoffWinner == "P2LW") {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (FaceoffWinner == "P2RW") {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (FaceoffWinner == "P2LD") {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (FaceoffWinner == "P2RD") {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}
		}

		// Go to Faceoff Win Scene
		if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F1D1")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P1C1";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D1")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P1C2";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D2")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P1C2";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D2")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P1C3";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D3")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P1C3";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F4D3")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P1C4";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F1D1")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P2C1";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D1")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P2C2";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D2")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P2C2";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D2")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P2C3";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D3")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P2C3";
		}

		else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F4D3")) {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "P2C4";
		}

		PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
		Scene07LoadRun.Scene07Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}