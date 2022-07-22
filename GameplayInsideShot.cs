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

public class GameplayInsideShot : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string CurrentShooter;
	public static int DiceRollA;
	public static int DiceRollB;
	public static int DiceRoll;
	public static string InitialShotString;
	public static string GenericShot;
	public static int ShotTotal;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene12BLoadRun;
	
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
    public void RunGameplayInsideShot() {
		PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
		
		// Set Current Shooter
		if (PlayerDatabase.GameplayPossession == "P1C1") {
			CurrentShooter = PlayerDatabase.P1C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C2") {
			CurrentShooter = PlayerDatabase.P1C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C3") {
			CurrentShooter = PlayerDatabase.P1C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C4") {
			CurrentShooter = PlayerDatabase.P1C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW1") {
			CurrentShooter = PlayerDatabase.P1LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW2") {
			CurrentShooter = PlayerDatabase.P1LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW3") {
			CurrentShooter = PlayerDatabase.P1LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW4") {
			CurrentShooter = PlayerDatabase.P1LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW1") {
			CurrentShooter = PlayerDatabase.P1RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW2") {
			CurrentShooter = PlayerDatabase.P1RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW3") {
			CurrentShooter = PlayerDatabase.P1RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW4") {
			CurrentShooter = PlayerDatabase.P1RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD1") {
			CurrentShooter = PlayerDatabase.P1LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD2") {
			CurrentShooter = PlayerDatabase.P1LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD3") {
			CurrentShooter = PlayerDatabase.P1LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD1") {
			CurrentShooter = PlayerDatabase.P1RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD2") {
			CurrentShooter = PlayerDatabase.P1RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD3") {
			CurrentShooter = PlayerDatabase.P1RD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C1") {
			CurrentShooter = PlayerDatabase.P2C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C2") {
			CurrentShooter = PlayerDatabase.P2C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C3") {
			CurrentShooter = PlayerDatabase.P2C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C4") {
			CurrentShooter = PlayerDatabase.P2C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW1") {
			CurrentShooter = PlayerDatabase.P2LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW2") {
			CurrentShooter = PlayerDatabase.P2LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW3") {
			CurrentShooter = PlayerDatabase.P2LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW4") {
			CurrentShooter = PlayerDatabase.P2LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW1") {
			CurrentShooter = PlayerDatabase.P2RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW2") {
			CurrentShooter = PlayerDatabase.P2RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW3") {
			CurrentShooter = PlayerDatabase.P2RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW4") {
			CurrentShooter = PlayerDatabase.P2RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD1") {
			CurrentShooter = PlayerDatabase.P2LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD2") {
			CurrentShooter = PlayerDatabase.P2LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD3") {
			CurrentShooter = PlayerDatabase.P2LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD1") {
			CurrentShooter = PlayerDatabase.P2RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD2") {
			CurrentShooter = PlayerDatabase.P2RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD3") {
			CurrentShooter = PlayerDatabase.P2RD3;
		}

		// Randomize Dice Roll
		DiceRollA = Random.Range(1,7);
		DiceRollB = Random.Range(1,7);
		DiceRoll = DiceRollA + DiceRollB;

		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (DiceRoll == 2) {
				InitialShotString = StatsInside02.PlayerStatsInside02[CurrentShooter];
			}

			else if (DiceRoll == 3) {
				InitialShotString = StatsInside03.PlayerStatsInside03[CurrentShooter];
			}

			else if (DiceRoll == 4) {
				InitialShotString = StatsInside04.PlayerStatsInside04[CurrentShooter];
			}

			else if (DiceRoll == 5) {
				InitialShotString = StatsInside05.PlayerStatsInside05[CurrentShooter];
			}

			else if (DiceRoll == 6) {
				InitialShotString = StatsInside06.PlayerStatsInside06[CurrentShooter];
			}

			else if (DiceRoll == 7) {
				InitialShotString = StatsInside07.PlayerStatsInside07[CurrentShooter];
			}

			else if (DiceRoll == 8) {
				InitialShotString = StatsInside08.PlayerStatsInside08[CurrentShooter];
			}

			else if (DiceRoll == 9) {
				InitialShotString = StatsInside09.PlayerStatsInside09[CurrentShooter];
			}

			else if (DiceRoll == 10) {
				InitialShotString = StatsInside10.PlayerStatsInside10[CurrentShooter];
			}

			else if (DiceRoll == 11) {
				InitialShotString = StatsInside11.PlayerStatsInside11[CurrentShooter];
			}

			else if (DiceRoll == 12) {
				InitialShotString = StatsInside12.PlayerStatsInside12[CurrentShooter];
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (DiceRoll == 2) {
					InitialShotString = StatsInside02.FrPlayerStatsInside02[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 3) {
					InitialShotString = StatsInside03.FrPlayerStatsInside03[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 4) {
					InitialShotString = StatsInside04.FrPlayerStatsInside04[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 5) {
					InitialShotString = StatsInside05.FrPlayerStatsInside05[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 6) {
					InitialShotString = StatsInside06.FrPlayerStatsInside06[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 7) {
					InitialShotString = StatsInside07.FrPlayerStatsInside07[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 8) {
					InitialShotString = StatsInside08.FrPlayerStatsInside08[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 9) {
					InitialShotString = StatsInside09.FrPlayerStatsInside09[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 10) {
					InitialShotString = StatsInside10.FrPlayerStatsInside10[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 11) {
					InitialShotString = StatsInside11.FrPlayerStatsInside11[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 12) {
					InitialShotString = StatsInside12.FrPlayerStatsInside12[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (DiceRoll == 2) {
					InitialShotString = StatsInside02.FrPlayerStatsInside02[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 3) {
					InitialShotString = StatsInside03.FrPlayerStatsInside03[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 4) {
					InitialShotString = StatsInside04.FrPlayerStatsInside04[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 5) {
					InitialShotString = StatsInside05.FrPlayerStatsInside05[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 6) {
					InitialShotString = StatsInside06.FrPlayerStatsInside06[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 7) {
					InitialShotString = StatsInside07.FrPlayerStatsInside07[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 8) {
					InitialShotString = StatsInside08.FrPlayerStatsInside08[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 9) {
					InitialShotString = StatsInside09.FrPlayerStatsInside09[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 10) {
					InitialShotString = StatsInside10.FrPlayerStatsInside10[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 11) {
					InitialShotString = StatsInside11.FrPlayerStatsInside11[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 12) {
					InitialShotString = StatsInside12.FrPlayerStatsInside12[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}
			}
		}

		// Determine Shot String
		if (InitialShotString == "G. Rating") {
			GenericShot = "Goalie Rating";
			Buttons11.GetShotType = 1;
			AddToShotTotal();
		}

		else if (InitialShotString == "G. Rating+") {
			GenericShot = "Goalie Rating";
			Buttons11.GetShotType = 1;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 1;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-10") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 10;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-11") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 11;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-12") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 12;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-13") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 13;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-14") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 14;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-15") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 15;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-16") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 16;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-17") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 17;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-18") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 18;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-19") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 19;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-2") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 2;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-20") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 20;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-3") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 3;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-4") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 4;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-5") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 5;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-6") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 6;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-7") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 7;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-8") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 8;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal: 1-9") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 9;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 1;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-10") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 10;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-11") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 11;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-12") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 12;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-13") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 13;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-14") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 14;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-15") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 15;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-16") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 16;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-17") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 17;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-18") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 18;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-19") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 19;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-2") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 2;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-20") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 20;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-3") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 3;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-4") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 4;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-5") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 5;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-6") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 6;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-7") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 7;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-8") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 8;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Goal+: 1-9") {
			GenericShot = "Goal Chance";
			GameplayGoal.GoalInt = 9;
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Loses to Any") {
			GameplayPassing.PassingString = "Lose Puck to Any";
			GenericShot = "Lose";
		}
		
		else if (InitialShotString == "Loses to C") {
			GameplayPassing.PassingString = "Lose Puck to C";
			GenericShot = "Lose";
		}
		
		else if (InitialShotString == "Loses to LD") {
			GameplayPassing.PassingString = "Lose Puck to LD";
			GenericShot = "Lose";
		}
		
		else if (InitialShotString == "Loses to LW") {
			GameplayPassing.PassingString = "Lose Puck to LW";
			GenericShot = "Lose";
		}
		
		else if (InitialShotString == "Loses to RD") {
			GameplayPassing.PassingString = "Lose Puck to RD";
			GenericShot = "Lose";
		}
		
		else if (InitialShotString == "Loses to RW") {
			GameplayPassing.PassingString = "Lose Puck to RW";
			GenericShot = "Lose";
		}
		
		else if (InitialShotString == "Rebound") {
			GenericShot = "Rebound";
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Shot to Any") {
			GenericShot = "Shot";
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Shot to C") {
			GenericShot = "Shot";
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Shot to LD") {
			GenericShot = "Shot";
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Shot to LW") {
			GenericShot = "Shot";
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Shot to RD") {
			GenericShot = "Shot";
			AddToShotTotal();
		}
		
		else if (InitialShotString == "Shot to RW") {
			GenericShot = "Shot";
			AddToShotTotal();
		}

		// Go to After Shot Scene
		Scene12BLoadRun.Scene12BLoad();
	}

	public void AddToShotTotal() {
		if (PlayerDatabase.GameplayPossession.Contains("P1")) {
			ShotTotal = System.Int32.Parse(PlayerDatabase.GameplayP1Shots);
			ShotTotal = ShotTotal + 1;
			PlayerDatabase.GameplayP1Shots = ShotTotal.ToString();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
			ShotTotal = System.Int32.Parse(PlayerDatabase.GameplayP2Shots);
			ShotTotal = ShotTotal + 1;
			PlayerDatabase.GameplayP2Shots = ShotTotal.ToString();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}