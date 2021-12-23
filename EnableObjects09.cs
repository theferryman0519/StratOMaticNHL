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

public class EnableObjects09 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image DefendingButton;

	// Scoreboard Objects
	public Image ScoreboardBackground;
	public Text P1Score;
	public Text P2Score;
	public Text P1Shots;
	public Text P2Shots;
	public Text Period;
	public Text Play;

	// Rink Objects
	public Image RinkBackgroundP1;
	public Image P1C;
	public Image P1LW;
	public Image P1RW;
	public Image P1LD;
	public Image P1RD;
	public Image P1G;
	public Image RinkBackgroundP2;
	public Image P2C;
	public Image P2LW;
	public Image P2RW;
	public Image P2LD;
	public Image P2RD;
	public Image P2G;

	// Overlay Objects
	public Image OverlayBackground;
	public Image PlayerNameBackground;
	public Text PlayerText;
	public Text PlayerTeam;
	public Text PlayerOffense;
	public Text PlayerDefense;
	public Text PlayerBreakaway;
	public Text PlayerIntimidation;
	public Text PlayerPenalty;
	public Text PlayerFaceoff;
	public Text PlayerDefendingTitle;
	public Text PlayerDefending01;
	public Text PlayerDefending02;
	public Text PlayerDefending03;
	public Text PlayerDefending04;
	public Text PlayerDefending05;
	public Text PlayerDefending06;
	public Text PlayerDefending07;
	public Text PlayerDefending11;
	public Text PlayerDefending12;
	public Text PlayerDefending13;
	public Text PlayerDefending14;
	public Image PlayerFlipButton;
	public Image PlayerBackButton;

	public Sprite BackgroundNamePlayer;
	public Sprite BackgroundNameComputer;

	// Flip Button Images
	public Sprite PlayerFlipToDefend;
	public Sprite PlayerFlipToMain;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ShowingOverlayInt;
	public static string ShowingOverlayString;
	public static int GettingPlayerInts;
	public static int FlippingPlayerData;
	public static string DefendingPlayerString;
	public static string DefendingPlayerPos;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ShowingOverlayInt = 0;
		ShowingOverlayString = "None";
		FlippingPlayerData = 0;
		EnableMainObjects();
		EnableScoreboardObjects();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (ShowingOverlayInt == 0) {
			DisableOverlayObjects();
			DisableOverlayMainObjects();
			DisableOverlayDefendingObjects();
		}

		else if (ShowingOverlayInt == 1) {
			EnableOverlayObjects();

			if (FlippingPlayerData == 0) {
				EnableOverlayMainObjects();
				DisableOverlayDefendingObjects();
				PlayerFlipButton.sprite = PlayerFlipToDefend;
			}

			else if (FlippingPlayerData == 1) {
				DisableOverlayMainObjects();
				EnableOverlayDefendingObjects();
				PlayerFlipButton.sprite = PlayerFlipToMain;
			}
		}

		UpdatingScoreboard();
		UpdatingLines();
		UpdatingActionText();
		UpdatingPossession();
		UpdatingOverlayTexts();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
		DefendingButton.enabled = true;
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

	public void EnableRinkObjectsP1() {
		RinkBackgroundP1.enabled = true;
		P1C.enabled = true;
		P1LW.enabled = true;
		P1RW.enabled = true;
		P1LD.enabled = true;
		P1RD.enabled = true;
		P1G.enabled = true;
	}

	public void EnableRinkObjectsP2() {
		RinkBackgroundP2.enabled = true;
		P2C.enabled = true;
		P2LW.enabled = true;
		P2RW.enabled = true;
		P2LD.enabled = true;
		P2RD.enabled = true;
		P2G.enabled = true;
	}

	public void EnableOverlayObjects() {
		OverlayBackground.enabled = true;
		PlayerNameBackground.enabled = true;
		PlayerText.enabled = true;
		PlayerFlipButton.enabled = true;
		PlayerBackButton.enabled = true;
	}

	public void EnableOverlayMainObjects() {
		PlayerTeam.enabled = true;
		PlayerOffense.enabled = true;
		PlayerDefense.enabled = true;
		PlayerBreakaway.enabled = true;
		PlayerIntimidation.enabled = true;
		PlayerPenalty.enabled = true;
		PlayerFaceoff.enabled = true;
	}

	public void EnableOverlayDefendingObjects() {
		PlayerDefendingTitle.enabled = true;
		PlayerDefending01.enabled = true;
		PlayerDefending02.enabled = true;
		PlayerDefending03.enabled = true;
		PlayerDefending04.enabled = true;
		PlayerDefending05.enabled = true;
		PlayerDefending06.enabled = true;
		PlayerDefending07.enabled = true;
		PlayerDefending11.enabled = true;
		PlayerDefending12.enabled = true;
		PlayerDefending13.enabled = true;
		PlayerDefending14.enabled = true;
	}

