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

public class EnableObjects26B : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image ShotButton;
	public Text BreakawayShotTitle;
	public Text PlayerShot02;
	public Text PlayerShot03;
	public Text PlayerShot04;
	public Text PlayerShot05;
	public Text PlayerShot06;
	public Text PlayerShot07;
	public Text PlayerShot08;
	public Text PlayerShot09;
	public Text PlayerShot10;
	public Text PlayerShot11;
	public Text PlayerShot12;

	// Scoreboard Objects
	public Image ScoreboardBackground;
	public Text P1Score;
	public Text P2Score;
	public Text P1Shots;
	public Text P2Shots;
	public Text Period;
	public Text Play;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ShootoutRoundInt;
	public static string ShootoutTurnString;
	public static string ShooterNameP1;
	public static string ShooterNameP2;
	public static string FullTeamNameP1;
	public static string FullTeamNameP2;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableMainObjects();
		EnableScoreboardObjects();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingScoreboard();
		UpdatingActionText();
		UpdatingRoundText();
		UpdatingTurnColor();
		UpdatingShotTexts();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
		ShotButton.enabled = true;
		BreakawayShotTitle.enabled = true;
		PlayerShot02.enabled = true;
		PlayerShot03.enabled = true;
		PlayerShot04.enabled = true;
		PlayerShot05.enabled = true;
		PlayerShot06.enabled = true;
		PlayerShot07.enabled = true;
		PlayerShot08.enabled = true;
		PlayerShot09.enabled = true;
		PlayerShot10.enabled = true;
		PlayerShot11.enabled = true;
		PlayerShot12.enabled = true;
	}

	public void EnableScoreboardObjects() {
		ScoreboardBackground.enabled = true;
		P1Score.enabled = true;
		P2Score.enabled = true;
		P1Shots.enabled = true;
		P2Shots.enabled = true;
		Period.enabled = true;
		Play.enabled = true;
	}

// --------------- DISABLING OBEJCTS FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ActionText.enabled = false;
		ShotButton.enabled = false;
		BreakawayShotTitle.enabled = false;
		PlayerShot02.enabled = false;
		PlayerShot03.enabled = false;
		PlayerShot04.enabled = false;
		PlayerShot05.enabled = false;
		PlayerShot06.enabled = false;
		PlayerShot07.enabled = false;
		PlayerShot08.enabled = false;
		PlayerShot09.enabled = false;
		PlayerShot10.enabled = false;
		PlayerShot11.enabled = false;
		PlayerShot12.enabled = false;
	}

	public void DisableScoreboardObjects() {
		ScoreboardBackground.enabled = false;
		P1Score.enabled = false;
		P2Score.enabled = false;
		P1Shots.enabled = false;
		P2Shots.enabled = false;
		Period.enabled = false;
		Play.enabled = false;
	}

