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

public class GameplayPassing : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string PassingPlayerName;
	public static string PassingString;
	public static int AnyPlayerPassingInt;
	public static string IntialPlayerPossession;
	public static string InitialPasserString;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene18BLoadRun;
	
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
    public void RunGameplayPassing() {
		// Initialize Variables
		PassingPlayerName = "None";
		PassingString = "None";
		AnyPlayerPassingInt = 0;
		IntialPlayerPossession = "None";
		InitialPasserString = "None";

		// Get Passing Player - Player
		if (PlayerDatabase.GameplayPossession == "P1C1") {
			PassingPlayerName = PlayerDatabase.P1C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C2") {
			PassingPlayerName = PlayerDatabase.P1C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C3") {
			PassingPlayerName = PlayerDatabase.P1C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C4") {
			PassingPlayerName = PlayerDatabase.P1C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW1") {
			PassingPlayerName = PlayerDatabase.P1LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW2") {
			PassingPlayerName = PlayerDatabase.P1LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW3") {
			PassingPlayerName = PlayerDatabase.P1LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW4") {
			PassingPlayerName = PlayerDatabase.P1LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW1") {
			PassingPlayerName = PlayerDatabase.P1RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW2") {
			PassingPlayerName = PlayerDatabase.P1RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW3") {
			PassingPlayerName = PlayerDatabase.P1RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW4") {
			PassingPlayerName = PlayerDatabase.P1RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD1") {
			PassingPlayerName = PlayerDatabase.P1LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD2") {
			PassingPlayerName = PlayerDatabase.P1LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD3") {
			PassingPlayerName = PlayerDatabase.P1LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD1") {
			PassingPlayerName = PlayerDatabase.P1RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD2") {
			PassingPlayerName = PlayerDatabase.P1RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD3") {
			PassingPlayerName = PlayerDatabase.P1RD3;
		}

		// Get Passing Player - Computer
		else if (PlayerDatabase.GameplayPossession == "P2C1") {
			PassingPlayerName = PlayerDatabase.P2C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C2") {
			PassingPlayerName = PlayerDatabase.P2C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C3") {
			PassingPlayerName = PlayerDatabase.P2C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C4") {
			PassingPlayerName = PlayerDatabase.P2C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW1") {
			PassingPlayerName = PlayerDatabase.P2LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW2") {
			PassingPlayerName = PlayerDatabase.P2LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW3") {
			PassingPlayerName = PlayerDatabase.P2LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW4") {
			PassingPlayerName = PlayerDatabase.P2LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW1") {
			PassingPlayerName = PlayerDatabase.P2RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW2") {
			PassingPlayerName = PlayerDatabase.P2RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW3") {
			PassingPlayerName = PlayerDatabase.P2RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW4") {
			PassingPlayerName = PlayerDatabase.P2RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD1") {
			PassingPlayerName = PlayerDatabase.P2LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD2") {
			PassingPlayerName = PlayerDatabase.P2LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD3") {
			PassingPlayerName = PlayerDatabase.P2LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD1") {
			PassingPlayerName = PlayerDatabase.P2RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD2") {
			PassingPlayerName = PlayerDatabase.P2RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD3") {
			PassingPlayerName = PlayerDatabase.P2RD3;
		}

		// Get Passing String
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (GameplayPickAction.DeterminedAction == "Passing A") {
				PassingString = StatsPassingA.PlayerStatsPassingA[PassingPlayerName];
			}

			else if (GameplayPickAction.DeterminedAction == "Passing B") {
				PassingString = StatsPassingB.PlayerStatsPassingB[PassingPlayerName];
			}

			else if (GameplayPickAction.DeterminedAction == "Passing C") {
				PassingString = StatsPassingC.PlayerStatsPassingC[PassingPlayerName];
			}

			else if (GameplayPickAction.DeterminedAction == "Passing D") {
				PassingString = StatsPassingD.PlayerStatsPassingD[PassingPlayerName];
			}

			else if (GameplayPickAction.DeterminedAction == "Passing E") {
				PassingString = StatsPassingE.PlayerStatsPassingE[PassingPlayerName];
			}

			else if (GameplayPickAction.DeterminedAction == "Passing F") {
				PassingString = StatsPassingF.PlayerStatsPassingF[PassingPlayerName];
			}

			else if (GameplayPickAction.DeterminedAction == "Passing G") {
				PassingString = StatsPassingG.PlayerStatsPassingG[PassingPlayerName];
			}

			else if (GameplayPickAction.DeterminedAction == "Passing H") {
				PassingString = StatsPassingH.PlayerStatsPassingH[PassingPlayerName];
			}

			else if (GameplayPickAction.DeterminedAction == "Passing I") {
				PassingString = StatsPassingI.PlayerStatsPassingI[PassingPlayerName];
			}

			else if ((GameplayPickAction.DeterminedAction == "Passing J") || (Buttons16.SetPassingString == "Passing J")) {
				PassingString = StatsPassingJ.PlayerStatsPassingJ[PassingPlayerName];
			}

			else if ((GameplayPickAction.DeterminedAction == "Passing K") || (Buttons16.SetPassingString == "Passing K")) {
				PassingString = StatsPassingK.PlayerStatsPassingK[PassingPlayerName];
			}

			else if ((GameplayPickAction.DeterminedAction == "Passing L") || (Buttons16.SetPassingString == "Passing L")) {
				PassingString = StatsPassingL.PlayerStatsPassingL[PassingPlayerName];
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (GameplayPickAction.DeterminedAction == "Passing A") {
					PassingString = StatsPassingA.FrPlayerStatsPassingA[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing B") {
					PassingString = StatsPassingB.FrPlayerStatsPassingB[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing C") {
					PassingString = StatsPassingC.FrPlayerStatsPassingC[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing D") {
					PassingString = StatsPassingD.FrPlayerStatsPassingD[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing E") {
					PassingString = StatsPassingE.FrPlayerStatsPassingE[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing F") {
					PassingString = StatsPassingF.FrPlayerStatsPassingF[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing G") {
					PassingString = StatsPassingG.FrPlayerStatsPassingG[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing H") {
					PassingString = StatsPassingH.FrPlayerStatsPassingH[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing I") {
					PassingString = StatsPassingI.FrPlayerStatsPassingI[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if ((GameplayPickAction.DeterminedAction == "Passing J") || (Buttons16.SetPassingString == "Passing J")) {
					PassingString = StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if ((GameplayPickAction.DeterminedAction == "Passing K") || (Buttons16.SetPassingString == "Passing K")) {
					PassingString = StatsPassingK.FrPlayerStatsPassingK[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}

				else if ((GameplayPickAction.DeterminedAction == "Passing L") || (Buttons16.SetPassingString == "Passing L")) {
					PassingString = StatsPassingL.FrPlayerStatsPassingL[PassingPlayerName + PlayerDatabase.PlayerChosenTeam];
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (GameplayPickAction.DeterminedAction == "Passing A") {
					PassingString = StatsPassingA.FrPlayerStatsPassingA[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing B") {
					PassingString = StatsPassingB.FrPlayerStatsPassingB[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing C") {
					PassingString = StatsPassingC.FrPlayerStatsPassingC[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing D") {
					PassingString = StatsPassingD.FrPlayerStatsPassingD[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing E") {
					PassingString = StatsPassingE.FrPlayerStatsPassingE[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing F") {
					PassingString = StatsPassingF.FrPlayerStatsPassingF[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing G") {
					PassingString = StatsPassingG.FrPlayerStatsPassingG[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing H") {
					PassingString = StatsPassingH.FrPlayerStatsPassingH[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Passing I") {
					PassingString = StatsPassingI.FrPlayerStatsPassingI[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if ((GameplayPickAction.DeterminedAction == "Passing J") || (Buttons16.SetPassingString == "Passing J")) {
					PassingString = StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if ((GameplayPickAction.DeterminedAction == "Passing K") || (Buttons16.SetPassingString == "Passing K")) {
					PassingString = StatsPassingK.FrPlayerStatsPassingK[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}

				else if ((GameplayPickAction.DeterminedAction == "Passing L") || (Buttons16.SetPassingString == "Passing L")) {
					PassingString = StatsPassingL.FrPlayerStatsPassingL[PassingPlayerName + PlayerDatabase.ComputerChosenTeam];
				}
			}
		}

		// Get New Player Possession
		if ((PassingString == "Inside Shot Any") || (Buttons16.SetPassingString == "Inside Any")) {
			AnyPlayerPassingInt = Random.Range(1,6);

			if (AnyPlayerPassingInt == 1) {
				IntialPlayerPossession = "C";
			}

			else if (AnyPlayerPassingInt == 2) {
				IntialPlayerPossession = "LW";
			}

			else if (AnyPlayerPassingInt == 3) {
				IntialPlayerPossession = "RW";
			}

			else if (AnyPlayerPassingInt == 4) {
				IntialPlayerPossession = "LD";
			}

			else if (AnyPlayerPassingInt == 5) {
				IntialPlayerPossession = "RD";
			}
		}

		else if (PassingString == "Inside Shot Any: I-Any") {
			AnyPlayerPassingInt = Random.Range(1,6);

			if (AnyPlayerPassingInt == 1) {
				IntialPlayerPossession = "C";
			}

			else if (AnyPlayerPassingInt == 2) {
				IntialPlayerPossession = "LW";
			}

			else if (AnyPlayerPassingInt == 3) {
				IntialPlayerPossession = "RW";
			}

			else if (AnyPlayerPassingInt == 4) {
				IntialPlayerPossession = "LD";
			}

			else if (AnyPlayerPassingInt == 5) {
				IntialPlayerPossession = "RD";
			}
		}

		else if ((PassingString == "Inside Shot C") || (Buttons16.SetPassingString == "Inside C")) {
			IntialPlayerPossession = "C";
		}
		
		else if (PassingString == "Inside Shot C: I-C") {
			IntialPlayerPossession = "C";
		}
		
		else if (PassingString == "Inside Shot C: I-LD") {
			IntialPlayerPossession = "C";
		}
		
		else if (PassingString == "Inside Shot C: I-LW") {
			IntialPlayerPossession = "C";
		}
		
		else if (PassingString == "Inside Shot C: I-RD") {
			IntialPlayerPossession = "C";
		}
		
		else if (PassingString == "Inside Shot C: I-RW") {
			IntialPlayerPossession = "C";
		}
		
		else if ((PassingString == "Inside Shot LW") || (Buttons16.SetPassingString == "Inside LW")) {
			IntialPlayerPossession = "LW";
		}
		
		else if (PassingString == "Inside Shot LW: I-C") {
			IntialPlayerPossession = "LW";
		}
		
		else if (PassingString == "Inside Shot LW: I-LD") {
			IntialPlayerPossession = "LW";
		}
		
		else if (PassingString == "Inside Shot LW: I-LW") {
			IntialPlayerPossession = "LW";
		}
		
		else if (PassingString == "Inside Shot LW: I-RD") {
			IntialPlayerPossession = "LW";
		}
		
		else if (PassingString == "Inside Shot LW: I-RW") {
			IntialPlayerPossession = "LW";
		}
		
		else if ((PassingString == "Inside Shot RW") || (Buttons16.SetPassingString == "Inside RW")) {
			IntialPlayerPossession = "RW";
		}
		
		else if (PassingString == "Inside Shot RW: I-C") {
			IntialPlayerPossession = "RW";
		}
		
		else if (PassingString == "Inside Shot RW: I-LD") {
			IntialPlayerPossession = "RW";
		}
		
		else if (PassingString == "Inside Shot RW: I-LW") {
			IntialPlayerPossession = "RW";
		}
		
		else if (PassingString == "Inside Shot RW: I-RD") {
			IntialPlayerPossession = "RW";
		}
		
		else if (PassingString == "Inside Shot RW: I-RW") {
			IntialPlayerPossession = "RW";
		}
		
		else if ((PassingString == "Lose Puck to Any") || (Buttons16.SetPassingString == "Lose to Any")) {
			AnyPlayerPassingInt = Random.Range(1,6);

			if (AnyPlayerPassingInt == 1) {
				IntialPlayerPossession = "OC";
			}

			else if (AnyPlayerPassingInt == 2) {
				IntialPlayerPossession = "OLW";
			}

			else if (AnyPlayerPassingInt == 3) {
				IntialPlayerPossession = "ORW";
			}

			else if (AnyPlayerPassingInt == 4) {
				IntialPlayerPossession = "OLD";
			}

			else if (AnyPlayerPassingInt == 5) {
				IntialPlayerPossession = "ORD";
			}
		}
		
		else if ((PassingString == "Lose Puck to C") || (Buttons16.SetPassingString == "Lose to C")) {
			IntialPlayerPossession = "OC";
		}
		
		else if ((PassingString == "Lose Puck to LD") || (Buttons16.SetPassingString == "Lose to LD")) {
			IntialPlayerPossession = "OLD";
		}
		
		else if ((PassingString == "Lose Puck to LW") || (Buttons16.SetPassingString == "Lose to LW")) {
			IntialPlayerPossession = "OLW";
		}
		
		else if ((PassingString == "Lose Puck to RD") || (Buttons16.SetPassingString == "Lose to RD")) {
			IntialPlayerPossession = "ORD";
		}
		
		else if ((PassingString == "Lose Puck to RW") || (Buttons16.SetPassingString == "Lose to RW")) {
			IntialPlayerPossession = "ORW";
		}
		
		else if (PassingString == "Lose, Inside Shot Any: I-Any") {
			AnyPlayerPassingInt = Random.Range(1,6);

			if (AnyPlayerPassingInt == 1) {
				IntialPlayerPossession = "OC";
			}

			else if (AnyPlayerPassingInt == 2) {
				IntialPlayerPossession = "OLW";
			}

			else if (AnyPlayerPassingInt == 3) {
				IntialPlayerPossession = "ORW";
			}

			else if (AnyPlayerPassingInt == 4) {
				IntialPlayerPossession = "OLD";
			}

			else if (AnyPlayerPassingInt == 5) {
				IntialPlayerPossession = "ORD";
			}
		}
		
		else if (PassingString == "Lose, Inside Shot C: I-C") {
			IntialPlayerPossession = "OC";
		}
		
		else if (PassingString == "Lose, Inside Shot C: I-LD") {
			IntialPlayerPossession = "OC";
		}
		
		else if (PassingString == "Lose, Inside Shot C: I-LW") {
			IntialPlayerPossession = "OC";
		}
		
		else if (PassingString == "Lose, Inside Shot C: I-RD") {
			IntialPlayerPossession = "OC";
		}
		
		else if (PassingString == "Lose, Inside Shot C: I-RW") {
			IntialPlayerPossession = "OC";
		}
		
		else if (PassingString == "Lose, Inside Shot LW: I-C") {
			IntialPlayerPossession = "OLW";
		}
		
		else if (PassingString == "Lose, Inside Shot LW: I-LD") {
			IntialPlayerPossession = "OLW";
		}
		
		else if (PassingString == "Lose, Inside Shot LW: I-LW") {
			IntialPlayerPossession = "OLW";
		}
		
		else if (PassingString == "Lose, Inside Shot LW: I-RD") {
			IntialPlayerPossession = "OLW";
		}
		
		else if (PassingString == "Lose, Inside Shot LW: I-RW") {
			IntialPlayerPossession = "OLW";
		}
		
		else if (PassingString == "Lose, Inside Shot RW: I-C") {
			IntialPlayerPossession = "ORW";
		}
		
		else if (PassingString == "Lose, Inside Shot RW: I-LD") {
			IntialPlayerPossession = "ORW";
		}
		
		else if (PassingString == "Lose, Inside Shot RW: I-LW") {
			IntialPlayerPossession = "ORW";
		}
		
		else if (PassingString == "Lose, Inside Shot RW: I-RD") {
			IntialPlayerPossession = "ORW";
		}
		
		else if (PassingString == "Lose, Inside Shot RW: I-RW") {
			IntialPlayerPossession = "ORW";
		}
		
		else if (PassingString == "Lose, Outside Shot Any") {
			AnyPlayerPassingInt = Random.Range(1,6);

			if (AnyPlayerPassingInt == 1) {
				IntialPlayerPossession = "OC";
			}

			else if (AnyPlayerPassingInt == 2) {
				IntialPlayerPossession = "OLW";
			}

			else if (AnyPlayerPassingInt == 3) {
				IntialPlayerPossession = "ORW";
			}

			else if (AnyPlayerPassingInt == 4) {
				IntialPlayerPossession = "OLD";
			}

			else if (AnyPlayerPassingInt == 5) {
				IntialPlayerPossession = "ORD";
			}
		}
		
		else if (PassingString == "Lose, Outside Shot C") {
			IntialPlayerPossession = "OC";
		}
		
		else if (PassingString == "Lose, Outside Shot LD") {
			IntialPlayerPossession = "OLD";
		}
		
		else if (PassingString == "Lose, Outside Shot LW") {
			IntialPlayerPossession = "OLW";
		}
		
		else if (PassingString == "Lose, Outside Shot RD") {
			IntialPlayerPossession = "ORD";
		}
		
		else if (PassingString == "Lose, Outside Shot RW") {
			IntialPlayerPossession = "ORW";
		}
		
		else if (PassingString == "Outside Shot Any") {
			AnyPlayerPassingInt = Random.Range(1,6);

			if (AnyPlayerPassingInt == 1) {
				IntialPlayerPossession = "C";
			}

			else if (AnyPlayerPassingInt == 2) {
				IntialPlayerPossession = "LW";
			}

			else if (AnyPlayerPassingInt == 3) {
				IntialPlayerPossession = "RW";
			}

			else if (AnyPlayerPassingInt == 4) {
				IntialPlayerPossession = "LD";
			}

			else if (AnyPlayerPassingInt == 5) {
				IntialPlayerPossession = "RD";
			}
		}
		
		else if (PassingString == "Outside Shot C") {
			IntialPlayerPossession = "C";
		}
		
		else if (PassingString == "Outside Shot LD") {
			IntialPlayerPossession = "LD";
		}
		
		else if (PassingString == "Outside Shot LW") {
			IntialPlayerPossession = "LW";
		}
		
		else if (PassingString == "Outside Shot RD") {
			IntialPlayerPossession = "RD";
		}
		
		else if (PassingString == "Outside Shot RW") {
			IntialPlayerPossession = "RW";
		}

		// Set Passer String
		InitialPasserString = PlayerDatabase.GameplayPossession;
		PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
		PlayerDatabase.GameplayAssistA = InitialPasserString;

		// Get Updated Possession
		if (PlayerDatabase.GameplayLine == "F1D1") {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				// Player to Player
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P1C1";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P1LW1";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P1RW1";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}

				// Player to Computer
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P2C1";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P2LW1";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P2RW1";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				// Computer to Computer
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P2C1";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P2LW1";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P2RW1";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}

				// Computer to Player
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P1C1";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P1LW1";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P1RW1";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}
			}
		}

		else if (PlayerDatabase.GameplayLine == "F2D1") {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				// Player to Player
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}

				// Player to Computer
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				// Computer to Computer
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}

				// Computer to Player
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}
			}
		}

		else if (PlayerDatabase.GameplayLine == "F2D2") {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				// Player to Player
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}

				// Player to Computer
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				// Computer to Computer
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}

				// Computer to Player
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}
			}
		}

		else if (PlayerDatabase.GameplayLine == "F3D2") {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				// Player to Player
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}

				// Player to Computer
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				// Computer to Computer
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}

				// Computer to Player
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}
			}
		}

		else if (PlayerDatabase.GameplayLine == "F3D3") {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				// Player to Player
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}

				// Player to Computer
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				// Computer to Computer
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}

				// Computer to Player
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}
			}
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				// Player to Player
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P1C4";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P1LW4";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P1RW4";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}

				// Player to Computer
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P2C4";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P2LW4";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P2RW4";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				// Computer to Computer
				if (IntialPlayerPossession == "C") {
					PlayerDatabase.GameplayPossession = "P2C4";
				}

				else if (IntialPlayerPossession == "LW") {
					PlayerDatabase.GameplayPossession = "P2LW4";
				}

				else if (IntialPlayerPossession == "RW") {
					PlayerDatabase.GameplayPossession = "P2RW4";
				}

				else if (IntialPlayerPossession == "LD") {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}

				else if (IntialPlayerPossession == "RD") {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}

				// Computer to Player
				else if (IntialPlayerPossession == "OC") {
					PlayerDatabase.GameplayPossession = "P1C4";
				}

				else if (IntialPlayerPossession == "OLW") {
					PlayerDatabase.GameplayPossession = "P1LW4";
				}

				else if (IntialPlayerPossession == "ORW") {
					PlayerDatabase.GameplayPossession = "P1RW4";
				}

				else if (IntialPlayerPossession == "OLD") {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				else if (IntialPlayerPossession == "ORD") {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}
			}
		}

		// Go to After Passing Scene
		PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
		Scene18BLoadRun.Scene18BLoad();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}