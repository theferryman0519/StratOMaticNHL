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

public class Buttons12 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button ShotButton;
	public Button PlayerFlipButton;
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
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Gameplay
	public GameplayInsideShot RunGameplayInsideShotRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// ShotButton
		Button ShotButtonClick = ShotButton.GetComponent<Button>();
		ShotButtonClick.onClick.AddListener(ShotButtonClicking);

		// PlayerFlipButton
		Button PlayerFlipButtonClick = PlayerFlipButton.GetComponent<Button>();
		PlayerFlipButtonClick.onClick.AddListener(PlayerFlipButtonClicking);

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
	public void ShotButtonClicking() {
		RunGameplayInsideShotRun.RunGameplayInsideShot();
	}

	public void PlayerFlipButtonClicking() {
		if (EnableObjects12.FlippingPlayerData == 0) {
			EnableObjects12.FlippingPlayerData = 1;
		}

		else if (EnableObjects12.FlippingPlayerData == 1) {
			EnableObjects12.FlippingPlayerData = 0;
		}
	}

	public void PlayerBackButtonClicking() {
		EnableObjects12.ShowingOverlayInt = 0;
	}

	public void P1CClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects12.ShowingOverlayString = "P1C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects12.ShowingOverlayString = "P1C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects12.ShowingOverlayString = "P1C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects12.ShowingOverlayString = "P1C4";
		}
	}

	public void P1LWClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects12.ShowingOverlayString = "P1LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects12.ShowingOverlayString = "P1LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects12.ShowingOverlayString = "P1LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects12.ShowingOverlayString = "P1LW4";
		}
	}

	public void P1RWClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects12.ShowingOverlayString = "P1RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects12.ShowingOverlayString = "P1RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects12.ShowingOverlayString = "P1RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects12.ShowingOverlayString = "P1RW4";
		}
	}

	public void P1LDClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects12.ShowingOverlayString = "P1LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects12.ShowingOverlayString = "P1LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects12.ShowingOverlayString = "P1LD3";
		}
	}

	public void P1RDClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects12.ShowingOverlayString = "P1RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects12.ShowingOverlayString = "P1RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects12.ShowingOverlayString = "P1RD3";
		}
	}

	public void P1GClicking() {
		EnableObjects12.ShowingOverlayInt = 1;
		EnableObjects12.ShowingOverlayString = "P1G";
	}

	public void P2CClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects12.ShowingOverlayString = "P2C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects12.ShowingOverlayString = "P2C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects12.ShowingOverlayString = "P2C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects12.ShowingOverlayString = "P2C4";
		}
	}

	public void P2LWClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects12.ShowingOverlayString = "P2LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects12.ShowingOverlayString = "P2LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects12.ShowingOverlayString = "P2LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects12.ShowingOverlayString = "P2LW4";
		}
	}

	public void P2RWClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects12.ShowingOverlayString = "P2RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects12.ShowingOverlayString = "P2RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects12.ShowingOverlayString = "P2RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects12.ShowingOverlayString = "P2RW4";
		}
	}

	public void P2LDClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects12.ShowingOverlayString = "P2LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects12.ShowingOverlayString = "P2LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects12.ShowingOverlayString = "P2LD3";
		}
	}

	public void P2RDClicking() {
		EnableObjects12.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects12.ShowingOverlayString = "P2RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects12.ShowingOverlayString = "P2RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects12.ShowingOverlayString = "P2RD3";
		}
	}

	public void P2GClicking() {
		EnableObjects12.ShowingOverlayInt = 1;
		EnableObjects12.ShowingOverlayString = "P2G";
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}