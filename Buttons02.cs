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

public class Buttons02 : MonoBehaviour {

// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button PVCButton;
	public Button PVCFranchiseButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene03LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// PVCButton
		Button PVCButtonClick = PVCButton.GetComponent<Button>();
		PVCButtonClick.onClick.AddListener(PVCButtonClicking);

		// PVCFranchiseButton
		Button PVCFranchiseButtonClick = PVCFranchiseButton.GetComponent<Button>();
		PVCFranchiseButtonClick.onClick.AddListener(PVCFranchiseButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	public void PVCButtonClicking() {
		PlayerDatabase.CurrentFranchiseSelect = 1;
		Scene03LoadRun.Scene03Load();
	}

	public void PVCFranchiseButtonClicking() {
		PlayerDatabase.CurrentFranchiseSelect = 2;
		Scene03LoadRun.Scene03Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}