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

public class Buttons16 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button OutsideShotButton;
	public Button PenetrateButton;
	public Button PassingButton;
	public Button ContinueButton;
	public Button PlayerFlipButton;
	public Button PlayerBackButton;

	// Player Buttons
	public Button P1C;
	public Button P1LW;
	public Button P1RW;
	public Button P1LD;
	public Button P1RD;
	public Button P1G;
	public Button P2C;
	public Button P2LW;
	public Button P2RW;
	public Button P2LD;
	public Button P2RD;
	public Button P2G;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int RandomizePassingInt;
	public static string SetPassingString;
	public static string PassingPlayer;
	public static int PassingNumber;
	public static string PenetratingPlayer;
	public static string PenetratingNumber;
	public static int RandomizeP2Movement;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene15LoadRun;
	public SceneChange Scene17LoadRun;
	public SceneChange Scene18LoadRun;
	public SceneChange Scene18BLoadRun;
	public SceneChange Scene20LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// OutsideShotButton
		Button OutsideShotButtonClick = OutsideShotButton.GetComponent<Button>();
		OutsideShotButtonClick.onClick.AddListener(OutsideShotButtonClicking);

		// PenetrateButton
		Button PenetrateButtonClick = PenetrateButton.GetComponent<Button>();
		PenetrateButtonClick.onClick.AddListener(PenetrateButtonClicking);

		// PassingButton
		Button PassingButtonClick = PassingButton.GetComponent<Button>();
		PassingButtonClick.onClick.AddListener(PassingButtonClicking);

		// ContinueButton
		Button ContinueButtonClick = ContinueButton.GetComponent<Button>();
		ContinueButtonClick.onClick.AddListener(ContinueButtonClicking);

		// PlayerFlipButton
		Button PlayerFlipButtonClick = PlayerFlipButton.GetComponent<Button>();
		PlayerFlipButtonClick.onClick.AddListener(PlayerFlipButtonClicking);

		// PlayerBackButton
		Button PlayerBackButtonClick = PlayerBackButton.GetComponent<Button>();
		PlayerBackButtonClick.onClick.AddListener(PlayerBackButtonClicking);

		// Player Buttons
		Button P1CClick = P1C.GetComponent<Button>();
		Button P1LWClick = P1LW.GetComponent<Button>();
		Button P1RWClick = P1RW.GetComponent<Button>();
		Button P1LDClick = P1LD.GetComponent<Button>();
		Button P1RDClick = P1RD.GetComponent<Button>();
		Button P1GClick = P1G.GetComponent<Button>();
		Button P2CClick = P2C.GetComponent<Button>();
		Button P2LWClick = P2LW.GetComponent<Button>();
		Button P2RWClick = P2RW.GetComponent<Button>();
		Button P2LDClick = P2LD.GetComponent<Button>();
		Button P2RDClick = P2RD.GetComponent<Button>();
		Button P2GClick = P2G.GetComponent<Button>();

		P1CClick.onClick.AddListener(P1CClicking);
		P1LWClick.onClick.AddListener(P1LWClicking);
		P1RWClick.onClick.AddListener(P1RWClicking);
		P1LDClick.onClick.AddListener(P1LDClicking);
		P1RDClick.onClick.AddListener(P1RDClicking);
		P1GClick.onClick.AddListener(P1GClicking);
		P2CClick.onClick.AddListener(P2CClicking);
		P2LWClick.onClick.AddListener(P2LWClicking);
		P2RWClick.onClick.AddListener(P2RWClicking);
		P2LDClick.onClick.AddListener(P2LDClicking);
		P2RDClick.onClick.AddListener(P2RDClicking);
		P2GClick.onClick.AddListener(P2GClicking);
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
	public void OutsideShotButtonClicking() {
		Scene17LoadRun.Scene17Load();
	}

	public void PenetrateButtonClicking() {
		DeterminePenetration();
	}

	public void PassingButtonClicking() {
		DeterminePassing();
	}

	public void ContinueButtonClicking() {
		RandomizeP2Movement = Random.Range(1,4);

		if (RandomizeP2Movement == 1) {
			OutsideShotButtonClicking();
		}

		else if (RandomizeP2Movement == 2) {
			PenetrateButtonClicking();
		}

		else if (RandomizeP2Movement == 3) {
			PassingButtonClicking();
		}
	}

	public void PlayerFlipButtonClicking() {
		if (EnableObjects16.FlippingPlayerData == 0) {
			EnableObjects16.FlippingPlayerData = 1;
		}

		else if (EnableObjects16.FlippingPlayerData == 1) {
			EnableObjects16.FlippingPlayerData = 0;
		}
	}

	public void PlayerBackButtonClicking() {
		EnableObjects16.ShowingOverlayInt = 0;
	}

	public void P1CClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects16.ShowingOverlayString = "P1C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects16.ShowingOverlayString = "P1C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects16.ShowingOverlayString = "P1C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects16.ShowingOverlayString = "P1C4";
		}
	}

	public void P1LWClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects16.ShowingOverlayString = "P1LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects16.ShowingOverlayString = "P1LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects16.ShowingOverlayString = "P1LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects16.ShowingOverlayString = "P1LW4";
		}
	}

	public void P1RWClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects16.ShowingOverlayString = "P1RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects16.ShowingOverlayString = "P1RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects16.ShowingOverlayString = "P1RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects16.ShowingOverlayString = "P1RW4";
		}
	}

	public void P1LDClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects16.ShowingOverlayString = "P1LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects16.ShowingOverlayString = "P1LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects16.ShowingOverlayString = "P1LD3";
		}
	}

	public void P1RDClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects16.ShowingOverlayString = "P1RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects16.ShowingOverlayString = "P1RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects16.ShowingOverlayString = "P1RD3";
		}
	}

	public void P1GClicking() {
		EnableObjects16.ShowingOverlayInt = 1;
		EnableObjects16.ShowingOverlayString = "P1G";
	}

	public void P2CClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects16.ShowingOverlayString = "P2C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects16.ShowingOverlayString = "P2C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects16.ShowingOverlayString = "P2C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects16.ShowingOverlayString = "P2C4";
		}
	}

	public void P2LWClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects16.ShowingOverlayString = "P2LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects16.ShowingOverlayString = "P2LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects16.ShowingOverlayString = "P2LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects16.ShowingOverlayString = "P2LW4";
		}
	}

	public void P2RWClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects16.ShowingOverlayString = "P2RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects16.ShowingOverlayString = "P2RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects16.ShowingOverlayString = "P2RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects16.ShowingOverlayString = "P2RW4";
		}
	}

	public void P2LDClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects16.ShowingOverlayString = "P2LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects16.ShowingOverlayString = "P2LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects16.ShowingOverlayString = "P2LD3";
		}
	}

	public void P2RDClicking() {
		EnableObjects16.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects16.ShowingOverlayString = "P2RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects16.ShowingOverlayString = "P2RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects16.ShowingOverlayString = "P2RD3";
		}
	}

	public void P2GClicking() {
		EnableObjects16.ShowingOverlayInt = 1;
		EnableObjects16.ShowingOverlayString = "P2G";
	}

	public void DeterminePassing() {
		// Get Passing Player - Player
		if (PlayerDatabase.GameplayPossession == "P1C1") {
			PassingPlayer = PlayerDatabase.P1C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C2") {
			PassingPlayer = PlayerDatabase.P1C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C3") {
			PassingPlayer = PlayerDatabase.P1C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C4") {
			PassingPlayer = PlayerDatabase.P1C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW1") {
			PassingPlayer = PlayerDatabase.P1LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW2") {
			PassingPlayer = PlayerDatabase.P1LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW3") {
			PassingPlayer = PlayerDatabase.P1LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW4") {
			PassingPlayer = PlayerDatabase.P1LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW1") {
			PassingPlayer = PlayerDatabase.P1RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW2") {
			PassingPlayer = PlayerDatabase.P1RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW3") {
			PassingPlayer = PlayerDatabase.P1RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW4") {
			PassingPlayer = PlayerDatabase.P1RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD1") {
			PassingPlayer = PlayerDatabase.P1LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD2") {
			PassingPlayer = PlayerDatabase.P1LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD3") {
			PassingPlayer = PlayerDatabase.P1LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD1") {
			PassingPlayer = PlayerDatabase.P1RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD2") {
			PassingPlayer = PlayerDatabase.P1RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD3") {
			PassingPlayer = PlayerDatabase.P1RD3;
		}

		// Get Penetrating Player - Computer
		else if (PlayerDatabase.GameplayPossession == "P2C1") {
			PassingPlayer = PlayerDatabase.P2C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C2") {
			PassingPlayer = PlayerDatabase.P2C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C3") {
			PassingPlayer = PlayerDatabase.P2C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C4") {
			PassingPlayer = PlayerDatabase.P2C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW1") {
			PassingPlayer = PlayerDatabase.P2LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW2") {
			PassingPlayer = PlayerDatabase.P2LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW3") {
			PassingPlayer = PlayerDatabase.P2LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW4") {
			PassingPlayer = PlayerDatabase.P2LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW1") {
			PassingPlayer = PlayerDatabase.P2RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW2") {
			PassingPlayer = PlayerDatabase.P2RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW3") {
			PassingPlayer = PlayerDatabase.P2RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW4") {
			PassingPlayer = PlayerDatabase.P2RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD1") {
			PassingPlayer = PlayerDatabase.P2LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD2") {
			PassingPlayer = PlayerDatabase.P2LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD3") {
			PassingPlayer = PlayerDatabase.P2LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD1") {
			PassingPlayer = PlayerDatabase.P2RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD2") {
			PassingPlayer = PlayerDatabase.P2RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD3") {
			PassingPlayer = PlayerDatabase.P2RD3;
		}

		// Determine Passing Stat
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if ((StatsPassingJ.PlayerStatsPassingJ[PassingPlayer].Contains("Inside")) && (StatsPassingK.PlayerStatsPassingK[PassingPlayer].Contains("Inside")) && (StatsPassingL.PlayerStatsPassingL[PassingPlayer].Contains("Inside"))) {
				PassingNumber = 3;
			}

			else if ((StatsPassingJ.PlayerStatsPassingJ[PassingPlayer].Contains("Inside")) && (StatsPassingK.PlayerStatsPassingK[PassingPlayer].Contains("Inside")) && (StatsPassingL.PlayerStatsPassingL[PassingPlayer].Contains("Lose"))) {
				PassingNumber = 2;
			}

			else if ((StatsPassingJ.PlayerStatsPassingJ[PassingPlayer].Contains("Inside")) && (StatsPassingK.PlayerStatsPassingK[PassingPlayer].Contains("Lose")) && (StatsPassingL.PlayerStatsPassingL[PassingPlayer].Contains("Lose"))) {
				PassingNumber = 1;
			}

			else if ((StatsPassingJ.PlayerStatsPassingJ[PassingPlayer].Contains("Lose")) && (StatsPassingK.PlayerStatsPassingK[PassingPlayer].Contains("Lose")) && (StatsPassingL.PlayerStatsPassingL[PassingPlayer].Contains("Lose"))) {
				PassingNumber = 0;
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if ((StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Inside")) && (StatsPassingK.FrPlayerStatsPassingK[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Inside")) && (StatsPassingL.FrPlayerStatsPassingL[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Inside"))) {
					PassingNumber = 3;
				}

				else if ((StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Inside")) && (StatsPassingK.FrPlayerStatsPassingK[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Inside")) && (StatsPassingL.FrPlayerStatsPassingL[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Lose"))) {
					PassingNumber = 2;
				}

				else if ((StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Inside")) && (StatsPassingK.FrPlayerStatsPassingK[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Lose")) && (StatsPassingL.FrPlayerStatsPassingL[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Lose"))) {
					PassingNumber = 1;
				}

				else if ((StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Lose")) && (StatsPassingK.FrPlayerStatsPassingK[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Lose")) && (StatsPassingL.FrPlayerStatsPassingL[PassingPlayer + PlayerDatabase.PlayerChosenTeam].Contains("Lose"))) {
					PassingNumber = 0;
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if ((StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Inside")) && (StatsPassingK.FrPlayerStatsPassingK[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Inside")) && (StatsPassingL.FrPlayerStatsPassingL[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Inside"))) {
					PassingNumber = 3;
				}

				else if ((StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Inside")) && (StatsPassingK.FrPlayerStatsPassingK[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Inside")) && (StatsPassingL.FrPlayerStatsPassingL[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Lose"))) {
					PassingNumber = 2;
				}

				else if ((StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Inside")) && (StatsPassingK.FrPlayerStatsPassingK[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Lose")) && (StatsPassingL.FrPlayerStatsPassingL[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Lose"))) {
					PassingNumber = 1;
				}

				else if ((StatsPassingJ.FrPlayerStatsPassingJ[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Lose")) && (StatsPassingK.FrPlayerStatsPassingK[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Lose")) && (StatsPassingL.FrPlayerStatsPassingL[PassingPlayer + PlayerDatabase.ComputerChosenTeam].Contains("Lose"))) {
					PassingNumber = 0;
				}
			}
		}

		// Determine Passing Int
		RandomizePassingInt = Random.Range(1,25);

		if (PassingNumber == 3) {
			if ((RandomizePassingInt >= 1) && (RandomizePassingInt < 7)) {
				GameplayPassing.PassingString = "Inside Shot C";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C4";
					}
				}
				
				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}
			
			else if ((RandomizePassingInt >= 7) && (RandomizePassingInt < 14)) {
				GameplayPassing.PassingString = "Inside Shot LW";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW4";
					}
				}

				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}

			else if ((RandomizePassingInt >= 14) && (RandomizePassingInt < 20)) {
				GameplayPassing.PassingString = "Inside Shot RW";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW4";
					}
				}

				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}

			else if ((RandomizePassingInt >= 20) && (RandomizePassingInt < 21)) {
				GameplayPickAction.DeterminedAction = "Lose to C";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to C";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 21) && (RandomizePassingInt < 22)) {
				GameplayPickAction.DeterminedAction = "Lose to LD";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to LD";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD3";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 22) && (RandomizePassingInt < 23)) {
				GameplayPickAction.DeterminedAction = "Lose to LW";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to LW";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 23) && (RandomizePassingInt < 24)) {
				GameplayPickAction.DeterminedAction = "Lose to RD";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to RD";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD3";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 24) && (RandomizePassingInt < 25)) {
				GameplayPickAction.DeterminedAction = "Lose to RW";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to RW";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}
		}

		else if (PassingNumber == 2) {
			if ((RandomizePassingInt >= 1) && (RandomizePassingInt < 5)) {
				GameplayPassing.PassingString = "Inside Shot C";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C4";
					}
				}
				
				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}
			
			else if ((RandomizePassingInt >= 5) && (RandomizePassingInt < 10)) {
				GameplayPassing.PassingString = "Inside Shot LW";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW4";
					}
				}

				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}

			else if ((RandomizePassingInt >= 10) && (RandomizePassingInt < 15)) {
				GameplayPassing.PassingString = "Inside Shot RW";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW4";
					}
				}

				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}

			else if ((RandomizePassingInt >= 15) && (RandomizePassingInt < 17)) {
				GameplayPickAction.DeterminedAction = "Lose to C";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to C";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 17) && (RandomizePassingInt < 19)) {
				GameplayPickAction.DeterminedAction = "Lose to LD";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to LD";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD3";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 19) && (RandomizePassingInt < 21)) {
				GameplayPickAction.DeterminedAction = "Lose to LW";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to LW";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 21) && (RandomizePassingInt < 23)) {
				GameplayPickAction.DeterminedAction = "Lose to RD";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to RD";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD3";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 23) && (RandomizePassingInt < 25)) {
				GameplayPickAction.DeterminedAction = "Lose to RW";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to RW";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}
		}

		else if (PassingNumber == 1) {
			if ((RandomizePassingInt >= 1) && (RandomizePassingInt < 3)) {
				GameplayPassing.PassingString = "Inside Shot C";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C4";
					}
				}
				
				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}
			
			else if ((RandomizePassingInt >= 3) && (RandomizePassingInt < 6)) {
				GameplayPassing.PassingString = "Inside Shot LW";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW4";
					}
				}

				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}

			else if ((RandomizePassingInt >= 6) && (RandomizePassingInt < 10)) {
				GameplayPassing.PassingString = "Inside Shot RW";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW4";
					}
				}

				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}

			else if ((RandomizePassingInt >= 10) && (RandomizePassingInt < 13)) {
				GameplayPickAction.DeterminedAction = "Lose to C";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to C";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 13) && (RandomizePassingInt < 16)) {
				GameplayPickAction.DeterminedAction = "Lose to LD";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to LD";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD3";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 16) && (RandomizePassingInt < 19)) {
				GameplayPickAction.DeterminedAction = "Lose to LW";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to LW";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 19) && (RandomizePassingInt < 22)) {
				GameplayPickAction.DeterminedAction = "Lose to RD";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to RD";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD3";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 22) && (RandomizePassingInt < 25)) {
				GameplayPickAction.DeterminedAction = "Lose to RW";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to RW";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}
		}

		else if (PassingNumber == 0) {
			if ((RandomizePassingInt >= 1) && (RandomizePassingInt < 3)) {
				GameplayPassing.PassingString = "Inside Shot C";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2C4";
					}
				}
				
				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}
			
			else if ((RandomizePassingInt >= 3) && (RandomizePassingInt < 4)) {
				GameplayPassing.PassingString = "Inside Shot LW";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LW4";
					}
				}

				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}

			else if ((RandomizePassingInt >= 4) && (RandomizePassingInt < 5)) {
				GameplayPassing.PassingString = "Inside Shot RW";
				GameplayPassing.InitialPasserString = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RW4";
					}
				}

				PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
				PlayerDatabase.GameplayAssistA = GameplayPassing.InitialPasserString;
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene18BLoadRun.Scene18BLoad();
			}

			else if ((RandomizePassingInt >= 5) && (RandomizePassingInt < 9)) {
				GameplayPickAction.DeterminedAction = "Lose to C";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to C";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2C4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1C4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 9) && (RandomizePassingInt < 13)) {
				GameplayPickAction.DeterminedAction = "Lose to LD";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to LD";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LD3";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 13) && (RandomizePassingInt < 17)) {
				GameplayPickAction.DeterminedAction = "Lose to LW";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to LW";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2LW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1LW4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 17) && (RandomizePassingInt < 21)) {
				GameplayPickAction.DeterminedAction = "Lose to RD";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to RD";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RD3";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}

			else if ((RandomizePassingInt >= 21) && (RandomizePassingInt < 25)) {
				GameplayPickAction.DeterminedAction = "Lose to RW";
				EnableObjects15.AfterLosingPuckString = "Lose Puck to RW";
				EnableObjects15.PuckOwnerFrom = PlayerDatabase.GameplayPossession;

				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						EnableObjects15.PuckOwnerTo = "P2RW4";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						EnableObjects15.PuckOwnerTo = "P1RW4";
					}
				}

				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene15LoadRun.Scene15Load();
			}
		}
	}

	public void DeterminePenetration() {
		// Get Penetrating Player - Player
		if (PlayerDatabase.GameplayPossession == "P1C1") {
			PenetratingPlayer = PlayerDatabase.P1C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C2") {
			PenetratingPlayer = PlayerDatabase.P1C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C3") {
			PenetratingPlayer = PlayerDatabase.P1C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1C4") {
			PenetratingPlayer = PlayerDatabase.P1C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW1") {
			PenetratingPlayer = PlayerDatabase.P1LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW2") {
			PenetratingPlayer = PlayerDatabase.P1LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW3") {
			PenetratingPlayer = PlayerDatabase.P1LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LW4") {
			PenetratingPlayer = PlayerDatabase.P1LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW1") {
			PenetratingPlayer = PlayerDatabase.P1RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW2") {
			PenetratingPlayer = PlayerDatabase.P1RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW3") {
			PenetratingPlayer = PlayerDatabase.P1RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RW4") {
			PenetratingPlayer = PlayerDatabase.P1RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD1") {
			PenetratingPlayer = PlayerDatabase.P1LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD2") {
			PenetratingPlayer = PlayerDatabase.P1LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1LD3") {
			PenetratingPlayer = PlayerDatabase.P1LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD1") {
			PenetratingPlayer = PlayerDatabase.P1RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD2") {
			PenetratingPlayer = PlayerDatabase.P1RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P1RD3") {
			PenetratingPlayer = PlayerDatabase.P1RD3;
		}

		// Get Penetrating Player - Computer
		else if (PlayerDatabase.GameplayPossession == "P2C1") {
			PenetratingPlayer = PlayerDatabase.P2C1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C2") {
			PenetratingPlayer = PlayerDatabase.P2C2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C3") {
			PenetratingPlayer = PlayerDatabase.P2C3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2C4") {
			PenetratingPlayer = PlayerDatabase.P2C4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW1") {
			PenetratingPlayer = PlayerDatabase.P2LW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW2") {
			PenetratingPlayer = PlayerDatabase.P2LW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW3") {
			PenetratingPlayer = PlayerDatabase.P2LW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LW4") {
			PenetratingPlayer = PlayerDatabase.P2LW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW1") {
			PenetratingPlayer = PlayerDatabase.P2RW1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW2") {
			PenetratingPlayer = PlayerDatabase.P2RW2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW3") {
			PenetratingPlayer = PlayerDatabase.P2RW3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RW4") {
			PenetratingPlayer = PlayerDatabase.P2RW4;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD1") {
			PenetratingPlayer = PlayerDatabase.P2LD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD2") {
			PenetratingPlayer = PlayerDatabase.P2LD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2LD3") {
			PenetratingPlayer = PlayerDatabase.P2LD3;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD1") {
			PenetratingPlayer = PlayerDatabase.P2RD1;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD2") {
			PenetratingPlayer = PlayerDatabase.P2RD2;
		}

		else if (PlayerDatabase.GameplayPossession == "P2RD3") {
			PenetratingPlayer = PlayerDatabase.P2RD3;
		}

		// Determine Penetration Stat
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			PenetratingNumber = StatsBreakaway.PlayerStatsBreakaway[PenetratingPlayer];
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				PenetratingNumber = StatsBreakaway.FrPlayerStatsBreakaway[PenetratingPlayer + PlayerDatabase.PlayerChosenTeam];
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				PenetratingNumber = StatsBreakaway.FrPlayerStatsBreakaway[PenetratingPlayer + PlayerDatabase.ComputerChosenTeam];
			}
		}

		// Go to Penetration Scene
		Scene20LoadRun.Scene20Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}