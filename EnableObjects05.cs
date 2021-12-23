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

public class EnableObjects05 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image BackgroundImage;
	public Text TitleText;
	public Text P1Title;
	public Text P1LW1Text;
	public Text P1C1Text;
	public Text P1RW1Text;
	public Text P1LD1Text;
	public Text P1RD1Text;
	public Text P1GText;
	public Text P2Title;
	public Text P2LW1Text;
	public Text P2C1Text;
	public Text P2RW1Text;
	public Text P2LD1Text;
	public Text P2RD1Text;
	public Text P2GText;
	public Text StartGameNote;
	public Image StartGameButton;
	public Text StartGameNoteGame;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string PlayerTeam;
	public static string ComputerTeam;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableAllObjects();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdateTeams();
		UpdateTexts();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBJECTS FUNCTION ---------------
	public void EnableAllObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		P1Title.enabled = true;
		P1LW1Text.enabled = true;
		P1C1Text.enabled = true;
		P1RW1Text.enabled = true;
		P1LD1Text.enabled = true;
		P1RD1Text.enabled = true;
		P1GText.enabled = true;
		P2Title.enabled = true;
		P2LW1Text.enabled = true;
		P2C1Text.enabled = true;
		P2RW1Text.enabled = true;
		P2LD1Text.enabled = true;
		P2RD1Text.enabled = true;
		P2GText.enabled = true;
		StartGameNote.enabled = true;
		StartGameButton.enabled = true;
		StartGameNoteGame.enabled = true;
	}

// --------------- DISABLING OBJECTS FUNCTION ---------------
	public void DisableAllObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		P1Title.enabled = false;
		P1LW1Text.enabled = false;
		P1C1Text.enabled = false;
		P1RW1Text.enabled = false;
		P1LD1Text.enabled = false;
		P1RD1Text.enabled = false;
		P1GText.enabled = false;
		P2Title.enabled = false;
		P2LW1Text.enabled = false;
		P2C1Text.enabled = false;
		P2RW1Text.enabled = false;
		P2LD1Text.enabled = false;
		P2RD1Text.enabled = false;
		P2GText.enabled = false;
		StartGameNote.enabled = false;
		StartGameButton.enabled = false;
		StartGameNoteGame.enabled = false;
	}

