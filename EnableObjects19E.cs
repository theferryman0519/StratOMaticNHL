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

public class EnableObjects19E : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Image ShotButton;

	// Scoreboard Objects
	public Image ScoreboardBackground;
	public Text P1Score;
	public Text P2Score;
	public Text P1Shots;
	public Text P2Shots;
	public Text Period;
	public Text Play;

    // Special Teams
    public Text ShotSelectionTitle;
    public Text ShotSelectionActionText;
    public Text ShotSelection02;
    public Text ShotSelection03;
    public Text ShotSelection04;
    public Text ShotSelection05;
    public Text ShotSelection06;
    public Text ShotSelection07;
    public Text ShotSelection08;
    public Text ShotSelection09;
    public Text ShotSelection10;
    public Text ShotSelection11;
    public Text ShotSelection12;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMainObjects();
		EnableScoreboardObjects();
        EnableSpecialTeamText();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingScoreboard();
        UpdatingShotSelection();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ShotButton.enabled = true;
	}

	public void EnableScoreboardObjects() {
		ScoreboardBackground.enabled = true;
		P1Score.enabled = true;
		P2Score.enabled = true;
		P1Shots.enabled = true;
		P2Shots.enabled = true;
		Period.enabled = true;
		Play.enabled = true;
	}

    public void EnableSpecialTeamText() {
        ShotSelectionTitle.enabled = true;
        ShotSelectionActionText.enabled = true;
        ShotSelection02.enabled = true;
        ShotSelection03.enabled = true;
        ShotSelection04.enabled = true;
        ShotSelection05.enabled = true;
        ShotSelection06.enabled = true;
        ShotSelection07.enabled = true;
        ShotSelection08.enabled = true;
        ShotSelection09.enabled = true;
        ShotSelection10.enabled = true;
        ShotSelection11.enabled = true;
        ShotSelection12.enabled = true;
    }

// --------------- DISABLING OBEJCTS FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ShotButton.enabled = false;
	}

	public void DisableScoreboardObjects() {
		ScoreboardBackground.enabled = false;
		P1Score.enabled = false;
		P2Score.enabled = false;
		P1Shots.enabled = false;
		P2Shots.enabled = false;
		Period.enabled = false;
		Play.enabled = false;
	}

    public void DisableSpecialTeamText() {
        ShotSelectionTitle.enabled = false;
        ShotSelectionActionText.enabled = false;
        ShotSelection02.enabled = false;
        ShotSelection03.enabled = false;
        ShotSelection04.enabled = false;
        ShotSelection05.enabled = false;
        ShotSelection06.enabled = false;
        ShotSelection07.enabled = false;
        ShotSelection08.enabled = false;
        ShotSelection09.enabled = false;
        ShotSelection10.enabled = false;
        ShotSelection11.enabled = false;
        ShotSelection12.enabled = false;
    }

