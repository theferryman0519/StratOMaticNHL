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

public class Buttons13 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button IntimidationButton;
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
	public static string IntimidationString;
	public static int RandomizeSplitNumber;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene12LoadRun;
	public SceneChange Scene24LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// IntimidationButton
		Button IntimidationButtonClick = IntimidationButton.GetComponent<Button>();
		IntimidationButtonClick.onClick.AddListener(IntimidationButtonClicking);

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
	public void IntimidationButtonClicking() {
		// Get Player Intimidation
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			IntimidationString = StatsIntimidation.PlayerStatsIntimidation[EnableObjects13.IntimidatingPlayer];
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				IntimidationString = StatsIntimidation.FrPlayerStatsIntimidation[EnableObjects13.IntimidatingPlayer + PlayerDatabase.PlayerChosenTeam];
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				IntimidationString = StatsIntimidation.FrPlayerStatsIntimidation[EnableObjects13.IntimidatingPlayer + PlayerDatabase.ComputerChosenTeam];
			}
		}

		RandomizeSplitNumber = Random.Range(1,76);

		if (IntimidationString == "0") {
			EnableObjects13.IntimidatingPlayer = "None";
			EnableObjects13.IntimidationPos = "None";
			Scene12LoadRun.Scene12Load();
		}

		else if (IntimidationString == "1") {
			if (RandomizeSplitNumber <= 5) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-2") {
			if (RandomizeSplitNumber <= 10) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-3") {
			if (RandomizeSplitNumber <= 15) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-4") {
			if (RandomizeSplitNumber <= 20) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-5") {
			if (RandomizeSplitNumber <= 25) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-6") {
			if (RandomizeSplitNumber <= 30) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-7") {
			if (RandomizeSplitNumber <= 35) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-8") {
			if (RandomizeSplitNumber <= 40) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-9") {
			if (RandomizeSplitNumber <= 45) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-10") {
			if (RandomizeSplitNumber <= 50) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-11") {
			if (RandomizeSplitNumber <= 55) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-12") {
			if (RandomizeSplitNumber <= 60) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-13") {
			if (RandomizeSplitNumber <= 65) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-14") {
			if (RandomizeSplitNumber <= 70) {
				PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				EnableObjects24.TakeAwayContinue = "Pick";
				Scene24LoadRun.Scene24Load();
			}

			else {
				EnableObjects13.IntimidatingPlayer = "None";
				EnableObjects13.IntimidationPos = "None";
				Scene12LoadRun.Scene12Load();
			}
		}

		else if (IntimidationString == "1-15") {
			PlayerDatabase.GameplayPossession = EnableObjects13.IntimidationPos;
			EnableObjects13.IntimidatingPlayer = "None";
			EnableObjects13.IntimidationPos = "None";
			EnableObjects24.TakeAwayContinue = "Pick";
			Scene24LoadRun.Scene24Load();
		}
	}

	public void PlayerBackButtonClicking() {
		EnableObjects13.ShowingOverlayInt = 0;
	}

	public void P1CClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects13.ShowingOverlayString = "P1C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects13.ShowingOverlayString = "P1C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects13.ShowingOverlayString = "P1C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects13.ShowingOverlayString = "P1C4";
		}
	}

	public void P1LWClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects13.ShowingOverlayString = "P1LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects13.ShowingOverlayString = "P1LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects13.ShowingOverlayString = "P1LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects13.ShowingOverlayString = "P1LW4";
		}
	}

	public void P1RWClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects13.ShowingOverlayString = "P1RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects13.ShowingOverlayString = "P1RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects13.ShowingOverlayString = "P1RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects13.ShowingOverlayString = "P1RW4";
		}
	}

	public void P1LDClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects13.ShowingOverlayString = "P1LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects13.ShowingOverlayString = "P1LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects13.ShowingOverlayString = "P1LD3";
		}
	}

	public void P1RDClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects13.ShowingOverlayString = "P1RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects13.ShowingOverlayString = "P1RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects13.ShowingOverlayString = "P1RD3";
		}
	}

	public void P1GClicking() {
		EnableObjects13.ShowingOverlayInt = 1;
		EnableObjects13.ShowingOverlayString = "P1G";
	}

	public void P2CClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects13.ShowingOverlayString = "P2C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects13.ShowingOverlayString = "P2C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects13.ShowingOverlayString = "P2C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects13.ShowingOverlayString = "P2C4";
		}
	}

	public void P2LWClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects13.ShowingOverlayString = "P2LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects13.ShowingOverlayString = "P2LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects13.ShowingOverlayString = "P2LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects13.ShowingOverlayString = "P2LW4";
		}
	}

	public void P2RWClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects13.ShowingOverlayString = "P2RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects13.ShowingOverlayString = "P2RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects13.ShowingOverlayString = "P2RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects13.ShowingOverlayString = "P2RW4";
		}
	}

	public void P2LDClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects13.ShowingOverlayString = "P2LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects13.ShowingOverlayString = "P2LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects13.ShowingOverlayString = "P2LD3";
		}
	}

	public void P2RDClicking() {
		EnableObjects13.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects13.ShowingOverlayString = "P2RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects13.ShowingOverlayString = "P2RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects13.ShowingOverlayString = "P2RD3";
		}
	}

	public void P2GClicking() {
		EnableObjects13.ShowingOverlayInt = 1;
		EnableObjects13.ShowingOverlayString = "P2G";
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}