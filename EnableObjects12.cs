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

public class EnableObjects12 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image ShotButton;

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

	// Puck Movement
	public Image P1CPuck;
	public Image P1LWPuck;
	public Image P1RWPuck;
	public Image P1LDPuck;
	public Image P1RDPuck;
	public Image P1GPuck;
	public Image P2CPuck;
	public Image P2LWPuck;
	public Image P2RWPuck;
	public Image P2LDPuck;
	public Image P2RDPuck;
	public Image P2GPuck;

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
	public Text PlayerShotTitle;
	public Text PlayerShot02;
	public Text PlayerShot03;
	public Text PlayerShot04;
	public Text PlayerShot05;
	public Text PlayerShot06;
	public Text PlayerShot07;
	public Text PlayerShot08;
	public Text PlayerShot09;
	public Text PlayerShot10;
	public Text PlayerShot11;
	public Text PlayerShot12;
	public Image PlayerFlipButton;
	public Image PlayerBackButton;

	public Sprite BackgroundNamePlayer;
	public Sprite BackgroundNameComputer;

	// Flip Button Images
	public Sprite PlayerFlipToShots;
	public Sprite PlayerFlipToMain;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ShowingOverlayInt;
	public static string ShowingOverlayString;
	public static int GettingPlayerInts;
	public static int FlippingPlayerData;
	
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
			DisableOverlayShotObjects();
		}

		else if (ShowingOverlayInt == 1) {
			EnableOverlayObjects();

			if (FlippingPlayerData == 0) {
				EnableOverlayMainObjects();
				DisableOverlayShotObjects();
				PlayerFlipButton.sprite = PlayerFlipToShots;
			}

			else if (FlippingPlayerData == 1) {
				DisableOverlayMainObjects();
				EnableOverlayShotObjects();
				PlayerFlipButton.sprite = PlayerFlipToMain;
			}
		}

		UpdatingScoreboard();
		UpdatingLines();
		UpdatingActionText();
		UpdatingPossession();
		UpdatingPuckMovement();
		UpdatingOverlayTexts();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
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

	public void EnablePuckMovementP1C() {
		P1CPuck.enabled = true;
	}

	public void EnablePuckMovementP1LW() {
		P1LWPuck.enabled = true;
	}

	public void EnablePuckMovementP1RW() {
		P1RWPuck.enabled = true;
	}

	public void EnablePuckMovementP1LD() {
		P1LDPuck.enabled = true;
	}

	public void EnablePuckMovementP1RD() {
		P1RDPuck.enabled = true;
	}

	public void EnablePuckMovementP1G() {
		P1GPuck.enabled = true;
	}

	public void EnablePuckMovementP2C() {
		P2CPuck.enabled = true;
	}

	public void EnablePuckMovementP2LW() {
		P2LWPuck.enabled = true;
	}

	public void EnablePuckMovementP2RW() {
		P2RWPuck.enabled = true;
	}

	public void EnablePuckMovementP2LD() {
		P2LDPuck.enabled = true;
	}

	public void EnablePuckMovementP2RD() {
		P2RDPuck.enabled = true;
	}

	public void EnablePuckMovementP2G() {
		P2GPuck.enabled = true;
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

	public void EnableOverlayShotObjects() {
		PlayerShotTitle.enabled = true;
		PlayerShot02.enabled = true;
		PlayerShot03.enabled = true;
		PlayerShot04.enabled = true;
		PlayerShot05.enabled = true;
		PlayerShot06.enabled = true;
		PlayerShot07.enabled = true;
		PlayerShot08.enabled = true;
		PlayerShot09.enabled = true;
		PlayerShot10.enabled = true;
		PlayerShot11.enabled = true;
		PlayerShot12.enabled = true;
	}

// --------------- DISABLING OBEJCTS FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ActionText.enabled = false;
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

	public void DisablePuckMovementP1C() {
		P1CPuck.enabled = false;
	}

	public void DisablePuckMovementP1LW() {
		P1LWPuck.enabled = false;
	}

	public void DisablePuckMovementP1RW() {
		P1RWPuck.enabled = false;
	}

	public void DisablePuckMovementP1LD() {
		P1LDPuck.enabled = false;
	}

	public void DisablePuckMovementP1RD() {
		P1RDPuck.enabled = false;
	}

	public void DisablePuckMovementP1G() {
		P1GPuck.enabled = false;
	}

	public void DisablePuckMovementP2C() {
		P2CPuck.enabled = false;
	}

	public void DisablePuckMovementP2LW() {
		P2LWPuck.enabled = false;
	}

	public void DisablePuckMovementP2RW() {
		P2RWPuck.enabled = false;
	}

	public void DisablePuckMovementP2LD() {
		P2LDPuck.enabled = false;
	}

	public void DisablePuckMovementP2RD() {
		P2RDPuck.enabled = false;
	}

	public void DisablePuckMovementP2G() {
		P2GPuck.enabled = false;
	}

	public void DisableAllPuckMovement() {
		DisablePuckMovementP1C();
		DisablePuckMovementP1LW();
		DisablePuckMovementP1RW();
		DisablePuckMovementP1LD();
		DisablePuckMovementP1RD();
		DisablePuckMovementP1G();
		DisablePuckMovementP2C();
		DisablePuckMovementP2LW();
		DisablePuckMovementP2RW();
		DisablePuckMovementP2LD();
		DisablePuckMovementP2RD();
		DisablePuckMovementP2G();
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

	public void DisableOverlayShotObjects() {
		PlayerShotTitle.enabled = false;
		PlayerShot02.enabled = false;
		PlayerShot03.enabled = false;
		PlayerShot04.enabled = false;
		PlayerShot05.enabled = false;
		PlayerShot06.enabled = false;
		PlayerShot07.enabled = false;
		PlayerShot08.enabled = false;
		PlayerShot09.enabled = false;
		PlayerShot10.enabled = false;
		PlayerShot11.enabled = false;
		PlayerShot12.enabled = false;
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
			ActionText.text = PlayerDatabase.P1C1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1C2") {
			ActionText.text = PlayerDatabase.P1C2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1C3") {
			ActionText.text = PlayerDatabase.P1C3 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1C4") {
			ActionText.text = PlayerDatabase.P1C4 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW1") {
			ActionText.text = PlayerDatabase.P1LW1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW2") {
			ActionText.text = PlayerDatabase.P1LW2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW3") {
			ActionText.text = PlayerDatabase.P1LW3 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW4") {
			ActionText.text = PlayerDatabase.P1LW4 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW1") {
			ActionText.text = PlayerDatabase.P1RW1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW2") {
			ActionText.text = PlayerDatabase.P1RW2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW3") {
			ActionText.text = PlayerDatabase.P1RW3 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW4") {
			ActionText.text = PlayerDatabase.P1RW4 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD1") {
			ActionText.text = PlayerDatabase.P1LD1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD2") {
			ActionText.text = PlayerDatabase.P1LD2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD3") {
			ActionText.text = PlayerDatabase.P1LD3 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD1") {
			ActionText.text = PlayerDatabase.P1RD1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD2") {
			ActionText.text = PlayerDatabase.P1RD2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD3") {
			ActionText.text = PlayerDatabase.P1RD3 + " is attempting to shoot for an inside shot.";
		}

		// P2
		else if (PlayerDatabase.GameplayPossession == "P2C1") {
			ActionText.text = PlayerDatabase.P2C1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2C2") {
			ActionText.text = PlayerDatabase.P2C2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2C3") {
			ActionText.text = PlayerDatabase.P2C3 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2C4") {
			ActionText.text = PlayerDatabase.P2C4 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW1") {
			ActionText.text = PlayerDatabase.P2LW1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW2") {
			ActionText.text = PlayerDatabase.P2LW2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW3") {
			ActionText.text = PlayerDatabase.P2LW3 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW4") {
			ActionText.text = PlayerDatabase.P2LW4 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW1") {
			ActionText.text = PlayerDatabase.P2RW1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW2") {
			ActionText.text = PlayerDatabase.P2RW2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW3") {
			ActionText.text = PlayerDatabase.P2RW3 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW4") {
			ActionText.text = PlayerDatabase.P2RW4 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD1") {
			ActionText.text = PlayerDatabase.P2LD1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD2") {
			ActionText.text = PlayerDatabase.P2LD2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD3") {
			ActionText.text = PlayerDatabase.P2LD3 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD1") {
			ActionText.text = PlayerDatabase.P2RD1 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD2") {
			ActionText.text = PlayerDatabase.P2RD2 + " is attempting to shoot for an inside shot.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD3") {
			ActionText.text = PlayerDatabase.P2RD3 + " is attempting to shoot for an inside shot.";
		}
	}

	public void UpdatingPossession() {
		if (PlayerDatabase.GameplayPossession.Contains("P1")) {
			DisableRinkObjectsP2();
			EnableRinkObjectsP1();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
			DisableRinkObjectsP1();
			EnableRinkObjectsP2();
		}
	}

	public void UpdatingPuckMovement() {
		DisableAllPuckMovement();

		if (PlayerDatabase.GameplayPossession.Contains("P1C")) {
			EnablePuckMovementP1C();
		}
		
		else if (PlayerDatabase.GameplayPossession.Contains("P1LW")) {
			EnablePuckMovementP1LW();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P1RW")) {
			EnablePuckMovementP1RW();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P1LD")) {
			EnablePuckMovementP1LD();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P1RD")) {
			EnablePuckMovementP1RD();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P1G")) {
			EnablePuckMovementP1G();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P2C")) {
			EnablePuckMovementP2C();
		}
		
		else if (PlayerDatabase.GameplayPossession.Contains("P2LW")) {
			EnablePuckMovementP2LW();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P2RW")) {
			EnablePuckMovementP2RW();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P2LD")) {
			EnablePuckMovementP2LD();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P2RD")) {
			EnablePuckMovementP2RD();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P2G")) {
			EnablePuckMovementP2G();
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
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1C1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1C1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1C1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1C1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1C1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1C1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1C1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1C1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1C1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1C1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1C1];
				}

				else if (ShowingOverlayString == "P1C2") {
					PlayerText.text = PlayerDatabase.P1C2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1C2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1C2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1C2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1C2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1C2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1C2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1C2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1C2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1C2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1C2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1C2];
				}

				else if (ShowingOverlayString == "P1C3") {
					PlayerText.text = PlayerDatabase.P1C3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1C3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1C3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1C3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1C3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1C3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1C3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1C3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1C3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1C3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1C3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1C3];
				}

				else if (ShowingOverlayString == "P1C4") {
					PlayerText.text = PlayerDatabase.P1C4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C4];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1C4];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1C4];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1C4];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1C4];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1C4];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1C4];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1C4];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1C4];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1C4];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1C4];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1C4];
				}

				else if (ShowingOverlayString == "P1LW1") {
					PlayerText.text = PlayerDatabase.P1LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW1];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LW1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LW1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LW1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LW1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LW1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LW1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LW1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LW1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LW1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LW1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LW1];
				}

				else if (ShowingOverlayString == "P1LW2") {
					PlayerText.text = PlayerDatabase.P1LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LW2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LW2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LW2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LW2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LW2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LW2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LW2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LW2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LW2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LW2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LW2];
				}

				else if (ShowingOverlayString == "P1LW3") {
					PlayerText.text = PlayerDatabase.P1LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LW3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LW3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LW3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LW3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LW3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LW3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LW3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LW3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LW3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LW3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LW3];
				}

				else if (ShowingOverlayString == "P1LW4") {
					PlayerText.text = PlayerDatabase.P1LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW4];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LW4];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LW4];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LW4];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LW4];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LW4];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LW4];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LW4];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LW4];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LW4];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LW4];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LW4];
				}

				else if (ShowingOverlayString == "P1RW1") {
					PlayerText.text = PlayerDatabase.P1RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW1];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RW1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RW1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RW1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RW1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RW1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RW1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RW1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RW1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RW1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RW1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RW1];
				}

				else if (ShowingOverlayString == "P1RW2") {
					PlayerText.text = PlayerDatabase.P1RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RW2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RW2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RW2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RW2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RW2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RW2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RW2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RW2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RW2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RW2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RW2];
				}

				else if (ShowingOverlayString == "P1RW3") {
					PlayerText.text = PlayerDatabase.P1RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RW3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RW3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RW3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RW3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RW3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RW3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RW3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RW3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RW3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RW3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RW3];
				}

				else if (ShowingOverlayString == "P1RW4") {
					PlayerText.text = PlayerDatabase.P1RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW4];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RW4];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RW4];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RW4];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RW4];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RW4];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RW4];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RW4];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RW4];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RW4];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RW4];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RW4];
				}

				else if (ShowingOverlayString == "P1LD1") {
					PlayerText.text = PlayerDatabase.P1LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LD1];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LD1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LD1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LD1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LD1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LD1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LD1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LD1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LD1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LD1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LD1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LD1];
				}

				else if (ShowingOverlayString == "P1LD2") {
					PlayerText.text = PlayerDatabase.P1LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LD2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LD2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LD2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LD2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LD2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LD2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LD2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LD2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LD2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LD2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LD2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LD2];
				}

				else if (ShowingOverlayString == "P1LD3") {
					PlayerText.text = PlayerDatabase.P1LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LD3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LD3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LD3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LD3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LD3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LD3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LD3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LD3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LD3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LD3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LD3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LD3];
				}

				else if (ShowingOverlayString == "P1RD1") {
					PlayerText.text = PlayerDatabase.P1RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RD1];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RD1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RD1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RD1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RD1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RD1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RD1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RD1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RD1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RD1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RD1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RD1];
				}

				else if (ShowingOverlayString == "P1RD2") {
					PlayerText.text = PlayerDatabase.P1RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RD2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RD2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RD2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RD2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RD2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RD2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RD2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RD2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RD2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RD2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RD2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RD2];
				}

				else if (ShowingOverlayString == "P1RD3") {
					PlayerText.text = PlayerDatabase.P1RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RD3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RD3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RD3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RD3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RD3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RD3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RD3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RD3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RD3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RD3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RD3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RD3];
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
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2C1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2C1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2C1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2C1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2C1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2C1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2C1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2C1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2C1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2C1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2C1];
				}

				else if (ShowingOverlayString == "P2C2") {
					PlayerText.text = PlayerDatabase.P2C2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2C2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2C2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2C2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2C2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2C2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2C2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2C2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2C2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2C2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2C2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2C2];
				}

				else if (ShowingOverlayString == "P2C3") {
					PlayerText.text = PlayerDatabase.P2C3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2C3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2C3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2C3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2C3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2C3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2C3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2C3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2C3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2C3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2C3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2C3];
				}

				else if (ShowingOverlayString == "P2C4") {
					PlayerText.text = PlayerDatabase.P2C4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C4];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2C4];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2C4];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2C4];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2C4];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2C4];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2C4];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2C4];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2C4];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2C4];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2C4];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2C4];
				}

				else if (ShowingOverlayString == "P2LW1") {
					PlayerText.text = PlayerDatabase.P2LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW1];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LW1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LW1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LW1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LW1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LW1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LW1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LW1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LW1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LW1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LW1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LW1];
				}

				else if (ShowingOverlayString == "P2LW2") {
					PlayerText.text = PlayerDatabase.P2LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LW2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LW2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LW2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LW2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LW2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LW2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LW2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LW2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LW2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LW2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LW2];
				}

				else if (ShowingOverlayString == "P2LW3") {
					PlayerText.text = PlayerDatabase.P2LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LW3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LW3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LW3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LW3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LW3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LW3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LW3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LW3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LW3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LW3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LW3];
				}

				else if (ShowingOverlayString == "P2LW4") {
					PlayerText.text = PlayerDatabase.P2LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW4];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LW4];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LW4];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LW4];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LW4];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LW4];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LW4];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LW4];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LW4];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LW4];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LW4];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LW4];
				}

				else if (ShowingOverlayString == "P2RW1") {
					PlayerText.text = PlayerDatabase.P2RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW1];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RW1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RW1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RW1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RW1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RW1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RW1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RW1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RW1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RW1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RW1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RW1];
				}

				else if (ShowingOverlayString == "P2RW2") {
					PlayerText.text = PlayerDatabase.P2RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RW2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RW2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RW2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RW2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RW2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RW2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RW2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RW2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RW2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RW2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RW2];
				}

				else if (ShowingOverlayString == "P2RW3") {
					PlayerText.text = PlayerDatabase.P2RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RW3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RW3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RW3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RW3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RW3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RW3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RW3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RW3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RW3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RW3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RW3];
				}

				else if (ShowingOverlayString == "P2RW4") {
					PlayerText.text = PlayerDatabase.P2RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW4];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RW4];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RW4];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RW4];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RW4];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RW4];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RW4];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RW4];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RW4];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RW4];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RW4];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RW4];
				}

				else if (ShowingOverlayString == "P2LD1") {
					PlayerText.text = PlayerDatabase.P2LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LD1];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LD1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LD1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LD1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LD1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LD1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LD1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LD1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LD1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LD1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LD1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LD1];
				}

				else if (ShowingOverlayString == "P2LD2") {
					PlayerText.text = PlayerDatabase.P2LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LD2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LD2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LD2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LD2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LD2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LD2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LD2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LD2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LD2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LD2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LD2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LD2];
				}

				else if (ShowingOverlayString == "P2LD3") {
					PlayerText.text = PlayerDatabase.P2LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LD3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LD3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LD3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LD3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LD3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LD3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LD3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LD3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LD3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LD3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LD3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LD3];
				}

				else if (ShowingOverlayString == "P2RD1") {
					PlayerText.text = PlayerDatabase.P2RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RD1];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RD1];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RD1];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RD1];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RD1];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RD1];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RD1];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RD1];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RD1];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RD1];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RD1];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RD1];
				}

				else if (ShowingOverlayString == "P2RD2") {
					PlayerText.text = PlayerDatabase.P2RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RD2];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RD2];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RD2];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RD2];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RD2];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RD2];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RD2];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RD2];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RD2];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RD2];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RD2];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RD2];
				}

				else if (ShowingOverlayString == "P2RD3") {
					PlayerText.text = PlayerDatabase.P2RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RD3];
					PlayerShot02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RD3];
					PlayerShot03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RD3];
					PlayerShot04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RD3];
					PlayerShot05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RD3];
					PlayerShot06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RD3];
					PlayerShot07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RD3];
					PlayerShot08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RD3];
					PlayerShot09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RD3];
					PlayerShot10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RD3];
					PlayerShot11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RD3];
					PlayerShot12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RD3];
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
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1C2") {
					PlayerText.text = PlayerDatabase.P1C2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1C3") {
					PlayerText.text = PlayerDatabase.P1C3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1C4") {
					PlayerText.text = PlayerDatabase.P1C4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW1") {
					PlayerText.text = PlayerDatabase.P1LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW2") {
					PlayerText.text = PlayerDatabase.P1LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW3") {
					PlayerText.text = PlayerDatabase.P1LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW4") {
					PlayerText.text = PlayerDatabase.P1LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW1") {
					PlayerText.text = PlayerDatabase.P1RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW2") {
					PlayerText.text = PlayerDatabase.P1RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW3") {
					PlayerText.text = PlayerDatabase.P1RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW4") {
					PlayerText.text = PlayerDatabase.P1RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LD1") {
					PlayerText.text = PlayerDatabase.P1LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LD2") {
					PlayerText.text = PlayerDatabase.P1LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LD3") {
					PlayerText.text = PlayerDatabase.P1LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RD1") {
					PlayerText.text = PlayerDatabase.P1RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RD2") {
					PlayerText.text = PlayerDatabase.P1RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RD3") {
					PlayerText.text = PlayerDatabase.P1RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
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
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2C2") {
					PlayerText.text = PlayerDatabase.P2C2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2C3") {
					PlayerText.text = PlayerDatabase.P2C3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2C4") {
					PlayerText.text = PlayerDatabase.P2C4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW1") {
					PlayerText.text = PlayerDatabase.P2LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW2") {
					PlayerText.text = PlayerDatabase.P2LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW3") {
					PlayerText.text = PlayerDatabase.P2LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW4") {
					PlayerText.text = PlayerDatabase.P2LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW1") {
					PlayerText.text = PlayerDatabase.P2RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW2") {
					PlayerText.text = PlayerDatabase.P2RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW3") {
					PlayerText.text = PlayerDatabase.P2RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW4") {
					PlayerText.text = PlayerDatabase.P2RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LD1") {
					PlayerText.text = PlayerDatabase.P2LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LD2") {
					PlayerText.text = PlayerDatabase.P2LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LD3") {
					PlayerText.text = PlayerDatabase.P2LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RD1") {
					PlayerText.text = PlayerDatabase.P2RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RD2") {
					PlayerText.text = PlayerDatabase.P2RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RD3") {
					PlayerText.text = PlayerDatabase.P2RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
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