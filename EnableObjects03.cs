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

public class EnableObjects03 : MonoBehaviour {

// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main
	public Image BackgroundImage;
	public Image MiniLogo;
	public Text FirstName;
	public Text TeamSelect;
	public Image SelectTeamButton;
	public Image RandomizeTeamButton;
	public Image ReselectTeamButton;
	public Image ContinueButton;
	public Text SelectedTeamText;

	// Select Team
	public Image SelectTeamBackground;
	public Text SelectTeamTitle;
	public Image SelectANA;
	public Image SelectARI;
	public Image SelectBOS;
	public Image SelectBUF;
	public Image SelectCAL;
	public Image SelectCAR;
	public Image SelectCHI;
	public Image SelectCOL;
	public Image SelectCBJ;
	public Image SelectDAL;
	public Image SelectDET;
	public Image SelectEDM;
	public Image SelectFLA;
	public Image SelectLAK;
	public Image SelectMIN;
	public Image SelectMON;
	public Image SelectNAS;
	public Image SelectNJD;
	public Image SelectNYI;
	public Image SelectNYR;
	public Image SelectOTT;
	public Image SelectPHI;
	public Image SelectPIT;
	public Image SelectSTL;
	public Image SelectSJS;
	public Image SelectSEA;
	public Image SelectTBL;
	public Image SelectTOR;
	public Image SelectVAN;
	public Image SelectVGK;
	public Image SelectWAS;
	public Image SelectWPG;

	// Select Franchise Team
	public Image SelectFrTeamBackground;
	public Text SelectFrTeamTitle;
	public Image SelectFrANA;
	public Image SelectFrATL;
	public Image SelectFrBOS;
	public Image SelectFrBUF;
	public Image SelectFrCAL;
	public Image SelectFrCAR;
	public Image SelectFrCHI;
	public Image SelectFrCOL;
	public Image SelectFrCBJ;
	public Image SelectFrDAL;
	public Image SelectFrDET;
	public Image SelectFrEDM;
	public Image SelectFrFLA;
	public Image SelectFrHAR;
	public Image SelectFrLAK;
	public Image SelectFrMNS;
	public Image SelectFrMNW;
	public Image SelectFrMON;
	public Image SelectFrNAS;
	public Image SelectFrNJD;
	public Image SelectFrNYI;
	public Image SelectFrNYR;
	public Image SelectFrOTT;
	public Image SelectFrPHI;
	public Image SelectFrPHO;
	public Image SelectFrPIT;
	public Image SelectFrQUE;
	public Image SelectFrSTL;
	public Image SelectFrSJS;
	public Image SelectFrTBL;
	public Image SelectFrTOR;
	public Image SelectFrVAN;
	public Image SelectFrWAS;
	public Image SelectFrWPG;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ShowingSelectTeam;
	public static int ShowingSelectFrTeam;
	public static int ShowingTeamChosen;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMain();
		ShowingSelectTeam = 0;
		ShowingSelectFrTeam = 0;
		ShowingTeamChosen = 0;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			ShowingSelectFrTeam = 0;
			DisableSelectFrTeam();

			// Show Select Team
			if (ShowingSelectTeam == 0) {
				DisableSelectTeam();
			}

			else if (ShowingSelectTeam == 1) {
				EnableSelectTeam();
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			ShowingSelectTeam = 0;
			DisableSelectTeam();

			// Show Select Franchise Team
			if (ShowingSelectFrTeam == 0) {
				DisableSelectFrTeam();
			}

			else if (ShowingSelectFrTeam == 1) {
				EnableSelectFrTeam();
			}
		}

		// Show Team Chosen
		if (ShowingTeamChosen == 0) {
			EnableButtons();
			DisableSelectedText();
		}

		else if (ShowingTeamChosen == 1) {
			DisableButtons();
			EnableSelectedText();
		}

		FirstName.text = PlayerDatabase.PlayerFirstName + ", please select your team.";
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE OBJECT FUNCTIONS ---------------
	public void EnableMain() {
		BackgroundImage.enabled = true;
		MiniLogo.enabled = true;
		FirstName.enabled = true;
		TeamSelect.enabled = true;
		ContinueButton.enabled = true;
	}

	public void EnableButtons() {
		RandomizeTeamButton.enabled = true;
		SelectTeamButton.enabled = true;
	}

	public void EnableSelectedText() {
		ReselectTeamButton.enabled = true;
		SelectedTeamText.enabled = true;
	}

	public void EnableSelectTeam() {
		SelectTeamBackground.enabled = true;
		SelectTeamTitle.enabled = true;
		SelectANA.enabled = true;
		SelectARI.enabled = true;
		SelectBOS.enabled = true;
		SelectBUF.enabled = true;
		SelectCAL.enabled = true;
		SelectCAR.enabled = true;
		SelectCHI.enabled = true;
		SelectCOL.enabled = true;
		SelectCBJ.enabled = true;
		SelectDAL.enabled = true;
		SelectDET.enabled = true;
		SelectEDM.enabled = true;
		SelectFLA.enabled = true;
		SelectLAK.enabled = true;
		SelectMIN.enabled = true;
		SelectMON.enabled = true;
		SelectNAS.enabled = true;
		SelectNJD.enabled = true;
		SelectNYI.enabled = true;
		SelectNYR.enabled = true;
		SelectOTT.enabled = true;
		SelectPHI.enabled = true;
		SelectPIT.enabled = true;
		SelectSTL.enabled = true;
		SelectSJS.enabled = true;
		SelectSEA.enabled = true;
		SelectTBL.enabled = true;
		SelectTOR.enabled = true;
		SelectVAN.enabled = true;
		SelectVGK.enabled = true;
		SelectWAS.enabled = true;
		SelectWPG.enabled = true;
	}

