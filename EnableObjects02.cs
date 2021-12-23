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

public class EnableObjects02 : MonoBehaviour {

// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image BackgroundImage;
	public Image MiniLogo;
	public Text PlayInfoText;
	public Image PVCButton;
	public Image PVCFranchiseButton;
	public Text VersionText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMain();
		PlayerDatabase.CurrentFranchiseSelect = 0;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		VersionText.text = "Version: 1.0";
		PlayInfoText.text = "Welcome, " + PlayerDatabase.PlayerFirstName + "\n" + "Vs. Computer: " + PlayerDatabase.PlayerComputerWins + " - " + PlayerDatabase.PlayerComputerLosses + " - " + PlayerDatabase.PlayerComputerOvertimes + "\n" + "Vs. Franchise CPU: " + PlayerDatabase.PlayerFranchiseWins + " - " + PlayerDatabase.PlayerFranchiseLosses + " - " + PlayerDatabase.PlayerFranchiseOvertimes;
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE OBJECT FUNCTIONS ---------------
	public void EnableMain() {
		BackgroundImage.enabled = true;
		MiniLogo.enabled = true;
		PlayInfoText.enabled = true;
		PVCButton.enabled = true;
		PVCFranchiseButton.enabled = true;
		VersionText.enabled = true;
	}

// --------------- DISABLE OBJECT FUNCTIONS ---------------
    public void DisableMain() {
		BackgroundImage.enabled = false;
		MiniLogo.enabled = false;
		PlayInfoText.enabled = false;
		PVCButton.enabled = false;
		PVCFranchiseButton.enabled = false;
		VersionText.enabled = false;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}