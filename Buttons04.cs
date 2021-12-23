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

public class Buttons04 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Button ContinueButton;

	// Select Line Objects
	public Button SetLW1Button;
	public Button SetC1Button;
	public Button SetRW1Button;
	public Button SetLW2Button;
	public Button SetC2Button;
	public Button SetRW2Button;
	public Button SetLW3Button;
	public Button SetC3Button;
	public Button SetRW3Button;
	public Button SetLW4Button;
	public Button SetC4Button;
	public Button SetRW4Button;
	public Button SetLD1Button;
	public Button SetRD1Button;
	public Button SetLD2Button;
	public Button SetRD2Button;
	public Button SetLD3Button;
	public Button SetRD3Button;
	public Button SetGButton;
	public Button SetLW1Text;
	public Button SetC1Text;
	public Button SetRW1Text;
	public Button SetLW2Text;
	public Button SetC2Text;
	public Button SetRW2Text;
	public Button SetLW3Text;
	public Button SetC3Text;
	public Button SetRW3Text;
	public Button SetLW4Text;
	public Button SetC4Text;
	public Button SetRW4Text;
	public Button SetLD1Text;
	public Button SetRD1Text;
	public Button SetLD2Text;
	public Button SetRD2Text;
	public Button SetLD3Text;
	public Button SetRD3Text;
	public Button SetGText;
	public Button DefaultLinesButton;

	// Player Select Objects
	public Text PlayerText01;
	public Text PlayerText02;
	public Text PlayerText03;
	public Text PlayerText04;
	public Text PlayerText05;
	public Text PlayerText06;
	public Text PlayerText07;
	public Text PlayerText08;
	public Text PlayerText09;
	public Text PlayerText10;
	public Text PlayerText11;
	public Text PlayerText12;
	public Button PlayerStats01;
	public Button PlayerStats02;
	public Button PlayerStats03;
	public Button PlayerStats04;
	public Button PlayerStats05;
	public Button PlayerStats06;
	public Button PlayerStats07;
	public Button PlayerStats08;
	public Button PlayerStats09;
	public Button PlayerStats10;
	public Button PlayerStats11;
	public Button PlayerStats12;
	public Button StatsBackButton;

	// Player Card Objects
	public Button PlayerSetBackButton;
	public Button PlayerSetButton;

	// Goalie Select Objects
	public Text GoalieText01;
	public Text GoalieText02;
	public Text GoalieText03;
	public Text GoalieText04;
	public Text GoalieText05;
	public Text GoalieText06;
	public Text GoalieText07;
	public Button GoalieStats01;
	public Button GoalieStats02;
	public Button GoalieStats03;
	public Button GoalieStats04;
	public Button GoalieStats05;
	public Button GoalieStats06;
	public Button GoalieStats07;
	public Button GoalieStatsBackButton;

	// Goalie Card Objects
	public Button GoalieSetBackButton;
	public Button GoalieSetButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string SettingPlayerPositions;
	public static int RandomComputerTeamInt;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene05LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		SettingPlayerPositions = "None";

		// Main Objects
		Button ContinueButtonClick = ContinueButton.GetComponent<Button>();
		ContinueButtonClick.onClick.AddListener(ContinueButtonClicking);

		// Select Line Objects
		Button SetLW1ButtonClick = SetLW1Button.GetComponent<Button>();
		Button SetC1ButtonClick = SetC1Button.GetComponent<Button>();
		Button SetRW1ButtonClick = SetRW1Button.GetComponent<Button>();
		Button SetLW2ButtonClick = SetLW2Button.GetComponent<Button>();
		Button SetC2ButtonClick = SetC2Button.GetComponent<Button>();
		Button SetRW2ButtonClick = SetRW2Button.GetComponent<Button>();
		Button SetLW3ButtonClick = SetLW3Button.GetComponent<Button>();
		Button SetC3ButtonClick = SetC3Button.GetComponent<Button>();
		Button SetRW3ButtonClick = SetRW3Button.GetComponent<Button>();
		Button SetLW4ButtonClick = SetLW4Button.GetComponent<Button>();
		Button SetC4ButtonClick = SetC4Button.GetComponent<Button>();
		Button SetRW4ButtonClick = SetRW4Button.GetComponent<Button>();
		Button SetLD1ButtonClick = SetLD1Button.GetComponent<Button>();
		Button SetRD1ButtonClick = SetRD1Button.GetComponent<Button>();
		Button SetLD2ButtonClick = SetLD2Button.GetComponent<Button>();
		Button SetRD2ButtonClick = SetRD2Button.GetComponent<Button>();
		Button SetLD3ButtonClick = SetLD3Button.GetComponent<Button>();
		Button SetRD3ButtonClick = SetRD3Button.GetComponent<Button>();
		Button SetGButtonClick = SetGButton.GetComponent<Button>();
		Button SetLW1TextClick = SetLW1Text.GetComponent<Button>();
		Button SetC1TextClick = SetC1Text.GetComponent<Button>();
		Button SetRW1TextClick = SetRW1Text.GetComponent<Button>();
		Button SetLW2TextClick = SetLW2Text.GetComponent<Button>();
		Button SetC2TextClick = SetC2Text.GetComponent<Button>();
		Button SetRW2TextClick = SetRW2Text.GetComponent<Button>();
		Button SetLW3TextClick = SetLW3Text.GetComponent<Button>();
		Button SetC3TextClick = SetC3Text.GetComponent<Button>();
		Button SetRW3TextClick = SetRW3Text.GetComponent<Button>();
		Button SetLW4TextClick = SetLW4Text.GetComponent<Button>();
		Button SetC4TextClick = SetC4Text.GetComponent<Button>();
		Button SetRW4TextClick = SetRW4Text.GetComponent<Button>();
		Button SetLD1TextClick = SetLD1Text.GetComponent<Button>();
		Button SetRD1TextClick = SetRD1Text.GetComponent<Button>();
		Button SetLD2TextClick = SetLD2Text.GetComponent<Button>();
		Button SetRD2TextClick = SetRD2Text.GetComponent<Button>();
		Button SetLD3TextClick = SetLD3Text.GetComponent<Button>();
		Button SetRD3TextClick = SetRD3Text.GetComponent<Button>();
		Button SetGTextClick = SetGText.GetComponent<Button>();

		SetLW1ButtonClick.onClick.AddListener(SetLW1ButtonClicking);
		SetC1ButtonClick.onClick.AddListener(SetC1ButtonClicking);
		SetRW1ButtonClick.onClick.AddListener(SetRW1ButtonClicking);
		SetLW2ButtonClick.onClick.AddListener(SetLW2ButtonClicking);
		SetC2ButtonClick.onClick.AddListener(SetC2ButtonClicking);
		SetRW2ButtonClick.onClick.AddListener(SetRW2ButtonClicking);
		SetLW3ButtonClick.onClick.AddListener(SetLW3ButtonClicking);
		SetC3ButtonClick.onClick.AddListener(SetC3ButtonClicking);
		SetRW3ButtonClick.onClick.AddListener(SetRW3ButtonClicking);
		SetLW4ButtonClick.onClick.AddListener(SetLW4ButtonClicking);
		SetC4ButtonClick.onClick.AddListener(SetC4ButtonClicking);
		SetRW4ButtonClick.onClick.AddListener(SetRW4ButtonClicking);
		SetLD1ButtonClick.onClick.AddListener(SetLD1ButtonClicking);
		SetRD1ButtonClick.onClick.AddListener(SetRD1ButtonClicking);
		SetLD2ButtonClick.onClick.AddListener(SetLD2ButtonClicking);
		SetRD2ButtonClick.onClick.AddListener(SetRD2ButtonClicking);
		SetLD3ButtonClick.onClick.AddListener(SetLD3ButtonClicking);
		SetRD3ButtonClick.onClick.AddListener(SetRD3ButtonClicking);
		SetGButtonClick.onClick.AddListener(SetGButtonClicking);
		SetLW1TextClick.onClick.AddListener(SetLW1TextClicking);
		SetC1TextClick.onClick.AddListener(SetC1TextClicking);
		SetRW1TextClick.onClick.AddListener(SetRW1TextClicking);
		SetLW2TextClick.onClick.AddListener(SetLW2TextClicking);
		SetC2TextClick.onClick.AddListener(SetC2TextClicking);
		SetRW2TextClick.onClick.AddListener(SetRW2TextClicking);
		SetLW3TextClick.onClick.AddListener(SetLW3TextClicking);
		SetC3TextClick.onClick.AddListener(SetC3TextClicking);
		SetRW3TextClick.onClick.AddListener(SetRW3TextClicking);
		SetLW4TextClick.onClick.AddListener(SetLW4TextClicking);
		SetC4TextClick.onClick.AddListener(SetC4TextClicking);
		SetRW4TextClick.onClick.AddListener(SetRW4TextClicking);
		SetLD1TextClick.onClick.AddListener(SetLD1TextClicking);
		SetRD1TextClick.onClick.AddListener(SetRD1TextClicking);
		SetLD2TextClick.onClick.AddListener(SetLD2TextClicking);
		SetRD2TextClick.onClick.AddListener(SetRD2TextClicking);
		SetLD3TextClick.onClick.AddListener(SetLD3TextClicking);
		SetRD3TextClick.onClick.AddListener(SetRD3TextClicking);
		SetGTextClick.onClick.AddListener(SetGTextClicking);

		// Pre-Set Lines
		Button DefaultLinesButtonClick = DefaultLinesButton.GetComponent<Button>();
		DefaultLinesButtonClick.onClick.AddListener(DefaultLinesButtonClicking);

		// Player Select Objects
		Button PlayerStats01Click = PlayerStats01.GetComponent<Button>();
		Button PlayerStats02Click = PlayerStats02.GetComponent<Button>();
		Button PlayerStats03Click = PlayerStats03.GetComponent<Button>();
		Button PlayerStats04Click = PlayerStats04.GetComponent<Button>();
		Button PlayerStats05Click = PlayerStats05.GetComponent<Button>();
		Button PlayerStats06Click = PlayerStats06.GetComponent<Button>();
		Button PlayerStats07Click = PlayerStats07.GetComponent<Button>();
		Button PlayerStats08Click = PlayerStats08.GetComponent<Button>();
		Button PlayerStats09Click = PlayerStats09.GetComponent<Button>();
		Button PlayerStats10Click = PlayerStats10.GetComponent<Button>();
		Button PlayerStats11Click = PlayerStats11.GetComponent<Button>();
		Button PlayerStats12Click = PlayerStats12.GetComponent<Button>();
		Button StatsBackButtonClick = StatsBackButton.GetComponent<Button>();

		PlayerStats01Click.onClick.AddListener(PlayerStats01Clicking);
		PlayerStats02Click.onClick.AddListener(PlayerStats02Clicking);
		PlayerStats03Click.onClick.AddListener(PlayerStats03Clicking);
		PlayerStats04Click.onClick.AddListener(PlayerStats04Clicking);
		PlayerStats05Click.onClick.AddListener(PlayerStats05Clicking);
		PlayerStats06Click.onClick.AddListener(PlayerStats06Clicking);
		PlayerStats07Click.onClick.AddListener(PlayerStats07Clicking);
		PlayerStats08Click.onClick.AddListener(PlayerStats08Clicking);
		PlayerStats09Click.onClick.AddListener(PlayerStats09Clicking);
		PlayerStats10Click.onClick.AddListener(PlayerStats10Clicking);
		PlayerStats11Click.onClick.AddListener(PlayerStats11Clicking);
		PlayerStats12Click.onClick.AddListener(PlayerStats12Clicking);
		StatsBackButtonClick.onClick.AddListener(StatsBackButtonClicking);

		// Player Card Objects
		Button PlayerSetBackButtonClick = PlayerSetBackButton.GetComponent<Button>();
		Button PlayerSetButtonClick = PlayerSetButton.GetComponent<Button>();

		PlayerSetBackButtonClick.onClick.AddListener(PlayerSetBackButtonClicking);
		PlayerSetButtonClick.onClick.AddListener(PlayerSetButtonClicking);

		// Goalie Select Objects
		Button GoalieStats01Click = GoalieStats01.GetComponent<Button>();
		Button GoalieStats02Click = GoalieStats02.GetComponent<Button>();
		Button GoalieStats03Click = GoalieStats03.GetComponent<Button>();
		Button GoalieStats04Click = GoalieStats04.GetComponent<Button>();
		Button GoalieStats05Click = GoalieStats05.GetComponent<Button>();
		Button GoalieStats06Click = GoalieStats06.GetComponent<Button>();
		Button GoalieStats07Click = GoalieStats07.GetComponent<Button>();
		Button GoalieStatsBackButtonClick = GoalieStatsBackButton.GetComponent<Button>();

		GoalieStats01Click.onClick.AddListener(GoalieStats01Clicking);
		GoalieStats02Click.onClick.AddListener(GoalieStats02Clicking);
		GoalieStats03Click.onClick.AddListener(GoalieStats03Clicking);
		GoalieStats04Click.onClick.AddListener(GoalieStats04Clicking);
		GoalieStats05Click.onClick.AddListener(GoalieStats05Clicking);
		GoalieStats06Click.onClick.AddListener(GoalieStats06Clicking);
		GoalieStats07Click.onClick.AddListener(GoalieStats07Clicking);
		GoalieStatsBackButtonClick.onClick.AddListener(GoalieStatsBackButtonClicking);

		// Goalie Card Objects
		Button GoalieSetBackButtonClick = GoalieSetBackButton.GetComponent<Button>();
		Button GoalieSetButtonClick = GoalieSetButton.GetComponent<Button>();

		GoalieSetButtonClick.onClick.AddListener(GoalieSetButtonClicking);
		GoalieSetBackButtonClick.onClick.AddListener(GoalieSetBackButtonClicking);
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
	public void ContinueButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "None";
		EnableObjects04.ShowingPlayerInfoString = "None";
		EnableObjects04.ShowingPlayerInfoInt = 0;
		SetComputerLines();
		Scene05LoadRun.Scene05Load();
	}

	public void SetLW1ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "LW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LW1";
		PlayerDatabase.P1LW1 = "None";
	}
	
	public void SetC1ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "C";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "C1";
		PlayerDatabase.P1C1 = "None";
	}
	
	public void SetRW1ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "RW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RW1";
		PlayerDatabase.P1RW1 = "None";
	}
	
	public void SetLW2ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "LW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LW2";
		PlayerDatabase.P1LW2 = "None";
	}
	
	public void SetC2ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "C";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "C2";
		PlayerDatabase.P1C2 = "None";
	}
	
	public void SetRW2ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "RW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RW2";
		PlayerDatabase.P1RW2 = "None";
	}
	
	public void SetLW3ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "LW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LW3";
		PlayerDatabase.P1LW3 = "None";
	}
	
	public void SetC3ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "C";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "C3";
		PlayerDatabase.P1C3 = "None";
	}
	
	public void SetRW3ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "RW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RW3";
		PlayerDatabase.P1RW3 = "None";
	}
	
	public void SetLW4ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "LW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LW4";
		PlayerDatabase.P1LW4 = "None";
	}
	
	public void SetC4ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "C";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "C4";
		PlayerDatabase.P1C4 = "None";
	}
	
	public void SetRW4ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "RW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RW4";
		PlayerDatabase.P1RW4 = "None";
	}
	
	public void SetLD1ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "LD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LD1";
		PlayerDatabase.P1LD1 = "None";
	}
	
	public void SetRD1ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "RD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RD1";
		PlayerDatabase.P1RD1 = "None";
	}
	
	public void SetLD2ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "LD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LD2";
		PlayerDatabase.P1LD2 = "None";
	}
	
	public void SetRD2ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "RD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RD2";
		PlayerDatabase.P1RD2 = "None";
	}
	
	public void SetLD3ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "LD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LD3";
		PlayerDatabase.P1LD3 = "None";
	}
	
	public void SetRD3ButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "RD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RD3";
		PlayerDatabase.P1RD3 = "None";
	}
	
	public void SetGButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "G";
		EnableObjects04.ShowingPlayerInfoInt = 3;
		SettingPlayerPositions = "G";
		PlayerDatabase.P1G = "None";
	}

	public void SetLW1TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "LW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LW1";
		PlayerDatabase.P1LW1 = "None";
	}
	
	public void SetC1TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "C";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "C1";
		PlayerDatabase.P1C1 = "None";
	}
	
	public void SetRW1TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "RW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RW1";
		PlayerDatabase.P1RW1 = "None";
	}
	
	public void SetLW2TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "LW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LW2";
		PlayerDatabase.P1LW2 = "None";
	}
	
	public void SetC2TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "C";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "C2";
		PlayerDatabase.P1C2 = "None";
	}
	
	public void SetRW2TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "RW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RW2";
		PlayerDatabase.P1RW2 = "None";
	}
	
	public void SetLW3TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "LW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LW3";
		PlayerDatabase.P1LW3 = "None";
	}
	
	public void SetC3TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "C";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "C3";
		PlayerDatabase.P1C3 = "None";
	}
	
	public void SetRW3TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "RW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RW3";
		PlayerDatabase.P1RW3 = "None";
	}
	
	public void SetLW4TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "LW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LW4";
		PlayerDatabase.P1LW4 = "None";
	}
	
	public void SetC4TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "C";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "C4";
		PlayerDatabase.P1C4 = "None";
	}
	
	public void SetRW4TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "RW";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RW4";
		PlayerDatabase.P1RW4 = "None";
	}
	
	public void SetLD1TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "LD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LD1";
		PlayerDatabase.P1LD1 = "None";
	}
	
	public void SetRD1TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "RD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RD1";
		PlayerDatabase.P1RD1 = "None";
	}
	
	public void SetLD2TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "LD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LD2";
		PlayerDatabase.P1LD2 = "None";
	}
	
	public void SetRD2TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "RD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RD2";
		PlayerDatabase.P1RD2 = "None";
	}
	
	public void SetLD3TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "LD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "LD3";
		PlayerDatabase.P1LD3 = "None";
	}
	
	public void SetRD3TextClicking() {
		EnableObjects04.ShowingPlayerPositions = "RD";
		EnableObjects04.ShowingPlayerInfoInt = 1;
		SettingPlayerPositions = "RD3";
		PlayerDatabase.P1RD3 = "None";
	}
	
	public void SetGTextClicking() {
		EnableObjects04.ShowingPlayerPositions = "G";
		EnableObjects04.ShowingPlayerInfoInt = 3;
		SettingPlayerPositions = "G";
		PlayerDatabase.P1G = "None";
	}
	
	public void PlayerStats01Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText01.text;
	}
	
	public void PlayerStats02Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText02.text;
	}
	
	public void PlayerStats03Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText03.text;
	}
	
	public void PlayerStats04Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText04.text;
	}
	
	public void PlayerStats05Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText05.text;
	}
	
	public void PlayerStats06Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText06.text;
	}
	
	public void PlayerStats07Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText07.text;
	}
	
	public void PlayerStats08Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText08.text;
	}
	
	public void PlayerStats09Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText09.text;
	}
	
	public void PlayerStats10Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText10.text;
	}
	
	public void PlayerStats11Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText11.text;
	}
	
	public void PlayerStats12Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 2;
		EnableObjects04.ShowingPlayerInfoString = PlayerText12.text;
	}
	
	public void StatsBackButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "None";
		EnableObjects04.ShowingPlayerInfoString = "None";
		EnableObjects04.ShowingPlayerInfoInt = 0;
	}

	public void PlayerSetBackButtonClicking() {
		EnableObjects04.ShowingPlayerInfoString = "None";
		EnableObjects04.ShowingPlayerInfoInt = 1;
	}
	
	public void PlayerSetButtonClicking() {
		if (SettingPlayerPositions == "LW1") {
			PlayerDatabase.P1LW1 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "LW2") {
			PlayerDatabase.P1LW2 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "LW3") {
			PlayerDatabase.P1LW3 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "LW4") {
			PlayerDatabase.P1LW4 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "C1") {
			PlayerDatabase.P1C1 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "C2") {
			PlayerDatabase.P1C2 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "C3") {
			PlayerDatabase.P1C3 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "C4") {
			PlayerDatabase.P1C4 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "RW1") {
			PlayerDatabase.P1RW1 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "RW2") {
			PlayerDatabase.P1RW2 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "RW3") {
			PlayerDatabase.P1RW3 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "RW4") {
			PlayerDatabase.P1RW4 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "LD1") {
			PlayerDatabase.P1LD1 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "LD2") {
			PlayerDatabase.P1LD2 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "LD3") {
			PlayerDatabase.P1LD3 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "RD1") {
			PlayerDatabase.P1RD1 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "RD2") {
			PlayerDatabase.P1RD2 = EnableObjects04.ShowingPlayerInfoString;
		}

		else if (SettingPlayerPositions == "RD3") {
			PlayerDatabase.P1RD3 = EnableObjects04.ShowingPlayerInfoString;
		}

		EnableObjects04.ShowingPlayerPositions = "None";
		EnableObjects04.ShowingPlayerInfoString = "None";
		EnableObjects04.ShowingPlayerInfoInt = 0;
		SettingPlayerPositions = "None";
	}

	public void GoalieStats01Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 4;
		EnableObjects04.ShowingPlayerInfoString = GoalieText01.text;
	}

	public void GoalieStats02Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 4;
		EnableObjects04.ShowingPlayerInfoString = GoalieText02.text;
	}
	
	public void GoalieStats03Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 4;
		EnableObjects04.ShowingPlayerInfoString = GoalieText03.text;
	}
	
	public void GoalieStats04Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 4;
		EnableObjects04.ShowingPlayerInfoString = GoalieText04.text;
	}
	
	public void GoalieStats05Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 4;
		EnableObjects04.ShowingPlayerInfoString = GoalieText05.text;
	}
	
	public void GoalieStats06Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 4;
		EnableObjects04.ShowingPlayerInfoString = GoalieText06.text;
	}
	
	public void GoalieStats07Clicking() {
		EnableObjects04.ShowingPlayerInfoInt = 4;
		EnableObjects04.ShowingPlayerInfoString = GoalieText07.text;
	}
	
	public void GoalieStatsBackButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "None";
		EnableObjects04.ShowingPlayerInfoString = "None";
		EnableObjects04.ShowingPlayerInfoInt = 0;
	}

	public void GoalieSetBackButtonClicking() {
		EnableObjects04.ShowingPlayerInfoInt = 3;
	}

	public void GoalieSetButtonClicking() {
		PlayerDatabase.P1G = EnableObjects04.ShowingPlayerInfoString;
		EnableObjects04.ShowingPlayerPositions = "None";
		EnableObjects04.ShowingPlayerInfoString = "None";
		EnableObjects04.ShowingPlayerInfoInt = 0;
		SettingPlayerPositions = "None";
	}

	public void DefaultLinesButtonClicking() {
		EnableObjects04.ShowingPlayerPositions = "None";
		EnableObjects04.ShowingPlayerInfoString = "None";
		EnableObjects04.ShowingPlayerInfoInt = 0;
		SetPreSetLines();
		SetComputerLines();
		Scene05LoadRun.Scene05Load();
	}

	public void SetPreSetLines() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				PlayerDatabase.P1LW1 = "Maxime Comtois";
				PlayerDatabase.P1LW2 = "Sonny Milano";
				PlayerDatabase.P1LW3 = "Alexander Volkov";
				PlayerDatabase.P1LW4 = "Max Jones";
				PlayerDatabase.P1C1 = "Ryan Getzlaf";
				PlayerDatabase.P1C2 = "Trevor Zegras";
				PlayerDatabase.P1C3 = "Adam Henrique";
				PlayerDatabase.P1C4 = "Sam Steel";
				PlayerDatabase.P1RW1 = "Rickard Rakell";
				PlayerDatabase.P1RW2 = "Jakob Silfverberg";
				PlayerDatabase.P1RW3 = "Troy Terry";
				PlayerDatabase.P1RW4 = "Derek Grant";
				PlayerDatabase.P1LD1 = "Cam Fowler";
				PlayerDatabase.P1LD2 = "Kevin Shattenkirk";
				PlayerDatabase.P1LD3 = "Jamie Drysdale";
				PlayerDatabase.P1RD1 = "Hampus Lindholm";
				PlayerDatabase.P1RD2 = "Brogan Rafferty";
				PlayerDatabase.P1RD3 = "Josh Mahura";
				PlayerDatabase.P1G = "John Gibson";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ARI") {
				PlayerDatabase.P1LW1 = "Ryan Dzingel";
				PlayerDatabase.P1LW2 = "Alex Galchenyuk";
				PlayerDatabase.P1LW3 = "Andrew Ladd";
				PlayerDatabase.P1LW4 = "Antoine Roussel";
				PlayerDatabase.P1C1 = "Nick Schmaltz";
				PlayerDatabase.P1C2 = "Travis Boyd";
				PlayerDatabase.P1C3 = "Loui Eriksson";
				PlayerDatabase.P1C4 = "Liam OBrien";
				PlayerDatabase.P1RW1 = "Phil Kessel";
				PlayerDatabase.P1RW2 = "Clayton Keller";
				PlayerDatabase.P1RW3 = "Dmitri Jaskin";
				PlayerDatabase.P1RW4 = "Christian Fischer";
				PlayerDatabase.P1LD1 = "Jakob Chychrun";
				PlayerDatabase.P1LD2 = "Shayne Gostisbehere";
				PlayerDatabase.P1LD3 = "Conor Timmins";
				PlayerDatabase.P1RD1 = "Victor Soderstrom";
				PlayerDatabase.P1RD2 = "Anton Stralman";
				PlayerDatabase.P1RD3 = "Ilya Lyubushkin";
				PlayerDatabase.P1G = "Carter Hutton";
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				PlayerDatabase.P1LW1 = "Brad Marchand";
				PlayerDatabase.P1LW2 = "Taylor Hall";
				PlayerDatabase.P1LW3 = "Jake DeBrusk";
				PlayerDatabase.P1LW4 = "Peter Cehlarik";
				PlayerDatabase.P1C1 = "Patrice Bergeron";
				PlayerDatabase.P1C2 = "Erik Haula";
				PlayerDatabase.P1C3 = "Charlie Coyle";
				PlayerDatabase.P1C4 = "Jakob ForsbackaKarlsson";
				PlayerDatabase.P1RW1 = "David Pastrnak";
				PlayerDatabase.P1RW2 = "Craig Smith";
				PlayerDatabase.P1RW3 = "Nick Foligno";
				PlayerDatabase.P1RW4 = "Curtis Lazar";
				PlayerDatabase.P1LD1 = "Mike Reilly";
				PlayerDatabase.P1LD2 = "Tyler Lewington";
				PlayerDatabase.P1LD3 = "Jakub Zboril";
				PlayerDatabase.P1RD1 = "Charlie McAvoy";
				PlayerDatabase.P1RD2 = "Matt Grzelcyk";
				PlayerDatabase.P1RD3 = "Brandon Carlo";
				PlayerDatabase.P1G = "Tuukka Rask";
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				PlayerDatabase.P1LW1 = "Victor Olofsson";
				PlayerDatabase.P1LW2 = "Jeff Skinner";
				PlayerDatabase.P1LW3 = "Drake Caggiula";
				PlayerDatabase.P1LW4 = "Anders Bjork";
				PlayerDatabase.P1C1 = "Jack Eichel";
				PlayerDatabase.P1C2 = "Vinnie Hinostroza";
				PlayerDatabase.P1C3 = "Casey Mittelstadt";
				PlayerDatabase.P1C4 = "Cody Eakin";
				PlayerDatabase.P1RW1 = "Kyle Okposo";
				PlayerDatabase.P1RW2 = "Arttu Ruotsalainen";
				PlayerDatabase.P1RW3 = "Tage Thompson";
				PlayerDatabase.P1RW4 = "Rasmus Asplund";
				PlayerDatabase.P1LD1 = "Will Butcher";
				PlayerDatabase.P1LD2 = "Colin Miller";
				PlayerDatabase.P1LD3 = "Robert Hagg";
				PlayerDatabase.P1RD1 = "Rasmus Dahlin";
				PlayerDatabase.P1RD2 = "Christian Wolanin";
				PlayerDatabase.P1RD3 = "Jacob Bryson";
				PlayerDatabase.P1G = "Craig Anderson";
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				PlayerDatabase.P1LW1 = "Johnny Gaudreau";
				PlayerDatabase.P1LW2 = "Matthew Tkachuk";
				PlayerDatabase.P1LW3 = "Blake Coleman";
				PlayerDatabase.P1LW4 = "Milan Lucic";
				PlayerDatabase.P1C1 = "Elias Lindholm";
				PlayerDatabase.P1C2 = "Sean Monahan";
				PlayerDatabase.P1C3 = "Mikael Backlund";
				PlayerDatabase.P1C4 = "Dillon Dube";
				PlayerDatabase.P1RW1 = "Andrew Mangiapane";
				PlayerDatabase.P1RW2 = "Brad Richardson";
				PlayerDatabase.P1RW3 = "Tyler Pitlick";
				PlayerDatabase.P1RW4 = "Trevor Lewis";
				PlayerDatabase.P1LD1 = "Rasmus Andersson";
				PlayerDatabase.P1LD2 = "Christopher Tanev";
				PlayerDatabase.P1LD3 = "Oliver Kylington";
				PlayerDatabase.P1RD1 = "Noah Hanifin";
				PlayerDatabase.P1RD2 = "Michael Stone";
				PlayerDatabase.P1RD3 = "Nikita Zadorov";
				PlayerDatabase.P1G = "Jacob Markstrom";
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				PlayerDatabase.P1LW1 = "Andrei Svechnikov";
				PlayerDatabase.P1LW2 = "Jesperi Kotkaniemi";
				PlayerDatabase.P1LW3 = "Josh Leivo";
				PlayerDatabase.P1LW4 = "Jordan Martinook";
				PlayerDatabase.P1C1 = "Sebastian Aho";
				PlayerDatabase.P1C2 = "Vincent Trocheck";
				PlayerDatabase.P1C3 = "Jordan Staal";
				PlayerDatabase.P1C4 = "Derek Stepan";
				PlayerDatabase.P1RW1 = "Teuvo Teravainen";
				PlayerDatabase.P1RW2 = "Martin Necas";
				PlayerDatabase.P1RW3 = "Nino Niederreiter";
				PlayerDatabase.P1RW4 = "Stefan Noesen";
				PlayerDatabase.P1LD1 = "Jaccob Slavin";
				PlayerDatabase.P1LD2 = "Brett Pesce";
				PlayerDatabase.P1LD3 = "Brady Skjei";
				PlayerDatabase.P1RD1 = "Tony DeAngelo";
				PlayerDatabase.P1RD2 = "Jake Gardiner";
				PlayerDatabase.P1RD3 = "Ian Cole";
				PlayerDatabase.P1G = "Frederik Andersen";
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				PlayerDatabase.P1LW1 = "Alex DeBrincat";
				PlayerDatabase.P1LW2 = "Dominik Kubalik";
				PlayerDatabase.P1LW3 = "Brandon Hagel";
				PlayerDatabase.P1LW4 = "Alexander Nylander";
				PlayerDatabase.P1C1 = "Jonathan Toews";
				PlayerDatabase.P1C2 = "Dylan Strome";
				PlayerDatabase.P1C3 = "Tyler Johnson";
				PlayerDatabase.P1C4 = "Kirby Dach";
				PlayerDatabase.P1RW1 = "Patrick Kane";
				PlayerDatabase.P1RW2 = "Brett Connolly";
				PlayerDatabase.P1RW3 = "MacKenzie Entwistle";
				PlayerDatabase.P1RW4 = "Ryan Carpenter";
				PlayerDatabase.P1LD1 = "Seth Jones";
				PlayerDatabase.P1LD2 = "Jake McCabe";
				PlayerDatabase.P1LD3 = "Caleb Jones";
				PlayerDatabase.P1RD1 = "Erik Gustafsson";
				PlayerDatabase.P1RD2 = "Nicolas Beaudin";
				PlayerDatabase.P1RD3 = "Connor Murphy";
				PlayerDatabase.P1G = "MarcAndre Fleury";
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				PlayerDatabase.P1LW1 = "Gabriel Landeskog";
				PlayerDatabase.P1LW2 = "Andre Burakovsky";
				PlayerDatabase.P1LW3 = "JT Compher";
				PlayerDatabase.P1LW4 = "Vladislav Kamenev";
				PlayerDatabase.P1C1 = "Nathan MacKinnon";
				PlayerDatabase.P1C2 = "Nazem Kadri";
				PlayerDatabase.P1C3 = "Tyson Jost";
				PlayerDatabase.P1C4 = "Darren Helm";
				PlayerDatabase.P1RW1 = "Mikko Rantanen";
				PlayerDatabase.P1RW2 = "Valeri Nichushkin";
				PlayerDatabase.P1RW3 = "Dylan Sikura";
				PlayerDatabase.P1RW4 = "Logan OConnor";
				PlayerDatabase.P1LD1 = "Samuel Girard";
				PlayerDatabase.P1LD2 = "Ryan Murray";
				PlayerDatabase.P1LD3 = "Erik Johnson";
				PlayerDatabase.P1RD1 = "Cale Makar";
				PlayerDatabase.P1RD2 = "Devon Toews";
				PlayerDatabase.P1RD3 = "Jack Johnson";
				PlayerDatabase.P1G = "Darcy Kuemper";
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				PlayerDatabase.P1LW1 = "Patrik Laine";
				PlayerDatabase.P1LW2 = "Nathan Gerbe";
				PlayerDatabase.P1LW3 = "Alexandre Texier";
				PlayerDatabase.P1LW4 = "Eric Robinson";
				PlayerDatabase.P1C1 = "Max Domi";
				PlayerDatabase.P1C2 = "Gustav Nyquist";
				PlayerDatabase.P1C3 = "Boone Jenner";
				PlayerDatabase.P1C4 = "Emil Bemstrom";
				PlayerDatabase.P1RW1 = "Jakub Voracek";
				PlayerDatabase.P1RW2 = "Oliver Bjorkstrand";
				PlayerDatabase.P1RW3 = "Jack Roslovic";
				PlayerDatabase.P1RW4 = "Liam Foudy";
				PlayerDatabase.P1LD1 = "Adam Boqvist";
				PlayerDatabase.P1LD2 = "Vladislav Gavrikov";
				PlayerDatabase.P1LD3 = "Gavin Bayreuther";
				PlayerDatabase.P1RD1 = "Zach Werenski";
				PlayerDatabase.P1RD2 = "Jake Bean";
				PlayerDatabase.P1RD3 = "Gabriel Carlsson";
				PlayerDatabase.P1G = "Joonas Korpisalo";
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				PlayerDatabase.P1LW1 = "Jamie Benn";
				PlayerDatabase.P1LW2 = "Jason Robertson";
				PlayerDatabase.P1LW3 = "Joel Kiviranta";
				PlayerDatabase.P1LW4 = "Blake Comeau";
				PlayerDatabase.P1C1 = "Tyler Seguin";
				PlayerDatabase.P1C2 = "Roope Hintz";
				PlayerDatabase.P1C3 = "Radek Faksa";
				PlayerDatabase.P1C4 = "Luke Glendening";
				PlayerDatabase.P1RW1 = "Alexander Radulov";
				PlayerDatabase.P1RW2 = "Joe Pavelski";
				PlayerDatabase.P1RW3 = "Denis Gurianov";
				PlayerDatabase.P1RW4 = "Michael Raffl";
				PlayerDatabase.P1LD1 = "John Klingberg";
				PlayerDatabase.P1LD2 = "Esa Lindell";
				PlayerDatabase.P1LD3 = "Jani Hakanpaa";
				PlayerDatabase.P1RD1 = "Ryan Suter";
				PlayerDatabase.P1RD2 = "Miro Heiskanen";
				PlayerDatabase.P1RD3 = "Joel Hanley";
				PlayerDatabase.P1G = "Ben Bishop";
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				PlayerDatabase.P1LW1 = "Tyler Bertuzzi";
				PlayerDatabase.P1LW2 = "Robby Fabbri";
				PlayerDatabase.P1LW3 = "Adam Erne";
				PlayerDatabase.P1LW4 = "Givani Smith";
				PlayerDatabase.P1C1 = "Dylan Larkin";
				PlayerDatabase.P1C2 = "Pius Suter";
				PlayerDatabase.P1C3 = "Vladislav Namestnikov";
				PlayerDatabase.P1C4 = "Michael Rasmussen";
				PlayerDatabase.P1RW1 = "Jakub Vrana";
				PlayerDatabase.P1RW2 = "Filip Zadina";
				PlayerDatabase.P1RW3 = "Sam Gagner";
				PlayerDatabase.P1RW4 = "Lucas Raymond";
				PlayerDatabase.P1LD1 = "Filip Hronek";
				PlayerDatabase.P1LD2 = "Nick Leddy";
				PlayerDatabase.P1LD3 = "Danny DeKeyser";
				PlayerDatabase.P1RD1 = "Troy Stecher";
				PlayerDatabase.P1RD2 = "Jordan Oesterle";
				PlayerDatabase.P1RD3 = "Marc Staal";
				PlayerDatabase.P1G = "Thomas Greiss";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				PlayerDatabase.P1LW1 = "Leon Draisaitl";
				PlayerDatabase.P1LW2 = "Warren Foegele";
				PlayerDatabase.P1LW3 = "Brendan Perlini";
				PlayerDatabase.P1LW4 = "Tyler Benson";
				PlayerDatabase.P1C1 = "Connor McDavid";
				PlayerDatabase.P1C2 = "Ryan NugentHopkins";
				PlayerDatabase.P1C3 = "Derek Ryan";
				PlayerDatabase.P1C4 = "Devin Shore";
				PlayerDatabase.P1RW1 = "Zach Hyman";
				PlayerDatabase.P1RW2 = "Kailer Yamamoto";
				PlayerDatabase.P1RW3 = "Kyle Turris";
				PlayerDatabase.P1RW4 = "Zack Kassian";
				PlayerDatabase.P1LD1 = "Darnell Nurse";
				PlayerDatabase.P1LD2 = "Oscar Klefbom";
				PlayerDatabase.P1LD3 = "Evan Bouchard";
				PlayerDatabase.P1RD1 = "Tyson Barrie";
				PlayerDatabase.P1RD2 = "Duncan Keith";
				PlayerDatabase.P1RD3 = "Cody Ceci";
				PlayerDatabase.P1G = "Mike Smith";
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				PlayerDatabase.P1LW1 = "Jonathan Huberdeau";
				PlayerDatabase.P1LW2 = "Anthony Duclair";
				PlayerDatabase.P1LW3 = "Frank Vatrano";
				PlayerDatabase.P1LW4 = "Mason Marchment";
				PlayerDatabase.P1C1 = "Aleksander Barkov";
				PlayerDatabase.P1C2 = "Joe Thornton";
				PlayerDatabase.P1C3 = "Carter Verhaeghe";
				PlayerDatabase.P1C4 = "Sam Bennett";
				PlayerDatabase.P1RW1 = "Sam Reinhart";
				PlayerDatabase.P1RW2 = "Patric Hornqvist";
				PlayerDatabase.P1RW3 = "Owen Tippett";
				PlayerDatabase.P1RW4 = "Zac Dalpe";
				PlayerDatabase.P1LD1 = "Aaron Ekblad";
				PlayerDatabase.P1LD2 = "Brandon Montour";
				PlayerDatabase.P1LD3 = "Gustav Forsling";
				PlayerDatabase.P1RD1 = "MacKenzie Weegar";
				PlayerDatabase.P1RD2 = "Markus Nutivaara";
				PlayerDatabase.P1RD3 = "Radko Gudas";
				PlayerDatabase.P1G = "Sergei Bobrovsky";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				PlayerDatabase.P1LW1 = "Viktor Arvidsson";
				PlayerDatabase.P1LW2 = "Alex Iafallo";
				PlayerDatabase.P1LW3 = "Trevor Moore";
				PlayerDatabase.P1LW4 = "Carl Grundstrom";
				PlayerDatabase.P1C1 = "Anze Kopitar";
				PlayerDatabase.P1C2 = "Phillip Danault";
				PlayerDatabase.P1C3 = "Gabriel Vilardi";
				PlayerDatabase.P1C4 = "Blake Lizotte";
				PlayerDatabase.P1RW1 = "Dustin Brown";
				PlayerDatabase.P1RW2 = "Andreas Athanasiou";
				PlayerDatabase.P1RW3 = "Adrian Kempe";
				PlayerDatabase.P1RW4 = "Martin Frk";
				PlayerDatabase.P1LD1 = "Drew Doughty";
				PlayerDatabase.P1LD2 = "Kale Clague";
				PlayerDatabase.P1LD3 = "Tobias Bjornfot";
				PlayerDatabase.P1RD1 = "Alexander Edler";
				PlayerDatabase.P1RD2 = "Sean Walker";
				PlayerDatabase.P1RD3 = "Matt Roy";
				PlayerDatabase.P1G = "Jonathan Quick";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "MIN") {
				PlayerDatabase.P1LW1 = "Kirill Kaprizov";
				PlayerDatabase.P1LW2 = "Kevin Fiala";
				PlayerDatabase.P1LW3 = "Marcus Foligno";
				PlayerDatabase.P1LW4 = "Joseph Cramarossa";
				PlayerDatabase.P1C1 = "Joel ErikssonEk";
				PlayerDatabase.P1C2 = "Nick Bjugstad";
				PlayerDatabase.P1C3 = "Nico Sturm";
				PlayerDatabase.P1C4 = "Victor Rask";
				PlayerDatabase.P1RW1 = "Mats Zuccarello";
				PlayerDatabase.P1RW2 = "Jordan Greenway";
				PlayerDatabase.P1RW3 = "Ryan Hartman";
				PlayerDatabase.P1RW4 = "Frederick Gaudreau";
				PlayerDatabase.P1LD1 = "Jared Spurgeon";
				PlayerDatabase.P1LD2 = "Alex Goligoski";
				PlayerDatabase.P1LD3 = "Jordie Benn";
				PlayerDatabase.P1RD1 = "Matt Dumba";
				PlayerDatabase.P1RD2 = "Jonas Brodin";
				PlayerDatabase.P1RD3 = "Dakota Mermis";
				PlayerDatabase.P1G = "Cam Talbot";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "MON") {
				PlayerDatabase.P1LW1 = "Mike Hoffman";
				PlayerDatabase.P1LW2 = "Jonathan Drouin";
				PlayerDatabase.P1LW3 = "Josh Anderson";
				PlayerDatabase.P1LW4 = "Artturi Lehkonen";
				PlayerDatabase.P1C1 = "Nick Suzuki";
				PlayerDatabase.P1C2 = "Christian Dvorak";
				PlayerDatabase.P1C3 = "Adam Brooks";
				PlayerDatabase.P1C4 = "Paul Byron";
				PlayerDatabase.P1RW1 = "Brendan Gallagher";
				PlayerDatabase.P1RW2 = "Tyler Toffoli";
				PlayerDatabase.P1RW3 = "Cole Caufield";
				PlayerDatabase.P1RW4 = "Joel Armia";
				PlayerDatabase.P1LD1 = "Shea Weber";
				PlayerDatabase.P1LD2 = "Chris Wideman";
				PlayerDatabase.P1LD3 = "Brett Kulak";
				PlayerDatabase.P1RD1 = "Jeff Petry";
				PlayerDatabase.P1RD2 = "Ben Chiarot";
				PlayerDatabase.P1RD3 = "Joel Edmundson";
				PlayerDatabase.P1G = "Carey Price";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				PlayerDatabase.P1LW1 = "Filip Forsberg";
				PlayerDatabase.P1LW2 = "Eeli Tolvanen";
				PlayerDatabase.P1LW3 = "Tanner Jeannot";
				PlayerDatabase.P1LW4 = "Yakov Trenin";
				PlayerDatabase.P1C1 = "Matt Duchene";
				PlayerDatabase.P1C2 = "Ryan Johansen";
				PlayerDatabase.P1C3 = "Nick Cousins";
				PlayerDatabase.P1C4 = "Cody Glass";
				PlayerDatabase.P1RW1 = "Mikael Granlund";
				PlayerDatabase.P1RW2 = "Luke Kunin";
				PlayerDatabase.P1RW3 = "Rocco Grimaldi";
				PlayerDatabase.P1RW4 = "Colton Sissons";
				PlayerDatabase.P1LD1 = "Roman Josi";
				PlayerDatabase.P1LD2 = "Mattias Ekholm";
				PlayerDatabase.P1LD3 = "Matt Benning";
				PlayerDatabase.P1RD1 = "Philippe Myers";
				PlayerDatabase.P1RD2 = "Dante Fabbro";
				PlayerDatabase.P1RD3 = "Mark Borowiecki";
				PlayerDatabase.P1G = "Juuse Saros";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				PlayerDatabase.P1LW1 = "Tomas Tatar";
				PlayerDatabase.P1LW2 = "Pavel Zacha";
				PlayerDatabase.P1LW3 = "Janne Kuokkanen";
				PlayerDatabase.P1LW4 = "Miles Wood";
				PlayerDatabase.P1C1 = "Nico Hischier";
				PlayerDatabase.P1C2 = "Yegor Sharangovich";
				PlayerDatabase.P1C3 = "Jack Hughes";
				PlayerDatabase.P1C4 = "Michael McLeod";
				PlayerDatabase.P1RW1 = "Jesper Bratt";
				PlayerDatabase.P1RW2 = "Jimmy Vesey";
				PlayerDatabase.P1RW3 = "Marian Studenic";
				PlayerDatabase.P1RW4 = "Dawson Mercer";
				PlayerDatabase.P1LD1 = "Ty Smith";
				PlayerDatabase.P1LD2 = "PK Subban";
				PlayerDatabase.P1LD3 = "Christian Jaros";
				PlayerDatabase.P1RD1 = "Dougie Hamilton";
				PlayerDatabase.P1RD2 = "Damon Severson";
				PlayerDatabase.P1RD3 = "Ryan Graves";
				PlayerDatabase.P1G = "Jonathan Bernier";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				PlayerDatabase.P1LW1 = "Zach Parise";
				PlayerDatabase.P1LW2 = "Anders Lee";
				PlayerDatabase.P1LW3 = "Anthony Beauvillier";
				PlayerDatabase.P1LW4 = "Richard Panik";
				PlayerDatabase.P1C1 = "Mathew Barzal";
				PlayerDatabase.P1C2 = "Brock Nelson";
				PlayerDatabase.P1C3 = "JeanGabriel Pageau";
				PlayerDatabase.P1C4 = "Casey Cizikas";
				PlayerDatabase.P1RW1 = "Josh Bailey";
				PlayerDatabase.P1RW2 = "Kyle Palmieri";
				PlayerDatabase.P1RW3 = "Oliver Wahlstrom";
				PlayerDatabase.P1RW4 = "Austin Czarnik";
				PlayerDatabase.P1LD1 = "Ryan Pulock";
				PlayerDatabase.P1LD2 = "Scott Mayfield";
				PlayerDatabase.P1LD3 = "Zdeno Chara";
				PlayerDatabase.P1RD1 = "Noah Dobson";
				PlayerDatabase.P1RD2 = "Adam Pelech";
				PlayerDatabase.P1RD3 = "Andy Greene";
				PlayerDatabase.P1G = "Semyon Varlamov";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				PlayerDatabase.P1LW1 = "Artemi Panarin";
				PlayerDatabase.P1LW2 = "Chris Kreider";
				PlayerDatabase.P1LW3 = "Alexis Lafreniere";
				PlayerDatabase.P1LW4 = "Dryden Hunt";
				PlayerDatabase.P1C1 = "Mika Zibanejad";
				PlayerDatabase.P1C2 = "Filip Chytil";
				PlayerDatabase.P1C3 = "Barclay Goodrow";
				PlayerDatabase.P1C4 = "Kevin Rooney";
				PlayerDatabase.P1RW1 = "Ryan Strome";
				PlayerDatabase.P1RW2 = "Kaapo Kakko";
				PlayerDatabase.P1RW3 = "Sammy Blais";
				PlayerDatabase.P1RW4 = "Ryan Reaves";
				PlayerDatabase.P1LD1 = "Ryan Lindgren";
				PlayerDatabase.P1LD2 = "Patrik Nemeth";
				PlayerDatabase.P1LD3 = "Anthony Bitetto";
				PlayerDatabase.P1RD1 = "Adam Fox";
				PlayerDatabase.P1RD2 = "Jacob Trouba";
				PlayerDatabase.P1RD3 = "KAndre Miller";
				PlayerDatabase.P1G = "Igor Shesterkin";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				PlayerDatabase.P1LW1 = "Brady Tkachuk";
				PlayerDatabase.P1LW2 = "Pontus Aberg";
				PlayerDatabase.P1LW3 = "Zach Sanford";
				PlayerDatabase.P1LW4 = "Austin Watson";
				PlayerDatabase.P1C1 = "Josh Norris";
				PlayerDatabase.P1C2 = "Tim Stutzle";
				PlayerDatabase.P1C3 = "Chris Tierney";
				PlayerDatabase.P1C4 = "Colin White";
				PlayerDatabase.P1RW1 = "Drake Batherson";
				PlayerDatabase.P1RW2 = "Connor Brown";
				PlayerDatabase.P1RW3 = "Tyler Ennis";
				PlayerDatabase.P1RW4 = "Logan Shaw";
				PlayerDatabase.P1LD1 = "Thomas Chabot";
				PlayerDatabase.P1LD2 = "Artyom Zub";
				PlayerDatabase.P1LD3 = "Erik Brannstrom";
				PlayerDatabase.P1RD1 = "Michael DelZotto";
				PlayerDatabase.P1RD2 = "Nikita Zaitsev";
				PlayerDatabase.P1RD3 = "Victor Mete";
				PlayerDatabase.P1G = "Matt Murray";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				PlayerDatabase.P1LW1 = "Travis Konecny";
				PlayerDatabase.P1LW2 = "James VanRiemsdyk";
				PlayerDatabase.P1LW3 = "Joel Farabee";
				PlayerDatabase.P1LW4 = "Nate Thompson";
				PlayerDatabase.P1C1 = "Sean Couturier";
				PlayerDatabase.P1C2 = "Kevin Hayes";
				PlayerDatabase.P1C3 = "Scott Laughton";
				PlayerDatabase.P1C4 = "Derick Brassard";
				PlayerDatabase.P1RW1 = "Claude Giroux";
				PlayerDatabase.P1RW2 = "Cam Atkinson";
				PlayerDatabase.P1RW3 = "Oskar Lindblom";
				PlayerDatabase.P1RW4 = "Nicolas AubeKubel";
				PlayerDatabase.P1LD1 = "Keith Yandle";
				PlayerDatabase.P1LD2 = "Rasmus Ristolainen";
				PlayerDatabase.P1LD3 = "Samuel Morin";
				PlayerDatabase.P1RD1 = "Ryan Ellis";
				PlayerDatabase.P1RD2 = "Ivan Provorov";
				PlayerDatabase.P1RD3 = "Travis Sanheim";
				PlayerDatabase.P1G = "Carter Hart";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				PlayerDatabase.P1LW1 = "Bryan Rust";
				PlayerDatabase.P1LW2 = "Jason Zucker";
				PlayerDatabase.P1LW3 = "Teddy Blueger";
				PlayerDatabase.P1LW4 = "Brian Boyle";
				PlayerDatabase.P1C1 = "Sidney Crosby";
				PlayerDatabase.P1C2 = "Evgeni Malkin";
				PlayerDatabase.P1C3 = "Jeff Carter";
				PlayerDatabase.P1C4 = "Dominik Simon";
				PlayerDatabase.P1RW1 = "Jake Guentzel";
				PlayerDatabase.P1RW2 = "Kasperi Kapanen";
				PlayerDatabase.P1RW3 = "Danton Heinen";
				PlayerDatabase.P1RW4 = "Evan Rodrigues";
				PlayerDatabase.P1LD1 = "Mike Matheson";
				PlayerDatabase.P1LD2 = "Brian Dumoulin";
				PlayerDatabase.P1LD3 = "Marcus Pettersson";
				PlayerDatabase.P1RD1 = "Kris Letang";
				PlayerDatabase.P1RD2 = "John Marino";
				PlayerDatabase.P1RD3 = "Taylor Fedun";
				PlayerDatabase.P1G = "Tristan Jarry";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "STL") {
				PlayerDatabase.P1LW1 = "David Perron";
				PlayerDatabase.P1LW2 = "Brandon Saad";
				PlayerDatabase.P1LW3 = "Ivan Barbashev";
				PlayerDatabase.P1LW4 = "Nathan Walker";
				PlayerDatabase.P1C1 = "Ryan OReilly";
				PlayerDatabase.P1C2 = "Brayden Schenn";
				PlayerDatabase.P1C3 = "Robert Thomas";
				PlayerDatabase.P1C4 = "Tyler Bozak";
				PlayerDatabase.P1RW1 = "Vladimir Tarasenko";
				PlayerDatabase.P1RW2 = "Pavel Buchnevich";
				PlayerDatabase.P1RW3 = "Jordan Kyrou";
				PlayerDatabase.P1RW4 = "James Neal";
				PlayerDatabase.P1LD1 = "Torey Krug";
				PlayerDatabase.P1LD2 = "Justin Faulk";
				PlayerDatabase.P1LD3 = "Calle Rosen";
				PlayerDatabase.P1RD1 = "Colton Parayko";
				PlayerDatabase.P1RD2 = "Marco Scandella";
				PlayerDatabase.P1RD3 = "Robert Bortuzzo";
				PlayerDatabase.P1G = "Jordan Binnington";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				PlayerDatabase.P1LW1 = "Evander Kane";
				PlayerDatabase.P1LW2 = "Kevin Labanc";
				PlayerDatabase.P1LW3 = "Rudolfs Balcers";
				PlayerDatabase.P1LW4 = "John Leonard";
				PlayerDatabase.P1C1 = "Tomas Hertl";
				PlayerDatabase.P1C2 = "Logan Couture";
				PlayerDatabase.P1C3 = "Nick Bonino";
				PlayerDatabase.P1C4 = "Joel Kellman";
				PlayerDatabase.P1RW1 = "Timo Meier";
				PlayerDatabase.P1RW2 = "Nick Merkley";
				PlayerDatabase.P1RW3 = "Alexander Barabanov";
				PlayerDatabase.P1RW4 = "Matt Nieto";
				PlayerDatabase.P1LD1 = "Brent Burns";
				PlayerDatabase.P1LD2 = "Mario Ferraro";
				PlayerDatabase.P1LD3 = "Radim Simek";
				PlayerDatabase.P1RD1 = "Erik Karlsson";
				PlayerDatabase.P1RD2 = "MarcEdouard Vlasic";
				PlayerDatabase.P1RD3 = "Jacob Middleton";
				PlayerDatabase.P1G = "James Reimer";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "SEA") {
				PlayerDatabase.P1LW1 = "Jaden Schwartz";
				PlayerDatabase.P1LW2 = "Marcus Johansson";
				PlayerDatabase.P1LW3 = "Ryan Donato";
				PlayerDatabase.P1LW4 = "Colin Blackwell";
				PlayerDatabase.P1C1 = "Yanni Gourde";
				PlayerDatabase.P1C2 = "Jared McCann";
				PlayerDatabase.P1C3 = "Calle Jarnkrok";
				PlayerDatabase.P1C4 = "Alexander Wennberg";
				PlayerDatabase.P1RW1 = "Jordan Eberle";
				PlayerDatabase.P1RW2 = "Joonas Donskoi";
				PlayerDatabase.P1RW3 = "Brandon Tanev";
				PlayerDatabase.P1RW4 = "Morgan Geekie";
				PlayerDatabase.P1LD1 = "Mark Giordano";
				PlayerDatabase.P1LD2 = "Vince Dunn";
				PlayerDatabase.P1LD3 = "Jamie Oleksiak";
				PlayerDatabase.P1RD1 = "Carson Soucy";
				PlayerDatabase.P1RD2 = "Connor Carrick";
				PlayerDatabase.P1RD3 = "Adam Larsson";
				PlayerDatabase.P1G = "Philipp Grubauer";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				PlayerDatabase.P1LW1 = "Ondrej Palat";
				PlayerDatabase.P1LW2 = "Alex Killorn";
				PlayerDatabase.P1LW3 = "Pat Maroon";
				PlayerDatabase.P1LW4 = "Gemel Smith";
				PlayerDatabase.P1C1 = "Steven Stamkos";
				PlayerDatabase.P1C2 = "Brayden Point";
				PlayerDatabase.P1C3 = "Anthony Cirelli";
				PlayerDatabase.P1C4 = "Ross Colton";
				PlayerDatabase.P1RW1 = "Nikita Kucherov";
				PlayerDatabase.P1RW2 = "Corey Perry";
				PlayerDatabase.P1RW3 = "Mathieu Joseph";
				PlayerDatabase.P1RW4 = "Charles Hudon";
				PlayerDatabase.P1LD1 = "Victor Hedman";
				PlayerDatabase.P1LD2 = "Mikhail Sergachev";
				PlayerDatabase.P1LD3 = "Ryan McDonagh";
				PlayerDatabase.P1RD1 = "Brent Seabrook";
				PlayerDatabase.P1RD2 = "Erik Cernak";
				PlayerDatabase.P1RD3 = "Jan Rutta";
				PlayerDatabase.P1G = "Andrei Vasilevskiy";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				PlayerDatabase.P1LW1 = "Nick Ritchie";
				PlayerDatabase.P1LW2 = "Alexander Kerfoot";
				PlayerDatabase.P1LW3 = "Ilya Mikheyev";
				PlayerDatabase.P1LW4 = "Denis Malgin";
				PlayerDatabase.P1C1 = "Auston Matthews";
				PlayerDatabase.P1C2 = "John Tavares";
				PlayerDatabase.P1C3 = "Jason Spezza";
				PlayerDatabase.P1C4 = "David Kampf";
				PlayerDatabase.P1RW1 = "Mitchell Marner";
				PlayerDatabase.P1RW2 = "William Nylander";
				PlayerDatabase.P1RW3 = "Michael Bunting";
				PlayerDatabase.P1RW4 = "Ondrej Kase";
				PlayerDatabase.P1LD1 = "Morgan Rielly";
				PlayerDatabase.P1LD2 = "TJ Brodie";
				PlayerDatabase.P1LD3 = "Justin Holl";
				PlayerDatabase.P1RD1 = "Jake Muzzin";
				PlayerDatabase.P1RD2 = "Rasmus Sandin";
				PlayerDatabase.P1RD3 = "Alex Biega";
				PlayerDatabase.P1G = "Petr Mrazek";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				PlayerDatabase.P1LW1 = "Conor Garland";
				PlayerDatabase.P1LW2 = "Michael Ferland";
				PlayerDatabase.P1LW3 = "Tanner Pearson";
				PlayerDatabase.P1LW4 = "Phil DiGiuseppe";
				PlayerDatabase.P1C1 = "Elias Pettersson";
				PlayerDatabase.P1C2 = "Bo Horvat";
				PlayerDatabase.P1C3 = "Jason Dickinson";
				PlayerDatabase.P1C4 = "Brandon Sutter";
				PlayerDatabase.P1RW1 = "JT Miller";
				PlayerDatabase.P1RW2 = "Brock Boeser";
				PlayerDatabase.P1RW3 = "Nils Hoglander";
				PlayerDatabase.P1RW4 = "Alex Chiasson";
				PlayerDatabase.P1LD1 = "Oliver EkmanLarsson";
				PlayerDatabase.P1LD2 = "Brad Hunt";
				PlayerDatabase.P1LD3 = "Madison Bowey";
				PlayerDatabase.P1RD1 = "Quinn Hughes";
				PlayerDatabase.P1RD2 = "Tyler Myers";
				PlayerDatabase.P1RD3 = "Noah Juulsen";
				PlayerDatabase.P1G = "Thatcher Demko";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "VGK") {
				PlayerDatabase.P1LW1 = "Max Pacioretty";
				PlayerDatabase.P1LW2 = "Jonathan Marchessault";
				PlayerDatabase.P1LW3 = "Peyton Krebs";
				PlayerDatabase.P1LW4 = "William Carrier";
				PlayerDatabase.P1C1 = "William Karlsson";
				PlayerDatabase.P1C2 = "Chandler Stephenson";
				PlayerDatabase.P1C3 = "Mattias Janmark";
				PlayerDatabase.P1C4 = "Nolan Patrick";
				PlayerDatabase.P1RW1 = "Mark Stone";
				PlayerDatabase.P1RW2 = "Reilly Smith";
				PlayerDatabase.P1RW3 = "Evgeny Dadonov";
				PlayerDatabase.P1RW4 = "Alex Tuch";
				PlayerDatabase.P1LD1 = "Alex Pietrangelo";
				PlayerDatabase.P1LD2 = "Nicolas Hague";
				PlayerDatabase.P1LD3 = "Dylan Coghlan";
				PlayerDatabase.P1RD1 = "Shea Theodore";
				PlayerDatabase.P1RD2 = "Alec Martinez";
				PlayerDatabase.P1RD3 = "Zach Whitecloud";
				PlayerDatabase.P1G = "Robin Lehner";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				PlayerDatabase.P1LW1 = "Alexander Ovechkin";
				PlayerDatabase.P1LW2 = "Anthony Mantha";
				PlayerDatabase.P1LW3 = "Conor Sheary";
				PlayerDatabase.P1LW4 = "Carl Hagelin";
				PlayerDatabase.P1C1 = "Nicklas Backstrom";
				PlayerDatabase.P1C2 = "Evgeny Kuznetsov";
				PlayerDatabase.P1C3 = "Lars Eller";
				PlayerDatabase.P1C4 = "Nic Dowd";
				PlayerDatabase.P1RW1 = "Tom Wilson";
				PlayerDatabase.P1RW2 = "TJ Oshie";
				PlayerDatabase.P1RW3 = "Daniel Sprong";
				PlayerDatabase.P1RW4 = "Garnet Hathaway";
				PlayerDatabase.P1LD1 = "Justin Schultz";
				PlayerDatabase.P1LD2 = "Dmitry Orlov";
				PlayerDatabase.P1LD3 = "Nick Jensen";
				PlayerDatabase.P1RD1 = "John Carlson";
				PlayerDatabase.P1RD2 = "Michal Kempny";
				PlayerDatabase.P1RD3 = "Dennis Cholowski";
				PlayerDatabase.P1G = "Ilya Samsonov";
			}

			else  if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				PlayerDatabase.P1LW1 = "Kyle Connor";
				PlayerDatabase.P1LW2 = "Nikolaj Ehlers";
				PlayerDatabase.P1LW3 = "Andrew Copp";
				PlayerDatabase.P1LW4 = "Cole Perfetti";
				PlayerDatabase.P1C1 = "Mark Scheifele";
				PlayerDatabase.P1C2 = "PierreLuc Dubois";
				PlayerDatabase.P1C3 = "Paul Stastny";
				PlayerDatabase.P1C4 = "Bryan Little";
				PlayerDatabase.P1RW1 = "Blake Wheeler";
				PlayerDatabase.P1RW2 = "Evgeny Svechnikov";
				PlayerDatabase.P1RW3 = "Riley Nash";
				PlayerDatabase.P1RW4 = "Kristian Vesalainen";
				PlayerDatabase.P1LD1 = "Neal Pionk";
				PlayerDatabase.P1LD2 = "Nate Schmidt";
				PlayerDatabase.P1LD3 = "Nathan Beaulieu";
				PlayerDatabase.P1RD1 = "Josh Morrissey";
				PlayerDatabase.P1RD2 = "Brenden Dillon";
				PlayerDatabase.P1RD3 = "Dylan DeMelo";
				PlayerDatabase.P1G = "Connor Hellebuyck";
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
            }
		}
	}

	public void SetComputerLines() {
		RandomSelectComputerTeam();

		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (PlayerDatabase.ComputerChosenTeam == "ANA") {
				PlayerDatabase.P2LW1 = "Maxime Comtois";
				PlayerDatabase.P2LW2 = "Sonny Milano";
				PlayerDatabase.P2LW3 = "Alexander Volkov";
				PlayerDatabase.P2LW4 = "Max Jones";
				PlayerDatabase.P2C1 = "Ryan Getzlaf";
				PlayerDatabase.P2C2 = "Trevor Zegras";
				PlayerDatabase.P2C3 = "Adam Henrique";
				PlayerDatabase.P2C4 = "Sam Steel";
				PlayerDatabase.P2RW1 = "Rickard Rakell";
				PlayerDatabase.P2RW2 = "Jakob Silfverberg";
				PlayerDatabase.P2RW3 = "Troy Terry";
				PlayerDatabase.P2RW4 = "Derek Grant";
				PlayerDatabase.P2LD1 = "Cam Fowler";
				PlayerDatabase.P2LD2 = "Kevin Shattenkirk";
				PlayerDatabase.P2LD3 = "Jamie Drysdale";
				PlayerDatabase.P2RD1 = "Hampus Lindholm";
				PlayerDatabase.P2RD2 = "Brogan Rafferty";
				PlayerDatabase.P2RD3 = "Josh Mahura";
				PlayerDatabase.P2G = "John Gibson";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "ARI") {
				PlayerDatabase.P2LW1 = "Ryan Dzingel";
				PlayerDatabase.P2LW2 = "Alex Galchenyuk";
				PlayerDatabase.P2LW3 = "Andrew Ladd";
				PlayerDatabase.P2LW4 = "Antoine Roussel";
				PlayerDatabase.P2C1 = "Nick Schmaltz";
				PlayerDatabase.P2C2 = "Travis Boyd";
				PlayerDatabase.P2C3 = "Loui Eriksson";
				PlayerDatabase.P2C4 = "Liam OBrien";
				PlayerDatabase.P2RW1 = "Phil Kessel";
				PlayerDatabase.P2RW2 = "Clayton Keller";
				PlayerDatabase.P2RW3 = "Dmitri Jaskin";
				PlayerDatabase.P2RW4 = "Christian Fischer";
				PlayerDatabase.P2LD1 = "Jakob Chychrun";
				PlayerDatabase.P2LD2 = "Shayne Gostisbehere";
				PlayerDatabase.P2LD3 = "Conor Timmins";
				PlayerDatabase.P2RD1 = "Victor Soderstrom";
				PlayerDatabase.P2RD2 = "Anton Stralman";
				PlayerDatabase.P2RD3 = "Ilya Lyubushkin";
				PlayerDatabase.P2G = "Carter Hutton";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BOS") {
				PlayerDatabase.P2LW1 = "Brad Marchand";
				PlayerDatabase.P2LW2 = "Taylor Hall";
				PlayerDatabase.P2LW3 = "Jake DeBrusk";
				PlayerDatabase.P2LW4 = "Peter Cehlarik";
				PlayerDatabase.P2C1 = "Patrice Bergeron";
				PlayerDatabase.P2C2 = "Erik Haula";
				PlayerDatabase.P2C3 = "Charlie Coyle";
				PlayerDatabase.P2C4 = "Jakob ForsbackaKarlsson";
				PlayerDatabase.P2RW1 = "David Pastrnak";
				PlayerDatabase.P2RW2 = "Craig Smith";
				PlayerDatabase.P2RW3 = "Nick Foligno";
				PlayerDatabase.P2RW4 = "Curtis Lazar";
				PlayerDatabase.P2LD1 = "Mike Reilly";
				PlayerDatabase.P2LD2 = "Tyler Lewington";
				PlayerDatabase.P2LD3 = "Jakub Zboril";
				PlayerDatabase.P2RD1 = "Charlie McAvoy";
				PlayerDatabase.P2RD2 = "Matt Grzelcyk";
				PlayerDatabase.P2RD3 = "Brandon Carlo";
				PlayerDatabase.P2G = "Tuukka Rask";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "BUF") {
				PlayerDatabase.P2LW1 = "Victor Olofsson";
				PlayerDatabase.P2LW2 = "Jeff Skinner";
				PlayerDatabase.P2LW3 = "Drake Caggiula";
				PlayerDatabase.P2LW4 = "Anders Bjork";
				PlayerDatabase.P2C1 = "Jack Eichel";
				PlayerDatabase.P2C2 = "Vinnie Hinostroza";
				PlayerDatabase.P2C3 = "Casey Mittelstadt";
				PlayerDatabase.P2C4 = "Cody Eakin";
				PlayerDatabase.P2RW1 = "Kyle Okposo";
				PlayerDatabase.P2RW2 = "Arttu Ruotsalainen";
				PlayerDatabase.P2RW3 = "Tage Thompson";
				PlayerDatabase.P2RW4 = "Rasmus Asplund";
				PlayerDatabase.P2LD1 = "Will Butcher";
				PlayerDatabase.P2LD2 = "Colin Miller";
				PlayerDatabase.P2LD3 = "Robert Hagg";
				PlayerDatabase.P2RD1 = "Rasmus Dahlin";
				PlayerDatabase.P2RD2 = "Christian Wolanin";
				PlayerDatabase.P2RD3 = "Jacob Bryson";
				PlayerDatabase.P2G = "Craig Anderson";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAL") {
				PlayerDatabase.P2LW1 = "Johnny Gaudreau";
				PlayerDatabase.P2LW2 = "Matthew Tkachuk";
				PlayerDatabase.P2LW3 = "Blake Coleman";
				PlayerDatabase.P2LW4 = "Milan Lucic";
				PlayerDatabase.P2C1 = "Elias Lindholm";
				PlayerDatabase.P2C2 = "Sean Monahan";
				PlayerDatabase.P2C3 = "Mikael Backlund";
				PlayerDatabase.P2C4 = "Dillon Dube";
				PlayerDatabase.P2RW1 = "Andrew Mangiapane";
				PlayerDatabase.P2RW2 = "Brad Richardson";
				PlayerDatabase.P2RW3 = "Tyler Pitlick";
				PlayerDatabase.P2RW4 = "Trevor Lewis";
				PlayerDatabase.P2LD1 = "Rasmus Andersson";
				PlayerDatabase.P2LD2 = "Christopher Tanev";
				PlayerDatabase.P2LD3 = "Oliver Kylington";
				PlayerDatabase.P2RD1 = "Noah Hanifin";
				PlayerDatabase.P2RD2 = "Michael Stone";
				PlayerDatabase.P2RD3 = "Nikita Zadorov";
				PlayerDatabase.P2G = "Jacob Markstrom";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CAR") {
				PlayerDatabase.P2LW1 = "Andrei Svechnikov";
				PlayerDatabase.P2LW2 = "Jesperi Kotkaniemi";
				PlayerDatabase.P2LW3 = "Josh Leivo";
				PlayerDatabase.P2LW4 = "Jordan Martinook";
				PlayerDatabase.P2C1 = "Sebastian Aho";
				PlayerDatabase.P2C2 = "Vincent Trocheck";
				PlayerDatabase.P2C3 = "Jordan Staal";
				PlayerDatabase.P2C4 = "Derek Stepan";
				PlayerDatabase.P2RW1 = "Teuvo Teravainen";
				PlayerDatabase.P2RW2 = "Martin Necas";
				PlayerDatabase.P2RW3 = "Nino Niederreiter";
				PlayerDatabase.P2RW4 = "Stefan Noesen";
				PlayerDatabase.P2LD1 = "Jaccob Slavin";
				PlayerDatabase.P2LD2 = "Brett Pesce";
				PlayerDatabase.P2LD3 = "Brady Skjei";
				PlayerDatabase.P2RD1 = "Tony DeAngelo";
				PlayerDatabase.P2RD2 = "Jake Gardiner";
				PlayerDatabase.P2RD3 = "Ian Cole";
				PlayerDatabase.P2G = "Frederik Andersen";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CHI") {
				PlayerDatabase.P2LW1 = "Alex DeBrincat";
				PlayerDatabase.P2LW2 = "Dominik Kubalik";
				PlayerDatabase.P2LW3 = "Brandon Hagel";
				PlayerDatabase.P2LW4 = "Alexander Nylander";
				PlayerDatabase.P2C1 = "Jonathan Toews";
				PlayerDatabase.P2C2 = "Dylan Strome";
				PlayerDatabase.P2C3 = "Tyler Johnson";
				PlayerDatabase.P2C4 = "Kirby Dach";
				PlayerDatabase.P2RW1 = "Patrick Kane";
				PlayerDatabase.P2RW2 = "Brett Connolly";
				PlayerDatabase.P2RW3 = "MacKenzie Entwistle";
				PlayerDatabase.P2RW4 = "Ryan Carpenter";
				PlayerDatabase.P2LD1 = "Seth Jones";
				PlayerDatabase.P2LD2 = "Jake McCabe";
				PlayerDatabase.P2LD3 = "Caleb Jones";
				PlayerDatabase.P2RD1 = "Erik Gustafsson";
				PlayerDatabase.P2RD2 = "Nicolas Beaudin";
				PlayerDatabase.P2RD3 = "Connor Murphy";
				PlayerDatabase.P2G = "MarcAndre Fleury";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "COL") {
				PlayerDatabase.P2LW1 = "Gabriel Landeskog";
				PlayerDatabase.P2LW2 = "Andre Burakovsky";
				PlayerDatabase.P2LW3 = "JT Compher";
				PlayerDatabase.P2LW4 = "Vladislav Kamenev";
				PlayerDatabase.P2C1 = "Nathan MacKinnon";
				PlayerDatabase.P2C2 = "Nazem Kadri";
				PlayerDatabase.P2C3 = "Tyson Jost";
				PlayerDatabase.P2C4 = "Darren Helm";
				PlayerDatabase.P2RW1 = "Mikko Rantanen";
				PlayerDatabase.P2RW2 = "Valeri Nichushkin";
				PlayerDatabase.P2RW3 = "Dylan Sikura";
				PlayerDatabase.P2RW4 = "Logan OConnor";
				PlayerDatabase.P2LD1 = "Samuel Girard";
				PlayerDatabase.P2LD2 = "Ryan Murray";
				PlayerDatabase.P2LD3 = "Erik Johnson";
				PlayerDatabase.P2RD1 = "Cale Makar";
				PlayerDatabase.P2RD2 = "Devon Toews";
				PlayerDatabase.P2RD3 = "Jack Johnson";
				PlayerDatabase.P2G = "Darcy Kuemper";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "CBJ") {
				PlayerDatabase.P2LW1 = "Patrik Laine";
				PlayerDatabase.P2LW2 = "Nathan Gerbe";
				PlayerDatabase.P2LW3 = "Alexandre Texier";
				PlayerDatabase.P2LW4 = "Eric Robinson";
				PlayerDatabase.P2C1 = "Max Domi";
				PlayerDatabase.P2C2 = "Gustav Nyquist";
				PlayerDatabase.P2C3 = "Boone Jenner";
				PlayerDatabase.P2C4 = "Emil Bemstrom";
				PlayerDatabase.P2RW1 = "Jakub Voracek";
				PlayerDatabase.P2RW2 = "Oliver Bjorkstrand";
				PlayerDatabase.P2RW3 = "Jack Roslovic";
				PlayerDatabase.P2RW4 = "Liam Foudy";
				PlayerDatabase.P2LD1 = "Adam Boqvist";
				PlayerDatabase.P2LD2 = "Vladislav Gavrikov";
				PlayerDatabase.P2LD3 = "Gavin Bayreuther";
				PlayerDatabase.P2RD1 = "Zach Werenski";
				PlayerDatabase.P2RD2 = "Jake Bean";
				PlayerDatabase.P2RD3 = "Gabriel Carlsson";
				PlayerDatabase.P2G = "Joonas Korpisalo";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DAL") {
				PlayerDatabase.P2LW1 = "Jamie Benn";
				PlayerDatabase.P2LW2 = "Jason Robertson";
				PlayerDatabase.P2LW3 = "Joel Kiviranta";
				PlayerDatabase.P2LW4 = "Blake Comeau";
				PlayerDatabase.P2C1 = "Tyler Seguin";
				PlayerDatabase.P2C2 = "Roope Hintz";
				PlayerDatabase.P2C3 = "Radek Faksa";
				PlayerDatabase.P2C4 = "Luke Glendening";
				PlayerDatabase.P2RW1 = "Alexander Radulov";
				PlayerDatabase.P2RW2 = "Joe Pavelski";
				PlayerDatabase.P2RW3 = "Denis Gurianov";
				PlayerDatabase.P2RW4 = "Michael Raffl";
				PlayerDatabase.P2LD1 = "John Klingberg";
				PlayerDatabase.P2LD2 = "Esa Lindell";
				PlayerDatabase.P2LD3 = "Jani Hakanpaa";
				PlayerDatabase.P2RD1 = "Ryan Suter";
				PlayerDatabase.P2RD2 = "Miro Heiskanen";
				PlayerDatabase.P2RD3 = "Joel Hanley";
				PlayerDatabase.P2G = "Ben Bishop";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "DET") {
				PlayerDatabase.P2LW1 = "Tyler Bertuzzi";
				PlayerDatabase.P2LW2 = "Robby Fabbri";
				PlayerDatabase.P2LW3 = "Adam Erne";
				PlayerDatabase.P2LW4 = "Givani Smith";
				PlayerDatabase.P2C1 = "Dylan Larkin";
				PlayerDatabase.P2C2 = "Pius Suter";
				PlayerDatabase.P2C3 = "Vladislav Namestnikov";
				PlayerDatabase.P2C4 = "Michael Rasmussen";
				PlayerDatabase.P2RW1 = "Jakub Vrana";
				PlayerDatabase.P2RW2 = "Filip Zadina";
				PlayerDatabase.P2RW3 = "Sam Gagner";
				PlayerDatabase.P2RW4 = "Lucas Raymond";
				PlayerDatabase.P2LD1 = "Filip Hronek";
				PlayerDatabase.P2LD2 = "Nick Leddy";
				PlayerDatabase.P2LD3 = "Danny DeKeyser";
				PlayerDatabase.P2RD1 = "Troy Stecher";
				PlayerDatabase.P2RD2 = "Jordan Oesterle";
				PlayerDatabase.P2RD3 = "Marc Staal";
				PlayerDatabase.P2G = "Thomas Greiss";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "EDM") {
				PlayerDatabase.P2LW1 = "Leon Draisaitl";
				PlayerDatabase.P2LW2 = "Warren Foegele";
				PlayerDatabase.P2LW3 = "Brendan Perlini";
				PlayerDatabase.P2LW4 = "Tyler Benson";
				PlayerDatabase.P2C1 = "Connor McDavid";
				PlayerDatabase.P2C2 = "Ryan NugentHopkins";
				PlayerDatabase.P2C3 = "Derek Ryan";
				PlayerDatabase.P2C4 = "Devin Shore";
				PlayerDatabase.P2RW1 = "Zach Hyman";
				PlayerDatabase.P2RW2 = "Kailer Yamamoto";
				PlayerDatabase.P2RW3 = "Kyle Turris";
				PlayerDatabase.P2RW4 = "Zack Kassian";
				PlayerDatabase.P2LD1 = "Darnell Nurse";
				PlayerDatabase.P2LD2 = "Oscar Klefbom";
				PlayerDatabase.P2LD3 = "Evan Bouchard";
				PlayerDatabase.P2RD1 = "Tyson Barrie";
				PlayerDatabase.P2RD2 = "Duncan Keith";
				PlayerDatabase.P2RD3 = "Cody Ceci";
				PlayerDatabase.P2G = "Mike Smith";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "FLA") {
				PlayerDatabase.P2LW1 = "Jonathan Huberdeau";
				PlayerDatabase.P2LW2 = "Anthony Duclair";
				PlayerDatabase.P2LW3 = "Frank Vatrano";
				PlayerDatabase.P2LW4 = "Mason Marchment";
				PlayerDatabase.P2C1 = "Aleksander Barkov";
				PlayerDatabase.P2C2 = "Joe Thornton";
				PlayerDatabase.P2C3 = "Carter Verhaeghe";
				PlayerDatabase.P2C4 = "Sam Bennett";
				PlayerDatabase.P2RW1 = "Sam Reinhart";
				PlayerDatabase.P2RW2 = "Patric Hornqvist";
				PlayerDatabase.P2RW3 = "Owen Tippett";
				PlayerDatabase.P2RW4 = "Zac Dalpe";
				PlayerDatabase.P2LD1 = "Aaron Ekblad";
				PlayerDatabase.P2LD2 = "Brandon Montour";
				PlayerDatabase.P2LD3 = "Gustav Forsling";
				PlayerDatabase.P2RD1 = "MacKenzie Weegar";
				PlayerDatabase.P2RD2 = "Markus Nutivaara";
				PlayerDatabase.P2RD3 = "Radko Gudas";
				PlayerDatabase.P2G = "Sergei Bobrovsky";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "LAK") {
				PlayerDatabase.P2LW1 = "Viktor Arvidsson";
				PlayerDatabase.P2LW2 = "Alex Iafallo";
				PlayerDatabase.P2LW3 = "Trevor Moore";
				PlayerDatabase.P2LW4 = "Carl Grundstrom";
				PlayerDatabase.P2C1 = "Anze Kopitar";
				PlayerDatabase.P2C2 = "Phillip Danault";
				PlayerDatabase.P2C3 = "Gabriel Vilardi";
				PlayerDatabase.P2C4 = "Blake Lizotte";
				PlayerDatabase.P2RW1 = "Dustin Brown";
				PlayerDatabase.P2RW2 = "Andreas Athanasiou";
				PlayerDatabase.P2RW3 = "Adrian Kempe";
				PlayerDatabase.P2RW4 = "Martin Frk";
				PlayerDatabase.P2LD1 = "Drew Doughty";
				PlayerDatabase.P2LD2 = "Kale Clague";
				PlayerDatabase.P2LD3 = "Tobias Bjornfot";
				PlayerDatabase.P2RD1 = "Alexander Edler";
				PlayerDatabase.P2RD2 = "Sean Walker";
				PlayerDatabase.P2RD3 = "Matt Roy";
				PlayerDatabase.P2G = "Jonathan Quick";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MIN") {
				PlayerDatabase.P2LW1 = "Kirill Kaprizov";
				PlayerDatabase.P2LW2 = "Kevin Fiala";
				PlayerDatabase.P2LW3 = "Marcus Foligno";
				PlayerDatabase.P2LW4 = "Joseph Cramarossa";
				PlayerDatabase.P2C1 = "Joel ErikssonEk";
				PlayerDatabase.P2C2 = "Nick Bjugstad";
				PlayerDatabase.P2C3 = "Nico Sturm";
				PlayerDatabase.P2C4 = "Victor Rask";
				PlayerDatabase.P2RW1 = "Mats Zuccarello";
				PlayerDatabase.P2RW2 = "Jordan Greenway";
				PlayerDatabase.P2RW3 = "Ryan Hartman";
				PlayerDatabase.P2RW4 = "Frederick Gaudreau";
				PlayerDatabase.P2LD1 = "Jared Spurgeon";
				PlayerDatabase.P2LD2 = "Alex Goligoski";
				PlayerDatabase.P2LD3 = "Jordie Benn";
				PlayerDatabase.P2RD1 = "Matt Dumba";
				PlayerDatabase.P2RD2 = "Jonas Brodin";
				PlayerDatabase.P2RD3 = "Dakota Mermis";
				PlayerDatabase.P2G = "Cam Talbot";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "MON") {
				PlayerDatabase.P2LW1 = "Mike Hoffman";
				PlayerDatabase.P2LW2 = "Jonathan Drouin";
				PlayerDatabase.P2LW3 = "Josh Anderson";
				PlayerDatabase.P2LW4 = "Artturi Lehkonen";
				PlayerDatabase.P2C1 = "Nick Suzuki";
				PlayerDatabase.P2C2 = "Christian Dvorak";
				PlayerDatabase.P2C3 = "Adam Brooks";
				PlayerDatabase.P2C4 = "Paul Byron";
				PlayerDatabase.P2RW1 = "Brendan Gallagher";
				PlayerDatabase.P2RW2 = "Tyler Toffoli";
				PlayerDatabase.P2RW3 = "Cole Caufield";
				PlayerDatabase.P2RW4 = "Joel Armia";
				PlayerDatabase.P2LD1 = "Shea Weber";
				PlayerDatabase.P2LD2 = "Chris Wideman";
				PlayerDatabase.P2LD3 = "Brett Kulak";
				PlayerDatabase.P2RD1 = "Jeff Petry";
				PlayerDatabase.P2RD2 = "Ben Chiarot";
				PlayerDatabase.P2RD3 = "Joel Edmundson";
				PlayerDatabase.P2G = "Carey Price";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NAS") {
				PlayerDatabase.P2LW1 = "Filip Forsberg";
				PlayerDatabase.P2LW2 = "Eeli Tolvanen";
				PlayerDatabase.P2LW3 = "Tanner Jeannot";
				PlayerDatabase.P2LW4 = "Yakov Trenin";
				PlayerDatabase.P2C1 = "Matt Duchene";
				PlayerDatabase.P2C2 = "Ryan Johansen";
				PlayerDatabase.P2C3 = "Nick Cousins";
				PlayerDatabase.P2C4 = "Cody Glass";
				PlayerDatabase.P2RW1 = "Mikael Granlund";
				PlayerDatabase.P2RW2 = "Luke Kunin";
				PlayerDatabase.P2RW3 = "Rocco Grimaldi";
				PlayerDatabase.P2RW4 = "Colton Sissons";
				PlayerDatabase.P2LD1 = "Roman Josi";
				PlayerDatabase.P2LD2 = "Mattias Ekholm";
				PlayerDatabase.P2LD3 = "Matt Benning";
				PlayerDatabase.P2RD1 = "Philippe Myers";
				PlayerDatabase.P2RD2 = "Dante Fabbro";
				PlayerDatabase.P2RD3 = "Mark Borowiecki";
				PlayerDatabase.P2G = "Juuse Saros";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NJD") {
				PlayerDatabase.P2LW1 = "Tomas Tatar";
				PlayerDatabase.P2LW2 = "Pavel Zacha";
				PlayerDatabase.P2LW3 = "Janne Kuokkanen";
				PlayerDatabase.P2LW4 = "Miles Wood";
				PlayerDatabase.P2C1 = "Nico Hischier";
				PlayerDatabase.P2C2 = "Yegor Sharangovich";
				PlayerDatabase.P2C3 = "Jack Hughes";
				PlayerDatabase.P2C4 = "Michael McLeod";
				PlayerDatabase.P2RW1 = "Jesper Bratt";
				PlayerDatabase.P2RW2 = "Jimmy Vesey";
				PlayerDatabase.P2RW3 = "Marian Studenic";
				PlayerDatabase.P2RW4 = "Dawson Mercer";
				PlayerDatabase.P2LD1 = "Ty Smith";
				PlayerDatabase.P2LD2 = "PK Subban";
				PlayerDatabase.P2LD3 = "Christian Jaros";
				PlayerDatabase.P2RD1 = "Dougie Hamilton";
				PlayerDatabase.P2RD2 = "Damon Severson";
				PlayerDatabase.P2RD3 = "Ryan Graves";
				PlayerDatabase.P2G = "Jonathan Bernier";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYI") {
				PlayerDatabase.P2LW1 = "Zach Parise";
				PlayerDatabase.P2LW2 = "Anders Lee";
				PlayerDatabase.P2LW3 = "Anthony Beauvillier";
				PlayerDatabase.P2LW4 = "Richard Panik";
				PlayerDatabase.P2C1 = "Mathew Barzal";
				PlayerDatabase.P2C2 = "Brock Nelson";
				PlayerDatabase.P2C3 = "JeanGabriel Pageau";
				PlayerDatabase.P2C4 = "Casey Cizikas";
				PlayerDatabase.P2RW1 = "Josh Bailey";
				PlayerDatabase.P2RW2 = "Kyle Palmieri";
				PlayerDatabase.P2RW3 = "Oliver Wahlstrom";
				PlayerDatabase.P2RW4 = "Austin Czarnik";
				PlayerDatabase.P2LD1 = "Ryan Pulock";
				PlayerDatabase.P2LD2 = "Scott Mayfield";
				PlayerDatabase.P2LD3 = "Zdeno Chara";
				PlayerDatabase.P2RD1 = "Noah Dobson";
				PlayerDatabase.P2RD2 = "Adam Pelech";
				PlayerDatabase.P2RD3 = "Andy Greene";
				PlayerDatabase.P2G = "Semyon Varlamov";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "NYR") {
				PlayerDatabase.P2LW1 = "Artemi Panarin";
				PlayerDatabase.P2LW2 = "Chris Kreider";
				PlayerDatabase.P2LW3 = "Alexis Lafreniere";
				PlayerDatabase.P2LW4 = "Dryden Hunt";
				PlayerDatabase.P2C1 = "Mika Zibanejad";
				PlayerDatabase.P2C2 = "Filip Chytil";
				PlayerDatabase.P2C3 = "Barclay Goodrow";
				PlayerDatabase.P2C4 = "Kevin Rooney";
				PlayerDatabase.P2RW1 = "Ryan Strome";
				PlayerDatabase.P2RW2 = "Kaapo Kakko";
				PlayerDatabase.P2RW3 = "Sammy Blais";
				PlayerDatabase.P2RW4 = "Ryan Reaves";
				PlayerDatabase.P2LD1 = "Ryan Lindgren";
				PlayerDatabase.P2LD2 = "Patrik Nemeth";
				PlayerDatabase.P2LD3 = "Anthony Bitetto";
				PlayerDatabase.P2RD1 = "Adam Fox";
				PlayerDatabase.P2RD2 = "Jacob Trouba";
				PlayerDatabase.P2RD3 = "KAndre Miller";
				PlayerDatabase.P2G = "Igor Shesterkin";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "OTT") {
				PlayerDatabase.P2LW1 = "Brady Tkachuk";
				PlayerDatabase.P2LW2 = "Pontus Aberg";
				PlayerDatabase.P2LW3 = "Zach Sanford";
				PlayerDatabase.P2LW4 = "Austin Watson";
				PlayerDatabase.P2C1 = "Josh Norris";
				PlayerDatabase.P2C2 = "Tim Stutzle";
				PlayerDatabase.P2C3 = "Chris Tierney";
				PlayerDatabase.P2C4 = "Colin White";
				PlayerDatabase.P2RW1 = "Drake Batherson";
				PlayerDatabase.P2RW2 = "Connor Brown";
				PlayerDatabase.P2RW3 = "Tyler Ennis";
				PlayerDatabase.P2RW4 = "Logan Shaw";
				PlayerDatabase.P2LD1 = "Thomas Chabot";
				PlayerDatabase.P2LD2 = "Artyom Zub";
				PlayerDatabase.P2LD3 = "Erik Brannstrom";
				PlayerDatabase.P2RD1 = "Michael DelZotto";
				PlayerDatabase.P2RD2 = "Nikita Zaitsev";
				PlayerDatabase.P2RD3 = "Victor Mete";
				PlayerDatabase.P2G = "Matt Murray";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PHI") {
				PlayerDatabase.P2LW1 = "Travis Konecny";
				PlayerDatabase.P2LW2 = "James VanRiemsdyk";
				PlayerDatabase.P2LW3 = "Joel Farabee";
				PlayerDatabase.P2LW4 = "Nate Thompson";
				PlayerDatabase.P2C1 = "Sean Couturier";
				PlayerDatabase.P2C2 = "Kevin Hayes";
				PlayerDatabase.P2C3 = "Scott Laughton";
				PlayerDatabase.P2C4 = "Derick Brassard";
				PlayerDatabase.P2RW1 = "Claude Giroux";
				PlayerDatabase.P2RW2 = "Cam Atkinson";
				PlayerDatabase.P2RW3 = "Oskar Lindblom";
				PlayerDatabase.P2RW4 = "Nicolas AubeKubel";
				PlayerDatabase.P2LD1 = "Keith Yandle";
				PlayerDatabase.P2LD2 = "Rasmus Ristolainen";
				PlayerDatabase.P2LD3 = "Samuel Morin";
				PlayerDatabase.P2RD1 = "Ryan Ellis";
				PlayerDatabase.P2RD2 = "Ivan Provorov";
				PlayerDatabase.P2RD3 = "Travis Sanheim";
				PlayerDatabase.P2G = "Carter Hart";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "PIT") {
				PlayerDatabase.P2LW1 = "Bryan Rust";
				PlayerDatabase.P2LW2 = "Jason Zucker";
				PlayerDatabase.P2LW3 = "Teddy Blueger";
				PlayerDatabase.P2LW4 = "Brian Boyle";
				PlayerDatabase.P2C1 = "Sidney Crosby";
				PlayerDatabase.P2C2 = "Evgeni Malkin";
				PlayerDatabase.P2C3 = "Jeff Carter";
				PlayerDatabase.P2C4 = "Dominik Simon";
				PlayerDatabase.P2RW1 = "Jake Guentzel";
				PlayerDatabase.P2RW2 = "Kasperi Kapanen";
				PlayerDatabase.P2RW3 = "Danton Heinen";
				PlayerDatabase.P2RW4 = "Evan Rodrigues";
				PlayerDatabase.P2LD1 = "Mike Matheson";
				PlayerDatabase.P2LD2 = "Brian Dumoulin";
				PlayerDatabase.P2LD3 = "Marcus Pettersson";
				PlayerDatabase.P2RD1 = "Kris Letang";
				PlayerDatabase.P2RD2 = "John Marino";
				PlayerDatabase.P2RD3 = "Taylor Fedun";
				PlayerDatabase.P2G = "Tristan Jarry";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "STL") {
				PlayerDatabase.P2LW1 = "David Perron";
				PlayerDatabase.P2LW2 = "Brandon Saad";
				PlayerDatabase.P2LW3 = "Ivan Barbashev";
				PlayerDatabase.P2LW4 = "Nathan Walker";
				PlayerDatabase.P2C1 = "Ryan OReilly";
				PlayerDatabase.P2C2 = "Brayden Schenn";
				PlayerDatabase.P2C3 = "Robert Thomas";
				PlayerDatabase.P2C4 = "Tyler Bozak";
				PlayerDatabase.P2RW1 = "Vladimir Tarasenko";
				PlayerDatabase.P2RW2 = "Pavel Buchnevich";
				PlayerDatabase.P2RW3 = "Jordan Kyrou";
				PlayerDatabase.P2RW4 = "James Neal";
				PlayerDatabase.P2LD1 = "Torey Krug";
				PlayerDatabase.P2LD2 = "Justin Faulk";
				PlayerDatabase.P2LD3 = "Calle Rosen";
				PlayerDatabase.P2RD1 = "Colton Parayko";
				PlayerDatabase.P2RD2 = "Marco Scandella";
				PlayerDatabase.P2RD3 = "Robert Bortuzzo";
				PlayerDatabase.P2G = "Jordan Binnington";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SJS") {
				PlayerDatabase.P2LW1 = "Evander Kane";
				PlayerDatabase.P2LW2 = "Kevin Labanc";
				PlayerDatabase.P2LW3 = "Rudolfs Balcers";
				PlayerDatabase.P2LW4 = "John Leonard";
				PlayerDatabase.P2C1 = "Tomas Hertl";
				PlayerDatabase.P2C2 = "Logan Couture";
				PlayerDatabase.P2C3 = "Nick Bonino";
				PlayerDatabase.P2C4 = "Joel Kellman";
				PlayerDatabase.P2RW1 = "Timo Meier";
				PlayerDatabase.P2RW2 = "Nick Merkley";
				PlayerDatabase.P2RW3 = "Alexander Barabanov";
				PlayerDatabase.P2RW4 = "Matt Nieto";
				PlayerDatabase.P2LD1 = "Brent Burns";
				PlayerDatabase.P2LD2 = "Mario Ferraro";
				PlayerDatabase.P2LD3 = "Radim Simek";
				PlayerDatabase.P2RD1 = "Erik Karlsson";
				PlayerDatabase.P2RD2 = "MarcEdouard Vlasic";
				PlayerDatabase.P2RD3 = "Jacob Middleton";
				PlayerDatabase.P2G = "James Reimer";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "SEA") {
				PlayerDatabase.P2LW1 = "Jaden Schwartz";
				PlayerDatabase.P2LW2 = "Marcus Johansson";
				PlayerDatabase.P2LW3 = "Ryan Donato";
				PlayerDatabase.P2LW4 = "Colin Blackwell";
				PlayerDatabase.P2C1 = "Yanni Gourde";
				PlayerDatabase.P2C2 = "Jared McCann";
				PlayerDatabase.P2C3 = "Calle Jarnkrok";
				PlayerDatabase.P2C4 = "Alexander Wennberg";
				PlayerDatabase.P2RW1 = "Jordan Eberle";
				PlayerDatabase.P2RW2 = "Joonas Donskoi";
				PlayerDatabase.P2RW3 = "Brandon Tanev";
				PlayerDatabase.P2RW4 = "Morgan Geekie";
				PlayerDatabase.P2LD1 = "Mark Giordano";
				PlayerDatabase.P2LD2 = "Vince Dunn";
				PlayerDatabase.P2LD3 = "Jamie Oleksiak";
				PlayerDatabase.P2RD1 = "Carson Soucy";
				PlayerDatabase.P2RD2 = "Connor Carrick";
				PlayerDatabase.P2RD3 = "Adam Larsson";
				PlayerDatabase.P2G = "Philipp Grubauer";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TBL") {
				PlayerDatabase.P2LW1 = "Ondrej Palat";
				PlayerDatabase.P2LW2 = "Alex Killorn";
				PlayerDatabase.P2LW3 = "Pat Maroon";
				PlayerDatabase.P2LW4 = "Gemel Smith";
				PlayerDatabase.P2C1 = "Steven Stamkos";
				PlayerDatabase.P2C2 = "Brayden Point";
				PlayerDatabase.P2C3 = "Anthony Cirelli";
				PlayerDatabase.P2C4 = "Ross Colton";
				PlayerDatabase.P2RW1 = "Nikita Kucherov";
				PlayerDatabase.P2RW2 = "Corey Perry";
				PlayerDatabase.P2RW3 = "Mathieu Joseph";
				PlayerDatabase.P2RW4 = "Charles Hudon";
				PlayerDatabase.P2LD1 = "Victor Hedman";
				PlayerDatabase.P2LD2 = "Mikhail Sergachev";
				PlayerDatabase.P2LD3 = "Ryan McDonagh";
				PlayerDatabase.P2RD1 = "Brent Seabrook";
				PlayerDatabase.P2RD2 = "Erik Cernak";
				PlayerDatabase.P2RD3 = "Jan Rutta";
				PlayerDatabase.P2G = "Andrei Vasilevskiy";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "TOR") {
				PlayerDatabase.P2LW1 = "Nick Ritchie";
				PlayerDatabase.P2LW2 = "Alexander Kerfoot";
				PlayerDatabase.P2LW3 = "Ilya Mikheyev";
				PlayerDatabase.P2LW4 = "Denis Malgin";
				PlayerDatabase.P2C1 = "Auston Matthews";
				PlayerDatabase.P2C2 = "John Tavares";
				PlayerDatabase.P2C3 = "Jason Spezza";
				PlayerDatabase.P2C4 = "David Kampf";
				PlayerDatabase.P2RW1 = "Mitchell Marner";
				PlayerDatabase.P2RW2 = "William Nylander";
				PlayerDatabase.P2RW3 = "Michael Bunting";
				PlayerDatabase.P2RW4 = "Ondrej Kase";
				PlayerDatabase.P2LD1 = "Morgan Rielly";
				PlayerDatabase.P2LD2 = "TJ Brodie";
				PlayerDatabase.P2LD3 = "Justin Holl";
				PlayerDatabase.P2RD1 = "Jake Muzzin";
				PlayerDatabase.P2RD2 = "Rasmus Sandin";
				PlayerDatabase.P2RD3 = "Alex Biega";
				PlayerDatabase.P2G = "Petr Mrazek";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VAN") {
				PlayerDatabase.P2LW1 = "Conor Garland";
				PlayerDatabase.P2LW2 = "Michael Ferland";
				PlayerDatabase.P2LW3 = "Tanner Pearson";
				PlayerDatabase.P2LW4 = "Phil DiGiuseppe";
				PlayerDatabase.P2C1 = "Elias Pettersson";
				PlayerDatabase.P2C2 = "Bo Horvat";
				PlayerDatabase.P2C3 = "Jason Dickinson";
				PlayerDatabase.P2C4 = "Brandon Sutter";
				PlayerDatabase.P2RW1 = "JT Miller";
				PlayerDatabase.P2RW2 = "Brock Boeser";
				PlayerDatabase.P2RW3 = "Nils Hoglander";
				PlayerDatabase.P2RW4 = "Alex Chiasson";
				PlayerDatabase.P2LD1 = "Oliver EkmanLarsson";
				PlayerDatabase.P2LD2 = "Brad Hunt";
				PlayerDatabase.P2LD3 = "Madison Bowey";
				PlayerDatabase.P2RD1 = "Quinn Hughes";
				PlayerDatabase.P2RD2 = "Tyler Myers";
				PlayerDatabase.P2RD3 = "Noah Juulsen";
				PlayerDatabase.P2G = "Thatcher Demko";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "VGK") {
				PlayerDatabase.P2LW1 = "Max Pacioretty";
				PlayerDatabase.P2LW2 = "Jonathan Marchessault";
				PlayerDatabase.P2LW3 = "Peyton Krebs";
				PlayerDatabase.P2LW4 = "William Carrier";
				PlayerDatabase.P2C1 = "William Karlsson";
				PlayerDatabase.P2C2 = "Chandler Stephenson";
				PlayerDatabase.P2C3 = "Mattias Janmark";
				PlayerDatabase.P2C4 = "Nolan Patrick";
				PlayerDatabase.P2RW1 = "Mark Stone";
				PlayerDatabase.P2RW2 = "Reilly Smith";
				PlayerDatabase.P2RW3 = "Evgeny Dadonov";
				PlayerDatabase.P2RW4 = "Alex Tuch";
				PlayerDatabase.P2LD1 = "Alex Pietrangelo";
				PlayerDatabase.P2LD2 = "Nicolas Hague";
				PlayerDatabase.P2LD3 = "Dylan Coghlan";
				PlayerDatabase.P2RD1 = "Shea Theodore";
				PlayerDatabase.P2RD2 = "Alec Martinez";
				PlayerDatabase.P2RD3 = "Zach Whitecloud";
				PlayerDatabase.P2G = "Robin Lehner";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WAS") {
				PlayerDatabase.P2LW1 = "Alexander Ovechkin";
				PlayerDatabase.P2LW2 = "Anthony Mantha";
				PlayerDatabase.P2LW3 = "Conor Sheary";
				PlayerDatabase.P2LW4 = "Carl Hagelin";
				PlayerDatabase.P2C1 = "Nicklas Backstrom";
				PlayerDatabase.P2C2 = "Evgeny Kuznetsov";
				PlayerDatabase.P2C3 = "Lars Eller";
				PlayerDatabase.P2C4 = "Nic Dowd";
				PlayerDatabase.P2RW1 = "Tom Wilson";
				PlayerDatabase.P2RW2 = "TJ Oshie";
				PlayerDatabase.P2RW3 = "Daniel Sprong";
				PlayerDatabase.P2RW4 = "Garnet Hathaway";
				PlayerDatabase.P2LD1 = "Justin Schultz";
				PlayerDatabase.P2LD2 = "Dmitry Orlov";
				PlayerDatabase.P2LD3 = "Nick Jensen";
				PlayerDatabase.P2RD1 = "John Carlson";
				PlayerDatabase.P2RD2 = "Michal Kempny";
				PlayerDatabase.P2RD3 = "Dennis Cholowski";
				PlayerDatabase.P2G = "Ilya Samsonov";
			}

			else if (PlayerDatabase.ComputerChosenTeam == "WPG") {
				PlayerDatabase.P2LW1 = "Kyle Connor";
				PlayerDatabase.P2LW2 = "Nikolaj Ehlers";
				PlayerDatabase.P2LW3 = "Andrew Copp";
				PlayerDatabase.P2LW4 = "Cole Perfetti";
				PlayerDatabase.P2C1 = "Mark Scheifele";
				PlayerDatabase.P2C2 = "PierreLuc Dubois";
				PlayerDatabase.P2C3 = "Paul Stastny";
				PlayerDatabase.P2C4 = "Bryan Little";
				PlayerDatabase.P2RW1 = "Blake Wheeler";
				PlayerDatabase.P2RW2 = "Evgeny Svechnikov";
				PlayerDatabase.P2RW3 = "Riley Nash";
				PlayerDatabase.P2RW4 = "Kristian Vesalainen";
				PlayerDatabase.P2LD1 = "Neal Pionk";
				PlayerDatabase.P2LD2 = "Nate Schmidt";
				PlayerDatabase.P2LD3 = "Nathan Beaulieu";
				PlayerDatabase.P2RD1 = "Josh Morrissey";
				PlayerDatabase.P2RD2 = "Brenden Dillon";
				PlayerDatabase.P2RD3 = "Dylan DeMelo";
				PlayerDatabase.P2G = "Connor Hellebuyck";
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
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}