// --------------- UPDATING TEXT FUNCTIONS ---------------
	public void UpdatingScoreboard() {
		P1Score.text = PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.GameplayP1Score;
		P2Score.text = PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.GameplayP2Score;
		P1Shots.text = PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.GameplayP1Shots + " shots";
		P2Shots.text = PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.GameplayP2Shots + " shots";
		Play.text = "Play: " + PlayerDatabase.GameplayPlay;

		if (PlayerDatabase.GameplayPeriod == "1") {
			Period.text = "1st Period";
		}

		else if (PlayerDatabase.GameplayPeriod == "2") {
			Period.text = "2nd Period";
		}

		else if (PlayerDatabase.GameplayPeriod == "3") {
			Period.text = "3rd Period";
		}

		else if (PlayerDatabase.GameplayPeriod == "4") {
			Period.text = "Overtime";
		}

		else if (PlayerDatabase.GameplayPeriod == "5") {
			Period.text = "Shootout";
		}
	}

    public void UpdatingShotSelection() {
        // Determine Shot
        if (Buttons19D.PowerplayShotTracker == 1) {
            if (EnableObjects19D.FinalShotSelection1.Contains("Outside")) {
                ShotSelectionTitle.text = "Outside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection1 + " first has a chance at an outside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection03.text = "3)" + "\n" + StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection04.text = "4)" + "\n" + StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection05.text = "5)" + "\n" + StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection06.text = "6)" + "\n" + StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection07.text = "7)" + "\n" + StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection08.text = "8)" + "\n" + StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection09.text = "9)" + "\n" + StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection10.text = "10)" + "\n" + StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection11.text = "11)" + "\n" + StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection12.text = "12)" + "\n" + StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection1];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection1.Contains("Inside")) {
                ShotSelectionTitle.text = "Inside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection1 + " first has a chance at an inside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection03.text = "3)" + "\n" + StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection04.text = "4)" + "\n" + StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection05.text = "5)" + "\n" + StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection06.text = "6)" + "\n" + StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection07.text = "7)" + "\n" + StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection08.text = "8)" + "\n" + StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection09.text = "9)" + "\n" + StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection10.text = "10)" + "\n" + StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection11.text = "11)" + "\n" + StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection12.text = "12)" + "\n" + StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection1];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection1.Contains("Rebound")) {
                ShotSelectionTitle.text = "Rebound Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection1 + " first has a chance at a rebound shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection1.Contains("Breakaway")) {
                ShotSelectionTitle.text = "Breakaway Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection1 + " first has a chance at a short-handed breakaway shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection1 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }
        }

        else if (Buttons19D.PowerplayShotTracker == 2) {
            if (EnableObjects19D.FinalShotSelection2.Contains("Outside")) {
                ShotSelectionTitle.text = "Outside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection2 + " now has a chance at an outside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection03.text = "3)" + "\n" + StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection04.text = "4)" + "\n" + StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection05.text = "5)" + "\n" + StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection06.text = "6)" + "\n" + StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection07.text = "7)" + "\n" + StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection08.text = "8)" + "\n" + StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection09.text = "9)" + "\n" + StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection10.text = "10)" + "\n" + StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection11.text = "11)" + "\n" + StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection12.text = "12)" + "\n" + StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection2];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection2.Contains("Inside")) {
                ShotSelectionTitle.text = "Inside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection2 + " now has a chance at an inside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection03.text = "3)" + "\n" + StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection04.text = "4)" + "\n" + StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection05.text = "5)" + "\n" + StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection06.text = "6)" + "\n" + StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection07.text = "7)" + "\n" + StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection08.text = "8)" + "\n" + StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection09.text = "9)" + "\n" + StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection10.text = "10)" + "\n" + StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection11.text = "11)" + "\n" + StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection12.text = "12)" + "\n" + StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection2];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection2.Contains("Rebound")) {
                ShotSelectionTitle.text = "Rebound Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection2 + " now has a chance at a rebound shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection2.Contains("Breakaway")) {
                ShotSelectionTitle.text = "Breakaway Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection2 + " now has a chance at a short-handed breakaway shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection2 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }
        }

        else if (Buttons19D.PowerplayShotTracker == 3) {
            if (EnableObjects19D.FinalShotSelection3.Contains("Outside")) {
                ShotSelectionTitle.text = "Outside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection3 + " now has a chance at an outside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection03.text = "3)" + "\n" + StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection04.text = "4)" + "\n" + StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection05.text = "5)" + "\n" + StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection06.text = "6)" + "\n" + StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection07.text = "7)" + "\n" + StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection08.text = "8)" + "\n" + StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection09.text = "9)" + "\n" + StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection10.text = "10)" + "\n" + StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection11.text = "11)" + "\n" + StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection12.text = "12)" + "\n" + StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection3];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection3.Contains("Inside")) {
                ShotSelectionTitle.text = "Inside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection3 + " now has a chance at an inside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection03.text = "3)" + "\n" + StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection04.text = "4)" + "\n" + StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection05.text = "5)" + "\n" + StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection06.text = "6)" + "\n" + StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection07.text = "7)" + "\n" + StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection08.text = "8)" + "\n" + StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection09.text = "9)" + "\n" + StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection10.text = "10)" + "\n" + StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection11.text = "11)" + "\n" + StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection12.text = "12)" + "\n" + StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection3];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection3.Contains("Rebound")) {
                ShotSelectionTitle.text = "Rebound Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection3 + " now has a chance at a rebound shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection3.Contains("Breakaway")) {
                ShotSelectionTitle.text = "Breakaway Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection3 + " now has a chance at a short-handed breakaway shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection3 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }
        }

        else if (Buttons19D.PowerplayShotTracker == 4) {
            if (EnableObjects19D.FinalShotSelection4.Contains("Outside")) {
                ShotSelectionTitle.text = "Outside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection4 + " now has a chance at an outside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection03.text = "3)" + "\n" + StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection04.text = "4)" + "\n" + StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection05.text = "5)" + "\n" + StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection06.text = "6)" + "\n" + StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection07.text = "7)" + "\n" + StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection08.text = "8)" + "\n" + StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection09.text = "9)" + "\n" + StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection10.text = "10)" + "\n" + StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection11.text = "11)" + "\n" + StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection12.text = "12)" + "\n" + StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection4];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection4.Contains("Inside")) {
                ShotSelectionTitle.text = "Inside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection4 + " now has a chance at an inside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection03.text = "3)" + "\n" + StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection04.text = "4)" + "\n" + StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection05.text = "5)" + "\n" + StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection06.text = "6)" + "\n" + StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection07.text = "7)" + "\n" + StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection08.text = "8)" + "\n" + StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection09.text = "9)" + "\n" + StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection10.text = "10)" + "\n" + StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection11.text = "11)" + "\n" + StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection12.text = "12)" + "\n" + StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection4];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection4.Contains("Rebound")) {
                ShotSelectionTitle.text = "Rebound Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection4 + " now has a chance at a rebound shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection4.Contains("Breakaway")) {
                ShotSelectionTitle.text = "Breakaway Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection4 + " now has a chance at a short-handed breakaway shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection4 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }
        }

        else if (Buttons19D.PowerplayShotTracker == 5) {
            if (EnableObjects19D.FinalShotSelection5.Contains("Outside")) {
                ShotSelectionTitle.text = "Outside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection5 + " now has a chance at an outside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsOutside02.PlayerStatsOutside02[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection03.text = "3)" + "\n" + StatsOutside03.PlayerStatsOutside03[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection04.text = "4)" + "\n" + StatsOutside04.PlayerStatsOutside04[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection05.text = "5)" + "\n" + StatsOutside05.PlayerStatsOutside05[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection06.text = "6)" + "\n" + StatsOutside06.PlayerStatsOutside06[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection07.text = "7)" + "\n" + StatsOutside07.PlayerStatsOutside07[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection08.text = "8)" + "\n" + StatsOutside08.PlayerStatsOutside08[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection09.text = "9)" + "\n" + StatsOutside09.PlayerStatsOutside09[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection10.text = "10)" + "\n" + StatsOutside10.PlayerStatsOutside10[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection11.text = "11)" + "\n" + StatsOutside11.PlayerStatsOutside11[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection12.text = "12)" + "\n" + StatsOutside12.PlayerStatsOutside12[EnableObjects19D.FinalShooterSelection5];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsOutside02.FrPlayerStatsOutside02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsOutside03.FrPlayerStatsOutside03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsOutside04.FrPlayerStatsOutside04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsOutside05.FrPlayerStatsOutside05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsOutside06.FrPlayerStatsOutside06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsOutside07.FrPlayerStatsOutside07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsOutside08.FrPlayerStatsOutside08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsOutside09.FrPlayerStatsOutside09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsOutside10.FrPlayerStatsOutside10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsOutside11.FrPlayerStatsOutside11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsOutside12.FrPlayerStatsOutside12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection5.Contains("Inside")) {
                ShotSelectionTitle.text = "Inside Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection5 + " now has a chance at an inside shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsInside02.PlayerStatsInside02[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection03.text = "3)" + "\n" + StatsInside03.PlayerStatsInside03[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection04.text = "4)" + "\n" + StatsInside04.PlayerStatsInside04[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection05.text = "5)" + "\n" + StatsInside05.PlayerStatsInside05[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection06.text = "6)" + "\n" + StatsInside06.PlayerStatsInside06[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection07.text = "7)" + "\n" + StatsInside07.PlayerStatsInside07[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection08.text = "8)" + "\n" + StatsInside08.PlayerStatsInside08[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection09.text = "9)" + "\n" + StatsInside09.PlayerStatsInside09[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection10.text = "10)" + "\n" + StatsInside10.PlayerStatsInside10[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection11.text = "11)" + "\n" + StatsInside11.PlayerStatsInside11[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection12.text = "12)" + "\n" + StatsInside12.PlayerStatsInside12[EnableObjects19D.FinalShooterSelection5];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsInside02.FrPlayerStatsInside02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsInside03.FrPlayerStatsInside03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsInside04.FrPlayerStatsInside04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsInside05.FrPlayerStatsInside05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsInside06.FrPlayerStatsInside06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsInside07.FrPlayerStatsInside07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsInside08.FrPlayerStatsInside08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsInside09.FrPlayerStatsInside09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsInside10.FrPlayerStatsInside10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsInside11.FrPlayerStatsInside11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsInside12.FrPlayerStatsInside12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection5.Contains("Rebound")) {
                ShotSelectionTitle.text = "Rebound Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection5 + " now has a chance at a rebound shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }

            else if (EnableObjects19D.FinalShotSelection5.Contains("Breakaway")) {
                ShotSelectionTitle.text = "Breakaway Shot";
                ShotSelectionActionText.text = EnableObjects19D.FinalShooterSelection5 + " now has a chance at a short-handed breakaway shot.";

                if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                    ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5];
                    ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5];
                }

                else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                    if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.ComputerChosenTeam];
                    }

                    else if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
                        ShotSelection02.text = "2)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection03.text = "3)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection04.text = "4)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection05.text = "5)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection06.text = "6)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection07.text = "7)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection08.text = "8)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection09.text = "9)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                        ShotSelection12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[EnableObjects19D.FinalShooterSelection5 + PlayerDatabase.PlayerChosenTeam];
                    }
                }
            }
        }
    }

// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}