	public void EnableSelectFrTeam() {
		SelectFrTeamBackground.enabled = true;
		SelectFrTeamTitle.enabled = true;
		SelectFrANA.enabled = true;
		SelectFrATL.enabled = true;
		SelectFrBOS.enabled = true;
		SelectFrBUF.enabled = true;
		SelectFrCAL.enabled = true;
		SelectFrCAR.enabled = true;
		SelectFrCHI.enabled = true;
		SelectFrCOL.enabled = true;
		SelectFrCBJ.enabled = true;
		SelectFrDAL.enabled = true;
		SelectFrDET.enabled = true;
		SelectFrEDM.enabled = true;
		SelectFrFLA.enabled = true;
		SelectFrHAR.enabled = true;
		SelectFrLAK.enabled = true;
		SelectFrMNS.enabled = true;
		SelectFrMNW.enabled = true;
		SelectFrMON.enabled = true;
		SelectFrNAS.enabled = true;
		SelectFrNJD.enabled = true;
		SelectFrNYI.enabled = true;
		SelectFrNYR.enabled = true;
		SelectFrOTT.enabled = true;
		SelectFrPHI.enabled = true;
		SelectFrPHO.enabled = true;
		SelectFrPIT.enabled = true;
		SelectFrQUE.enabled = true;
		SelectFrSTL.enabled = true;
		SelectFrSJS.enabled = true;
		SelectFrTBL.enabled = true;
		SelectFrTOR.enabled = true;
		SelectFrVAN.enabled = true;
		SelectFrWAS.enabled = true;
		SelectFrWPG.enabled = true;
	}

// --------------- DISABLE OBJECT FUNCTIONS ---------------
    public void DisableMain() {
		BackgroundImage.enabled = false;
		MiniLogo.enabled = false;
		FirstName.enabled = false;
		TeamSelect.enabled = false;
		ContinueButton.enabled = false;
	}

	public void DisableButtons() {
		RandomizeTeamButton.enabled = false;
		SelectTeamButton.enabled = false;
	}

	public void DisableSelectedText() {
		ReselectTeamButton.enabled = false;
		SelectedTeamText.enabled = false;
	}

	public void DisableSelectTeam() {
		SelectTeamBackground.enabled = false;
		SelectTeamTitle.enabled = false;
		SelectANA.enabled = false;
		SelectARI.enabled = false;
		SelectBOS.enabled = false;
		SelectBUF.enabled = false;
		SelectCAL.enabled = false;
		SelectCAR.enabled = false;
		SelectCHI.enabled = false;
		SelectCOL.enabled = false;
		SelectCBJ.enabled = false;
		SelectDAL.enabled = false;
		SelectDET.enabled = false;
		SelectEDM.enabled = false;
		SelectFLA.enabled = false;
		SelectLAK.enabled = false;
		SelectMIN.enabled = false;
		SelectMON.enabled = false;
		SelectNAS.enabled = false;
		SelectNJD.enabled = false;
		SelectNYI.enabled = false;
		SelectNYR.enabled = false;
		SelectOTT.enabled = false;
		SelectPHI.enabled = false;
		SelectPIT.enabled = false;
		SelectSTL.enabled = false;
		SelectSJS.enabled = false;
		SelectSEA.enabled = false;
		SelectTBL.enabled = false;
		SelectTOR.enabled = false;
		SelectVAN.enabled = false;
		SelectVGK.enabled = false;
		SelectWAS.enabled = false;
		SelectWPG.enabled = false;
	}

	public void DisableSelectFrTeam() {
		SelectFrTeamBackground.enabled = false;
		SelectFrTeamTitle.enabled = false;
		SelectFrANA.enabled = false;
		SelectFrATL.enabled = false;
		SelectFrBOS.enabled = false;
		SelectFrBUF.enabled = false;
		SelectFrCAL.enabled = false;
		SelectFrCAR.enabled = false;
		SelectFrCHI.enabled = false;
		SelectFrCOL.enabled = false;
		SelectFrCBJ.enabled = false;
		SelectFrDAL.enabled = false;
		SelectFrDET.enabled = false;
		SelectFrEDM.enabled = false;
		SelectFrFLA.enabled = false;
		SelectFrHAR.enabled = false;
		SelectFrLAK.enabled = false;
		SelectFrMNS.enabled = false;
		SelectFrMNW.enabled = false;
		SelectFrMON.enabled = false;
		SelectFrNAS.enabled = false;
		SelectFrNJD.enabled = false;
		SelectFrNYI.enabled = false;
		SelectFrNYR.enabled = false;
		SelectFrOTT.enabled = false;
		SelectFrPHI.enabled = false;
		SelectFrPHO.enabled = false;
		SelectFrPIT.enabled = false;
		SelectFrQUE.enabled = false;
		SelectFrSTL.enabled = false;
		SelectFrSJS.enabled = false;
		SelectFrTBL.enabled = false;
		SelectFrTOR.enabled = false;
		SelectFrVAN.enabled = false;
		SelectFrWAS.enabled = false;
		SelectFrWPG.enabled = false;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}