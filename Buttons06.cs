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

public class Buttons06 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button FaceoffButton;
	public Button PlayerBackButton;

	// Player Buttons
	public Button P1C;
	public Button P2C;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Gameplay
	public GameplayFaceoff RunGameplayFaceoffRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// FaceoffButton
		Button FaceoffButtonClick = FaceoffButton.GetComponent<Button>();
		FaceoffButtonClick.onClick.AddListener(FaceoffButtonClicking);

		// PlayerBackButton
		Button PlayerBackButtonClick = PlayerBackButton.GetComponent<Button>();
		PlayerBackButtonClick.onClick.AddListener(PlayerBackButtonClicking);

		// P1C
		Button P1CClick = P1C.GetComponent<Button>();
		P1CClick.onClick.AddListener(P1CClicking);

		// P2C
		Button P2CClick = P2C.GetComponent<Button>();
		P2CClick.onClick.AddListener(P2CClicking);
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
	public void FaceoffButtonClicking() {
		RunGameplayFaceoffRun.RunGameplayFaceoff();
	}

	public void PlayerBackButtonClicking() {
		EnableObjects06.ShowingOverlayInt = 0;
	}

	public void P1CClicking() {
		EnableObjects06.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects06.ShowingOverlayString = "P1C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects06.ShowingOverlayString = "P1C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects06.ShowingOverlayString = "P1C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects06.ShowingOverlayString = "P1C4";
		}
	}

	public void P2CClicking() {
		EnableObjects06.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects06.ShowingOverlayString = "P2C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects06.ShowingOverlayString = "P2C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects06.ShowingOverlayString = "P2C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects06.ShowingOverlayString = "P2C4";
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}