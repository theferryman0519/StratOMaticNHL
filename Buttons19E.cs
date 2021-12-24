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

public class Buttons19E : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button ShotButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int RollNumberA;
	public static int RollNumberB;
	public static int RollNumber;
	public static int GoalieRatingRollA;
	public static int GoalieRatingRollB;
	public static int GoalieRatingRoll;
	public static int SplitCardNumber;
	public static string ShotSelection;
	public static string GoalieRatingSelection;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene19FLoadRun;
	public SceneChange Scene19GLoadRun;
	
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
		// Randomize Rolls
		RollNumberA = Random.Range(1,7);
		RollNumberB = Random.Range(1,7);
		RollNumber = RollNumberA + RollNumberB;

		// Determine Shot
		if (RollNumber == 2) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 3) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 4) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 5) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 6) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 7) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 8) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 9) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 10) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 11) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		else if (RollNumber == 12) {
			if (Buttons19D.PowerplayShotTracker == 1) {
				if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 2) {
				if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 3) {
				if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 4) {
				if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}

			else if (Buttons19D.PowerplayShotTracker == 5) {
				if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}
					}
				}

				else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
					if (PlayerDatabase.CurrentFranchiseSelect == 1) {
						ShotSelection = StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5];
					}

					else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
						if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
						}

						else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
							ShotSelection = StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
						}
					}
				}
			}
		}

		// Determine Goal / GR / Save / Loss
		if ((ShotSelection.Contains("Shot")) || (ShotSelection.Contains("Save")) || (ShotSelection.Contains("Rebound"))) {
			EnableObjects19F.SaveOrLoss = "Save";
			Scene19FLoadRun.Scene19FLoad();
		}

		else if ((ShotSelection.Contains("Goal")) || (ShotSelection.Contains("Goal+"))) {
			DetermineGoal();
		}

		else if ((ShotSelection.Contains("G. Rating")) || (ShotSelection.Contains("G. Rating+"))) {
			DetermineGoalieRating();
		}

		else {
			EnableObjects19F.SaveOrLoss = "Loss";
			Scene19FLoadRun.Scene19FLoad();
		}
	}

	public void DetermineGoal() {
		// Randomize Split Number
		SplitCardNumber = Random.Range(1,21);

		// Determine Goal
		if ((ShotSelection == "Goal: 1") || (ShotSelection == "Goal+: 1")) {
			if (SplitCardNumber <= 1) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-2") || (ShotSelection == "Goal+: 1-2")) {
			if (SplitCardNumber <= 2) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-3") || (ShotSelection == "Goal+: 1-3")) {
			if (SplitCardNumber <= 3) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-4") || (ShotSelection == "Goal+: 1-4")) {
			if (SplitCardNumber <= 4) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-5") || (ShotSelection == "Goal+: 1-5")) {
			if (SplitCardNumber <= 5) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-6") || (ShotSelection == "Goal+: 1-6")) {
			if (SplitCardNumber <= 6) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-7") || (ShotSelection == "Goal+: 1-7")) {
			if (SplitCardNumber <= 7) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-8") || (ShotSelection == "Goal+: 1-8")) {
			if (SplitCardNumber <= 8) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-9") || (ShotSelection == "Goal+: 1-9")) {
			if (SplitCardNumber <= 9) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-10") || (ShotSelection == "Goal+: 1-10")) {
			if (SplitCardNumber <= 10) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-11") || (ShotSelection == "Goal+: 1-11")) {
			if (SplitCardNumber <= 11) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-12") || (ShotSelection == "Goal+: 1-12")) {
			if (SplitCardNumber <= 12) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-13") || (ShotSelection == "Goal+: 1-13")) {
			if (SplitCardNumber <= 13) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-14") || (ShotSelection == "Goal+: 1-14")) {
			if (SplitCardNumber <= 14) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-15") || (ShotSelection == "Goal+: 1-15")) {
			if (SplitCardNumber <= 15) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-16") || (ShotSelection == "Goal+: 1-16")) {
			if (SplitCardNumber <= 16) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-17") || (ShotSelection == "Goal+: 1-17")) {
			if (SplitCardNumber <= 17) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-18") || (ShotSelection == "Goal+: 1-18")) {
			if (SplitCardNumber <= 18) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-19") || (ShotSelection == "Goal+: 1-19")) {
			if (SplitCardNumber <= 19) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}

		else if ((ShotSelection == "Goal: 1-20") || (ShotSelection == "Goal+: 1-20")) {
			if (SplitCardNumber <= 20) {
				Scene19GLoadRun.Scene19GLoad();
			}

			else {
				EnableObjects19F.SaveOrLoss = "Save";
				Scene19FLoadRun.Scene19FLoad();
			}
		}
	}

	public void DetermineGoalieRating() {
		// Randomize Dice Roll
		GoalieRatingRollA = Random.Range(1,7);
		GoalieRatingRollB = Random.Range(1,7);
		GoalieRatingRoll = GoalieRatingRollA + GoalieRatingRollB;

		// Determine Goalie Rating
		if (GoalieRatingRoll == 2) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating02.PlayerGStatsGoalieRating02[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating02.PlayerGStatsGoalieRating02[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating02.PlayerGStatsGoalieRating02[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating02.PlayerGStatsGoalieRating02[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating02.FrPlayerGStatsGoalieRating02[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating02.FrPlayerGStatsGoalieRating02[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating02.FrPlayerGStatsGoalieRating02[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating02.FrPlayerGStatsGoalieRating02[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 3) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating03.PlayerGStatsGoalieRating03[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating03.PlayerGStatsGoalieRating03[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating03.PlayerGStatsGoalieRating03[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating03.PlayerGStatsGoalieRating03[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating03.FrPlayerGStatsGoalieRating03[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating03.FrPlayerGStatsGoalieRating03[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating03.FrPlayerGStatsGoalieRating03[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating03.FrPlayerGStatsGoalieRating03[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 4) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating04.PlayerGStatsGoalieRating04[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating04.PlayerGStatsGoalieRating04[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating04.PlayerGStatsGoalieRating04[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating04.PlayerGStatsGoalieRating04[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating04.FrPlayerGStatsGoalieRating04[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating04.FrPlayerGStatsGoalieRating04[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating04.FrPlayerGStatsGoalieRating04[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating04.FrPlayerGStatsGoalieRating04[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 5) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating05.PlayerGStatsGoalieRating05[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating05.PlayerGStatsGoalieRating05[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating05.PlayerGStatsGoalieRating05[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating05.PlayerGStatsGoalieRating05[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating05.FrPlayerGStatsGoalieRating05[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating05.FrPlayerGStatsGoalieRating05[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating05.FrPlayerGStatsGoalieRating05[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating05.FrPlayerGStatsGoalieRating05[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 6) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating06.PlayerGStatsGoalieRating06[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating06.PlayerGStatsGoalieRating06[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating06.PlayerGStatsGoalieRating06[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating06.PlayerGStatsGoalieRating06[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating06.FrPlayerGStatsGoalieRating06[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating06.FrPlayerGStatsGoalieRating06[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating06.FrPlayerGStatsGoalieRating06[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating06.FrPlayerGStatsGoalieRating06[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 7) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating07.PlayerGStatsGoalieRating07[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating07.PlayerGStatsGoalieRating07[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating07.PlayerGStatsGoalieRating07[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating07.PlayerGStatsGoalieRating07[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating07.FrPlayerGStatsGoalieRating07[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating07.FrPlayerGStatsGoalieRating07[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating07.FrPlayerGStatsGoalieRating07[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating07.FrPlayerGStatsGoalieRating07[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 8) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating08.PlayerGStatsGoalieRating08[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating08.PlayerGStatsGoalieRating08[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating08.PlayerGStatsGoalieRating08[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating08.PlayerGStatsGoalieRating08[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating08.FrPlayerGStatsGoalieRating08[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating08.FrPlayerGStatsGoalieRating08[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating08.FrPlayerGStatsGoalieRating08[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating08.FrPlayerGStatsGoalieRating08[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 9) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating09.PlayerGStatsGoalieRating09[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating09.PlayerGStatsGoalieRating09[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating09.PlayerGStatsGoalieRating09[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating09.PlayerGStatsGoalieRating09[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating09.FrPlayerGStatsGoalieRating09[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating09.FrPlayerGStatsGoalieRating09[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating09.FrPlayerGStatsGoalieRating09[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating09.FrPlayerGStatsGoalieRating09[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 10) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating10.PlayerGStatsGoalieRating10[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating10.PlayerGStatsGoalieRating10[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating10.PlayerGStatsGoalieRating10[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating10.PlayerGStatsGoalieRating10[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating10.FrPlayerGStatsGoalieRating10[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating10.FrPlayerGStatsGoalieRating10[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating10.FrPlayerGStatsGoalieRating10[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating10.FrPlayerGStatsGoalieRating10[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 11) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating11.PlayerGStatsGoalieRating11[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating11.PlayerGStatsGoalieRating11[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating11.PlayerGStatsGoalieRating11[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating11.PlayerGStatsGoalieRating11[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating11.FrPlayerGStatsGoalieRating11[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating11.FrPlayerGStatsGoalieRating11[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating11.FrPlayerGStatsGoalieRating11[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating11.FrPlayerGStatsGoalieRating11[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		else if (GoalieRatingRoll == 12) {
			if (PlayerDatabase.CurrentFranchiseSelect == 1) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating12.PlayerGStatsGoalieRating12[PlayerDatabase.P2G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating12.PlayerGStatsGoalieRating12[PlayerDatabase.P1G];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating12.PlayerGStatsGoalieRating12[PlayerDatabase.P1G];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating12.PlayerGStatsGoalieRating12[PlayerDatabase.P2G];
					}
				}
			}

			else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
				if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating12.FrPlayerGStatsGoalieRating12[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating12.FrPlayerGStatsGoalieRating12[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}
				}

				else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
					if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
						GoalieRatingSelection = GStatsGoalieRating12.FrPlayerGStatsGoalieRating12[PlayerDatabase.P1G + PlayerDatabase.PlayerChosenTeam];
					}

					else {
						GoalieRatingSelection = GStatsGoalieRating12.FrPlayerGStatsGoalieRating12[PlayerDatabase.P2G + PlayerDatabase.ComputerChosenTeam];
					}
				}
			}			
		}

		// Determine Goal / GR / Save / Loss
		if (GoalieRatingSelection == "Goal") {
			Scene19GLoadRun.Scene19GLoad();
		}

		else {
			EnableObjects19F.SaveOrLoss = "Save";
			Scene19FLoadRun.Scene19FLoad();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}