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

public class Buttons26B : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button ShotButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int DiceRollA;
	public static int DiceRollB;
	public static int DiceRoll;
	public static string CurrentShooter;
	public static string InitialShotString;
	public static string GRatingShotString;
	public static int SplitCardNumber;
	public static int GRatingDiceA;
	public static int GRatingDiceB;
	public static int GRatingDice;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene26CLoadRun;
	public SceneChange Scene26DLoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// ShotButton
		Button ShotButtonClick = ShotButton.GetComponent<Button>();
		ShotButtonClick.onClick.AddListener(ShotButtonClicking);
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
	public void ShotButtonClicking() {
		// Determine Current Shooter
		if (EnableObjects26B.ShootoutTurnString == "P1") {
			CurrentShooter = EnableObjects26B.ShooterNameP1;
		}

		else if (EnableObjects26B.ShootoutTurnString == "P2") {
			CurrentShooter = EnableObjects26B.ShooterNameP2;
		}

		// Randomize Dice Roll
		DiceRollA = Random.Range(1,7);
		DiceRollB = Random.Range(1,7);
		DiceRoll = DiceRollA + DiceRollB;

		// Determine Shot String
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (DiceRoll == 2) {
				InitialShotString = StatsRebBreak02.PlayerStatsRebBreak02[CurrentShooter];
			}

			else if (DiceRoll == 3) {
				InitialShotString = StatsRebBreak03.PlayerStatsRebBreak03[CurrentShooter];
			}

			else if (DiceRoll == 4) {
				InitialShotString = StatsRebBreak04.PlayerStatsRebBreak04[CurrentShooter];
			}

			else if (DiceRoll == 5) {
				InitialShotString = StatsRebBreak05.PlayerStatsRebBreak05[CurrentShooter];
			}

			else if (DiceRoll == 6) {
				InitialShotString = StatsRebBreak06.PlayerStatsRebBreak06[CurrentShooter];
			}

			else if (DiceRoll == 7) {
				InitialShotString = StatsRebBreak07.PlayerStatsRebBreak07[CurrentShooter];
			}

			else if (DiceRoll == 8) {
				InitialShotString = StatsRebBreak08.PlayerStatsRebBreak08[CurrentShooter];
			}

			else if (DiceRoll == 9) {
				InitialShotString = StatsRebBreak09.PlayerStatsRebBreak09[CurrentShooter];
			}

			else if (DiceRoll == 10) {
				InitialShotString = StatsRebBreak10.PlayerStatsRebBreak10[CurrentShooter];
			}

			else if (DiceRoll == 11) {
				InitialShotString = StatsRebBreak11.PlayerStatsRebBreak11[CurrentShooter];
			}

			else if (DiceRoll == 12) {
				InitialShotString = StatsRebBreak12.PlayerStatsRebBreak12[CurrentShooter];
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (DiceRoll == 2) {
					InitialShotString = StatsRebBreak02.FrPlayerStatsRebBreak02[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 3) {
					InitialShotString = StatsRebBreak03.FrPlayerStatsRebBreak03[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 4) {
					InitialShotString = StatsRebBreak04.FrPlayerStatsRebBreak04[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 5) {
					InitialShotString = StatsRebBreak05.FrPlayerStatsRebBreak05[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 6) {
					InitialShotString = StatsRebBreak06.FrPlayerStatsRebBreak06[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 7) {
					InitialShotString = StatsRebBreak07.FrPlayerStatsRebBreak07[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 8) {
					InitialShotString = StatsRebBreak08.FrPlayerStatsRebBreak08[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 9) {
					InitialShotString = StatsRebBreak09.FrPlayerStatsRebBreak09[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 10) {
					InitialShotString = StatsRebBreak10.FrPlayerStatsRebBreak10[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 11) {
					InitialShotString = StatsRebBreak11.FrPlayerStatsRebBreak11[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}

				else if (DiceRoll == 12) {
					InitialShotString = StatsRebBreak12.FrPlayerStatsRebBreak12[CurrentShooter + PlayerDatabase.PlayerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (DiceRoll == 2) {
					InitialShotString = StatsRebBreak02.FrPlayerStatsRebBreak02[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 3) {
					InitialShotString = StatsRebBreak03.FrPlayerStatsRebBreak03[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 4) {
					InitialShotString = StatsRebBreak04.FrPlayerStatsRebBreak04[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 5) {
					InitialShotString = StatsRebBreak05.FrPlayerStatsRebBreak05[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 6) {
					InitialShotString = StatsRebBreak06.FrPlayerStatsRebBreak06[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 7) {
					InitialShotString = StatsRebBreak07.FrPlayerStatsRebBreak07[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 8) {
					InitialShotString = StatsRebBreak08.FrPlayerStatsRebBreak08[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 9) {
					InitialShotString = StatsRebBreak09.FrPlayerStatsRebBreak09[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 10) {
					InitialShotString = StatsRebBreak10.FrPlayerStatsRebBreak10[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 11) {
					InitialShotString = StatsRebBreak11.FrPlayerStatsRebBreak11[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}

				else if (DiceRoll == 12) {
					InitialShotString = StatsRebBreak12.FrPlayerStatsRebBreak12[CurrentShooter + PlayerDatabase.ComputerChosenTeam];
				}
			}
		}

		// Determine Goal / G. Rating / Other
		if ((InitialShotString.Contains("Goal")) || (InitialShotString.Contains("Goal+"))) {
			DetermineGoal();
		}

		else if ((InitialShotString.Contains("G. Rating")) || (InitialShotString.Contains("G. Rating+"))) {
			DetermineGoalieRating();
		}

		else {
			Scene26CLoadRun.Scene26CLoad();
		}
	}

	public void DetermineGoal() {
		// Randomize Split Number
		SplitCardNumber = Random.Range(1,21);

		// Determine Goal
		if ((InitialShotString == "Goal: 1") || (InitialShotString == "Goal+: 1")) {
			if (SplitCardNumber <= 1) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-2") || (InitialShotString == "Goal+: 1-2")) {
			if (SplitCardNumber <= 2) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-3") || (InitialShotString == "Goal+: 1-3")) {
			if (SplitCardNumber <= 3) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-4") || (InitialShotString == "Goal+: 1-4")) {
			if (SplitCardNumber <= 4) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-5") || (InitialShotString == "Goal+: 1-5")) {
			if (SplitCardNumber <= 5) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-6") || (InitialShotString == "Goal+: 1-6")) {
			if (SplitCardNumber <= 6) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-7") || (InitialShotString == "Goal+: 1-7")) {
			if (SplitCardNumber <= 7) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-8") || (InitialShotString == "Goal+: 1-8")) {
			if (SplitCardNumber <= 8) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-9") || (InitialShotString == "Goal+: 1-9")) {
			if (SplitCardNumber <= 9) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-10") || (InitialShotString == "Goal+: 1-10")) {
			if (SplitCardNumber <= 10) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-11") || (InitialShotString == "Goal+: 1-11")) {
			if (SplitCardNumber <= 11) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-12") || (InitialShotString == "Goal+: 1-12")) {
			if (SplitCardNumber <= 12) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-13") || (InitialShotString == "Goal+: 1-13")) {
			if (SplitCardNumber <= 13) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-14") || (InitialShotString == "Goal+: 1-14")) {
			if (SplitCardNumber <= 14) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-15") || (InitialShotString == "Goal+: 1-15")) {
			if (SplitCardNumber <= 15) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-16") || (InitialShotString == "Goal+: 1-16")) {
			if (SplitCardNumber <= 16) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-17") || (InitialShotString == "Goal+: 1-17")) {
			if (SplitCardNumber <= 17) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-18") || (InitialShotString == "Goal+: 1-18")) {
			if (SplitCardNumber <= 18) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-19") || (InitialShotString == "Goal+: 1-19")) {
			if (SplitCardNumber <= 19) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}

		else if ((InitialShotString == "Goal: 1-20") || (InitialShotString == "Goal+: 1-20")) {
			if (SplitCardNumber <= 20) {
				Scene26DLoadRun.Scene26DLoad();
			}

			else {
				Scene26CLoadRun.Scene26CLoad();
			}
		}
	}

	public void DetermineGoalieRating() {
		// Randomize G. Rating Dice Roll
		GRatingDiceA = Random.Range(1,7);
		GRatingDiceB = Random.Range(1,7);
		GRatingDice = GRatingDiceA + GRatingDiceB;

		// Get Goalie Rating String
		if (GRatingDice == 2) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating02.PlayerGStatsGoalieRating02[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating02.FrPlayerGStatsGoalieRating02[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating02.PlayerGStatsGoalieRating02[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating02.FrPlayerGStatsGoalieRating02[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 3) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating03.PlayerGStatsGoalieRating03[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating03.FrPlayerGStatsGoalieRating03[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating03.PlayerGStatsGoalieRating03[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating03.FrPlayerGStatsGoalieRating03[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 4) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating04.PlayerGStatsGoalieRating04[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating04.FrPlayerGStatsGoalieRating04[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating04.PlayerGStatsGoalieRating04[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating04.FrPlayerGStatsGoalieRating04[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 5) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating05.PlayerGStatsGoalieRating05[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating05.FrPlayerGStatsGoalieRating05[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating05.PlayerGStatsGoalieRating05[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating05.FrPlayerGStatsGoalieRating05[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 6) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating06.PlayerGStatsGoalieRating06[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating06.FrPlayerGStatsGoalieRating06[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating06.PlayerGStatsGoalieRating06[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating06.FrPlayerGStatsGoalieRating06[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 7) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating07.PlayerGStatsGoalieRating07[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating07.FrPlayerGStatsGoalieRating07[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating07.PlayerGStatsGoalieRating07[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating07.FrPlayerGStatsGoalieRating07[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 8) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating08.PlayerGStatsGoalieRating08[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating08.FrPlayerGStatsGoalieRating08[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating08.PlayerGStatsGoalieRating08[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating08.FrPlayerGStatsGoalieRating08[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 9) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating09.PlayerGStatsGoalieRating09[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating09.FrPlayerGStatsGoalieRating09[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating09.PlayerGStatsGoalieRating09[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating09.FrPlayerGStatsGoalieRating09[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 10) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating10.PlayerGStatsGoalieRating10[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating10.FrPlayerGStatsGoalieRating10[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating10.PlayerGStatsGoalieRating10[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating10.FrPlayerGStatsGoalieRating10[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 11) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating11.PlayerGStatsGoalieRating11[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating11.FrPlayerGStatsGoalieRating11[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating11.PlayerGStatsGoalieRating11[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating11.FrPlayerGStatsGoalieRating11[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		else if (GRatingDice == 12) {
			if (EnableObjects26B.ShootoutTurnString == "P1") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating12.PlayerGStatsGoalieRating12[PlayerDatabase.P2G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating12.FrPlayerGStatsGoalieRating12[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
				}
			}

			else if (EnableObjects26B.ShootoutTurnString == "P2") {
				if (PlayerDatabase.CurrentFranchiseSelect == 1) {
					GRatingShotString = GStatsGoalieRating12.PlayerGStatsGoalieRating12[PlayerDatabase.P1G];
				}

				else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
					GRatingShotString = GStatsGoalieRating12.FrPlayerGStatsGoalieRating12[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
				}
			}
		}

		// Determine Goal
		if ((GRatingShotString == "Goal") || (GRatingShotString.Contains("IRB: Goal"))) {
			Scene26DLoadRun.Scene26DLoad();
		}

		else {
			Scene26CLoadRun.Scene26CLoad();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}