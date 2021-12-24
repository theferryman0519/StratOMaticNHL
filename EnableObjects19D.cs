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

public class EnableObjects19D : MonoBehaviour {
		
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
    public Text ShotSelectionA;
    public Text ShotSelectionB;
    public Text ShotSelectionC;
    public Text ShotSelectionD;
    public Text ShotSelectionE;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string DefenseRatingNeed;
    public static string DefenseRatingLW;
    public static string DefenseRatingRW;
    public static string DefenseRatingLD;
    public static string DefenseRatingRD;
    public static int DefenseFourSumLW;
    public static int DefenseFourSumRW;
    public static int DefenseFourSumLD;
    public static int DefenseFourSumRD;
    public static int DefenseFourSum;

    public static int SplitNumber;
    public static int RandomizeAnyShooter;
    public static string DefenseRatingYesNo;

    public static string YesShotSelection1;
    public static string YesShotSelection2;
    public static string YesShotSelection3;
    public static string YesShotSelection4;
    public static string YesShotSelection5;
    public static string YesShooterSelection1;
    public static string YesShooterSelection2;
    public static string YesShooterSelection3;
    public static string YesShooterSelection4;
    public static string YesShooterSelection5;

    public static string NoShotSelection1;
    public static string NoShotSelection2;
    public static string NoShotSelection3;
    public static string NoShotSelection4;
    public static string NoShotSelection5;
    public static string NoShooterSelection1;
    public static string NoShooterSelection2;
    public static string NoShooterSelection3;
    public static string NoShooterSelection4;
    public static string NoShooterSelection5;