// --------------- UPDATING TEXT FUNCTIONS ---------------
	public void UpdatingScoreboard() {
		P1Score.text = PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.GameplayP1Score;
		P2Score.text = PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.GameplayP2Score;
		P1Shots.text = PlayerDatabase.PlayerChosenTeam + ": " + PlayerDatabase.GameplayP1Shots + " shots";
		P2Shots.text = PlayerDatabase.ComputerChosenTeam + ": " + PlayerDatabase.GameplayP2Shots + " shots";

		if (System.Int32.Parse(PlayerDatabase.GameplayPlay) > 30) {
			PlayerDatabase.GameplayPlay = "0";
		}

		Play.text = "Play: " + PlayerDatabase.GameplayPlay;

		if (PlayerDatabase.GameplayPeriod == "1") {
			Period.text = "1st Period";
		}

		else if (PlayerDatabase.GameplayPeriod == "2") {
			Period.text = "2nd Period";
		}

		else if (PlayerDatabase.GameplayPeriod == "3") {
			Period.text = "3rd Period";
		}

		else if (PlayerDatabase.GameplayPeriod == "4") {
			Period.text = "Overtime";
		}

		else if (PlayerDatabase.GameplayPeriod == "5") {
			Period.text = "Shootout";
		}
	}

	public void UpdatingActionText() {
		UpdateFullTeamName();
		UpdateCurrentShooter();

		if (ShootoutTurnString == "P1") {
			ActionText.text = ShooterNameP1 + " is up to shoot for the " + FullTeamNameP1;
		}

		else if (ShootoutTurnString == "P2") {
			ActionText.text = ShooterNameP2 + " is up to shoot for the " + FullTeamNameP2;
		}
	}

	public void UpdatingRoundText() {
		TitleText.text = "Shootout (Round " + ShootoutRoundInt.ToString() + ")";
	}

	public void UpdatingTurnColor() {
		if (ShootoutTurnString == "P1") {
			BreakawayShotTitle.color = new Color(0.0509804f, 0.2666667f, 0.4980392f, 1.0f);
		}

		else if (ShootoutTurnString == "P2") {
			BreakawayShotTitle.color = new Color(0.6627451f, 0.007843138f, 0.003921569f, 1.0f);
		}
	}

	public void UpdatingShotTexts() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (ShootoutTurnString == "P1") {
				PlayerShot02.text = "02)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[ShooterNameP1];
				PlayerShot03.text = "03)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[ShooterNameP1];
				PlayerShot04.text = "04)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[ShooterNameP1];
				PlayerShot05.text = "05)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[ShooterNameP1];
				PlayerShot06.text = "06)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[ShooterNameP1];
				PlayerShot07.text = "07)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[ShooterNameP1];
				PlayerShot08.text = "08)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[ShooterNameP1];
				PlayerShot09.text = "09)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[ShooterNameP1];
				PlayerShot10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[ShooterNameP1];
				PlayerShot11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[ShooterNameP1];
				PlayerShot12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[ShooterNameP1];
			}

			else if (ShootoutTurnString == "P2") {
				PlayerShot02.text = "02)" + "\n" + StatsRebBreak02.PlayerStatsRebBreak02[ShooterNameP2];
				PlayerShot03.text = "03)" + "\n" + StatsRebBreak03.PlayerStatsRebBreak03[ShooterNameP2];
				PlayerShot04.text = "04)" + "\n" + StatsRebBreak04.PlayerStatsRebBreak04[ShooterNameP2];
				PlayerShot05.text = "05)" + "\n" + StatsRebBreak05.PlayerStatsRebBreak05[ShooterNameP2];
				PlayerShot06.text = "06)" + "\n" + StatsRebBreak06.PlayerStatsRebBreak06[ShooterNameP2];
				PlayerShot07.text = "07)" + "\n" + StatsRebBreak07.PlayerStatsRebBreak07[ShooterNameP2];
				PlayerShot08.text = "08)" + "\n" + StatsRebBreak08.PlayerStatsRebBreak08[ShooterNameP2];
				PlayerShot09.text = "09)" + "\n" + StatsRebBreak09.PlayerStatsRebBreak09[ShooterNameP2];
				PlayerShot10.text = "10)" + "\n" + StatsRebBreak10.PlayerStatsRebBreak10[ShooterNameP2];
				PlayerShot11.text = "11)" + "\n" + StatsRebBreak11.PlayerStatsRebBreak11[ShooterNameP2];
				PlayerShot12.text = "12)" + "\n" + StatsRebBreak12.PlayerStatsRebBreak12[ShooterNameP2];
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (ShootoutTurnString == "P1") {
				PlayerShot02.text = "02)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot03.text = "03)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot04.text = "04)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot05.text = "05)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot06.text = "06)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot07.text = "07)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot08.text = "08)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot09.text = "09)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
				PlayerShot12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[ShooterNameP1 + PlayerDatabase.PlayerChosenTeam];
			}

			else if (ShootoutTurnString == "P2") {
				PlayerShot02.text = "02)" + "\n" + StatsRebBreak02.FrPlayerStatsRebBreak02[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot03.text = "03)" + "\n" + StatsRebBreak03.FrPlayerStatsRebBreak03[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot04.text = "04)" + "\n" + StatsRebBreak04.FrPlayerStatsRebBreak04[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot05.text = "05)" + "\n" + StatsRebBreak05.FrPlayerStatsRebBreak05[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot06.text = "06)" + "\n" + StatsRebBreak06.FrPlayerStatsRebBreak06[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot07.text = "07)" + "\n" + StatsRebBreak07.FrPlayerStatsRebBreak07[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot08.text = "08)" + "\n" + StatsRebBreak08.FrPlayerStatsRebBreak08[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot09.text = "09)" + "\n" + StatsRebBreak09.FrPlayerStatsRebBreak09[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot10.text = "10)" + "\n" + StatsRebBreak10.FrPlayerStatsRebBreak10[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot11.text = "11)" + "\n" + StatsRebBreak11.FrPlayerStatsRebBreak11[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
				PlayerShot12.text = "12)" + "\n" + StatsRebBreak12.FrPlayerStatsRebBreak12[ShooterNameP2 + PlayerDatabase.ComputerChosenTeam];
			}
		}
	}

	public void UpdateFullTeamName() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			// Show Team Selected Text - Player
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				FullTeamNameP1 = "Anaheim Ducks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ARI") {
				FullTeamNameP1 = "Arizona Coyotes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				FullTeamNameP1 = "Boston Bruins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				FullTeamNameP1 = "Buffalo Sabres";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				FullTeamNameP1 = "Calgary Flames";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				FullTeamNameP1 = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				FullTeamNameP1 = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				FullTeamNameP1 = "Colorado Avalanche";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				FullTeamNameP1 = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				FullTeamNameP1 = "Dallas Stars";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				FullTeamNameP1 = "Detroit Red Wings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				FullTeamNameP1 = "Edmonton Oilers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				FullTeamNameP1 = "Florida Panthers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				FullTeamNameP1 = "Los Angeles Kings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MIN") {
				FullTeamNameP1 = "Minnesota Wild";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				FullTeamNameP1 = "Montreal Canadiens";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				FullTeamNameP1 = "Nashville Predators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				FullTeamNameP1 = "New Jersey Devils";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				FullTeamNameP1 = "New York Islanders";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				FullTeamNameP1 = "New York Rangers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				FullTeamNameP1 = "Ottawa Senators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				FullTeamNameP1 = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				FullTeamNameP1 = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				FullTeamNameP1 = "St Louis Blues";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				FullTeamNameP1 = "San Jose Sharks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SEA") {
				FullTeamNameP1 = "Seattle Kraken";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				FullTeamNameP1 = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				FullTeamNameP1 = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				FullTeamNameP1 = "Vancouver Canucks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VGK") {
				FullTeamNameP1 = "Vegas Golden Knights";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				FullTeamNameP1 = "Washington Capitals";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				FullTeamNameP1 = "Winnipeg Jets";
			}

			// Show Team Selected Text - Computer
			if (PlayerDatabase.ComputerChosenTeam == "ANA") {
				FullTeamNameP2 = "Anaheim Ducks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "ARI") {
				FullTeamNameP2 = "Arizona Coyotes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BOS") {
				FullTeamNameP2 = "Boston Bruins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BUF") {
				FullTeamNameP2 = "Buffalo Sabres";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAL") {
				FullTeamNameP2 = "Calgary Flames";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAR") {
				FullTeamNameP2 = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CHI") {
				FullTeamNameP2 = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "COL") {
				FullTeamNameP2 = "Colorado Avalanche";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CBJ") {
				FullTeamNameP2 = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DAL") {
				FullTeamNameP2 = "Dallas Stars";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DET") {
				FullTeamNameP2 = "Detroit Red Wings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "EDM") {
				FullTeamNameP2 = "Edmonton Oilers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "FLA") {
				FullTeamNameP2 = "Florida Panthers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "LAK") {
				FullTeamNameP2 = "Los Angeles Kings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MIN") {
				FullTeamNameP2 = "Minnesota Wild";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MON") {
				FullTeamNameP2 = "Montreal Canadiens";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NAS") {
				FullTeamNameP2 = "Nashville Predators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NJD") {
				FullTeamNameP2 = "New Jersey Devils";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYI") {
				FullTeamNameP2 = "New York Islanders";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYR") {
				FullTeamNameP2 = "New York Rangers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "OTT") {
				FullTeamNameP2 = "Ottawa Senators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHI") {
				FullTeamNameP2 = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PIT") {
				FullTeamNameP2 = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "STL") {
				FullTeamNameP2 = "St Louis Blues";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SJS") {
				FullTeamNameP2 = "San Jose Sharks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SEA") {
				FullTeamNameP2 = "Seattle Kraken";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TBL") {
				FullTeamNameP2 = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TOR") {
				FullTeamNameP2 = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VAN") {
				FullTeamNameP2 = "Vancouver Canucks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VGK") {
				FullTeamNameP2 = "Vegas Golden Knights";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WAS") {
				FullTeamNameP2 = "Washington Capitals";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WPG") {
				FullTeamNameP2 = "Winnipeg Jets";
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			// Show Franchise Team Selected Text - Player
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				FullTeamNameP1 = "Mighty Ducks of Anaheim";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ATL") {
				FullTeamNameP1 = "Atlanta Thrashers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				FullTeamNameP1 = "Boston Bruins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				FullTeamNameP1 = "Buffalo Sabres";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				FullTeamNameP1 = "Calgary Flames";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				FullTeamNameP1 = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				FullTeamNameP1 = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				FullTeamNameP1 = "Colorado Avalanche";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				FullTeamNameP1 = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				FullTeamNameP1 = "Dallas Stars";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				FullTeamNameP1 = "Detroit Red Wings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				FullTeamNameP1 = "Edmonton Oilers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				FullTeamNameP1 = "Florida Panthers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "HAR") {
				FullTeamNameP1 = "Hartford Whalers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				FullTeamNameP1 = "Los Angeles Kings";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNS") {
				FullTeamNameP1 = "Minnesota North Stars";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNW") {
				FullTeamNameP1 = "Minnesota Wild";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				FullTeamNameP1 = "Montreal Canadiens";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				FullTeamNameP1 = "Nashville Predators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				FullTeamNameP1 = "New Jersey Devils";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				FullTeamNameP1 = "New York Islanders";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				FullTeamNameP1 = "New York Rangers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				FullTeamNameP1 = "Ottawa Senators";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				FullTeamNameP1 = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHO") {
				FullTeamNameP1 = "Phoenix Coyotes";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				FullTeamNameP1 = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "QUE") {
				FullTeamNameP1 = "Quebec Nordiques";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				FullTeamNameP1 = "St Louis Blues";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				FullTeamNameP1 = "San Jose Sharks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				FullTeamNameP1 = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				FullTeamNameP1 = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				FullTeamNameP1 = "Vancouver Canucks";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				FullTeamNameP1 = "Washington Capitals";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				FullTeamNameP1 = "Winnipeg Jets";
			}

			// Show Franchise Team Selected Text - Computer
			if (PlayerDatabase.ComputerChosenTeam == "ANA") {
				FullTeamNameP2 = "Mighty Ducks of Anaheim";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "ATL") {
				FullTeamNameP2 = "Atlanta Thrashers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BOS") {
				FullTeamNameP2 = "Boston Bruins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BUF") {
				FullTeamNameP2 = "Buffalo Sabres";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAL") {
				FullTeamNameP2 = "Calgary Flames";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAR") {
				FullTeamNameP2 = "Carolina Hurricanes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CHI") {
				FullTeamNameP2 = "Chicago Blackhawks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "COL") {
				FullTeamNameP2 = "Colorado Avalanche";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CBJ") {
				FullTeamNameP2 = "Columbus Blue Jackets";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DAL") {
				FullTeamNameP2 = "Dallas Stars";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DET") {
				FullTeamNameP2 = "Detroit Red Wings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "EDM") {
				FullTeamNameP2 = "Edmonton Oilers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "FLA") {
				FullTeamNameP2 = "Florida Panthers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "HAR") {
				FullTeamNameP2 = "Hartford Whalers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "LAK") {
				FullTeamNameP2 = "Los Angeles Kings";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MNS") {
				FullTeamNameP2 = "Minnesota North Stars";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MNW") {
				FullTeamNameP2 = "Minnesota Wild";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MON") {
				FullTeamNameP2 = "Montreal Canadiens";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NAS") {
				FullTeamNameP2 = "Nashville Predators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NJD") {
				FullTeamNameP2 = "New Jersey Devils";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYI") {
				FullTeamNameP2 = "New York Islanders";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYR") {
				FullTeamNameP2 = "New York Rangers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "OTT") {
				FullTeamNameP2 = "Ottawa Senators";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHI") {
				FullTeamNameP2 = "Philadelphia Flyers";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHO") {
				FullTeamNameP2 = "Phoenix Coyotes";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PIT") {
				FullTeamNameP2 = "Pittsburgh Penguins";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "QUE") {
				FullTeamNameP2 = "Quebec Nordiques";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "STL") {
				FullTeamNameP2 = "St Louis Blues";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SJS") {
				FullTeamNameP2 = "San Jose Sharks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TBL") {
				FullTeamNameP2 = "Tampa Bay Lightning";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TOR") {
				FullTeamNameP2 = "Toronto Maple Leafs";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VAN") {
				FullTeamNameP2 = "Vancouver Canucks";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WAS") {
				FullTeamNameP2 = "Washington Capitals";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WPG") {
				FullTeamNameP2 = "Winnipeg Jets";
			}
		}
	}

	public void UpdateCurrentShooter() {
		if (ShootoutRoundInt == 1) {
			ShooterNameP1 = PlayerDatabase.P1C1;
			ShooterNameP2 = PlayerDatabase.P2C1;
		}

		else if (ShootoutRoundInt == 2) {
			ShooterNameP1 = PlayerDatabase.P1LW1;
			ShooterNameP2 = PlayerDatabase.P2LW1;
		}

		else if (ShootoutRoundInt == 3) {
			ShooterNameP1 = PlayerDatabase.P1RW1;
			ShooterNameP2 = PlayerDatabase.P2RW1;
		}

		else if (ShootoutRoundInt == 4) {
			ShooterNameP1 = PlayerDatabase.P1C2;
			ShooterNameP2 = PlayerDatabase.P2C2;
		}

		else if (ShootoutRoundInt == 5) {
			ShooterNameP1 = PlayerDatabase.P1LW2;
			ShooterNameP2 = PlayerDatabase.P2LW2;
		}

		else if (ShootoutRoundInt == 6) {
			ShooterNameP1 = PlayerDatabase.P1RW2;
			ShooterNameP2 = PlayerDatabase.P2RW2;
		}

		else if (ShootoutRoundInt == 7) {
			ShooterNameP1 = PlayerDatabase.P1LD1;
			ShooterNameP2 = PlayerDatabase.P2LD1;
		}

		else if (ShootoutRoundInt == 8) {
			ShooterNameP1 = PlayerDatabase.P1RD1;
			ShooterNameP2 = PlayerDatabase.P2RD1;
		}

		else if (ShootoutRoundInt == 9) {
			ShooterNameP1 = PlayerDatabase.P1C3;
			ShooterNameP2 = PlayerDatabase.P2C3;
		}

		else if (ShootoutRoundInt == 10) {
			ShooterNameP1 = PlayerDatabase.P1LW3;
			ShooterNameP2 = PlayerDatabase.P2LW3;
		}

		else if (ShootoutRoundInt == 11) {
			ShooterNameP1 = PlayerDatabase.P1RW3;
			ShooterNameP2 = PlayerDatabase.P2RW3;
		}

		else if (ShootoutRoundInt == 12) {
			ShooterNameP1 = PlayerDatabase.P1LD2;
			ShooterNameP2 = PlayerDatabase.P2LD2;
		}

		else if (ShootoutRoundInt == 13) {
			ShooterNameP1 = PlayerDatabase.P1RD2;
			ShooterNameP2 = PlayerDatabase.P2RD2;
		}

		else if (ShootoutRoundInt == 14) {
			ShooterNameP1 = PlayerDatabase.P1C4;
			ShooterNameP2 = PlayerDatabase.P2C4;
		}

		else if (ShootoutRoundInt == 15) {
			ShooterNameP1 = PlayerDatabase.P1LW4;
			ShooterNameP2 = PlayerDatabase.P2LW4;
		}

		else if (ShootoutRoundInt == 16) {
			ShooterNameP1 = PlayerDatabase.P1RW4;
			ShooterNameP2 = PlayerDatabase.P2RW4;
		}

		else if (ShootoutRoundInt == 17) {
			ShooterNameP1 = PlayerDatabase.P1LD3;
			ShooterNameP2 = PlayerDatabase.P2LD3;
		}

		else if (ShootoutRoundInt == 18) {
			ShooterNameP1 = PlayerDatabase.P1RD3;
			ShooterNameP2 = PlayerDatabase.P2RD3;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}