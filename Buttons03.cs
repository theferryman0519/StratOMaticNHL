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

public class Buttons03 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button SelectTeamButton;
	public Button RandomizeTeamButton;
	public Button ReselectTeamButton;
	public Button ContinueButton;

	// Select Team Buttons
	public Button SelectANA;
	public Button SelectARI;
	public Button SelectBOS;
	public Button SelectBUF;
	public Button SelectCAL;
	public Button SelectCAR;
	public Button SelectCHI;
	public Button SelectCOL;
	public Button SelectCBJ;
	public Button SelectDAL;
	public Button SelectDET;
	public Button SelectEDM;
	public Button SelectFLA;
	public Button SelectLAK;
	public Button SelectMIN;
	public Button SelectMON;
	public Button SelectNAS;
	public Button SelectNJD;
	public Button SelectNYI;
	public Button SelectNYR;
	public Button SelectOTT;
	public Button SelectPHI;
	public Button SelectPIT;
	public Button SelectSTL;
	public Button SelectSJS;
	public Button SelectSEA;
	public Button SelectTBL;
	public Button SelectTOR;
	public Button SelectVAN;
	public Button SelectVGK;
	public Button SelectWAS;
	public Button SelectWPG;

	// Select Franchise Buttons
	public Button SelectFrANA;
	public Button SelectFrATL;
	public Button SelectFrBOS;
	public Button SelectFrBUF;
	public Button SelectFrCAL;
	public Button SelectFrCAR;
	public Button SelectFrCHI;
	public Button SelectFrCOL;
	public Button SelectFrCBJ;
	public Button SelectFrDAL;
	public Button SelectFrDET;
	public Button SelectFrEDM;
	public Button SelectFrFLA;
	public Button SelectFrHAR;
	public Button SelectFrLAK;
	public Button SelectFrMNS;
	public Button SelectFrMNW;
	public Button SelectFrMON;
	public Button SelectFrNAS;
	public Button SelectFrNJD;
	public Button SelectFrNYI;
	public Button SelectFrNYR;
	public Button SelectFrOTT;
	public Button SelectFrPHI;
	public Button SelectFrPHO;
	public Button SelectFrPIT;
	public Button SelectFrQUE;
	public Button SelectFrSTL;
	public Button SelectFrSJS;
	public Button SelectFrTBL;
	public Button SelectFrTOR;
	public Button SelectFrVAN;
	public Button SelectFrWAS;
	public Button SelectFrWPG;

	// Texts
	public Text SelectedTeamText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int SelectRandomTeamInt;
	public static int RandomComputerTeamInt;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene03LoadRun;
	public SceneChange Scene04LoadRun;
	public SceneChange Scene05LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// SelectTeamButton
		Button SelectTeamButtonClick = SelectTeamButton.GetComponent<Button>();
		SelectTeamButtonClick.onClick.AddListener(SelectTeamButtonClicking);

		// RandomizeTeamButton
		Button RandomizeTeamButtonClick = RandomizeTeamButton.GetComponent<Button>();
		RandomizeTeamButtonClick.onClick.AddListener(RandomizeTeamButtonClicking);

		// ReselectTeamButton
		Button ReselectTeamButtonClick = ReselectTeamButton.GetComponent<Button>();
		ReselectTeamButtonClick.onClick.AddListener(ReselectTeamButtonClicking);

		// ContinueButton
		Button ContinueButtonClick = ContinueButton.GetComponent<Button>();
		ContinueButtonClick.onClick.AddListener(ContinueButtonClicking);

		// Select Teams
		Button SelectANAClick = SelectANA.GetComponent<Button>();
		Button SelectARIClick = SelectARI.GetComponent<Button>();
		Button SelectBOSClick = SelectBOS.GetComponent<Button>();
		Button SelectBUFClick = SelectBUF.GetComponent<Button>();
		Button SelectCALClick = SelectCAL.GetComponent<Button>();
		Button SelectCARClick = SelectCAR.GetComponent<Button>();
		Button SelectCHIClick = SelectCHI.GetComponent<Button>();
		Button SelectCOLClick = SelectCOL.GetComponent<Button>();
		Button SelectCBJClick = SelectCBJ.GetComponent<Button>();
		Button SelectDALClick = SelectDAL.GetComponent<Button>();
		Button SelectDETClick = SelectDET.GetComponent<Button>();
		Button SelectEDMClick = SelectEDM.GetComponent<Button>();
		Button SelectFLAClick = SelectFLA.GetComponent<Button>();
		Button SelectLAKClick = SelectLAK.GetComponent<Button>();
		Button SelectMINClick = SelectMIN.GetComponent<Button>();
		Button SelectMONClick = SelectMON.GetComponent<Button>();
		Button SelectNASClick = SelectNAS.GetComponent<Button>();
		Button SelectNJDClick = SelectNJD.GetComponent<Button>();
		Button SelectNYIClick = SelectNYI.GetComponent<Button>();
		Button SelectNYRClick = SelectNYR.GetComponent<Button>();
		Button SelectOTTClick = SelectOTT.GetComponent<Button>();
		Button SelectPHIClick = SelectPHI.GetComponent<Button>();
		Button SelectPITClick = SelectPIT.GetComponent<Button>();
		Button SelectSTLClick = SelectSTL.GetComponent<Button>();
		Button SelectSJSClick = SelectSJS.GetComponent<Button>();
		Button SelectSEAClick = SelectSEA.GetComponent<Button>();
		Button SelectTBLClick = SelectTBL.GetComponent<Button>();
		Button SelectTORClick = SelectTOR.GetComponent<Button>();
		Button SelectVANClick = SelectVAN.GetComponent<Button>();
		Button SelectVGKClick = SelectVGK.GetComponent<Button>();
		Button SelectWASClick = SelectWAS.GetComponent<Button>();
		Button SelectWPGClick = SelectWPG.GetComponent<Button>();

		SelectANAClick.onClick.AddListener(SelectANAClicking);
		SelectARIClick.onClick.AddListener(SelectARIClicking);
		SelectBOSClick.onClick.AddListener(SelectBOSClicking);
		SelectBUFClick.onClick.AddListener(SelectBUFClicking);
		SelectCALClick.onClick.AddListener(SelectCALClicking);
		SelectCARClick.onClick.AddListener(SelectCARClicking);
		SelectCHIClick.onClick.AddListener(SelectCHIClicking);
		SelectCOLClick.onClick.AddListener(SelectCOLClicking);
		SelectCBJClick.onClick.AddListener(SelectCBJClicking);
		SelectDALClick.onClick.AddListener(SelectDALClicking);
		SelectDETClick.onClick.AddListener(SelectDETClicking);
		SelectEDMClick.onClick.AddListener(SelectEDMClicking);
		SelectFLAClick.onClick.AddListener(SelectFLAClicking);
		SelectLAKClick.onClick.AddListener(SelectLAKClicking);
		SelectMINClick.onClick.AddListener(SelectMINClicking);
		SelectMONClick.onClick.AddListener(SelectMONClicking);
		SelectNASClick.onClick.AddListener(SelectNASClicking);
		SelectNJDClick.onClick.AddListener(SelectNJDClicking);
		SelectNYIClick.onClick.AddListener(SelectNYIClicking);
		SelectNYRClick.onClick.AddListener(SelectNYRClicking);
		SelectOTTClick.onClick.AddListener(SelectOTTClicking);
		SelectPHIClick.onClick.AddListener(SelectPHIClicking);
		SelectPITClick.onClick.AddListener(SelectPITClicking);
		SelectSTLClick.onClick.AddListener(SelectSTLClicking);
		SelectSJSClick.onClick.AddListener(SelectSJSClicking);
		SelectSEAClick.onClick.AddListener(SelectSEAClicking);
		SelectTBLClick.onClick.AddListener(SelectTBLClicking);
		SelectTORClick.onClick.AddListener(SelectTORClicking);
		SelectVANClick.onClick.AddListener(SelectVANClicking);
		SelectVGKClick.onClick.AddListener(SelectVGKClicking);
		SelectWASClick.onClick.AddListener(SelectWASClicking);
		SelectWPGClick.onClick.AddListener(SelectWPGClicking);

		// Select Franchise Teams
		Button SelectFrANAClick = SelectFrANA.GetComponent<Button>();
		Button SelectFrATLClick = SelectFrATL.GetComponent<Button>();
		Button SelectFrBOSClick = SelectFrBOS.GetComponent<Button>();
		Button SelectFrBUFClick = SelectFrBUF.GetComponent<Button>();
		Button SelectFrCALClick = SelectFrCAL.GetComponent<Button>();
		Button SelectFrCARClick = SelectFrCAR.GetComponent<Button>();
		Button SelectFrCHIClick = SelectFrCHI.GetComponent<Button>();
		Button SelectFrCOLClick = SelectFrCOL.GetComponent<Button>();
		Button SelectFrCBJClick = SelectFrCBJ.GetComponent<Button>();
		Button SelectFrDALClick = SelectFrDAL.GetComponent<Button>();
		Button SelectFrDETClick = SelectFrDET.GetComponent<Button>();
		Button SelectFrEDMClick = SelectFrEDM.GetComponent<Button>();
		Button SelectFrFLAClick = SelectFrFLA.GetComponent<Button>();
		Button SelectFrHARClick = SelectFrHAR.GetComponent<Button>();
		Button SelectFrLAKClick = SelectFrLAK.GetComponent<Button>();
		Button SelectFrMNSClick = SelectFrMNS.GetComponent<Button>();
		Button SelectFrMNWClick = SelectFrMNW.GetComponent<Button>();
		Button SelectFrMONClick = SelectFrMON.GetComponent<Button>();
		Button SelectFrNASClick = SelectFrNAS.GetComponent<Button>();
		Button SelectFrNJDClick = SelectFrNJD.GetComponent<Button>();
		Button SelectFrNYIClick = SelectFrNYI.GetComponent<Button>();
		Button SelectFrNYRClick = SelectFrNYR.GetComponent<Button>();
		Button SelectFrOTTClick = SelectFrOTT.GetComponent<Button>();
		Button SelectFrPHIClick = SelectFrPHI.GetComponent<Button>();
		Button SelectFrPHOClick = SelectFrPHO.GetComponent<Button>();
		Button SelectFrPITClick = SelectFrPIT.GetComponent<Button>();
		Button SelectFrQUEClick = SelectFrQUE.GetComponent<Button>();
		Button SelectFrSTLClick = SelectFrSTL.GetComponent<Button>();
		Button SelectFrSJSClick = SelectFrSJS.GetComponent<Button>();
		Button SelectFrTBLClick = SelectFrTBL.GetComponent<Button>();
		Button SelectFrTORClick = SelectFrTOR.GetComponent<Button>();
		Button SelectFrVANClick = SelectFrVAN.GetComponent<Button>();
		Button SelectFrWASClick = SelectFrWAS.GetComponent<Button>();
		Button SelectFrWPGClick = SelectFrWPG.GetComponent<Button>();

		SelectFrANAClick.onClick.AddListener(SelectFrANAClicking);
		SelectFrATLClick.onClick.AddListener(SelectFrATLClicking);
		SelectFrBOSClick.onClick.AddListener(SelectFrBOSClicking);
		SelectFrBUFClick.onClick.AddListener(SelectFrBUFClicking);
		SelectFrCALClick.onClick.AddListener(SelectFrCALClicking);
		SelectFrCARClick.onClick.AddListener(SelectFrCARClicking);
		SelectFrCHIClick.onClick.AddListener(SelectFrCHIClicking);
		SelectFrCOLClick.onClick.AddListener(SelectFrCOLClicking);
		SelectFrCBJClick.onClick.AddListener(SelectFrCBJClicking);
		SelectFrDALClick.onClick.AddListener(SelectFrDALClicking);
		SelectFrDETClick.onClick.AddListener(SelectFrDETClicking);
		SelectFrEDMClick.onClick.AddListener(SelectFrEDMClicking);
		SelectFrFLAClick.onClick.AddListener(SelectFrFLAClicking);
		SelectFrHARClick.onClick.AddListener(SelectFrHARClicking);
		SelectFrLAKClick.onClick.AddListener(SelectFrLAKClicking);
		SelectFrMNSClick.onClick.AddListener(SelectFrMNSClicking);
		SelectFrMNWClick.onClick.AddListener(SelectFrMNWClicking);
		SelectFrMONClick.onClick.AddListener(SelectFrMONClicking);
		SelectFrNASClick.onClick.AddListener(SelectFrNASClicking);
		SelectFrNJDClick.onClick.AddListener(SelectFrNJDClicking);
		SelectFrNYIClick.onClick.AddListener(SelectFrNYIClicking);
		SelectFrNYRClick.onClick.AddListener(SelectFrNYRClicking);
		SelectFrOTTClick.onClick.AddListener(SelectFrOTTClicking);
		SelectFrPHIClick.onClick.AddListener(SelectFrPHIClicking);
		SelectFrPHOClick.onClick.AddListener(SelectFrPHOClicking);
		SelectFrPITClick.onClick.AddListener(SelectFrPITClicking);
		SelectFrQUEClick.onClick.AddListener(SelectFrQUEClicking);
		SelectFrSTLClick.onClick.AddListener(SelectFrSTLClicking);
		SelectFrSJSClick.onClick.AddListener(SelectFrSJSClicking);
		SelectFrTBLClick.onClick.AddListener(SelectFrTBLClicking);
		SelectFrTORClick.onClick.AddListener(SelectFrTORClicking);
		SelectFrVANClick.onClick.AddListener(SelectFrVANClicking);
		SelectFrWASClick.onClick.AddListener(SelectFrWASClicking);
		SelectFrWPGClick.onClick.AddListener(SelectFrWPGClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			// Show Team Selected Text
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				SelectedTeamText.text = "You have selected the Anaheim Ducks as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ARI") {
				SelectedTeamText.text = "You have selected the Arizona Coyotes as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				SelectedTeamText.text = "You have selected the Boston Bruins as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				SelectedTeamText.text = "You have selected the Buffalo Sabres as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				SelectedTeamText.text = "You have selected the Calgary Flames as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				SelectedTeamText.text = "You have selected the Carolina Hurricanes as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				SelectedTeamText.text = "You have selected the Chicago Blackhawks as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				SelectedTeamText.text = "You have selected the Colorado Avalanche as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				SelectedTeamText.text = "You have selected the Columbus Blue Jackets as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				SelectedTeamText.text = "You have selected the Dallas Stars as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				SelectedTeamText.text = "You have selected the Detroit Red Wings as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				SelectedTeamText.text = "You have selected the Edmonton Oilers as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				SelectedTeamText.text = "You have selected the Florida Panthers as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				SelectedTeamText.text = "You have selected the Los Angeles Kings as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MIN") {
				SelectedTeamText.text = "You have selected the Minnesota Wild as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				SelectedTeamText.text = "You have selected the Montreal Canadiens as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				SelectedTeamText.text = "You have selected the Nashville Predators as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				SelectedTeamText.text = "You have selected the New Jersey Devils as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				SelectedTeamText.text = "You have selected the New York Islanders as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				SelectedTeamText.text = "You have selected the New York Rangers as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				SelectedTeamText.text = "You have selected the Ottawa Senators as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				SelectedTeamText.text = "You have selected the Philadelphia Flyers as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				SelectedTeamText.text = "You have selected the Pittsburgh Penguins as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				SelectedTeamText.text = "You have selected the St Louis Blues as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				SelectedTeamText.text = "You have selected the San Jose Sharks as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SEA") {
				SelectedTeamText.text = "You have selected the Seattle Kraken as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				SelectedTeamText.text = "You have selected the Tampa Bay Lightning as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				SelectedTeamText.text = "You have selected the Toronto Maple Leafs as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				SelectedTeamText.text = "You have selected the Vancouver Canucks as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VGK") {
				SelectedTeamText.text = "You have selected the Vegas Golden Knights as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				SelectedTeamText.text = "You have selected the Washington Capitals as your chosen team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				SelectedTeamText.text = "You have selected the Winnipeg Jets as your chosen team.";
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			// Show Franchise Team Selected Text
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				SelectedTeamText.text = "You have selected the Mighty Ducks of Anaheim as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ATL") {
				SelectedTeamText.text = "You have selected the Atlanta Thrashers as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				SelectedTeamText.text = "You have selected the Boston Bruins as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				SelectedTeamText.text = "You have selected the Buffalo Sabres as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				SelectedTeamText.text = "You have selected the Calgary Flames as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				SelectedTeamText.text = "You have selected the Carolina Hurricanes as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				SelectedTeamText.text = "You have selected the Chicago Blackhawks as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				SelectedTeamText.text = "You have selected the Colorado Avalanche as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				SelectedTeamText.text = "You have selected the Columbus Blue Jackets as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				SelectedTeamText.text = "You have selected the Dallas Stars as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				SelectedTeamText.text = "You have selected the Detroit Red Wings as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				SelectedTeamText.text = "You have selected the Edmonton Oilers as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				SelectedTeamText.text = "You have selected the Florida Panthers as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "HAR") {
				SelectedTeamText.text = "You have selected the Hartford Whalers as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				SelectedTeamText.text = "You have selected the Los Angeles Kings as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNS") {
				SelectedTeamText.text = "You have selected the Minnesota North Stars as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNW") {
				SelectedTeamText.text = "You have selected the Minnesota Wild as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				SelectedTeamText.text = "You have selected the Montreal Canadiens as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				SelectedTeamText.text = "You have selected the Nashville Predators as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				SelectedTeamText.text = "You have selected the New Jersey Devils as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				SelectedTeamText.text = "You have selected the New York Islanders as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				SelectedTeamText.text = "You have selected the New York Rangers as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				SelectedTeamText.text = "You have selected the Ottawa Senators as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				SelectedTeamText.text = "You have selected the Philadelphia Flyers as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHO") {
				SelectedTeamText.text = "You have selected the Phoenix Coyotes as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				SelectedTeamText.text = "You have selected the Pittsburgh Penguins as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "QUE") {
				SelectedTeamText.text = "You have selected the Quebec Nordiques as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				SelectedTeamText.text = "You have selected the St Louis Blues as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				SelectedTeamText.text = "You have selected the San Jose Sharks as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				SelectedTeamText.text = "You have selected the Tampa Bay Lightning as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				SelectedTeamText.text = "You have selected the Toronto Maple Leafs as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				SelectedTeamText.text = "You have selected the Vancouver Canucks as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				SelectedTeamText.text = "You have selected the Washington Capitals as your chosen franchise team.";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				SelectedTeamText.text = "You have selected the Winnipeg Jets as your chosen franchise team.";
			}
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void SelectTeamButtonClicking() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			EnableObjects03.ShowingSelectTeam = 1;
			EnableObjects03.ShowingSelectFrTeam = 0;
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			EnableObjects03.ShowingSelectFrTeam = 1;
			EnableObjects03.ShowingSelectTeam = 0;
		}
	}

	public void RandomizeTeamButtonClicking() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			SelectRandomTeamInt = Random.Range(1,33);

			if (SelectRandomTeamInt == 1) {
				PlayerDatabase.PlayerChosenTeam = "ANA";
			}

			else if (SelectRandomTeamInt == 2) {
				PlayerDatabase.PlayerChosenTeam = "ARI";
			}

			else if (SelectRandomTeamInt == 3) {
				PlayerDatabase.PlayerChosenTeam = "BOS";
			}

			else if (SelectRandomTeamInt == 4) {
				PlayerDatabase.PlayerChosenTeam = "BUF";
			}

			else if (SelectRandomTeamInt == 5) {
				PlayerDatabase.PlayerChosenTeam = "CAL";
			}

			else if (SelectRandomTeamInt == 6) {
				PlayerDatabase.PlayerChosenTeam = "CAR";
			}

			else if (SelectRandomTeamInt == 7) {
				PlayerDatabase.PlayerChosenTeam = "CHI";
			}

			else if (SelectRandomTeamInt == 8) {
				PlayerDatabase.PlayerChosenTeam = "COL";
			}

			else if (SelectRandomTeamInt == 9) {
				PlayerDatabase.PlayerChosenTeam = "CBJ";
			}

			else if (SelectRandomTeamInt == 10) {
				PlayerDatabase.PlayerChosenTeam = "DAL";
			}

			else if (SelectRandomTeamInt == 11) {
				PlayerDatabase.PlayerChosenTeam = "DET";
			}

			else if (SelectRandomTeamInt == 12) {
				PlayerDatabase.PlayerChosenTeam = "EDM";
			}

			else if (SelectRandomTeamInt == 13) {
				PlayerDatabase.PlayerChosenTeam = "FLA";
			}

			else if (SelectRandomTeamInt == 14) {
				PlayerDatabase.PlayerChosenTeam = "LAK";
			}

			else if (SelectRandomTeamInt == 15) {
				PlayerDatabase.PlayerChosenTeam = "MIN";
			}

			else if (SelectRandomTeamInt == 16) {
				PlayerDatabase.PlayerChosenTeam = "MON";
			}

			else if (SelectRandomTeamInt == 17) {
				PlayerDatabase.PlayerChosenTeam = "NAS";
			}

			else if (SelectRandomTeamInt == 18) {
				PlayerDatabase.PlayerChosenTeam = "NJD";
			}

			else if (SelectRandomTeamInt == 19) {
				PlayerDatabase.PlayerChosenTeam = "NYI";
			}

			else if (SelectRandomTeamInt == 20) {
				PlayerDatabase.PlayerChosenTeam = "NYR";
			}

			else if (SelectRandomTeamInt == 21) {
				PlayerDatabase.PlayerChosenTeam = "OTT";
			}

			else if (SelectRandomTeamInt == 22) {
				PlayerDatabase.PlayerChosenTeam = "PHI";
			}

			else if (SelectRandomTeamInt == 23) {
				PlayerDatabase.PlayerChosenTeam = "PIT";
			}

			else if (SelectRandomTeamInt == 24) {
				PlayerDatabase.PlayerChosenTeam = "STL";
			}

			else if (SelectRandomTeamInt == 25) {
				PlayerDatabase.PlayerChosenTeam = "SJS";
			}

			else if (SelectRandomTeamInt == 26) {
				PlayerDatabase.PlayerChosenTeam = "SEA";
			}

			else if (SelectRandomTeamInt == 27) {
				PlayerDatabase.PlayerChosenTeam = "TBL";
			}

			else if (SelectRandomTeamInt == 28) {
				PlayerDatabase.PlayerChosenTeam = "TOR";
			}

			else if (SelectRandomTeamInt == 29) {
				PlayerDatabase.PlayerChosenTeam = "VAN";
			}

			else if (SelectRandomTeamInt == 30) {
				PlayerDatabase.PlayerChosenTeam = "VGK";
			}

			else if (SelectRandomTeamInt == 31) {
				PlayerDatabase.PlayerChosenTeam = "WAS";
			}

			else if (SelectRandomTeamInt == 32) {
				PlayerDatabase.PlayerChosenTeam = "WPG";
			}

			EnableObjects03.ShowingTeamChosen = 1;
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			SelectRandomTeamInt = Random.Range(1,35);

			if (SelectRandomTeamInt == 1) {
				PlayerDatabase.PlayerChosenTeam = "ANA";
			}

			else if (SelectRandomTeamInt == 2) {
				PlayerDatabase.PlayerChosenTeam = "ATL";
			}

			else if (SelectRandomTeamInt == 3) {
				PlayerDatabase.PlayerChosenTeam = "BOS";
			}

			else if (SelectRandomTeamInt == 4) {
				PlayerDatabase.PlayerChosenTeam = "BUF";
			}

			else if (SelectRandomTeamInt == 5) {
				PlayerDatabase.PlayerChosenTeam = "CAL";
			}

			else if (SelectRandomTeamInt == 6) {
				PlayerDatabase.PlayerChosenTeam = "CAR";
			}

			else if (SelectRandomTeamInt == 7) {
				PlayerDatabase.PlayerChosenTeam = "CHI";
			}

			else if (SelectRandomTeamInt == 8) {
				PlayerDatabase.PlayerChosenTeam = "COL";
			}

			else if (SelectRandomTeamInt == 9) {
				PlayerDatabase.PlayerChosenTeam = "CBJ";
			}

			else if (SelectRandomTeamInt == 10) {
				PlayerDatabase.PlayerChosenTeam = "DAL";
			}

			else if (SelectRandomTeamInt == 11) {
				PlayerDatabase.PlayerChosenTeam = "DET";
			}

			else if (SelectRandomTeamInt == 12) {
				PlayerDatabase.PlayerChosenTeam = "EDM";
			}

			else if (SelectRandomTeamInt == 13) {
				PlayerDatabase.PlayerChosenTeam = "FLA";
			}

			else if (SelectRandomTeamInt == 14) {
				PlayerDatabase.PlayerChosenTeam = "HAR";
			}

			else if (SelectRandomTeamInt == 15) {
				PlayerDatabase.PlayerChosenTeam = "LAK";
			}

			else if (SelectRandomTeamInt == 16) {
				PlayerDatabase.PlayerChosenTeam = "MNS";
			}

			else if (SelectRandomTeamInt == 17) {
				PlayerDatabase.PlayerChosenTeam = "MNW";
			}

			else if (SelectRandomTeamInt == 18) {
				PlayerDatabase.PlayerChosenTeam = "MON";
			}

			else if (SelectRandomTeamInt == 19) {
				PlayerDatabase.PlayerChosenTeam = "NAS";
			}

			else if (SelectRandomTeamInt == 20) {
				PlayerDatabase.PlayerChosenTeam = "NJD";
			}

			else if (SelectRandomTeamInt == 21) {
				PlayerDatabase.PlayerChosenTeam = "NYI";
			}

			else if (SelectRandomTeamInt == 22) {
				PlayerDatabase.PlayerChosenTeam = "NYR";
			}

			else if (SelectRandomTeamInt == 23) {
				PlayerDatabase.PlayerChosenTeam = "OTT";
			}

			else if (SelectRandomTeamInt == 24) {
				PlayerDatabase.PlayerChosenTeam = "PHI";
			}

			else if (SelectRandomTeamInt == 25) {
				PlayerDatabase.PlayerChosenTeam = "PHO";
			}

			else if (SelectRandomTeamInt == 26) {
				PlayerDatabase.PlayerChosenTeam = "PIT";
			}

			else if (SelectRandomTeamInt == 27) {
				PlayerDatabase.PlayerChosenTeam = "QUE";
			}

			else if (SelectRandomTeamInt == 28) {
				PlayerDatabase.PlayerChosenTeam = "STL";
			}

			else if (SelectRandomTeamInt == 29) {
				PlayerDatabase.PlayerChosenTeam = "SJS";
			}

			else if (SelectRandomTeamInt == 30) {
				PlayerDatabase.PlayerChosenTeam = "TBL";
			}

			else if (SelectRandomTeamInt == 31) {
				PlayerDatabase.PlayerChosenTeam = "TOR";
			}

			else if (SelectRandomTeamInt == 32) {
				PlayerDatabase.PlayerChosenTeam = "VAN";
			}

			else if (SelectRandomTeamInt == 33) {
				PlayerDatabase.PlayerChosenTeam = "WAS";
			}

			else if (SelectRandomTeamInt == 34) {
				PlayerDatabase.PlayerChosenTeam = "WPG";
			}

			EnableObjects03.ShowingTeamChosen = 1;
		}
	}

	public void ReselectTeamButtonClicking() {
		PlayerDatabase.PlayerChosenTeam = "";
		EnableObjects03.ShowingTeamChosen = 0;
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingSelectFrTeam = 0;
		Scene03LoadRun.Scene03Load();
	}
	
	public void ContinueButtonClicking() {
		// SetPlayerChosenTeam();
		// Scene04LoadRun.Scene04Load();
		// EnableObjects03.ShowingTeamChosen = 0;
		// EnableObjects03.ShowingSelectTeam = 0;
		// EnableObjects03.ShowingSelectFrTeam = 0;

		// FOR NOW
		EnableObjects04.ShowingPlayerPositions = "None";
		EnableObjects04.ShowingPlayerInfoString = "None";
		EnableObjects04.ShowingPlayerInfoInt = 0;
		SetPlayerLines();
		SetComputerLines();
		Scene05LoadRun.Scene05Load();
	}

	public void SetPlayerLines() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
                PlayerDatabase.P1LW1 = "Frank Vatrano";
                PlayerDatabase.P1LW2 = "Jakob Silfverberg";
                PlayerDatabase.P1LW3 = "Maxime Comtois";
                PlayerDatabase.P1LW4 = "Sonny Milano";
                PlayerDatabase.P1C1 = "Trevor Zegras";
                PlayerDatabase.P1C2 = "Adam Henrique";
                PlayerDatabase.P1C3 = "Sam Carrick";
                PlayerDatabase.P1C4 = "Dominik Simon";
                PlayerDatabase.P1RW1 = "Ryan Strome";
                PlayerDatabase.P1RW2 = "Troy Terry";
                PlayerDatabase.P1RW3 = "Zach AstonReese";
                PlayerDatabase.P1RW4 = "Gerald Mayhew";
                PlayerDatabase.P1LD1 = "Kevin Shattenkirk";
                PlayerDatabase.P1LD2 = "Greg Pateryn";
                PlayerDatabase.P1LD3 = "Cam Fowler";
                PlayerDatabase.P1RD1 = "Brendan Guhle";
                PlayerDatabase.P1RD2 = "Josh Mahura";
                PlayerDatabase.P1RD3 = "Andrej Sustr";
                PlayerDatabase.P1G = "John Gibson";
                PlayerDatabase.P1PPLW = "Jakob Silfverberg";PlayerDatabase.P1PPC = "Trevor Zegras";PlayerDatabase.P1PPRW = "Ryan Strome";PlayerDatabase.P1PPLD = "Frank Vatrano";PlayerDatabase.P1PPRD = "Adam Henrique";PlayerDatabase.P1PKLW = "Ryan Strome";PlayerDatabase.P1PKRW = "Zach AstonReese";PlayerDatabase.P1PKLD = "Kevin Shattenkirk";PlayerDatabase.P1PKRD = "Brendan Guhle";PlayerDatabase.P1PKExW = "Frank Vatrano";PlayerDatabase.P1PKExD = "Greg Pateryn";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "ARI") {
                PlayerDatabase.P1LW1 = "Nick Ritchie";
                PlayerDatabase.P1LW2 = "Lawson Crouse";
                PlayerDatabase.P1LW3 = "Antoine Roussel";
                PlayerDatabase.P1LW4 = "Michael Carcone";
                PlayerDatabase.P1C1 = "Nick Bjugstad";
                PlayerDatabase.P1C2 = "Alex Galchenyuk";
                PlayerDatabase.P1C3 = "Barrett Hayton";
                PlayerDatabase.P1C4 = "Bryan Little";
                PlayerDatabase.P1RW1 = "Clayton Keller";
                PlayerDatabase.P1RW2 = "Phil Kessel";
                PlayerDatabase.P1RW3 = "Zack Kassian";
                PlayerDatabase.P1RW4 = "Nick Schmaltz";
                PlayerDatabase.P1LD1 = "Conor Timmins";
                PlayerDatabase.P1LD2 = "Troy Stecher";
                PlayerDatabase.P1LD3 = "Shayne Gostisbehere";
                PlayerDatabase.P1RD1 = "Anton Stralman";
                PlayerDatabase.P1RD2 = "Patrik Nemeth";
                PlayerDatabase.P1RD3 = "Jakob Chychrun";
                PlayerDatabase.P1G = "Harri Sateri";
                PlayerDatabase.P1PPLW = "Nick Ritchie";PlayerDatabase.P1PPC = "Nick Bjugstad";PlayerDatabase.P1PPRW = "Clayton Keller";PlayerDatabase.P1PPLD = "Jakob Chychrun";PlayerDatabase.P1PPRD = "Alex Galchenyuk";PlayerDatabase.P1PKLW = "Nick Ritchie";PlayerDatabase.P1PKRW = "Nick Bjugstad";PlayerDatabase.P1PKLD = "Conor Timmins";PlayerDatabase.P1PKRD = "Troy Stecher";PlayerDatabase.P1PKExW = "Lawson Crouse";PlayerDatabase.P1PKExD = "Anton Stralman";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
                PlayerDatabase.P1LW1 = "Brad Marchand";
                PlayerDatabase.P1LW2 = "Jake DeBrusk";
                PlayerDatabase.P1LW3 = "Taylor Hall";
                PlayerDatabase.P1LW4 = "Peter Cehlarik";
                PlayerDatabase.P1C1 = "Patrice Bergeron";
                PlayerDatabase.P1C2 = "Charlie Coyle";
                PlayerDatabase.P1C3 = "Pavel Zacha";
                PlayerDatabase.P1C4 = "Trent Frederic";
                PlayerDatabase.P1RW1 = "David Pastrnak";
                PlayerDatabase.P1RW2 = "Craig Smith";
                PlayerDatabase.P1RW3 = "Nick Foligno";
                PlayerDatabase.P1RW4 = "Oskar Steen";
                PlayerDatabase.P1LD1 = "Brandon Carlo";
                PlayerDatabase.P1LD2 = "Connor Clifton";
                PlayerDatabase.P1LD3 = "Mike Reilly";
                PlayerDatabase.P1RD1 = "Matt Grzelcyk";
                PlayerDatabase.P1RD2 = "Charlie McAvoy";
                PlayerDatabase.P1RD3 = "John Moore";
                PlayerDatabase.P1G = "Linus Ullmark";
                PlayerDatabase.P1PPLW = "Jake DeBrusk";PlayerDatabase.P1PPC = "Patrice Bergeron";PlayerDatabase.P1PPRW = "David Pastrnak";PlayerDatabase.P1PPLD = "Brad Marchand";PlayerDatabase.P1PPRD = "Craig Smith";PlayerDatabase.P1PKLW = "Brad Marchand";PlayerDatabase.P1PKRW = "Patrice Bergeron";PlayerDatabase.P1PKLD = "Brandon Carlo";PlayerDatabase.P1PKRD = "Matt Grzelcyk";PlayerDatabase.P1PKExW = "David Pastrnak";PlayerDatabase.P1PKExD = "Charlie McAvoy";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
                PlayerDatabase.P1LW1 = "Victor Olofsson";
                PlayerDatabase.P1LW2 = "Zemgus Girgensons";
                PlayerDatabase.P1LW3 = "Brett Murray";
                PlayerDatabase.P1LW4 = "Anders Bjork";
                PlayerDatabase.P1C1 = "Jeff Skinner";
                PlayerDatabase.P1C2 = "Vinnie Hinostroza";
                PlayerDatabase.P1C3 = "Dylan Cozens";
                PlayerDatabase.P1C4 = "Cody Eakin";
                PlayerDatabase.P1RW1 = "Alex Tuch";
                PlayerDatabase.P1RW2 = "Kyle Okposo";
                PlayerDatabase.P1RW3 = "Tage Thompson";
                PlayerDatabase.P1RW4 = "Rasmus Asplund";
                PlayerDatabase.P1LD1 = "Johnny Boychuk";
                PlayerDatabase.P1LD2 = "Jacob Bryson";
                PlayerDatabase.P1LD3 = "Henri Jokiharju";
                PlayerDatabase.P1RD1 = "Rasmus Dahlin";
                PlayerDatabase.P1RD2 = "Will Butcher";
                PlayerDatabase.P1RD3 = "Ilya Lyubushkin";
                PlayerDatabase.P1G = "Craig Anderson";
                PlayerDatabase.P1PPLW = "Victor Olofsson";PlayerDatabase.P1PPC = "Vinnie Hinostroza";PlayerDatabase.P1PPRW = "Alex Tuch";PlayerDatabase.P1PPLD = "Jeff Skinner";PlayerDatabase.P1PPRD = "Rasmus Dahlin";PlayerDatabase.P1PKLW = "Vinnie Hinostroza";PlayerDatabase.P1PKRW = "Alex Tuch";PlayerDatabase.P1PKLD = "Johnny Boychuk";PlayerDatabase.P1PKRD = "Jacob Bryson";PlayerDatabase.P1PKExW = "Cody Eakin";PlayerDatabase.P1PKExD = "Ilya Lyubushkin";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
                PlayerDatabase.P1LW1 = "Matthew Tkachuk";
                PlayerDatabase.P1LW2 = "Blake Coleman";
                PlayerDatabase.P1LW3 = "Dillon Dube";
                PlayerDatabase.P1LW4 = "Milan Lucic";
                PlayerDatabase.P1C1 = "Elias Lindholm";
                PlayerDatabase.P1C2 = "Mikael Backlund";
                PlayerDatabase.P1C3 = "Sean Monahan";
                PlayerDatabase.P1C4 = "Adam Ruzicka";
                PlayerDatabase.P1RW1 = "Tyler Toffoli";
                PlayerDatabase.P1RW2 = "Andrew Mangiapane";
                PlayerDatabase.P1RW3 = "Trevor Lewis";
                PlayerDatabase.P1RW4 = "Brett Ritchie";
                PlayerDatabase.P1LD1 = "Oliver Kylington";
                PlayerDatabase.P1LD2 = "Nikita Zadorov";
                PlayerDatabase.P1LD3 = "Christopher Tanev";
                PlayerDatabase.P1RD1 = "Noah Hanifin";
                PlayerDatabase.P1RD2 = "Rasmus Andersson";
                PlayerDatabase.P1RD3 = "Michael Stone";
                PlayerDatabase.P1G = "Jacob Markstrom";
                PlayerDatabase.P1PPLW = "Matthew Tkachuk";PlayerDatabase.P1PPC = "Elias Lindholm";PlayerDatabase.P1PPRW = "Tyler Toffoli";PlayerDatabase.P1PPLD = "Oliver Kylington";PlayerDatabase.P1PPRD = "Noah Hanifin";PlayerDatabase.P1PKLW = "Mikael Backlund";PlayerDatabase.P1PKRW = "Elias Lindholm";PlayerDatabase.P1PKLD = "Oliver Kylington";PlayerDatabase.P1PKRD = "Noah Hanifin";PlayerDatabase.P1PKExW = "Adam Ruzicka";PlayerDatabase.P1PKExD = "Nikita Zadorov";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
                PlayerDatabase.P1LW1 = "Max Pacioretty";
                PlayerDatabase.P1LW2 = "Andrei Svechnikov";
                PlayerDatabase.P1LW3 = "Gregory Hofmann";
                PlayerDatabase.P1LW4 = "Jesperi Kotkaniemi";
                PlayerDatabase.P1C1 = "Sebastian Aho";
                PlayerDatabase.P1C2 = "Martin Necas";
                PlayerDatabase.P1C3 = "Jordan Staal";
                PlayerDatabase.P1C4 = "Derek Stepan";
                PlayerDatabase.P1RW1 = "Teuvo Teravainen";
                PlayerDatabase.P1RW2 = "Ondrej Kase";
                PlayerDatabase.P1RW3 = "Jesper Fast";
                PlayerDatabase.P1RW4 = "Seth Jarvis";
                PlayerDatabase.P1LD1 = "Brett Pesce";
                PlayerDatabase.P1LD2 = "Brent Burns";
                PlayerDatabase.P1LD3 = "Brady Skjei";
                PlayerDatabase.P1RD1 = "Jaccob Slavin";
                PlayerDatabase.P1RD2 = "Ethan Bear";
                PlayerDatabase.P1RD3 = "Jake Gardiner";
                PlayerDatabase.P1G = "Frederik Andersen";
                PlayerDatabase.P1PPLW = "Max Pacioretty";PlayerDatabase.P1PPC = "Sebastian Aho";PlayerDatabase.P1PPRW = "Teuvo Teravainen";PlayerDatabase.P1PPLD = "Brent Burns";PlayerDatabase.P1PPRD = "Andrei Svechnikov";PlayerDatabase.P1PKLW = "Sebastian Aho";PlayerDatabase.P1PKRW = "Teuvo Teravainen";PlayerDatabase.P1PKLD = "Brett Pesce";PlayerDatabase.P1PKRD = "Jaccob Slavin";PlayerDatabase.P1PKExW = "Jesper Fast";PlayerDatabase.P1PKExD = "Brady Skjei";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
                PlayerDatabase.P1LW1 = "Max Domi";
                PlayerDatabase.P1LW2 = "Colin Blackwell";
                PlayerDatabase.P1LW3 = "Philipp Kurashev";
                PlayerDatabase.P1LW4 = "Sam Lafferty";
                PlayerDatabase.P1C1 = "Jonathan Toews";
                PlayerDatabase.P1C2 = "Tyler Johnson";
                PlayerDatabase.P1C3 = "Dylan Sikura";
                PlayerDatabase.P1C4 = "Jujhar Khaira";
                PlayerDatabase.P1RW1 = "Patrick Kane";
                PlayerDatabase.P1RW2 = "Andreas Athanasiou";
                PlayerDatabase.P1RW3 = "Brett Connolly";
                PlayerDatabase.P1RW4 = "Kurtis Gabriel";
                PlayerDatabase.P1LD1 = "Seth Jones";
                PlayerDatabase.P1LD2 = "Riley Stillman";
                PlayerDatabase.P1LD3 = "Caleb Jones";
                PlayerDatabase.P1RD1 = "Connor Murphy";
                PlayerDatabase.P1RD2 = "Nicolas Beaudin";
                PlayerDatabase.P1RD3 = "Calvin DeHaan";
                PlayerDatabase.P1G = "Petr Mrazek";
                PlayerDatabase.P1PPLW = "Max Domi";PlayerDatabase.P1PPC = "Jonathan Toews";PlayerDatabase.P1PPRW = "Patrick Kane";PlayerDatabase.P1PPLD = "Seth Jones";PlayerDatabase.P1PPRD = "Andreas Athanasiou";PlayerDatabase.P1PKLW = "Colin Blackwell";PlayerDatabase.P1PKRW = "Tyler Johnson";PlayerDatabase.P1PKLD = "Seth Jones";PlayerDatabase.P1PKRD = "Connor Murphy";PlayerDatabase.P1PKExW = "Dylan Sikura";PlayerDatabase.P1PKExD = "Nicolas Beaudin";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "COL") {
                PlayerDatabase.P1LW1 = "Gabriel Landeskog";
                PlayerDatabase.P1LW2 = "Artturi Lehkonen";
                PlayerDatabase.P1LW3 = "Alex Newhook";
                PlayerDatabase.P1LW4 = "JT Compher";
                PlayerDatabase.P1C1 = "Nathan MacKinnon";
                PlayerDatabase.P1C2 = "Nazem Kadri";
                PlayerDatabase.P1C3 = "Darren Helm";
                PlayerDatabase.P1C4 = "Andrew Cogliano";
                PlayerDatabase.P1RW1 = "Mikko Rantanen";
                PlayerDatabase.P1RW2 = "Valeri Nichushkin";
                PlayerDatabase.P1RW3 = "Logan OConnor";
                PlayerDatabase.P1RW4 = "Martin Kaut";
                PlayerDatabase.P1LD1 = "Devon Toews";
                PlayerDatabase.P1LD2 = "Bowen Byram";
                PlayerDatabase.P1LD3 = "Erik Johnson";
                PlayerDatabase.P1RD1 = "Cale Makar";
                PlayerDatabase.P1RD2 = "Jacob MacDonald";
                PlayerDatabase.P1RD3 = "Samuel Girard";
                PlayerDatabase.P1G = "Alexandar Georgiev";
                PlayerDatabase.P1PPLW = "Gabriel Landeskog";PlayerDatabase.P1PPC = "Nazem Kadri";PlayerDatabase.P1PPRW = "Nathan MacKinnon";PlayerDatabase.P1PPLD = "Mikko Rantanen";PlayerDatabase.P1PPRD = "Cale Makar";PlayerDatabase.P1PKLW = "Gabriel Landeskog";PlayerDatabase.P1PKRW = "Nathan MacKinnon";PlayerDatabase.P1PKLD = "Devon Toews";PlayerDatabase.P1PKRD = "Cale Makar";PlayerDatabase.P1PKExW = "Mikko Rantanen";PlayerDatabase.P1PKExD = "Bowen Byram";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
                PlayerDatabase.P1LW1 = "Johnny Gaudreau";
                PlayerDatabase.P1LW2 = "Patrik Laine";
                PlayerDatabase.P1LW3 = "Eric Robinson";
                PlayerDatabase.P1LW4 = "Brendan Gaunce";
                PlayerDatabase.P1C1 = "Boone Jenner";
                PlayerDatabase.P1C2 = "Gustav Nyquist";
                PlayerDatabase.P1C3 = "Cole Sillinger";
                PlayerDatabase.P1C4 = "Alexandre Texier";
                PlayerDatabase.P1RW1 = "Oliver Bjorkstrand";
                PlayerDatabase.P1RW2 = "Jakub Voracek";
                PlayerDatabase.P1RW3 = "Emil Bemstrom";
                PlayerDatabase.P1RW4 = "Liam Foudy";
                PlayerDatabase.P1LD1 = "Gavin Bayreuther";
                PlayerDatabase.P1LD2 = "Vladislav Gavrikov";
                PlayerDatabase.P1LD3 = "Dean Kukan";
                PlayerDatabase.P1RD1 = "Zach Werenski";
                PlayerDatabase.P1RD2 = "Jake Bean";
                PlayerDatabase.P1RD3 = "Erik Gudbranson";
                PlayerDatabase.P1G = "Elvis Merzlikins";
                PlayerDatabase.P1PPLW = "Johnny Gaudreau";PlayerDatabase.P1PPC = "Boone Jenner";PlayerDatabase.P1PPRW = "Oliver Bjorkstrand";PlayerDatabase.P1PPLD = "Patrik Laine";PlayerDatabase.P1PPRD = "Zach Werenski";PlayerDatabase.P1PKLW = "Eric Robinson";PlayerDatabase.P1PKRW = "Brendan Gaunce";PlayerDatabase.P1PKLD = "Gavin Bayreuther";PlayerDatabase.P1PKRD = "Zach Werenski";PlayerDatabase.P1PKExW = "Gustav Nyquist";PlayerDatabase.P1PKExD = "Jake Bean";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
                PlayerDatabase.P1LW1 = "Jason Robertson";
                PlayerDatabase.P1LW2 = "Mason Marchment";
                PlayerDatabase.P1LW3 = "Joel Kiviranta";
                PlayerDatabase.P1LW4 = "Michael Raffl";
                PlayerDatabase.P1C1 = "Roope Hintz";
                PlayerDatabase.P1C2 = "Jamie Benn";
                PlayerDatabase.P1C3 = "Ty Dellandrea";
                PlayerDatabase.P1C4 = "Jacob Peterson";
                PlayerDatabase.P1RW1 = "Joe Pavelski";
                PlayerDatabase.P1RW2 = "Tyler Seguin";
                PlayerDatabase.P1RW3 = "Denis Gurianov";
                PlayerDatabase.P1RW4 = "Luke Glendening";
                PlayerDatabase.P1LD1 = "Esa Lindell";
                PlayerDatabase.P1LD2 = "Jani Hakanpaa";
                PlayerDatabase.P1LD3 = "Colin Miller";
                PlayerDatabase.P1RD1 = "Miro Heiskanen";
                PlayerDatabase.P1RD2 = "Ryan Suter";
                PlayerDatabase.P1RD3 = "Joel Hanley";
                PlayerDatabase.P1G = "Jake Oettinger";
                PlayerDatabase.P1PPLW = "Jason Robertson";PlayerDatabase.P1PPC = "Joe Pavelski";PlayerDatabase.P1PPRW = "Tyler Seguin";PlayerDatabase.P1PPLD = "Jamie Benn";PlayerDatabase.P1PPRD = "Roope Hintz";PlayerDatabase.P1PKLW = "Jason Robertson";PlayerDatabase.P1PKRW = "Mason Marchment";PlayerDatabase.P1PKLD = "Esa Lindell";PlayerDatabase.P1PKRD = "Ryan Suter";PlayerDatabase.P1PKExW = "Joe Pavelski";PlayerDatabase.P1PKExD = "Jani Hakanpaa";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "DET") {
                PlayerDatabase.P1LW1 = "Dominik Kubalik";
                PlayerDatabase.P1LW2 = "Tyler Bertuzzi";
                PlayerDatabase.P1LW3 = "Filip Zadina";
                PlayerDatabase.P1LW4 = "Adam Erne";
                PlayerDatabase.P1C1 = "Dylan Larkin";
                PlayerDatabase.P1C2 = "Andrew Copp";
                PlayerDatabase.P1C3 = "Robby Fabbri";
                PlayerDatabase.P1C4 = "Oskar Sundqvist";
                PlayerDatabase.P1RW1 = "David Perron";
                PlayerDatabase.P1RW2 = "Jakub Vrana";
                PlayerDatabase.P1RW3 = "Lucas Raymond";
                PlayerDatabase.P1RW4 = "Sam Gagner";
                PlayerDatabase.P1LD1 = "Moritz Seider";
                PlayerDatabase.P1LD2 = "Danny DeKeyser";
                PlayerDatabase.P1LD3 = "Filip Hronek";
                PlayerDatabase.P1RD1 = "Olli Maatta";
                PlayerDatabase.P1RD2 = "Ben Chiarot";
                PlayerDatabase.P1RD3 = "Mark Pysyk";
                PlayerDatabase.P1G = "Alex Nedeljkovic";
                PlayerDatabase.P1PPLW = "Dominik Kubalik";PlayerDatabase.P1PPC = "Dylan Larkin";PlayerDatabase.P1PPRW = "Jakub Vrana";PlayerDatabase.P1PPLD = "David Perron";PlayerDatabase.P1PPRD = "Andrew Copp";PlayerDatabase.P1PKLW = "Andrew Copp";PlayerDatabase.P1PKRW = "David Perron";PlayerDatabase.P1PKLD = "Danny DeKeyser";PlayerDatabase.P1PKRD = "Olli Maatta";PlayerDatabase.P1PKExW = "Jakub Vrana";PlayerDatabase.P1PKExD = "Ben Chiarot";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
                PlayerDatabase.P1LW1 = "Leon Draisaitl";
                PlayerDatabase.P1LW2 = "Evander Kane";
                PlayerDatabase.P1LW3 = "Warren Foegele";
                PlayerDatabase.P1LW4 = "Brendan Perlini";
                PlayerDatabase.P1C1 = "Connor McDavid";
                PlayerDatabase.P1C2 = "Ryan NugentHopkins";
                PlayerDatabase.P1C3 = "Derek Ryan";
                PlayerDatabase.P1C4 = "Derick Brassard";
                PlayerDatabase.P1RW1 = "Zach Hyman";
                PlayerDatabase.P1RW2 = "Jesse Puljujarvi";
                PlayerDatabase.P1RW3 = "Kailer Yamamoto";
                PlayerDatabase.P1RW4 = "Mattias Janmark";
                PlayerDatabase.P1LD1 = "Darnell Nurse";
                PlayerDatabase.P1LD2 = "Kris Russell";
                PlayerDatabase.P1LD3 = "Oscar Klefbom";
                PlayerDatabase.P1RD1 = "Tyson Barrie";
                PlayerDatabase.P1RD2 = "Evan Bouchard";
                PlayerDatabase.P1RD3 = "Cody Ceci";
                PlayerDatabase.P1G = "Jack Campbell";
                PlayerDatabase.P1PPLW = "Evander Kane";PlayerDatabase.P1PPC = "Connor McDavid";PlayerDatabase.P1PPRW = "Zach Hyman";PlayerDatabase.P1PPLD = "Darnell Nurse";PlayerDatabase.P1PPRD = "Leon Draisaitl";PlayerDatabase.P1PKLW = "Connor McDavid";PlayerDatabase.P1PKRW = "Zach Hyman";PlayerDatabase.P1PKLD = "Darnell Nurse";PlayerDatabase.P1PKRD = "Tyson Barrie";PlayerDatabase.P1PKExW = "Leon Draisaitl";PlayerDatabase.P1PKExD = "Kris Russell";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
                PlayerDatabase.P1LW1 = "Jonathan Huberdeau";
                PlayerDatabase.P1LW2 = "Anthony Duclair";
                PlayerDatabase.P1LW3 = "Sam Bennett";
                PlayerDatabase.P1LW4 = "Maxim Mamin";
                PlayerDatabase.P1C1 = "Aleksander Barkov";
                PlayerDatabase.P1C2 = "Anton Lundell";
                PlayerDatabase.P1C3 = "Carter Verhaeghe";
                PlayerDatabase.P1C4 = "Nick Cousins";
                PlayerDatabase.P1RW1 = "Patric Hornqvist";
                PlayerDatabase.P1RW2 = "Sam Reinhart";
                PlayerDatabase.P1RW3 = "Rudolfs Balcers";
                PlayerDatabase.P1RW4 = "Colin White";
                PlayerDatabase.P1LD1 = "Aaron Ekblad";
                PlayerDatabase.P1LD2 = "Gustav Forsling";
                PlayerDatabase.P1LD3 = "Brandon Montour";
                PlayerDatabase.P1RD1 = "MacKenzie Weegar";
                PlayerDatabase.P1RD2 = "Radko Gudas";
                PlayerDatabase.P1RD3 = "Lucas Carlsson";
                PlayerDatabase.P1G = "Sergei Bobrovsky";
                PlayerDatabase.P1PPLW = "Jonathan Huberdeau";PlayerDatabase.P1PPC = "Aleksander Barkov";PlayerDatabase.P1PPRW = "Patric Hornqvist";PlayerDatabase.P1PPLD = "Aaron Ekblad";PlayerDatabase.P1PPRD = "Anthony Duclair";PlayerDatabase.P1PKLW = "Anthony Duclair";PlayerDatabase.P1PKRW = "Aleksander Barkov";PlayerDatabase.P1PKLD = "Aaron Ekblad";PlayerDatabase.P1PKRD = "MacKenzie Weegar";PlayerDatabase.P1PKExW = "Anton Lundell";PlayerDatabase.P1PKExD = "Gustav Forsling";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
                PlayerDatabase.P1LW1 = "Kevin Fiala";
                PlayerDatabase.P1LW2 = "Arthur Kaliyev";
                PlayerDatabase.P1LW3 = "Alex Iafallo";
                PlayerDatabase.P1LW4 = "Brendan Lemieux";
                PlayerDatabase.P1C1 = "Phillip Danault";
                PlayerDatabase.P1C2 = "Anze Kopitar";
                PlayerDatabase.P1C3 = "Blake Lizotte";
                PlayerDatabase.P1C4 = "Trevor Moore";
                PlayerDatabase.P1RW1 = "Viktor Arvidsson";
                PlayerDatabase.P1RW2 = "Adrian Kempe";
                PlayerDatabase.P1RW3 = "Martin Frk";
                PlayerDatabase.P1RW4 = "TJ Tynan";
                PlayerDatabase.P1LD1 = "Drew Doughty";
                PlayerDatabase.P1LD2 = "Jacob Moverare";
                PlayerDatabase.P1LD3 = "Jordan Spence";
                PlayerDatabase.P1RD1 = "Matt Roy";
                PlayerDatabase.P1RD2 = "Alexander Edler";
                PlayerDatabase.P1RD3 = "Michael Anderson";
                PlayerDatabase.P1G = "Jonathan Quick";
                PlayerDatabase.P1PPLW = "Arthur Kaliyev";PlayerDatabase.P1PPC = "Phillip Danault";PlayerDatabase.P1PPRW = "Viktor Arvidsson";PlayerDatabase.P1PPLD = "Kevin Fiala";PlayerDatabase.P1PPRD = "Alexander Edler";PlayerDatabase.P1PKLW = "Phillip Danault";PlayerDatabase.P1PKRW = "Viktor Arvidsson";PlayerDatabase.P1PKLD = "Jacob Moverare";PlayerDatabase.P1PKRD = "Matt Roy";PlayerDatabase.P1PKExW = "Blake Lizotte";PlayerDatabase.P1PKExD = "Alexander Edler";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "MIN") {
                PlayerDatabase.P1LW1 = "Ryan Hartman";
                PlayerDatabase.P1LW2 = "Marcus Foligno";
                PlayerDatabase.P1LW3 = "Jordan Greenway";
                PlayerDatabase.P1LW4 = "Joseph Cramarossa";
                PlayerDatabase.P1C1 = "Joel ErikssonEk";
                PlayerDatabase.P1C2 = "Frederick Gaudreau";
                PlayerDatabase.P1C3 = "Tyson Jost";
                PlayerDatabase.P1C4 = "Kyle Rau";
                PlayerDatabase.P1RW1 = "Kirill Kaprizov";
                PlayerDatabase.P1RW2 = "Mats Zuccarello";
                PlayerDatabase.P1RW3 = "Brandon Duhaime";
                PlayerDatabase.P1RW4 = "Brandon Baddock";
                PlayerDatabase.P1LD1 = "Alex Goligoski";
                PlayerDatabase.P1LD2 = "Jonas Brodin";
                PlayerDatabase.P1LD3 = "Jon Merrill";
                PlayerDatabase.P1RD1 = "Jared Spurgeon";
                PlayerDatabase.P1RD2 = "Matt Dumba";
                PlayerDatabase.P1RD3 = "Dakota Mermis";
                PlayerDatabase.P1G = "MarcAndre Fleury";
                PlayerDatabase.P1PPLW = "Ryan Hartman";PlayerDatabase.P1PPC = "Joel ErikssonEk";PlayerDatabase.P1PPRW = "Kirill Kaprizov";PlayerDatabase.P1PPLD = "Jared Spurgeon";PlayerDatabase.P1PPRD = "Matt Dumba";PlayerDatabase.P1PKLW = "Marcus Foligno";PlayerDatabase.P1PKRW = "Kirill Kaprizov";PlayerDatabase.P1PKLD = "Alex Goligoski";PlayerDatabase.P1PKRD = "Dakota Mermis";PlayerDatabase.P1PKExW = "Frederick Gaudreau";PlayerDatabase.P1PKExD = "Jared Spurgeon";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "MON") {
                PlayerDatabase.P1LW1 = "Josh Anderson";
                PlayerDatabase.P1LW2 = "Evgeny Dadonov";
                PlayerDatabase.P1LW3 = "Jonathan Drouin";
                PlayerDatabase.P1LW4 = "Mathieu Perreault";
                PlayerDatabase.P1C1 = "Mike Hoffman";
                PlayerDatabase.P1C2 = "Nick Suzuki";
                PlayerDatabase.P1C3 = "Paul Byron";
                PlayerDatabase.P1C4 = "Kirby Dach";
                PlayerDatabase.P1RW1 = "Brendan Gallagher";
                PlayerDatabase.P1RW2 = "Cole Caufield";
                PlayerDatabase.P1RW3 = "Joel Armia";
                PlayerDatabase.P1RW4 = "Tyler Pitlick";
                PlayerDatabase.P1LD1 = "Mike Matheson";
                PlayerDatabase.P1LD2 = "Sami Niku";
                PlayerDatabase.P1LD3 = "Madison Bowey";
                PlayerDatabase.P1RD1 = "Joel Edmundson";
                PlayerDatabase.P1RD2 = "William Lagesson";
                PlayerDatabase.P1RD3 = "Xavier Ouellet";
                PlayerDatabase.P1G = "Carey Price";
                PlayerDatabase.P1PPLW = "Josh Anderson";PlayerDatabase.P1PPC = "Mike Hoffman";PlayerDatabase.P1PPRW = "Brendan Gallagher";PlayerDatabase.P1PPLD = "Mike Matheson";PlayerDatabase.P1PPRD = "Evgeny Dadonov";PlayerDatabase.P1PKLW = "Paul Byron";PlayerDatabase.P1PKRW = "Brendan Gallagher";PlayerDatabase.P1PKLD = "Joel Edmundson";PlayerDatabase.P1PKRD = "Mike Matheson";PlayerDatabase.P1PKExW = "Tyler Pitlick";PlayerDatabase.P1PKExD = "William Lagesson";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
                PlayerDatabase.P1LW1 = "Filip Forsberg";
                PlayerDatabase.P1LW2 = "Eeli Tolvanen";
                PlayerDatabase.P1LW3 = "Tanner Jeannot";
                PlayerDatabase.P1LW4 = "Zach Sanford";
                PlayerDatabase.P1C1 = "Matt Duchene";
                PlayerDatabase.P1C2 = "Colton Sissons";
                PlayerDatabase.P1C3 = "Yakov Trenin";
                PlayerDatabase.P1C4 = "Ryan Johansen";
                PlayerDatabase.P1RW1 = "Mikael Granlund";
                PlayerDatabase.P1RW2 = "Nino Niederreiter";
                PlayerDatabase.P1RW3 = "Rocco Grimaldi";
                PlayerDatabase.P1RW4 = "Matt Luff";
                PlayerDatabase.P1LD1 = "Roman Josi";
                PlayerDatabase.P1LD2 = "Mattias Ekholm";
                PlayerDatabase.P1LD3 = "Ryan McDonagh";
                PlayerDatabase.P1RD1 = "Alexandre Carrier";
                PlayerDatabase.P1RD2 = "Dante Fabbro";
                PlayerDatabase.P1RD3 = "Jeremy Lauzon";
                PlayerDatabase.P1G = "Juuse Saros";
                PlayerDatabase.P1PPLW = "Filip Forsberg";PlayerDatabase.P1PPC = "Matt Duchene";PlayerDatabase.P1PPRW = "Mikael Granlund";PlayerDatabase.P1PPLD = "Roman Josi";PlayerDatabase.P1PPRD = "Eeli Tolvanen";PlayerDatabase.P1PKLW = "Tanner Jeannot";PlayerDatabase.P1PKRW = "Michael McCarron";PlayerDatabase.P1PKLD = "Mattias Ekholm";PlayerDatabase.P1PKRD = "Alexandre Carrier";PlayerDatabase.P1PKExW = "Colton Sissons";PlayerDatabase.P1PKExD = "Ryan McDonagh";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
                PlayerDatabase.P1LW1 = "Ondrej Palat";
                PlayerDatabase.P1LW2 = "Tomas Tatar";
                PlayerDatabase.P1LW3 = "Miles Wood";
                PlayerDatabase.P1LW4 = "Andreas Johnson";
                PlayerDatabase.P1C1 = "Erik Haula";
                PlayerDatabase.P1C2 = "Nico Hischier";
                PlayerDatabase.P1C3 = "Jack Hughes";
                PlayerDatabase.P1C4 = "Yegor Sharangovich";
                PlayerDatabase.P1RW1 = "Jesper Bratt";
                PlayerDatabase.P1RW2 = "Dawson Mercer";
                PlayerDatabase.P1RW3 = "Nathan Bastian";
                PlayerDatabase.P1RW4 = "Jimmy Vesey";
                PlayerDatabase.P1LD1 = "Dougie Hamilton";
                PlayerDatabase.P1LD2 = "Brendan Smith";
                PlayerDatabase.P1LD3 = "Jonas Siegenthaler";
                PlayerDatabase.P1RD1 = "Ryan Graves";
                PlayerDatabase.P1RD2 = "John Marino";
                PlayerDatabase.P1RD3 = "Damon Severson";
                PlayerDatabase.P1G = "Vitek Vanecek";
                PlayerDatabase.P1PPLW = "Ondrej Palat";PlayerDatabase.P1PPC = "Erik Haula";PlayerDatabase.P1PPRW = "Jesper Bratt";PlayerDatabase.P1PPLD = "Dougie Hamilton";PlayerDatabase.P1PPRD = "Tomas Tatar";PlayerDatabase.P1PKLW = "Ondrej Palat";PlayerDatabase.P1PKRW = "Erik Haula";PlayerDatabase.P1PKLD = "Dougie Hamilton";PlayerDatabase.P1PKRD = "Ryan Graves";PlayerDatabase.P1PKExW = "Andreas Johnson";PlayerDatabase.P1PKExD = "John Marino";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
                PlayerDatabase.P1LW1 = "Anders Lee";
                PlayerDatabase.P1LW2 = "Anthony Beauvillier";
                PlayerDatabase.P1LW3 = "Zach Parise";
                PlayerDatabase.P1LW4 = "Matt Martin";
                PlayerDatabase.P1C1 = "Brock Nelson";
                PlayerDatabase.P1C2 = "Mathew Barzal";
                PlayerDatabase.P1C3 = "JeanGabriel Pageau";
                PlayerDatabase.P1C4 = "Casey Cizikas";
                PlayerDatabase.P1RW1 = "Kyle Palmieri";
                PlayerDatabase.P1RW2 = "Oliver Wahlstrom";
                PlayerDatabase.P1RW3 = "Josh Bailey";
                PlayerDatabase.P1RW4 = "Cal Clutterbuck";
                PlayerDatabase.P1LD1 = "Zdeno Chara";
                PlayerDatabase.P1LD2 = "Scott Mayfield";
                PlayerDatabase.P1LD3 = "Thomas Hickey";
                PlayerDatabase.P1RD1 = "Ryan Pulock";
                PlayerDatabase.P1RD2 = "Adam Pelech";
                PlayerDatabase.P1RD3 = "Noah Dobson";
                PlayerDatabase.P1G = "Ilya Sorokin";
                PlayerDatabase.P1PPLW = "Anders Lee";PlayerDatabase.P1PPC = "Brock Nelson";PlayerDatabase.P1PPRW = "Kyle Palmieri";PlayerDatabase.P1PPLD = "Ryan Pulock";PlayerDatabase.P1PPRD = "Anthony Beauvillier";PlayerDatabase.P1PKLW = "Anders Lee";PlayerDatabase.P1PKRW = "Brock Nelson";PlayerDatabase.P1PKLD = "Ryan Pulock";PlayerDatabase.P1PKRD = "Zdeno Chara";PlayerDatabase.P1PKExW = "Casey Cizikas";PlayerDatabase.P1PKExD = "Adam Pelech";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
                PlayerDatabase.P1LW1 = "Artemi Panarin";
                PlayerDatabase.P1LW2 = "Chris Kreider";
                PlayerDatabase.P1LW3 = "Dryden Hunt";
                PlayerDatabase.P1LW4 = "Alexis Lafreniere";
                PlayerDatabase.P1C1 = "Mika Zibanejad";
                PlayerDatabase.P1C2 = "Vincent Trocheck";
                PlayerDatabase.P1C3 = "Filip Chytil";
                PlayerDatabase.P1C4 = "Ryan Carpenter";
                PlayerDatabase.P1RW1 = "Barclay Goodrow";
                PlayerDatabase.P1RW2 = "Jonny Brodzinski";
                PlayerDatabase.P1RW3 = "Kaapo Kakko";
                PlayerDatabase.P1RW4 = "Nick Merkley";
                PlayerDatabase.P1LD1 = "Nils Lundkvist";
                PlayerDatabase.P1LD2 = "Ryan Lindgren";
                PlayerDatabase.P1LD3 = "Libor Hajek";
                PlayerDatabase.P1RD1 = "Adam Fox";
                PlayerDatabase.P1RD2 = "KAndre Miller";
                PlayerDatabase.P1RD3 = "Jacob Trouba";
                PlayerDatabase.P1G = "Igor Shesterkin";
                PlayerDatabase.P1PPLW = "Artemi Panarin";PlayerDatabase.P1PPC = "Mika Zibanejad";PlayerDatabase.P1PPRW = "Barclay Goodrow";PlayerDatabase.P1PPLD = "Nils Lundkvist";PlayerDatabase.P1PPRD = "Adam Fox";PlayerDatabase.P1PKLW = "Artemi Panarin";PlayerDatabase.P1PKRW = "Mika Zibanejad";PlayerDatabase.P1PKLD = "Nils Lundkvist";PlayerDatabase.P1PKRD = "Adam Fox";PlayerDatabase.P1PKExW = "Chris Kreider";PlayerDatabase.P1PKExD = "KAndre Miller";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
                PlayerDatabase.P1LW1 = "Alex DeBrincat";
                PlayerDatabase.P1LW2 = "Brady Tkachuk";
                PlayerDatabase.P1LW3 = "Alex Formenton";
                PlayerDatabase.P1LW4 = "Austin Watson";
                PlayerDatabase.P1C1 = "Claude Giroux";
                PlayerDatabase.P1C2 = "Josh Norris";
                PlayerDatabase.P1C3 = "Tim Stutzle";
                PlayerDatabase.P1C4 = "Dylan Gambrell";
                PlayerDatabase.P1RW1 = "Drake Batherson";
                PlayerDatabase.P1RW2 = "Tyler Ennis";
                PlayerDatabase.P1RW3 = "Mathieu Joseph";
                PlayerDatabase.P1RW4 = "Zach Senyshyn";
                PlayerDatabase.P1LD1 = "Travis Hamonic";
                PlayerDatabase.P1LD2 = "Nick Holden";
                PlayerDatabase.P1LD3 = "Erik Brannstrom";
                PlayerDatabase.P1RD1 = "Thomas Chabot";
                PlayerDatabase.P1RD2 = "Nikita Zaitsev";
                PlayerDatabase.P1RD3 = "Jacob BernardDocker";
                PlayerDatabase.P1G = "Cam Talbot";
                PlayerDatabase.P1PPLW = "Alex DeBrincat";PlayerDatabase.P1PPC = "Claude Giroux";PlayerDatabase.P1PPRW = "Drake Batherson";PlayerDatabase.P1PPLD = "Thomas Chabot";PlayerDatabase.P1PPRD = "Tyler Ennis";PlayerDatabase.P1PKLW = "Alex DeBrincat";PlayerDatabase.P1PKRW = "Mathieu Joseph";PlayerDatabase.P1PKLD = "Travis Hamonic";PlayerDatabase.P1PKRD = "Nikita Zaitsev";PlayerDatabase.P1PKExW = "Claude Giroux";PlayerDatabase.P1PKExD = "Nick Holden";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
                PlayerDatabase.P1LW1 = "Travis Konecny";
                PlayerDatabase.P1LW2 = "James VanRiemsdyk";
                PlayerDatabase.P1LW3 = "Joel Farabee";
                PlayerDatabase.P1LW4 = "Nick Deslauriers";
                PlayerDatabase.P1C1 = "Sean Couturier";
                PlayerDatabase.P1C2 = "Kevin Hayes";
                PlayerDatabase.P1C3 = "Scott Laughton";
                PlayerDatabase.P1C4 = "Morgan Frost";
                PlayerDatabase.P1RW1 = "Cam Atkinson";
                PlayerDatabase.P1RW2 = "Owen Tippett";
                PlayerDatabase.P1RW3 = "Wade Allison";
                PlayerDatabase.P1RW4 = "Zack MacEwen";
                PlayerDatabase.P1LD1 = "Ryan Ellis";
                PlayerDatabase.P1LD2 = "Rasmus Ristolainen";
                PlayerDatabase.P1LD3 = "Kevin Connauton";
                PlayerDatabase.P1RD1 = "Tony DeAngelo";
                PlayerDatabase.P1RD2 = "Ivan Provorov";
                PlayerDatabase.P1RD3 = "Justin Braun";
                PlayerDatabase.P1G = "Carter Hart";
                PlayerDatabase.P1PPLW = "James VanRiemsdyk";PlayerDatabase.P1PPC = "Sean Couturier";PlayerDatabase.P1PPRW = "Cam Atkinson";PlayerDatabase.P1PPLD = "Ryan Ellis";PlayerDatabase.P1PPRD = "Travis Konecny";PlayerDatabase.P1PKLW = "Sean Couturier";PlayerDatabase.P1PKRW = "Cam Atkinson";PlayerDatabase.P1PKLD = "Ryan Ellis";PlayerDatabase.P1PKRD = "Tony DeAngelo";PlayerDatabase.P1PKExW = "Joel Farabee";PlayerDatabase.P1PKExD = "Ivan Provorov";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
                PlayerDatabase.P1LW1 = "Bryan Rust";
                PlayerDatabase.P1LW2 = "Kasperi Kapanen";
                PlayerDatabase.P1LW3 = "Jason Zucker";
                PlayerDatabase.P1LW4 = "Brian Boyle";
                PlayerDatabase.P1C1 = "Sidney Crosby";
                PlayerDatabase.P1C2 = "Jeff Carter";
                PlayerDatabase.P1C3 = "Evgeni Malkin";
                PlayerDatabase.P1C4 = "Teddy Blueger";
                PlayerDatabase.P1RW1 = "Jake Guentzel";
                PlayerDatabase.P1RW2 = "Evan Rodrigues";
                PlayerDatabase.P1RW3 = "Rickard Rakell";
                PlayerDatabase.P1RW4 = "Josh Archibald";
                PlayerDatabase.P1LD1 = "Brian Dumoulin";
                PlayerDatabase.P1LD2 = "Jeff Petry";
                PlayerDatabase.P1LD3 = "Marcus Pettersson";
                PlayerDatabase.P1RD1 = "Kris Letang";
                PlayerDatabase.P1RD2 = "Jan Rutta";
                PlayerDatabase.P1RD3 = "Taylor Fedun";
                PlayerDatabase.P1G = "Casey DeSmith";
                PlayerDatabase.P1PPLW = "Bryan Rust";PlayerDatabase.P1PPC = "Sidney Crosby";PlayerDatabase.P1PPRW = "Evan Rodrigues";PlayerDatabase.P1PPLD = "Jake Guentzel";PlayerDatabase.P1PPRD = "Kris Letang";PlayerDatabase.P1PKLW = "Sidney Crosby";PlayerDatabase.P1PKRW = "Jake Guentzel";PlayerDatabase.P1PKLD = "Brian Dumoulin";PlayerDatabase.P1PKRD = "Kris Letang";PlayerDatabase.P1PKExW = "Bryan Rust";PlayerDatabase.P1PKExD = "Jan Rutta";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "STL") {
                PlayerDatabase.P1LW1 = "Pavel Buchnevich";
                PlayerDatabase.P1LW2 = "Josh Leivo";
                PlayerDatabase.P1LW3 = "Brandon Saad";
                PlayerDatabase.P1LW4 = "MacKenzie MacEachern";
                PlayerDatabase.P1C1 = "Ryan OReilly";
                PlayerDatabase.P1C2 = "Brayden Schenn";
                PlayerDatabase.P1C3 = "Robert Thomas";
                PlayerDatabase.P1C4 = "Noel Acciari";
                PlayerDatabase.P1RW1 = "Vladimir Tarasenko";
                PlayerDatabase.P1RW2 = "Jordan Kyrou";
                PlayerDatabase.P1RW3 = "James Neal";
                PlayerDatabase.P1RW4 = "Alexei Toropchenko";
                PlayerDatabase.P1LD1 = "Justin Faulk";
                PlayerDatabase.P1LD2 = "Torey Krug";
                PlayerDatabase.P1LD3 = "Steve Santini";
                PlayerDatabase.P1RD1 = "Colton Parayko";
                PlayerDatabase.P1RD2 = "Marco Scandella";
                PlayerDatabase.P1RD3 = "Robert Bortuzzo";
                PlayerDatabase.P1G = "Jordan Binnington";
                PlayerDatabase.P1PPLW = "Pavel Buchnevich";PlayerDatabase.P1PPC = "Ryan OReilly";PlayerDatabase.P1PPRW = "Vladimir Tarasenko";PlayerDatabase.P1PPLD = "Justin Faulk";PlayerDatabase.P1PPRD = "Colton Parayko";PlayerDatabase.P1PKLW = "Ryan OReilly";PlayerDatabase.P1PKRW = "Pavel Buchnevich";PlayerDatabase.P1PKLD = "Justin Faulk";PlayerDatabase.P1PKRD = "Colton Parayko";PlayerDatabase.P1PKExW = "Torey Krug";PlayerDatabase.P1PKExD = "Jordan Kyrou";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
                PlayerDatabase.P1LW1 = "Timo Meier";
                PlayerDatabase.P1LW2 = "Alexander Barabanov";
                PlayerDatabase.P1LW3 = "Ryan Dzingel";
                PlayerDatabase.P1LW4 = "Matt Nieto";
                PlayerDatabase.P1C1 = "Tomas Hertl";
                PlayerDatabase.P1C2 = "Logan Couture";
                PlayerDatabase.P1C3 = "Noah Gregor";
                PlayerDatabase.P1C4 = "Nick Bonino";
                PlayerDatabase.P1RW1 = "Kevin Labanc";
                PlayerDatabase.P1RW2 = "Luke Kunin";
                PlayerDatabase.P1RW3 = "Alexander Chmelevski";
                PlayerDatabase.P1RW4 = "Oskar Lindblom";
                PlayerDatabase.P1LD1 = "Erik Karlsson";
                PlayerDatabase.P1LD2 = "Matt Benning";
                PlayerDatabase.P1LD3 = "Jaycob Megna";
                PlayerDatabase.P1RD1 = "Markus Nutivaara";
                PlayerDatabase.P1RD2 = "Mario Ferraro";
                PlayerDatabase.P1RD3 = "MarcEdouard Vlasic";
                PlayerDatabase.P1G = "James Reimer";
                PlayerDatabase.P1PPLW = "Tomas Hertl";PlayerDatabase.P1PPC = "Logan Couture";PlayerDatabase.P1PPRW = "Luke Kunin";PlayerDatabase.P1PPLD = "Erik Karlsson";PlayerDatabase.P1PPRD = "Timo Meier";PlayerDatabase.P1PKLW = "Tomas Hertl";PlayerDatabase.P1PKRW = "Nick Bonino";PlayerDatabase.P1PKLD = "Matt Benning";PlayerDatabase.P1PKRD = "Markus Nutivaara";PlayerDatabase.P1PKExW = "Timo Meier";PlayerDatabase.P1PKExD = "Jaycob Megna";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "SEA") {
                PlayerDatabase.P1LW1 = "Jaden Schwartz";
                PlayerDatabase.P1LW2 = "Andre Burakovsky";
                PlayerDatabase.P1LW3 = "Brandon Tanev";
                PlayerDatabase.P1LW4 = "Riley Sheahan";
                PlayerDatabase.P1C1 = "Jared McCann";
                PlayerDatabase.P1C2 = "Ryan Donato";
                PlayerDatabase.P1C3 = "Yanni Gourde";
                PlayerDatabase.P1C4 = "Matthew Beniers";
                PlayerDatabase.P1RW1 = "Jordan Eberle";
                PlayerDatabase.P1RW2 = "Daniel Sprong";
                PlayerDatabase.P1RW3 = "Joonas Donskoi";
                PlayerDatabase.P1RW4 = "Karson Kuhlman";
                PlayerDatabase.P1LD1 = "Carson Soucy";
                PlayerDatabase.P1LD2 = "Vince Dunn";
                PlayerDatabase.P1LD3 = "Connor Carrick";
                PlayerDatabase.P1RD1 = "Jamie Oleksiak";
                PlayerDatabase.P1RD2 = "Dennis Cholowski";
                PlayerDatabase.P1RD3 = "Adam Larsson";
                PlayerDatabase.P1G = "Philipp Grubauer";
                PlayerDatabase.P1PPLW = "Jaden Schwartz";PlayerDatabase.P1PPC = "Ryan Donato";PlayerDatabase.P1PPRW = "Jordan Eberle";PlayerDatabase.P1PPLD = "Vince Dunn";PlayerDatabase.P1PPRD = "Jared McCann";PlayerDatabase.P1PKLW = "Joonas Donskoi";PlayerDatabase.P1PKRW = "Andre Burakovsky";PlayerDatabase.P1PKLD = "Carson Soucy";PlayerDatabase.P1PKRD = "Jamie Oleksiak";PlayerDatabase.P1PKExW = "Brandon Tanev";PlayerDatabase.P1PKExD = "Vince Dunn";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
                PlayerDatabase.P1LW1 = "Alex Killorn";
                PlayerDatabase.P1LW2 = "Nick Paul";
                PlayerDatabase.P1LW3 = "Vladislav Namestnikov";
                PlayerDatabase.P1LW4 = "Pat Maroon";
                PlayerDatabase.P1C1 = "Steven Stamkos";
                PlayerDatabase.P1C2 = "Brayden Point";
                PlayerDatabase.P1C3 = "Ross Colton";
                PlayerDatabase.P1C4 = "Anthony Cirelli";
                PlayerDatabase.P1RW1 = "Nikita Kucherov";
                PlayerDatabase.P1RW2 = "Alex BarreBoulet";
                PlayerDatabase.P1RW3 = "Charles Hudon";
                PlayerDatabase.P1RW4 = "Corey Perry";
                PlayerDatabase.P1LD1 = "Victor Hedman";
                PlayerDatabase.P1LD2 = "Mikhail Sergachev";
                PlayerDatabase.P1LD3 = "Ian Cole";
                PlayerDatabase.P1RD1 = "Erik Cernak";
                PlayerDatabase.P1RD2 = "Cal Foote";
                PlayerDatabase.P1RD3 = "Haydn Fleury";
                PlayerDatabase.P1G = "Andrei Vasilevskiy";
                PlayerDatabase.P1PPLW = "Alex Killorn";PlayerDatabase.P1PPC = "Brayden Point";PlayerDatabase.P1PPRW = "Nikita Kucherov";PlayerDatabase.P1PPLD = "Victor Hedman";PlayerDatabase.P1PPRD = "Steven Stamkos";PlayerDatabase.P1PKLW = "Brayden Point";PlayerDatabase.P1PKRW = "Nikita Kucherov";PlayerDatabase.P1PKLD = "Victor Hedman";PlayerDatabase.P1PKRD = "Erik Cernak";PlayerDatabase.P1PKExW = "Steven Stamkos";PlayerDatabase.P1PKExD = "Mikhail Sergachev";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
                PlayerDatabase.P1LW1 = "Michael Bunting";
                PlayerDatabase.P1LW2 = "Calle Jarnkrok";
                PlayerDatabase.P1LW3 = "Pierre Engvall";
                PlayerDatabase.P1LW4 = "Kyle Clifford";
                PlayerDatabase.P1C1 = "Auston Matthews";
                PlayerDatabase.P1C2 = "John Tavares";
                PlayerDatabase.P1C3 = "Alexander Kerfoot";
                PlayerDatabase.P1C4 = "Jason Spezza";
                PlayerDatabase.P1RW1 = "Mitchell Marner";
                PlayerDatabase.P1RW2 = "William Nylander";
                PlayerDatabase.P1RW3 = "Nicolas AubeKubel";
                PlayerDatabase.P1RW4 = "Joey Anderson";
                PlayerDatabase.P1LD1 = "Morgan Rielly";
                PlayerDatabase.P1LD2 = "Mark Giordano";
                PlayerDatabase.P1LD3 = "Jordie Benn";
                PlayerDatabase.P1RD1 = "Jake Muzzin";
                PlayerDatabase.P1RD2 = "TJ Brodie";
                PlayerDatabase.P1RD3 = "Timothy Liljegren";
                PlayerDatabase.P1G = "Ilya Samsonov";
                PlayerDatabase.P1PPLW = "Michael Bunting";PlayerDatabase.P1PPC = "Auston Matthews";PlayerDatabase.P1PPRW = "Mitchell Marner";PlayerDatabase.P1PPLD = "Morgan Rielly";PlayerDatabase.P1PPRD = "Mark Giordano";PlayerDatabase.P1PKLW = "Auston Matthews";PlayerDatabase.P1PKRW = "Mitchell Marner";PlayerDatabase.P1PKLD = "Morgan Rielly";PlayerDatabase.P1PKRD = "Jake Muzzin";PlayerDatabase.P1PKExW = "Michael Bunting";PlayerDatabase.P1PKExD = "TJ Brodie";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
                PlayerDatabase.P1LW1 = "Ilya Mikheyev";
                PlayerDatabase.P1LW2 = "Conor Garland";
                PlayerDatabase.P1LW3 = "Tanner Pearson";
                PlayerDatabase.P1LW4 = "Alex Chiasson";
                PlayerDatabase.P1C1 = "Bo Horvat";
                PlayerDatabase.P1C2 = "JT Miller";
                PlayerDatabase.P1C3 = "Elias Pettersson";
                PlayerDatabase.P1C4 = "Jason Dickinson";
                PlayerDatabase.P1RW1 = "Brock Boeser";
                PlayerDatabase.P1RW2 = "Michael Ferland";
                PlayerDatabase.P1RW3 = "Nils Hoglander";
                PlayerDatabase.P1RW4 = "Vasily Podkolzin";
                PlayerDatabase.P1LD1 = "Tucker Poolman";
                PlayerDatabase.P1LD2 = "Oliver EkmanLarsson";
                PlayerDatabase.P1LD3 = "Luke Schenn";
                PlayerDatabase.P1RD1 = "Tyler Myers";
                PlayerDatabase.P1RD2 = "Travis Dermott";
                PlayerDatabase.P1RD3 = "Quinn Hughes";
                PlayerDatabase.P1G = "Thatcher Demko";
                PlayerDatabase.P1PPLW = "Ilya Mikheyev";PlayerDatabase.P1PPC = "Bo Horvat";PlayerDatabase.P1PPRW = "Brock Boeser";PlayerDatabase.P1PPLD = "Conor Garland";PlayerDatabase.P1PPRD = "JT Miller";PlayerDatabase.P1PKLW = "Conor Garland";PlayerDatabase.P1PKRW = "Ilya Mikheyev";PlayerDatabase.P1PKLD = "Tucker Poolman";PlayerDatabase.P1PKRD = "Travis Dermott";PlayerDatabase.P1PKExW = "Michael Ferland";PlayerDatabase.P1PKExD = "Tyler Myers";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "VGK") {
                PlayerDatabase.P1LW1 = "Jonathan Marchessault";
                PlayerDatabase.P1LW2 = "Chandler Stephenson";
                PlayerDatabase.P1LW3 = "William Carrier";
                PlayerDatabase.P1LW4 = "Sven Bartschi";
                PlayerDatabase.P1C1 = "Jack Eichel";
                PlayerDatabase.P1C2 = "William Karlsson";
                PlayerDatabase.P1C3 = "Mike Amadio";
                PlayerDatabase.P1C4 = "Nolan Patrick";
                PlayerDatabase.P1RW1 = "Reilly Smith";
                PlayerDatabase.P1RW2 = "Mark Stone";
                PlayerDatabase.P1RW3 = "Nicolas Roy";
                PlayerDatabase.P1RW4 = "Keegan Kolesar";
                PlayerDatabase.P1LD1 = "Alex Pietrangelo";
                PlayerDatabase.P1LD2 = "Shea Weber";
                PlayerDatabase.P1LD3 = "Nicolas Hague";
                PlayerDatabase.P1RD1 = "Shea Theodore";
                PlayerDatabase.P1RD2 = "Zach Whitecloud";
                PlayerDatabase.P1RD3 = "Alec Martinez";
                PlayerDatabase.P1G = "Robin Lehner";
                PlayerDatabase.P1PPLW = "Jonathan Marchessault";PlayerDatabase.P1PPC = "Jack Eichel";PlayerDatabase.P1PPRW = "Reilly Smith";PlayerDatabase.P1PPLD = "Alex Pietrangelo";PlayerDatabase.P1PPRD = "Shea Theodore";PlayerDatabase.P1PKLW = "William Karlsson";PlayerDatabase.P1PKRW = "Reilly Smith";PlayerDatabase.P1PKLD = "Alex Pietrangelo";PlayerDatabase.P1PKRD = "Zach Whitecloud";PlayerDatabase.P1PKExW = "Mark Stone";PlayerDatabase.P1PKExD = "Shea Theodore";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
                PlayerDatabase.P1LW1 = "Alexander Ovechkin";
                PlayerDatabase.P1LW2 = "Carl Hagelin";
                PlayerDatabase.P1LW3 = "Garnet Hathaway";
                PlayerDatabase.P1LW4 = "Axel JonssonFjallby";
                PlayerDatabase.P1C1 = "Evgeny Kuznetsov";
                PlayerDatabase.P1C2 = "Nicklas Backstrom";
                PlayerDatabase.P1C3 = "Lars Eller";
                PlayerDatabase.P1C4 = "Dylan Strome";
                PlayerDatabase.P1RW1 = "Anthony Mantha";
                PlayerDatabase.P1RW2 = "Tom Wilson";
                PlayerDatabase.P1RW3 = "Connor Brown";
                PlayerDatabase.P1RW4 = "TJ Oshie";
                PlayerDatabase.P1LD1 = "Dmitry Orlov";
                PlayerDatabase.P1LD2 = "Martin Fehervary";
                PlayerDatabase.P1LD3 = "Nick Jensen";
                PlayerDatabase.P1RD1 = "John Carlson";
                PlayerDatabase.P1RD2 = "Michal Kempny";
                PlayerDatabase.P1RD3 = "Erik Gustafsson";
                PlayerDatabase.P1G = "Darcy Kuemper";
                PlayerDatabase.P1PPLW = "Alexander Ovechkin";PlayerDatabase.P1PPC = "Evgeny Kuznetsov";PlayerDatabase.P1PPRW = "Tom Wilson";PlayerDatabase.P1PPLD = "Anthony Mantha";PlayerDatabase.P1PPRD = "John Carlson";PlayerDatabase.P1PKLW = "Carl Hagelin";PlayerDatabase.P1PKRW = "Garnet Hathaway";PlayerDatabase.P1PKLD = "Martin Fehervary";PlayerDatabase.P1PKRD = "Michal Kempny";PlayerDatabase.P1PKExW = "Evgeny Kuznetsov";PlayerDatabase.P1PKExD = "Dmitry Orlov";
            }
            else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
                PlayerDatabase.P1LW1 = "Nikolaj Ehlers";
                PlayerDatabase.P1LW2 = "Kyle Connor";
                PlayerDatabase.P1LW3 = "Cole Perfetti";
                PlayerDatabase.P1LW4 = "Kristian Vesalainen";
                PlayerDatabase.P1C1 = "Mark Scheifele";
                PlayerDatabase.P1C2 = "Paul Stastny";
                PlayerDatabase.P1C3 = "PierreLuc Dubois";
                PlayerDatabase.P1C4 = "Adam Lowry";
                PlayerDatabase.P1RW1 = "Blake Wheeler";
                PlayerDatabase.P1RW2 = "Mason Appleton";
                PlayerDatabase.P1RW3 = "Evgeny Svechnikov";
                PlayerDatabase.P1RW4 = "Austin Poganski";
                PlayerDatabase.P1LD1 = "Nate Schmidt";
                PlayerDatabase.P1LD2 = "Neal Pionk";
                PlayerDatabase.P1LD3 = "Dylan Samberg";
                PlayerDatabase.P1RD1 = "Brenden Dillon";
                PlayerDatabase.P1RD2 = "Dylan DeMelo";
                PlayerDatabase.P1RD3 = "Logan Stanley";
                PlayerDatabase.P1G = "Connor Hellebuyck";
                PlayerDatabase.P1PPLW = "Nikolaj Ehlers";PlayerDatabase.P1PPC = "Mark Scheifele";PlayerDatabase.P1PPRW = "Blake Wheeler";PlayerDatabase.P1PPLD = "Neal Pionk";PlayerDatabase.P1PPRD = "Dylan DeMelo";PlayerDatabase.P1PKLW = "Nikolaj Ehlers";PlayerDatabase.P1PKRW = "Paul Stastny";PlayerDatabase.P1PKLD = "Dylan Samberg";PlayerDatabase.P1PKRD = "Brenden Dillon";PlayerDatabase.P1PKExW = "Cole Perfetti";PlayerDatabase.P1PKExD = "Dylan DeMelo";
            }
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				PlayerDatabase.P1LW1 = "Paul Kariya";
				PlayerDatabase.P1LW2 = "Chris Kunitz";
				PlayerDatabase.P1LW3 = "Bobby Ryan";
				PlayerDatabase.P1LW4 = "Jakob Silfverberg";
				PlayerDatabase.P1C1 = "Ryan Getzlaf";
				PlayerDatabase.P1C2 = "Andy McDonald";
				PlayerDatabase.P1C3 = "Rickard Rakell";
				PlayerDatabase.P1C4 = "Steve Rucchin";
				PlayerDatabase.P1RW1 = "Teemu Selanne";
				PlayerDatabase.P1RW2 = "Petr Sykora";
				PlayerDatabase.P1RW3 = "Corey Perry";
				PlayerDatabase.P1RW4 = "Andrew Cogliano";
				PlayerDatabase.P1LD1 = "Hampus Lindholm";
				PlayerDatabase.P1LD2 = "Cam Fowler";
				PlayerDatabase.P1LD3 = "Josh Manson";
				PlayerDatabase.P1RD1 = "Scott Niedermayer";
				PlayerDatabase.P1RD2 = "Chris Pronger";
				PlayerDatabase.P1RD3 = "Francois Beauchemin";
				PlayerDatabase.P1G = "John Gibson";
                PlayerDatabase.P1PPLW = "Paul Kariya";
                PlayerDatabase.P1PPC = "Ryan Getzlaf";
                PlayerDatabase.P1PPRW = "Teemu Selanne";
                PlayerDatabase.P1PPLD = "Bobby Ryan";
                PlayerDatabase.P1PPRD = "Petr Sykora";
                PlayerDatabase.P1PKLW = "Chris Kunitz";
                PlayerDatabase.P1PKRW = "Teemu Selanne";
                PlayerDatabase.P1PKLD = "Hampus Lindholm";
                PlayerDatabase.P1PKRD = "Chris Pronger";
                PlayerDatabase.P1PKExW = "Paul Kariya";
                PlayerDatabase.P1PKExD = "Francois Beauchemin";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ATL") {
				PlayerDatabase.P1LW1 = "Ilya Kovalchuk";
				PlayerDatabase.P1LW2 = "Donald Audette";
				PlayerDatabase.P1LW3 = "Vyacheslav Kozlov";
				PlayerDatabase.P1LW4 = "Shawn McEachern";
				PlayerDatabase.P1C1 = "Bryan Little";
				PlayerDatabase.P1C2 = "Marc Savard";
				PlayerDatabase.P1C3 = "Ray Ferraro";
				PlayerDatabase.P1C4 = "Patrik Stefan";
				PlayerDatabase.P1RW1 = "Marian Hossa";
				PlayerDatabase.P1RW2 = "Dany Heatley";
				PlayerDatabase.P1RW3 = "Colby Armstrong";
				PlayerDatabase.P1RW4 = "Nikolai Antropov";
				PlayerDatabase.P1LD1 = "Dustin Byfuglien";
				PlayerDatabase.P1LD2 = "Tobias Enstrom";
				PlayerDatabase.P1LD3 = "Frantisek Kaberle";
				PlayerDatabase.P1RD1 = "Zach Bogosian";
				PlayerDatabase.P1RD2 = "Greg DeVries";
				PlayerDatabase.P1RD3 = "Ron Hainsey";
				PlayerDatabase.P1G = "Kari Lehtonen";
                PlayerDatabase.P1PPLW = "Ilya Kovalchuk";
                PlayerDatabase.P1PPC = "Bryan Little";
                PlayerDatabase.P1PPRW = "Marian Hossa";
                PlayerDatabase.P1PPLD = "Donald Audette";
                PlayerDatabase.P1PPRD = "Dany Heatley";
                PlayerDatabase.P1PKLW = "Marian Hossa";
                PlayerDatabase.P1PKRW = "Colby Armstrong";
                PlayerDatabase.P1PKLD = "Dustin Byfuglien";
                PlayerDatabase.P1PKRD = "Greg DeVries";
                PlayerDatabase.P1PKExW = "Ilya Kovalchuk";
                PlayerDatabase.P1PKExD = "Frantisek Kaberle";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				PlayerDatabase.P1LW1 = "Ken Hodge";
				PlayerDatabase.P1LW2 = "Brad Marchand";
				PlayerDatabase.P1LW3 = "Fred Stanfield";
				PlayerDatabase.P1LW4 = "Sergei Samsonov";
				PlayerDatabase.P1C1 = "Phil Esposito";
				PlayerDatabase.P1C2 = "Patrice Bergeron";
				PlayerDatabase.P1C3 = "Peter McNab";
				PlayerDatabase.P1C4 = "David Krejci";
				PlayerDatabase.P1RW1 = "Cam Neely";
				PlayerDatabase.P1RW2 = "Rick Middleton";
				PlayerDatabase.P1RW3 = "Woody Dumart";
				PlayerDatabase.P1RW4 = "Wayne Cashman";
				PlayerDatabase.P1LD1 = "Raymond Bourque";
				PlayerDatabase.P1LD2 = "Brad Park";
				PlayerDatabase.P1LD3 = "Zdeno Chara";
				PlayerDatabase.P1RD1 = "Bobby Orr";
				PlayerDatabase.P1RD2 = "Dit Clapper";
				PlayerDatabase.P1RD3 = "Mike OConnell";
				PlayerDatabase.P1G = "Tuukka Rask";
                PlayerDatabase.P1PPLW = "Ken Hodge";
                PlayerDatabase.P1PPC = "Phil Esposito";
                PlayerDatabase.P1PPRW = "Cam Neely";
                PlayerDatabase.P1PPLD = "Raymond Bourque";
                PlayerDatabase.P1PPRD = "Patrice Bergeron";
                PlayerDatabase.P1PKLW = "Ken Hodge";
                PlayerDatabase.P1PKRW = "Phil Esposito";
                PlayerDatabase.P1PKLD = "Raymond Bourque";
                PlayerDatabase.P1PKRD = "Bobby Orr";
                PlayerDatabase.P1PKExW = "Cam Neely";
                PlayerDatabase.P1PKExD = "Brad Park";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				PlayerDatabase.P1LW1 = "Rick Martin";
				PlayerDatabase.P1LW2 = "Don Luce";
				PlayerDatabase.P1LW3 = "Dave Andreychuk";
				PlayerDatabase.P1LW4 = "Jochen Hecht";
				PlayerDatabase.P1C1 = "Pat LaFontaine";
				PlayerDatabase.P1C2 = "Rene Robert";
				PlayerDatabase.P1C3 = "Gilbert Perreault";
				PlayerDatabase.P1C4 = "Derek Roy";
				PlayerDatabase.P1RW1 = "Danny Gare";
				PlayerDatabase.P1RW2 = "Alexander Mogilny";
				PlayerDatabase.P1RW3 = "Mike Foligno";
				PlayerDatabase.P1RW4 = "Jason Pominville";
				PlayerDatabase.P1LD1 = "John VanBoxmeer";
				PlayerDatabase.P1LD2 = "Phil Housley";
				PlayerDatabase.P1LD3 = "Alexei Zhitnik";
				PlayerDatabase.P1RD1 = "Doug Bodger";
				PlayerDatabase.P1RD2 = "Jerry Korab";
				PlayerDatabase.P1RD3 = "Bill Hajt";
				PlayerDatabase.P1G = "Dominik Hasek";
                PlayerDatabase.P1PPLW = "Rick Martin";
                PlayerDatabase.P1PPC = "Pat LaFontaine";
                PlayerDatabase.P1PPRW = "Danny Gare";
                PlayerDatabase.P1PPLD = "Rene Robert";
                PlayerDatabase.P1PPRD = "Alexander Mogilny";
                PlayerDatabase.P1PKLW = "Don Luce";
                PlayerDatabase.P1PKRW = "Danny Gare";
                PlayerDatabase.P1PKLD = "John VanBoxmeer";
                PlayerDatabase.P1PKRD = "Bill Hajt";
                PlayerDatabase.P1PKExW = "Mike Foligno";
                PlayerDatabase.P1PKExD = "Phil Housley";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
                PlayerDatabase.P1LW1 = "Gary Roberts";
                PlayerDatabase.P1LW2 = "Hakan Loob";
                PlayerDatabase.P1LW3 = "Johnny Gaudreau";
                PlayerDatabase.P1LW4 = "Matthew Tkachuk";
                PlayerDatabase.P1C1 = "Joe Nieuwendyk";
                PlayerDatabase.P1C2 = "Mikael Backlund";
                PlayerDatabase.P1C3 = "Sean Monahan";
                PlayerDatabase.P1C4 = "Kent Nilsson";
                PlayerDatabase.P1RW1 = "Theo Fleury";
                PlayerDatabase.P1RW2 = "Jarome Iginla";
                PlayerDatabase.P1RW3 = "Joe Mullen";
                PlayerDatabase.P1RW4 = "Lanny McDonald";
                PlayerDatabase.P1LD1 = "Al MacInnis";
                PlayerDatabase.P1LD2 = "Mark Giordano";
                PlayerDatabase.P1LD3 = "Phil Housley";
                PlayerDatabase.P1RD1 = "Dion Phaneuf";
                PlayerDatabase.P1RD2 = "Gary Suter";
                PlayerDatabase.P1RD3 = "Jamie Macoun";
                PlayerDatabase.P1G = "Mike Vernon";
                PlayerDatabase.P1PPLW = "Gary Roberts";
                PlayerDatabase.P1PPC = "Joe Nieuwendyk";
                PlayerDatabase.P1PPRW = "Theo Fleury";
                PlayerDatabase.P1PPLD = "Al MacInnis";
                PlayerDatabase.P1PPRD = "Jarome Iginla";
                PlayerDatabase.P1PKLW = "Gary Roberts";
                PlayerDatabase.P1PKRW = "Joe Mullen";
                PlayerDatabase.P1PKLD = "Al MacInnis";
                PlayerDatabase.P1PKRD = "Jamie Macoun";
                PlayerDatabase.P1PKExW = "Joe Nieuwendyk";
                PlayerDatabase.P1PKExD = "Gary Suter";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
                PlayerDatabase.P1LW1 = "Jeff Skinner";
                PlayerDatabase.P1LW2 = "Erik Cole";
                PlayerDatabase.P1LW3 = "Chad Larose";
                PlayerDatabase.P1LW4 = "Ray Whitney";
                PlayerDatabase.P1C1 = "Eric Staal";
                PlayerDatabase.P1C2 = "Sebastian Aho";
                PlayerDatabase.P1C3 = "Rod BrindAmour";
                PlayerDatabase.P1C4 = "Ron Francis";
                PlayerDatabase.P1RW1 = "Andrei Svechnikov";
                PlayerDatabase.P1RW2 = "Sami Kapanen";
                PlayerDatabase.P1RW3 = "Jeff ONeill";
                PlayerDatabase.P1RW4 = "Justin Williams";
                PlayerDatabase.P1LD1 = "Sean Hill";
                PlayerDatabase.P1LD2 = "Joe Corvo";
                PlayerDatabase.P1LD3 = "Justin Faulk";
                PlayerDatabase.P1RD1 = "Dougie Hamilton";
                PlayerDatabase.P1RD2 = "Joni Pitkanen";
                PlayerDatabase.P1RD3 = "Brett Pesce";
                PlayerDatabase.P1G = "Kevin Weekes";
                PlayerDatabase.P1PPLW = "Jeff Skinner";
                PlayerDatabase.P1PPC = "Eric Staal";
                PlayerDatabase.P1PPRW = "Andrei Svechnikov";
                PlayerDatabase.P1PPLD = "Sebastian Aho";
                PlayerDatabase.P1PPRD = "Dougie Hamilton";
                PlayerDatabase.P1PKLW = "Sebastian Aho";
                PlayerDatabase.P1PKRW = "Andrei Svechnikov";
                PlayerDatabase.P1PKLD = "Dougie Hamilton";
                PlayerDatabase.P1PKRD = "Brett Pesce";
                PlayerDatabase.P1PKExW = "Erik Cole";
                PlayerDatabase.P1PKExD = "Sean Hill";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
                PlayerDatabase.P1LW1 = "Rick Nash";
                PlayerDatabase.P1LW2 = "Geoff Sanderson";
                PlayerDatabase.P1LW3 = "Nikolai Zherdev";
                PlayerDatabase.P1LW4 = "Nick Foligno";
                PlayerDatabase.P1C1 = "Boone Jenner";
                PlayerDatabase.P1C2 = "RJ Umberger";
                PlayerDatabase.P1C3 = "Brandon Dubinsky";
                PlayerDatabase.P1C4 = "Alexander Wennberg";
                PlayerDatabase.P1RW1 = "Cam Atkinson";
                PlayerDatabase.P1RW2 = "Artemi Panarin";
                PlayerDatabase.P1RW3 = "Oliver Bjorkstrand";
                PlayerDatabase.P1RW4 = "Jason Chimera";
                PlayerDatabase.P1LD1 = "Seth Jones";
                PlayerDatabase.P1LD2 = "James Wisniewski";
                PlayerDatabase.P1LD3 = "Ron Hainsey";
                PlayerDatabase.P1RD1 = "Zach Werenski";
                PlayerDatabase.P1RD2 = "Ryan Murray";
                PlayerDatabase.P1RD3 = "David Savard";
                PlayerDatabase.P1G = "Sergei Bobrovsky";
                PlayerDatabase.P1PPLW = "Rick Nash";
                PlayerDatabase.P1PPC = "Boone Jenner";
                PlayerDatabase.P1PPRW = "Cam Atkinson";
                PlayerDatabase.P1PPLD = "Seth Jones";
                PlayerDatabase.P1PPRD = "Geoff Sanderson";
                PlayerDatabase.P1PKLW = "Nick Foligno";
                PlayerDatabase.P1PKRW = "Artemi Panarin";
                PlayerDatabase.P1PKLD = "Seth Jones";
                PlayerDatabase.P1PKRD = "Zach Werenski";
                PlayerDatabase.P1PKExW = "Brandon Dubinsky";
                PlayerDatabase.P1PKExD = "Ryan Murray";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
                PlayerDatabase.P1LW1 = "Bobby Hull";
                PlayerDatabase.P1LW2 = "Doug Bentley";
                PlayerDatabase.P1LW3 = "Patrick Sharp";
                PlayerDatabase.P1LW4 = "Eric Daze";
                PlayerDatabase.P1C1 = "Stan Mikita";
                PlayerDatabase.P1C2 = "Pit Martin";
                PlayerDatabase.P1C3 = "Jeremy Roenick";
                PlayerDatabase.P1C4 = "Jonathan Toews";
                PlayerDatabase.P1RW1 = "Tony Amonte";
                PlayerDatabase.P1RW2 = "Patrick Kane";
                PlayerDatabase.P1RW3 = "Bill Mosienko";
                PlayerDatabase.P1RW4 = "Steve Larmer";
                PlayerDatabase.P1LD1 = "Doug Wilson";
                PlayerDatabase.P1LD2 = "Phil Russell";
                PlayerDatabase.P1LD3 = "Pierre Pilote";
                PlayerDatabase.P1RD1 = "Chris Chelios";
                PlayerDatabase.P1RD2 = "Duncan Keith";
                PlayerDatabase.P1RD3 = "Pat Stapleton";
                PlayerDatabase.P1G = "Tony Esposito";
                PlayerDatabase.P1PPLW = "Bobby Hull";
                PlayerDatabase.P1PPC = "Stan Mikita";
                PlayerDatabase.P1PPRW = "Tony Amonte";
                PlayerDatabase.P1PPLD = "Patrick Kane";
                PlayerDatabase.P1PPRD = "Chris Chelios";
                PlayerDatabase.P1PKLW = "Bobby Hull";
                PlayerDatabase.P1PKRW = "Stan Mikita";
                PlayerDatabase.P1PKLD = "Pierre Pilote";
                PlayerDatabase.P1PKRD = "Pat Stapleton";
                PlayerDatabase.P1PKExW = "Jonathan Toews";
                PlayerDatabase.P1PKExD = "Chris Chelios";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "COL") {
                PlayerDatabase.P1LW1 = "Nathan MacKinnon";
                PlayerDatabase.P1LW2 = "Valeri Kamensky";
                PlayerDatabase.P1LW3 = "Gabriel Landeskog";
                PlayerDatabase.P1LW4 = "Alex Tanguay";
                PlayerDatabase.P1C1 = "Joe Sakic";
                PlayerDatabase.P1C2 = "Peter Forsberg";
                PlayerDatabase.P1C3 = "Paul Stastny";
                PlayerDatabase.P1C4 = "Matt Duchene";
                PlayerDatabase.P1RW1 = "Claude Lemieux";
                PlayerDatabase.P1RW2 = "Adam Deadmarsh";
                PlayerDatabase.P1RW3 = "Milan Hejduk";
                PlayerDatabase.P1RW4 = "Andrew Brunette";
                PlayerDatabase.P1LD1 = "Cale Makar";
                PlayerDatabase.P1LD2 = "Sandis Ozolinsh";
                PlayerDatabase.P1LD3 = "Tyson Barrie";
                PlayerDatabase.P1RD1 = "Rob Blake";
                PlayerDatabase.P1RD2 = "Erik Johnson";
                PlayerDatabase.P1RD3 = "Brett Clark";
                PlayerDatabase.P1G = "Patrick Roy";
                PlayerDatabase.P1PPLW = "Nathan MacKinnon";
                PlayerDatabase.P1PPC = "Joe Sakic";
                PlayerDatabase.P1PPRW = "Claude Lemieux";
                PlayerDatabase.P1PPLD = "Cale Makar";
                PlayerDatabase.P1PPRD = "Peter Forsberg";
                PlayerDatabase.P1PKLW = "Joe Sakic";
                PlayerDatabase.P1PKRW = "Peter Forsberg";
                PlayerDatabase.P1PKLD = "Cale Makar";
                PlayerDatabase.P1PKRD = "Rob Blake";
                PlayerDatabase.P1PKExW = "Alex Tanguay";
                PlayerDatabase.P1PKExD = "Erik Johnson";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
                PlayerDatabase.P1LW1 = "Jere Lehtinen";
                PlayerDatabase.P1LW2 = "Jamie Benn";
                PlayerDatabase.P1LW3 = "Brett Hull";
                PlayerDatabase.P1LW4 = "Brenden Morrow";
                PlayerDatabase.P1C1 = "Tyler Seguin";
                PlayerDatabase.P1C2 = "Mike Modano";
                PlayerDatabase.P1C3 = "Joe Nieuwendyk";
                PlayerDatabase.P1C4 = "Mike Ribeiro";
                PlayerDatabase.P1RW1 = "Bill Guerin";
                PlayerDatabase.P1RW2 = "Loui Eriksson";
                PlayerDatabase.P1RW3 = "Alexander Radulov";
                PlayerDatabase.P1RW4 = "Jamie Langenbrunner";
                PlayerDatabase.P1LD1 = "John Klingberg";
                PlayerDatabase.P1LD2 = "Sergei Zubov";
                PlayerDatabase.P1LD3 = "Esa Lindell";
                PlayerDatabase.P1RD1 = "Philippe Boucher";
                PlayerDatabase.P1RD2 = "Derian Hatcher";
                PlayerDatabase.P1RD3 = "Trevor Daley";
                PlayerDatabase.P1G = "Marty Turco";
                PlayerDatabase.P1PPLW = "Jere Lehtinen";
                PlayerDatabase.P1PPC = "Mike Modano";
                PlayerDatabase.P1PPRW = "Bill Guerin";
                PlayerDatabase.P1PPLD = "Jamie Benn";
                PlayerDatabase.P1PPRD = "Tyler Seguin";
                PlayerDatabase.P1PKLW = "Jere Lehtinen";
                PlayerDatabase.P1PKRW = "Mike Modano";
                PlayerDatabase.P1PKLD = "Esa Lindell";
                PlayerDatabase.P1PKRD = "Derian Hatcher";
                PlayerDatabase.P1PKExW = "Brenden Morrow";
                PlayerDatabase.P1PKExD = "Philippe Boucher";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "DET") {
                PlayerDatabase.P1LW1 = "Brendan Shanahan";
                PlayerDatabase.P1LW2 = "Ted Lindsay";
                PlayerDatabase.P1LW3 = "Daniel Cleary";
                PlayerDatabase.P1LW4 = "John Ogrodnick";
                PlayerDatabase.P1C1 = "Steve Yzerman";
                PlayerDatabase.P1C2 = "Henrik Zetterberg";
                PlayerDatabase.P1C3 = "Pavel Datsyuk";
                PlayerDatabase.P1C4 = "Alex Delvecchio";
                PlayerDatabase.P1RW1 = "Sergei Fedorov";
                PlayerDatabase.P1RW2 = "Gordie Howe";
                PlayerDatabase.P1RW3 = "Mickey Redmond";
                PlayerDatabase.P1RW4 = "Tomas Holmstrom";
                PlayerDatabase.P1LD1 = "Nicklas Lidstrom";
                PlayerDatabase.P1LD2 = "Steve Chiasson";
                PlayerDatabase.P1LD3 = "William Huber";
                PlayerDatabase.P1RD1 = "Paul Coffey";
                PlayerDatabase.P1RD2 = "Reed Larson";
                PlayerDatabase.P1RD3 = "Brian Rafalski";
                PlayerDatabase.P1G = "Terry Sawchuk";
                PlayerDatabase.P1PPLW = "Brendan Shanahan";
                PlayerDatabase.P1PPC = "Steve Yzerman";
                PlayerDatabase.P1PPRW = "Sergei Fedorov";
                PlayerDatabase.P1PPLD = "Nicklas Lidstrom";
                PlayerDatabase.P1PPRD = "Gordie Howe";
                PlayerDatabase.P1PKLW = "Pavel Datsyuk";
                PlayerDatabase.P1PKRW = "Sergei Fedorov";
                PlayerDatabase.P1PKLD = "Nicklas Lidstrom";
                PlayerDatabase.P1PKRD = "Paul Coffey";
                PlayerDatabase.P1PKExW = "Gordie Howe";
                PlayerDatabase.P1PKExD = "Brian Rafalski";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
                PlayerDatabase.P1LW1 = "Connor McDavid";
                PlayerDatabase.P1LW2 = "Esa Tikkanen";
                PlayerDatabase.P1LW3 = "Taylor Hall";
                PlayerDatabase.P1LW4 = "Ryan Smyth";
                PlayerDatabase.P1C1 = "Wayne Gretzky";
                PlayerDatabase.P1C2 = "Mark Messier";
                PlayerDatabase.P1C3 = "Leon Draisaitl";
                PlayerDatabase.P1C4 = "Doug Weight";
                PlayerDatabase.P1RW1 = "Jari Kurri";
                PlayerDatabase.P1RW2 = "Glenn Anderson";
                PlayerDatabase.P1RW3 = "Jordan Eberle";
                PlayerDatabase.P1RW4 = "Sam Gagner";
                PlayerDatabase.P1LD1 = "Paul Coffey";
                PlayerDatabase.P1LD2 = "Charlie Huddy";
                PlayerDatabase.P1LD3 = "Boris Mironov";
                PlayerDatabase.P1RD1 = "Randy Gregg";
                PlayerDatabase.P1RD2 = "Darnell Nurse";
                PlayerDatabase.P1RD3 = "Steve Smith";
                PlayerDatabase.P1G = "Grant Fuhr";
                PlayerDatabase.P1PPLW = "Connor McDavid";
                PlayerDatabase.P1PPC = "Wayne Gretzky";
                PlayerDatabase.P1PPRW = "Jari Kurri";
                PlayerDatabase.P1PPLD = "Paul Coffey";
                PlayerDatabase.P1PPRD = "Mark Messier";
                PlayerDatabase.P1PKLW = "Wayne Gretzky";
                PlayerDatabase.P1PKRW = "Jari Kurri";
                PlayerDatabase.P1PKLD = "Paul Coffey";
                PlayerDatabase.P1PKRD = "Randy Gregg";
                PlayerDatabase.P1PKExW = "Mark Messier";
                PlayerDatabase.P1PKExD = "Charlie Huddy";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
                PlayerDatabase.P1LW1 = "David Booth";
                PlayerDatabase.P1LW2 = "Jonathan Huberdeau";
                PlayerDatabase.P1LW3 = "Ray Whitney";
                PlayerDatabase.P1LW4 = "Evgeny Dadonov";
                PlayerDatabase.P1C1 = "Aleksander Barkov";
                PlayerDatabase.P1C2 = "Olli Jokinen";
                PlayerDatabase.P1C3 = "Viktor Kozlov";
                PlayerDatabase.P1C4 = "Vincent Trocheck";
                PlayerDatabase.P1RW1 = "Pavel Bure";
                PlayerDatabase.P1RW2 = "Nathan Horton";
                PlayerDatabase.P1RW3 = "Radek Dvorak";
                PlayerDatabase.P1RW4 = "Scott Mellanby";
                PlayerDatabase.P1LD1 = "Bryan McCabe";
                PlayerDatabase.P1LD2 = "Keith Yandle";
                PlayerDatabase.P1LD3 = "Brian Campbell";
                PlayerDatabase.P1RD1 = "Aaron Ekblad";
                PlayerDatabase.P1RD2 = "Jay Bouwmeester";
                PlayerDatabase.P1RD3 = "Ed Jovanovski";
                PlayerDatabase.P1G = "Roberto Luongo";
                PlayerDatabase.P1PPLW = "David Booth";
                PlayerDatabase.P1PPC = "Aleksander Barkov";
                PlayerDatabase.P1PPRW = "Pavel Bure";
                PlayerDatabase.P1PPLD = "Olli Jokinen";
                PlayerDatabase.P1PPRD = "Aaron Ekblad";
                PlayerDatabase.P1PKLW = "Aleksander Barkov";
                PlayerDatabase.P1PKRW = "Pavel Bure";
                PlayerDatabase.P1PKLD = "Bryan McCabe";
                PlayerDatabase.P1PKRD = "Aaron Ekblad";
                PlayerDatabase.P1PKExW = "Ray Whitney";
                PlayerDatabase.P1PKExD = "Brian Campbell";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "HAR") {
                PlayerDatabase.P1LW1 = "Geoff Sanderson";
                PlayerDatabase.P1LW2 = "John Anderson";
                PlayerDatabase.P1LW3 = "Paul MacDermid";
                PlayerDatabase.P1LW4 = "Blaine Stoughton";
                PlayerDatabase.P1C1 = "Mike Rogers";
                PlayerDatabase.P1C2 = "Ron Francis";
                PlayerDatabase.P1C3 = "Andrew Cassels";
                PlayerDatabase.P1C4 = "Dean Evason";
                PlayerDatabase.P1RW1 = "Sylvain Turgeon";
                PlayerDatabase.P1RW2 = "Kevin Dineen";
                PlayerDatabase.P1RW3 = "Pat Verbeek";
                PlayerDatabase.P1RW4 = "Scott Young";
                PlayerDatabase.P1LD1 = "Ulf Samuelsson";
                PlayerDatabase.P1LD2 = "Al Sims";
                PlayerDatabase.P1LD3 = "Sylvain Cote";
                PlayerDatabase.P1RD1 = "Mark Howe";
                PlayerDatabase.P1RD2 = "Adam Burt";
                PlayerDatabase.P1RD3 = "Brad Shaw";
                PlayerDatabase.P1G = "Mike Liut";
                PlayerDatabase.P1PPLW = "Geoff Sanderson";
                PlayerDatabase.P1PPC = "Mike Rogers";
                PlayerDatabase.P1PPRW = "Sylvain Turgeon";
                PlayerDatabase.P1PPLD = "Ron Francis";
                PlayerDatabase.P1PPRD = "Kevin Dineen";
                PlayerDatabase.P1PKLW = "John Anderson";
                PlayerDatabase.P1PKRW = "Mike Rogers";
                PlayerDatabase.P1PKLD = "Ulf Samuelsson";
                PlayerDatabase.P1PKRD = "Mark Howe";
                PlayerDatabase.P1PKExW = "Paul MacDermid";
                PlayerDatabase.P1PKExD = "Sylvain Cote";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
                PlayerDatabase.P1LW1 = "Wayne Gretzky";
                PlayerDatabase.P1LW2 = "Charlie Simmer";
                PlayerDatabase.P1LW3 = "Alexander Frolov";
                PlayerDatabase.P1LW4 = "Luc Robitaille";
                PlayerDatabase.P1C1 = "Marcel Dionne";
                PlayerDatabase.P1C2 = "Anze Kopitar";
                PlayerDatabase.P1C3 = "Bernie Nicholls";
                PlayerDatabase.P1C4 = "Butch Goring";
                PlayerDatabase.P1RW1 = "Zigmund Palffy";
                PlayerDatabase.P1RW2 = "Dave Taylor";
                PlayerDatabase.P1RW3 = "Mike Murphy";
                PlayerDatabase.P1RW4 = "Jari Kurri";
                PlayerDatabase.P1LD1 = "Drew Doughty";
                PlayerDatabase.P1LD2 = "Steve Duchesne";
                PlayerDatabase.P1LD3 = "Jake Muzzin";
                PlayerDatabase.P1RD1 = "Rob Blake";
                PlayerDatabase.P1RD2 = "Larry Murphy";
                PlayerDatabase.P1RD3 = "Marty McSorley";
                PlayerDatabase.P1G = "Kelly Hrudey";
                PlayerDatabase.P1PPLW = "Wayne Gretzky";
                PlayerDatabase.P1PPC = "Marcel Dionne";
                PlayerDatabase.P1PPRW = "Zigmund Palffy";
                PlayerDatabase.P1PPLD = "Dave Taylor";
                PlayerDatabase.P1PPRD = "Rob Blake";
                PlayerDatabase.P1PKLW = "Charlie Simmer";
                PlayerDatabase.P1PKRW = "Zigmund Palffy";
                PlayerDatabase.P1PKLD = "Drew Doughty";
                PlayerDatabase.P1PKRD = "Marty McSorley";
                PlayerDatabase.P1PKExW = "Dave Taylor";
                PlayerDatabase.P1PKExD = "Steve Duchesne";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "MNS") {
                PlayerDatabase.P1LW1 = "Bill Goldsworthy";
                PlayerDatabase.P1LW2 = "Danny Grant";
                PlayerDatabase.P1LW3 = "Steve Payne";
                PlayerDatabase.P1LW4 = "JeanPaul Parise";
                PlayerDatabase.P1C1 = "Mike Modano";
                PlayerDatabase.P1C2 = "Jude Drouin";
                PlayerDatabase.P1C3 = "Neal Broten";
                PlayerDatabase.P1C4 = "Dave Gagner";
                PlayerDatabase.P1RW1 = "Brian Bellows";
                PlayerDatabase.P1RW2 = "Dino Ciccarelli";
                PlayerDatabase.P1RW3 = "Tom McCarthy";
                PlayerDatabase.P1RW4 = "Al MacAdam";
                PlayerDatabase.P1LD1 = "Barry Gibbs";
                PlayerDatabase.P1LD2 = "Craig Hartsburg";
                PlayerDatabase.P1LD3 = "Gordie Roberts";
                PlayerDatabase.P1RD1 = "Gary Sargent";
                PlayerDatabase.P1RD2 = "Brad Maxwell";
                PlayerDatabase.P1RD3 = "Mark Tinordi";
                PlayerDatabase.P1G = "Don Beaupre";
                PlayerDatabase.P1PPLW = "Bill Goldsworthy";
                PlayerDatabase.P1PPC = "Mike Modano";
                PlayerDatabase.P1PPRW = "Brian Bellows";
                PlayerDatabase.P1PPLD = "Danny Grant";
                PlayerDatabase.P1PPRD = "Dino Ciccarelli";
                PlayerDatabase.P1PKLW = "Danny Grant";
                PlayerDatabase.P1PKRW = "Neal Broten";
                PlayerDatabase.P1PKLD = "Gordie Roberts";
                PlayerDatabase.P1PKRD = "Gary Sargent";
                PlayerDatabase.P1PKExW = "Tom McCarthy";
                PlayerDatabase.P1PKExD = "Mark Tinordi";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "MNW") {
                PlayerDatabase.P1LW1 = "Marian Gaborik";
                PlayerDatabase.P1LW2 = "Zach Parise";
                PlayerDatabase.P1LW3 = "Cal Clutterbuck";
                PlayerDatabase.P1LW4 = "Marcus Foligno";
                PlayerDatabase.P1C1 = "Mikko Koivu";
                PlayerDatabase.P1C2 = "Mikael Granlund";
                PlayerDatabase.P1C3 = "Eric Staal";
                PlayerDatabase.P1C4 = "PierreMarc Bouchard";
                PlayerDatabase.P1RW1 = "Jason Pominville";
                PlayerDatabase.P1RW2 = "Jason Zucker";
                PlayerDatabase.P1RW3 = "Dany Heatley";
                PlayerDatabase.P1RW4 = "Charlie Coyle";
                PlayerDatabase.P1LD1 = "Matt Dumba";
                PlayerDatabase.P1LD2 = "Ryan Suter";
                PlayerDatabase.P1LD3 = "Filip Kuba";
                PlayerDatabase.P1RD1 = "Jonas Brodin";
                PlayerDatabase.P1RD2 = "Jared Spurgeon";
                PlayerDatabase.P1RD3 = "Brent Burns";
                PlayerDatabase.P1G = "Dwayne Roloson";
                PlayerDatabase.P1PPLW = "Marian Gaborik";
                PlayerDatabase.P1PPC = "Mikko Koivu";
                PlayerDatabase.P1PPRW = "Jason Pominville";
                PlayerDatabase.P1PPLD = "Matt Dumba";
                PlayerDatabase.P1PPRD = "Zach Parise";
                PlayerDatabase.P1PKLW = "Marian Gaborik";
                PlayerDatabase.P1PKRW = "Mikko Koivu";
                PlayerDatabase.P1PKLD = "Matt Dumba";
                PlayerDatabase.P1PKRD = "Jared Spurgeon";
                PlayerDatabase.P1PKExW = "Eric Staal";
                PlayerDatabase.P1PKExD = "Ryan Suter";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "MON") {
                PlayerDatabase.P1LW1 = "Jacques Lemaire";
                PlayerDatabase.P1LW2 = "Yvan Cournoyer";
                PlayerDatabase.P1LW3 = "Toe Blake";
                PlayerDatabase.P1LW4 = "Steve Shutt";
                PlayerDatabase.P1C1 = "Jean Beliveau";
                PlayerDatabase.P1C2 = "Henri Richard";
                PlayerDatabase.P1C3 = "Elmer Lach";
                PlayerDatabase.P1C4 = "Saku Koivu";
                PlayerDatabase.P1RW1 = "Guy Lafleur";
                PlayerDatabase.P1RW2 = "Maurice Richard";
                PlayerDatabase.P1RW3 = "Bernard Geoffrion";
                PlayerDatabase.P1RW4 = "Pete Mahovlich";
                PlayerDatabase.P1LD1 = "Chris Chelios";
                PlayerDatabase.P1LD2 = "PK Subban";
                PlayerDatabase.P1LD3 = "Larry Robinson";
                PlayerDatabase.P1RD1 = "Guy Lapointe";
                PlayerDatabase.P1RD2 = "Doug Harvey";
                PlayerDatabase.P1RD3 = "Jacques Laperriere";
                PlayerDatabase.P1G = "Jacques Plante";
                PlayerDatabase.P1PPLW = "Jacques Lemaire";
                PlayerDatabase.P1PPC = "Jean Beliveau";
                PlayerDatabase.P1PPRW = "Guy Lafleur";
                PlayerDatabase.P1PPLD = "Yvan Cournoyer";
                PlayerDatabase.P1PPRD = "Maurice Richard";
                PlayerDatabase.P1PKLW = "Jacques Lemaire";
                PlayerDatabase.P1PKRW = "Guy Lafleur";
                PlayerDatabase.P1PKLD = "Larry Robinson";
                PlayerDatabase.P1PKRD = "Guy Lapointe";
                PlayerDatabase.P1PKExW = "Maurice Richard";
                PlayerDatabase.P1PKExD = "Jacques Laperriere";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
                PlayerDatabase.P1LW1 = "Patric Hornqvist";
                PlayerDatabase.P1LW2 = "Filip Forsberg";
                PlayerDatabase.P1LW3 = "Steve Sullivan";
                PlayerDatabase.P1LW4 = "Martin Erat";
                PlayerDatabase.P1C1 = "David Legwand";
                PlayerDatabase.P1C2 = "Craig Smith";
                PlayerDatabase.P1C3 = "Mike Fisher";
                PlayerDatabase.P1C4 = "Ryan Johansen";
                PlayerDatabase.P1RW1 = "James Neal";
                PlayerDatabase.P1RW2 = "Viktor Arvidsson";
                PlayerDatabase.P1RW3 = "JeanPierre Dumont";
                PlayerDatabase.P1RW4 = "Scott Walker";
                PlayerDatabase.P1LD1 = "Roman Josi";
                PlayerDatabase.P1LD2 = "PK Subban";
                PlayerDatabase.P1LD3 = "Mattias Ekholm";
                PlayerDatabase.P1RD1 = "Ryan Ellis";
                PlayerDatabase.P1RD2 = "Shea Weber";
                PlayerDatabase.P1RD3 = "Dan Hamhuis";
                PlayerDatabase.P1G = "Pekka Rinne";
                PlayerDatabase.P1PPLW = "Patric Hornqvist";
                PlayerDatabase.P1PPC = "David Legwand";
                PlayerDatabase.P1PPRW = "James Neal";
                PlayerDatabase.P1PPLD = "Roman Josi";
                PlayerDatabase.P1PPRD = "Filip Forsberg";
                PlayerDatabase.P1PKLW = "David Legwand";
                PlayerDatabase.P1PKRW = "James Neal";
                PlayerDatabase.P1PKLD = "Roman Josi";
                PlayerDatabase.P1PKRD = "Ryan Ellis";
                PlayerDatabase.P1PKExW = "Martin Erat";
                PlayerDatabase.P1PKExD = "Shea Weber";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
                PlayerDatabase.P1LW1 = "Zach Parise";
                PlayerDatabase.P1LW2 = "Patrik Elias";
                PlayerDatabase.P1LW3 = "Jamie Langenbrunner";
                PlayerDatabase.P1LW4 = "Brian Rolston";
                PlayerDatabase.P1C1 = "Bobby Holik";
                PlayerDatabase.P1C2 = "Scott Gomez";
                PlayerDatabase.P1C3 = "Aaron Broten";
                PlayerDatabase.P1C4 = "Kirk Muller";
                PlayerDatabase.P1RW1 = "Stephane Richer";
                PlayerDatabase.P1RW2 = "Petr Sykora";
                PlayerDatabase.P1RW3 = "John MacLean";
                PlayerDatabase.P1RW4 = "Randy McKay";
                PlayerDatabase.P1LD1 = "Bruce Driver";
                PlayerDatabase.P1LD2 = "Scott Niedermayer";
                PlayerDatabase.P1LD3 = "Tommy Albelin";
                PlayerDatabase.P1RD1 = "Scott Stevens";
                PlayerDatabase.P1RD2 = "Brian Rafalski";
                PlayerDatabase.P1RD3 = "Paul Martin";
                PlayerDatabase.P1G = "Martin Brodeur";
                PlayerDatabase.P1PPLW = "Zach Parise";
                PlayerDatabase.P1PPC = "Bobby Holik";
                PlayerDatabase.P1PPRW = "Stephane Richer";
                PlayerDatabase.P1PPLD = "Scott Niedermayer";
                PlayerDatabase.P1PPRD = "Scott Stevens";
                PlayerDatabase.P1PKLW = "Bobby Holik";
                PlayerDatabase.P1PKRW = "Petr Sykora";
                PlayerDatabase.P1PKLD = "Scott Niedermayer";
                PlayerDatabase.P1PKRD = "Scott Stevens";
                PlayerDatabase.P1PKExW = "Randy McKay";
                PlayerDatabase.P1PKExD = "Brian Rafalski";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
                PlayerDatabase.P1LW1 = "Clark Gillies";
                PlayerDatabase.P1LW2 = "Jason Blake";
                PlayerDatabase.P1LW3 = "John Tonelli";
                PlayerDatabase.P1LW4 = "Derek King";
                PlayerDatabase.P1C1 = "Bryan Trottier";
                PlayerDatabase.P1C2 = "John Tavares";
                PlayerDatabase.P1C3 = "Brent Sutter";
                PlayerDatabase.P1C4 = "Bob Bourne";
                PlayerDatabase.P1RW1 = "Mike Bossy";
                PlayerDatabase.P1RW2 = "Pat LaFontaine";
                PlayerDatabase.P1RW3 = "Billy Harris";
                PlayerDatabase.P1RW4 = "Anders Lee";
                PlayerDatabase.P1LD1 = "Denis Potvin";
                PlayerDatabase.P1LD2 = "Roman Hamrlik";
                PlayerDatabase.P1LD3 = "Tomas Jonsson";
                PlayerDatabase.P1RD1 = "Stefan Persson";
                PlayerDatabase.P1RD2 = "Travis Hamonic";
                PlayerDatabase.P1RD3 = "Nick Leddy";
                PlayerDatabase.P1G = "Billy Smith";
                PlayerDatabase.P1PPLW = "Clark Gillies";
                PlayerDatabase.P1PPC = "Bryan Trottier";
                PlayerDatabase.P1PPRW = "Mike Bossy";
                PlayerDatabase.P1PPLD = "Denis Potvin";
                PlayerDatabase.P1PPRD = "Pat LaFontaine";
                PlayerDatabase.P1PKLW = "Bryan Trottier";
                PlayerDatabase.P1PKRW = "Mike Bossy";
                PlayerDatabase.P1PKLD = "Denis Potvin";
                PlayerDatabase.P1PKRD = "Stefan Persson";
                PlayerDatabase.P1PKExW = "Clark Gillies";
                PlayerDatabase.P1PKExD = "Roman Hamrlik";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
                PlayerDatabase.P1LW1 = "Adam Graves";
                PlayerDatabase.P1LW2 = "Vic Hadfield";
                PlayerDatabase.P1LW3 = "Mark Messier";
                PlayerDatabase.P1LW4 = "Don Maloney";
                PlayerDatabase.P1C1 = "Walt Tkaczuk";
                PlayerDatabase.P1C2 = "Frank Boucher";
                PlayerDatabase.P1C3 = "Andy Bathgate";
                PlayerDatabase.P1C4 = "Jean Ratelle";
                PlayerDatabase.P1RW1 = "Bill Cook";
                PlayerDatabase.P1RW2 = "Tomas Sandstrom";
                PlayerDatabase.P1RW3 = "Rod Gilbert";
                PlayerDatabase.P1RW4 = "Anders Hedberg";
                PlayerDatabase.P1LD1 = "Reijo Ruotsalainen";
                PlayerDatabase.P1LD2 = "Brian Leetch";
                PlayerDatabase.P1LD3 = "Jim Neilson";
                PlayerDatabase.P1RD1 = "Brad Park";
                PlayerDatabase.P1RD2 = "Neil Colville";
                PlayerDatabase.P1RD3 = "Dave Maloney";
                PlayerDatabase.P1G = "Henrik Lundqvist";
                PlayerDatabase.P1PPLW = "Adam Graves";
                PlayerDatabase.P1PPC = "Walt Tkaczuk";
                PlayerDatabase.P1PPRW = "Bill Cook";
                PlayerDatabase.P1PPLD = "Brian Leetch";
                PlayerDatabase.P1PPRD = "Mark Messier";
                PlayerDatabase.P1PKLW = "Adam Graves";
                PlayerDatabase.P1PKRW = "Walt Tkaczuk";
                PlayerDatabase.P1PKLD = "Reijo Ruotsalainen";
                PlayerDatabase.P1PKRD = "Brad Park";
                PlayerDatabase.P1PKExW = "Mark Messier";
                PlayerDatabase.P1PKExD = "Brian Leetch";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
                PlayerDatabase.P1LW1 = "Dany Heatley";
                PlayerDatabase.P1LW2 = "Mark Stone";
                PlayerDatabase.P1LW3 = "Mike Hoffman";
                PlayerDatabase.P1LW4 = "Shawn McEachern";
                PlayerDatabase.P1C1 = "Alexei Yashin";
                PlayerDatabase.P1C2 = "Mike Fisher";
                PlayerDatabase.P1C3 = "Jason Spezza";
                PlayerDatabase.P1C4 = "Kyle Turris";
                PlayerDatabase.P1RW1 = "Daniel Alfredsson";
                PlayerDatabase.P1RW2 = "Martin Havlat";
                PlayerDatabase.P1RW3 = "Marian Hossa";
                PlayerDatabase.P1RW4 = "Milan Michalek";
                PlayerDatabase.P1LD1 = "Erik Karlsson";
                PlayerDatabase.P1LD2 = "Andrej Meszaros";
                PlayerDatabase.P1LD3 = "Chris Phillips";
                PlayerDatabase.P1RD1 = "Zdeno Chara";
                PlayerDatabase.P1RD2 = "Wade Redden";
                PlayerDatabase.P1RD3 = "Thomas Chabot";
                PlayerDatabase.P1G = "Craig Anderson";
                PlayerDatabase.P1PPLW = "Dany Heatley";
                PlayerDatabase.P1PPC = "Alexei Yashin";
                PlayerDatabase.P1PPRW = "Daniel Alfredsson";
                PlayerDatabase.P1PPLD = "Erik Karlsson";
                PlayerDatabase.P1PPRD = "Martin Havlat";
                PlayerDatabase.P1PKLW = "Dany Heatley";
                PlayerDatabase.P1PKRW = "Mark Stone";
                PlayerDatabase.P1PKLD = "Zdeno Chara";
                PlayerDatabase.P1PKRD = "Wade Redden";
                PlayerDatabase.P1PKExW = "Jason Spezza";
                PlayerDatabase.P1PKExD = "Andrej Meszaros";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
                PlayerDatabase.P1LW1 = "Brian Propp";
                PlayerDatabase.P1LW2 = "Bill Barber";
                PlayerDatabase.P1LW3 = "Rick MacLeish";
                PlayerDatabase.P1LW4 = "Simon Gagne";
                PlayerDatabase.P1C1 = "Eric Lindros";
                PlayerDatabase.P1C2 = "Bobby Clarke";
                PlayerDatabase.P1C3 = "Claude Giroux";
                PlayerDatabase.P1C4 = "Sean Couturier";
                PlayerDatabase.P1RW1 = "John LeClair";
                PlayerDatabase.P1RW2 = "Reggie Leach";
                PlayerDatabase.P1RW3 = "Tim Kerr";
                PlayerDatabase.P1RW4 = "Mark Recchi";
                PlayerDatabase.P1LD1 = "Mark Howe";
                PlayerDatabase.P1LD2 = "Bob Dailey";
                PlayerDatabase.P1LD3 = "Behn Wilson";
                PlayerDatabase.P1RD1 = "Tom Bladon";
                PlayerDatabase.P1RD2 = "Eric Desjardins";
                PlayerDatabase.P1RD3 = "Brad McCrimmon";
                PlayerDatabase.P1G = "Bernie Parent";
                PlayerDatabase.P1PPLW = "Brian Propp";
                PlayerDatabase.P1PPC = "Eric Lindros";
                PlayerDatabase.P1PPRW = "John LeClair";
                PlayerDatabase.P1PPLD = "Bill Barber";
                PlayerDatabase.P1PPRD = "Reggie Leach";
                PlayerDatabase.P1PKLW = "Eric Lindros";
                PlayerDatabase.P1PKRW = "Bobby Clarke";
                PlayerDatabase.P1PKLD = "Mark Howe";
                PlayerDatabase.P1PKRD = "Brad McCrimmon";
                PlayerDatabase.P1PKExW = "Bill Barber";
                PlayerDatabase.P1PKExD = "Bob Dailey";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "PHO") {
                PlayerDatabase.P1LW1 = "Keith Tkachuk";
                PlayerDatabase.P1LW2 = "Ladislav Nagy";
                PlayerDatabase.P1LW3 = "Clayton Keller";
                PlayerDatabase.P1LW4 = "Dallas Drake";
                PlayerDatabase.P1C1 = "Daymond Langkow";
                PlayerDatabase.P1C2 = "Shane Doan";
                PlayerDatabase.P1C3 = "Martin Hanzal";
                PlayerDatabase.P1C4 = "Jeremy Roenick";
                PlayerDatabase.P1RW1 = "Radim Vrbata";
                PlayerDatabase.P1RW2 = "Rick Tocchet";
                PlayerDatabase.P1RW3 = "Mike Johnson";
                PlayerDatabase.P1RW4 = "Mikkel Boedker";
                PlayerDatabase.P1LD1 = "Oliver EkmanLarsson";
                PlayerDatabase.P1LD2 = "Teppo Numminen";
                PlayerDatabase.P1LD3 = "Oleg Tverdovsky";
                PlayerDatabase.P1RD1 = "Ed Jovanovski";
                PlayerDatabase.P1RD2 = "Keith Yandle";
                PlayerDatabase.P1RD3 = "Jakob Chychrun";
                PlayerDatabase.P1G = "Ilya Bryzgalov";
                PlayerDatabase.P1PPLW = "Keith Tkachuk";
                PlayerDatabase.P1PPC = "Daymond Langkow";
                PlayerDatabase.P1PPRW = "Radim Vrbata";
                PlayerDatabase.P1PPLD = "Oliver EkmanLarsson";
                PlayerDatabase.P1PPRD = "Ladislav Nagy";
                PlayerDatabase.P1PKLW = "Keith Tkachuk";
                PlayerDatabase.P1PKRW = "Radim Vrbata";
                PlayerDatabase.P1PKLD = "Teppo Numminen";
                PlayerDatabase.P1PKRD = "Oleg Tverdovsky";
                PlayerDatabase.P1PKExW = "Ladislav Nagy";
                PlayerDatabase.P1PKExD = "Keith Yandle";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
                PlayerDatabase.P1LW1 = "Jean Pronovost";
                PlayerDatabase.P1LW2 = "Evgeni Malkin";
                PlayerDatabase.P1LW3 = "Pascal Dupuis";
                PlayerDatabase.P1LW4 = "Chris Kunitz";
                PlayerDatabase.P1C1 = "Mario Lemieux";
                PlayerDatabase.P1C2 = "Sidney Crosby";
                PlayerDatabase.P1C3 = "Syl Apps";
                PlayerDatabase.P1C4 = "Ron Francis";
                PlayerDatabase.P1RW1 = "Jaromir Jagr";
                PlayerDatabase.P1RW2 = "Alexei Kovalev";
                PlayerDatabase.P1RW3 = "Rick Kehoe";
                PlayerDatabase.P1RW4 = "Mark Recchi";
                PlayerDatabase.P1LD1 = "Larry Murphy";
                PlayerDatabase.P1LD2 = "Kris Letang";
                PlayerDatabase.P1LD3 = "Ron Stackhouse";
                PlayerDatabase.P1RD1 = "Paul Coffey";
                PlayerDatabase.P1RD2 = "Kevin Hatcher";
                PlayerDatabase.P1RD3 = "Doug Bodger";
                PlayerDatabase.P1G = "MarcAndre Fleury";
                PlayerDatabase.P1PPLW = "Jean Pronovost";
                PlayerDatabase.P1PPC = "Mario Lemieux";
                PlayerDatabase.P1PPRW = "Jaromir Jagr";
                PlayerDatabase.P1PPLD = "Larry Murphy";
                PlayerDatabase.P1PPRD = "Sidney Crosby";
                PlayerDatabase.P1PKLW = "Pascal Dupuis";
                PlayerDatabase.P1PKRW = "Jaromir Jagr";
                PlayerDatabase.P1PKLD = "Larry Murphy";
                PlayerDatabase.P1PKRD = "Kevin Hatcher";
                PlayerDatabase.P1PKExW = "Syl Apps";
                PlayerDatabase.P1PKExD = "Kris Letang";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "QUE") {
                PlayerDatabase.P1LW1 = "Michel Goulet";
                PlayerDatabase.P1LW2 = "Wilf Paiement";
                PlayerDatabase.P1LW3 = "Anton Stastny";
                PlayerDatabase.P1LW4 = "Marc Tardif";
                PlayerDatabase.P1C1 = "Joe Sakic";
                PlayerDatabase.P1C2 = "Jacques Richard";
                PlayerDatabase.P1C3 = "Peter Stastny";
                PlayerDatabase.P1C4 = "Mats Sundin";
                PlayerDatabase.P1RW1 = "Real Cloutier";
                PlayerDatabase.P1RW2 = "Owen Nolan";
                PlayerDatabase.P1RW3 = "Marian Stastny";
                PlayerDatabase.P1RW4 = "Dale Hunter";
                PlayerDatabase.P1LD1 = "Pierre Lacroix";
                PlayerDatabase.P1LD2 = "Mario Marois";
                PlayerDatabase.P1LD3 = "Randy Moller";
                PlayerDatabase.P1RD1 = "Jeff Brown";
                PlayerDatabase.P1RD2 = "Normand Rochefort";
                PlayerDatabase.P1RD3 = "Dave Pichette";
                PlayerDatabase.P1G = "Dan Bouchard";
                PlayerDatabase.P1PPLW = "Michel Goulet";
                PlayerDatabase.P1PPC = "Joe Sakic";
                PlayerDatabase.P1PPRW = "Real Cloutier";
                PlayerDatabase.P1PPLD = "Jacques Richard";
                PlayerDatabase.P1PPRD = "Owen Nolan";
                PlayerDatabase.P1PKLW = "Wilf Paiement";
                PlayerDatabase.P1PKRW = "Dale Hunter";
                PlayerDatabase.P1PKLD = "Mario Marois";
                PlayerDatabase.P1PKRD = "Normand Rochefort";
                PlayerDatabase.P1PKExW = "Michel Goulet";
                PlayerDatabase.P1PKExD = "Randy Moller";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
                PlayerDatabase.P1LW1 = "Milan Michalek";
                PlayerDatabase.P1LW2 = "Ryan Clowe";
                PlayerDatabase.P1LW3 = "Jeff Friesen";
                PlayerDatabase.P1LW4 = "Patrick Marleau";
                PlayerDatabase.P1C1 = "Joe Pavelski";
                PlayerDatabase.P1C2 = "Logan Couture";
                PlayerDatabase.P1C3 = "Vincent Damphousse";
                PlayerDatabase.P1C4 = "Joe Thornton";
                PlayerDatabase.P1RW1 = "Jonathan Cheechoo";
                PlayerDatabase.P1RW2 = "Marco Sturm";
                PlayerDatabase.P1RW3 = "Tomas Hertl";
                PlayerDatabase.P1RW4 = "Owen Nolan";
                PlayerDatabase.P1LD1 = "Brent Burns";
                PlayerDatabase.P1LD2 = "Dan Boyle";
                PlayerDatabase.P1LD3 = "Christian Ehrhoff";
                PlayerDatabase.P1RD1 = "Erik Karlsson";
                PlayerDatabase.P1RD2 = "Justin Braun";
                PlayerDatabase.P1RD3 = "Scott Hannan";
                PlayerDatabase.P1G = "Evgeni Nabokov";
                PlayerDatabase.P1PPLW = "Milan Michalek";
                PlayerDatabase.P1PPC = "Joe Pavelski";
                PlayerDatabase.P1PPRW = "Jonathan Cheechoo";
                PlayerDatabase.P1PPLD = "Brent Burns";
                PlayerDatabase.P1PPRD = "Erik Karlsson";
                PlayerDatabase.P1PKLW = "Milan Michalek";
                PlayerDatabase.P1PKRW = "Vincent Damphousse";
                PlayerDatabase.P1PKLD = "Brent Burns";
                PlayerDatabase.P1PKRD = "Justin Braun";
                PlayerDatabase.P1PKExW = "Joe Thornton";
                PlayerDatabase.P1PKExD = "Scott Hannan";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "STL") {
                PlayerDatabase.P1LW1 = "Red Berenson";
                PlayerDatabase.P1LW2 = "David Perron";
                PlayerDatabase.P1LW3 = "Alexander Steen";
                PlayerDatabase.P1LW4 = "Keith Tkachuk";
                PlayerDatabase.P1C1 = "Pavol Demitra";
                PlayerDatabase.P1C2 = "Pierre Turgeon";
                PlayerDatabase.P1C3 = "Garry Unger";
                PlayerDatabase.P1C4 = "David Backes";
                PlayerDatabase.P1RW1 = "Vladimir Tarasenko";
                PlayerDatabase.P1RW2 = "TJ Oshie";
                PlayerDatabase.P1RW3 = "Brett Hull";
                PlayerDatabase.P1RW4 = "Wayne Babych";
                PlayerDatabase.P1LD1 = "Al MacInnis";
                PlayerDatabase.P1LD2 = "Chris Pronger";
                PlayerDatabase.P1LD3 = "Kevin Shattenkirk";
                PlayerDatabase.P1RD1 = "Rob Ramage";
                PlayerDatabase.P1RD2 = "Colton Parayko";
                PlayerDatabase.P1RD3 = "Alex Pietrangelo";
                PlayerDatabase.P1G = "Mike Liut";
                PlayerDatabase.P1PPLW = "Red Berenson";
                PlayerDatabase.P1PPC = "Pavol Demitra";
                PlayerDatabase.P1PPRW = "Vladimir Tarasenko";
                PlayerDatabase.P1PPLD = "Al MacInnis";
                PlayerDatabase.P1PPRD = "Pierre Turgeon";
                PlayerDatabase.P1PKLW = "Pavol Demitra";
                PlayerDatabase.P1PKRW = "Pierre Turgeon";
                PlayerDatabase.P1PKLD = "Al MacInnis";
                PlayerDatabase.P1PKRD = "Chris Pronger";
                PlayerDatabase.P1PKExW = "TJ Oshie";
                PlayerDatabase.P1PKExD = "Colton Parayko";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
                PlayerDatabase.P1LW1 = "Ondrej Palat";
                PlayerDatabase.P1LW2 = "Fredrik Modin";
                PlayerDatabase.P1LW3 = "Teddy Purcell";
                PlayerDatabase.P1LW4 = "Ryan Malone";
                PlayerDatabase.P1C1 = "Steven Stamkos";
                PlayerDatabase.P1C2 = "Vincent Lecavalier";
                PlayerDatabase.P1C3 = "Brad Richards";
                PlayerDatabase.P1C4 = "Tyler Johnson";
                PlayerDatabase.P1RW1 = "Nikita Kucherov";
                PlayerDatabase.P1RW2 = "Martin StLouis";
                PlayerDatabase.P1RW3 = "Vaclav Prospal";
                PlayerDatabase.P1RW4 = "Petr Klima";
                PlayerDatabase.P1LD1 = "Victor Hedman";
                PlayerDatabase.P1LD2 = "Anton Stralman";
                PlayerDatabase.P1LD3 = "Mikhail Sergachev";
                PlayerDatabase.P1RD1 = "Ryan McDonagh";
                PlayerDatabase.P1RD2 = "Shawn Chambers";
                PlayerDatabase.P1RD3 = "Dan Boyle";
                PlayerDatabase.P1G = "Andrei Vasilevskiy";
                PlayerDatabase.P1PPLW = "Ondrej Palat";
                PlayerDatabase.P1PPC = "Steven Stamkos";
                PlayerDatabase.P1PPRW = "Nikita Kucherov";
                PlayerDatabase.P1PPLD = "Victor Hedman";
                PlayerDatabase.P1PPRD = "Martin StLouis";
                PlayerDatabase.P1PKLW = "Ondrej Palat";
                PlayerDatabase.P1PKRW = "Nikita Kucherov";
                PlayerDatabase.P1PKLD = "Victor Hedman";
                PlayerDatabase.P1PKRD = "Ryan McDonagh";
                PlayerDatabase.P1PKExW = "Fredrik Modin";
                PlayerDatabase.P1PKExD = "Anton Stralman";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
                PlayerDatabase.P1LW1 = "Frank Mahovlich";
                PlayerDatabase.P1LW2 = "Bob Pulford";
                PlayerDatabase.P1LW3 = "John Anderson";
                PlayerDatabase.P1LW4 = "Wendel Clark";
                PlayerDatabase.P1C1 = "Mats Sundin";
                PlayerDatabase.P1C2 = "Dave Keon";
                PlayerDatabase.P1C3 = "Darryl Sittler";
                PlayerDatabase.P1C4 = "Ted Kennedy";
                PlayerDatabase.P1RW1 = "Lanny McDonald";
                PlayerDatabase.P1RW2 = "Rick Vaive";
                PlayerDatabase.P1RW3 = "Phil Kessel";
                PlayerDatabase.P1RW4 = "George Armstrong";
                PlayerDatabase.P1LD1 = "Red Kelly";
                PlayerDatabase.P1LD2 = "Borje Salming";
                PlayerDatabase.P1LD3 = "Tim Horton";
                PlayerDatabase.P1RD1 = "Ian Turnbull";
                PlayerDatabase.P1RD2 = "Bryan McCabe";
                PlayerDatabase.P1RD3 = "Morgan Rielly";
                PlayerDatabase.P1G = "Johnny Bower";
                PlayerDatabase.P1PPLW = "Frank Mahovlich";
                PlayerDatabase.P1PPC = "Mats Sundin";
                PlayerDatabase.P1PPRW = "Rick Vaive";
                PlayerDatabase.P1PPLD = "Lanny McDonald";
                PlayerDatabase.P1PPRD = "Phil Kessel";
                PlayerDatabase.P1PKLW = "Frank Mahovlich";
                PlayerDatabase.P1PKRW = "Lanny McDonald";
                PlayerDatabase.P1PKLD = "Tim Horton";
                PlayerDatabase.P1PKRD = "Ian Turnbull";
                PlayerDatabase.P1PKExW = "Mats Sundin";
                PlayerDatabase.P1PKExD = "Red Kelly";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
                PlayerDatabase.P1LW1 = "Todd Bertuzzi";
                PlayerDatabase.P1LW2 = "Daniel Sedin";
                PlayerDatabase.P1LW3 = "Markus Naslund";
                PlayerDatabase.P1LW4 = "Don Lever";
                PlayerDatabase.P1C1 = "Ryan Kesler";
                PlayerDatabase.P1C2 = "Henrik Sedin";
                PlayerDatabase.P1C3 = "Brendan Morrison";
                PlayerDatabase.P1C4 = "Trevor Linden";
                PlayerDatabase.P1RW1 = "Pavel Bure";
                PlayerDatabase.P1RW2 = "Stan Smyl";
                PlayerDatabase.P1RW3 = "Patrik Sundstrom";
                PlayerDatabase.P1RW4 = "Tony Tanti";
                PlayerDatabase.P1LD1 = "Alexander Edler";
                PlayerDatabase.P1LD2 = "Kevin Bieksa";
                PlayerDatabase.P1LD3 = "Jyrki Lumme";
                PlayerDatabase.P1RD1 = "Ed Jovanovski";
                PlayerDatabase.P1RD2 = "Rick Lanz";
                PlayerDatabase.P1RD3 = "Mattias Ohlund";
                PlayerDatabase.P1G = "Kirk McLean";
                PlayerDatabase.P1PPLW = "Todd Bertuzzi";
                PlayerDatabase.P1PPC = "Henrik Sedin";
                PlayerDatabase.P1PPRW = "Pavel Bure";
                PlayerDatabase.P1PPLD = "Alexander Edler";
                PlayerDatabase.P1PPRD = "Daniel Sedin";
                PlayerDatabase.P1PKLW = "Todd Bertuzzi";
                PlayerDatabase.P1PKRW = "Pavel Bure";
                PlayerDatabase.P1PKLD = "Kevin Bieksa";
                PlayerDatabase.P1PKRD = "Jyrki Lumme";
                PlayerDatabase.P1PKExW = "Markus Naslund";
                PlayerDatabase.P1PKExD = "Mattias Ohlund";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
                PlayerDatabase.P1LW1 = "Alexander Ovechkin";
                PlayerDatabase.P1LW2 = "Dave Christian";
                PlayerDatabase.P1LW3 = "Alexander Semin";
                PlayerDatabase.P1LW4 = "Steve Konowalchuk";
                PlayerDatabase.P1C1 = "Nicklas Backstrom";
                PlayerDatabase.P1C2 = "Adam Oates";
                PlayerDatabase.P1C3 = "Michal Pivonka";
                PlayerDatabase.P1C4 = "Mike Ridley";
                PlayerDatabase.P1RW1 = "Peter Bondra";
                PlayerDatabase.P1RW2 = "Mike Gartner";
                PlayerDatabase.P1RW3 = "TJ Oshie";
                PlayerDatabase.P1RW4 = "Dale Hunter";
                PlayerDatabase.P1LD1 = "John Carlson";
                PlayerDatabase.P1LD2 = "Sylvain Cote";
                PlayerDatabase.P1LD3 = "Scott Stevens";
                PlayerDatabase.P1RD1 = "Sergei Gonchar";
                PlayerDatabase.P1RD2 = "Rod Langway";
                PlayerDatabase.P1RD3 = "Al Iafrate";
                PlayerDatabase.P1G = "Braden Holtby";
                PlayerDatabase.P1PPLW = "Alexander Ovechkin";
                PlayerDatabase.P1PPC = "Nicklas Backstrom";
                PlayerDatabase.P1PPRW = "Peter Bondra";
                PlayerDatabase.P1PPLD = "John Carlson";
                PlayerDatabase.P1PPRD = "Mike Gartner";
                PlayerDatabase.P1PKLW = "Adam Oates";
                PlayerDatabase.P1PKRW = "Mike Ridley";
                PlayerDatabase.P1PKLD = "Scott Stevens";
                PlayerDatabase.P1PKRD = "Rod Langway";
                PlayerDatabase.P1PKExW = "Alexander Ovechkin";
                PlayerDatabase.P1PKExD = "Sergei Gonchar";
            }

            else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
                PlayerDatabase.P1LW1 = "Patrik Laine";
                PlayerDatabase.P1LW2 = "Nikolaj Ehlers";
                PlayerDatabase.P1LW3 = "Keith Tkachuk";
                PlayerDatabase.P1LW4 = "Pat Elynuik";
                PlayerDatabase.P1C1 = "Dale Hawerchuk";
                PlayerDatabase.P1C2 = "Mark Scheifele";
                PlayerDatabase.P1C3 = "Blake Wheeler";
                PlayerDatabase.P1C4 = "Thomas Steen";
                PlayerDatabase.P1RW1 = "Teemu Selanne";
                PlayerDatabase.P1RW2 = "Paul MacLean";
                PlayerDatabase.P1RW3 = "Brian Mullen";
                PlayerDatabase.P1RW4 = "Doug Smail";
                PlayerDatabase.P1LD1 = "Dustin Byfuglien";
                PlayerDatabase.P1LD2 = "Dave Babych";
                PlayerDatabase.P1LD3 = "Dave Ellett";
                PlayerDatabase.P1RD1 = "Jacob Trouba";
                PlayerDatabase.P1RD2 = "Phil Housley";
                PlayerDatabase.P1RD3 = "Fredrik Olausson";
                PlayerDatabase.P1G = "Connor Hellebuyck";
                PlayerDatabase.P1PPLW = "Patrik Laine";
                PlayerDatabase.P1PPC = "Dale Hawerchuk";
                PlayerDatabase.P1PPRW = "Teemu Selanne";
                PlayerDatabase.P1PPLD = "Dustin Byfuglien";
                PlayerDatabase.P1PPRD = "Paul MacLean";
                PlayerDatabase.P1PKLW = "Blake Wheeler";
                PlayerDatabase.P1PKRW = "Doug Smail";
                PlayerDatabase.P1PKLD = "Dustin Byfuglien";
                PlayerDatabase.P1PKRD = "Jacob Trouba";
                PlayerDatabase.P1PKExW = "Nikolaj Ehlers";
                PlayerDatabase.P1PKExD = "Phil Housley";
            }
		}
	}

	public void SetComputerLines() {
		RandomSelectComputerTeam();

		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (PlayerDatabase.ComputerChosenTeam == "ANA") {
                PlayerDatabase.P2LW1 = "Frank Vatrano";
                PlayerDatabase.P2LW2 = "Jakob Silfverberg";
                PlayerDatabase.P2LW3 = "Maxime Comtois";
                PlayerDatabase.P2LW4 = "Sonny Milano";
                PlayerDatabase.P2C1 = "Trevor Zegras";
                PlayerDatabase.P2C2 = "Adam Henrique";
                PlayerDatabase.P2C3 = "Sam Carrick";
                PlayerDatabase.P2C4 = "Dominik Simon";
                PlayerDatabase.P2RW1 = "Ryan Strome";
                PlayerDatabase.P2RW2 = "Troy Terry";
                PlayerDatabase.P2RW3 = "Zach AstonReese";
                PlayerDatabase.P2RW4 = "Gerald Mayhew";
                PlayerDatabase.P2LD1 = "Kevin Shattenkirk";
                PlayerDatabase.P2LD2 = "Greg Pateryn";
                PlayerDatabase.P2LD3 = "Cam Fowler";
                PlayerDatabase.P2RD1 = "Brendan Guhle";
                PlayerDatabase.P2RD2 = "Josh Mahura";
                PlayerDatabase.P2RD3 = "Andrej Sustr";
                PlayerDatabase.P2G = "John Gibson";
                PlayerDatabase.P2PPLW = "Jakob Silfverberg";PlayerDatabase.P2PPC = "Trevor Zegras";PlayerDatabase.P2PPRW = "Ryan Strome";PlayerDatabase.P2PPLD = "Frank Vatrano";PlayerDatabase.P2PPRD = "Adam Henrique";PlayerDatabase.P2PKLW = "Ryan Strome";PlayerDatabase.P2PKRW = "Zach AstonReese";PlayerDatabase.P2PKLD = "Kevin Shattenkirk";PlayerDatabase.P2PKRD = "Brendan Guhle";PlayerDatabase.P2PKExW = "Frank Vatrano";PlayerDatabase.P2PKExD = "Greg Pateryn";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "ARI") {
                PlayerDatabase.P2LW1 = "Nick Ritchie";
                PlayerDatabase.P2LW2 = "Lawson Crouse";
                PlayerDatabase.P2LW3 = "Antoine Roussel";
                PlayerDatabase.P2LW4 = "Michael Carcone";
                PlayerDatabase.P2C1 = "Nick Bjugstad";
                PlayerDatabase.P2C2 = "Alex Galchenyuk";
                PlayerDatabase.P2C3 = "Barrett Hayton";
                PlayerDatabase.P2C4 = "Bryan Little";
                PlayerDatabase.P2RW1 = "Clayton Keller";
                PlayerDatabase.P2RW2 = "Phil Kessel";
                PlayerDatabase.P2RW3 = "Zack Kassian";
                PlayerDatabase.P2RW4 = "Nick Schmaltz";
                PlayerDatabase.P2LD1 = "Conor Timmins";
                PlayerDatabase.P2LD2 = "Troy Stecher";
                PlayerDatabase.P2LD3 = "Shayne Gostisbehere";
                PlayerDatabase.P2RD1 = "Anton Stralman";
                PlayerDatabase.P2RD2 = "Patrik Nemeth";
                PlayerDatabase.P2RD3 = "Jakob Chychrun";
                PlayerDatabase.P2G = "Harri Sateri";
                PlayerDatabase.P2PPLW = "Nick Ritchie";PlayerDatabase.P2PPC = "Nick Bjugstad";PlayerDatabase.P2PPRW = "Clayton Keller";PlayerDatabase.P2PPLD = "Jakob Chychrun";PlayerDatabase.P2PPRD = "Alex Galchenyuk";PlayerDatabase.P2PKLW = "Nick Ritchie";PlayerDatabase.P2PKRW = "Nick Bjugstad";PlayerDatabase.P2PKLD = "Conor Timmins";PlayerDatabase.P2PKRD = "Troy Stecher";PlayerDatabase.P2PKExW = "Lawson Crouse";PlayerDatabase.P2PKExD = "Anton Stralman";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "BOS") {
                PlayerDatabase.P2LW1 = "Brad Marchand";
                PlayerDatabase.P2LW2 = "Jake DeBrusk";
                PlayerDatabase.P2LW3 = "Taylor Hall";
                PlayerDatabase.P2LW4 = "Peter Cehlarik";
                PlayerDatabase.P2C1 = "Patrice Bergeron";
                PlayerDatabase.P2C2 = "Charlie Coyle";
                PlayerDatabase.P2C3 = "Pavel Zacha";
                PlayerDatabase.P2C4 = "Trent Frederic";
                PlayerDatabase.P2RW1 = "David Pastrnak";
                PlayerDatabase.P2RW2 = "Craig Smith";
                PlayerDatabase.P2RW3 = "Nick Foligno";
                PlayerDatabase.P2RW4 = "Oskar Steen";
                PlayerDatabase.P2LD1 = "Brandon Carlo";
                PlayerDatabase.P2LD2 = "Connor Clifton";
                PlayerDatabase.P2LD3 = "Mike Reilly";
                PlayerDatabase.P2RD1 = "Matt Grzelcyk";
                PlayerDatabase.P2RD2 = "Charlie McAvoy";
                PlayerDatabase.P2RD3 = "John Moore";
                PlayerDatabase.P2G = "Linus Ullmark";
                PlayerDatabase.P2PPLW = "Jake DeBrusk";PlayerDatabase.P2PPC = "Patrice Bergeron";PlayerDatabase.P2PPRW = "David Pastrnak";PlayerDatabase.P2PPLD = "Brad Marchand";PlayerDatabase.P2PPRD = "Craig Smith";PlayerDatabase.P2PKLW = "Brad Marchand";PlayerDatabase.P2PKRW = "Patrice Bergeron";PlayerDatabase.P2PKLD = "Brandon Carlo";PlayerDatabase.P2PKRD = "Matt Grzelcyk";PlayerDatabase.P2PKExW = "David Pastrnak";PlayerDatabase.P2PKExD = "Charlie McAvoy";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "BUF") {
                PlayerDatabase.P2LW1 = "Victor Olofsson";
                PlayerDatabase.P2LW2 = "Zemgus Girgensons";
                PlayerDatabase.P2LW3 = "Brett Murray";
                PlayerDatabase.P2LW4 = "Anders Bjork";
                PlayerDatabase.P2C1 = "Jeff Skinner";
                PlayerDatabase.P2C2 = "Vinnie Hinostroza";
                PlayerDatabase.P2C3 = "Dylan Cozens";
                PlayerDatabase.P2C4 = "Cody Eakin";
                PlayerDatabase.P2RW1 = "Alex Tuch";
                PlayerDatabase.P2RW2 = "Kyle Okposo";
                PlayerDatabase.P2RW3 = "Tage Thompson";
                PlayerDatabase.P2RW4 = "Rasmus Asplund";
                PlayerDatabase.P2LD1 = "Johnny Boychuk";
                PlayerDatabase.P2LD2 = "Jacob Bryson";
                PlayerDatabase.P2LD3 = "Henri Jokiharju";
                PlayerDatabase.P2RD1 = "Rasmus Dahlin";
                PlayerDatabase.P2RD2 = "Will Butcher";
                PlayerDatabase.P2RD3 = "Ilya Lyubushkin";
                PlayerDatabase.P2G = "Craig Anderson";
                PlayerDatabase.P2PPLW = "Victor Olofsson";PlayerDatabase.P2PPC = "Vinnie Hinostroza";PlayerDatabase.P2PPRW = "Alex Tuch";PlayerDatabase.P2PPLD = "Jeff Skinner";PlayerDatabase.P2PPRD = "Rasmus Dahlin";PlayerDatabase.P2PKLW = "Vinnie Hinostroza";PlayerDatabase.P2PKRW = "Alex Tuch";PlayerDatabase.P2PKLD = "Johnny Boychuk";PlayerDatabase.P2PKRD = "Jacob Bryson";PlayerDatabase.P2PKExW = "Cody Eakin";PlayerDatabase.P2PKExD = "Ilya Lyubushkin";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "CAL") {
                PlayerDatabase.P2LW1 = "Matthew Tkachuk";
                PlayerDatabase.P2LW2 = "Blake Coleman";
                PlayerDatabase.P2LW3 = "Dillon Dube";
                PlayerDatabase.P2LW4 = "Milan Lucic";
                PlayerDatabase.P2C1 = "Elias Lindholm";
                PlayerDatabase.P2C2 = "Mikael Backlund";
                PlayerDatabase.P2C3 = "Sean Monahan";
                PlayerDatabase.P2C4 = "Adam Ruzicka";
                PlayerDatabase.P2RW1 = "Tyler Toffoli";
                PlayerDatabase.P2RW2 = "Andrew Mangiapane";
                PlayerDatabase.P2RW3 = "Trevor Lewis";
                PlayerDatabase.P2RW4 = "Brett Ritchie";
                PlayerDatabase.P2LD1 = "Oliver Kylington";
                PlayerDatabase.P2LD2 = "Nikita Zadorov";
                PlayerDatabase.P2LD3 = "Christopher Tanev";
                PlayerDatabase.P2RD1 = "Noah Hanifin";
                PlayerDatabase.P2RD2 = "Rasmus Andersson";
                PlayerDatabase.P2RD3 = "Michael Stone";
                PlayerDatabase.P2G = "Jacob Markstrom";
                PlayerDatabase.P2PPLW = "Matthew Tkachuk";PlayerDatabase.P2PPC = "Elias Lindholm";PlayerDatabase.P2PPRW = "Tyler Toffoli";PlayerDatabase.P2PPLD = "Oliver Kylington";PlayerDatabase.P2PPRD = "Noah Hanifin";PlayerDatabase.P2PKLW = "Mikael Backlund";PlayerDatabase.P2PKRW = "Elias Lindholm";PlayerDatabase.P2PKLD = "Oliver Kylington";PlayerDatabase.P2PKRD = "Noah Hanifin";PlayerDatabase.P2PKExW = "Adam Ruzicka";PlayerDatabase.P2PKExD = "Nikita Zadorov";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "CAR") {
                PlayerDatabase.P2LW1 = "Max Pacioretty";
                PlayerDatabase.P2LW2 = "Andrei Svechnikov";
                PlayerDatabase.P2LW3 = "Gregory Hofmann";
                PlayerDatabase.P2LW4 = "Jesperi Kotkaniemi";
                PlayerDatabase.P2C1 = "Sebastian Aho";
                PlayerDatabase.P2C2 = "Martin Necas";
                PlayerDatabase.P2C3 = "Jordan Staal";
                PlayerDatabase.P2C4 = "Derek Stepan";
                PlayerDatabase.P2RW1 = "Teuvo Teravainen";
                PlayerDatabase.P2RW2 = "Ondrej Kase";
                PlayerDatabase.P2RW3 = "Jesper Fast";
                PlayerDatabase.P2RW4 = "Seth Jarvis";
                PlayerDatabase.P2LD1 = "Brett Pesce";
                PlayerDatabase.P2LD2 = "Brent Burns";
                PlayerDatabase.P2LD3 = "Brady Skjei";
                PlayerDatabase.P2RD1 = "Jaccob Slavin";
                PlayerDatabase.P2RD2 = "Ethan Bear";
                PlayerDatabase.P2RD3 = "Jake Gardiner";
                PlayerDatabase.P2G = "Frederik Andersen";
                PlayerDatabase.P2PPLW = "Max Pacioretty";PlayerDatabase.P2PPC = "Sebastian Aho";PlayerDatabase.P2PPRW = "Teuvo Teravainen";PlayerDatabase.P2PPLD = "Brent Burns";PlayerDatabase.P2PPRD = "Andrei Svechnikov";PlayerDatabase.P2PKLW = "Sebastian Aho";PlayerDatabase.P2PKRW = "Teuvo Teravainen";PlayerDatabase.P2PKLD = "Brett Pesce";PlayerDatabase.P2PKRD = "Jaccob Slavin";PlayerDatabase.P2PKExW = "Jesper Fast";PlayerDatabase.P2PKExD = "Brady Skjei";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "CHI") {
                PlayerDatabase.P2LW1 = "Max Domi";
                PlayerDatabase.P2LW2 = "Colin Blackwell";
                PlayerDatabase.P2LW3 = "Philipp Kurashev";
                PlayerDatabase.P2LW4 = "Sam Lafferty";
                PlayerDatabase.P2C1 = "Jonathan Toews";
                PlayerDatabase.P2C2 = "Tyler Johnson";
                PlayerDatabase.P2C3 = "Dylan Sikura";
                PlayerDatabase.P2C4 = "Jujhar Khaira";
                PlayerDatabase.P2RW1 = "Patrick Kane";
                PlayerDatabase.P2RW2 = "Andreas Athanasiou";
                PlayerDatabase.P2RW3 = "Brett Connolly";
                PlayerDatabase.P2RW4 = "Kurtis Gabriel";
                PlayerDatabase.P2LD1 = "Seth Jones";
                PlayerDatabase.P2LD2 = "Riley Stillman";
                PlayerDatabase.P2LD3 = "Caleb Jones";
                PlayerDatabase.P2RD1 = "Connor Murphy";
                PlayerDatabase.P2RD2 = "Nicolas Beaudin";
                PlayerDatabase.P2RD3 = "Calvin DeHaan";
                PlayerDatabase.P2G = "Petr Mrazek";
                PlayerDatabase.P2PPLW = "Max Domi";PlayerDatabase.P2PPC = "Jonathan Toews";PlayerDatabase.P2PPRW = "Patrick Kane";PlayerDatabase.P2PPLD = "Seth Jones";PlayerDatabase.P2PPRD = "Andreas Athanasiou";PlayerDatabase.P2PKLW = "Colin Blackwell";PlayerDatabase.P2PKRW = "Tyler Johnson";PlayerDatabase.P2PKLD = "Seth Jones";PlayerDatabase.P2PKRD = "Connor Murphy";PlayerDatabase.P2PKExW = "Dylan Sikura";PlayerDatabase.P2PKExD = "Nicolas Beaudin";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "COL") {
                PlayerDatabase.P2LW1 = "Gabriel Landeskog";
                PlayerDatabase.P2LW2 = "Artturi Lehkonen";
                PlayerDatabase.P2LW3 = "Alex Newhook";
                PlayerDatabase.P2LW4 = "JT Compher";
                PlayerDatabase.P2C1 = "Nathan MacKinnon";
                PlayerDatabase.P2C2 = "Nazem Kadri";
                PlayerDatabase.P2C3 = "Darren Helm";
                PlayerDatabase.P2C4 = "Andrew Cogliano";
                PlayerDatabase.P2RW1 = "Mikko Rantanen";
                PlayerDatabase.P2RW2 = "Valeri Nichushkin";
                PlayerDatabase.P2RW3 = "Logan OConnor";
                PlayerDatabase.P2RW4 = "Martin Kaut";
                PlayerDatabase.P2LD1 = "Devon Toews";
                PlayerDatabase.P2LD2 = "Bowen Byram";
                PlayerDatabase.P2LD3 = "Erik Johnson";
                PlayerDatabase.P2RD1 = "Cale Makar";
                PlayerDatabase.P2RD2 = "Jacob MacDonald";
                PlayerDatabase.P2RD3 = "Samuel Girard";
                PlayerDatabase.P2G = "Alexandar Georgiev";
                PlayerDatabase.P2PPLW = "Gabriel Landeskog";PlayerDatabase.P2PPC = "Nazem Kadri";PlayerDatabase.P2PPRW = "Nathan MacKinnon";PlayerDatabase.P2PPLD = "Mikko Rantanen";PlayerDatabase.P2PPRD = "Cale Makar";PlayerDatabase.P2PKLW = "Gabriel Landeskog";PlayerDatabase.P2PKRW = "Nathan MacKinnon";PlayerDatabase.P2PKLD = "Devon Toews";PlayerDatabase.P2PKRD = "Cale Makar";PlayerDatabase.P2PKExW = "Mikko Rantanen";PlayerDatabase.P2PKExD = "Bowen Byram";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "CBJ") {
                PlayerDatabase.P2LW1 = "Johnny Gaudreau";
                PlayerDatabase.P2LW2 = "Patrik Laine";
                PlayerDatabase.P2LW3 = "Eric Robinson";
                PlayerDatabase.P2LW4 = "Brendan Gaunce";
                PlayerDatabase.P2C1 = "Boone Jenner";
                PlayerDatabase.P2C2 = "Gustav Nyquist";
                PlayerDatabase.P2C3 = "Cole Sillinger";
                PlayerDatabase.P2C4 = "Alexandre Texier";
                PlayerDatabase.P2RW1 = "Oliver Bjorkstrand";
                PlayerDatabase.P2RW2 = "Jakub Voracek";
                PlayerDatabase.P2RW3 = "Emil Bemstrom";
                PlayerDatabase.P2RW4 = "Liam Foudy";
                PlayerDatabase.P2LD1 = "Gavin Bayreuther";
                PlayerDatabase.P2LD2 = "Vladislav Gavrikov";
                PlayerDatabase.P2LD3 = "Dean Kukan";
                PlayerDatabase.P2RD1 = "Zach Werenski";
                PlayerDatabase.P2RD2 = "Jake Bean";
                PlayerDatabase.P2RD3 = "Erik Gudbranson";
                PlayerDatabase.P2G = "Elvis Merzlikins";
                PlayerDatabase.P2PPLW = "Johnny Gaudreau";PlayerDatabase.P2PPC = "Boone Jenner";PlayerDatabase.P2PPRW = "Oliver Bjorkstrand";PlayerDatabase.P2PPLD = "Patrik Laine";PlayerDatabase.P2PPRD = "Zach Werenski";PlayerDatabase.P2PKLW = "Eric Robinson";PlayerDatabase.P2PKRW = "Brendan Gaunce";PlayerDatabase.P2PKLD = "Gavin Bayreuther";PlayerDatabase.P2PKRD = "Zach Werenski";PlayerDatabase.P2PKExW = "Gustav Nyquist";PlayerDatabase.P2PKExD = "Jake Bean";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "DAL") {
                PlayerDatabase.P2LW1 = "Jason Robertson";
                PlayerDatabase.P2LW2 = "Mason Marchment";
                PlayerDatabase.P2LW3 = "Joel Kiviranta";
                PlayerDatabase.P2LW4 = "Michael Raffl";
                PlayerDatabase.P2C1 = "Roope Hintz";
                PlayerDatabase.P2C2 = "Jamie Benn";
                PlayerDatabase.P2C3 = "Ty Dellandrea";
                PlayerDatabase.P2C4 = "Jacob Peterson";
                PlayerDatabase.P2RW1 = "Joe Pavelski";
                PlayerDatabase.P2RW2 = "Tyler Seguin";
                PlayerDatabase.P2RW3 = "Denis Gurianov";
                PlayerDatabase.P2RW4 = "Luke Glendening";
                PlayerDatabase.P2LD1 = "Esa Lindell";
                PlayerDatabase.P2LD2 = "Jani Hakanpaa";
                PlayerDatabase.P2LD3 = "Colin Miller";
                PlayerDatabase.P2RD1 = "Miro Heiskanen";
                PlayerDatabase.P2RD2 = "Ryan Suter";
                PlayerDatabase.P2RD3 = "Joel Hanley";
                PlayerDatabase.P2G = "Jake Oettinger";
                PlayerDatabase.P2PPLW = "Jason Robertson";PlayerDatabase.P2PPC = "Joe Pavelski";PlayerDatabase.P2PPRW = "Tyler Seguin";PlayerDatabase.P2PPLD = "Jamie Benn";PlayerDatabase.P2PPRD = "Roope Hintz";PlayerDatabase.P2PKLW = "Jason Robertson";PlayerDatabase.P2PKRW = "Mason Marchment";PlayerDatabase.P2PKLD = "Esa Lindell";PlayerDatabase.P2PKRD = "Ryan Suter";PlayerDatabase.P2PKExW = "Joe Pavelski";PlayerDatabase.P2PKExD = "Jani Hakanpaa";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "DET") {
                PlayerDatabase.P2LW1 = "Dominik Kubalik";
                PlayerDatabase.P2LW2 = "Tyler Bertuzzi";
                PlayerDatabase.P2LW3 = "Filip Zadina";
                PlayerDatabase.P2LW4 = "Adam Erne";
                PlayerDatabase.P2C1 = "Dylan Larkin";
                PlayerDatabase.P2C2 = "Andrew Copp";
                PlayerDatabase.P2C3 = "Robby Fabbri";
                PlayerDatabase.P2C4 = "Oskar Sundqvist";
                PlayerDatabase.P2RW1 = "David Perron";
                PlayerDatabase.P2RW2 = "Jakub Vrana";
                PlayerDatabase.P2RW3 = "Lucas Raymond";
                PlayerDatabase.P2RW4 = "Sam Gagner";
                PlayerDatabase.P2LD1 = "Moritz Seider";
                PlayerDatabase.P2LD2 = "Danny DeKeyser";
                PlayerDatabase.P2LD3 = "Filip Hronek";
                PlayerDatabase.P2RD1 = "Olli Maatta";
                PlayerDatabase.P2RD2 = "Ben Chiarot";
                PlayerDatabase.P2RD3 = "Mark Pysyk";
                PlayerDatabase.P2G = "Alex Nedeljkovic";
                PlayerDatabase.P2PPLW = "Dominik Kubalik";PlayerDatabase.P2PPC = "Dylan Larkin";PlayerDatabase.P2PPRW = "Jakub Vrana";PlayerDatabase.P2PPLD = "David Perron";PlayerDatabase.P2PPRD = "Andrew Copp";PlayerDatabase.P2PKLW = "Andrew Copp";PlayerDatabase.P2PKRW = "David Perron";PlayerDatabase.P2PKLD = "Danny DeKeyser";PlayerDatabase.P2PKRD = "Olli Maatta";PlayerDatabase.P2PKExW = "Jakub Vrana";PlayerDatabase.P2PKExD = "Ben Chiarot";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "EDM") {
                PlayerDatabase.P2LW1 = "Leon Draisaitl";
                PlayerDatabase.P2LW2 = "Evander Kane";
                PlayerDatabase.P2LW3 = "Warren Foegele";
                PlayerDatabase.P2LW4 = "Brendan Perlini";
                PlayerDatabase.P2C1 = "Connor McDavid";
                PlayerDatabase.P2C2 = "Ryan NugentHopkins";
                PlayerDatabase.P2C3 = "Derek Ryan";
                PlayerDatabase.P2C4 = "Derick Brassard";
                PlayerDatabase.P2RW1 = "Zach Hyman";
                PlayerDatabase.P2RW2 = "Jesse Puljujarvi";
                PlayerDatabase.P2RW3 = "Kailer Yamamoto";
                PlayerDatabase.P2RW4 = "Mattias Janmark";
                PlayerDatabase.P2LD1 = "Darnell Nurse";
                PlayerDatabase.P2LD2 = "Kris Russell";
                PlayerDatabase.P2LD3 = "Oscar Klefbom";
                PlayerDatabase.P2RD1 = "Tyson Barrie";
                PlayerDatabase.P2RD2 = "Evan Bouchard";
                PlayerDatabase.P2RD3 = "Cody Ceci";
                PlayerDatabase.P2G = "Jack Campbell";
                PlayerDatabase.P2PPLW = "Evander Kane";PlayerDatabase.P2PPC = "Connor McDavid";PlayerDatabase.P2PPRW = "Zach Hyman";PlayerDatabase.P2PPLD = "Darnell Nurse";PlayerDatabase.P2PPRD = "Leon Draisaitl";PlayerDatabase.P2PKLW = "Connor McDavid";PlayerDatabase.P2PKRW = "Zach Hyman";PlayerDatabase.P2PKLD = "Darnell Nurse";PlayerDatabase.P2PKRD = "Tyson Barrie";PlayerDatabase.P2PKExW = "Leon Draisaitl";PlayerDatabase.P2PKExD = "Kris Russell";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "FLA") {
                PlayerDatabase.P2LW1 = "Jonathan Huberdeau";
                PlayerDatabase.P2LW2 = "Anthony Duclair";
                PlayerDatabase.P2LW3 = "Sam Bennett";
                PlayerDatabase.P2LW4 = "Maxim Mamin";
                PlayerDatabase.P2C1 = "Aleksander Barkov";
                PlayerDatabase.P2C2 = "Anton Lundell";
                PlayerDatabase.P2C3 = "Carter Verhaeghe";
                PlayerDatabase.P2C4 = "Nick Cousins";
                PlayerDatabase.P2RW1 = "Patric Hornqvist";
                PlayerDatabase.P2RW2 = "Sam Reinhart";
                PlayerDatabase.P2RW3 = "Rudolfs Balcers";
                PlayerDatabase.P2RW4 = "Colin White";
                PlayerDatabase.P2LD1 = "Aaron Ekblad";
                PlayerDatabase.P2LD2 = "Gustav Forsling";
                PlayerDatabase.P2LD3 = "Brandon Montour";
                PlayerDatabase.P2RD1 = "MacKenzie Weegar";
                PlayerDatabase.P2RD2 = "Radko Gudas";
                PlayerDatabase.P2RD3 = "Lucas Carlsson";
                PlayerDatabase.P2G = "Sergei Bobrovsky";
                PlayerDatabase.P2PPLW = "Jonathan Huberdeau";PlayerDatabase.P2PPC = "Aleksander Barkov";PlayerDatabase.P2PPRW = "Patric Hornqvist";PlayerDatabase.P2PPLD = "Aaron Ekblad";PlayerDatabase.P2PPRD = "Anthony Duclair";PlayerDatabase.P2PKLW = "Anthony Duclair";PlayerDatabase.P2PKRW = "Aleksander Barkov";PlayerDatabase.P2PKLD = "Aaron Ekblad";PlayerDatabase.P2PKRD = "MacKenzie Weegar";PlayerDatabase.P2PKExW = "Anton Lundell";PlayerDatabase.P2PKExD = "Gustav Forsling";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "LAK") {
                PlayerDatabase.P2LW1 = "Kevin Fiala";
                PlayerDatabase.P2LW2 = "Arthur Kaliyev";
                PlayerDatabase.P2LW3 = "Alex Iafallo";
                PlayerDatabase.P2LW4 = "Brendan Lemieux";
                PlayerDatabase.P2C1 = "Phillip Danault";
                PlayerDatabase.P2C2 = "Anze Kopitar";
                PlayerDatabase.P2C3 = "Blake Lizotte";
                PlayerDatabase.P2C4 = "Trevor Moore";
                PlayerDatabase.P2RW1 = "Viktor Arvidsson";
                PlayerDatabase.P2RW2 = "Adrian Kempe";
                PlayerDatabase.P2RW3 = "Martin Frk";
                PlayerDatabase.P2RW4 = "TJ Tynan";
                PlayerDatabase.P2LD1 = "Drew Doughty";
                PlayerDatabase.P2LD2 = "Jacob Moverare";
                PlayerDatabase.P2LD3 = "Jordan Spence";
                PlayerDatabase.P2RD1 = "Matt Roy";
                PlayerDatabase.P2RD2 = "Alexander Edler";
                PlayerDatabase.P2RD3 = "Michael Anderson";
                PlayerDatabase.P2G = "Jonathan Quick";
                PlayerDatabase.P2PPLW = "Arthur Kaliyev";PlayerDatabase.P2PPC = "Phillip Danault";PlayerDatabase.P2PPRW = "Viktor Arvidsson";PlayerDatabase.P2PPLD = "Kevin Fiala";PlayerDatabase.P2PPRD = "Alexander Edler";PlayerDatabase.P2PKLW = "Phillip Danault";PlayerDatabase.P2PKRW = "Viktor Arvidsson";PlayerDatabase.P2PKLD = "Jacob Moverare";PlayerDatabase.P2PKRD = "Matt Roy";PlayerDatabase.P2PKExW = "Blake Lizotte";PlayerDatabase.P2PKExD = "Alexander Edler";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "MIN") {
                PlayerDatabase.P2LW1 = "Ryan Hartman";
                PlayerDatabase.P2LW2 = "Marcus Foligno";
                PlayerDatabase.P2LW3 = "Jordan Greenway";
                PlayerDatabase.P2LW4 = "Joseph Cramarossa";
                PlayerDatabase.P2C1 = "Joel ErikssonEk";
                PlayerDatabase.P2C2 = "Frederick Gaudreau";
                PlayerDatabase.P2C3 = "Tyson Jost";
                PlayerDatabase.P2C4 = "Kyle Rau";
                PlayerDatabase.P2RW1 = "Kirill Kaprizov";
                PlayerDatabase.P2RW2 = "Mats Zuccarello";
                PlayerDatabase.P2RW3 = "Brandon Duhaime";
                PlayerDatabase.P2RW4 = "Brandon Baddock";
                PlayerDatabase.P2LD1 = "Alex Goligoski";
                PlayerDatabase.P2LD2 = "Jonas Brodin";
                PlayerDatabase.P2LD3 = "Jon Merrill";
                PlayerDatabase.P2RD1 = "Jared Spurgeon";
                PlayerDatabase.P2RD2 = "Matt Dumba";
                PlayerDatabase.P2RD3 = "Dakota Mermis";
                PlayerDatabase.P2G = "MarcAndre Fleury";
                PlayerDatabase.P2PPLW = "Ryan Hartman";PlayerDatabase.P2PPC = "Joel ErikssonEk";PlayerDatabase.P2PPRW = "Kirill Kaprizov";PlayerDatabase.P2PPLD = "Jared Spurgeon";PlayerDatabase.P2PPRD = "Matt Dumba";PlayerDatabase.P2PKLW = "Marcus Foligno";PlayerDatabase.P2PKRW = "Kirill Kaprizov";PlayerDatabase.P2PKLD = "Alex Goligoski";PlayerDatabase.P2PKRD = "Dakota Mermis";PlayerDatabase.P2PKExW = "Frederick Gaudreau";PlayerDatabase.P2PKExD = "Jared Spurgeon";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "MON") {
                PlayerDatabase.P2LW1 = "Josh Anderson";
                PlayerDatabase.P2LW2 = "Evgeny Dadonov";
                PlayerDatabase.P2LW3 = "Jonathan Drouin";
                PlayerDatabase.P2LW4 = "Mathieu Perreault";
                PlayerDatabase.P2C1 = "Mike Hoffman";
                PlayerDatabase.P2C2 = "Nick Suzuki";
                PlayerDatabase.P2C3 = "Paul Byron";
                PlayerDatabase.P2C4 = "Kirby Dach";
                PlayerDatabase.P2RW1 = "Brendan Gallagher";
                PlayerDatabase.P2RW2 = "Cole Caufield";
                PlayerDatabase.P2RW3 = "Joel Armia";
                PlayerDatabase.P2RW4 = "Tyler Pitlick";
                PlayerDatabase.P2LD1 = "Mike Matheson";
                PlayerDatabase.P2LD2 = "Sami Niku";
                PlayerDatabase.P2LD3 = "Madison Bowey";
                PlayerDatabase.P2RD1 = "Joel Edmundson";
                PlayerDatabase.P2RD2 = "William Lagesson";
                PlayerDatabase.P2RD3 = "Xavier Ouellet";
                PlayerDatabase.P2G = "Carey Price";
                PlayerDatabase.P2PPLW = "Josh Anderson";PlayerDatabase.P2PPC = "Mike Hoffman";PlayerDatabase.P2PPRW = "Brendan Gallagher";PlayerDatabase.P2PPLD = "Mike Matheson";PlayerDatabase.P2PPRD = "Evgeny Dadonov";PlayerDatabase.P2PKLW = "Paul Byron";PlayerDatabase.P2PKRW = "Brendan Gallagher";PlayerDatabase.P2PKLD = "Joel Edmundson";PlayerDatabase.P2PKRD = "Mike Matheson";PlayerDatabase.P2PKExW = "Tyler Pitlick";PlayerDatabase.P2PKExD = "William Lagesson";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "NAS") {
                PlayerDatabase.P2LW1 = "Filip Forsberg";
                PlayerDatabase.P2LW2 = "Eeli Tolvanen";
                PlayerDatabase.P2LW3 = "Tanner Jeannot";
                PlayerDatabase.P2LW4 = "Zach Sanford";
                PlayerDatabase.P2C1 = "Matt Duchene";
                PlayerDatabase.P2C2 = "Colton Sissons";
                PlayerDatabase.P2C3 = "Yakov Trenin";
                PlayerDatabase.P2C4 = "Ryan Johansen";
                PlayerDatabase.P2RW1 = "Mikael Granlund";
                PlayerDatabase.P2RW2 = "Nino Niederreiter";
                PlayerDatabase.P2RW3 = "Rocco Grimaldi";
                PlayerDatabase.P2RW4 = "Matt Luff";
                PlayerDatabase.P2LD1 = "Roman Josi";
                PlayerDatabase.P2LD2 = "Mattias Ekholm";
                PlayerDatabase.P2LD3 = "Ryan McDonagh";
                PlayerDatabase.P2RD1 = "Alexandre Carrier";
                PlayerDatabase.P2RD2 = "Dante Fabbro";
                PlayerDatabase.P2RD3 = "Jeremy Lauzon";
                PlayerDatabase.P2G = "Juuse Saros";
                PlayerDatabase.P2PPLW = "Filip Forsberg";PlayerDatabase.P2PPC = "Matt Duchene";PlayerDatabase.P2PPRW = "Mikael Granlund";PlayerDatabase.P2PPLD = "Roman Josi";PlayerDatabase.P2PPRD = "Eeli Tolvanen";PlayerDatabase.P2PKLW = "Tanner Jeannot";PlayerDatabase.P2PKRW = "Michael McCarron";PlayerDatabase.P2PKLD = "Mattias Ekholm";PlayerDatabase.P2PKRD = "Alexandre Carrier";PlayerDatabase.P2PKExW = "Colton Sissons";PlayerDatabase.P2PKExD = "Ryan McDonagh";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "NJD") {
                PlayerDatabase.P2LW1 = "Ondrej Palat";
                PlayerDatabase.P2LW2 = "Tomas Tatar";
                PlayerDatabase.P2LW3 = "Miles Wood";
                PlayerDatabase.P2LW4 = "Andreas Johnson";
                PlayerDatabase.P2C1 = "Erik Haula";
                PlayerDatabase.P2C2 = "Nico Hischier";
                PlayerDatabase.P2C3 = "Jack Hughes";
                PlayerDatabase.P2C4 = "Yegor Sharangovich";
                PlayerDatabase.P2RW1 = "Jesper Bratt";
                PlayerDatabase.P2RW2 = "Dawson Mercer";
                PlayerDatabase.P2RW3 = "Nathan Bastian";
                PlayerDatabase.P2RW4 = "Jimmy Vesey";
                PlayerDatabase.P2LD1 = "Dougie Hamilton";
                PlayerDatabase.P2LD2 = "Brendan Smith";
                PlayerDatabase.P2LD3 = "Jonas Siegenthaler";
                PlayerDatabase.P2RD1 = "Ryan Graves";
                PlayerDatabase.P2RD2 = "John Marino";
                PlayerDatabase.P2RD3 = "Damon Severson";
                PlayerDatabase.P2G = "Vitek Vanecek";
                PlayerDatabase.P2PPLW = "Ondrej Palat";PlayerDatabase.P2PPC = "Erik Haula";PlayerDatabase.P2PPRW = "Jesper Bratt";PlayerDatabase.P2PPLD = "Dougie Hamilton";PlayerDatabase.P2PPRD = "Tomas Tatar";PlayerDatabase.P2PKLW = "Ondrej Palat";PlayerDatabase.P2PKRW = "Erik Haula";PlayerDatabase.P2PKLD = "Dougie Hamilton";PlayerDatabase.P2PKRD = "Ryan Graves";PlayerDatabase.P2PKExW = "Andreas Johnson";PlayerDatabase.P2PKExD = "John Marino";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "NYI") {
                PlayerDatabase.P2LW1 = "Anders Lee";
                PlayerDatabase.P2LW2 = "Anthony Beauvillier";
                PlayerDatabase.P2LW3 = "Zach Parise";
                PlayerDatabase.P2LW4 = "Matt Martin";
                PlayerDatabase.P2C1 = "Brock Nelson";
                PlayerDatabase.P2C2 = "Mathew Barzal";
                PlayerDatabase.P2C3 = "JeanGabriel Pageau";
                PlayerDatabase.P2C4 = "Casey Cizikas";
                PlayerDatabase.P2RW1 = "Kyle Palmieri";
                PlayerDatabase.P2RW2 = "Oliver Wahlstrom";
                PlayerDatabase.P2RW3 = "Josh Bailey";
                PlayerDatabase.P2RW4 = "Cal Clutterbuck";
                PlayerDatabase.P2LD1 = "Zdeno Chara";
                PlayerDatabase.P2LD2 = "Scott Mayfield";
                PlayerDatabase.P2LD3 = "Thomas Hickey";
                PlayerDatabase.P2RD1 = "Ryan Pulock";
                PlayerDatabase.P2RD2 = "Adam Pelech";
                PlayerDatabase.P2RD3 = "Noah Dobson";
                PlayerDatabase.P2G = "Ilya Sorokin";
                PlayerDatabase.P2PPLW = "Anders Lee";PlayerDatabase.P2PPC = "Brock Nelson";PlayerDatabase.P2PPRW = "Kyle Palmieri";PlayerDatabase.P2PPLD = "Ryan Pulock";PlayerDatabase.P2PPRD = "Anthony Beauvillier";PlayerDatabase.P2PKLW = "Anders Lee";PlayerDatabase.P2PKRW = "Brock Nelson";PlayerDatabase.P2PKLD = "Ryan Pulock";PlayerDatabase.P2PKRD = "Zdeno Chara";PlayerDatabase.P2PKExW = "Casey Cizikas";PlayerDatabase.P2PKExD = "Adam Pelech";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "NYR") {
                PlayerDatabase.P2LW1 = "Artemi Panarin";
                PlayerDatabase.P2LW2 = "Chris Kreider";
                PlayerDatabase.P2LW3 = "Dryden Hunt";
                PlayerDatabase.P2LW4 = "Alexis Lafreniere";
                PlayerDatabase.P2C1 = "Mika Zibanejad";
                PlayerDatabase.P2C2 = "Vincent Trocheck";
                PlayerDatabase.P2C3 = "Filip Chytil";
                PlayerDatabase.P2C4 = "Ryan Carpenter";
                PlayerDatabase.P2RW1 = "Barclay Goodrow";
                PlayerDatabase.P2RW2 = "Jonny Brodzinski";
                PlayerDatabase.P2RW3 = "Kaapo Kakko";
                PlayerDatabase.P2RW4 = "Nick Merkley";
                PlayerDatabase.P2LD1 = "Nils Lundkvist";
                PlayerDatabase.P2LD2 = "Ryan Lindgren";
                PlayerDatabase.P2LD3 = "Libor Hajek";
                PlayerDatabase.P2RD1 = "Adam Fox";
                PlayerDatabase.P2RD2 = "KAndre Miller";
                PlayerDatabase.P2RD3 = "Jacob Trouba";
                PlayerDatabase.P2G = "Igor Shesterkin";
                PlayerDatabase.P2PPLW = "Artemi Panarin";PlayerDatabase.P2PPC = "Mika Zibanejad";PlayerDatabase.P2PPRW = "Barclay Goodrow";PlayerDatabase.P2PPLD = "Nils Lundkvist";PlayerDatabase.P2PPRD = "Adam Fox";PlayerDatabase.P2PKLW = "Artemi Panarin";PlayerDatabase.P2PKRW = "Mika Zibanejad";PlayerDatabase.P2PKLD = "Nils Lundkvist";PlayerDatabase.P2PKRD = "Adam Fox";PlayerDatabase.P2PKExW = "Chris Kreider";PlayerDatabase.P2PKExD = "KAndre Miller";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "OTT") {
                PlayerDatabase.P2LW1 = "Alex DeBrincat";
                PlayerDatabase.P2LW2 = "Brady Tkachuk";
                PlayerDatabase.P2LW3 = "Alex Formenton";
                PlayerDatabase.P2LW4 = "Austin Watson";
                PlayerDatabase.P2C1 = "Claude Giroux";
                PlayerDatabase.P2C2 = "Josh Norris";
                PlayerDatabase.P2C3 = "Tim Stutzle";
                PlayerDatabase.P2C4 = "Dylan Gambrell";
                PlayerDatabase.P2RW1 = "Drake Batherson";
                PlayerDatabase.P2RW2 = "Tyler Ennis";
                PlayerDatabase.P2RW3 = "Mathieu Joseph";
                PlayerDatabase.P2RW4 = "Zach Senyshyn";
                PlayerDatabase.P2LD1 = "Travis Hamonic";
                PlayerDatabase.P2LD2 = "Nick Holden";
                PlayerDatabase.P2LD3 = "Erik Brannstrom";
                PlayerDatabase.P2RD1 = "Thomas Chabot";
                PlayerDatabase.P2RD2 = "Nikita Zaitsev";
                PlayerDatabase.P2RD3 = "Jacob BernardDocker";
                PlayerDatabase.P2G = "Cam Talbot";
                PlayerDatabase.P2PPLW = "Alex DeBrincat";PlayerDatabase.P2PPC = "Claude Giroux";PlayerDatabase.P2PPRW = "Drake Batherson";PlayerDatabase.P2PPLD = "Thomas Chabot";PlayerDatabase.P2PPRD = "Tyler Ennis";PlayerDatabase.P2PKLW = "Alex DeBrincat";PlayerDatabase.P2PKRW = "Mathieu Joseph";PlayerDatabase.P2PKLD = "Travis Hamonic";PlayerDatabase.P2PKRD = "Nikita Zaitsev";PlayerDatabase.P2PKExW = "Claude Giroux";PlayerDatabase.P2PKExD = "Nick Holden";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "PHI") {
                PlayerDatabase.P2LW1 = "Travis Konecny";
                PlayerDatabase.P2LW2 = "James VanRiemsdyk";
                PlayerDatabase.P2LW3 = "Joel Farabee";
                PlayerDatabase.P2LW4 = "Nick Deslauriers";
                PlayerDatabase.P2C1 = "Sean Couturier";
                PlayerDatabase.P2C2 = "Kevin Hayes";
                PlayerDatabase.P2C3 = "Scott Laughton";
                PlayerDatabase.P2C4 = "Morgan Frost";
                PlayerDatabase.P2RW1 = "Cam Atkinson";
                PlayerDatabase.P2RW2 = "Owen Tippett";
                PlayerDatabase.P2RW3 = "Wade Allison";
                PlayerDatabase.P2RW4 = "Zack MacEwen";
                PlayerDatabase.P2LD1 = "Ryan Ellis";
                PlayerDatabase.P2LD2 = "Rasmus Ristolainen";
                PlayerDatabase.P2LD3 = "Kevin Connauton";
                PlayerDatabase.P2RD1 = "Tony DeAngelo";
                PlayerDatabase.P2RD2 = "Ivan Provorov";
                PlayerDatabase.P2RD3 = "Justin Braun";
                PlayerDatabase.P2G = "Carter Hart";
                PlayerDatabase.P2PPLW = "James VanRiemsdyk";PlayerDatabase.P2PPC = "Sean Couturier";PlayerDatabase.P2PPRW = "Cam Atkinson";PlayerDatabase.P2PPLD = "Ryan Ellis";PlayerDatabase.P2PPRD = "Travis Konecny";PlayerDatabase.P2PKLW = "Sean Couturier";PlayerDatabase.P2PKRW = "Cam Atkinson";PlayerDatabase.P2PKLD = "Ryan Ellis";PlayerDatabase.P2PKRD = "Tony DeAngelo";PlayerDatabase.P2PKExW = "Joel Farabee";PlayerDatabase.P2PKExD = "Ivan Provorov";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "PIT") {
                PlayerDatabase.P2LW1 = "Bryan Rust";
                PlayerDatabase.P2LW2 = "Kasperi Kapanen";
                PlayerDatabase.P2LW3 = "Jason Zucker";
                PlayerDatabase.P2LW4 = "Brian Boyle";
                PlayerDatabase.P2C1 = "Sidney Crosby";
                PlayerDatabase.P2C2 = "Jeff Carter";
                PlayerDatabase.P2C3 = "Evgeni Malkin";
                PlayerDatabase.P2C4 = "Teddy Blueger";
                PlayerDatabase.P2RW1 = "Jake Guentzel";
                PlayerDatabase.P2RW2 = "Evan Rodrigues";
                PlayerDatabase.P2RW3 = "Rickard Rakell";
                PlayerDatabase.P2RW4 = "Josh Archibald";
                PlayerDatabase.P2LD1 = "Brian Dumoulin";
                PlayerDatabase.P2LD2 = "Jeff Petry";
                PlayerDatabase.P2LD3 = "Marcus Pettersson";
                PlayerDatabase.P2RD1 = "Kris Letang";
                PlayerDatabase.P2RD2 = "Jan Rutta";
                PlayerDatabase.P2RD3 = "Taylor Fedun";
                PlayerDatabase.P2G = "Casey DeSmith";
                PlayerDatabase.P2PPLW = "Bryan Rust";PlayerDatabase.P2PPC = "Sidney Crosby";PlayerDatabase.P2PPRW = "Evan Rodrigues";PlayerDatabase.P2PPLD = "Jake Guentzel";PlayerDatabase.P2PPRD = "Kris Letang";PlayerDatabase.P2PKLW = "Sidney Crosby";PlayerDatabase.P2PKRW = "Jake Guentzel";PlayerDatabase.P2PKLD = "Brian Dumoulin";PlayerDatabase.P2PKRD = "Kris Letang";PlayerDatabase.P2PKExW = "Bryan Rust";PlayerDatabase.P2PKExD = "Jan Rutta";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "STL") {
                PlayerDatabase.P2LW1 = "Pavel Buchnevich";
                PlayerDatabase.P2LW2 = "Josh Leivo";
                PlayerDatabase.P2LW3 = "Brandon Saad";
                PlayerDatabase.P2LW4 = "MacKenzie MacEachern";
                PlayerDatabase.P2C1 = "Ryan OReilly";
                PlayerDatabase.P2C2 = "Brayden Schenn";
                PlayerDatabase.P2C3 = "Robert Thomas";
                PlayerDatabase.P2C4 = "Noel Acciari";
                PlayerDatabase.P2RW1 = "Vladimir Tarasenko";
                PlayerDatabase.P2RW2 = "Jordan Kyrou";
                PlayerDatabase.P2RW3 = "James Neal";
                PlayerDatabase.P2RW4 = "Alexei Toropchenko";
                PlayerDatabase.P2LD1 = "Justin Faulk";
                PlayerDatabase.P2LD2 = "Torey Krug";
                PlayerDatabase.P2LD3 = "Steve Santini";
                PlayerDatabase.P2RD1 = "Colton Parayko";
                PlayerDatabase.P2RD2 = "Marco Scandella";
                PlayerDatabase.P2RD3 = "Robert Bortuzzo";
                PlayerDatabase.P2G = "Jordan Binnington";
                PlayerDatabase.P2PPLW = "Pavel Buchnevich";PlayerDatabase.P2PPC = "Ryan OReilly";PlayerDatabase.P2PPRW = "Vladimir Tarasenko";PlayerDatabase.P2PPLD = "Justin Faulk";PlayerDatabase.P2PPRD = "Colton Parayko";PlayerDatabase.P2PKLW = "Ryan OReilly";PlayerDatabase.P2PKRW = "Pavel Buchnevich";PlayerDatabase.P2PKLD = "Justin Faulk";PlayerDatabase.P2PKRD = "Colton Parayko";PlayerDatabase.P2PKExW = "Torey Krug";PlayerDatabase.P2PKExD = "Jordan Kyrou";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "SJS") {
                PlayerDatabase.P2LW1 = "Timo Meier";
                PlayerDatabase.P2LW2 = "Alexander Barabanov";
                PlayerDatabase.P2LW3 = "Ryan Dzingel";
                PlayerDatabase.P2LW4 = "Matt Nieto";
                PlayerDatabase.P2C1 = "Tomas Hertl";
                PlayerDatabase.P2C2 = "Logan Couture";
                PlayerDatabase.P2C3 = "Noah Gregor";
                PlayerDatabase.P2C4 = "Nick Bonino";
                PlayerDatabase.P2RW1 = "Kevin Labanc";
                PlayerDatabase.P2RW2 = "Luke Kunin";
                PlayerDatabase.P2RW3 = "Alexander Chmelevski";
                PlayerDatabase.P2RW4 = "Oskar Lindblom";
                PlayerDatabase.P2LD1 = "Erik Karlsson";
                PlayerDatabase.P2LD2 = "Matt Benning";
                PlayerDatabase.P2LD3 = "Jaycob Megna";
                PlayerDatabase.P2RD1 = "Markus Nutivaara";
                PlayerDatabase.P2RD2 = "Mario Ferraro";
                PlayerDatabase.P2RD3 = "MarcEdouard Vlasic";
                PlayerDatabase.P2G = "James Reimer";
                PlayerDatabase.P2PPLW = "Tomas Hertl";PlayerDatabase.P2PPC = "Logan Couture";PlayerDatabase.P2PPRW = "Luke Kunin";PlayerDatabase.P2PPLD = "Erik Karlsson";PlayerDatabase.P2PPRD = "Timo Meier";PlayerDatabase.P2PKLW = "Tomas Hertl";PlayerDatabase.P2PKRW = "Nick Bonino";PlayerDatabase.P2PKLD = "Matt Benning";PlayerDatabase.P2PKRD = "Markus Nutivaara";PlayerDatabase.P2PKExW = "Timo Meier";PlayerDatabase.P2PKExD = "Jaycob Megna";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "SEA") {
                PlayerDatabase.P2LW1 = "Jaden Schwartz";
                PlayerDatabase.P2LW2 = "Andre Burakovsky";
                PlayerDatabase.P2LW3 = "Brandon Tanev";
                PlayerDatabase.P2LW4 = "Riley Sheahan";
                PlayerDatabase.P2C1 = "Jared McCann";
                PlayerDatabase.P2C2 = "Ryan Donato";
                PlayerDatabase.P2C3 = "Yanni Gourde";
                PlayerDatabase.P2C4 = "Matthew Beniers";
                PlayerDatabase.P2RW1 = "Jordan Eberle";
                PlayerDatabase.P2RW2 = "Daniel Sprong";
                PlayerDatabase.P2RW3 = "Joonas Donskoi";
                PlayerDatabase.P2RW4 = "Karson Kuhlman";
                PlayerDatabase.P2LD1 = "Carson Soucy";
                PlayerDatabase.P2LD2 = "Vince Dunn";
                PlayerDatabase.P2LD3 = "Connor Carrick";
                PlayerDatabase.P2RD1 = "Jamie Oleksiak";
                PlayerDatabase.P2RD2 = "Dennis Cholowski";
                PlayerDatabase.P2RD3 = "Adam Larsson";
                PlayerDatabase.P2G = "Philipp Grubauer";
                PlayerDatabase.P2PPLW = "Jaden Schwartz";PlayerDatabase.P2PPC = "Ryan Donato";PlayerDatabase.P2PPRW = "Jordan Eberle";PlayerDatabase.P2PPLD = "Vince Dunn";PlayerDatabase.P2PPRD = "Jared McCann";PlayerDatabase.P2PKLW = "Joonas Donskoi";PlayerDatabase.P2PKRW = "Andre Burakovsky";PlayerDatabase.P2PKLD = "Carson Soucy";PlayerDatabase.P2PKRD = "Jamie Oleksiak";PlayerDatabase.P2PKExW = "Brandon Tanev";PlayerDatabase.P2PKExD = "Vince Dunn";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "TBL") {
                PlayerDatabase.P2LW1 = "Alex Killorn";
                PlayerDatabase.P2LW2 = "Nick Paul";
                PlayerDatabase.P2LW3 = "Vladislav Namestnikov";
                PlayerDatabase.P2LW4 = "Pat Maroon";
                PlayerDatabase.P2C1 = "Steven Stamkos";
                PlayerDatabase.P2C2 = "Brayden Point";
                PlayerDatabase.P2C3 = "Ross Colton";
                PlayerDatabase.P2C4 = "Anthony Cirelli";
                PlayerDatabase.P2RW1 = "Nikita Kucherov";
                PlayerDatabase.P2RW2 = "Alex BarreBoulet";
                PlayerDatabase.P2RW3 = "Charles Hudon";
                PlayerDatabase.P2RW4 = "Corey Perry";
                PlayerDatabase.P2LD1 = "Victor Hedman";
                PlayerDatabase.P2LD2 = "Mikhail Sergachev";
                PlayerDatabase.P2LD3 = "Ian Cole";
                PlayerDatabase.P2RD1 = "Erik Cernak";
                PlayerDatabase.P2RD2 = "Cal Foote";
                PlayerDatabase.P2RD3 = "Haydn Fleury";
                PlayerDatabase.P2G = "Andrei Vasilevskiy";
                PlayerDatabase.P2PPLW = "Alex Killorn";PlayerDatabase.P2PPC = "Brayden Point";PlayerDatabase.P2PPRW = "Nikita Kucherov";PlayerDatabase.P2PPLD = "Victor Hedman";PlayerDatabase.P2PPRD = "Steven Stamkos";PlayerDatabase.P2PKLW = "Brayden Point";PlayerDatabase.P2PKRW = "Nikita Kucherov";PlayerDatabase.P2PKLD = "Victor Hedman";PlayerDatabase.P2PKRD = "Erik Cernak";PlayerDatabase.P2PKExW = "Steven Stamkos";PlayerDatabase.P2PKExD = "Mikhail Sergachev";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "TOR") {
                PlayerDatabase.P2LW1 = "Michael Bunting";
                PlayerDatabase.P2LW2 = "Calle Jarnkrok";
                PlayerDatabase.P2LW3 = "Pierre Engvall";
                PlayerDatabase.P2LW4 = "Kyle Clifford";
                PlayerDatabase.P2C1 = "Auston Matthews";
                PlayerDatabase.P2C2 = "John Tavares";
                PlayerDatabase.P2C3 = "Alexander Kerfoot";
                PlayerDatabase.P2C4 = "Jason Spezza";
                PlayerDatabase.P2RW1 = "Mitchell Marner";
                PlayerDatabase.P2RW2 = "William Nylander";
                PlayerDatabase.P2RW3 = "Nicolas AubeKubel";
                PlayerDatabase.P2RW4 = "Joey Anderson";
                PlayerDatabase.P2LD1 = "Morgan Rielly";
                PlayerDatabase.P2LD2 = "Mark Giordano";
                PlayerDatabase.P2LD3 = "Jordie Benn";
                PlayerDatabase.P2RD1 = "Jake Muzzin";
                PlayerDatabase.P2RD2 = "TJ Brodie";
                PlayerDatabase.P2RD3 = "Timothy Liljegren";
                PlayerDatabase.P2G = "Ilya Samsonov";
                PlayerDatabase.P2PPLW = "Michael Bunting";PlayerDatabase.P2PPC = "Auston Matthews";PlayerDatabase.P2PPRW = "Mitchell Marner";PlayerDatabase.P2PPLD = "Morgan Rielly";PlayerDatabase.P2PPRD = "Mark Giordano";PlayerDatabase.P2PKLW = "Auston Matthews";PlayerDatabase.P2PKRW = "Mitchell Marner";PlayerDatabase.P2PKLD = "Morgan Rielly";PlayerDatabase.P2PKRD = "Jake Muzzin";PlayerDatabase.P2PKExW = "Michael Bunting";PlayerDatabase.P2PKExD = "TJ Brodie";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "VAN") {
                PlayerDatabase.P2LW1 = "Ilya Mikheyev";
                PlayerDatabase.P2LW2 = "Conor Garland";
                PlayerDatabase.P2LW3 = "Tanner Pearson";
                PlayerDatabase.P2LW4 = "Alex Chiasson";
                PlayerDatabase.P2C1 = "Bo Horvat";
                PlayerDatabase.P2C2 = "JT Miller";
                PlayerDatabase.P2C3 = "Elias Pettersson";
                PlayerDatabase.P2C4 = "Jason Dickinson";
                PlayerDatabase.P2RW1 = "Brock Boeser";
                PlayerDatabase.P2RW2 = "Michael Ferland";
                PlayerDatabase.P2RW3 = "Nils Hoglander";
                PlayerDatabase.P2RW4 = "Vasily Podkolzin";
                PlayerDatabase.P2LD1 = "Tucker Poolman";
                PlayerDatabase.P2LD2 = "Oliver EkmanLarsson";
                PlayerDatabase.P2LD3 = "Luke Schenn";
                PlayerDatabase.P2RD1 = "Tyler Myers";
                PlayerDatabase.P2RD2 = "Travis Dermott";
                PlayerDatabase.P2RD3 = "Quinn Hughes";
                PlayerDatabase.P2G = "Thatcher Demko";
                PlayerDatabase.P2PPLW = "Ilya Mikheyev";PlayerDatabase.P2PPC = "Bo Horvat";PlayerDatabase.P2PPRW = "Brock Boeser";PlayerDatabase.P2PPLD = "Conor Garland";PlayerDatabase.P2PPRD = "JT Miller";PlayerDatabase.P2PKLW = "Conor Garland";PlayerDatabase.P2PKRW = "Ilya Mikheyev";PlayerDatabase.P2PKLD = "Tucker Poolman";PlayerDatabase.P2PKRD = "Travis Dermott";PlayerDatabase.P2PKExW = "Michael Ferland";PlayerDatabase.P2PKExD = "Tyler Myers";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "VGK") {
                PlayerDatabase.P2LW1 = "Jonathan Marchessault";
                PlayerDatabase.P2LW2 = "Chandler Stephenson";
                PlayerDatabase.P2LW3 = "William Carrier";
                PlayerDatabase.P2LW4 = "Sven Bartschi";
                PlayerDatabase.P2C1 = "Jack Eichel";
                PlayerDatabase.P2C2 = "William Karlsson";
                PlayerDatabase.P2C3 = "Mike Amadio";
                PlayerDatabase.P2C4 = "Nolan Patrick";
                PlayerDatabase.P2RW1 = "Reilly Smith";
                PlayerDatabase.P2RW2 = "Mark Stone";
                PlayerDatabase.P2RW3 = "Nicolas Roy";
                PlayerDatabase.P2RW4 = "Keegan Kolesar";
                PlayerDatabase.P2LD1 = "Alex Pietrangelo";
                PlayerDatabase.P2LD2 = "Shea Weber";
                PlayerDatabase.P2LD3 = "Nicolas Hague";
                PlayerDatabase.P2RD1 = "Shea Theodore";
                PlayerDatabase.P2RD2 = "Zach Whitecloud";
                PlayerDatabase.P2RD3 = "Alec Martinez";
                PlayerDatabase.P2G = "Robin Lehner";
                PlayerDatabase.P2PPLW = "Jonathan Marchessault";PlayerDatabase.P2PPC = "Jack Eichel";PlayerDatabase.P2PPRW = "Reilly Smith";PlayerDatabase.P2PPLD = "Alex Pietrangelo";PlayerDatabase.P2PPRD = "Shea Theodore";PlayerDatabase.P2PKLW = "William Karlsson";PlayerDatabase.P2PKRW = "Reilly Smith";PlayerDatabase.P2PKLD = "Alex Pietrangelo";PlayerDatabase.P2PKRD = "Zach Whitecloud";PlayerDatabase.P2PKExW = "Mark Stone";PlayerDatabase.P2PKExD = "Shea Theodore";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "WAS") {
                PlayerDatabase.P2LW1 = "Alexander Ovechkin";
                PlayerDatabase.P2LW2 = "Carl Hagelin";
                PlayerDatabase.P2LW3 = "Garnet Hathaway";
                PlayerDatabase.P2LW4 = "Axel JonssonFjallby";
                PlayerDatabase.P2C1 = "Evgeny Kuznetsov";
                PlayerDatabase.P2C2 = "Nicklas Backstrom";
                PlayerDatabase.P2C3 = "Lars Eller";
                PlayerDatabase.P2C4 = "Dylan Strome";
                PlayerDatabase.P2RW1 = "Anthony Mantha";
                PlayerDatabase.P2RW2 = "Tom Wilson";
                PlayerDatabase.P2RW3 = "Connor Brown";
                PlayerDatabase.P2RW4 = "TJ Oshie";
                PlayerDatabase.P2LD1 = "Dmitry Orlov";
                PlayerDatabase.P2LD2 = "Martin Fehervary";
                PlayerDatabase.P2LD3 = "Nick Jensen";
                PlayerDatabase.P2RD1 = "John Carlson";
                PlayerDatabase.P2RD2 = "Michal Kempny";
                PlayerDatabase.P2RD3 = "Erik Gustafsson";
                PlayerDatabase.P2G = "Darcy Kuemper";
                PlayerDatabase.P2PPLW = "Alexander Ovechkin";PlayerDatabase.P2PPC = "Evgeny Kuznetsov";PlayerDatabase.P2PPRW = "Tom Wilson";PlayerDatabase.P2PPLD = "Anthony Mantha";PlayerDatabase.P2PPRD = "John Carlson";PlayerDatabase.P2PKLW = "Carl Hagelin";PlayerDatabase.P2PKRW = "Garnet Hathaway";PlayerDatabase.P2PKLD = "Martin Fehervary";PlayerDatabase.P2PKRD = "Michal Kempny";PlayerDatabase.P2PKExW = "Evgeny Kuznetsov";PlayerDatabase.P2PKExD = "Dmitry Orlov";
            }
            else if (PlayerDatabase.ComputerChosenTeam == "WPG") {
                PlayerDatabase.P2LW1 = "Nikolaj Ehlers";
                PlayerDatabase.P2LW2 = "Kyle Connor";
                PlayerDatabase.P2LW3 = "Cole Perfetti";
                PlayerDatabase.P2LW4 = "Kristian Vesalainen";
                PlayerDatabase.P2C1 = "Mark Scheifele";
                PlayerDatabase.P2C2 = "Paul Stastny";
                PlayerDatabase.P2C3 = "PierreLuc Dubois";
                PlayerDatabase.P2C4 = "Adam Lowry";
                PlayerDatabase.P2RW1 = "Blake Wheeler";
                PlayerDatabase.P2RW2 = "Mason Appleton";
                PlayerDatabase.P2RW3 = "Evgeny Svechnikov";
                PlayerDatabase.P2RW4 = "Austin Poganski";
                PlayerDatabase.P2LD1 = "Nate Schmidt";
                PlayerDatabase.P2LD2 = "Neal Pionk";
                PlayerDatabase.P2LD3 = "Dylan Samberg";
                PlayerDatabase.P2RD1 = "Brenden Dillon";
                PlayerDatabase.P2RD2 = "Dylan DeMelo";
                PlayerDatabase.P2RD3 = "Logan Stanley";
                PlayerDatabase.P2G = "Connor Hellebuyck";
                PlayerDatabase.P2PPLW = "Nikolaj Ehlers";PlayerDatabase.P2PPC = "Mark Scheifele";PlayerDatabase.P2PPRW = "Blake Wheeler";PlayerDatabase.P2PPLD = "Neal Pionk";PlayerDatabase.P2PPRD = "Dylan DeMelo";PlayerDatabase.P2PKLW = "Nikolaj Ehlers";PlayerDatabase.P2PKRW = "Paul Stastny";PlayerDatabase.P2PKLD = "Dylan Samberg";PlayerDatabase.P2PKRD = "Brenden Dillon";PlayerDatabase.P2PKExW = "Cole Perfetti";PlayerDatabase.P2PKExD = "Dylan DeMelo";
            }
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (PlayerDatabase.ComputerChosenTeam == "ANA") {
				PlayerDatabase.P2LW1 = "Paul Kariya";
				PlayerDatabase.P2LW2 = "Chris Kunitz";
				PlayerDatabase.P2LW3 = "Bobby Ryan";
				PlayerDatabase.P2LW4 = "Jakob Silfverberg";
				PlayerDatabase.P2C1 = "Ryan Getzlaf";
				PlayerDatabase.P2C2 = "Andy McDonald";
				PlayerDatabase.P2C3 = "Rickard Rakell";
				PlayerDatabase.P2C4 = "Steve Rucchin";
				PlayerDatabase.P2RW1 = "Teemu Selanne";
				PlayerDatabase.P2RW2 = "Petr Sykora";
				PlayerDatabase.P2RW3 = "Corey Perry";
				PlayerDatabase.P2RW4 = "Andrew Cogliano";
				PlayerDatabase.P2LD1 = "Hampus Lindholm";
				PlayerDatabase.P2LD2 = "Cam Fowler";
				PlayerDatabase.P2LD3 = "Josh Manson";
				PlayerDatabase.P2RD1 = "Scott Niedermayer";
				PlayerDatabase.P2RD2 = "Chris Pronger";
				PlayerDatabase.P2RD3 = "Francois Beauchemin";
				PlayerDatabase.P2G = "John Gibson";
                PlayerDatabase.P2PPLW = "Paul Kariya";
                PlayerDatabase.P2PPC = "Ryan Getzlaf";
                PlayerDatabase.P2PPRW = "Teemu Selanne";
                PlayerDatabase.P2PPLD = "Bobby Ryan";
                PlayerDatabase.P2PPRD = "Petr Sykora";
                PlayerDatabase.P2PKLW = "Chris Kunitz";
                PlayerDatabase.P2PKRW = "Teemu Selanne";
                PlayerDatabase.P2PKLD = "Hampus Lindholm";
                PlayerDatabase.P2PKRD = "Chris Pronger";
                PlayerDatabase.P2PKExW = "Paul Kariya";
                PlayerDatabase.P2PKExD = "Francois Beauchemin";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "ATL") {
				PlayerDatabase.P2LW1 = "Ilya Kovalchuk";
				PlayerDatabase.P2LW2 = "Donald Audette";
				PlayerDatabase.P2LW3 = "Vyacheslav Kozlov";
				PlayerDatabase.P2LW4 = "Shawn McEachern";
				PlayerDatabase.P2C1 = "Bryan Little";
				PlayerDatabase.P2C2 = "Marc Savard";
				PlayerDatabase.P2C3 = "Ray Ferraro";
				PlayerDatabase.P2C4 = "Patrik Stefan";
				PlayerDatabase.P2RW1 = "Marian Hossa";
				PlayerDatabase.P2RW2 = "Dany Heatley";
				PlayerDatabase.P2RW3 = "Colby Armstrong";
				PlayerDatabase.P2RW4 = "Nikolai Antropov";
				PlayerDatabase.P2LD1 = "Dustin Byfuglien";
				PlayerDatabase.P2LD2 = "Tobias Enstrom";
				PlayerDatabase.P2LD3 = "Frantisek Kaberle";
				PlayerDatabase.P2RD1 = "Zach Bogosian";
				PlayerDatabase.P2RD2 = "Greg DeVries";
				PlayerDatabase.P2RD3 = "Ron Hainsey";
				PlayerDatabase.P2G = "Kari Lehtonen";
                PlayerDatabase.P2PPLW = "Ilya Kovalchuk";
                PlayerDatabase.P2PPC = "Bryan Little";
                PlayerDatabase.P2PPRW = "Marian Hossa";
                PlayerDatabase.P2PPLD = "Donald Audette";
                PlayerDatabase.P2PPRD = "Dany Heatley";
                PlayerDatabase.P2PKLW = "Marian Hossa";
                PlayerDatabase.P2PKRW = "Colby Armstrong";
                PlayerDatabase.P2PKLD = "Dustin Byfuglien";
                PlayerDatabase.P2PKRD = "Greg DeVries";
                PlayerDatabase.P2PKExW = "Ilya Kovalchuk";
                PlayerDatabase.P2PKExD = "Frantisek Kaberle";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BOS") {
				PlayerDatabase.P2LW1 = "Ken Hodge";
				PlayerDatabase.P2LW2 = "Brad Marchand";
				PlayerDatabase.P2LW3 = "Fred Stanfield";
				PlayerDatabase.P2LW4 = "Sergei Samsonov";
				PlayerDatabase.P2C1 = "Phil Esposito";
				PlayerDatabase.P2C2 = "Patrice Bergeron";
				PlayerDatabase.P2C3 = "Peter McNab";
				PlayerDatabase.P2C4 = "David Krejci";
				PlayerDatabase.P2RW1 = "Cam Neely";
				PlayerDatabase.P2RW2 = "Rick Middleton";
				PlayerDatabase.P2RW3 = "Woody Dumart";
				PlayerDatabase.P2RW4 = "Wayne Cashman";
				PlayerDatabase.P2LD1 = "Raymond Bourque";
				PlayerDatabase.P2LD2 = "Brad Park";
				PlayerDatabase.P2LD3 = "Zdeno Chara";
				PlayerDatabase.P2RD1 = "Bobby Orr";
				PlayerDatabase.P2RD2 = "Dit Clapper";
				PlayerDatabase.P2RD3 = "Mike OConnell";
				PlayerDatabase.P2G = "Tuukka Rask";
                PlayerDatabase.P2PPLW = "Ken Hodge";
                PlayerDatabase.P2PPC = "Phil Esposito";
                PlayerDatabase.P2PPRW = "Cam Neely";
                PlayerDatabase.P2PPLD = "Raymond Bourque";
                PlayerDatabase.P2PPRD = "Patrice Bergeron";
                PlayerDatabase.P2PKLW = "Ken Hodge";
                PlayerDatabase.P2PKRW = "Phil Esposito";
                PlayerDatabase.P2PKLD = "Raymond Bourque";
                PlayerDatabase.P2PKRD = "Bobby Orr";
                PlayerDatabase.P2PKExW = "Cam Neely";
                PlayerDatabase.P2PKExD = "Brad Park";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BUF") {
				PlayerDatabase.P2LW1 = "Rick Martin";
				PlayerDatabase.P2LW2 = "Don Luce";
				PlayerDatabase.P2LW3 = "Dave Andreychuk";
				PlayerDatabase.P2LW4 = "Jochen Hecht";
				PlayerDatabase.P2C1 = "Pat LaFontaine";
				PlayerDatabase.P2C2 = "Rene Robert";
				PlayerDatabase.P2C3 = "Gilbert Perreault";
				PlayerDatabase.P2C4 = "Derek Roy";
				PlayerDatabase.P2RW1 = "Danny Gare";
				PlayerDatabase.P2RW2 = "Alexander Mogilny";
				PlayerDatabase.P2RW3 = "Mike Foligno";
				PlayerDatabase.P2RW4 = "Jason Pominville";
				PlayerDatabase.P2LD1 = "John VanBoxmeer";
				PlayerDatabase.P2LD2 = "Phil Housley";
				PlayerDatabase.P2LD3 = "Alexei Zhitnik";
				PlayerDatabase.P2RD1 = "Doug Bodger";
				PlayerDatabase.P2RD2 = "Jerry Korab";
				PlayerDatabase.P2RD3 = "Bill Hajt";
				PlayerDatabase.P2G = "Dominik Hasek";
                PlayerDatabase.P2PPLW = "Rick Martin";
                PlayerDatabase.P2PPC = "Pat LaFontaine";
                PlayerDatabase.P2PPRW = "Danny Gare";
                PlayerDatabase.P2PPLD = "Rene Robert";
                PlayerDatabase.P2PPRD = "Alexander Mogilny";
                PlayerDatabase.P2PKLW = "Don Luce";
                PlayerDatabase.P2PKRW = "Danny Gare";
                PlayerDatabase.P2PKLD = "John VanBoxmeer";
                PlayerDatabase.P2PKRD = "Bill Hajt";
                PlayerDatabase.P2PKExW = "Mike Foligno";
                PlayerDatabase.P2PKExD = "Phil Housley";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAL") {
                PlayerDatabase.P2LW1 = "Gary Roberts";
                PlayerDatabase.P2LW2 = "Hakan Loob";
                PlayerDatabase.P2LW3 = "Johnny Gaudreau";
                PlayerDatabase.P2LW4 = "Matthew Tkachuk";
                PlayerDatabase.P2C1 = "Joe Nieuwendyk";
                PlayerDatabase.P2C2 = "Mikael Backlund";
                PlayerDatabase.P2C3 = "Sean Monahan";
                PlayerDatabase.P2C4 = "Kent Nilsson";
                PlayerDatabase.P2RW1 = "Theo Fleury";
                PlayerDatabase.P2RW2 = "Jarome Iginla";
                PlayerDatabase.P2RW3 = "Joe Mullen";
                PlayerDatabase.P2RW4 = "Lanny McDonald";
                PlayerDatabase.P2LD1 = "Al MacInnis";
                PlayerDatabase.P2LD2 = "Mark Giordano";
                PlayerDatabase.P2LD3 = "Phil Housley";
                PlayerDatabase.P2RD1 = "Dion Phaneuf";
                PlayerDatabase.P2RD2 = "Gary Suter";
                PlayerDatabase.P2RD3 = "Jamie Macoun";
                PlayerDatabase.P2G = "Mike Vernon";
                PlayerDatabase.P2PPLW = "Gary Roberts";
                PlayerDatabase.P2PPC = "Joe Nieuwendyk";
                PlayerDatabase.P2PPRW = "Theo Fleury";
                PlayerDatabase.P2PPLD = "Al MacInnis";
                PlayerDatabase.P2PPRD = "Jarome Iginla";
                PlayerDatabase.P2PKLW = "Gary Roberts";
                PlayerDatabase.P2PKRW = "Joe Mullen";
                PlayerDatabase.P2PKLD = "Al MacInnis";
                PlayerDatabase.P2PKRD = "Jamie Macoun";
                PlayerDatabase.P2PKExW = "Joe Nieuwendyk";
                PlayerDatabase.P2PKExD = "Gary Suter";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "CAR") {
                PlayerDatabase.P2LW1 = "Jeff Skinner";
                PlayerDatabase.P2LW2 = "Erik Cole";
                PlayerDatabase.P2LW3 = "Chad Larose";
                PlayerDatabase.P2LW4 = "Ray Whitney";
                PlayerDatabase.P2C1 = "Eric Staal";
                PlayerDatabase.P2C2 = "Sebastian Aho";
                PlayerDatabase.P2C3 = "Rod BrindAmour";
                PlayerDatabase.P2C4 = "Ron Francis";
                PlayerDatabase.P2RW1 = "Andrei Svechnikov";
                PlayerDatabase.P2RW2 = "Sami Kapanen";
                PlayerDatabase.P2RW3 = "Jeff ONeill";
                PlayerDatabase.P2RW4 = "Justin Williams";
                PlayerDatabase.P2LD1 = "Sean Hill";
                PlayerDatabase.P2LD2 = "Joe Corvo";
                PlayerDatabase.P2LD3 = "Justin Faulk";
                PlayerDatabase.P2RD1 = "Dougie Hamilton";
                PlayerDatabase.P2RD2 = "Joni Pitkanen";
                PlayerDatabase.P2RD3 = "Brett Pesce";
                PlayerDatabase.P2G = "Kevin Weekes";
                PlayerDatabase.P2PPLW = "Jeff Skinner";
                PlayerDatabase.P2PPC = "Eric Staal";
                PlayerDatabase.P2PPRW = "Andrei Svechnikov";
                PlayerDatabase.P2PPLD = "Sebastian Aho";
                PlayerDatabase.P2PPRD = "Dougie Hamilton";
                PlayerDatabase.P2PKLW = "Sebastian Aho";
                PlayerDatabase.P2PKRW = "Andrei Svechnikov";
                PlayerDatabase.P2PKLD = "Dougie Hamilton";
                PlayerDatabase.P2PKRD = "Brett Pesce";
                PlayerDatabase.P2PKExW = "Erik Cole";
                PlayerDatabase.P2PKExD = "Sean Hill";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "CBJ") {
                PlayerDatabase.P2LW1 = "Rick Nash";
                PlayerDatabase.P2LW2 = "Geoff Sanderson";
                PlayerDatabase.P2LW3 = "Nikolai Zherdev";
                PlayerDatabase.P2LW4 = "Nick Foligno";
                PlayerDatabase.P2C1 = "Boone Jenner";
                PlayerDatabase.P2C2 = "RJ Umberger";
                PlayerDatabase.P2C3 = "Brandon Dubinsky";
                PlayerDatabase.P2C4 = "Alexander Wennberg";
                PlayerDatabase.P2RW1 = "Cam Atkinson";
                PlayerDatabase.P2RW2 = "Artemi Panarin";
                PlayerDatabase.P2RW3 = "Oliver Bjorkstrand";
                PlayerDatabase.P2RW4 = "Jason Chimera";
                PlayerDatabase.P2LD1 = "Seth Jones";
                PlayerDatabase.P2LD2 = "James Wisniewski";
                PlayerDatabase.P2LD3 = "Ron Hainsey";
                PlayerDatabase.P2RD1 = "Zach Werenski";
                PlayerDatabase.P2RD2 = "Ryan Murray";
                PlayerDatabase.P2RD3 = "David Savard";
                PlayerDatabase.P2G = "Sergei Bobrovsky";
                PlayerDatabase.P2PPLW = "Rick Nash";
                PlayerDatabase.P2PPC = "Boone Jenner";
                PlayerDatabase.P2PPRW = "Cam Atkinson";
                PlayerDatabase.P2PPLD = "Seth Jones";
                PlayerDatabase.P2PPRD = "Geoff Sanderson";
                PlayerDatabase.P2PKLW = "Nick Foligno";
                PlayerDatabase.P2PKRW = "Artemi Panarin";
                PlayerDatabase.P2PKLD = "Seth Jones";
                PlayerDatabase.P2PKRD = "Zach Werenski";
                PlayerDatabase.P2PKExW = "Brandon Dubinsky";
                PlayerDatabase.P2PKExD = "Ryan Murray";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "CHI") {
                PlayerDatabase.P2LW1 = "Bobby Hull";
                PlayerDatabase.P2LW2 = "Doug Bentley";
                PlayerDatabase.P2LW3 = "Patrick Sharp";
                PlayerDatabase.P2LW4 = "Eric Daze";
                PlayerDatabase.P2C1 = "Stan Mikita";
                PlayerDatabase.P2C2 = "Pit Martin";
                PlayerDatabase.P2C3 = "Jeremy Roenick";
                PlayerDatabase.P2C4 = "Jonathan Toews";
                PlayerDatabase.P2RW1 = "Tony Amonte";
                PlayerDatabase.P2RW2 = "Patrick Kane";
                PlayerDatabase.P2RW3 = "Bill Mosienko";
                PlayerDatabase.P2RW4 = "Steve Larmer";
                PlayerDatabase.P2LD1 = "Doug Wilson";
                PlayerDatabase.P2LD2 = "Phil Russell";
                PlayerDatabase.P2LD3 = "Pierre Pilote";
                PlayerDatabase.P2RD1 = "Chris Chelios";
                PlayerDatabase.P2RD2 = "Duncan Keith";
                PlayerDatabase.P2RD3 = "Pat Stapleton";
                PlayerDatabase.P2G = "Tony Esposito";
                PlayerDatabase.P2PPLW = "Bobby Hull";
                PlayerDatabase.P2PPC = "Stan Mikita";
                PlayerDatabase.P2PPRW = "Tony Amonte";
                PlayerDatabase.P2PPLD = "Patrick Kane";
                PlayerDatabase.P2PPRD = "Chris Chelios";
                PlayerDatabase.P2PKLW = "Bobby Hull";
                PlayerDatabase.P2PKRW = "Stan Mikita";
                PlayerDatabase.P2PKLD = "Pierre Pilote";
                PlayerDatabase.P2PKRD = "Pat Stapleton";
                PlayerDatabase.P2PKExW = "Jonathan Toews";
                PlayerDatabase.P2PKExD = "Chris Chelios";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "COL") {
                PlayerDatabase.P2LW1 = "Nathan MacKinnon";
                PlayerDatabase.P2LW2 = "Valeri Kamensky";
                PlayerDatabase.P2LW3 = "Gabriel Landeskog";
                PlayerDatabase.P2LW4 = "Alex Tanguay";
                PlayerDatabase.P2C1 = "Joe Sakic";
                PlayerDatabase.P2C2 = "Peter Forsberg";
                PlayerDatabase.P2C3 = "Paul Stastny";
                PlayerDatabase.P2C4 = "Matt Duchene";
                PlayerDatabase.P2RW1 = "Claude Lemieux";
                PlayerDatabase.P2RW2 = "Adam Deadmarsh";
                PlayerDatabase.P2RW3 = "Milan Hejduk";
                PlayerDatabase.P2RW4 = "Andrew Brunette";
                PlayerDatabase.P2LD1 = "Cale Makar";
                PlayerDatabase.P2LD2 = "Sandis Ozolinsh";
                PlayerDatabase.P2LD3 = "Tyson Barrie";
                PlayerDatabase.P2RD1 = "Rob Blake";
                PlayerDatabase.P2RD2 = "Erik Johnson";
                PlayerDatabase.P2RD3 = "Brett Clark";
                PlayerDatabase.P2G = "Patrick Roy";
                PlayerDatabase.P2PPLW = "Nathan MacKinnon";
                PlayerDatabase.P2PPC = "Joe Sakic";
                PlayerDatabase.P2PPRW = "Claude Lemieux";
                PlayerDatabase.P2PPLD = "Cale Makar";
                PlayerDatabase.P2PPRD = "Peter Forsberg";
                PlayerDatabase.P2PKLW = "Joe Sakic";
                PlayerDatabase.P2PKRW = "Peter Forsberg";
                PlayerDatabase.P2PKLD = "Cale Makar";
                PlayerDatabase.P2PKRD = "Rob Blake";
                PlayerDatabase.P2PKExW = "Alex Tanguay";
                PlayerDatabase.P2PKExD = "Erik Johnson";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "DAL") {
                PlayerDatabase.P2LW1 = "Jere Lehtinen";
                PlayerDatabase.P2LW2 = "Jamie Benn";
                PlayerDatabase.P2LW3 = "Brett Hull";
                PlayerDatabase.P2LW4 = "Brenden Morrow";
                PlayerDatabase.P2C1 = "Tyler Seguin";
                PlayerDatabase.P2C2 = "Mike Modano";
                PlayerDatabase.P2C3 = "Joe Nieuwendyk";
                PlayerDatabase.P2C4 = "Mike Ribeiro";
                PlayerDatabase.P2RW1 = "Bill Guerin";
                PlayerDatabase.P2RW2 = "Loui Eriksson";
                PlayerDatabase.P2RW3 = "Alexander Radulov";
                PlayerDatabase.P2RW4 = "Jamie Langenbrunner";
                PlayerDatabase.P2LD1 = "John Klingberg";
                PlayerDatabase.P2LD2 = "Sergei Zubov";
                PlayerDatabase.P2LD3 = "Esa Lindell";
                PlayerDatabase.P2RD1 = "Philippe Boucher";
                PlayerDatabase.P2RD2 = "Derian Hatcher";
                PlayerDatabase.P2RD3 = "Trevor Daley";
                PlayerDatabase.P2G = "Marty Turco";
                PlayerDatabase.P2PPLW = "Jere Lehtinen";
                PlayerDatabase.P2PPC = "Mike Modano";
                PlayerDatabase.P2PPRW = "Bill Guerin";
                PlayerDatabase.P2PPLD = "Jamie Benn";
                PlayerDatabase.P2PPRD = "Tyler Seguin";
                PlayerDatabase.P2PKLW = "Jere Lehtinen";
                PlayerDatabase.P2PKRW = "Mike Modano";
                PlayerDatabase.P2PKLD = "Esa Lindell";
                PlayerDatabase.P2PKRD = "Derian Hatcher";
                PlayerDatabase.P2PKExW = "Brenden Morrow";
                PlayerDatabase.P2PKExD = "Philippe Boucher";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "DET") {
                PlayerDatabase.P2LW1 = "Brendan Shanahan";
                PlayerDatabase.P2LW2 = "Ted Lindsay";
                PlayerDatabase.P2LW3 = "Daniel Cleary";
                PlayerDatabase.P2LW4 = "John Ogrodnick";
                PlayerDatabase.P2C1 = "Steve Yzerman";
                PlayerDatabase.P2C2 = "Henrik Zetterberg";
                PlayerDatabase.P2C3 = "Pavel Datsyuk";
                PlayerDatabase.P2C4 = "Alex Delvecchio";
                PlayerDatabase.P2RW1 = "Sergei Fedorov";
                PlayerDatabase.P2RW2 = "Gordie Howe";
                PlayerDatabase.P2RW3 = "Mickey Redmond";
                PlayerDatabase.P2RW4 = "Tomas Holmstrom";
                PlayerDatabase.P2LD1 = "Nicklas Lidstrom";
                PlayerDatabase.P2LD2 = "Steve Chiasson";
                PlayerDatabase.P2LD3 = "William Huber";
                PlayerDatabase.P2RD1 = "Paul Coffey";
                PlayerDatabase.P2RD2 = "Reed Larson";
                PlayerDatabase.P2RD3 = "Brian Rafalski";
                PlayerDatabase.P2G = "Terry Sawchuk";
                PlayerDatabase.P2PPLW = "Brendan Shanahan";
                PlayerDatabase.P2PPC = "Steve Yzerman";
                PlayerDatabase.P2PPRW = "Sergei Fedorov";
                PlayerDatabase.P2PPLD = "Nicklas Lidstrom";
                PlayerDatabase.P2PPRD = "Gordie Howe";
                PlayerDatabase.P2PKLW = "Pavel Datsyuk";
                PlayerDatabase.P2PKRW = "Sergei Fedorov";
                PlayerDatabase.P2PKLD = "Nicklas Lidstrom";
                PlayerDatabase.P2PKRD = "Paul Coffey";
                PlayerDatabase.P2PKExW = "Gordie Howe";
                PlayerDatabase.P2PKExD = "Brian Rafalski";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "EDM") {
                PlayerDatabase.P2LW1 = "Connor McDavid";
                PlayerDatabase.P2LW2 = "Esa Tikkanen";
                PlayerDatabase.P2LW3 = "Taylor Hall";
                PlayerDatabase.P2LW4 = "Ryan Smyth";
                PlayerDatabase.P2C1 = "Wayne Gretzky";
                PlayerDatabase.P2C2 = "Mark Messier";
                PlayerDatabase.P2C3 = "Leon Draisaitl";
                PlayerDatabase.P2C4 = "Doug Weight";
                PlayerDatabase.P2RW1 = "Jari Kurri";
                PlayerDatabase.P2RW2 = "Glenn Anderson";
                PlayerDatabase.P2RW3 = "Jordan Eberle";
                PlayerDatabase.P2RW4 = "Sam Gagner";
                PlayerDatabase.P2LD1 = "Paul Coffey";
                PlayerDatabase.P2LD2 = "Charlie Huddy";
                PlayerDatabase.P2LD3 = "Boris Mironov";
                PlayerDatabase.P2RD1 = "Randy Gregg";
                PlayerDatabase.P2RD2 = "Darnell Nurse";
                PlayerDatabase.P2RD3 = "Steve Smith";
                PlayerDatabase.P2G = "Grant Fuhr";
                PlayerDatabase.P2PPLW = "Connor McDavid";
                PlayerDatabase.P2PPC = "Wayne Gretzky";
                PlayerDatabase.P2PPRW = "Jari Kurri";
                PlayerDatabase.P2PPLD = "Paul Coffey";
                PlayerDatabase.P2PPRD = "Mark Messier";
                PlayerDatabase.P2PKLW = "Wayne Gretzky";
                PlayerDatabase.P2PKRW = "Jari Kurri";
                PlayerDatabase.P2PKLD = "Paul Coffey";
                PlayerDatabase.P2PKRD = "Randy Gregg";
                PlayerDatabase.P2PKExW = "Mark Messier";
                PlayerDatabase.P2PKExD = "Charlie Huddy";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "FLA") {
                PlayerDatabase.P2LW1 = "David Booth";
                PlayerDatabase.P2LW2 = "Jonathan Huberdeau";
                PlayerDatabase.P2LW3 = "Ray Whitney";
                PlayerDatabase.P2LW4 = "Evgeny Dadonov";
                PlayerDatabase.P2C1 = "Aleksander Barkov";
                PlayerDatabase.P2C2 = "Olli Jokinen";
                PlayerDatabase.P2C3 = "Viktor Kozlov";
                PlayerDatabase.P2C4 = "Vincent Trocheck";
                PlayerDatabase.P2RW1 = "Pavel Bure";
                PlayerDatabase.P2RW2 = "Nathan Horton";
                PlayerDatabase.P2RW3 = "Radek Dvorak";
                PlayerDatabase.P2RW4 = "Scott Mellanby";
                PlayerDatabase.P2LD1 = "Bryan McCabe";
                PlayerDatabase.P2LD2 = "Keith Yandle";
                PlayerDatabase.P2LD3 = "Brian Campbell";
                PlayerDatabase.P2RD1 = "Aaron Ekblad";
                PlayerDatabase.P2RD2 = "Jay Bouwmeester";
                PlayerDatabase.P2RD3 = "Ed Jovanovski";
                PlayerDatabase.P2G = "Roberto Luongo";
                PlayerDatabase.P2PPLW = "David Booth";
                PlayerDatabase.P2PPC = "Aleksander Barkov";
                PlayerDatabase.P2PPRW = "Pavel Bure";
                PlayerDatabase.P2PPLD = "Olli Jokinen";
                PlayerDatabase.P2PPRD = "Aaron Ekblad";
                PlayerDatabase.P2PKLW = "Aleksander Barkov";
                PlayerDatabase.P2PKRW = "Pavel Bure";
                PlayerDatabase.P2PKLD = "Bryan McCabe";
                PlayerDatabase.P2PKRD = "Aaron Ekblad";
                PlayerDatabase.P2PKExW = "Ray Whitney";
                PlayerDatabase.P2PKExD = "Brian Campbell";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "HAR") {
                PlayerDatabase.P2LW1 = "Geoff Sanderson";
                PlayerDatabase.P2LW2 = "John Anderson";
                PlayerDatabase.P2LW3 = "Paul MacDermid";
                PlayerDatabase.P2LW4 = "Blaine Stoughton";
                PlayerDatabase.P2C1 = "Mike Rogers";
                PlayerDatabase.P2C2 = "Ron Francis";
                PlayerDatabase.P2C3 = "Andrew Cassels";
                PlayerDatabase.P2C4 = "Dean Evason";
                PlayerDatabase.P2RW1 = "Sylvain Turgeon";
                PlayerDatabase.P2RW2 = "Kevin Dineen";
                PlayerDatabase.P2RW3 = "Pat Verbeek";
                PlayerDatabase.P2RW4 = "Scott Young";
                PlayerDatabase.P2LD1 = "Ulf Samuelsson";
                PlayerDatabase.P2LD2 = "Al Sims";
                PlayerDatabase.P2LD3 = "Sylvain Cote";
                PlayerDatabase.P2RD1 = "Mark Howe";
                PlayerDatabase.P2RD2 = "Adam Burt";
                PlayerDatabase.P2RD3 = "Brad Shaw";
                PlayerDatabase.P2G = "Mike Liut";
                PlayerDatabase.P2PPLW = "Geoff Sanderson";
                PlayerDatabase.P2PPC = "Mike Rogers";
                PlayerDatabase.P2PPRW = "Sylvain Turgeon";
                PlayerDatabase.P2PPLD = "Ron Francis";
                PlayerDatabase.P2PPRD = "Kevin Dineen";
                PlayerDatabase.P2PKLW = "John Anderson";
                PlayerDatabase.P2PKRW = "Mike Rogers";
                PlayerDatabase.P2PKLD = "Ulf Samuelsson";
                PlayerDatabase.P2PKRD = "Mark Howe";
                PlayerDatabase.P2PKExW = "Paul MacDermid";
                PlayerDatabase.P2PKExD = "Sylvain Cote";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "LAK") {
                PlayerDatabase.P2LW1 = "Wayne Gretzky";
                PlayerDatabase.P2LW2 = "Charlie Simmer";
                PlayerDatabase.P2LW3 = "Alexander Frolov";
                PlayerDatabase.P2LW4 = "Luc Robitaille";
                PlayerDatabase.P2C1 = "Marcel Dionne";
                PlayerDatabase.P2C2 = "Anze Kopitar";
                PlayerDatabase.P2C3 = "Bernie Nicholls";
                PlayerDatabase.P2C4 = "Butch Goring";
                PlayerDatabase.P2RW1 = "Zigmund Palffy";
                PlayerDatabase.P2RW2 = "Dave Taylor";
                PlayerDatabase.P2RW3 = "Mike Murphy";
                PlayerDatabase.P2RW4 = "Jari Kurri";
                PlayerDatabase.P2LD1 = "Drew Doughty";
                PlayerDatabase.P2LD2 = "Steve Duchesne";
                PlayerDatabase.P2LD3 = "Jake Muzzin";
                PlayerDatabase.P2RD1 = "Rob Blake";
                PlayerDatabase.P2RD2 = "Larry Murphy";
                PlayerDatabase.P2RD3 = "Marty McSorley";
                PlayerDatabase.P2G = "Kelly Hrudey";
                PlayerDatabase.P2PPLW = "Wayne Gretzky";
                PlayerDatabase.P2PPC = "Marcel Dionne";
                PlayerDatabase.P2PPRW = "Zigmund Palffy";
                PlayerDatabase.P2PPLD = "Dave Taylor";
                PlayerDatabase.P2PPRD = "Rob Blake";
                PlayerDatabase.P2PKLW = "Charlie Simmer";
                PlayerDatabase.P2PKRW = "Zigmund Palffy";
                PlayerDatabase.P2PKLD = "Drew Doughty";
                PlayerDatabase.P2PKRD = "Marty McSorley";
                PlayerDatabase.P2PKExW = "Dave Taylor";
                PlayerDatabase.P2PKExD = "Steve Duchesne";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "MNS") {
                PlayerDatabase.P2LW1 = "Bill Goldsworthy";
                PlayerDatabase.P2LW2 = "Danny Grant";
                PlayerDatabase.P2LW3 = "Steve Payne";
                PlayerDatabase.P2LW4 = "JeanPaul Parise";
                PlayerDatabase.P2C1 = "Mike Modano";
                PlayerDatabase.P2C2 = "Jude Drouin";
                PlayerDatabase.P2C3 = "Neal Broten";
                PlayerDatabase.P2C4 = "Dave Gagner";
                PlayerDatabase.P2RW1 = "Brian Bellows";
                PlayerDatabase.P2RW2 = "Dino Ciccarelli";
                PlayerDatabase.P2RW3 = "Tom McCarthy";
                PlayerDatabase.P2RW4 = "Al MacAdam";
                PlayerDatabase.P2LD1 = "Barry Gibbs";
                PlayerDatabase.P2LD2 = "Craig Hartsburg";
                PlayerDatabase.P2LD3 = "Gordie Roberts";
                PlayerDatabase.P2RD1 = "Gary Sargent";
                PlayerDatabase.P2RD2 = "Brad Maxwell";
                PlayerDatabase.P2RD3 = "Mark Tinordi";
                PlayerDatabase.P2G = "Don Beaupre";
                PlayerDatabase.P2PPLW = "Bill Goldsworthy";
                PlayerDatabase.P2PPC = "Mike Modano";
                PlayerDatabase.P2PPRW = "Brian Bellows";
                PlayerDatabase.P2PPLD = "Danny Grant";
                PlayerDatabase.P2PPRD = "Dino Ciccarelli";
                PlayerDatabase.P2PKLW = "Danny Grant";
                PlayerDatabase.P2PKRW = "Neal Broten";
                PlayerDatabase.P2PKLD = "Gordie Roberts";
                PlayerDatabase.P2PKRD = "Gary Sargent";
                PlayerDatabase.P2PKExW = "Tom McCarthy";
                PlayerDatabase.P2PKExD = "Mark Tinordi";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "MNW") {
                PlayerDatabase.P2LW1 = "Marian Gaborik";
                PlayerDatabase.P2LW2 = "Zach Parise";
                PlayerDatabase.P2LW3 = "Cal Clutterbuck";
                PlayerDatabase.P2LW4 = "Marcus Foligno";
                PlayerDatabase.P2C1 = "Mikko Koivu";
                PlayerDatabase.P2C2 = "Mikael Granlund";
                PlayerDatabase.P2C3 = "Eric Staal";
                PlayerDatabase.P2C4 = "PierreMarc Bouchard";
                PlayerDatabase.P2RW1 = "Jason Pominville";
                PlayerDatabase.P2RW2 = "Jason Zucker";
                PlayerDatabase.P2RW3 = "Dany Heatley";
                PlayerDatabase.P2RW4 = "Charlie Coyle";
                PlayerDatabase.P2LD1 = "Matt Dumba";
                PlayerDatabase.P2LD2 = "Ryan Suter";
                PlayerDatabase.P2LD3 = "Filip Kuba";
                PlayerDatabase.P2RD1 = "Jonas Brodin";
                PlayerDatabase.P2RD2 = "Jared Spurgeon";
                PlayerDatabase.P2RD3 = "Brent Burns";
                PlayerDatabase.P2G = "Dwayne Roloson";
                PlayerDatabase.P2PPLW = "Marian Gaborik";
                PlayerDatabase.P2PPC = "Mikko Koivu";
                PlayerDatabase.P2PPRW = "Jason Pominville";
                PlayerDatabase.P2PPLD = "Matt Dumba";
                PlayerDatabase.P2PPRD = "Zach Parise";
                PlayerDatabase.P2PKLW = "Marian Gaborik";
                PlayerDatabase.P2PKRW = "Mikko Koivu";
                PlayerDatabase.P2PKLD = "Matt Dumba";
                PlayerDatabase.P2PKRD = "Jared Spurgeon";
                PlayerDatabase.P2PKExW = "Eric Staal";
                PlayerDatabase.P2PKExD = "Ryan Suter";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "MON") {
                PlayerDatabase.P2LW1 = "Jacques Lemaire";
                PlayerDatabase.P2LW2 = "Yvan Cournoyer";
                PlayerDatabase.P2LW3 = "Toe Blake";
                PlayerDatabase.P2LW4 = "Steve Shutt";
                PlayerDatabase.P2C1 = "Jean Beliveau";
                PlayerDatabase.P2C2 = "Henri Richard";
                PlayerDatabase.P2C3 = "Elmer Lach";
                PlayerDatabase.P2C4 = "Saku Koivu";
                PlayerDatabase.P2RW1 = "Guy Lafleur";
                PlayerDatabase.P2RW2 = "Maurice Richard";
                PlayerDatabase.P2RW3 = "Bernard Geoffrion";
                PlayerDatabase.P2RW4 = "Pete Mahovlich";
                PlayerDatabase.P2LD1 = "Chris Chelios";
                PlayerDatabase.P2LD2 = "PK Subban";
                PlayerDatabase.P2LD3 = "Larry Robinson";
                PlayerDatabase.P2RD1 = "Guy Lapointe";
                PlayerDatabase.P2RD2 = "Doug Harvey";
                PlayerDatabase.P2RD3 = "Jacques Laperriere";
                PlayerDatabase.P2G = "Jacques Plante";
                PlayerDatabase.P2PPLW = "Jacques Lemaire";
                PlayerDatabase.P2PPC = "Jean Beliveau";
                PlayerDatabase.P2PPRW = "Guy Lafleur";
                PlayerDatabase.P2PPLD = "Yvan Cournoyer";
                PlayerDatabase.P2PPRD = "Maurice Richard";
                PlayerDatabase.P2PKLW = "Jacques Lemaire";
                PlayerDatabase.P2PKRW = "Guy Lafleur";
                PlayerDatabase.P2PKLD = "Larry Robinson";
                PlayerDatabase.P2PKRD = "Guy Lapointe";
                PlayerDatabase.P2PKExW = "Maurice Richard";
                PlayerDatabase.P2PKExD = "Jacques Laperriere";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "NAS") {
                PlayerDatabase.P2LW1 = "Patric Hornqvist";
                PlayerDatabase.P2LW2 = "Filip Forsberg";
                PlayerDatabase.P2LW3 = "Steve Sullivan";
                PlayerDatabase.P2LW4 = "Martin Erat";
                PlayerDatabase.P2C1 = "David Legwand";
                PlayerDatabase.P2C2 = "Craig Smith";
                PlayerDatabase.P2C3 = "Mike Fisher";
                PlayerDatabase.P2C4 = "Ryan Johansen";
                PlayerDatabase.P2RW1 = "James Neal";
                PlayerDatabase.P2RW2 = "Viktor Arvidsson";
                PlayerDatabase.P2RW3 = "JeanPierre Dumont";
                PlayerDatabase.P2RW4 = "Scott Walker";
                PlayerDatabase.P2LD1 = "Roman Josi";
                PlayerDatabase.P2LD2 = "PK Subban";
                PlayerDatabase.P2LD3 = "Mattias Ekholm";
                PlayerDatabase.P2RD1 = "Ryan Ellis";
                PlayerDatabase.P2RD2 = "Shea Weber";
                PlayerDatabase.P2RD3 = "Dan Hamhuis";
                PlayerDatabase.P2G = "Pekka Rinne";
                PlayerDatabase.P2PPLW = "Patric Hornqvist";
                PlayerDatabase.P2PPC = "David Legwand";
                PlayerDatabase.P2PPRW = "James Neal";
                PlayerDatabase.P2PPLD = "Roman Josi";
                PlayerDatabase.P2PPRD = "Filip Forsberg";
                PlayerDatabase.P2PKLW = "David Legwand";
                PlayerDatabase.P2PKRW = "James Neal";
                PlayerDatabase.P2PKLD = "Roman Josi";
                PlayerDatabase.P2PKRD = "Ryan Ellis";
                PlayerDatabase.P2PKExW = "Martin Erat";
                PlayerDatabase.P2PKExD = "Shea Weber";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "NJD") {
                PlayerDatabase.P2LW1 = "Zach Parise";
                PlayerDatabase.P2LW2 = "Patrik Elias";
                PlayerDatabase.P2LW3 = "Jamie Langenbrunner";
                PlayerDatabase.P2LW4 = "Brian Rolston";
                PlayerDatabase.P2C1 = "Bobby Holik";
                PlayerDatabase.P2C2 = "Scott Gomez";
                PlayerDatabase.P2C3 = "Aaron Broten";
                PlayerDatabase.P2C4 = "Kirk Muller";
                PlayerDatabase.P2RW1 = "Stephane Richer";
                PlayerDatabase.P2RW2 = "Petr Sykora";
                PlayerDatabase.P2RW3 = "John MacLean";
                PlayerDatabase.P2RW4 = "Randy McKay";
                PlayerDatabase.P2LD1 = "Bruce Driver";
                PlayerDatabase.P2LD2 = "Scott Niedermayer";
                PlayerDatabase.P2LD3 = "Tommy Albelin";
                PlayerDatabase.P2RD1 = "Scott Stevens";
                PlayerDatabase.P2RD2 = "Brian Rafalski";
                PlayerDatabase.P2RD3 = "Paul Martin";
                PlayerDatabase.P2G = "Martin Brodeur";
                PlayerDatabase.P2PPLW = "Zach Parise";
                PlayerDatabase.P2PPC = "Bobby Holik";
                PlayerDatabase.P2PPRW = "Stephane Richer";
                PlayerDatabase.P2PPLD = "Scott Niedermayer";
                PlayerDatabase.P2PPRD = "Scott Stevens";
                PlayerDatabase.P2PKLW = "Bobby Holik";
                PlayerDatabase.P2PKRW = "Petr Sykora";
                PlayerDatabase.P2PKLD = "Scott Niedermayer";
                PlayerDatabase.P2PKRD = "Scott Stevens";
                PlayerDatabase.P2PKExW = "Randy McKay";
                PlayerDatabase.P2PKExD = "Brian Rafalski";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "NYI") {
                PlayerDatabase.P2LW1 = "Clark Gillies";
                PlayerDatabase.P2LW2 = "Jason Blake";
                PlayerDatabase.P2LW3 = "John Tonelli";
                PlayerDatabase.P2LW4 = "Derek King";
                PlayerDatabase.P2C1 = "Bryan Trottier";
                PlayerDatabase.P2C2 = "John Tavares";
                PlayerDatabase.P2C3 = "Brent Sutter";
                PlayerDatabase.P2C4 = "Bob Bourne";
                PlayerDatabase.P2RW1 = "Mike Bossy";
                PlayerDatabase.P2RW2 = "Pat LaFontaine";
                PlayerDatabase.P2RW3 = "Billy Harris";
                PlayerDatabase.P2RW4 = "Anders Lee";
                PlayerDatabase.P2LD1 = "Denis Potvin";
                PlayerDatabase.P2LD2 = "Roman Hamrlik";
                PlayerDatabase.P2LD3 = "Tomas Jonsson";
                PlayerDatabase.P2RD1 = "Stefan Persson";
                PlayerDatabase.P2RD2 = "Travis Hamonic";
                PlayerDatabase.P2RD3 = "Nick Leddy";
                PlayerDatabase.P2G = "Billy Smith";
                PlayerDatabase.P2PPLW = "Clark Gillies";
                PlayerDatabase.P2PPC = "Bryan Trottier";
                PlayerDatabase.P2PPRW = "Mike Bossy";
                PlayerDatabase.P2PPLD = "Denis Potvin";
                PlayerDatabase.P2PPRD = "Pat LaFontaine";
                PlayerDatabase.P2PKLW = "Bryan Trottier";
                PlayerDatabase.P2PKRW = "Mike Bossy";
                PlayerDatabase.P2PKLD = "Denis Potvin";
                PlayerDatabase.P2PKRD = "Stefan Persson";
                PlayerDatabase.P2PKExW = "Clark Gillies";
                PlayerDatabase.P2PKExD = "Roman Hamrlik";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "NYR") {
                PlayerDatabase.P2LW1 = "Adam Graves";
                PlayerDatabase.P2LW2 = "Vic Hadfield";
                PlayerDatabase.P2LW3 = "Mark Messier";
                PlayerDatabase.P2LW4 = "Don Maloney";
                PlayerDatabase.P2C1 = "Walt Tkaczuk";
                PlayerDatabase.P2C2 = "Frank Boucher";
                PlayerDatabase.P2C3 = "Andy Bathgate";
                PlayerDatabase.P2C4 = "Jean Ratelle";
                PlayerDatabase.P2RW1 = "Bill Cook";
                PlayerDatabase.P2RW2 = "Tomas Sandstrom";
                PlayerDatabase.P2RW3 = "Rod Gilbert";
                PlayerDatabase.P2RW4 = "Anders Hedberg";
                PlayerDatabase.P2LD1 = "Reijo Ruotsalainen";
                PlayerDatabase.P2LD2 = "Brian Leetch";
                PlayerDatabase.P2LD3 = "Jim Neilson";
                PlayerDatabase.P2RD1 = "Brad Park";
                PlayerDatabase.P2RD2 = "Neil Colville";
                PlayerDatabase.P2RD3 = "Dave Maloney";
                PlayerDatabase.P2G = "Henrik Lundqvist";
                PlayerDatabase.P2PPLW = "Adam Graves";
                PlayerDatabase.P2PPC = "Walt Tkaczuk";
                PlayerDatabase.P2PPRW = "Bill Cook";
                PlayerDatabase.P2PPLD = "Brian Leetch";
                PlayerDatabase.P2PPRD = "Mark Messier";
                PlayerDatabase.P2PKLW = "Adam Graves";
                PlayerDatabase.P2PKRW = "Walt Tkaczuk";
                PlayerDatabase.P2PKLD = "Reijo Ruotsalainen";
                PlayerDatabase.P2PKRD = "Brad Park";
                PlayerDatabase.P2PKExW = "Mark Messier";
                PlayerDatabase.P2PKExD = "Brian Leetch";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "OTT") {
                PlayerDatabase.P2LW1 = "Dany Heatley";
                PlayerDatabase.P2LW2 = "Mark Stone";
                PlayerDatabase.P2LW3 = "Mike Hoffman";
                PlayerDatabase.P2LW4 = "Shawn McEachern";
                PlayerDatabase.P2C1 = "Alexei Yashin";
                PlayerDatabase.P2C2 = "Mike Fisher";
                PlayerDatabase.P2C3 = "Jason Spezza";
                PlayerDatabase.P2C4 = "Kyle Turris";
                PlayerDatabase.P2RW1 = "Daniel Alfredsson";
                PlayerDatabase.P2RW2 = "Martin Havlat";
                PlayerDatabase.P2RW3 = "Marian Hossa";
                PlayerDatabase.P2RW4 = "Milan Michalek";
                PlayerDatabase.P2LD1 = "Erik Karlsson";
                PlayerDatabase.P2LD2 = "Andrej Meszaros";
                PlayerDatabase.P2LD3 = "Chris Phillips";
                PlayerDatabase.P2RD1 = "Zdeno Chara";
                PlayerDatabase.P2RD2 = "Wade Redden";
                PlayerDatabase.P2RD3 = "Thomas Chabot";
                PlayerDatabase.P2G = "Craig Anderson";
                PlayerDatabase.P2PPLW = "Dany Heatley";
                PlayerDatabase.P2PPC = "Alexei Yashin";
                PlayerDatabase.P2PPRW = "Daniel Alfredsson";
                PlayerDatabase.P2PPLD = "Erik Karlsson";
                PlayerDatabase.P2PPRD = "Martin Havlat";
                PlayerDatabase.P2PKLW = "Dany Heatley";
                PlayerDatabase.P2PKRW = "Mark Stone";
                PlayerDatabase.P2PKLD = "Zdeno Chara";
                PlayerDatabase.P2PKRD = "Wade Redden";
                PlayerDatabase.P2PKExW = "Jason Spezza";
                PlayerDatabase.P2PKExD = "Andrej Meszaros";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "PHI") {
                PlayerDatabase.P2LW1 = "Brian Propp";
                PlayerDatabase.P2LW2 = "Bill Barber";
                PlayerDatabase.P2LW3 = "Rick MacLeish";
                PlayerDatabase.P2LW4 = "Simon Gagne";
                PlayerDatabase.P2C1 = "Eric Lindros";
                PlayerDatabase.P2C2 = "Bobby Clarke";
                PlayerDatabase.P2C3 = "Claude Giroux";
                PlayerDatabase.P2C4 = "Sean Couturier";
                PlayerDatabase.P2RW1 = "John LeClair";
                PlayerDatabase.P2RW2 = "Reggie Leach";
                PlayerDatabase.P2RW3 = "Tim Kerr";
                PlayerDatabase.P2RW4 = "Mark Recchi";
                PlayerDatabase.P2LD1 = "Mark Howe";
                PlayerDatabase.P2LD2 = "Bob Dailey";
                PlayerDatabase.P2LD3 = "Behn Wilson";
                PlayerDatabase.P2RD1 = "Tom Bladon";
                PlayerDatabase.P2RD2 = "Eric Desjardins";
                PlayerDatabase.P2RD3 = "Brad McCrimmon";
                PlayerDatabase.P2G = "Bernie Parent";
                PlayerDatabase.P2PPLW = "Brian Propp";
                PlayerDatabase.P2PPC = "Eric Lindros";
                PlayerDatabase.P2PPRW = "John LeClair";
                PlayerDatabase.P2PPLD = "Bill Barber";
                PlayerDatabase.P2PPRD = "Reggie Leach";
                PlayerDatabase.P2PKLW = "Eric Lindros";
                PlayerDatabase.P2PKRW = "Bobby Clarke";
                PlayerDatabase.P2PKLD = "Mark Howe";
                PlayerDatabase.P2PKRD = "Brad McCrimmon";
                PlayerDatabase.P2PKExW = "Bill Barber";
                PlayerDatabase.P2PKExD = "Bob Dailey";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "PHO") {
                PlayerDatabase.P2LW1 = "Keith Tkachuk";
                PlayerDatabase.P2LW2 = "Ladislav Nagy";
                PlayerDatabase.P2LW3 = "Clayton Keller";
                PlayerDatabase.P2LW4 = "Dallas Drake";
                PlayerDatabase.P2C1 = "Daymond Langkow";
                PlayerDatabase.P2C2 = "Shane Doan";
                PlayerDatabase.P2C3 = "Martin Hanzal";
                PlayerDatabase.P2C4 = "Jeremy Roenick";
                PlayerDatabase.P2RW1 = "Radim Vrbata";
                PlayerDatabase.P2RW2 = "Rick Tocchet";
                PlayerDatabase.P2RW3 = "Mike Johnson";
                PlayerDatabase.P2RW4 = "Mikkel Boedker";
                PlayerDatabase.P2LD1 = "Oliver EkmanLarsson";
                PlayerDatabase.P2LD2 = "Teppo Numminen";
                PlayerDatabase.P2LD3 = "Oleg Tverdovsky";
                PlayerDatabase.P2RD1 = "Ed Jovanovski";
                PlayerDatabase.P2RD2 = "Keith Yandle";
                PlayerDatabase.P2RD3 = "Jakob Chychrun";
                PlayerDatabase.P2G = "Ilya Bryzgalov";
                PlayerDatabase.P2PPLW = "Keith Tkachuk";
                PlayerDatabase.P2PPC = "Daymond Langkow";
                PlayerDatabase.P2PPRW = "Radim Vrbata";
                PlayerDatabase.P2PPLD = "Oliver EkmanLarsson";
                PlayerDatabase.P2PPRD = "Ladislav Nagy";
                PlayerDatabase.P2PKLW = "Keith Tkachuk";
                PlayerDatabase.P2PKRW = "Radim Vrbata";
                PlayerDatabase.P2PKLD = "Teppo Numminen";
                PlayerDatabase.P2PKRD = "Oleg Tverdovsky";
                PlayerDatabase.P2PKExW = "Ladislav Nagy";
                PlayerDatabase.P2PKExD = "Keith Yandle";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "PIT") {
                PlayerDatabase.P2LW1 = "Jean Pronovost";
                PlayerDatabase.P2LW2 = "Evgeni Malkin";
                PlayerDatabase.P2LW3 = "Pascal Dupuis";
                PlayerDatabase.P2LW4 = "Chris Kunitz";
                PlayerDatabase.P2C1 = "Mario Lemieux";
                PlayerDatabase.P2C2 = "Sidney Crosby";
                PlayerDatabase.P2C3 = "Syl Apps";
                PlayerDatabase.P2C4 = "Ron Francis";
                PlayerDatabase.P2RW1 = "Jaromir Jagr";
                PlayerDatabase.P2RW2 = "Alexei Kovalev";
                PlayerDatabase.P2RW3 = "Rick Kehoe";
                PlayerDatabase.P2RW4 = "Mark Recchi";
                PlayerDatabase.P2LD1 = "Larry Murphy";
                PlayerDatabase.P2LD2 = "Kris Letang";
                PlayerDatabase.P2LD3 = "Ron Stackhouse";
                PlayerDatabase.P2RD1 = "Paul Coffey";
                PlayerDatabase.P2RD2 = "Kevin Hatcher";
                PlayerDatabase.P2RD3 = "Doug Bodger";
                PlayerDatabase.P2G = "MarcAndre Fleury";
                PlayerDatabase.P2PPLW = "Jean Pronovost";
                PlayerDatabase.P2PPC = "Mario Lemieux";
                PlayerDatabase.P2PPRW = "Jaromir Jagr";
                PlayerDatabase.P2PPLD = "Larry Murphy";
                PlayerDatabase.P2PPRD = "Sidney Crosby";
                PlayerDatabase.P2PKLW = "Pascal Dupuis";
                PlayerDatabase.P2PKRW = "Jaromir Jagr";
                PlayerDatabase.P2PKLD = "Larry Murphy";
                PlayerDatabase.P2PKRD = "Kevin Hatcher";
                PlayerDatabase.P2PKExW = "Syl Apps";
                PlayerDatabase.P2PKExD = "Kris Letang";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "QUE") {
                PlayerDatabase.P2LW1 = "Michel Goulet";
                PlayerDatabase.P2LW2 = "Wilf Paiement";
                PlayerDatabase.P2LW3 = "Anton Stastny";
                PlayerDatabase.P2LW4 = "Marc Tardif";
                PlayerDatabase.P2C1 = "Joe Sakic";
                PlayerDatabase.P2C2 = "Jacques Richard";
                PlayerDatabase.P2C3 = "Peter Stastny";
                PlayerDatabase.P2C4 = "Mats Sundin";
                PlayerDatabase.P2RW1 = "Real Cloutier";
                PlayerDatabase.P2RW2 = "Owen Nolan";
                PlayerDatabase.P2RW3 = "Marian Stastny";
                PlayerDatabase.P2RW4 = "Dale Hunter";
                PlayerDatabase.P2LD1 = "Pierre Lacroix";
                PlayerDatabase.P2LD2 = "Mario Marois";
                PlayerDatabase.P2LD3 = "Randy Moller";
                PlayerDatabase.P2RD1 = "Jeff Brown";
                PlayerDatabase.P2RD2 = "Normand Rochefort";
                PlayerDatabase.P2RD3 = "Dave Pichette";
                PlayerDatabase.P2G = "Dan Bouchard";
                PlayerDatabase.P2PPLW = "Michel Goulet";
                PlayerDatabase.P2PPC = "Joe Sakic";
                PlayerDatabase.P2PPRW = "Real Cloutier";
                PlayerDatabase.P2PPLD = "Jacques Richard";
                PlayerDatabase.P2PPRD = "Owen Nolan";
                PlayerDatabase.P2PKLW = "Wilf Paiement";
                PlayerDatabase.P2PKRW = "Dale Hunter";
                PlayerDatabase.P2PKLD = "Mario Marois";
                PlayerDatabase.P2PKRD = "Normand Rochefort";
                PlayerDatabase.P2PKExW = "Michel Goulet";
                PlayerDatabase.P2PKExD = "Randy Moller";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "SJS") {
                PlayerDatabase.P2LW1 = "Milan Michalek";
                PlayerDatabase.P2LW2 = "Ryan Clowe";
                PlayerDatabase.P2LW3 = "Jeff Friesen";
                PlayerDatabase.P2LW4 = "Patrick Marleau";
                PlayerDatabase.P2C1 = "Joe Pavelski";
                PlayerDatabase.P2C2 = "Logan Couture";
                PlayerDatabase.P2C3 = "Vincent Damphousse";
                PlayerDatabase.P2C4 = "Joe Thornton";
                PlayerDatabase.P2RW1 = "Jonathan Cheechoo";
                PlayerDatabase.P2RW2 = "Marco Sturm";
                PlayerDatabase.P2RW3 = "Tomas Hertl";
                PlayerDatabase.P2RW4 = "Owen Nolan";
                PlayerDatabase.P2LD1 = "Brent Burns";
                PlayerDatabase.P2LD2 = "Dan Boyle";
                PlayerDatabase.P2LD3 = "Christian Ehrhoff";
                PlayerDatabase.P2RD1 = "Erik Karlsson";
                PlayerDatabase.P2RD2 = "Justin Braun";
                PlayerDatabase.P2RD3 = "Scott Hannan";
                PlayerDatabase.P2G = "Evgeni Nabokov";
                PlayerDatabase.P2PPLW = "Milan Michalek";
                PlayerDatabase.P2PPC = "Joe Pavelski";
                PlayerDatabase.P2PPRW = "Jonathan Cheechoo";
                PlayerDatabase.P2PPLD = "Brent Burns";
                PlayerDatabase.P2PPRD = "Erik Karlsson";
                PlayerDatabase.P2PKLW = "Milan Michalek";
                PlayerDatabase.P2PKRW = "Vincent Damphousse";
                PlayerDatabase.P2PKLD = "Brent Burns";
                PlayerDatabase.P2PKRD = "Justin Braun";
                PlayerDatabase.P2PKExW = "Joe Thornton";
                PlayerDatabase.P2PKExD = "Scott Hannan";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "STL") {
                PlayerDatabase.P2LW1 = "Red Berenson";
                PlayerDatabase.P2LW2 = "David Perron";
                PlayerDatabase.P2LW3 = "Alexander Steen";
                PlayerDatabase.P2LW4 = "Keith Tkachuk";
                PlayerDatabase.P2C1 = "Pavol Demitra";
                PlayerDatabase.P2C2 = "Pierre Turgeon";
                PlayerDatabase.P2C3 = "Garry Unger";
                PlayerDatabase.P2C4 = "David Backes";
                PlayerDatabase.P2RW1 = "Vladimir Tarasenko";
                PlayerDatabase.P2RW2 = "TJ Oshie";
                PlayerDatabase.P2RW3 = "Brett Hull";
                PlayerDatabase.P2RW4 = "Wayne Babych";
                PlayerDatabase.P2LD1 = "Al MacInnis";
                PlayerDatabase.P2LD2 = "Chris Pronger";
                PlayerDatabase.P2LD3 = "Kevin Shattenkirk";
                PlayerDatabase.P2RD1 = "Rob Ramage";
                PlayerDatabase.P2RD2 = "Colton Parayko";
                PlayerDatabase.P2RD3 = "Alex Pietrangelo";
                PlayerDatabase.P2G = "Mike Liut";
                PlayerDatabase.P2PPLW = "Red Berenson";
                PlayerDatabase.P2PPC = "Pavol Demitra";
                PlayerDatabase.P2PPRW = "Vladimir Tarasenko";
                PlayerDatabase.P2PPLD = "Al MacInnis";
                PlayerDatabase.P2PPRD = "Pierre Turgeon";
                PlayerDatabase.P2PKLW = "Pavol Demitra";
                PlayerDatabase.P2PKRW = "Pierre Turgeon";
                PlayerDatabase.P2PKLD = "Al MacInnis";
                PlayerDatabase.P2PKRD = "Chris Pronger";
                PlayerDatabase.P2PKExW = "TJ Oshie";
                PlayerDatabase.P2PKExD = "Colton Parayko";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "TBL") {
                PlayerDatabase.P2LW1 = "Ondrej Palat";
                PlayerDatabase.P2LW2 = "Fredrik Modin";
                PlayerDatabase.P2LW3 = "Teddy Purcell";
                PlayerDatabase.P2LW4 = "Ryan Malone";
                PlayerDatabase.P2C1 = "Steven Stamkos";
                PlayerDatabase.P2C2 = "Vincent Lecavalier";
                PlayerDatabase.P2C3 = "Brad Richards";
                PlayerDatabase.P2C4 = "Tyler Johnson";
                PlayerDatabase.P2RW1 = "Nikita Kucherov";
                PlayerDatabase.P2RW2 = "Martin StLouis";
                PlayerDatabase.P2RW3 = "Vaclav Prospal";
                PlayerDatabase.P2RW4 = "Petr Klima";
                PlayerDatabase.P2LD1 = "Victor Hedman";
                PlayerDatabase.P2LD2 = "Anton Stralman";
                PlayerDatabase.P2LD3 = "Mikhail Sergachev";
                PlayerDatabase.P2RD1 = "Ryan McDonagh";
                PlayerDatabase.P2RD2 = "Shawn Chambers";
                PlayerDatabase.P2RD3 = "Dan Boyle";
                PlayerDatabase.P2G = "Andrei Vasilevskiy";
                PlayerDatabase.P2PPLW = "Ondrej Palat";
                PlayerDatabase.P2PPC = "Steven Stamkos";
                PlayerDatabase.P2PPRW = "Nikita Kucherov";
                PlayerDatabase.P2PPLD = "Victor Hedman";
                PlayerDatabase.P2PPRD = "Martin StLouis";
                PlayerDatabase.P2PKLW = "Ondrej Palat";
                PlayerDatabase.P2PKRW = "Nikita Kucherov";
                PlayerDatabase.P2PKLD = "Victor Hedman";
                PlayerDatabase.P2PKRD = "Ryan McDonagh";
                PlayerDatabase.P2PKExW = "Fredrik Modin";
                PlayerDatabase.P2PKExD = "Anton Stralman";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "TOR") {
                PlayerDatabase.P2LW1 = "Frank Mahovlich";
                PlayerDatabase.P2LW2 = "Bob Pulford";
                PlayerDatabase.P2LW3 = "John Anderson";
                PlayerDatabase.P2LW4 = "Wendel Clark";
                PlayerDatabase.P2C1 = "Mats Sundin";
                PlayerDatabase.P2C2 = "Dave Keon";
                PlayerDatabase.P2C3 = "Darryl Sittler";
                PlayerDatabase.P2C4 = "Ted Kennedy";
                PlayerDatabase.P2RW1 = "Lanny McDonald";
                PlayerDatabase.P2RW2 = "Rick Vaive";
                PlayerDatabase.P2RW3 = "Phil Kessel";
                PlayerDatabase.P2RW4 = "George Armstrong";
                PlayerDatabase.P2LD1 = "Red Kelly";
                PlayerDatabase.P2LD2 = "Borje Salming";
                PlayerDatabase.P2LD3 = "Tim Horton";
                PlayerDatabase.P2RD1 = "Ian Turnbull";
                PlayerDatabase.P2RD2 = "Bryan McCabe";
                PlayerDatabase.P2RD3 = "Morgan Rielly";
                PlayerDatabase.P2G = "Johnny Bower";
                PlayerDatabase.P2PPLW = "Frank Mahovlich";
                PlayerDatabase.P2PPC = "Mats Sundin";
                PlayerDatabase.P2PPRW = "Rick Vaive";
                PlayerDatabase.P2PPLD = "Lanny McDonald";
                PlayerDatabase.P2PPRD = "Phil Kessel";
                PlayerDatabase.P2PKLW = "Frank Mahovlich";
                PlayerDatabase.P2PKRW = "Lanny McDonald";
                PlayerDatabase.P2PKLD = "Tim Horton";
                PlayerDatabase.P2PKRD = "Ian Turnbull";
                PlayerDatabase.P2PKExW = "Mats Sundin";
                PlayerDatabase.P2PKExD = "Red Kelly";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "VAN") {
                PlayerDatabase.P2LW1 = "Todd Bertuzzi";
                PlayerDatabase.P2LW2 = "Daniel Sedin";
                PlayerDatabase.P2LW3 = "Markus Naslund";
                PlayerDatabase.P2LW4 = "Don Lever";
                PlayerDatabase.P2C1 = "Ryan Kesler";
                PlayerDatabase.P2C2 = "Henrik Sedin";
                PlayerDatabase.P2C3 = "Brendan Morrison";
                PlayerDatabase.P2C4 = "Trevor Linden";
                PlayerDatabase.P2RW1 = "Pavel Bure";
                PlayerDatabase.P2RW2 = "Stan Smyl";
                PlayerDatabase.P2RW3 = "Patrik Sundstrom";
                PlayerDatabase.P2RW4 = "Tony Tanti";
                PlayerDatabase.P2LD1 = "Alexander Edler";
                PlayerDatabase.P2LD2 = "Kevin Bieksa";
                PlayerDatabase.P2LD3 = "Jyrki Lumme";
                PlayerDatabase.P2RD1 = "Ed Jovanovski";
                PlayerDatabase.P2RD2 = "Rick Lanz";
                PlayerDatabase.P2RD3 = "Mattias Ohlund";
                PlayerDatabase.P2G = "Kirk McLean";
                PlayerDatabase.P2PPLW = "Todd Bertuzzi";
                PlayerDatabase.P2PPC = "Henrik Sedin";
                PlayerDatabase.P2PPRW = "Pavel Bure";
                PlayerDatabase.P2PPLD = "Alexander Edler";
                PlayerDatabase.P2PPRD = "Daniel Sedin";
                PlayerDatabase.P2PKLW = "Todd Bertuzzi";
                PlayerDatabase.P2PKRW = "Pavel Bure";
                PlayerDatabase.P2PKLD = "Kevin Bieksa";
                PlayerDatabase.P2PKRD = "Jyrki Lumme";
                PlayerDatabase.P2PKExW = "Markus Naslund";
                PlayerDatabase.P2PKExD = "Mattias Ohlund";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "WAS") {
                PlayerDatabase.P2LW1 = "Alexander Ovechkin";
                PlayerDatabase.P2LW2 = "Dave Christian";
                PlayerDatabase.P2LW3 = "Alexander Semin";
                PlayerDatabase.P2LW4 = "Steve Konowalchuk";
                PlayerDatabase.P2C1 = "Nicklas Backstrom";
                PlayerDatabase.P2C2 = "Adam Oates";
                PlayerDatabase.P2C3 = "Michal Pivonka";
                PlayerDatabase.P2C4 = "Mike Ridley";
                PlayerDatabase.P2RW1 = "Peter Bondra";
                PlayerDatabase.P2RW2 = "Mike Gartner";
                PlayerDatabase.P2RW3 = "TJ Oshie";
                PlayerDatabase.P2RW4 = "Dale Hunter";
                PlayerDatabase.P2LD1 = "John Carlson";
                PlayerDatabase.P2LD2 = "Sylvain Cote";
                PlayerDatabase.P2LD3 = "Scott Stevens";
                PlayerDatabase.P2RD1 = "Sergei Gonchar";
                PlayerDatabase.P2RD2 = "Rod Langway";
                PlayerDatabase.P2RD3 = "Al Iafrate";
                PlayerDatabase.P2G = "Braden Holtby";
                PlayerDatabase.P2PPLW = "Alexander Ovechkin";
                PlayerDatabase.P2PPC = "Nicklas Backstrom";
                PlayerDatabase.P2PPRW = "Peter Bondra";
                PlayerDatabase.P2PPLD = "John Carlson";
                PlayerDatabase.P2PPRD = "Mike Gartner";
                PlayerDatabase.P2PKLW = "Adam Oates";
                PlayerDatabase.P2PKRW = "Mike Ridley";
                PlayerDatabase.P2PKLD = "Scott Stevens";
                PlayerDatabase.P2PKRD = "Rod Langway";
                PlayerDatabase.P2PKExW = "Alexander Ovechkin";
                PlayerDatabase.P2PKExD = "Sergei Gonchar";
            }

            else if (PlayerDatabase.ComputerChosenTeam == "WPG") {
                PlayerDatabase.P2LW1 = "Patrik Laine";
                PlayerDatabase.P2LW2 = "Nikolaj Ehlers";
                PlayerDatabase.P2LW3 = "Keith Tkachuk";
                PlayerDatabase.P2LW4 = "Pat Elynuik";
                PlayerDatabase.P2C1 = "Dale Hawerchuk";
                PlayerDatabase.P2C2 = "Mark Scheifele";
                PlayerDatabase.P2C3 = "Blake Wheeler";
                PlayerDatabase.P2C4 = "Thomas Steen";
                PlayerDatabase.P2RW1 = "Teemu Selanne";
                PlayerDatabase.P2RW2 = "Paul MacLean";
                PlayerDatabase.P2RW3 = "Brian Mullen";
                PlayerDatabase.P2RW4 = "Doug Smail";
                PlayerDatabase.P2LD1 = "Dustin Byfuglien";
                PlayerDatabase.P2LD2 = "Dave Babych";
                PlayerDatabase.P2LD3 = "Dave Ellett";
                PlayerDatabase.P2RD1 = "Jacob Trouba";
                PlayerDatabase.P2RD2 = "Phil Housley";
                PlayerDatabase.P2RD3 = "Fredrik Olausson";
                PlayerDatabase.P2G = "Connor Hellebuyck";
                PlayerDatabase.P2PPLW = "Patrik Laine";
                PlayerDatabase.P2PPC = "Dale Hawerchuk";
                PlayerDatabase.P2PPRW = "Teemu Selanne";
                PlayerDatabase.P2PPLD = "Dustin Byfuglien";
                PlayerDatabase.P2PPRD = "Paul MacLean";
                PlayerDatabase.P2PKLW = "Blake Wheeler";
                PlayerDatabase.P2PKRW = "Doug Smail";
                PlayerDatabase.P2PKLD = "Dustin Byfuglien";
                PlayerDatabase.P2PKRD = "Jacob Trouba";
                PlayerDatabase.P2PKExW = "Nikolaj Ehlers";
                PlayerDatabase.P2PKExD = "Phil Housley";
            }
		}
	}

	public void RandomSelectComputerTeam() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			RandomComputerTeamInt = Random.Range(1,33);

			if (RandomComputerTeamInt == 1) {
				PlayerDatabase.ComputerChosenTeam = "ANA";
			}

			else if (RandomComputerTeamInt == 2) {
				PlayerDatabase.ComputerChosenTeam = "ARI";
			}

			else if (RandomComputerTeamInt == 3) {
				PlayerDatabase.ComputerChosenTeam = "BOS";
			}

			else if (RandomComputerTeamInt == 4) {
				PlayerDatabase.ComputerChosenTeam = "BUF";
			}

			else if (RandomComputerTeamInt == 5) {
				PlayerDatabase.ComputerChosenTeam = "CAL";
			}

			else if (RandomComputerTeamInt == 6) {
				PlayerDatabase.ComputerChosenTeam = "CAR";
			}

			else if (RandomComputerTeamInt == 7) {
				PlayerDatabase.ComputerChosenTeam = "CHI";
			}

			else if (RandomComputerTeamInt == 8) {
				PlayerDatabase.ComputerChosenTeam = "COL";
			}

			else if (RandomComputerTeamInt == 9) {
				PlayerDatabase.ComputerChosenTeam = "CBJ";
			}

			else if (RandomComputerTeamInt == 10) {
				PlayerDatabase.ComputerChosenTeam = "DAL";
			}

			else if (RandomComputerTeamInt == 11) {
				PlayerDatabase.ComputerChosenTeam = "DET";
			}

			else if (RandomComputerTeamInt == 12) {
				PlayerDatabase.ComputerChosenTeam = "EDM";
			}

			else if (RandomComputerTeamInt == 13) {
				PlayerDatabase.ComputerChosenTeam = "FLA";
			}

			else if (RandomComputerTeamInt == 14) {
				PlayerDatabase.ComputerChosenTeam = "LAK";
			}

			else if (RandomComputerTeamInt == 15) {
				PlayerDatabase.ComputerChosenTeam = "MIN";
			}

			else if (RandomComputerTeamInt == 16) {
				PlayerDatabase.ComputerChosenTeam = "MON";
			}

			else if (RandomComputerTeamInt == 17) {
				PlayerDatabase.ComputerChosenTeam = "NAS";
			}

			else if (RandomComputerTeamInt == 18) {
				PlayerDatabase.ComputerChosenTeam = "NJD";
			}

			else if (RandomComputerTeamInt == 19) {
				PlayerDatabase.ComputerChosenTeam = "NYI";
			}

			else if (RandomComputerTeamInt == 20) {
				PlayerDatabase.ComputerChosenTeam = "NYR";
			}

			else if (RandomComputerTeamInt == 21) {
				PlayerDatabase.ComputerChosenTeam = "OTT";
			}

			else if (RandomComputerTeamInt == 22) {
				PlayerDatabase.ComputerChosenTeam = "PHI";
			}

			else if (RandomComputerTeamInt == 23) {
				PlayerDatabase.ComputerChosenTeam = "PIT";
			}

			else if (RandomComputerTeamInt == 24) {
				PlayerDatabase.ComputerChosenTeam = "STL";
			}

			else if (RandomComputerTeamInt == 25) {
				PlayerDatabase.ComputerChosenTeam = "SJS";
			}

			else if (RandomComputerTeamInt == 26) {
				PlayerDatabase.ComputerChosenTeam = "SEA";
			}

			else if (RandomComputerTeamInt == 27) {
				PlayerDatabase.ComputerChosenTeam = "TBL";
			}

			else if (RandomComputerTeamInt == 28) {
				PlayerDatabase.ComputerChosenTeam = "TOR";
			}

			else if (RandomComputerTeamInt == 29) {
				PlayerDatabase.ComputerChosenTeam = "VAN";
			}

			else if (RandomComputerTeamInt == 30) {
				PlayerDatabase.ComputerChosenTeam = "VGK";
			}

			else if (RandomComputerTeamInt == 31) {
				PlayerDatabase.ComputerChosenTeam = "WAS";
			}

			else if (RandomComputerTeamInt == 32) {
				PlayerDatabase.ComputerChosenTeam = "WPG";
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			RandomComputerTeamInt = Random.Range(1,35);

			if (RandomComputerTeamInt == 1) {
				PlayerDatabase.ComputerChosenTeam = "ANA";
			}

			else if (RandomComputerTeamInt == 2) {
				PlayerDatabase.ComputerChosenTeam = "ATL";
			}

			else if (RandomComputerTeamInt == 3) {
				PlayerDatabase.ComputerChosenTeam = "BOS";
			}

			else if (RandomComputerTeamInt == 4) {
				PlayerDatabase.ComputerChosenTeam = "BUF";
			}

			else if (RandomComputerTeamInt == 5) {
				PlayerDatabase.ComputerChosenTeam = "CAL";
			}

			else if (RandomComputerTeamInt == 6) {
				PlayerDatabase.ComputerChosenTeam = "CAR";
			}

			else if (RandomComputerTeamInt == 7) {
				PlayerDatabase.ComputerChosenTeam = "CHI";
			}

			else if (RandomComputerTeamInt == 8) {
				PlayerDatabase.ComputerChosenTeam = "COL";
			}

			else if (RandomComputerTeamInt == 9) {
				PlayerDatabase.ComputerChosenTeam = "CBJ";
			}

			else if (RandomComputerTeamInt == 10) {
				PlayerDatabase.ComputerChosenTeam = "DAL";
			}

			else if (RandomComputerTeamInt == 11) {
				PlayerDatabase.ComputerChosenTeam = "DET";
			}

			else if (RandomComputerTeamInt == 12) {
				PlayerDatabase.ComputerChosenTeam = "EDM";
			}

			else if (RandomComputerTeamInt == 13) {
				PlayerDatabase.ComputerChosenTeam = "FLA";
			}

			else if (RandomComputerTeamInt == 14) {
				PlayerDatabase.ComputerChosenTeam = "HAR";
			}

			else if (RandomComputerTeamInt == 15) {
				PlayerDatabase.ComputerChosenTeam = "LAK";
			}

			else if (RandomComputerTeamInt == 16) {
				PlayerDatabase.ComputerChosenTeam = "MNS";
			}

			else if (RandomComputerTeamInt == 17) {
				PlayerDatabase.ComputerChosenTeam = "MNW";
			}

			else if (RandomComputerTeamInt == 18) {
				PlayerDatabase.ComputerChosenTeam = "MON";
			}

			else if (RandomComputerTeamInt == 19) {
				PlayerDatabase.ComputerChosenTeam = "NAS";
			}

			else if (RandomComputerTeamInt == 20) {
				PlayerDatabase.ComputerChosenTeam = "NJD";
			}

			else if (RandomComputerTeamInt == 21) {
				PlayerDatabase.ComputerChosenTeam = "NYI";
			}

			else if (RandomComputerTeamInt == 22) {
				PlayerDatabase.ComputerChosenTeam = "NYR";
			}

			else if (RandomComputerTeamInt == 23) {
				PlayerDatabase.ComputerChosenTeam = "OTT";
			}

			else if (RandomComputerTeamInt == 24) {
				PlayerDatabase.ComputerChosenTeam = "PHI";
			}

			else if (RandomComputerTeamInt == 25) {
				PlayerDatabase.ComputerChosenTeam = "PHO";
			}

			else if (RandomComputerTeamInt == 26) {
				PlayerDatabase.ComputerChosenTeam = "PIT";
			}

			else if (RandomComputerTeamInt == 27) {
				PlayerDatabase.ComputerChosenTeam = "QUE";
			}

			else if (RandomComputerTeamInt == 28) {
				PlayerDatabase.ComputerChosenTeam = "STL";
			}

			else if (RandomComputerTeamInt == 29) {
				PlayerDatabase.ComputerChosenTeam = "SJS";
			}

			else if (RandomComputerTeamInt == 30) {
				PlayerDatabase.ComputerChosenTeam = "TBL";
			}

			else if (RandomComputerTeamInt == 31) {
				PlayerDatabase.ComputerChosenTeam = "TOR";
			}

			else if (RandomComputerTeamInt == 32) {
				PlayerDatabase.ComputerChosenTeam = "VAN";
			}

			else if (RandomComputerTeamInt == 33) {
				PlayerDatabase.ComputerChosenTeam = "WAS";
			}

			else if (RandomComputerTeamInt == 34) {
				PlayerDatabase.ComputerChosenTeam = "WPG";
			}
		}

		CheckDuplicateTeams();
	}

	public void CheckDuplicateTeams() {
		if (PlayerDatabase.ComputerChosenTeam == PlayerDatabase.PlayerChosenTeam) {
			RandomSelectComputerTeam();
		}
	}

	public void SetPlayerChosenTeam() {
		PlayerDatabase.P1LW1 = "None";
		PlayerDatabase.P1LW2 = "None";
		PlayerDatabase.P1LW3 = "None";
		PlayerDatabase.P1LW4 = "None";
		PlayerDatabase.P1C1 = "None";
		PlayerDatabase.P1C2 = "None";
		PlayerDatabase.P1C3 = "None";
		PlayerDatabase.P1C4 = "None";
		PlayerDatabase.P1RW1 = "None";
		PlayerDatabase.P1RW2 = "None";
		PlayerDatabase.P1RW3 = "None";
		PlayerDatabase.P1RW4 = "None";
		PlayerDatabase.P1LD1 = "None";
		PlayerDatabase.P1LD2 = "None";
		PlayerDatabase.P1LD3 = "None";
		PlayerDatabase.P1RD1 = "None";
		PlayerDatabase.P1RD2 = "None";
		PlayerDatabase.P1RD3 = "None";
		PlayerDatabase.P1G = "None";
	}
	
	public void SelectANAClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "ANA";
	}
	
	public void SelectARIClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "ARI";
	}
	
	public void SelectBOSClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "BOS";
	}
	
	public void SelectBUFClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "BUF";
	}
	
	public void SelectCALClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "CAL";
	}
	
	public void SelectCARClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "CAR";
	}
	
	public void SelectCHIClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "CHI";
	}
	
	public void SelectCOLClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "COL";
	}
	
	public void SelectCBJClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "CBJ";
	}
	
	public void SelectDALClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "DAL";
	}
	
	public void SelectDETClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "DET";
	}
	
	public void SelectEDMClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "EDM";
	}
	
	public void SelectFLAClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "FLA";
	}
	
	public void SelectLAKClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "LAK";
	}
	
	public void SelectMINClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "MIN";
	}
	
	public void SelectMONClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "MON";
	}
	
	public void SelectNASClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "NAS";
	}
	
	public void SelectNJDClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "NJD";
	}
	
	public void SelectNYIClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "NYI";
	}
	
	public void SelectNYRClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "NYR";
	}
	
	public void SelectOTTClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "OTT";
	}
	
	public void SelectPHIClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "PHI";
	}
	
	public void SelectPITClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "PIT";
	}
	
	public void SelectSTLClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "STL";
	}
	
	public void SelectSJSClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "SJS";
	}
	
	public void SelectSEAClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "SEA";
	}
	
	public void SelectTBLClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "TBL";
	}
	
	public void SelectTORClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "TOR";
	}
	
	public void SelectVANClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "VAN";
	}
	
	public void SelectVGKClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "VGK";
	}
	
	public void SelectWASClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "WAS";
	}
	
	public void SelectWPGClicking() {
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "WPG";
	}

	public void SelectFrANAClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "ANA";
	}

	public void SelectFrATLClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "ATL";
	}

	public void SelectFrBOSClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "BOS";
	}

	public void SelectFrBUFClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "BUF";
	}

	public void SelectFrCALClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "CAL";
	}

	public void SelectFrCARClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "CAR";
	}

	public void SelectFrCHIClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "CHI";
	}

	public void SelectFrCOLClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "COL";
	}

	public void SelectFrCBJClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "CBJ";
	}

	public void SelectFrDALClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "DAL";
	}

	public void SelectFrDETClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "DET";
	}

	public void SelectFrEDMClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "EDM";
	}

	public void SelectFrFLAClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "FLA";
	}

	public void SelectFrHARClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "HAR";
	}

	public void SelectFrLAKClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "LAK";
	}

	public void SelectFrMNSClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "MNS";
	}

	public void SelectFrMNWClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "MNW";
	}

	public void SelectFrMONClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "MON";
	}

	public void SelectFrNASClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "NAS";
	}

	public void SelectFrNJDClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "NJD";
	}

	public void SelectFrNYIClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "NYI";
	}

	public void SelectFrNYRClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "NYR";
	}

	public void SelectFrOTTClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "OTT";
	}

	public void SelectFrPHIClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "PHI";
	}

	public void SelectFrPHOClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "PHO";
	}

	public void SelectFrPITClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "PIT";
	}

	public void SelectFrQUEClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "QUE";
	}

	public void SelectFrSTLClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "STL";
	}

	public void SelectFrSJSClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "SJS";
	}

	public void SelectFrTBLClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "TBL";
	}

	public void SelectFrTORClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "TOR";
	}

	public void SelectFrVANClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "VAN";
	}

	public void SelectFrWASClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "WAS";
	}

	public void SelectFrWPGClicking() {
		EnableObjects03.ShowingSelectFrTeam = 0;
		EnableObjects03.ShowingTeamChosen = 1;
		PlayerDatabase.PlayerChosenTeam = "WPG";
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}