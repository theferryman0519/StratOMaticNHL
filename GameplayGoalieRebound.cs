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

public class GameplayGoalieRebound : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string DefenseP1C;
	public static string DefenseP1LW;
	public static string DefenseP1RW;
	public static string DefenseP1LD;
	public static string DefenseP1RD;
	public static string DefenseP2C;
	public static string DefenseP2LW;
	public static string DefenseP2RW;
	public static string DefenseP2LD;
	public static string DefenseP2RD;
	public static string OffenseP1C;
	public static string OffenseP1LW;
	public static string OffenseP1RW;
	public static string OffenseP1LD;
	public static string OffenseP1RD;
	public static string OffenseP2C;
	public static string OffenseP2LW;
	public static string OffenseP2RW;
	public static string OffenseP2LD;
	public static string OffenseP2RD;
	public static string PlayerPossession;
	public static int RandomizeSplitNumber;
	public static int RandomizeAnyPlayer;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene22LoadRun;
	public SceneChange Scene25LoadRun;
	
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
    public void RunGameplayGoalieRebound() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			// Get Current Lines Offense
			if (PlayerDatabase.GameplayLine == "F1D1") {
				OffenseP1C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C1];
				OffenseP1LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW1];
				OffenseP1RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW1];
				OffenseP1LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD1];
				OffenseP1RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD1];
				OffenseP2C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C1];
				OffenseP2LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW1];
				OffenseP2RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW1];
				OffenseP2LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD1];
				OffenseP2RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD1];
			}

			else if (PlayerDatabase.GameplayLine == "F2D1") {
				OffenseP1C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C2];
				OffenseP1LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW2];
				OffenseP1RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW2];
				OffenseP1LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD1];
				OffenseP1RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD1];
				OffenseP2C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C2];
				OffenseP2LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW2];
				OffenseP2RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW2];
				OffenseP2LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD1];
				OffenseP2RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD1];
			}

			else if (PlayerDatabase.GameplayLine == "F2D2") {
				OffenseP1C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C2];
				OffenseP1LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW2];
				OffenseP1RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW2];
				OffenseP1LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD2];
				OffenseP1RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD2];
				OffenseP2C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C2];
				OffenseP2LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW2];
				OffenseP2RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW2];
				OffenseP2LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD2];
				OffenseP2RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD2];
			}

			else if (PlayerDatabase.GameplayLine == "F3D2") {
				OffenseP1C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C3];
				OffenseP1LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW3];
				OffenseP1RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW3];
				OffenseP1LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD2];
				OffenseP1RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD2];
				OffenseP2C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C3];
				OffenseP2LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW3];
				OffenseP2RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW3];
				OffenseP2LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD2];
				OffenseP2RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD2];
			}

			else if (PlayerDatabase.GameplayLine == "F3D3") {
				OffenseP1C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C3];
				OffenseP1LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW3];
				OffenseP1RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW3];
				OffenseP1LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD3];
				OffenseP1RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD3];
				OffenseP2C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C3];
				OffenseP2LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW3];
				OffenseP2RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW3];
				OffenseP2LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD3];
				OffenseP2RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD3];
			}

			else if (PlayerDatabase.GameplayLine == "F4D3") {
				OffenseP1C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C4];
				OffenseP1LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW4];
				OffenseP1RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW4];
				OffenseP1LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD3];
				OffenseP1RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD3];
				OffenseP2C = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C4];
				OffenseP2LW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW4];
				OffenseP2RW = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW4];
				OffenseP2LD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD3];
				OffenseP2RD = StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD3];
			}

			// Get Current Lines Defense
			if (PlayerDatabase.GameplayLine == "F1D1") {
				DefenseP1C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C1];
				DefenseP1LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW1];
				DefenseP1RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW1];
				DefenseP1LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD1];
				DefenseP1RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD1];
				DefenseP2C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C1];
				DefenseP2LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW1];
				DefenseP2RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW1];
				DefenseP2LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD1];
				DefenseP2RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD1];
			}

			else if (PlayerDatabase.GameplayLine == "F2D1") {
				DefenseP1C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C2];
				DefenseP1LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW2];
				DefenseP1RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW2];
				DefenseP1LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD1];
				DefenseP1RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD1];
				DefenseP2C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C2];
				DefenseP2LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW2];
				DefenseP2RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW2];
				DefenseP2LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD1];
				DefenseP2RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD1];
			}

			else if (PlayerDatabase.GameplayLine == "F2D2") {
				DefenseP1C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C2];
				DefenseP1LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW2];
				DefenseP1RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW2];
				DefenseP1LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD2];
				DefenseP1RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD2];
				DefenseP2C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C2];
				DefenseP2LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW2];
				DefenseP2RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW2];
				DefenseP2LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD2];
				DefenseP2RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD2];
			}

			else if (PlayerDatabase.GameplayLine == "F3D2") {
				DefenseP1C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C3];
				DefenseP1LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW3];
				DefenseP1RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW3];
				DefenseP1LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD2];
				DefenseP1RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD2];
				DefenseP2C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C3];
				DefenseP2LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW3];
				DefenseP2RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW3];
				DefenseP2LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD2];
				DefenseP2RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD2];
			}

			else if (PlayerDatabase.GameplayLine == "F3D3") {
				DefenseP1C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C3];
				DefenseP1LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW3];
				DefenseP1RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW3];
				DefenseP1LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD3];
				DefenseP1RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD3];
				DefenseP2C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C3];
				DefenseP2LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW3];
				DefenseP2RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW3];
				DefenseP2LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD3];
				DefenseP2RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD3];
			}

			else if (PlayerDatabase.GameplayLine == "F4D3") {
				DefenseP1C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C4];
				DefenseP1LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW4];
				DefenseP1RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW4];
				DefenseP1LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD3];
				DefenseP1RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD3];
				DefenseP2C = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C4];
				DefenseP2LW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW4];
				DefenseP2RW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW4];
				DefenseP2LD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD3];
				DefenseP2RD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD3];
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			// Get Current Lines Offense
			if (PlayerDatabase.GameplayLine == "F1D1") {
				OffenseP1C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
				OffenseP2C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F2D1") {
				OffenseP1C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
				OffenseP2C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F2D2") {
				OffenseP1C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP2C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F3D2") {
				OffenseP1C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
				OffenseP2C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F3D3") {
				OffenseP1C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP2C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F4D3") {
				OffenseP1C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP1RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
				OffenseP2C = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RW = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2LD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
				OffenseP2RD = StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
			}

			// Get Current Lines Defense
			if (PlayerDatabase.GameplayLine == "F1D1") {
				DefenseP1C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
				DefenseP2C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F2D1") {
				DefenseP1C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
				DefenseP2C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F2D2") {
				DefenseP1C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP2C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F3D2") {
				DefenseP1C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
				DefenseP2C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F3D3") {
				DefenseP1C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP2C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (PlayerDatabase.GameplayLine == "F4D3") {
				DefenseP1C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP1RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
				DefenseP2C = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2LD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
				DefenseP2RD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
			}
		}

		// Randomize Split Number
		RandomizeSplitNumber = Random.Range(1,1001);

		// Determine Rebound Play
		if ((RandomizeSplitNumber >= 1) && (RandomizeSplitNumber < 126)) {
			RandomizeAnyPlayer = Random.Range(1,6);

			if (RandomizeAnyPlayer == 1) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C4";
					}
				}
			}

			else if (RandomizeAnyPlayer == 2) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW4";
					}
				}
			}

			else if (RandomizeAnyPlayer == 3) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW4";
					}
				}
			}

			else if (RandomizeAnyPlayer == 4) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD3";
					}
				}
			}

			else if (RandomizeAnyPlayer == 5) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD3";
					}
				}
			}

			Scene25LoadRun.Scene25Load();
		}
		
		else if ((RandomizeSplitNumber >= 126) && (RandomizeSplitNumber < 151)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1C == "0") || (DefenseP1C == "2") || (DefenseP1C == "3") || (DefenseP1C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2C == "0") || (DefenseP2C == "2") || (DefenseP2C == "3") || (DefenseP2C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 151) && (RandomizeSplitNumber < 171)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1C == "2") || (DefenseP1C == "3") || (DefenseP1C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2C == "2") || (DefenseP2C == "3") || (DefenseP2C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 176) && (RandomizeSplitNumber < 201)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1C == "3") || (DefenseP1C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2C == "3") || (DefenseP2C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 201) && (RandomizeSplitNumber < 226)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1LW == "0") || (DefenseP1LW == "2") || (DefenseP1LW == "3") || (DefenseP1LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2LW == "0") || (DefenseP2LW == "2") || (DefenseP2LW == "3") || (DefenseP2LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 226) && (RandomizeSplitNumber < 251)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1LW == "2") || (DefenseP1LW == "3") || (DefenseP1LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2LW == "2") || (DefenseP2LW == "3") || (DefenseP2LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 251) && (RandomizeSplitNumber < 276)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1LW == "3") || (DefenseP1LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2LW == "3") || (DefenseP2LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 276) && (RandomizeSplitNumber < 301)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1RW == "0") || (DefenseP1RW == "2") || (DefenseP1RW == "3") || (DefenseP1RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2RW == "0") || (DefenseP2RW == "2") || (DefenseP2RW == "3") || (DefenseP2RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 301) && (RandomizeSplitNumber < 326)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1RW == "2") || (DefenseP1RW == "3") || (DefenseP1RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2RW == "2") || (DefenseP2RW == "3") || (DefenseP2RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 326) && (RandomizeSplitNumber < 351)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1RW == "3") || (DefenseP1RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2RW == "3") || (DefenseP2RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 351) && (RandomizeSplitNumber < 376)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1LD == "0") || (DefenseP1LD == "2") || (DefenseP1LD == "3") || (DefenseP1LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2LD == "0") || (DefenseP2LD == "2") || (DefenseP2LD == "3") || (DefenseP2LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 376) && (RandomizeSplitNumber < 401)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1LD == "2") || (DefenseP1LD == "3") || (DefenseP1LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2LD == "2") || (DefenseP2LD == "3") || (DefenseP2LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 401) && (RandomizeSplitNumber < 426)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1LD == "3") || (DefenseP1LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2LD == "3") || (DefenseP2LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 426) && (RandomizeSplitNumber < 451)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1RD == "0") || (DefenseP1RD == "2") || (DefenseP1RD == "3") || (DefenseP1RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2RD == "0") || (DefenseP2RD == "2") || (DefenseP2RD == "3") || (DefenseP2RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 451) && (RandomizeSplitNumber < 476)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1RD == "2") || (DefenseP1RD == "3") || (DefenseP1RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2RD == "2") || (DefenseP2RD == "3") || (DefenseP2RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 476) && (RandomizeSplitNumber < 501)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((DefenseP1RD == "3") || (DefenseP1RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((DefenseP2RD == "3") || (DefenseP2RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 501) && (RandomizeSplitNumber < 526)) {
			RandomizeAnyPlayer = Random.Range(1,6);
			
			if (RandomizeAnyPlayer == 1) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2C4";
					}
				}
			}

			else if (RandomizeAnyPlayer == 2) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LW4";
					}
				}
			}

			else if (RandomizeAnyPlayer == 3) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RW4";
					}
				}
			}

			else if (RandomizeAnyPlayer == 4) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2LD3";
					}
				}
			}

			else if (RandomizeAnyPlayer == 5) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P1RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P2RD3";
					}
				}
			}

			Scene22LoadRun.Scene22Load();
		}
				
		else if ((RandomizeSplitNumber >= 626) && (RandomizeSplitNumber < 651)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2C == "0") || (OffenseP2C == "2") || (OffenseP2C == "3") || (OffenseP2C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1C == "0") || (OffenseP1C == "2") || (OffenseP1C == "3") || (OffenseP1C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 651) && (RandomizeSplitNumber < 676)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2C == "2") || (OffenseP2C == "3") || (OffenseP2C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1C == "2") || (OffenseP1C == "3") || (OffenseP1C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 676) && (RandomizeSplitNumber < 701)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2C == "3") || (OffenseP2C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1C == "3") || (OffenseP1C == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 701) && (RandomizeSplitNumber < 726)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2LW == "0") || (OffenseP2LW == "2") || (OffenseP2LW == "3") || (OffenseP2LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1LW == "0") || (OffenseP1LW == "2") || (OffenseP1LW == "3") || (OffenseP1LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 726) && (RandomizeSplitNumber < 751)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2LW == "2") || (OffenseP2LW == "3") || (OffenseP2LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1LW == "2") || (OffenseP1LW == "3") || (OffenseP1LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 751) && (RandomizeSplitNumber < 776)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2LW == "3") || (OffenseP2LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1LW == "3") || (OffenseP1LW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 776) && (RandomizeSplitNumber < 801)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2RW == "0") || (OffenseP2RW == "2") || (OffenseP2RW == "3") || (OffenseP2RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1RW == "0") || (OffenseP1RW == "2") || (OffenseP1RW == "3") || (OffenseP1RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 801) && (RandomizeSplitNumber < 826)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2RW == "2") || (OffenseP2RW == "3") || (OffenseP2RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1RW == "2") || (OffenseP1RW == "3") || (OffenseP1RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 826) && (RandomizeSplitNumber < 851)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2RW == "3") || (OffenseP2RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1RW == "3") || (OffenseP1RW == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 851) && (RandomizeSplitNumber < 876)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2LD == "0") || (OffenseP2LD == "2") || (OffenseP2LD == "3") || (OffenseP2LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1LD == "0") || (OffenseP1LD == "2") || (OffenseP1LD == "3") || (OffenseP1LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 876) && (RandomizeSplitNumber < 901)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2LD == "2") || (OffenseP2LD == "3") || (OffenseP2LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1LD == "2") || (OffenseP1LD == "3") || (OffenseP1LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 901) && (RandomizeSplitNumber < 926)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2LD == "3") || (OffenseP2LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1LD == "3") || (OffenseP1LD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 926) && (RandomizeSplitNumber < 951)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2RD == "0") || (OffenseP2RD == "2") || (OffenseP2RD == "3") || (OffenseP2RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1RD == "0") || (OffenseP1RD == "2") || (OffenseP1RD == "3") || (OffenseP1RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 951) && (RandomizeSplitNumber < 976)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2RD == "2") || (OffenseP2RD == "3") || (OffenseP2RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1RD == "2") || (OffenseP1RD == "3") || (OffenseP1RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
		
		else if ((RandomizeSplitNumber >= 976) && (RandomizeSplitNumber < 1001)) {
			if (PlayerDatabase.GameplayPossession == "P1G") {
				if ((OffenseP2RD == "3") || (OffenseP2RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}

			else if (PlayerDatabase.GameplayPossession == "P2G") {
				if ((OffenseP1RD == "3") || (OffenseP1RD == "4")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
						Scene22LoadRun.Scene22Load();
					}
				}

				else {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
						Scene25LoadRun.Scene25Load();
					}
				}
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}