    public static string FinalShotSelection1;
    public static string FinalShotSelection2;
    public static string FinalShotSelection3;
    public static string FinalShotSelection4;
    public static string FinalShotSelection5;
    public static string FinalShooterSelection1;
    public static string FinalShooterSelection2;
    public static string FinalShooterSelection3;
    public static string FinalShooterSelection4;
    public static string FinalShooterSelection5;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMainObjects();
		EnableScoreboardObjects();
        EnableSpecialTeamText();
        DefenseFourSum = 0;
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
        ShotSelectionA.enabled = true;
        ShotSelectionB.enabled = true;
        ShotSelectionC.enabled = true;
        ShotSelectionD.enabled = true;
        ShotSelectionE.enabled = true;
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
        ShotSelectionA.enabled = false;
        ShotSelectionB.enabled = false;
        ShotSelectionC.enabled = false;
        ShotSelectionD.enabled = false;
        ShotSelectionE.enabled = false;
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
        // Determine PK Unit Defenses
        if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
            if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKLW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKRW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKLD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKRD];
                }

                else if ((PlayerDatabase.P1PKLW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKExW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKRW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKLD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKRD];
                }

                else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKLW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKExW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKLD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKRD];
                }

                else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKLW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKRW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKExD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKRD];
                }

                else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD == PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKLW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKRW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKLD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P1PKExD];
                }
            }

            else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKLW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKRW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKLD + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKRD + PlayerDatabase.PlayerChosenTeam];
                }

                else if ((PlayerDatabase.P1PKLW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKExW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKRW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKLD + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKRD + PlayerDatabase.PlayerChosenTeam];
                }

                else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKLW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKExW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKLD + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKRD + PlayerDatabase.PlayerChosenTeam];
                }

                else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKLW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKRW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKExD + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKRD + PlayerDatabase.PlayerChosenTeam];
                }

                else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD == PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKLW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKRW + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKLD + PlayerDatabase.PlayerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1PKExD + PlayerDatabase.PlayerChosenTeam];
                }
            }
        }

        else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
            if (PlayerDatabase.CurrentFranchiseSelect == 1) {
                if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKLW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKRW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKLD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKRD];
                }

                else if ((PlayerDatabase.P2PKLW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKExW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKRW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKLD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKRD];
                }

                else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKLW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKExW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKLD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKRD];
                }

                else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKLW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKRW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKExD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKRD];
                }

                else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD == PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKLW];
                    DefenseRatingRW = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKRW];
                    DefenseRatingLD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKLD];
                    DefenseRatingRD = StatsDefense.PlayerStatsDefense[PlayerDatabase.P2PKExD];
                }
            }

            else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
                if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKLW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKRW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKLD + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKRD + PlayerDatabase.ComputerChosenTeam];
                }

                else if ((PlayerDatabase.P2PKLW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKExW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKRW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKLD + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKRD + PlayerDatabase.ComputerChosenTeam];
                }

                else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKLW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKExW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKLD + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKRD + PlayerDatabase.ComputerChosenTeam];
                }

                else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKLW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKRW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKExD + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKRD + PlayerDatabase.ComputerChosenTeam];
                }

                else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD == PlayerDatabase.GameplayPenaltyPlayer)) {
                    DefenseRatingLW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKLW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRW = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKRW + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingLD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKLD + PlayerDatabase.ComputerChosenTeam];
                    DefenseRatingRD = StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2PKExD + PlayerDatabase.ComputerChosenTeam];
                }
            }
        }

        // Determine Shot Selections
        if (DefenseRatingNeed == "LD2") {
            if (System.Int32.Parse(DefenseRatingLD) >= 2) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "LD3") {
            if (System.Int32.Parse(DefenseRatingLD) >= 3) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "LD4") {
            if (System.Int32.Parse(DefenseRatingLD) >= 4) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "RD2") {
            if (System.Int32.Parse(DefenseRatingRD) >= 2) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "RD3") {
            if (System.Int32.Parse(DefenseRatingRD) >= 3) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "RD4") {
            if (System.Int32.Parse(DefenseRatingRD) >= 4) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "LW2") {
            if (System.Int32.Parse(DefenseRatingLW) >= 2) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "LW3") {
            if (System.Int32.Parse(DefenseRatingLW) >= 3) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "LW4") {
            if (System.Int32.Parse(DefenseRatingLW) >= 4) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "RW2") {
            if (System.Int32.Parse(DefenseRatingRW) >= 2) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "RW3") {
            if (System.Int32.Parse(DefenseRatingRW) >= 3) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "RW4") {
            if (System.Int32.Parse(DefenseRatingRW) >= 4) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "1All4") {
            // LW
            if (System.Int32.Parse(DefenseRatingLW) >= 4) {
                DefenseFourSumLW = 1;
            }

            else {
                DefenseFourSumLW = 0;
            }

            // RW
            if (System.Int32.Parse(DefenseRatingRW) >= 4) {
                DefenseFourSumRW = 1;
            }

            else {
                DefenseFourSumRW = 0;
            }

            // LD
            if (System.Int32.Parse(DefenseRatingLD) >= 4) {
                DefenseFourSumLD = 1;
            }

            else {
                DefenseFourSumLD = 0;
            }

            // RD
            if (System.Int32.Parse(DefenseRatingRD) >= 4) {
                DefenseFourSumRD = 1;
            }

            else {
                DefenseFourSumRD = 0;
            }

            // Sum of All
            DefenseFourSum = DefenseFourSumLW + DefenseFourSumRW + DefenseFourSumLD + DefenseFourSumRD;

            if (DefenseFourSum >= 1) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "2All4") {
            // LW
            if (System.Int32.Parse(DefenseRatingLW) >= 4) {
                DefenseFourSumLW = 1;
            }

            else {
                DefenseFourSumLW = 0;
            }

            // RW
            if (System.Int32.Parse(DefenseRatingRW) >= 4) {
                DefenseFourSumRW = 1;
            }

            else {
                DefenseFourSumRW = 0;
            }

            // LD
            if (System.Int32.Parse(DefenseRatingLD) >= 4) {
                DefenseFourSumLD = 1;
            }

            else {
                DefenseFourSumLD = 0;
            }

            // RD
            if (System.Int32.Parse(DefenseRatingRD) >= 4) {
                DefenseFourSumRD = 1;
            }

            else {
                DefenseFourSumRD = 0;
            }

            // Sum of All
            DefenseFourSum = DefenseFourSumLW + DefenseFourSumRW + DefenseFourSumLD + DefenseFourSumRD;

            if (DefenseFourSum >= 2) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "3All4") {
            // LW
            if (System.Int32.Parse(DefenseRatingLW) >= 4) {
                DefenseFourSumLW = 1;
            }

            else {
                DefenseFourSumLW = 0;
            }

            // RW
            if (System.Int32.Parse(DefenseRatingRW) >= 4) {
                DefenseFourSumRW = 1;
            }

            else {
                DefenseFourSumRW = 0;
            }

            // LD
            if (System.Int32.Parse(DefenseRatingLD) >= 4) {
                DefenseFourSumLD = 1;
            }

            else {
                DefenseFourSumLD = 0;
            }

            // RD
            if (System.Int32.Parse(DefenseRatingRD) >= 4) {
                DefenseFourSumRD = 1;
            }

            else {
                DefenseFourSumRD = 0;
            }

            // Sum of All
            DefenseFourSum = DefenseFourSumLW + DefenseFourSumRW + DefenseFourSumLD + DefenseFourSumRD;

            if (DefenseFourSum >= 3) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        else if (DefenseRatingNeed == "4All4") {
            // LW
            if (System.Int32.Parse(DefenseRatingLW) >= 4) {
                DefenseFourSumLW = 1;
            }

            else {
                DefenseFourSumLW = 0;
            }

            // RW
            if (System.Int32.Parse(DefenseRatingRW) >= 4) {
                DefenseFourSumRW = 1;
            }

            else {
                DefenseFourSumRW = 0;
            }

            // LD
            if (System.Int32.Parse(DefenseRatingLD) >= 4) {
                DefenseFourSumLD = 1;
            }

            else {
                DefenseFourSumLD = 0;
            }

            // RD
            if (System.Int32.Parse(DefenseRatingRD) >= 4) {
                DefenseFourSumRD = 1;
            }

            else {
                DefenseFourSumRD = 0;
            }

            // Sum of All
            DefenseFourSum = DefenseFourSumLW + DefenseFourSumRW + DefenseFourSumLD + DefenseFourSumRD;

            if (DefenseFourSum >= 4) {
                DefenseRatingYesNo = "Yes";
            }

            else {
                DefenseRatingYesNo = "No";
            }
        }

        SetFinalTexts();

        // Set Shot Selection Texts
        ShotSelectionA.text = FinalShotSelection1 + " for " + FinalShooterSelection1;
        ShotSelectionB.text = FinalShotSelection2 + " for " + FinalShooterSelection2;
        ShotSelectionC.text = FinalShotSelection3 + " for " + FinalShooterSelection3;
        ShotSelectionD.text = FinalShotSelection4 + " for " + FinalShooterSelection4;
        ShotSelectionE.text = FinalShotSelection5 + " for " + FinalShooterSelection5;

        // Disable Nones
        if (FinalShotSelection1 == "None") {
            ShotSelectionA.text = "No shots this powerplay";
        }

        if (FinalShotSelection2 == "None") {
            ShotSelectionB.enabled = false;
        }

        else {
            ShotSelectionB.enabled = true;
        }

        if (FinalShotSelection3 == "None") {
            ShotSelectionC.enabled = false;
        }

        else {
            ShotSelectionC.enabled = true;
        }

        if (FinalShotSelection4 == "None") {
            ShotSelectionD.enabled = false;
        }

        else {
            ShotSelectionD.enabled = true;
        }

        if (FinalShotSelection5 == "None") {
            ShotSelectionE.enabled = false;
        }

        else {
            ShotSelectionE.enabled = true;
        }
    }

    public void SetFinalTexts() {
        // Set Final Shot Selections
        if (DefenseRatingYesNo == "Yes") {
            // Shot #1
            if (YesShotSelection1 == "Out") {
                FinalShotSelection1 = "Outside shot";
            }

            else if (YesShotSelection1 == "In") {
                FinalShotSelection1 = "Inside shot";
            }

            else if (YesShotSelection1 == "Reb") {
                FinalShotSelection1 = "Rebound shot";
            }

            else if (YesShotSelection1 == "Break") {
                FinalShotSelection1 = "Breakaway shot";
            }

            else if (YesShotSelection1 == "None") {
                FinalShotSelection1 = "None";
            }

            // Shot #2
            if (YesShotSelection2 == "Out") {
                FinalShotSelection2 = "Outside shot";
            }

            else if (YesShotSelection2 == "In") {
                FinalShotSelection2 = "Inside shot";
            }

            else if (YesShotSelection2 == "Reb") {
                FinalShotSelection2 = "Rebound shot";
            }

            else if (YesShotSelection2 == "Break") {
                FinalShotSelection2 = "Breakaway shot";
            }

            else if (YesShotSelection2 == "None") {
                FinalShotSelection2 = "None";
            }

            // Shot #3
            if (YesShotSelection3 == "Out") {
                FinalShotSelection3 = "Outside shot";
            }

            else if (YesShotSelection3 == "In") {
                FinalShotSelection3 = "Inside shot";
            }

            else if (YesShotSelection3 == "Reb") {
                FinalShotSelection3 = "Rebound shot";
            }

            else if (YesShotSelection3 == "Break") {
                FinalShotSelection3 = "Breakaway shot";
            }

            else if (YesShotSelection3 == "None") {
                FinalShotSelection3 = "None";
            }

            // Shot #4
            if (YesShotSelection4 == "Out") {
                FinalShotSelection4 = "Outside shot";
            }

            else if (YesShotSelection4 == "In") {
                FinalShotSelection4 = "Inside shot";
            }

            else if (YesShotSelection4 == "Reb") {
                FinalShotSelection4 = "Rebound shot";
            }

            else if (YesShotSelection4 == "Break") {
                FinalShotSelection4 = "Breakaway shot";
            }

            else if (YesShotSelection4 == "None") {
                FinalShotSelection4 = "None";
            }

            // Shot #5
            if (YesShotSelection5 == "Out") {
                FinalShotSelection5 = "Outside shot";
            }

            else if (YesShotSelection5 == "In") {
                FinalShotSelection5 = "Inside shot";
            }

            else if (YesShotSelection5 == "Reb") {
                FinalShotSelection5 = "Rebound shot";
            }

            else if (YesShotSelection5 == "Break") {
                FinalShotSelection5 = "Breakaway shot";
            }

            else if (YesShotSelection5 == "None") {
                FinalShotSelection5 = "None";
            }
        }

        else if (DefenseRatingYesNo == "No") {
            // Shot #1
            if (NoShotSelection1 == "Out") {
                FinalShotSelection1 = "Outside shot";
            }

            else if (NoShotSelection1 == "In") {
                FinalShotSelection1 = "Inside shot";
            }

            else if (NoShotSelection1 == "Reb") {
                FinalShotSelection1 = "Rebound shot";
            }

            else if (NoShotSelection1 == "Break") {
                FinalShotSelection1 = "Breakaway shot";
            }

            else if (NoShotSelection1 == "None") {
                FinalShotSelection1 = "None";
            }

            // Shot #2
            if (NoShotSelection2 == "Out") {
                FinalShotSelection2 = "Outside shot";
            }

            else if (NoShotSelection2 == "In") {
                FinalShotSelection2 = "Inside shot";
            }

            else if (NoShotSelection2 == "Reb") {
                FinalShotSelection2 = "Rebound shot";
            }

            else if (NoShotSelection2 == "Break") {
                FinalShotSelection2 = "Breakaway shot";
            }

            else if (NoShotSelection2 == "None") {
                FinalShotSelection2 = "None";
            }

            // Shot #3
            if (NoShotSelection3 == "Out") {
                FinalShotSelection3 = "Outside shot";
            }

            else if (NoShotSelection3 == "In") {
                FinalShotSelection3 = "Inside shot";
            }

            else if (NoShotSelection3 == "Reb") {
                FinalShotSelection3 = "Rebound shot";
            }

            else if (NoShotSelection3 == "Break") {
                FinalShotSelection3 = "Breakaway shot";
            }

            else if (NoShotSelection3 == "None") {
                FinalShotSelection3 = "None";
            }

            // Shot #4
            if (NoShotSelection4 == "Out") {
                FinalShotSelection4 = "Outside shot";
            }

            else if (NoShotSelection4 == "In") {
                FinalShotSelection4 = "Inside shot";
            }

            else if (NoShotSelection4 == "Reb") {
                FinalShotSelection4 = "Rebound shot";
            }

            else if (NoShotSelection4 == "Break") {
                FinalShotSelection4 = "Breakaway shot";
            }

            else if (NoShotSelection4 == "None") {
                FinalShotSelection4 = "None";
            }

            // Shot #5
            if (NoShotSelection5 == "Out") {
                FinalShotSelection5 = "Outside shot";
            }

            else if (NoShotSelection5 == "In") {
                FinalShotSelection5 = "Inside shot";
            }

            else if (NoShotSelection5 == "Reb") {
                FinalShotSelection5 = "Rebound shot";
            }

            else if (NoShotSelection5 == "Break") {
                FinalShotSelection5 = "Breakaway shot";
            }

            else if (NoShotSelection5 == "None") {
                FinalShotSelection5 = "None";
            }
        }

        // Set Any Shooter Selections
        RandomizeAnyShooter = Random.Range(1,6);

        if (RandomizeAnyShooter == 1) {
            if (YesShooterSelection1 == "Any") {
                YesShooterSelection1 = "C";
            }

            if (YesShooterSelection2 == "Any") {
                YesShooterSelection2 = "C";
            }

            if (YesShooterSelection3 == "Any") {
                YesShooterSelection3 = "C";
            }

            if (YesShooterSelection4 == "Any") {
                YesShooterSelection4 = "C";
            }

            if (YesShooterSelection5 == "Any") {
                YesShooterSelection5 = "C";
            }

            if (NoShooterSelection1 == "Any") {
                NoShooterSelection1 = "C";
            }

            if (NoShooterSelection2 == "Any") {
                NoShooterSelection2 = "C";
            }

            if (NoShooterSelection3 == "Any") {
                NoShooterSelection3 = "C";
            }

            if (NoShooterSelection4 == "Any") {
                NoShooterSelection4 = "C";
            }

            if (NoShooterSelection5 == "Any") {
                NoShooterSelection5 = "C";
            }
        }

        else if (RandomizeAnyShooter == 2) {
            if (YesShooterSelection1 == "Any") {
                YesShooterSelection1 = "LW";
            }

            if (YesShooterSelection2 == "Any") {
                YesShooterSelection2 = "LW";
            }

            if (YesShooterSelection3 == "Any") {
                YesShooterSelection3 = "LW";
            }

            if (YesShooterSelection4 == "Any") {
                YesShooterSelection4 = "LW";
            }

            if (YesShooterSelection5 == "Any") {
                YesShooterSelection5 = "LW";
            }

            if (NoShooterSelection1 == "Any") {
                NoShooterSelection1 = "LW";
            }

            if (NoShooterSelection2 == "Any") {
                NoShooterSelection2 = "LW";
            }

            if (NoShooterSelection3 == "Any") {
                NoShooterSelection3 = "LW";
            }

            if (NoShooterSelection4 == "Any") {
                NoShooterSelection4 = "LW";
            }

            if (NoShooterSelection5 == "Any") {
                NoShooterSelection5 = "LW";
            }
        }

        else if (RandomizeAnyShooter == 3) {
            if (YesShooterSelection1 == "Any") {
                YesShooterSelection1 = "RW";
            }

            if (YesShooterSelection2 == "Any") {
                YesShooterSelection2 = "RW";
            }

            if (YesShooterSelection3 == "Any") {
                YesShooterSelection3 = "RW";
            }

            if (YesShooterSelection4 == "Any") {
                YesShooterSelection4 = "RW";
            }

            if (YesShooterSelection5 == "Any") {
                YesShooterSelection5 = "RW";
            }

            if (NoShooterSelection1 == "Any") {
                NoShooterSelection1 = "RW";
            }

            if (NoShooterSelection2 == "Any") {
                NoShooterSelection2 = "RW";
            }

            if (NoShooterSelection3 == "Any") {
                NoShooterSelection3 = "RW";
            }

            if (NoShooterSelection4 == "Any") {
                NoShooterSelection4 = "RW";
            }

            if (NoShooterSelection5 == "Any") {
                NoShooterSelection5 = "RW";
            }
        }

        else if (RandomizeAnyShooter == 4) {
            if (YesShooterSelection1 == "Any") {
                YesShooterSelection1 = "LD";
            }

            if (YesShooterSelection2 == "Any") {
                YesShooterSelection2 = "LD";
            }

            if (YesShooterSelection3 == "Any") {
                YesShooterSelection3 = "LD";
            }

            if (YesShooterSelection4 == "Any") {
                YesShooterSelection4 = "LD";
            }

            if (YesShooterSelection5 == "Any") {
                YesShooterSelection5 = "LD";
            }

            if (NoShooterSelection1 == "Any") {
                NoShooterSelection1 = "LD";
            }

            if (NoShooterSelection2 == "Any") {
                NoShooterSelection2 = "LD";
            }

            if (NoShooterSelection3 == "Any") {
                NoShooterSelection3 = "LD";
            }

            if (NoShooterSelection4 == "Any") {
                NoShooterSelection4 = "LD";
            }

            if (NoShooterSelection5 == "Any") {
                NoShooterSelection5 = "LD";
            }
        }

        else if (RandomizeAnyShooter == 5) {
            if (YesShooterSelection1 == "Any") {
                YesShooterSelection1 = "RD";
            }

            if (YesShooterSelection2 == "Any") {
                YesShooterSelection2 = "RD";
            }

            if (YesShooterSelection3 == "Any") {
                YesShooterSelection3 = "RD";
            }

            if (YesShooterSelection4 == "Any") {
                YesShooterSelection4 = "RD";
            }

            if (YesShooterSelection5 == "Any") {
                YesShooterSelection5 = "RD";
            }

            if (NoShooterSelection1 == "Any") {
                NoShooterSelection1 = "RD";
            }

            if (NoShooterSelection2 == "Any") {
                NoShooterSelection2 = "RD";
            }

            if (NoShooterSelection3 == "Any") {
                NoShooterSelection3 = "RD";
            }

            if (NoShooterSelection4 == "Any") {
                NoShooterSelection4 = "RD";
            }

            if (NoShooterSelection5 == "Any") {
                NoShooterSelection5 = "RD";
            }
        }

        // Set Shooter Selections
        if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
            if (DefenseRatingYesNo == "Yes") {
                // Shot #1
                if ((YesShooterSelection1 == "C") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPC;
                }

                else if ((YesShooterSelection1 == "LW") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPLW;
                }

                else if ((YesShooterSelection1 == "LW") && (YesShotSelection1 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection1 == "RW") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPRW;
                }

                else if ((YesShooterSelection1 == "RW") && (YesShotSelection1 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection1 == "LD") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPLD;
                }

                else if ((YesShooterSelection1 == "LD") && (YesShotSelection1 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((YesShooterSelection1 == "RD") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPRD;
                }

                else if ((YesShooterSelection1 == "RD") && (YesShotSelection1 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection1 = "None";
                }

                // Shot #2
                if ((YesShooterSelection2 == "C") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPC;
                }

                else if ((YesShooterSelection2 == "LW") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPLW;
                }

                else if ((YesShooterSelection2 == "LW") && (YesShotSelection2 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection2 == "RW") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPRW;
                }

                else if ((YesShooterSelection2 == "RW") && (YesShotSelection2 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection2 == "LD") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPLD;
                }

                else if ((YesShooterSelection2 == "LD") && (YesShotSelection2 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((YesShooterSelection2 == "RD") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPRD;
                }

                else if ((YesShooterSelection2 == "RD") && (YesShotSelection2 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection2 = "None";
                }

                // Shot #3
                if ((YesShooterSelection3 == "C") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPC;
                }

                else if ((YesShooterSelection3 == "LW") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPLW;
                }

                else if ((YesShooterSelection3 == "LW") && (YesShotSelection3 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection3 == "RW") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPRW;
                }

                else if ((YesShooterSelection3 == "RW") && (YesShotSelection3 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection3 == "LD") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPLD;
                }

                else if ((YesShooterSelection3 == "LD") && (YesShotSelection3 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((YesShooterSelection3 == "RD") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPRD;
                }

                else if ((YesShooterSelection3 == "RD") && (YesShotSelection3 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection3 = "None";
                }

                // Shot #4
                if ((YesShooterSelection4 == "C") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPC;
                }

                else if ((YesShooterSelection4 == "LW") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPLW;
                }

                else if ((YesShooterSelection4 == "LW") && (YesShotSelection4 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection4 == "RW") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPRW;
                }

                else if ((YesShooterSelection4 == "RW") && (YesShotSelection4 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection4 == "LD") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPLD;
                }

                else if ((YesShooterSelection4 == "LD") && (YesShotSelection4 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((YesShooterSelection4 == "RD") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPRD;
                }

                else if ((YesShooterSelection4 == "RD") && (YesShotSelection4 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection4 = "None";
                }

                // Shot #5
                if ((YesShooterSelection5 == "C") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPC;
                }

                else if ((YesShooterSelection5 == "LW") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPLW;
                }

                else if ((YesShooterSelection5 == "LW") && (YesShotSelection5 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection5 == "RW") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPRW;
                }

                else if ((YesShooterSelection5 == "RW") && (YesShotSelection5 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((YesShooterSelection5 == "LD") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPLD;
                }

                else if ((YesShooterSelection5 == "LD") && (YesShotSelection5 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((YesShooterSelection5 == "RD") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPRD;
                }

                else if ((YesShooterSelection5 == "RD") && (YesShotSelection5 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection5 = "None";
                }
            }

            else if (DefenseRatingYesNo == "No") {
                // Shot #1
                if ((NoShooterSelection1 == "C") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPC;
                }

                else if ((NoShooterSelection1 == "LW") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPLW;
                }

                else if ((NoShooterSelection1 == "LW") && (NoShotSelection1 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection1 == "RW") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPRW;
                }

                else if ((NoShooterSelection1 == "RW") && (NoShotSelection1 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection1 == "LD") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPLD;
                }

                else if ((NoShooterSelection1 == "LD") && (NoShotSelection1 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((NoShooterSelection1 == "RD") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P2PPRD;
                }

                else if ((NoShooterSelection1 == "RD") && (NoShotSelection1 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection1 = "None";
                }

                // Shot #2
                if ((NoShooterSelection2 == "C") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPC;
                }

                else if ((NoShooterSelection2 == "LW") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPLW;
                }

                else if ((NoShooterSelection2 == "LW") && (NoShotSelection2 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection2 == "RW") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPRW;
                }

                else if ((NoShooterSelection2 == "RW") && (NoShotSelection2 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection2 == "LD") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPLD;
                }

                else if ((NoShooterSelection2 == "LD") && (NoShotSelection2 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((NoShooterSelection2 == "RD") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P2PPRD;
                }

                else if ((NoShooterSelection2 == "RD") && (NoShotSelection2 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection2 = "None";
                }

                // Shot #3
                if ((NoShooterSelection3 == "C") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPC;
                }

                else if ((NoShooterSelection3 == "LW") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPLW;
                }

                else if ((NoShooterSelection3 == "LW") && (NoShotSelection3 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection3 == "RW") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPRW;
                }

                else if ((NoShooterSelection3 == "RW") && (NoShotSelection3 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection3 == "LD") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPLD;
                }

                else if ((NoShooterSelection3 == "LD") && (NoShotSelection3 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((NoShooterSelection3 == "RD") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P2PPRD;
                }

                else if ((NoShooterSelection3 == "RD") && (NoShotSelection3 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection3 = "None";
                }

                // Shot #4
                if ((NoShooterSelection4 == "C") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPC;
                }

                else if ((NoShooterSelection4 == "LW") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPLW;
                }

                else if ((NoShooterSelection4 == "LW") && (NoShotSelection4 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection4 == "RW") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPRW;
                }

                else if ((NoShooterSelection4 == "RW") && (NoShotSelection4 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection4 == "LD") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPLD;
                }

                else if ((NoShooterSelection4 == "LD") && (NoShotSelection4 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((NoShooterSelection4 == "RD") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P2PPRD;
                }

                else if ((NoShooterSelection4 == "RD") && (NoShotSelection4 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection4 = "None";
                }

                // Shot #5
                if ((NoShooterSelection5 == "C") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPC;
                }

                else if ((NoShooterSelection5 == "LW") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPLW;
                }

                else if ((NoShooterSelection5 == "LW") && (NoShotSelection5 == "Break")) {
                    if (PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P1PKLW;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection5 == "RW") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPRW;
                }

                else if ((NoShooterSelection5 == "RW") && (NoShotSelection5 == "Break")) {
                    if (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P1PKRW;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P1PKExW;
                    }
                }

                else if ((NoShooterSelection5 == "LD") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPLD;
                }

                else if ((NoShooterSelection5 == "LD") && (NoShotSelection5 == "Break")) {
                    if (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P1PKLD;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P1PKExD;
                    }
                }

                else if ((NoShooterSelection5 == "RD") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P2PPRD;
                }

                else if ((NoShooterSelection5 == "RD") && (NoShotSelection5 == "Break")) {
                    if (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P1PKRD;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P1PKExD;
                    }
                }

                else {
                    FinalShooterSelection5 = "None";
                }
            }
        }

        else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
            if (DefenseRatingYesNo == "Yes") {
                // Shot #1
                if ((YesShooterSelection1 == "C") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPC;
                }

                else if ((YesShooterSelection1 == "LW") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPLW;
                }

                else if ((YesShooterSelection1 == "LW") && (YesShotSelection1 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection1 == "RW") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPRW;
                }

                else if ((YesShooterSelection1 == "RW") && (YesShotSelection1 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection1 == "LD") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPLD;
                }

                else if ((YesShooterSelection1 == "LD") && (YesShotSelection1 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((YesShooterSelection1 == "RD") && (YesShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPRD;
                }

                else if ((YesShooterSelection1 == "RD") && (YesShotSelection1 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection1 = "None";
                }

                // Shot #2
                if ((YesShooterSelection2 == "C") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPC;
                }

                else if ((YesShooterSelection2 == "LW") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPLW;
                }

                else if ((YesShooterSelection2 == "LW") && (YesShotSelection2 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection2 == "RW") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPRW;
                }

                else if ((YesShooterSelection2 == "RW") && (YesShotSelection2 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection2 == "LD") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPLD;
                }

                else if ((YesShooterSelection2 == "LD") && (YesShotSelection2 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((YesShooterSelection2 == "RD") && (YesShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPRD;
                }

                else if ((YesShooterSelection2 == "RD") && (YesShotSelection2 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection2 = "None";
                }

                // Shot #3
                if ((YesShooterSelection3 == "C") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPC;
                }

                else if ((YesShooterSelection3 == "LW") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPLW;
                }

                else if ((YesShooterSelection3 == "LW") && (YesShotSelection3 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection3 == "RW") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPRW;
                }

                else if ((YesShooterSelection3 == "RW") && (YesShotSelection3 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection3 == "LD") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPLD;
                }

                else if ((YesShooterSelection3 == "LD") && (YesShotSelection3 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((YesShooterSelection3 == "RD") && (YesShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPRD;
                }

                else if ((YesShooterSelection3 == "RD") && (YesShotSelection3 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection3 = "None";
                }

                // Shot #4
                if ((YesShooterSelection4 == "C") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPC;
                }

                else if ((YesShooterSelection4 == "LW") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPLW;
                }

                else if ((YesShooterSelection4 == "LW") && (YesShotSelection4 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection4 == "RW") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPRW;
                }

                else if ((YesShooterSelection4 == "RW") && (YesShotSelection4 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection4 == "LD") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPLD;
                }

                else if ((YesShooterSelection4 == "LD") && (YesShotSelection4 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((YesShooterSelection4 == "RD") && (YesShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPRD;
                }

                else if ((YesShooterSelection4 == "RD") && (YesShotSelection4 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection4 = "None";
                }

                // Shot #5
                if ((YesShooterSelection5 == "C") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPC;
                }

                else if ((YesShooterSelection5 == "LW") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPLW;
                }

                else if ((YesShooterSelection5 == "LW") && (YesShotSelection5 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection5 == "RW") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPRW;
                }

                else if ((YesShooterSelection5 == "RW") && (YesShotSelection5 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((YesShooterSelection5 == "LD") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPLD;
                }

                else if ((YesShooterSelection5 == "LD") && (YesShotSelection5 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((YesShooterSelection5 == "RD") && (YesShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPRD;
                }

                else if ((YesShooterSelection5 == "RD") && (YesShotSelection5 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection5 = "None";
                }
            }

            else if (DefenseRatingYesNo == "No") {
                // Shot #1
                if ((NoShooterSelection1 == "C") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPC;
                }

                else if ((NoShooterSelection1 == "LW") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPLW;
                }

                else if ((NoShooterSelection1 == "LW") && (NoShotSelection1 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection1 == "RW") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPRW;
                }

                else if ((NoShooterSelection1 == "RW") && (NoShotSelection1 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection1 == "LD") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPLD;
                }

                else if ((NoShooterSelection1 == "LD") && (NoShotSelection1 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((NoShooterSelection1 == "RD") && (NoShotSelection1 != "Break")) {
                    FinalShooterSelection1 = PlayerDatabase.P1PPRD;
                }

                else if ((NoShooterSelection1 == "RD") && (NoShotSelection1 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection1 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection1 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection1 = "None";
                }

                // Shot #2
                if ((NoShooterSelection2 == "C") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPC;
                }

                else if ((NoShooterSelection2 == "LW") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPLW;
                }

                else if ((NoShooterSelection2 == "LW") && (NoShotSelection2 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection2 == "RW") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPRW;
                }

                else if ((NoShooterSelection2 == "RW") && (NoShotSelection2 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection2 == "LD") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPLD;
                }

                else if ((NoShooterSelection2 == "LD") && (NoShotSelection2 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((NoShooterSelection2 == "RD") && (NoShotSelection2 != "Break")) {
                    FinalShooterSelection2 = PlayerDatabase.P1PPRD;
                }

                else if ((NoShooterSelection2 == "RD") && (NoShotSelection2 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection2 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection2 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection2 = "None";
                }

                // Shot #3
                if ((NoShooterSelection3 == "C") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPC;
                }

                else if ((NoShooterSelection3 == "LW") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPLW;
                }

                else if ((NoShooterSelection3 == "LW") && (NoShotSelection3 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection3 == "RW") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPRW;
                }

                else if ((NoShooterSelection3 == "RW") && (NoShotSelection3 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection3 == "LD") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPLD;
                }

                else if ((NoShooterSelection3 == "LD") && (NoShotSelection3 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((NoShooterSelection3 == "RD") && (NoShotSelection3 != "Break")) {
                    FinalShooterSelection3 = PlayerDatabase.P1PPRD;
                }

                else if ((NoShooterSelection3 == "RD") && (NoShotSelection3 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection3 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection3 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection3 = "None";
                }

                // Shot #4
                if ((NoShooterSelection4 == "C") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPC;
                }

                else if ((NoShooterSelection4 == "LW") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPLW;
                }

                else if ((NoShooterSelection4 == "LW") && (NoShotSelection4 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection4 == "RW") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPRW;
                }

                else if ((NoShooterSelection4 == "RW") && (NoShotSelection4 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection4 == "LD") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPLD;
                }

                else if ((NoShooterSelection4 == "LD") && (NoShotSelection4 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((NoShooterSelection4 == "RD") && (NoShotSelection4 != "Break")) {
                    FinalShooterSelection4 = PlayerDatabase.P1PPRD;
                }

                else if ((NoShooterSelection4 == "RD") && (NoShotSelection4 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection4 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection4 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection4 = "None";
                }

                // Shot #5
                if ((NoShooterSelection5 == "C") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPC;
                }

                else if ((NoShooterSelection5 == "LW") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPLW;
                }

                else if ((NoShooterSelection5 == "LW") && (NoShotSelection5 == "Break")) {
                    if (PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P2PKLW;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection5 == "RW") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPRW;
                }

                else if ((NoShooterSelection5 == "RW") && (NoShotSelection5 == "Break")) {
                    if (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P2PKRW;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P2PKExW;
                    }
                }

                else if ((NoShooterSelection5 == "LD") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPLD;
                }

                else if ((NoShooterSelection5 == "LD") && (NoShotSelection5 == "Break")) {
                    if (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P2PKLD;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P2PKExD;
                    }
                }

                else if ((NoShooterSelection5 == "RD") && (NoShotSelection5 != "Break")) {
                    FinalShooterSelection5 = PlayerDatabase.P1PPRD;
                }

                else if ((NoShooterSelection5 == "RD") && (NoShotSelection5 == "Break")) {
                    if (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer) {
                        FinalShooterSelection5 = PlayerDatabase.P2PKRD;
                    }

                    else {
                        FinalShooterSelection5 = PlayerDatabase.P2PKExD;
                    }
                }

                else {
                    FinalShooterSelection5 = "None";
                }
            }
        }
    }

// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}