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

public class EnableObjects06 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image FaceoffButton;

	// Scoreboard Objects
	public Image ScoreboardBackground;
	public Text P1Score;
	public Text P2Score;
	public Text P1Shots;
	public Text P2Shots;
	public Text Period;
	public Text Play;

	// Rink Objects
	public Image RinkBackground;
	public Image P1C;
	public Image P2C;

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
	public Image PlayerBackButton;

	public Sprite BackgroundNamePlayer;
	public Sprite BackgroundNameComputer;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ShowingOverlayInt;
	public static string ShowingOverlayString;
	public static int GettingPlayerInts;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ShowingOverlayInt = 0;
		ShowingOverlayString = "None";
		EnableMainObjects();
		EnableScoreboardObjects();
		EnableRinkObjects();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (ShowingOverlayInt == 0) {
			DisableOverlayObjects();
		}

		else if (ShowingOverlayInt == 1) {
			EnableOverlayObjects();
		}

		UpdatingScoreboard();
		UpdatingLines();
		UpdateActionText();
		UpdateOverlayTexts();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
		FaceoffButton.enabled = true;
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

	public void EnableRinkObjects() {
		RinkBackground.enabled = true;
		P1C.enabled = true;
		P2C.enabled = true;
	}

	public void EnableOverlayObjects() {
		OverlayBackground.enabled = true;
		PlayerNameBackground.enabled = true;
		PlayerText.enabled = true;
		PlayerTeam.enabled = true;
		PlayerOffense.enabled = true;
		PlayerDefense.enabled = true;
		PlayerBreakaway.enabled = true;
		PlayerIntimidation.enabled = true;
		PlayerPenalty.enabled = true;
		PlayerFaceoff.enabled = true;
		PlayerBackButton.enabled = true;
	}

// --------------- DISABLING OBEJCTS FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ActionText.enabled = false;
		FaceoffButton.enabled = false;
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

	public void DisableRinkObjects() {
		RinkBackground.enabled = false;
		P1C.enabled = false;
		P2C.enabled = false;
	}

	public void DisableOverlayObjects() {
		OverlayBackground.enabled = false;
		PlayerNameBackground.enabled = false;
		PlayerText.enabled = false;
		PlayerTeam.enabled = false;
		PlayerOffense.enabled = false;
		PlayerDefense.enabled = false;
		PlayerBreakaway.enabled = false;
		PlayerIntimidation.enabled = false;
		PlayerPenalty.enabled = false;
		PlayerFaceoff.enabled = false;
		PlayerBackButton.enabled = false;
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

	public void UpdateActionText() {
		if (PlayerDatabase.GameplayLine == "F1D1") {
			ActionText.text = "The puck is about to drop between " + PlayerDatabase.P1C1 + " and " + PlayerDatabase.P2C1;
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			ActionText.text = "The puck is about to drop between " + PlayerDatabase.P1C2 + " and " + PlayerDatabase.P2C2;
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			ActionText.text = "The puck is about to drop between " + PlayerDatabase.P1C3 + " and " + PlayerDatabase.P2C3;
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			ActionText.text = "The puck is about to drop between " + PlayerDatabase.P1C4 + " and " + PlayerDatabase.P2C4;
		}
	}

	public void UpdateOverlayTexts() {
		// Set Title Color
		if (ShowingOverlayString.Contains("P1")) {
			PlayerNameBackground.sprite = BackgroundNamePlayer;
		}

		else if (ShowingOverlayString.Contains("P2")) {
			PlayerNameBackground.sprite = BackgroundNameComputer;
		}

		// Set Team
		if ((ShowingOverlayString == "P1C1") || (ShowingOverlayString == "P1C2") || (ShowingOverlayString == "P1C3") || (ShowingOverlayString == "P1C4")) {
			PlayerTeam.text = "Team: " + PlayerDatabase.PlayerChosenTeam;
		}

		else if ((ShowingOverlayString == "P2C1") || (ShowingOverlayString == "P2C2") || (ShowingOverlayString == "P2C3") || (ShowingOverlayString == "P2C4")) {
			PlayerTeam.text = "Team: " + PlayerDatabase.ComputerChosenTeam;
		}

		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			// Set Player Data - Player
			if (ShowingOverlayString == "P1C1") {
				PlayerText.text = PlayerDatabase.P1C1;
				PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C1];
				PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C1];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C1];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C1];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C1];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C1];
			}

			else if (ShowingOverlayString == "P1C2") {
				PlayerText.text = PlayerDatabase.P1C2;
				PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C2];
				PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C2];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C2];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C2];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C2];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C2];
			}

			else if (ShowingOverlayString == "P1C3") {
				PlayerText.text = PlayerDatabase.P1C3;
				PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C3];
				PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C3];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C3];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C3];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C3];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C3];
			}

			else if (ShowingOverlayString == "P1C4") {
				PlayerText.text = PlayerDatabase.P1C4;
				PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C4];
				PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C4];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C4];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C4];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C4];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C4];
			}

			// Set Player Data - Computer
			if (ShowingOverlayString == "P2C1") {
				PlayerText.text = PlayerDatabase.P2C1;
				PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C1];
				PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C1];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C1];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C1];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C1];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C1];
			}

			else if (ShowingOverlayString == "P2C2") {
				PlayerText.text = PlayerDatabase.P2C2;
				PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C2];
				PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C2];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C2];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C2];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C2];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C2];
			}

			else if (ShowingOverlayString == "P2C3") {
				PlayerText.text = PlayerDatabase.P2C3;
				PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C3];
				PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C3];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C3];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C3];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C3];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C3];
			}

			else if (ShowingOverlayString == "P2C4") {
				PlayerText.text = PlayerDatabase.P2C4;
				PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C4];
				PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C4];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C4];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C4];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C4];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C4];
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			// Set Player Data - Player
			if (ShowingOverlayString == "P1C1") {
				PlayerText.text = PlayerDatabase.P1C1;
				PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
			}

			else if (ShowingOverlayString == "P1C2") {
				PlayerText.text = PlayerDatabase.P1C2;
				PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
			}

			else if (ShowingOverlayString == "P1C3") {
				PlayerText.text = PlayerDatabase.P1C3;
				PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
			}

			else if (ShowingOverlayString == "P1C4") {
				PlayerText.text = PlayerDatabase.P1C4;
				PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
			}

			// Set Player Data - Computer
			if (ShowingOverlayString == "P2C1") {
				PlayerText.text = PlayerDatabase.P2C1;
				PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (ShowingOverlayString == "P2C2") {
				PlayerText.text = PlayerDatabase.P2C2;
				PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (ShowingOverlayString == "P2C3") {
				PlayerText.text = PlayerDatabase.P2C3;
				PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
			}

			else if (ShowingOverlayString == "P2C4") {
				PlayerText.text = PlayerDatabase.P2C4;
				PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}