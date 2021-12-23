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
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene03LoadRun;
	public SceneChange Scene04LoadRun;
	
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
		SetPlayerChosenTeam();
		Scene04LoadRun.Scene04Load();
		EnableObjects03.ShowingTeamChosen = 0;
		EnableObjects03.ShowingSelectTeam = 0;
		EnableObjects03.ShowingSelectFrTeam = 0;
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