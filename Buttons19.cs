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

public class Buttons19 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button ContinueButton;
	public Button PlayerBackButton;

	// Player Buttons
	public Button P1C;
	public Button P1LW;
	public Button P1RW;
	public Button P1LD;
	public Button P1RD;
	public Button P1G;
	public Button P2C;
	public Button P2LW;
	public Button P2RW;
	public Button P2LD;
	public Button P2RD;
	public Button P2G;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string PenalizedPlayer;
	public static string PlayerPenaltyRating;
	public static int RandomizeSplitNumber;
	public static int RandomizePenaltyInt;
	public static string PenaltyType;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene19BLoadRun;
	public SceneChange Scene19CLoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// ContinueButton
		Button ContinueButtonClick = ContinueButton.GetComponent<Button>();
		ContinueButtonClick.onClick.AddListener(ContinueButtonClicking);

		// PlayerBackButton
		Button PlayerBackButtonClick = PlayerBackButton.GetComponent<Button>();
		PlayerBackButtonClick.onClick.AddListener(PlayerBackButtonClicking);

		// Player Buttons
		Button P1CClick = P1C.GetComponent<Button>();
		Button P1LWClick = P1LW.GetComponent<Button>();
		Button P1RWClick = P1RW.GetComponent<Button>();
		Button P1LDClick = P1LD.GetComponent<Button>();
		Button P1RDClick = P1RD.GetComponent<Button>();
		Button P1GClick = P1G.GetComponent<Button>();
		Button P2CClick = P2C.GetComponent<Button>();
		Button P2LWClick = P2LW.GetComponent<Button>();
		Button P2RWClick = P2RW.GetComponent<Button>();
		Button P2LDClick = P2LD.GetComponent<Button>();
		Button P2RDClick = P2RD.GetComponent<Button>();
		Button P2GClick = P2G.GetComponent<Button>();

		P1CClick.onClick.AddListener(P1CClicking);
		P1LWClick.onClick.AddListener(P1LWClicking);
		P1RWClick.onClick.AddListener(P1RWClicking);
		P1LDClick.onClick.AddListener(P1LDClicking);
		P1RDClick.onClick.AddListener(P1RDClicking);
		P1GClick.onClick.AddListener(P1GClicking);
		P2CClick.onClick.AddListener(P2CClicking);
		P2LWClick.onClick.AddListener(P2LWClicking);
		P2RWClick.onClick.AddListener(P2RWClicking);
		P2LDClick.onClick.AddListener(P2LDClicking);
		P2RDClick.onClick.AddListener(P2RDClicking);
		P2GClick.onClick.AddListener(P2GClicking);
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
	public void ContinueButtonClicking() {
		DeterminePenalty();
	}

	public void PlayerBackButtonClicking() {
		EnableObjects19.ShowingOverlayInt = 0;
	}

	public void P1CClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects19.ShowingOverlayString = "P1C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects19.ShowingOverlayString = "P1C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects19.ShowingOverlayString = "P1C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects19.ShowingOverlayString = "P1C4";
		}
	}

	public void P1LWClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects19.ShowingOverlayString = "P1LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects19.ShowingOverlayString = "P1LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects19.ShowingOverlayString = "P1LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects19.ShowingOverlayString = "P1LW4";
		}
	}

	public void P1RWClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects19.ShowingOverlayString = "P1RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects19.ShowingOverlayString = "P1RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects19.ShowingOverlayString = "P1RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects19.ShowingOverlayString = "P1RW4";
		}
	}

	public void P1LDClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects19.ShowingOverlayString = "P1LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects19.ShowingOverlayString = "P1LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects19.ShowingOverlayString = "P1LD3";
		}
	}

	public void P1RDClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects19.ShowingOverlayString = "P1RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects19.ShowingOverlayString = "P1RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects19.ShowingOverlayString = "P1RD3";
		}
	}

	public void P1GClicking() {
		EnableObjects19.ShowingOverlayInt = 1;
		EnableObjects19.ShowingOverlayString = "P1G";
	}

	public void P2CClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects19.ShowingOverlayString = "P2C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects19.ShowingOverlayString = "P2C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects19.ShowingOverlayString = "P2C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects19.ShowingOverlayString = "P2C4";
		}
	}

	public void P2LWClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects19.ShowingOverlayString = "P2LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects19.ShowingOverlayString = "P2LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects19.ShowingOverlayString = "P2LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects19.ShowingOverlayString = "P2LW4";
		}
	}

	public void P2RWClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects19.ShowingOverlayString = "P2RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects19.ShowingOverlayString = "P2RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects19.ShowingOverlayString = "P2RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects19.ShowingOverlayString = "P2RW4";
		}
	}

	public void P2LDClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects19.ShowingOverlayString = "P2LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects19.ShowingOverlayString = "P2LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects19.ShowingOverlayString = "P2LD3";
		}
	}

	public void P2RDClicking() {
		EnableObjects19.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects19.ShowingOverlayString = "P2RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects19.ShowingOverlayString = "P2RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects19.ShowingOverlayString = "P2RD3";
		}
	}

	public void P2GClicking() {
		EnableObjects19.ShowingOverlayInt = 1;
		EnableObjects19.ShowingOverlayString = "P2G";
	}

	public void DeterminePenalty() {
		// Get Penalized Player
		// P1
		if (PlayerDatabase.GameplayPossession == "P1C1") {
			PenalizedPlayer = PlayerDatabase.P1C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C2") {
			PenalizedPlayer = PlayerDatabase.P1C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C3") {
			PenalizedPlayer = PlayerDatabase.P1C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C4") {
			PenalizedPlayer = PlayerDatabase.P1C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW1") {
			PenalizedPlayer = PlayerDatabase.P1LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW2") {
			PenalizedPlayer = PlayerDatabase.P1LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW3") {
			PenalizedPlayer = PlayerDatabase.P1LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW4") {
			PenalizedPlayer = PlayerDatabase.P1LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW1") {
			PenalizedPlayer = PlayerDatabase.P1RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW2") {
			PenalizedPlayer = PlayerDatabase.P1RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW3") {
			PenalizedPlayer = PlayerDatabase.P1RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW4") {
			PenalizedPlayer = PlayerDatabase.P1RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD1") {
			PenalizedPlayer = PlayerDatabase.P1LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD2") {
			PenalizedPlayer = PlayerDatabase.P1LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD3") {
			PenalizedPlayer = PlayerDatabase.P1LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD1") {
			PenalizedPlayer = PlayerDatabase.P1RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD2") {
			PenalizedPlayer = PlayerDatabase.P1RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD3") {
			PenalizedPlayer = PlayerDatabase.P1RD3;
		}

		// P2
		else if (PlayerDatabase.GameplayPossession == "P2C1") {
			PenalizedPlayer = PlayerDatabase.P2C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C2") {
			PenalizedPlayer = PlayerDatabase.P2C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C3") {
			PenalizedPlayer = PlayerDatabase.P2C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C4") {
			PenalizedPlayer = PlayerDatabase.P2C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW1") {
			PenalizedPlayer = PlayerDatabase.P2LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW2") {
			PenalizedPlayer = PlayerDatabase.P2LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW3") {
			PenalizedPlayer = PlayerDatabase.P2LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW4") {
			PenalizedPlayer = PlayerDatabase.P2LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW1") {
			PenalizedPlayer = PlayerDatabase.P2RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW2") {
			PenalizedPlayer = PlayerDatabase.P2RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW3") {
			PenalizedPlayer = PlayerDatabase.P2RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW4") {
			PenalizedPlayer = PlayerDatabase.P2RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD1") {
			PenalizedPlayer = PlayerDatabase.P2LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD2") {
			PenalizedPlayer = PlayerDatabase.P2LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD3") {
			PenalizedPlayer = PlayerDatabase.P2LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD1") {
			PenalizedPlayer = PlayerDatabase.P2RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD2") {
			PenalizedPlayer = PlayerDatabase.P2RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD3") {
			PenalizedPlayer = PlayerDatabase.P2RD3;
		}

		// Get Penalty Rating
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			PlayerPenaltyRating = StatsPenalty.PlayerStatsPenalty[PenalizedPlayer];
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				PlayerPenaltyRating = StatsPenalty.FrPlayerStatsPenalty[PenalizedPlayer + PlayerDatabase.PlayerChosenTeam];
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				PlayerPenaltyRating = StatsPenalty.FrPlayerStatsPenalty[PenalizedPlayer + PlayerDatabase.ComputerChosenTeam];
			}
		}

		// Determine Penalty
		RandomizeSplitNumber = Random.Range(1,21);

		if (PlayerPenaltyRating == "AA") {
			if (RandomizeSplitNumber >= 5) {
				RandomizePenaltyType();
				Scene19CLoadRun.Scene19CLoad();
			}

			else {
				Scene19BLoadRun.Scene19BLoad();
			}
		}

		else if (PlayerPenaltyRating == "A") {
			if (RandomizeSplitNumber >= 7) {
				RandomizePenaltyType();
				Scene19CLoadRun.Scene19CLoad();
			}

			else {
				Scene19BLoadRun.Scene19BLoad();
			}
		}

		else if (PlayerPenaltyRating == "B") {
			if (RandomizeSplitNumber >= 9) {
				RandomizePenaltyType();
				Scene19CLoadRun.Scene19CLoad();
			}

			else {
				Scene19BLoadRun.Scene19BLoad();
			}
		}

		else if (PlayerPenaltyRating == "C") {
			if (RandomizeSplitNumber >= 12) {
				RandomizePenaltyType();
				Scene19CLoadRun.Scene19CLoad();
			}

			else {
				Scene19BLoadRun.Scene19BLoad();
			}
		}

		else if (PlayerPenaltyRating == "D") {
			if (RandomizeSplitNumber >= 15) {
				RandomizePenaltyType();
				Scene19CLoadRun.Scene19CLoad();
			}

			else {
				Scene19BLoadRun.Scene19BLoad();
			}
		}
	}

	public void RandomizePenaltyType() {
		RandomizePenaltyInt = Random.Range(1,19);

		if (RandomizePenaltyInt == 1) {
			PenaltyType = "Boarding";
		}

		else if (RandomizePenaltyInt == 2) {
			PenaltyType = "Charging";
		}

		else if (RandomizePenaltyInt == 3) {
			PenaltyType = "Cross Checking";
		}

		else if (RandomizePenaltyInt == 4) {
			PenaltyType = "Delay of Game";
		}

		else if (RandomizePenaltyInt == 5) {
			PenaltyType = "Elbowing";
		}

		else if (RandomizePenaltyInt == 6) {
			PenaltyType = "Embellishment";
		}

		else if (RandomizePenaltyInt == 7) {
			PenaltyType = "High Sticking";
		}

		else if (RandomizePenaltyInt == 8) {
			PenaltyType = "Hitting the Head";
		}

		else if (RandomizePenaltyInt == 9) {
			PenaltyType = "Holding";
		}

		else if (RandomizePenaltyInt == 10) {
			PenaltyType = "Hooking";
		}

		else if (RandomizePenaltyInt == 11) {
			PenaltyType = "Intent to Injure";
		}

		else if (RandomizePenaltyInt == 12) {
			PenaltyType = "Interference";
		}

		else if (RandomizePenaltyInt == 13) {
			PenaltyType = "Kneeing";
		}

		else if (RandomizePenaltyInt == 14) {
			PenaltyType = "Roughing";
		}

		else if (RandomizePenaltyInt == 15) {
			PenaltyType = "Slashing";
		}

		else if (RandomizePenaltyInt == 16) {
			PenaltyType = "Spearing";
		}

		else if (RandomizePenaltyInt == 17) {
			PenaltyType = "Tripping";
		}

		else if (RandomizePenaltyInt == 18) {
			PenaltyType = "Unsportsmanlike Conduct";
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}