// --------------- UPDATE TEXTS FUNCTION ---------------
	public void UpdateTexts() {
		P1LW1Text.text = PlayerDatabase.P1LW1.Replace(" ", "\n");
		P1C1Text.text = PlayerDatabase.P1C1.Replace(" ", "\n");
		P1RW1Text.text = PlayerDatabase.P1RW1.Replace(" ", "\n");
		P1LD1Text.text = PlayerDatabase.P1LD1.Replace(" ", "\n");
		P1RD1Text.text = PlayerDatabase.P1RD1.Replace(" ", "\n");
		P1GText.text = PlayerDatabase.P1G.Replace(" ", "\n");
		P2LW1Text.text = PlayerDatabase.P2LW1.Replace(" ", "\n");
		P2C1Text.text = PlayerDatabase.P2C1.Replace(" ", "\n");
		P2RW1Text.text = PlayerDatabase.P2RW1.Replace(" ", "\n");
		P2LD1Text.text = PlayerDatabase.P2LD1.Replace(" ", "\n");
		P2RD1Text.text = PlayerDatabase.P2RD1.Replace(" ", "\n");
		P2GText.text = PlayerDatabase.P2G.Replace(" ", "\n");
		StartGameNote.text = "The puck is about to drop between the " + PlayerTeam + " and the " +  ComputerTeam;
	}

	public void UpdateTeams() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			// Player
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				PlayerTeam = "Anaheim Ducks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ARI") {
				PlayerTeam = "Arizona Coyotes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				PlayerTeam = "Boston Bruins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				PlayerTeam = "Buffalo Sabres";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				PlayerTeam = "Calgary Flames";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				PlayerTeam = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				PlayerTeam = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				PlayerTeam = "Colorado Avalanche";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				PlayerTeam = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				PlayerTeam = "Dallas Stars";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				PlayerTeam = "Detroit Red Wings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				PlayerTeam = "Edmonton Oilers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				PlayerTeam = "Florida Panthers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				PlayerTeam = "Los Angeles Kings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MIN") {
				PlayerTeam = "Minnesota Wild";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				PlayerTeam = "Montreal Canadiens";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				PlayerTeam = "Nashville Predators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				PlayerTeam = "New Jersey Devils";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				PlayerTeam = "New York Islanders";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				PlayerTeam = "New York Rangers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				PlayerTeam = "Ottawa Senators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				PlayerTeam = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				PlayerTeam = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				PlayerTeam = "St Louis Blues";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				PlayerTeam = "San Jose Sharks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SEA") {
				PlayerTeam = "Seattle Kraken";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				PlayerTeam = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				PlayerTeam = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				PlayerTeam = "Vancouver Canucks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VGK") {
				PlayerTeam = "Vegas Golden Knights";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				PlayerTeam = "Washington Capitals";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				PlayerTeam = "Winnipeg Jets";
			}

			// Computer
			if (PlayerDatabase.ComputerChosenTeam == "ANA") {
				ComputerTeam = "Anaheim Ducks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "ARI") {
				ComputerTeam = "Arizona Coyotes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BOS") {
				ComputerTeam = "Boston Bruins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BUF") {
				ComputerTeam = "Buffalo Sabres";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAL") {
				ComputerTeam = "Calgary Flames";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAR") {
				ComputerTeam = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CHI") {
				ComputerTeam = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "COL") {
				ComputerTeam = "Colorado Avalanche";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CBJ") {
				ComputerTeam = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DAL") {
				ComputerTeam = "Dallas Stars";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DET") {
				ComputerTeam = "Detroit Red Wings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "EDM") {
				ComputerTeam = "Edmonton Oilers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "FLA") {
				ComputerTeam = "Florida Panthers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "LAK") {
				ComputerTeam = "Los Angeles Kings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MIN") {
				ComputerTeam = "Minnesota Wild";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MON") {
				ComputerTeam = "Montreal Canadiens";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NAS") {
				ComputerTeam = "Nashville Predators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NJD") {
				ComputerTeam = "New Jersey Devils";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYI") {
				ComputerTeam = "New York Islanders";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYR") {
				ComputerTeam = "New York Rangers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "OTT") {
				ComputerTeam = "Ottawa Senators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHI") {
				ComputerTeam = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PIT") {
				ComputerTeam = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "STL") {
				ComputerTeam = "St Louis Blues";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SJS") {
				ComputerTeam = "San Jose Sharks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SEA") {
				ComputerTeam = "Seattle Kraken";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TBL") {
				ComputerTeam = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TOR") {
				ComputerTeam = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VAN") {
				ComputerTeam = "Vancouver Canucks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VGK") {
				ComputerTeam = "Vegas Golden Knights";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WAS") {
				ComputerTeam = "Washington Capitals";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WPG") {
				ComputerTeam = "Winnipeg Jets";
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			// Player
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				PlayerTeam = "Mighty Ducks of Anaheim";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ATL") {
				PlayerTeam = "Atlanta Thrashers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				PlayerTeam = "Boston Bruins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				PlayerTeam = "Buffalo Sabres";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				PlayerTeam = "Calgary Flames";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				PlayerTeam = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				PlayerTeam = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				PlayerTeam = "Colorado Avalanche";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				PlayerTeam = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				PlayerTeam = "Dallas Stars";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				PlayerTeam = "Detroit Red Wings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				PlayerTeam = "Edmonton Oilers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				PlayerTeam = "Florida Panthers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "HAR") {
				PlayerTeam = "Hartford Whalers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				PlayerTeam = "Los Angeles Kings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNS") {
				PlayerTeam = "Minnesota North Stars";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNW") {
				PlayerTeam = "Minnesota Wild";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				PlayerTeam = "Montreal Canadiens";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				PlayerTeam = "Nashville Predators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				PlayerTeam = "New Jersey Devils";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				PlayerTeam = "New York Islanders";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				PlayerTeam = "New York Rangers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				PlayerTeam = "Ottawa Senators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				PlayerTeam = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHO") {
				PlayerTeam = "Phoenix Coyotes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				PlayerTeam = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "QUE") {
				PlayerTeam = "Quebec Nordiques";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				PlayerTeam = "St Louis Blues";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				PlayerTeam = "San Jose Sharks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				PlayerTeam = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				PlayerTeam = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				PlayerTeam = "Vancouver Canucks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				PlayerTeam = "Washington Capitals";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				PlayerTeam = "Winnipeg Jets";
			}

			// Computer
			if (PlayerDatabase.ComputerChosenTeam == "ANA") {
				ComputerTeam = "Mighty Ducks of Anaheim";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "ATL") {
				ComputerTeam = "Atlanta Thrashers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BOS") {
				ComputerTeam = "Boston Bruins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BUF") {
				ComputerTeam = "Buffalo Sabres";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAL") {
				ComputerTeam = "Calgary Flames";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAR") {
				ComputerTeam = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CHI") {
				ComputerTeam = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "COL") {
				ComputerTeam = "Colorado Avalanche";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CBJ") {
				ComputerTeam = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DAL") {
				ComputerTeam = "Dallas Stars";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DET") {
				ComputerTeam = "Detroit Red Wings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "EDM") {
				ComputerTeam = "Edmonton Oilers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "FLA") {
				ComputerTeam = "Florida Panthers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "HAR") {
				ComputerTeam = "Hartford Whalers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "LAK") {
				ComputerTeam = "Los Angeles Kings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MNS") {
				ComputerTeam = "Minnesota North Stars";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MNW") {
				ComputerTeam = "Minnesota Wild";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MON") {
				ComputerTeam = "Montreal Canadiens";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NAS") {
				ComputerTeam = "Nashville Predators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NJD") {
				ComputerTeam = "New Jersey Devils";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYI") {
				ComputerTeam = "New York Islanders";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYR") {
				ComputerTeam = "New York Rangers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "OTT") {
				ComputerTeam = "Ottawa Senators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHI") {
				ComputerTeam = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHO") {
				ComputerTeam = "Phoenix Coyotes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PIT") {
				ComputerTeam = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "QUE") {
				ComputerTeam = "Quebec Nordiques";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "STL") {
				ComputerTeam = "St Louis Blues";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SJS") {
				ComputerTeam = "San Jose Sharks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TBL") {
				ComputerTeam = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TOR") {
				ComputerTeam = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VAN") {
				ComputerTeam = "Vancouver Canucks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WAS") {
				ComputerTeam = "Washington Capitals";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WPG") {
				ComputerTeam = "Winnipeg Jets";
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}