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

public class EnableObjects19C : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image StartPowerplayButton;

	// Scoreboard Objects
	public Image ScoreboardBackground;
	public Text P1Score;
	public Text P2Score;
	public Text P1Shots;
	public Text P2Shots;
	public Text Period;
	public Text Play;

    // Special Teams
    public Text PowerplayUnitTitle;
    public Text PowerplayUnitLW;
    public Text PowerplayUnitC;
    public Text PowerplayUnitRW;
    public Text PowerplayUnitLD;
    public Text PowerplayUnitRD;
    public Text PenaltyKillUnitTitle;
    public Text PenaltyKillUnitLW;
    public Text PenaltyKillUnitRW;
    public Text PenaltyKillUnitLD;
    public Text PenaltyKillUnitRD;
	
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
        EnableSpecialTeams();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingScoreboard();
		UpdatingLines();
        UpdatingSpecialTeamsPP();
        UpdatingSpecialTeamsPK();
        UpdatingTitleColors();
		ActionText.text = Buttons19.PenalizedPlayer + " has been given a 2:00 penalty for " + Buttons19.PenaltyType + ".";
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
		StartPowerplayButton.enabled = true;
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

    public void EnableSpecialTeams() {
        PowerplayUnitTitle.enabled = true;
        PowerplayUnitLW.enabled = true;
        PowerplayUnitC.enabled = true;
        PowerplayUnitRW.enabled = true;
        PowerplayUnitLD.enabled = true;
        PowerplayUnitRD.enabled = true;
        PenaltyKillUnitTitle.enabled = true;
        PenaltyKillUnitLW.enabled = true;
        PenaltyKillUnitRW.enabled = true;
        PenaltyKillUnitLD.enabled = true;
        PenaltyKillUnitRD.enabled = true;
    }

// --------------- DISABLING OBEJCTS FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ActionText.enabled = false;
		StartPowerplayButton.enabled = false;
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

    public void DisableSpecialTeams() {
        PowerplayUnitTitle.enabled = false;
        PowerplayUnitLW.enabled = false;
        PowerplayUnitC.enabled = false;
        PowerplayUnitRW.enabled = false;
        PowerplayUnitLD.enabled = false;
        PowerplayUnitRD.enabled = false;
        PenaltyKillUnitTitle.enabled = false;
        PenaltyKillUnitLW.enabled = false;
        PenaltyKillUnitRW.enabled = false;
        PenaltyKillUnitLD.enabled = false;
        PenaltyKillUnitRD.enabled = false;
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

	public void UpdatingLines() {
		if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 0) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 10)) {
			PlayerDatabase.GameplayLine = "F1D1";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 10) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 12)) {
			PlayerDatabase.GameplayLine = "F2D1";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 12) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 19)) {
			PlayerDatabase.GameplayLine = "F2D2";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 19) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 25)) {
			PlayerDatabase.GameplayLine = "F3D2";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 19) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 25)) {
			PlayerDatabase.GameplayLine = "F3D2";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 25) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 26)) {
			PlayerDatabase.GameplayLine = "F3D3";
		}

		else if ((System.Int32.Parse(PlayerDatabase.GameplayPlay) >= 26) && (System.Int32.Parse(PlayerDatabase.GameplayPlay) < 31)) {
			PlayerDatabase.GameplayLine = "F4D3";
		}
	}

    public void UpdatingSpecialTeamsPP() {
        if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
            PowerplayUnitTitle.text = "Powerplay (" + PlayerDatabase.ComputerChosenTeam + ")";
            PowerplayUnitLW.text = PlayerDatabase.P2PPLW.Replace(" ", "\n");
            PowerplayUnitC.text = PlayerDatabase.P2PPC.Replace(" ", "\n");
            PowerplayUnitRW.text = PlayerDatabase.P2PPRW.Replace(" ", "\n");
            PowerplayUnitLD.text = PlayerDatabase.P2PPLD.Replace(" ", "\n");
            PowerplayUnitRD.text = PlayerDatabase.P2PPRD.Replace(" ", "\n");
        }

        else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
            PowerplayUnitTitle.text = "Powerplay (" + PlayerDatabase.PlayerChosenTeam + ")";
            PowerplayUnitLW.text = PlayerDatabase.P1PPLW.Replace(" ", "\n");
            PowerplayUnitC.text = PlayerDatabase.P1PPC.Replace(" ", "\n");
            PowerplayUnitRW.text = PlayerDatabase.P1PPRW.Replace(" ", "\n");
            PowerplayUnitLD.text = PlayerDatabase.P1PPLD.Replace(" ", "\n");
            PowerplayUnitRD.text = PlayerDatabase.P1PPRD.Replace(" ", "\n");
        }
    }

    public void UpdatingSpecialTeamsPK() {
        if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
            PenaltyKillUnitTitle.text = "Penalty Kill (" + PlayerDatabase.PlayerChosenTeam + ")";

            if ((PlayerDatabase.P1PKLW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P1PKExW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P1PKRW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P1PKLD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P1PKRD.Replace(" ", "\n");
            }

            else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P1PKLW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P1PKExW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P1PKLD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P1PKRD.Replace(" ", "\n");
            }

            else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P1PKLW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P1PKRW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P1PKExD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P1PKRD.Replace(" ", "\n");
            }

            else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD == PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P1PKLW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P1PKRW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P1PKLD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P1PKExD.Replace(" ", "\n");
            }

            else if ((PlayerDatabase.P1PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P1PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P1PKLW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P1PKRW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P1PKLD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P1PKRD.Replace(" ", "\n");
            }
        }

        else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
            PenaltyKillUnitTitle.text = "Penalty Kill (" + PlayerDatabase.ComputerChosenTeam + ")";

            if ((PlayerDatabase.P2PKLW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P2PKExW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P2PKRW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P2PKLD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P2PKRD.Replace(" ", "\n");
            }

            else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P2PKLW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P2PKExW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P2PKLD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P2PKRD.Replace(" ", "\n");
            }

            else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD == PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P2PKLW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P2PKRW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P2PKExD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P2PKRD.Replace(" ", "\n");
            }

            else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD == PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P2PKLW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P2PKRW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P2PKLD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P2PKExD.Replace(" ", "\n");
            }

            else if ((PlayerDatabase.P2PKLW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRW != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKLD != PlayerDatabase.GameplayPenaltyPlayer) && (PlayerDatabase.P2PKRD != PlayerDatabase.GameplayPenaltyPlayer)) {
                PenaltyKillUnitLW.text = PlayerDatabase.P2PKLW.Replace(" ", "\n");
                PenaltyKillUnitRW.text = PlayerDatabase.P2PKRW.Replace(" ", "\n");
                PenaltyKillUnitLD.text = PlayerDatabase.P2PKLD.Replace(" ", "\n");
                PenaltyKillUnitRD.text = PlayerDatabase.P2PKRD.Replace(" ", "\n");
            }
        }
    }

    public void UpdatingTitleColors() {
        if (PlayerDatabase.GameplayPenaltyTeam == "P1") {
            PowerplayUnitTitle.color = new Color(0.6627451f, 0.007843138f, 0.003921569f, 1.0f);
            PenaltyKillUnitTitle.color = new Color(0.0509804f, 0.2666667f, 0.4980392f, 1.0f);
        }

        else if (PlayerDatabase.GameplayPenaltyTeam == "P2") {
            PowerplayUnitTitle.color = new Color(0.0509804f, 0.2666667f, 0.4980392f, 1.0f);
            PenaltyKillUnitTitle.color = new Color(0.6627451f, 0.007843138f, 0.003921569f, 1.0f);
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}