// --------------- DISABLING OBEJCTS FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ActionText.enabled = false;
		DefendingButton.enabled = false;
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

	public void DisableRinkObjectsP1() {
		RinkBackgroundP1.enabled = false;
		P1C.enabled = false;
		P1LW.enabled = false;
		P1RW.enabled = false;
		P1LD.enabled = false;
		P1RD.enabled = false;
		P1G.enabled = false;
	}

	public void DisableRinkObjectsP2() {
		RinkBackgroundP2.enabled = false;
		P2C.enabled = false;
		P2LW.enabled = false;
		P2RW.enabled = false;
		P2LD.enabled = false;
		P2RD.enabled = false;
		P2G.enabled = false;
	}

	public void DisableOverlayObjects() {
		OverlayBackground.enabled = false;
		PlayerNameBackground.enabled = false;
		PlayerText.enabled = false;
		PlayerFlipButton.enabled = false;
		PlayerBackButton.enabled = false;
	}

	public void DisableOverlayMainObjects() {
		PlayerTeam.enabled = false;
		PlayerOffense.enabled = false;
		PlayerDefense.enabled = false;
		PlayerBreakaway.enabled = false;
		PlayerIntimidation.enabled = false;
		PlayerPenalty.enabled = false;
		PlayerFaceoff.enabled = false;
	}

	public void DisableOverlayDefendingObjects() {
		PlayerDefendingTitle.enabled = false;
		PlayerDefending01.enabled = false;
		PlayerDefending02.enabled = false;
		PlayerDefending03.enabled = false;
		PlayerDefending04.enabled = false;
		PlayerDefending05.enabled = false;
		PlayerDefending06.enabled = false;
		PlayerDefending07.enabled = false;
		PlayerDefending11.enabled = false;
		PlayerDefending12.enabled = false;
		PlayerDefending13.enabled = false;
		PlayerDefending14.enabled = false;
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

	public void UpdatingActionText() {
		// P1
		if (PlayerDatabase.GameplayPossession == "P1C1") {
			DefendingPlayerString = PlayerDatabase.P2C1;
			DefendingPlayerPos = "P2C1";
			ActionText.text = PlayerDatabase.P2C1 + " is attempting to defend on " + PlayerDatabase.P1C1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1C2") {
			DefendingPlayerString = PlayerDatabase.P2C2;
			DefendingPlayerPos = "P2C2";
			ActionText.text = PlayerDatabase.P2C2 + " is attempting to defend on " + PlayerDatabase.P1C2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1C3") {
			DefendingPlayerString = PlayerDatabase.P2C3;
			DefendingPlayerPos = "P2C3";
			ActionText.text = PlayerDatabase.P2C3 + " is attempting to defend on " + PlayerDatabase.P1C3 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1C4") {
			DefendingPlayerString = PlayerDatabase.P2C4;
			DefendingPlayerPos = "P2C4";
			ActionText.text = PlayerDatabase.P2C4 + " is attempting to defend on " + PlayerDatabase.P1C4 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW1") {
			DefendingPlayerString = PlayerDatabase.P2LW1;
			DefendingPlayerPos = "P2LW1";
			ActionText.text = PlayerDatabase.P2LW1 + " is attempting to defend on " + PlayerDatabase.P1LW1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW2") {
			DefendingPlayerString = PlayerDatabase.P2LW2;
			DefendingPlayerPos = "P2LW2";
			ActionText.text = PlayerDatabase.P2LW2 + " is attempting to defend on " + PlayerDatabase.P1LW2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW3") {
			DefendingPlayerString = PlayerDatabase.P2LW3;
			DefendingPlayerPos = "P2LW3";
			ActionText.text = PlayerDatabase.P2LW3 + " is attempting to defend on " + PlayerDatabase.P1LW3 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW4") {
			DefendingPlayerString = PlayerDatabase.P2LW4;
			DefendingPlayerPos = "P2LW4";
			ActionText.text = PlayerDatabase.P2LW4 + " is attempting to defend on " + PlayerDatabase.P1LW4 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW1") {
			DefendingPlayerString = PlayerDatabase.P2RW1;
			DefendingPlayerPos = "P2RW1";
			ActionText.text = PlayerDatabase.P2RW1 + " is attempting to defend on " + PlayerDatabase.P1RW1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW2") {
			DefendingPlayerString = PlayerDatabase.P2RW2;
			DefendingPlayerPos = "P2RW2";
			ActionText.text = PlayerDatabase.P2RW2 + " is attempting to defend on " + PlayerDatabase.P1RW2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW3") {
			DefendingPlayerString = PlayerDatabase.P2RW3;
			DefendingPlayerPos = "P2RW3";
			ActionText.text = PlayerDatabase.P2RW3 + " is attempting to defend on " + PlayerDatabase.P1RW3 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW4") {
			DefendingPlayerString = PlayerDatabase.P2RW4;
			DefendingPlayerPos = "P2RW4";
			ActionText.text = PlayerDatabase.P2RW4 + " is attempting to defend on " + PlayerDatabase.P1RW4 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD1") {
			DefendingPlayerString = PlayerDatabase.P2LD1;
			DefendingPlayerPos = "P2LD1";
			ActionText.text = PlayerDatabase.P2LD1 + " is attempting to defend on " + PlayerDatabase.P1LD1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD2") {
			DefendingPlayerString = PlayerDatabase.P2LD2;
			DefendingPlayerPos = "P2LD2";
			ActionText.text = PlayerDatabase.P2LD2 + " is attempting to defend on " + PlayerDatabase.P1LD2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD3") {
			DefendingPlayerString = PlayerDatabase.P2LD3;
			DefendingPlayerPos = "P2LD3";
			ActionText.text = PlayerDatabase.P2LD3 + " is attempting to defend on " + PlayerDatabase.P1LD3 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD1") {
			DefendingPlayerString = PlayerDatabase.P2RD1;
			DefendingPlayerPos = "P2RD1";
			ActionText.text = PlayerDatabase.P2RD1 + " is attempting to defend on " + PlayerDatabase.P1RD1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD2") {
			DefendingPlayerString = PlayerDatabase.P2RD2;
			DefendingPlayerPos = "P2RD2";
			ActionText.text = PlayerDatabase.P2RD2 + " is attempting to defend on " + PlayerDatabase.P1RD2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD3") {
			DefendingPlayerString = PlayerDatabase.P2RD3;
			DefendingPlayerPos = "P2RD3";
			ActionText.text = PlayerDatabase.P2RD3 + " is attempting to defend on " + PlayerDatabase.P1RD3 + ".";
		}

		// P2
		else if (PlayerDatabase.GameplayPossession == "P2C1") {
			DefendingPlayerString = PlayerDatabase.P1C1;
			DefendingPlayerPos = "P1C1";
			ActionText.text = PlayerDatabase.P1C1 + " is attempting to defend on " + PlayerDatabase.P2C1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2C2") {
			DefendingPlayerString = PlayerDatabase.P1C2;
			DefendingPlayerPos = "P1C2";
			ActionText.text = PlayerDatabase.P1C2 + " is attempting to defend on " + PlayerDatabase.P2C2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2C3") {
			DefendingPlayerString = PlayerDatabase.P1C3;
			DefendingPlayerPos = "P1C3";
			ActionText.text = PlayerDatabase.P1C3 + " is attempting to defend on " + PlayerDatabase.P2C3 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2C4") {
			DefendingPlayerString = PlayerDatabase.P1C4;
			DefendingPlayerPos = "P1C4";
			ActionText.text = PlayerDatabase.P1C4 + " is attempting to defend on " + PlayerDatabase.P2C4 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW1") {
			DefendingPlayerString = PlayerDatabase.P1LW1;
			DefendingPlayerPos = "P1LW1";
			ActionText.text = PlayerDatabase.P1LW1 + " is attempting to defend on " + PlayerDatabase.P2LW1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW2") {
			DefendingPlayerString = PlayerDatabase.P1LW2;
			DefendingPlayerPos = "P1LW2";
			ActionText.text = PlayerDatabase.P1LW2 + " is attempting to defend on " + PlayerDatabase.P2LW2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW3") {
			DefendingPlayerString = PlayerDatabase.P1LW3;
			DefendingPlayerPos = "P1LW3";
			ActionText.text = PlayerDatabase.P1LW3 + " is attempting to defend on " + PlayerDatabase.P2LW3 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW4") {
			DefendingPlayerString = PlayerDatabase.P1LW4;
			DefendingPlayerPos = "P1LW4";
			ActionText.text = PlayerDatabase.P1LW4 + " is attempting to defend on " + PlayerDatabase.P2LW4 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW1") {
			DefendingPlayerString = PlayerDatabase.P1RW1;
			DefendingPlayerPos = "P1RW1";
			ActionText.text = PlayerDatabase.P1RW1 + " is attempting to defend on " + PlayerDatabase.P2RW1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW2") {
			DefendingPlayerString = PlayerDatabase.P1RW2;
			DefendingPlayerPos = "P1RW2";
			ActionText.text = PlayerDatabase.P1RW2 + " is attempting to defend on " + PlayerDatabase.P2RW2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW3") {
			DefendingPlayerString = PlayerDatabase.P1RW3;
			DefendingPlayerPos = "P1RW3";
			ActionText.text = PlayerDatabase.P1RW3 + " is attempting to defend on " + PlayerDatabase.P2RW3 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW4") {
			DefendingPlayerString = PlayerDatabase.P1RW4;
			DefendingPlayerPos = "P1RW4";
			ActionText.text = PlayerDatabase.P1RW4 + " is attempting to defend on " + PlayerDatabase.P2RW4 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD1") {
			DefendingPlayerString = PlayerDatabase.P1LD1;
			DefendingPlayerPos = "P1LD1";
			ActionText.text = PlayerDatabase.P1LD1 + " is attempting to defend on " + PlayerDatabase.P2LD1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD2") {
			DefendingPlayerString = PlayerDatabase.P1LD2;
			DefendingPlayerPos = "P1LD2";
			ActionText.text = PlayerDatabase.P1LD2 + " is attempting to defend on " + PlayerDatabase.P2LD2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD3") {
			DefendingPlayerString = PlayerDatabase.P1LD3;
			DefendingPlayerPos = "P1LD3";
			ActionText.text = PlayerDatabase.P1LD3 + " is attempting to defend on " + PlayerDatabase.P2LD3 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD1") {
			DefendingPlayerString = PlayerDatabase.P1RD1;
			DefendingPlayerPos = "P1RD1";
			ActionText.text = PlayerDatabase.P1RD1 + " is attempting to defend on " + PlayerDatabase.P2RD1 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD2") {
			DefendingPlayerString = PlayerDatabase.P1RD2;
			DefendingPlayerPos = "P1RD2";
			ActionText.text = PlayerDatabase.P1RD2 + " is attempting to defend on " + PlayerDatabase.P2RD2 + ".";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD3") {
			DefendingPlayerString = PlayerDatabase.P1RD3;
			DefendingPlayerPos = "P1RD3";
			ActionText.text = PlayerDatabase.P1RD3 + " is attempting to defend on " + PlayerDatabase.P2RD3 + ".";
		}
	}

	public void UpdatingPossession() {
		if (PlayerDatabase.GameplayPossession.Contains("P1")) {
			DisableRinkObjectsP1();
			EnableRinkObjectsP2();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
			DisableRinkObjectsP2();
			EnableRinkObjectsP1();
		}
	}

	public void UpdatingOverlayTexts() {
		// Set Title Color
		if (ShowingOverlayString.Contains("P1")) {
			PlayerNameBackground.sprite = BackgroundNamePlayer;
		}

		else if (ShowingOverlayString.Contains("P2")) {
			PlayerNameBackground.sprite = BackgroundNameComputer;
		}

		// Set Team
		if (ShowingOverlayString.Contains("P1")) {
			PlayerTeam.text = "Team: " + PlayerDatabase.PlayerChosenTeam;
		}

		else if (ShowingOverlayString.Contains("P2")) {
			PlayerTeam.text = "Team: " + PlayerDatabase.ComputerChosenTeam;
		}

		// Set Player Data
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if ((ShowingOverlayString != "P1G") && (ShowingOverlayString != "P2G")) {
				// Player
				if (ShowingOverlayString == "P1C1") {
					PlayerText.text = PlayerDatabase.P1C1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1C1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1C1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1C1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1C1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1C1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1C1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1C1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1C1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1C1];
				}

				else if (ShowingOverlayString == "P1C2") {
					PlayerText.text = PlayerDatabase.P1C2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1C2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1C2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1C2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1C2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1C2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1C2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1C2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1C2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1C2];
				}

				else if (ShowingOverlayString == "P1C3") {
					PlayerText.text = PlayerDatabase.P1C3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1C3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1C3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1C3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1C3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1C3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1C3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1C3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1C3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1C3];
				}

				else if (ShowingOverlayString == "P1C4") {
					PlayerText.text = PlayerDatabase.P1C4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C4];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1C4];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1C4];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1C4];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1C4];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1C4];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1C4];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1C4] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1C4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1C4];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1C4];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1C4];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1C4];
				}

				else if (ShowingOverlayString == "P1LW1") {
					PlayerText.text = PlayerDatabase.P1LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1LW1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1LW1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1LW1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1LW1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1LW1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1LW1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1LW1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1LW1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1LW1];
				}

				else if (ShowingOverlayString == "P1LW2") {
					PlayerText.text = PlayerDatabase.P1LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1LW2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1LW2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1LW2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1LW2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1LW2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1LW2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1LW2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1LW2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1LW2];
				}

				else if (ShowingOverlayString == "P1LW3") {
					PlayerText.text = PlayerDatabase.P1LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1LW3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1LW3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1LW3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1LW3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1LW3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1LW3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1LW3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1LW3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1LW3];
				}

				else if (ShowingOverlayString == "P1LW4") {
					PlayerText.text = PlayerDatabase.P1LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW4];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1LW4];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1LW4];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1LW4];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1LW4];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1LW4];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1LW4];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LW4] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LW4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LW4];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1LW4];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1LW4];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1LW4];
				}

				else if (ShowingOverlayString == "P1RW1") {
					PlayerText.text = PlayerDatabase.P1RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1RW1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1RW1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1RW1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1RW1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1RW1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1RW1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1RW1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1RW1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1RW1];
				}

				else if (ShowingOverlayString == "P1RW2") {
					PlayerText.text = PlayerDatabase.P1RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1RW2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1RW2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1RW2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1RW2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1RW2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1RW2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1RW2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1RW2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1RW2];
				}

				else if (ShowingOverlayString == "P1RW3") {
					PlayerText.text = PlayerDatabase.P1RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1RW3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1RW3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1RW3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1RW3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1RW3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1RW3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1RW3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1RW3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1RW3];
				}

				else if (ShowingOverlayString == "P1RW4") {
					PlayerText.text = PlayerDatabase.P1RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW4];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1RW4];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1RW4];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1RW4];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1RW4];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1RW4];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1RW4];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RW4] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RW4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RW4];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1RW4];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1RW4];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1RW4];
				}

				else if (ShowingOverlayString == "P1LD1") {
					PlayerText.text = PlayerDatabase.P1LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LD1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1LD1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1LD1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1LD1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1LD1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1LD1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1LD1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1LD1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1LD1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1LD1];
				}

				else if (ShowingOverlayString == "P1LD2") {
					PlayerText.text = PlayerDatabase.P1LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LD2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1LD2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1LD2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1LD2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1LD2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1LD2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1LD2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1LD2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1LD2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1LD2];
				}

				else if (ShowingOverlayString == "P1LD3") {
					PlayerText.text = PlayerDatabase.P1LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LD3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1LD3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1LD3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1LD3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1LD3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1LD3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1LD3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1LD3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1LD3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1LD3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1LD3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1LD3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1LD3];
				}

				else if (ShowingOverlayString == "P1RD1") {
					PlayerText.text = PlayerDatabase.P1RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RD1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1RD1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1RD1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1RD1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1RD1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1RD1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1RD1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1RD1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1RD1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1RD1];
				}

				else if (ShowingOverlayString == "P1RD2") {
					PlayerText.text = PlayerDatabase.P1RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RD2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1RD2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1RD2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1RD2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1RD2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1RD2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1RD2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1RD2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1RD2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1RD2];
				}

				else if (ShowingOverlayString == "P1RD3") {
					PlayerText.text = PlayerDatabase.P1RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RD3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P1RD3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P1RD3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P1RD3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P1RD3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P1RD3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P1RD3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P1RD3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P1RD3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P1RD3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P1RD3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P1RD3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P1RD3];
				}

				// Computer
				else if (ShowingOverlayString == "P2C1") {
					PlayerText.text = PlayerDatabase.P2C1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2C1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2C1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2C1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2C1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2C1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2C1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2C1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2C1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2C1];
				}

				else if (ShowingOverlayString == "P2C2") {
					PlayerText.text = PlayerDatabase.P2C2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2C2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2C2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2C2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2C2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2C2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2C2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2C2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2C2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2C2];
				}

				else if (ShowingOverlayString == "P2C3") {
					PlayerText.text = PlayerDatabase.P2C3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2C3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2C3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2C3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2C3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2C3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2C3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2C3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2C3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2C3];
				}

				else if (ShowingOverlayString == "P2C4") {
					PlayerText.text = PlayerDatabase.P2C4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C4];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2C4];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2C4];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2C4];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2C4];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2C4];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2C4];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2C4] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2C4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2C4];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2C4];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2C4];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2C4];
				}

				else if (ShowingOverlayString == "P2LW1") {
					PlayerText.text = PlayerDatabase.P2LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2LW1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2LW1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2LW1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2LW1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2LW1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2LW1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2LW1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2LW1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2LW1];
				}

				else if (ShowingOverlayString == "P2LW2") {
					PlayerText.text = PlayerDatabase.P2LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2LW2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2LW2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2LW2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2LW2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2LW2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2LW2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2LW2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2LW2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2LW2];
				}

				else if (ShowingOverlayString == "P2LW3") {
					PlayerText.text = PlayerDatabase.P2LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2LW3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2LW3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2LW3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2LW3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2LW3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2LW3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2LW3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2LW3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2LW3];
				}

				else if (ShowingOverlayString == "P2LW4") {
					PlayerText.text = PlayerDatabase.P2LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW4];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2LW4];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2LW4];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2LW4];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2LW4];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2LW4];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2LW4];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LW4] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LW4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LW4];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2LW4];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2LW4];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2LW4];
				}

				else if (ShowingOverlayString == "P2RW1") {
					PlayerText.text = PlayerDatabase.P2RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2RW1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2RW1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2RW1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2RW1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2RW1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2RW1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2RW1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2RW1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2RW1];
				}

				else if (ShowingOverlayString == "P2RW2") {
					PlayerText.text = PlayerDatabase.P2RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2RW2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2RW2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2RW2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2RW2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2RW2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2RW2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2RW2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2RW2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2RW2];
				}

				else if (ShowingOverlayString == "P2RW3") {
					PlayerText.text = PlayerDatabase.P2RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2RW3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2RW3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2RW3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2RW3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2RW3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2RW3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2RW3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2RW3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2RW3];
				}

				else if (ShowingOverlayString == "P2RW4") {
					PlayerText.text = PlayerDatabase.P2RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW4];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2RW4];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2RW4];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2RW4];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2RW4];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2RW4];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2RW4];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW4] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RW4] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RW4];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RW4];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2RW4];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2RW4];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2RW4];
				}

				else if (ShowingOverlayString == "P2LD1") {
					PlayerText.text = PlayerDatabase.P2LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LD1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2LD1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2LD1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2LD1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2LD1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2LD1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2LD1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2LD1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2LD1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2LD1];
				}

				else if (ShowingOverlayString == "P2LD2") {
					PlayerText.text = PlayerDatabase.P2LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LD2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2LD2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2LD2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2LD2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2LD2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2LD2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2LD2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2LD2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2LD2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2LD2];
				}

				else if (ShowingOverlayString == "P2LD3") {
					PlayerText.text = PlayerDatabase.P2LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LD3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2LD3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2LD3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2LD3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2LD3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2LD3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2LD3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2LD3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2LD3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2LD3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2LD3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2LD3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2LD3];
				}

				else if (ShowingOverlayString == "P2RD1") {
					PlayerText.text = PlayerDatabase.P2RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RD1];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2RD1];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2RD1];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2RD1];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2RD1];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2RD1];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2RD1];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD1] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD1] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD1];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD1];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2RD1];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2RD1];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2RD1];
				}

				else if (ShowingOverlayString == "P2RD2") {
					PlayerText.text = PlayerDatabase.P2RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RD2];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2RD2];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2RD2];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2RD2];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2RD2];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2RD2];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2RD2];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD2] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD2] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD2];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD2];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2RD2];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2RD2];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2RD2];
				}

				else if (ShowingOverlayString == "P2RD3") {
					PlayerText.text = PlayerDatabase.P2RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RD3];
					PlayerDefending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[PlayerDatabase.P2RD3];
					PlayerDefending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[PlayerDatabase.P2RD3];
					PlayerDefending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[PlayerDatabase.P2RD3];
					PlayerDefending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[PlayerDatabase.P2RD3];
					PlayerDefending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[PlayerDatabase.P2RD3];
					PlayerDefending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[PlayerDatabase.P2RD3];

					if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3];
						PlayerDefending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3];
						PlayerDefending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD3] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3];
						PlayerDefending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3];
					}

					else if ((StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[PlayerDatabase.P2RD3] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[PlayerDatabase.P2RD3];
						PlayerDefending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[PlayerDatabase.P2RD3];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[PlayerDatabase.P2RD3];
					PlayerDefending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[PlayerDatabase.P2RD3];
					PlayerDefending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[PlayerDatabase.P2RD3];
				}
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if ((ShowingOverlayString != "P1G") && (ShowingOverlayString != "P2G")) {
				// Player
				if (ShowingOverlayString == "P1C1") {
					PlayerText.text = PlayerDatabase.P1C1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1C2") {
					PlayerText.text = PlayerDatabase.P1C2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1C3") {
					PlayerText.text = PlayerDatabase.P1C3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1C4") {
					PlayerText.text = PlayerDatabase.P1C4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW1") {
					PlayerText.text = PlayerDatabase.P1LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW2") {
					PlayerText.text = PlayerDatabase.P1LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW3") {
					PlayerText.text = PlayerDatabase.P1LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW4") {
					PlayerText.text = PlayerDatabase.P1LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW1") {
					PlayerText.text = PlayerDatabase.P1RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW2") {
					PlayerText.text = PlayerDatabase.P1RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW3") {
					PlayerText.text = PlayerDatabase.P1RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW4") {
					PlayerText.text = PlayerDatabase.P1RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LD1") {
					PlayerText.text = PlayerDatabase.P1LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LD2") {
					PlayerText.text = PlayerDatabase.P1LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LD3") {
					PlayerText.text = PlayerDatabase.P1LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RD1") {
					PlayerText.text = PlayerDatabase.P1RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RD2") {
					PlayerText.text = PlayerDatabase.P1RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RD3") {
					PlayerText.text = PlayerDatabase.P1RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
				}

				// Computer
				else if (ShowingOverlayString == "P2C1") {
					PlayerText.text = PlayerDatabase.P2C1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2C2") {
					PlayerText.text = PlayerDatabase.P2C2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2C3") {
					PlayerText.text = PlayerDatabase.P2C3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2C4") {
					PlayerText.text = PlayerDatabase.P2C4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW1") {
					PlayerText.text = PlayerDatabase.P2LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW2") {
					PlayerText.text = PlayerDatabase.P2LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW3") {
					PlayerText.text = PlayerDatabase.P2LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW4") {
					PlayerText.text = PlayerDatabase.P2LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW1") {
					PlayerText.text = PlayerDatabase.P2RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW2") {
					PlayerText.text = PlayerDatabase.P2RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW3") {
					PlayerText.text = PlayerDatabase.P2RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW4") {
					PlayerText.text = PlayerDatabase.P2RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LD1") {
					PlayerText.text = PlayerDatabase.P2LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LD2") {
					PlayerText.text = PlayerDatabase.P2LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LD3") {
					PlayerText.text = PlayerDatabase.P2LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RD1") {
					PlayerText.text = PlayerDatabase.P2RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RD2") {
					PlayerText.text = PlayerDatabase.P2RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RD3") {
					PlayerText.text = PlayerDatabase.P2RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];

					if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					}

					else if ((StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam] == "Penalty")) {
						PlayerDefending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
						PlayerDefending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					}

					PlayerDefending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
				}
			}
		}

		// Set Goalie Data
		if (ShowingOverlayString == "P1G") {
			PlayerOffense.enabled = false;
			PlayerDefense.enabled = false;
			PlayerBreakaway.enabled = false;
			PlayerIntimidation.enabled = false;
			PlayerPenalty.enabled = false;
			PlayerFaceoff.enabled = false;

			PlayerText.text = PlayerDatabase.P1G;
			PlayerTeam.text = PlayerDatabase.PlayerChosenTeam;
		}

		else if (ShowingOverlayString == "P2G") {
			PlayerOffense.enabled = false;
			PlayerDefense.enabled = false;
			PlayerBreakaway.enabled = false;
			PlayerIntimidation.enabled = false;
			PlayerPenalty.enabled = false;
			PlayerFaceoff.enabled = false;

			PlayerText.text = PlayerDatabase.P2G;
			PlayerTeam.text = PlayerDatabase.ComputerChosenTeam;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}