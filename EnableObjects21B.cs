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

public class EnableObjects21B : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image MainMenuButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string P1FullTeam;
	public static string P2FullTeam;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMainObjects();
		UpdatingTeamNames();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingActionText();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
		MainMenuButton.enabled = true;
	}

// --------------- DISABLING OBEJCTS FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ActionText.enabled = false;
		MainMenuButton.enabled = false;
	}

// --------------- UPDATING TEXT FUNCTIONS ---------------
	public void UpdatingActionText() {
		if (System.Int32.Parse(PlayerDatabase.GameplayP1Score) > System.Int32.Parse(PlayerDatabase.GameplayP2Score)) {
			ActionText.text = "The game has ended." + "\n\n" + "The " + P1FullTeam + " have defeated the " + P2FullTeam + " by a final score of " + PlayerDatabase.GameplayP1Score + " to " + PlayerDatabase.GameplayP2Score + ".";
		}

		else if (System.Int32.Parse(PlayerDatabase.GameplayP2Score) > System.Int32.Parse(PlayerDatabase.GameplayP1Score)) {
			ActionText.text = "The game has ended." + "\n\n" + "The " + P2FullTeam + " have defeated the " + P1FullTeam + " by a final score of " + PlayerDatabase.GameplayP2Score + " to " + PlayerDatabase.GameplayP1Score + ".";
		}

		else {
			ActionText.text = "The game has ended." + "\n\n" + "The " + P1FullTeam + " have tied with the " + P2FullTeam + " by a final score of " + PlayerDatabase.GameplayP1Score + " to " + PlayerDatabase.GameplayP2Score + ".";
		}
	}

	public void UpdatingTeamNames() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			// P1
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				P1FullTeam = "Anaheim Ducks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ARI") {
				P1FullTeam = "Arizona Coyotes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				P1FullTeam = "Boston Bruins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				P1FullTeam = "Buffalo Sabres";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				P1FullTeam = "Calgary Flames";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				P1FullTeam = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				P1FullTeam = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				P1FullTeam = "Colorado Avalanche";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				P1FullTeam = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				P1FullTeam = "Dallas Stars";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				P1FullTeam = "Detroit Red Wings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				P1FullTeam = "Edmonton Oilers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				P1FullTeam = "Florida Panthers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				P1FullTeam = "Los Angeles Kings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MIN") {
				P1FullTeam = "Minnesota Wild";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				P1FullTeam = "Montreal Canadiens";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				P1FullTeam = "Nashville Predators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				P1FullTeam = "New Jersey Devils";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				P1FullTeam = "New York Islanders";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				P1FullTeam = "New York Rangers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				P1FullTeam = "Ottawa Senators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				P1FullTeam = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				P1FullTeam = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				P1FullTeam = "St Louis Blues";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				P1FullTeam = "San Jose Sharks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SEA") {
				P1FullTeam = "Seattle Kraken";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				P1FullTeam = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				P1FullTeam = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				P1FullTeam = "Vancouver Canucks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VGK") {
				P1FullTeam = "Vegas Golden Knights";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				P1FullTeam = "Washington Capitals";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				P1FullTeam = "Winnipeg Jets";
			}

			// P2
			if (PlayerDatabase.ComputerChosenTeam == "ANA") {
				P2FullTeam = "Anaheim Ducks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "ARI") {
				P2FullTeam = "Arizona Coyotes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BOS") {
				P2FullTeam = "Boston Bruins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BUF") {
				P2FullTeam = "Buffalo Sabres";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAL") {
				P2FullTeam = "Calgary Flames";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAR") {
				P2FullTeam = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CHI") {
				P2FullTeam = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "COL") {
				P2FullTeam = "Colorado Avalanche";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CBJ") {
				P2FullTeam = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DAL") {
				P2FullTeam = "Dallas Stars";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DET") {
				P2FullTeam = "Detroit Red Wings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "EDM") {
				P2FullTeam = "Edmonton Oilers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "FLA") {
				P2FullTeam = "Florida Panthers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "LAK") {
				P2FullTeam = "Los Angeles Kings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MIN") {
				P2FullTeam = "Minnesota Wild";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MON") {
				P2FullTeam = "Montreal Canadiens";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NAS") {
				P2FullTeam = "Nashville Predators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NJD") {
				P2FullTeam = "New Jersey Devils";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYI") {
				P2FullTeam = "New York Islanders";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYR") {
				P2FullTeam = "New York Rangers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "OTT") {
				P2FullTeam = "Ottawa Senators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHI") {
				P2FullTeam = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PIT") {
				P2FullTeam = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "STL") {
				P2FullTeam = "St Louis Blues";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SJS") {
				P2FullTeam = "San Jose Sharks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SEA") {
				P2FullTeam = "Seattle Kraken";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TBL") {
				P2FullTeam = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TOR") {
				P2FullTeam = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VAN") {
				P2FullTeam = "Vancouver Canucks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VGK") {
				P2FullTeam = "Vegas Golden Knights";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WAS") {
				P2FullTeam = "Washington Capitals";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WPG") {
				P2FullTeam = "Winnipeg Jets";
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			// P1
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				P1FullTeam = "Mighty Ducks of Anaheim";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ATL") {
				P1FullTeam = "Atlanta Thrashers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				P1FullTeam = "Boston Bruins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				P1FullTeam = "Buffalo Sabres";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				P1FullTeam = "Calgary Flames";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				P1FullTeam = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				P1FullTeam = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				P1FullTeam = "Colorado Avalanche";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				P1FullTeam = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				P1FullTeam = "Dallas Stars";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				P1FullTeam = "Detroit Red Wings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				P1FullTeam = "Edmonton Oilers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				P1FullTeam = "Florida Panthers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "HAR") {
				P1FullTeam = "Hartford Whalers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				P1FullTeam = "Los Angeles Kings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNS") {
				P1FullTeam = "Minnesota North Stars";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNW") {
				P1FullTeam = "Minnesota Wild";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				P1FullTeam = "Montreal Canadiens";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				P1FullTeam = "Nashville Predators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				P1FullTeam = "New Jersey Devils";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				P1FullTeam = "New York Islanders";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				P1FullTeam = "New York Rangers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				P1FullTeam = "Ottawa Senators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				P1FullTeam = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHO") {
				P1FullTeam = "Phoenix Coyotes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				P1FullTeam = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "QUE") {
				P1FullTeam = "Quebec Nordiques";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				P1FullTeam = "St Louis Blues";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				P1FullTeam = "San Jose Sharks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				P1FullTeam = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				P1FullTeam = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				P1FullTeam = "Vancouver Canucks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				P1FullTeam = "Washington Capitals";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				P1FullTeam = "Winnipeg Jets";
			}

			// P2
			if (PlayerDatabase.ComputerChosenTeam == "ANA") {
				P2FullTeam = "Mighty Ducks of Anaheim";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "ATL") {
				P2FullTeam = "Atlanta Thrashers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BOS") {
				P2FullTeam = "Boston Bruins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BUF") {
				P2FullTeam = "Buffalo Sabres";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAL") {
				P2FullTeam = "Calgary Flames";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAR") {
				P2FullTeam = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CHI") {
				P2FullTeam = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "COL") {
				P2FullTeam = "Colorado Avalanche";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CBJ") {
				P2FullTeam = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DAL") {
				P2FullTeam = "Dallas Stars";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DET") {
				P2FullTeam = "Detroit Red Wings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "EDM") {
				P2FullTeam = "Edmonton Oilers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "FLA") {
				P2FullTeam = "Florida Panthers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "HAR") {
				P2FullTeam = "Hartford Whalers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "LAK") {
				P2FullTeam = "Los Angeles Kings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MNS") {
				P2FullTeam = "Minnesota North Stars";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MNW") {
				P2FullTeam = "Minnesota Wild";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MON") {
				P2FullTeam = "Montreal Canadiens";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NAS") {
				P2FullTeam = "Nashville Predators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NJD") {
				P2FullTeam = "New Jersey Devils";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYI") {
				P2FullTeam = "New York Islanders";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYR") {
				P2FullTeam = "New York Rangers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "OTT") {
				P2FullTeam = "Ottawa Senators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHI") {
				P2FullTeam = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHO") {
				P2FullTeam = "Phoenix Coyotes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PIT") {
				P2FullTeam = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "QUE") {
				P2FullTeam = "Quebec Nordiques";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "STL") {
				P2FullTeam = "St Louis Blues";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SJS") {
				P2FullTeam = "San Jose Sharks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TBL") {
				P2FullTeam = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TOR") {
				P2FullTeam = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VAN") {
				P2FullTeam = "Vancouver Canucks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WAS") {
				P2FullTeam = "Washington Capitals";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WPG") {
				P2FullTeam = "Winnipeg Jets";
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}