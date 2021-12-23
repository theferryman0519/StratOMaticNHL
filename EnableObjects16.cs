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

public class EnableObjects16 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image OutsideShotButton;
	public Image PenetrateButton;
	public Image PassingButton;
	public Image ContinueButton;

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
	public Image PlayerScroll;
	public Image PlayerView;
	public Text PlayerOutsideTitle;
	public Text PlayerOutside02;
	public Text PlayerOutside03;
	public Text PlayerOutside04;
	public Text PlayerOutside05;
	public Text PlayerOutside06;
	public Text PlayerOutside07;
	public Text PlayerOutside08;
	public Text PlayerOutside09;
	public Text PlayerOutside10;
	public Text PlayerOutside11;
	public Text PlayerOutside12;
	public Text PlayerInsideTitle;
	public Text PlayerInside02;
	public Text PlayerInside03;
	public Text PlayerInside04;
	public Text PlayerInside05;
	public Text PlayerInside06;
	public Text PlayerInside07;
	public Text PlayerInside08;
	public Text PlayerInside09;
	public Text PlayerInside10;
	public Text PlayerInside11;
	public Text PlayerInside12;
	public Text PlayerPassingTitle;
	public Text PlayerPassingA;
	public Text PlayerPassingB;
	public Text PlayerPassingC;
	public Text PlayerPassingD;
	public Text PlayerPassingE;
	public Text PlayerPassingF;
	public Text PlayerPassingG;
	public Text PlayerPassingH;
	public Text PlayerPassingI;
	public Text PlayerPassingJ;
	public Text PlayerPassingK;
	public Text PlayerPassingL;
	public Image PlayerFlipButton;
	public Image PlayerBackButton;
	public Text PlayerScrollNote;

	public Sprite BackgroundNamePlayer;
	public Sprite BackgroundNameComputer;

	// Flip Button Images
	public Sprite PlayerFlipToOptions;
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
			DisableOverlayOptionsObjects();
		}

		else if (ShowingOverlayInt == 1) {
			EnableOverlayObjects();

			if (FlippingPlayerData == 0) {
				EnableOverlayMainObjects();
				DisableOverlayOptionsObjects();
				PlayerFlipButton.sprite = PlayerFlipToOptions;
			}

			else if (FlippingPlayerData == 1) {
				DisableOverlayMainObjects();
				EnableOverlayOptionsObjects();
				PlayerFlipButton.sprite = PlayerFlipToMain;
			}
		}

		if (PlayerDatabase.GameplayPossession.Contains("P1")) {
			EnableP1ButtonObjects();
		}

		else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
			EnableP2ButtonObjects();
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
	}

	public void EnableP1ButtonObjects() {
		OutsideShotButton.enabled = true;
		PenetrateButton.enabled = true;
		PassingButton.enabled = true;
		ContinueButton.enabled = false;
	}

	public void EnableP2ButtonObjects() {
		OutsideShotButton.enabled = false;
		PenetrateButton.enabled = false;
		PassingButton.enabled = false;
		ContinueButton.enabled = true;
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
		PlayerScrollNote.enabled = true;
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

	public void EnableOverlayOptionsObjects() {
		PlayerScroll.enabled = true;
		PlayerView.enabled = true;
		PlayerOutsideTitle.enabled = true;
		PlayerOutside02.enabled = true;
		PlayerOutside03.enabled = true;
		PlayerOutside04.enabled = true;
		PlayerOutside05.enabled = true;
		PlayerOutside06.enabled = true;
		PlayerOutside07.enabled = true;
		PlayerOutside08.enabled = true;
		PlayerOutside09.enabled = true;
		PlayerOutside10.enabled = true;
		PlayerOutside11.enabled = true;
		PlayerOutside12.enabled = true;
		PlayerInsideTitle.enabled = true;
		PlayerInside02.enabled = true;
		PlayerInside03.enabled = true;
		PlayerInside04.enabled = true;
		PlayerInside05.enabled = true;
		PlayerInside06.enabled = true;
		PlayerInside07.enabled = true;
		PlayerInside08.enabled = true;
		PlayerInside09.enabled = true;
		PlayerInside10.enabled = true;
		PlayerInside11.enabled = true;
		PlayerInside12.enabled = true;
		PlayerPassingTitle.enabled = true;
		PlayerPassingA.enabled = true;
		PlayerPassingB.enabled = true;
		PlayerPassingC.enabled = true;
		PlayerPassingD.enabled = true;
		PlayerPassingE.enabled = true;
		PlayerPassingF.enabled = true;
		PlayerPassingG.enabled = true;
		PlayerPassingH.enabled = true;
		PlayerPassingI.enabled = true;
		PlayerPassingJ.enabled = true;
		PlayerPassingK.enabled = true;
		PlayerPassingL.enabled = true;
	}

// --------------- DISABLING OBEJCTS FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ActionText.enabled = false;
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
		PlayerScrollNote.enabled = false;
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

	public void DisableOverlayOptionsObjects() {
		PlayerScroll.enabled = false;
		PlayerView.enabled = false;
		PlayerOutsideTitle.enabled = false;
		PlayerOutside02.enabled = false;
		PlayerOutside03.enabled = false;
		PlayerOutside04.enabled = false;
		PlayerOutside05.enabled = false;
		PlayerOutside06.enabled = false;
		PlayerOutside07.enabled = false;
		PlayerOutside08.enabled = false;
		PlayerOutside09.enabled = false;
		PlayerOutside10.enabled = false;
		PlayerOutside11.enabled = false;
		PlayerOutside12.enabled = false;
		PlayerInsideTitle.enabled = false;
		PlayerInside02.enabled = false;
		PlayerInside03.enabled = false;
		PlayerInside04.enabled = false;
		PlayerInside05.enabled = false;
		PlayerInside06.enabled = false;
		PlayerInside07.enabled = false;
		PlayerInside08.enabled = false;
		PlayerInside09.enabled = false;
		PlayerInside10.enabled = false;
		PlayerInside11.enabled = false;
		PlayerInside12.enabled = false;
		PlayerPassingTitle.enabled = false;
		PlayerPassingA.enabled = false;
		PlayerPassingB.enabled = false;
		PlayerPassingC.enabled = false;
		PlayerPassingD.enabled = false;
		PlayerPassingE.enabled = false;
		PlayerPassingF.enabled = false;
		PlayerPassingG.enabled = false;
		PlayerPassingH.enabled = false;
		PlayerPassingI.enabled = false;
		PlayerPassingJ.enabled = false;
		PlayerPassingK.enabled = false;
		PlayerPassingL.enabled = false;
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
			ActionText.text = PlayerDatabase.P1C1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1C2") {
			ActionText.text = PlayerDatabase.P1C2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1C3") {
			ActionText.text = PlayerDatabase.P1C3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1C4") {
			ActionText.text = PlayerDatabase.P1C4 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW1") {
			ActionText.text = PlayerDatabase.P1LW1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW2") {
			ActionText.text = PlayerDatabase.P1LW2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW3") {
			ActionText.text = PlayerDatabase.P1LW3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW4") {
			ActionText.text = PlayerDatabase.P1LW4 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW1") {
			ActionText.text = PlayerDatabase.P1RW1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW2") {
			ActionText.text = PlayerDatabase.P1RW2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW3") {
			ActionText.text = PlayerDatabase.P1RW3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW4") {
			ActionText.text = PlayerDatabase.P1RW4 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD1") {
			ActionText.text = PlayerDatabase.P1LD1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD2") {
			ActionText.text = PlayerDatabase.P1LD2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD3") {
			ActionText.text = PlayerDatabase.P1LD3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD1") {
			ActionText.text = PlayerDatabase.P1RD1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD2") {
			ActionText.text = PlayerDatabase.P1RD2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD3") {
			ActionText.text = PlayerDatabase.P1RD3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		// P2
		else if (PlayerDatabase.GameplayPossession == "P2C1") {
			ActionText.text = PlayerDatabase.P2C1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2C2") {
			ActionText.text = PlayerDatabase.P2C2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2C3") {
			ActionText.text = PlayerDatabase.P2C3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2C4") {
			ActionText.text = PlayerDatabase.P2C4 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW1") {
			ActionText.text = PlayerDatabase.P2LW1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW2") {
			ActionText.text = PlayerDatabase.P2LW2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW3") {
			ActionText.text = PlayerDatabase.P2LW3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW4") {
			ActionText.text = PlayerDatabase.P2LW4 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW1") {
			ActionText.text = PlayerDatabase.P2RW1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW2") {
			ActionText.text = PlayerDatabase.P2RW2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW3") {
			ActionText.text = PlayerDatabase.P2RW3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW4") {
			ActionText.text = PlayerDatabase.P2RW4 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD1") {
			ActionText.text = PlayerDatabase.P2LD1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD2") {
			ActionText.text = PlayerDatabase.P2LD2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD3") {
			ActionText.text = PlayerDatabase.P2LD3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD1") {
			ActionText.text = PlayerDatabase.P2RD1 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD2") {
			ActionText.text = PlayerDatabase.P2RD2 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD3") {
			ActionText.text = PlayerDatabase.P2RD3 + " has the ability to take an outside shot, attempt to penetrate inside, or pass the puck.";
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
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1C1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1C1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1C1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1C1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1C1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1C1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1C1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1C1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1C1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1C1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1C1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1C1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1C1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1C1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1C1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1C1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1C1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1C1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1C1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1C1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1C1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1C1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1C1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1C1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1C1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1C1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1C1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1C1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1C1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1C1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1C1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1C1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1C1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1C1];
				}

				else if (ShowingOverlayString == "P1C2") {
					PlayerText.text = PlayerDatabase.P1C2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1C2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1C2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1C2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1C2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1C2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1C2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1C2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1C2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1C2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1C2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1C2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1C2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1C2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1C2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1C2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1C2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1C2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1C2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1C2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1C2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1C2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1C2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1C2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1C2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1C2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1C2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1C2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1C2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1C2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1C2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1C2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1C2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1C2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1C2];
				}

				else if (ShowingOverlayString == "P1C3") {
					PlayerText.text = PlayerDatabase.P1C3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1C3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1C3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1C3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1C3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1C3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1C3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1C3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1C3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1C3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1C3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1C3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1C3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1C3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1C3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1C3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1C3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1C3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1C3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1C3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1C3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1C3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1C3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1C3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1C3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1C3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1C3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1C3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1C3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1C3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1C3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1C3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1C3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1C3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1C3];
				}

				else if (ShowingOverlayString == "P1C4") {
					PlayerText.text = PlayerDatabase.P1C4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1C4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1C4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1C4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1C4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1C4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1C4];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1C4];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1C4];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1C4];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1C4];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1C4];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1C4];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1C4];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1C4];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1C4];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1C4];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1C4];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1C4];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1C4];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1C4];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1C4];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1C4];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1C4];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1C4];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1C4];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1C4];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1C4];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1C4];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1C4];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1C4];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1C4];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1C4];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1C4];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1C4];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1C4];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1C4];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1C4];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1C4];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1C4];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1C4];
				}

				else if (ShowingOverlayString == "P1LW1") {
					PlayerText.text = PlayerDatabase.P1LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW1];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1LW1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1LW1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1LW1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1LW1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1LW1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1LW1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1LW1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1LW1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1LW1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1LW1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1LW1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LW1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LW1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LW1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LW1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LW1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LW1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LW1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LW1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LW1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LW1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LW1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1LW1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1LW1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1LW1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1LW1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1LW1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1LW1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1LW1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1LW1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1LW1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1LW1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1LW1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1LW1];
				}

				else if (ShowingOverlayString == "P1LW2") {
					PlayerText.text = PlayerDatabase.P1LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1LW2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1LW2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1LW2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1LW2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1LW2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1LW2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1LW2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1LW2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1LW2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1LW2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1LW2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LW2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LW2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LW2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LW2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LW2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LW2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LW2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LW2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LW2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LW2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LW2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1LW2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1LW2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1LW2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1LW2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1LW2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1LW2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1LW2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1LW2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1LW2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1LW2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1LW2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1LW2];
				}

				else if (ShowingOverlayString == "P1LW3") {
					PlayerText.text = PlayerDatabase.P1LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1LW3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1LW3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1LW3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1LW3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1LW3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1LW3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1LW3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1LW3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1LW3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1LW3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1LW3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LW3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LW3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LW3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LW3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LW3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LW3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LW3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LW3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LW3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LW3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LW3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1LW3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1LW3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1LW3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1LW3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1LW3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1LW3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1LW3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1LW3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1LW3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1LW3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1LW3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1LW3];
				}

				else if (ShowingOverlayString == "P1LW4") {
					PlayerText.text = PlayerDatabase.P1LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LW4];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1LW4];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1LW4];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1LW4];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1LW4];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1LW4];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1LW4];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1LW4];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1LW4];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1LW4];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1LW4];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1LW4];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LW4];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LW4];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LW4];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LW4];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LW4];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LW4];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LW4];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LW4];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LW4];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LW4];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LW4];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1LW4];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1LW4];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1LW4];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1LW4];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1LW4];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1LW4];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1LW4];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1LW4];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1LW4];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1LW4];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1LW4];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1LW4];
				}

				else if (ShowingOverlayString == "P1RW1") {
					PlayerText.text = PlayerDatabase.P1RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW1];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1RW1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1RW1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1RW1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1RW1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1RW1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1RW1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1RW1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1RW1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1RW1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1RW1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1RW1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RW1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RW1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RW1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RW1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RW1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RW1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RW1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RW1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RW1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RW1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RW1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1RW1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1RW1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1RW1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1RW1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1RW1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1RW1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1RW1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1RW1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1RW1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1RW1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1RW1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1RW1];
				}

				else if (ShowingOverlayString == "P1RW2") {
					PlayerText.text = PlayerDatabase.P1RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1RW2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1RW2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1RW2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1RW2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1RW2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1RW2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1RW2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1RW2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1RW2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1RW2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1RW2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RW2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RW2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RW2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RW2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RW2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RW2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RW2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RW2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RW2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RW2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RW2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1RW2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1RW2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1RW2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1RW2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1RW2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1RW2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1RW2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1RW2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1RW2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1RW2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1RW2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1RW2];
				}

				else if (ShowingOverlayString == "P1RW3") {
					PlayerText.text = PlayerDatabase.P1RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1RW3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1RW3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1RW3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1RW3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1RW3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1RW3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1RW3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1RW3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1RW3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1RW3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1RW3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RW3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RW3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RW3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RW3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RW3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RW3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RW3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RW3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RW3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RW3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RW3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1RW3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1RW3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1RW3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1RW3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1RW3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1RW3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1RW3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1RW3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1RW3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1RW3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1RW3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1RW3];
				}

				else if (ShowingOverlayString == "P1RW4") {
					PlayerText.text = PlayerDatabase.P1RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RW4];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1RW4];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1RW4];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1RW4];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1RW4];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1RW4];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1RW4];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1RW4];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1RW4];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1RW4];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1RW4];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1RW4];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RW4];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RW4];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RW4];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RW4];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RW4];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RW4];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RW4];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RW4];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RW4];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RW4];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RW4];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1RW4];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1RW4];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1RW4];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1RW4];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1RW4];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1RW4];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1RW4];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1RW4];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1RW4];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1RW4];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1RW4];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1RW4];
				}

				else if (ShowingOverlayString == "P1LD1") {
					PlayerText.text = PlayerDatabase.P1LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LD1];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1LD1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1LD1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1LD1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1LD1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1LD1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1LD1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1LD1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1LD1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1LD1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1LD1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1LD1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LD1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LD1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LD1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LD1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LD1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LD1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LD1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LD1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LD1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LD1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LD1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1LD1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1LD1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1LD1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1LD1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1LD1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1LD1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1LD1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1LD1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1LD1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1LD1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1LD1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1LD1];
				}

				else if (ShowingOverlayString == "P1LD2") {
					PlayerText.text = PlayerDatabase.P1LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LD2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1LD2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1LD2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1LD2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1LD2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1LD2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1LD2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1LD2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1LD2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1LD2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1LD2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1LD2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LD2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LD2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LD2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LD2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LD2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LD2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LD2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LD2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LD2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LD2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LD2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1LD2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1LD2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1LD2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1LD2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1LD2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1LD2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1LD2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1LD2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1LD2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1LD2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1LD2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1LD2];
				}

				else if (ShowingOverlayString == "P1LD3") {
					PlayerText.text = PlayerDatabase.P1LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1LD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1LD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1LD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1LD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1LD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1LD3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1LD3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1LD3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1LD3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1LD3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1LD3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1LD3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1LD3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1LD3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1LD3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1LD3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1LD3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1LD3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1LD3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1LD3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1LD3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1LD3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1LD3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1LD3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1LD3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1LD3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1LD3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1LD3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1LD3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1LD3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1LD3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1LD3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1LD3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1LD3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1LD3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1LD3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1LD3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1LD3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1LD3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1LD3];
				}

				else if (ShowingOverlayString == "P1RD1") {
					PlayerText.text = PlayerDatabase.P1RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RD1];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1RD1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1RD1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1RD1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1RD1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1RD1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1RD1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1RD1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1RD1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1RD1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1RD1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1RD1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RD1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RD1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RD1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RD1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RD1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RD1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RD1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RD1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RD1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RD1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RD1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1RD1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1RD1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1RD1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1RD1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1RD1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1RD1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1RD1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1RD1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1RD1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1RD1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1RD1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1RD1];
				}

				else if (ShowingOverlayString == "P1RD2") {
					PlayerText.text = PlayerDatabase.P1RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RD2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1RD2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1RD2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1RD2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1RD2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1RD2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1RD2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1RD2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1RD2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1RD2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1RD2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1RD2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RD2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RD2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RD2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RD2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RD2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RD2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RD2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RD2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RD2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RD2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RD2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1RD2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1RD2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1RD2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1RD2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1RD2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1RD2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1RD2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1RD2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1RD2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1RD2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1RD2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1RD2];
				}

				else if (ShowingOverlayString == "P1RD3") {
					PlayerText.text = PlayerDatabase.P1RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P1RD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P1RD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P1RD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P1RD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P1RD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P1RD3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P1RD3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P1RD3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P1RD3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P1RD3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P1RD3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P1RD3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P1RD3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P1RD3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P1RD3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P1RD3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P1RD3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P1RD3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P1RD3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P1RD3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P1RD3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P1RD3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P1RD3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P1RD3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P1RD3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P1RD3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P1RD3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P1RD3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P1RD3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P1RD3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P1RD3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P1RD3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P1RD3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P1RD3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P1RD3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P1RD3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P1RD3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P1RD3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P1RD3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P1RD3];
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
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2C1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2C1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2C1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2C1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2C1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2C1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2C1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2C1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2C1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2C1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2C1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2C1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2C1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2C1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2C1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2C1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2C1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2C1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2C1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2C1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2C1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2C1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2C1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2C1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2C1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2C1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2C1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2C1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2C1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2C1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2C1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2C1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2C1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2C1];
				}

				else if (ShowingOverlayString == "P2C2") {
					PlayerText.text = PlayerDatabase.P2C2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2C2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2C2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2C2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2C2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2C2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2C2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2C2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2C2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2C2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2C2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2C2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2C2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2C2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2C2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2C2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2C2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2C2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2C2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2C2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2C2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2C2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2C2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2C2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2C2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2C2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2C2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2C2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2C2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2C2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2C2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2C2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2C2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2C2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2C2];
				}

				else if (ShowingOverlayString == "P2C3") {
					PlayerText.text = PlayerDatabase.P2C3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2C3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2C3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2C3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2C3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2C3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2C3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2C3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2C3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2C3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2C3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2C3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2C3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2C3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2C3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2C3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2C3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2C3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2C3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2C3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2C3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2C3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2C3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2C3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2C3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2C3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2C3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2C3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2C3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2C3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2C3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2C3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2C3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2C3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2C3];
				}

				else if (ShowingOverlayString == "P2C4") {
					PlayerText.text = PlayerDatabase.P2C4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2C4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2C4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2C4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2C4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2C4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2C4];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2C4];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2C4];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2C4];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2C4];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2C4];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2C4];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2C4];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2C4];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2C4];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2C4];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2C4];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2C4];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2C4];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2C4];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2C4];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2C4];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2C4];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2C4];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2C4];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2C4];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2C4];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2C4];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2C4];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2C4];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2C4];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2C4];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2C4];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2C4];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2C4];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2C4];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2C4];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2C4];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2C4];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2C4];
				}

				else if (ShowingOverlayString == "P2LW1") {
					PlayerText.text = PlayerDatabase.P2LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW1];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2LW1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2LW1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2LW1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2LW1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2LW1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2LW1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2LW1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2LW1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2LW1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2LW1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2LW1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LW1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LW1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LW1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LW1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LW1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LW1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LW1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LW1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LW1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LW1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LW1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2LW1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2LW1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2LW1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2LW1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2LW1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2LW1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2LW1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2LW1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2LW1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2LW1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2LW1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2LW1];
				}

				else if (ShowingOverlayString == "P2LW2") {
					PlayerText.text = PlayerDatabase.P2LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2LW2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2LW2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2LW2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2LW2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2LW2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2LW2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2LW2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2LW2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2LW2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2LW2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2LW2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LW2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LW2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LW2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LW2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LW2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LW2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LW2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LW2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LW2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LW2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LW2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2LW2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2LW2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2LW2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2LW2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2LW2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2LW2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2LW2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2LW2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2LW2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2LW2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2LW2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2LW2];
				}

				else if (ShowingOverlayString == "P2LW3") {
					PlayerText.text = PlayerDatabase.P2LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2LW3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2LW3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2LW3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2LW3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2LW3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2LW3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2LW3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2LW3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2LW3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2LW3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2LW3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LW3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LW3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LW3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LW3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LW3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LW3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LW3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LW3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LW3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LW3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LW3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2LW3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2LW3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2LW3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2LW3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2LW3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2LW3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2LW3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2LW3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2LW3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2LW3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2LW3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2LW3];
				}

				else if (ShowingOverlayString == "P2LW4") {
					PlayerText.text = PlayerDatabase.P2LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LW4];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2LW4];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2LW4];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2LW4];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2LW4];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2LW4];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2LW4];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2LW4];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2LW4];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2LW4];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2LW4];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2LW4];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LW4];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LW4];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LW4];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LW4];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LW4];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LW4];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LW4];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LW4];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LW4];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LW4];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LW4];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2LW4];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2LW4];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2LW4];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2LW4];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2LW4];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2LW4];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2LW4];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2LW4];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2LW4];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2LW4];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2LW4];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2LW4];
				}

				else if (ShowingOverlayString == "P2RW1") {
					PlayerText.text = PlayerDatabase.P2RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW1];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2RW1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2RW1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2RW1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2RW1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2RW1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2RW1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2RW1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2RW1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2RW1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2RW1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2RW1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RW1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RW1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RW1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RW1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RW1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RW1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RW1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RW1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RW1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RW1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RW1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2RW1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2RW1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2RW1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2RW1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2RW1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2RW1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2RW1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2RW1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2RW1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2RW1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2RW1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2RW1];
				}

				else if (ShowingOverlayString == "P2RW2") {
					PlayerText.text = PlayerDatabase.P2RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2RW2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2RW2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2RW2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2RW2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2RW2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2RW2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2RW2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2RW2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2RW2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2RW2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2RW2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RW2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RW2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RW2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RW2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RW2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RW2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RW2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RW2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RW2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RW2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RW2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2RW2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2RW2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2RW2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2RW2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2RW2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2RW2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2RW2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2RW2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2RW2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2RW2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2RW2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2RW2];
				}

				else if (ShowingOverlayString == "P2RW3") {
					PlayerText.text = PlayerDatabase.P2RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2RW3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2RW3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2RW3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2RW3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2RW3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2RW3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2RW3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2RW3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2RW3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2RW3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2RW3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RW3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RW3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RW3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RW3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RW3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RW3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RW3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RW3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RW3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RW3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RW3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2RW3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2RW3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2RW3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2RW3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2RW3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2RW3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2RW3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2RW3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2RW3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2RW3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2RW3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2RW3];
				}

				else if (ShowingOverlayString == "P2RW4") {
					PlayerText.text = PlayerDatabase.P2RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RW4];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RW4];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RW4];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RW4];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RW4];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RW4];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2RW4];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2RW4];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2RW4];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2RW4];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2RW4];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2RW4];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2RW4];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2RW4];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2RW4];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2RW4];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2RW4];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RW4];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RW4];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RW4];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RW4];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RW4];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RW4];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RW4];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RW4];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RW4];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RW4];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RW4];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2RW4];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2RW4];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2RW4];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2RW4];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2RW4];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2RW4];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2RW4];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2RW4];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2RW4];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2RW4];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2RW4];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2RW4];
				}

				else if (ShowingOverlayString == "P2LD1") {
					PlayerText.text = PlayerDatabase.P2LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LD1];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2LD1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2LD1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2LD1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2LD1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2LD1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2LD1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2LD1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2LD1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2LD1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2LD1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2LD1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LD1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LD1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LD1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LD1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LD1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LD1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LD1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LD1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LD1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LD1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LD1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2LD1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2LD1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2LD1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2LD1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2LD1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2LD1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2LD1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2LD1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2LD1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2LD1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2LD1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2LD1];
				}

				else if (ShowingOverlayString == "P2LD2") {
					PlayerText.text = PlayerDatabase.P2LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LD2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2LD2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2LD2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2LD2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2LD2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2LD2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2LD2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2LD2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2LD2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2LD2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2LD2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2LD2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LD2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LD2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LD2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LD2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LD2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LD2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LD2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LD2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LD2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LD2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LD2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2LD2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2LD2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2LD2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2LD2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2LD2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2LD2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2LD2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2LD2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2LD2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2LD2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2LD2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2LD2];
				}

				else if (ShowingOverlayString == "P2LD3") {
					PlayerText.text = PlayerDatabase.P2LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2LD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2LD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2LD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2LD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2LD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2LD3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2LD3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2LD3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2LD3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2LD3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2LD3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2LD3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2LD3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2LD3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2LD3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2LD3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2LD3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2LD3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2LD3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2LD3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2LD3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2LD3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2LD3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2LD3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2LD3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2LD3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2LD3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2LD3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2LD3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2LD3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2LD3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2LD3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2LD3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2LD3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2LD3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2LD3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2LD3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2LD3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2LD3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2LD3];
				}

				else if (ShowingOverlayString == "P2RD1") {
					PlayerText.text = PlayerDatabase.P2RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD1];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD1];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RD1];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RD1];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RD1];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RD1];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2RD1];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2RD1];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2RD1];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2RD1];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2RD1];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2RD1];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2RD1];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2RD1];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2RD1];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2RD1];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2RD1];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RD1];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RD1];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RD1];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RD1];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RD1];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RD1];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RD1];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RD1];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RD1];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RD1];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RD1];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2RD1];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2RD1];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2RD1];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2RD1];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2RD1];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2RD1];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2RD1];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2RD1];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2RD1];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2RD1];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2RD1];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2RD1];
				}

				else if (ShowingOverlayString == "P2RD2") {
					PlayerText.text = PlayerDatabase.P2RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD2];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD2];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RD2];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RD2];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RD2];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RD2];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2RD2];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2RD2];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2RD2];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2RD2];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2RD2];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2RD2];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2RD2];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2RD2];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2RD2];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2RD2];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2RD2];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RD2];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RD2];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RD2];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RD2];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RD2];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RD2];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RD2];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RD2];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RD2];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RD2];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RD2];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2RD2];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2RD2];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2RD2];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2RD2];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2RD2];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2RD2];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2RD2];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2RD2];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2RD2];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2RD2];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2RD2];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2RD2];
				}

				else if (ShowingOverlayString == "P2RD3") {
					PlayerText.text = PlayerDatabase.P2RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.PlayerStatsOffense[PlayerDatabase.P2RD3];
					PlayerDefense.text = "Defense: " + StatsDefense.PlayerStatsDefense[PlayerDatabase.P2RD3];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[PlayerDatabase.P2RD3];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[PlayerDatabase.P2RD3];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[PlayerDatabase.P2RD3];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[PlayerDatabase.P2RD3];
					PlayerOutside02.text = "2) " + StatsOutside02.PlayerStatsOutside02[PlayerDatabase.P2RD3];
					PlayerOutside03.text = "3) " + StatsOutside03.PlayerStatsOutside03[PlayerDatabase.P2RD3];
					PlayerOutside04.text = "4) " + StatsOutside04.PlayerStatsOutside04[PlayerDatabase.P2RD3];
					PlayerOutside05.text = "5) " + StatsOutside05.PlayerStatsOutside05[PlayerDatabase.P2RD3];
					PlayerOutside06.text = "6) " + StatsOutside06.PlayerStatsOutside06[PlayerDatabase.P2RD3];
					PlayerOutside07.text = "7) " + StatsOutside07.PlayerStatsOutside07[PlayerDatabase.P2RD3];
					PlayerOutside08.text = "8) " + StatsOutside08.PlayerStatsOutside08[PlayerDatabase.P2RD3];
					PlayerOutside09.text = "9) " + StatsOutside09.PlayerStatsOutside09[PlayerDatabase.P2RD3];
					PlayerOutside10.text = "10) " + StatsOutside10.PlayerStatsOutside10[PlayerDatabase.P2RD3];
					PlayerOutside11.text = "11) " + StatsOutside11.PlayerStatsOutside11[PlayerDatabase.P2RD3];
					PlayerOutside12.text = "12) " + StatsOutside12.PlayerStatsOutside12[PlayerDatabase.P2RD3];
					PlayerInside02.text = "2) " + StatsInside02.PlayerStatsInside02[PlayerDatabase.P2RD3];
					PlayerInside03.text = "3) " + StatsInside03.PlayerStatsInside03[PlayerDatabase.P2RD3];
					PlayerInside04.text = "4) " + StatsInside04.PlayerStatsInside04[PlayerDatabase.P2RD3];
					PlayerInside05.text = "5) " + StatsInside05.PlayerStatsInside05[PlayerDatabase.P2RD3];
					PlayerInside06.text = "6) " + StatsInside06.PlayerStatsInside06[PlayerDatabase.P2RD3];
					PlayerInside07.text = "7) " + StatsInside07.PlayerStatsInside07[PlayerDatabase.P2RD3];
					PlayerInside08.text = "8) " + StatsInside08.PlayerStatsInside08[PlayerDatabase.P2RD3];
					PlayerInside09.text = "9) " + StatsInside09.PlayerStatsInside09[PlayerDatabase.P2RD3];
					PlayerInside10.text = "10) " + StatsInside10.PlayerStatsInside10[PlayerDatabase.P2RD3];
					PlayerInside11.text = "11) " + StatsInside11.PlayerStatsInside11[PlayerDatabase.P2RD3];
					PlayerInside12.text = "12) " + StatsInside12.PlayerStatsInside12[PlayerDatabase.P2RD3];
					PlayerPassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[PlayerDatabase.P2RD3];
					PlayerPassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[PlayerDatabase.P2RD3];
					PlayerPassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[PlayerDatabase.P2RD3];
					PlayerPassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[PlayerDatabase.P2RD3];
					PlayerPassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[PlayerDatabase.P2RD3];
					PlayerPassingF.text = "F) " + StatsPassingF.PlayerStatsPassingF[PlayerDatabase.P2RD3];
					PlayerPassingG.text = "G) " + StatsPassingG.PlayerStatsPassingG[PlayerDatabase.P2RD3];
					PlayerPassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[PlayerDatabase.P2RD3];
					PlayerPassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[PlayerDatabase.P2RD3];
					PlayerPassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[PlayerDatabase.P2RD3];
					PlayerPassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[PlayerDatabase.P2RD3];
					PlayerPassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[PlayerDatabase.P2RD3];
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
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1C1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1C2") {
					PlayerText.text = PlayerDatabase.P1C2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1C2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1C3") {
					PlayerText.text = PlayerDatabase.P1C3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1C3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1C4") {
					PlayerText.text = PlayerDatabase.P1C4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1C4 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW1") {
					PlayerText.text = PlayerDatabase.P1LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1LW1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW2") {
					PlayerText.text = PlayerDatabase.P1LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1LW2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW3") {
					PlayerText.text = PlayerDatabase.P1LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1LW3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LW4") {
					PlayerText.text = PlayerDatabase.P1LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1LW4 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW1") {
					PlayerText.text = PlayerDatabase.P1RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1RW1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW2") {
					PlayerText.text = PlayerDatabase.P1RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1RW2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW3") {
					PlayerText.text = PlayerDatabase.P1RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1RW3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RW4") {
					PlayerText.text = PlayerDatabase.P1RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1RW4 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LD1") {
					PlayerText.text = PlayerDatabase.P1LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1LD1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LD2") {
					PlayerText.text = PlayerDatabase.P1LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1LD2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1LD3") {
					PlayerText.text = PlayerDatabase.P1LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1LD3 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RD1") {
					PlayerText.text = PlayerDatabase.P1RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1RD1 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RD2") {
					PlayerText.text = PlayerDatabase.P1RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1RD2 + PlayerDatabase.PlayerChosenTeam];
				}

				else if (ShowingOverlayString == "P1RD3") {
					PlayerText.text = PlayerDatabase.P1RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P1RD3 + PlayerDatabase.PlayerChosenTeam];
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
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2C1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2C2") {
					PlayerText.text = PlayerDatabase.P2C2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2C2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2C3") {
					PlayerText.text = PlayerDatabase.P2C3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2C3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2C4") {
					PlayerText.text = PlayerDatabase.P2C4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2C4 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW1") {
					PlayerText.text = PlayerDatabase.P2LW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2LW1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW2") {
					PlayerText.text = PlayerDatabase.P2LW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2LW2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW3") {
					PlayerText.text = PlayerDatabase.P2LW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2LW3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LW4") {
					PlayerText.text = PlayerDatabase.P2LW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2LW4 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW1") {
					PlayerText.text = PlayerDatabase.P2RW1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2RW1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW2") {
					PlayerText.text = PlayerDatabase.P2RW2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2RW2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW3") {
					PlayerText.text = PlayerDatabase.P2RW3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2RW3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RW4") {
					PlayerText.text = PlayerDatabase.P2RW4;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2RW4 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LD1") {
					PlayerText.text = PlayerDatabase.P2LD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2LD1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LD2") {
					PlayerText.text = PlayerDatabase.P2LD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2LD2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2LD3") {
					PlayerText.text = PlayerDatabase.P2LD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2LD3 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RD1") {
					PlayerText.text = PlayerDatabase.P2RD1;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2RD1 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RD2") {
					PlayerText.text = PlayerDatabase.P2RD2;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2RD2 + PlayerDatabase.ComputerChosenTeam];
				}

				else if (ShowingOverlayString == "P2RD3") {
					PlayerText.text = PlayerDatabase.P2RD3;
					PlayerOffense.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerDefense.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPenalty.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerBreakaway.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerIntimidation.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerFaceoff.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerOutside12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside02.text = "2) " + StatsInside02.FrPlayerStatsInside02[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside03.text = "3) " + StatsInside03.FrPlayerStatsInside03[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside04.text = "4) " + StatsInside04.FrPlayerStatsInside04[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside05.text = "5) " + StatsInside05.FrPlayerStatsInside05[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside06.text = "6) " + StatsInside06.FrPlayerStatsInside06[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside07.text = "7) " + StatsInside07.FrPlayerStatsInside07[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside08.text = "8) " + StatsInside08.FrPlayerStatsInside08[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside09.text = "9) " + StatsInside09.FrPlayerStatsInside09[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside10.text = "10) " + StatsInside10.FrPlayerStatsInside10[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside11.text = "11) " + StatsInside11.FrPlayerStatsInside11[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerInside12.text = "12) " + StatsInside12.FrPlayerStatsInside12[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingF.text = "F) " + StatsPassingF.FrPlayerStatsPassingF[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingG.text = "G) " + StatsPassingG.FrPlayerStatsPassingG[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
					PlayerPassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[PlayerDatabase.P2RD3 + PlayerDatabase.ComputerChosenTeam];
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