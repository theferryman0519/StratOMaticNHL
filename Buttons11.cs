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

public class Buttons11 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button GoalieRatingButton;
	public Button PlayerBackButton;

	// Player Buttons
	public Button P1C;
	public Button P1LW;
	public Button P1RW;
	public Button P1LD;
	public Button P1RD;
	public Button P1G;
	public Button P2C;
	public Button P2LW;
	public Button P2RW;
	public Button P2LD;
	public Button P2RD;
	public Button P2G;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int RandomizeDiceRollA;
	public static int RandomizeDiceRollB;
	public static int RandomizeDiceRoll;
	public static int GetShotType;
	public static string GoalieRatingString;
	public static int RandomizeSkaterInt;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene08LoadRun;
	public SceneChange Scene10LoadRun;
	public SceneChange Scene19LoadRun;
	public SceneChange Scene22LoadRun;
	public SceneChange Scene23LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// GoalieRatingButton
		Button GoalieRatingButtonClick = GoalieRatingButton.GetComponent<Button>();
		GoalieRatingButtonClick.onClick.AddListener(GoalieRatingButtonClicking);

		// PlayerBackButton
		Button PlayerBackButtonClick = PlayerBackButton.GetComponent<Button>();
		PlayerBackButtonClick.onClick.AddListener(PlayerBackButtonClicking);

		// Player Buttons
		Button P1CClick = P1C.GetComponent<Button>();
		Button P1LWClick = P1LW.GetComponent<Button>();
		Button P1RWClick = P1RW.GetComponent<Button>();
		Button P1LDClick = P1LD.GetComponent<Button>();
		Button P1RDClick = P1RD.GetComponent<Button>();
		Button P1GClick = P1G.GetComponent<Button>();
		Button P2CClick = P2C.GetComponent<Button>();
		Button P2LWClick = P2LW.GetComponent<Button>();
		Button P2RWClick = P2RW.GetComponent<Button>();
		Button P2LDClick = P2LD.GetComponent<Button>();
		Button P2RDClick = P2RD.GetComponent<Button>();
		Button P2GClick = P2G.GetComponent<Button>();

		P1CClick.onClick.AddListener(P1CClicking);
		P1LWClick.onClick.AddListener(P1LWClicking);
		P1RWClick.onClick.AddListener(P1RWClicking);
		P1LDClick.onClick.AddListener(P1LDClicking);
		P1RDClick.onClick.AddListener(P1RDClicking);
		P1GClick.onClick.AddListener(P1GClicking);
		P2CClick.onClick.AddListener(P2CClicking);
		P2LWClick.onClick.AddListener(P2LWClicking);
		P2RWClick.onClick.AddListener(P2RWClicking);
		P2LDClick.onClick.AddListener(P2LDClicking);
		P2RDClick.onClick.AddListener(P2RDClicking);
		P2GClick.onClick.AddListener(P2GClicking);
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
	public void GoalieRatingButtonClicking() {
		// Randomize Dice Roll
		RandomizeDiceRollA = Random.Range(1,7);
		RandomizeDiceRollB = Random.Range(1,7);
		RandomizeDiceRoll = RandomizeDiceRollA + RandomizeDiceRollB;

		// Get Goalie Rating String
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (RandomizeDiceRoll == 2) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating02.PlayerGStatsGoalieRating02[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating02.PlayerGStatsGoalieRating02[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 3) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating03.PlayerGStatsGoalieRating03[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating03.PlayerGStatsGoalieRating03[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 4) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating04.PlayerGStatsGoalieRating04[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating04.PlayerGStatsGoalieRating04[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 5) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating05.PlayerGStatsGoalieRating05[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating05.PlayerGStatsGoalieRating05[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 6) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating06.PlayerGStatsGoalieRating06[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating06.PlayerGStatsGoalieRating06[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 7) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating07.PlayerGStatsGoalieRating07[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating07.PlayerGStatsGoalieRating07[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 8) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating08.PlayerGStatsGoalieRating08[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating08.PlayerGStatsGoalieRating08[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 9) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating09.PlayerGStatsGoalieRating09[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating09.PlayerGStatsGoalieRating09[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 10) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating10.PlayerGStatsGoalieRating10[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating10.PlayerGStatsGoalieRating10[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 11) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating11.PlayerGStatsGoalieRating11[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating11.PlayerGStatsGoalieRating11[PlayerDatabase.P2G];
				}
			}

			else if (RandomizeDiceRoll == 12) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating12.PlayerGStatsGoalieRating12[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating12.PlayerGStatsGoalieRating12[PlayerDatabase.P2G];
				}
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (RandomizeDiceRoll == 2) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating02.FrPlayerGStatsGoalieRating02[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating02.FrPlayerGStatsGoalieRating02[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 3) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating03.FrPlayerGStatsGoalieRating03[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating03.FrPlayerGStatsGoalieRating03[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 4) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating04.FrPlayerGStatsGoalieRating04[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating04.FrPlayerGStatsGoalieRating04[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 5) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating05.FrPlayerGStatsGoalieRating05[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating05.FrPlayerGStatsGoalieRating05[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 6) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating06.FrPlayerGStatsGoalieRating06[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating06.FrPlayerGStatsGoalieRating06[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 7) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating07.FrPlayerGStatsGoalieRating07[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating07.FrPlayerGStatsGoalieRating07[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 8) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating08.FrPlayerGStatsGoalieRating08[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating08.FrPlayerGStatsGoalieRating08[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 9) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating09.FrPlayerGStatsGoalieRating09[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating09.FrPlayerGStatsGoalieRating09[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 10) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating10.FrPlayerGStatsGoalieRating10[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating10.FrPlayerGStatsGoalieRating10[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 11) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating11.FrPlayerGStatsGoalieRating11[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating11.FrPlayerGStatsGoalieRating11[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (RandomizeDiceRoll == 12) {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					GoalieRatingString = GStatsGoalieRating12.FrPlayerGStatsGoalieRating12[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					GoalieRatingString = GStatsGoalieRating12.FrPlayerGStatsGoalieRating12[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}
		}

		// Determine Goalie Rating
		if (GoalieRatingString == "Breakaway") {
			RandomizeSkater();
			Scene22LoadRun.Scene22Load();
		}

		else if (GoalieRatingString == "Goal") {
			GameplayGoal.GoalInt = 20;
			Scene10LoadRun.Scene10Load();
		}

		else if (GoalieRatingString == "OUT: Breakaway / IRB: Goal") {
			if (GetShotType == 2) {
				RandomizeSkater();
				Scene22LoadRun.Scene22Load();
			}

			else if (GetShotType == 1) {
				GameplayGoal.GoalInt = 20;
				Scene10LoadRun.Scene10Load();
			}
		}

		else if (GoalieRatingString == "OUT: Breakaway / IRB: Penalty") {
			if (GetShotType == 2) {
				RandomizeSkater();
				Scene22LoadRun.Scene22Load();
			}

			else if (GetShotType == 1) {
				RandomizeSkater();
				Scene19LoadRun.Scene19Load();
			}
		}

		else if (GoalieRatingString == "OUT: Breakaway / IRB: Rebound") {
			if (GetShotType == 2) {
				RandomizeSkater();
				Scene22LoadRun.Scene22Load();
			}

			else if (GetShotType == 1) {
				Scene08LoadRun.Scene08Load();
			}
		}

		else if (GoalieRatingString == "OUT: Goal / IRB: Breakaway") {
			if (GetShotType == 2) {
				GameplayGoal.GoalInt = 20;
				Scene10LoadRun.Scene10Load();
			}

			else if (GetShotType == 1) {
				RandomizeSkater();
				Scene22LoadRun.Scene22Load();
			}
		}

		else if (GoalieRatingString == "OUT: Goal / IRB: Penalty") {
			if (GetShotType == 2) {
				GameplayGoal.GoalInt = 20;
				Scene10LoadRun.Scene10Load();
			}

			else if (GetShotType == 1) {
				RandomizeSkater();
				Scene19LoadRun.Scene19Load();
			}
		}

		else if (GoalieRatingString == "OUT: Goal / IRB: Rebound") {
			if (GetShotType == 2) {
				GameplayGoal.GoalInt = 20;
				Scene10LoadRun.Scene10Load();
			}

			else if (GetShotType == 1) {
				Scene08LoadRun.Scene08Load();
			}
		}

		else if (GoalieRatingString == "OUT: Penalty / IRB: Breakaway") {
			if (GetShotType == 2) {
				RandomizeSkater();
				Scene19LoadRun.Scene19Load();
			}

			else if (GetShotType == 1) {
				RandomizeSkater();
				Scene22LoadRun.Scene22Load();
			}
		}

		else if (GoalieRatingString == "OUT: Penalty / IRB: Goal") {
			if (GetShotType == 2) {
				RandomizeSkater();
				Scene19LoadRun.Scene19Load();
			}

			else if (GetShotType == 1) {
				GameplayGoal.GoalInt = 20;
				Scene10LoadRun.Scene10Load();
			}
		}

		else if (GoalieRatingString == "OUT: Penalty / IRB: Rebound") {
			if (GetShotType == 2) {
				RandomizeSkater();
				Scene19LoadRun.Scene19Load();
			}

			else if (GetShotType == 1) {
				Scene08LoadRun.Scene08Load();
			}
		}

		else if (GoalieRatingString == "OUT: Rebound / IRB: Breakaway") {
			if (GetShotType == 2) {
				Scene08LoadRun.Scene08Load();
			}

			else if (GetShotType == 1) {
				RandomizeSkater();
				Scene22LoadRun.Scene22Load();
			}
		}

		else if (GoalieRatingString == "OUT: Rebound / IRB: Goal") {
			if (GetShotType == 2) {
				Scene08LoadRun.Scene08Load();
			}

			else if (GetShotType == 1) {
				GameplayGoal.GoalInt = 20;
				Scene10LoadRun.Scene10Load();
			}
		}

		else if (GoalieRatingString == "OUT: Rebound / IRB: Penalty") {
			if (GetShotType == 2) {
				Scene08LoadRun.Scene08Load();
			}

			else if (GetShotType == 1) {
				RandomizeSkater();
				Scene19LoadRun.Scene19Load();
			}
		}

		else if (GoalieRatingString == "Penalty") {
			RandomizeSkater();
			Scene19LoadRun.Scene19Load();
		}

		else if (GoalieRatingString == "Rebound") {
			Scene08LoadRun.Scene08Load();
		}

		else if (GoalieRatingString == "Save, to Any") {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				PlayerDatabase.GameplayPossession = "P2";
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				PlayerDatabase.GameplayPossession = "P1";
			}

			Scene23LoadRun.Scene23Load();
		}

		else if (GoalieRatingString == "Save, to C") {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				PlayerDatabase.GameplayPossession = "P2";
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				PlayerDatabase.GameplayPossession = "P1";
			}

			Scene23LoadRun.Scene23Load();
		}

		else if (GoalieRatingString == "Save, to LD") {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				PlayerDatabase.GameplayPossession = "P2";
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				PlayerDatabase.GameplayPossession = "P1";
			}

			Scene23LoadRun.Scene23Load();
		}

		else if (GoalieRatingString == "Save, to LW") {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				PlayerDatabase.GameplayPossession = "P2";
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				PlayerDatabase.GameplayPossession = "P1";
			}

			Scene23LoadRun.Scene23Load();
		}

		else if (GoalieRatingString == "Save, to RD") {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				PlayerDatabase.GameplayPossession = "P2";
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				PlayerDatabase.GameplayPossession = "P1";
			}

			Scene23LoadRun.Scene23Load();
		}

		else if (GoalieRatingString == "Save, to RW") {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				PlayerDatabase.GameplayPossession = "P2";
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				PlayerDatabase.GameplayPossession = "P1";
			}

			Scene23LoadRun.Scene23Load();
		}
	}

	public void PlayerBackButtonClicking() {
		EnableObjects11.ShowingOverlayInt = 0;
	}

	public void P1CClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects11.ShowingOverlayString = "P1C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects11.ShowingOverlayString = "P1C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects11.ShowingOverlayString = "P1C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects11.ShowingOverlayString = "P1C4";
		}
	}

	public void P1LWClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects11.ShowingOverlayString = "P1LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects11.ShowingOverlayString = "P1LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects11.ShowingOverlayString = "P1LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects11.ShowingOverlayString = "P1LW4";
		}
	}

	public void P1RWClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects11.ShowingOverlayString = "P1RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects11.ShowingOverlayString = "P1RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects11.ShowingOverlayString = "P1RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects11.ShowingOverlayString = "P1RW4";
		}
	}

	public void P1LDClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects11.ShowingOverlayString = "P1LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects11.ShowingOverlayString = "P1LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects11.ShowingOverlayString = "P1LD3";
		}
	}

	public void P1RDClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects11.ShowingOverlayString = "P1RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects11.ShowingOverlayString = "P1RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects11.ShowingOverlayString = "P1RD3";
		}
	}

	public void P1GClicking() {
		EnableObjects11.ShowingOverlayInt = 1;
		EnableObjects11.ShowingOverlayString = "P1G";
	}

	public void P2CClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects11.ShowingOverlayString = "P2C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects11.ShowingOverlayString = "P2C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects11.ShowingOverlayString = "P2C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects11.ShowingOverlayString = "P2C4";
		}
	}

	public void P2LWClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects11.ShowingOverlayString = "P2LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects11.ShowingOverlayString = "P2LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects11.ShowingOverlayString = "P2LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects11.ShowingOverlayString = "P2LW4";
		}
	}

	public void P2RWClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects11.ShowingOverlayString = "P2RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects11.ShowingOverlayString = "P2RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects11.ShowingOverlayString = "P2RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects11.ShowingOverlayString = "P2RW4";
		}
	}

	public void P2LDClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects11.ShowingOverlayString = "P2LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects11.ShowingOverlayString = "P2LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects11.ShowingOverlayString = "P2LD3";
		}
	}

	public void P2RDClicking() {
		EnableObjects11.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects11.ShowingOverlayString = "P2RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects11.ShowingOverlayString = "P2RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects11.ShowingOverlayString = "P2RD3";
		}
	}

	public void P2GClicking() {
		EnableObjects11.ShowingOverlayInt = 1;
		EnableObjects11.ShowingOverlayString = "P2G";
	}

	public void RandomizeSkater() {
		RandomizeSkaterInt = Random.Range(1,6);

		if (RandomizeSkaterInt == 1) {
			if (PlayerDatabase.GameplayLine == "F1D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1C1";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2C1";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}
			}

			if (PlayerDatabase.GameplayLine == "F4D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1C4";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2C4";
				}
			}
		}

		else if (RandomizeSkaterInt == 2) {
			if (PlayerDatabase.GameplayLine == "F1D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LW1";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LW1";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}
			}

			if (PlayerDatabase.GameplayLine == "F4D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LW4";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LW4";
				}
			}
		}

		else if (RandomizeSkaterInt == 3) {
			if (PlayerDatabase.GameplayLine == "F1D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RW1";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RW1";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}
			}

			if (PlayerDatabase.GameplayLine == "F4D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RW4";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RW4";
				}
			}
		}

		else if (RandomizeSkaterInt == 4) {
			if (PlayerDatabase.GameplayLine == "F1D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}
			}

			if (PlayerDatabase.GameplayLine == "F4D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}
			}
		}

		else if (RandomizeSkaterInt == 5) {
			if (PlayerDatabase.GameplayLine == "F1D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D1") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}
			}

			if (PlayerDatabase.GameplayLine == "F2D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D2") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}
			}

			if (PlayerDatabase.GameplayLine == "F3D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}
			}

			if (PlayerDatabase.GameplayLine == "F4D3") {
				if (PlayerDatabase.GameplayPossession == "P1G") {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}

				else if (PlayerDatabase.GameplayPossession == "P2G") {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}