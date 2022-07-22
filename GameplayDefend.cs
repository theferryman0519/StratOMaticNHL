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

public class GameplayDefend : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string DefendPlayString;
	public static int RandomizeAnyPlayer;
	public static int RandomizeAnyIntimidation;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene13LoadRun;
	public SceneChange Scene16LoadRun;
	public SceneChange Scene17LoadRun;
	public SceneChange Scene19LoadRun;
	public SceneChange Scene24LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void RunGameplayDefend() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			// Get Defend Play
			if (GameplayPickAction.DeterminedAction == "Defending 01") {
				DefendPlayString = StatsDefending01.PlayerStatsDefending01[EnableObjects09.DefendingPlayerString];
			}

			else if (GameplayPickAction.DeterminedAction == "Defending 02") {
				DefendPlayString = StatsDefending02.PlayerStatsDefending02[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 03") {
				DefendPlayString = StatsDefending03.PlayerStatsDefending03[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 04") {
				DefendPlayString = StatsDefending04.PlayerStatsDefending04[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 05") {
				DefendPlayString = StatsDefending05.PlayerStatsDefending05[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 06") {
				DefendPlayString = StatsDefending06.PlayerStatsDefending06[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 07") {
				DefendPlayString = StatsDefending07.PlayerStatsDefending07[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 08") {
				DefendPlayString = StatsDefending08.PlayerStatsDefending08[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 09") {
				DefendPlayString = StatsDefending09.PlayerStatsDefending09[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 10") {
				DefendPlayString = StatsDefending10.PlayerStatsDefending10[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 11") {
				DefendPlayString = StatsDefending11.PlayerStatsDefending11[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 12") {
				DefendPlayString = StatsDefending12.PlayerStatsDefending12[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 13") {
				DefendPlayString = StatsDefending13.PlayerStatsDefending13[EnableObjects09.DefendingPlayerString];
			}
			
			else if (GameplayPickAction.DeterminedAction == "Defending 14") {
				DefendPlayString = StatsDefending14.PlayerStatsDefending14[EnableObjects09.DefendingPlayerString];
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				// Get Defend Play
				if (GameplayPickAction.DeterminedAction == "Defending 01") {
					DefendPlayString = StatsDefending01.FrPlayerStatsDefending01[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Defending 02") {
					DefendPlayString = StatsDefending02.FrPlayerStatsDefending02[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 03") {
					DefendPlayString = StatsDefending03.FrPlayerStatsDefending03[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 04") {
					DefendPlayString = StatsDefending04.FrPlayerStatsDefending04[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 05") {
					DefendPlayString = StatsDefending05.FrPlayerStatsDefending05[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 06") {
					DefendPlayString = StatsDefending06.FrPlayerStatsDefending06[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 07") {
					DefendPlayString = StatsDefending07.FrPlayerStatsDefending07[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 08") {
					DefendPlayString = StatsDefending08.FrPlayerStatsDefending08[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 09") {
					DefendPlayString = StatsDefending09.FrPlayerStatsDefending09[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 10") {
					DefendPlayString = StatsDefending10.FrPlayerStatsDefending10[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 11") {
					DefendPlayString = StatsDefending11.FrPlayerStatsDefending11[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 12") {
					DefendPlayString = StatsDefending12.FrPlayerStatsDefending12[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 13") {
					DefendPlayString = StatsDefending13.FrPlayerStatsDefending13[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 14") {
					DefendPlayString = StatsDefending14.FrPlayerStatsDefending14[EnableObjects09.DefendingPlayerString + PlayerDatabase.PlayerChosenTeam];
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				// Get Defend Play
				if (GameplayPickAction.DeterminedAction == "Defending 01") {
					DefendPlayString = StatsDefending01.FrPlayerStatsDefending01[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}

				else if (GameplayPickAction.DeterminedAction == "Defending 02") {
					DefendPlayString = StatsDefending02.FrPlayerStatsDefending02[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 03") {
					DefendPlayString = StatsDefending03.FrPlayerStatsDefending03[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 04") {
					DefendPlayString = StatsDefending04.FrPlayerStatsDefending04[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 05") {
					DefendPlayString = StatsDefending05.FrPlayerStatsDefending05[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 06") {
					DefendPlayString = StatsDefending06.FrPlayerStatsDefending06[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 07") {
					DefendPlayString = StatsDefending07.FrPlayerStatsDefending07[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 08") {
					DefendPlayString = StatsDefending08.FrPlayerStatsDefending08[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 09") {
					DefendPlayString = StatsDefending09.FrPlayerStatsDefending09[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 10") {
					DefendPlayString = StatsDefending10.FrPlayerStatsDefending10[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 11") {
					DefendPlayString = StatsDefending11.FrPlayerStatsDefending11[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 12") {
					DefendPlayString = StatsDefending12.FrPlayerStatsDefending12[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 13") {
					DefendPlayString = StatsDefending13.FrPlayerStatsDefending13[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
				
				else if (GameplayPickAction.DeterminedAction == "Defending 14") {
					DefendPlayString = StatsDefending14.FrPlayerStatsDefending14[EnableObjects09.DefendingPlayerString + PlayerDatabase.ComputerChosenTeam];
				}
			}
		}

		// Determine Scene
		if (DefendPlayString == "Inside Shot Any: I-Any") {
			RandomizeAnyPlayer = Random.Range(1,6);
			RandomizeAnyIntimidation = Random.Range(1,6);

			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (RandomizeAnyPlayer == 1) {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1C1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1C2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1C3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1C4";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2C1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2C2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2C2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2C3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2C3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2C4";
					}
				}
			}

			else if (RandomizeAnyPlayer == 2) {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LW1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LW2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LW3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LW4";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LW1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LW2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LW3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LW4";
					}
				}
			}

			else if (RandomizeAnyPlayer == 3) {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RW1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RW2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RW3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RW4";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RW1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RW2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RW3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RW4";
					}
				}
			}

			else if (RandomizeAnyPlayer == 4) {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1LD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1LD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1LD3";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2LD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2LD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2LD3";
					}
				}
			}

			else if (RandomizeAnyPlayer == 5) {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P1RD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P1RD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P1RD3";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						PlayerDatabase.GameplayPossession = "P2RD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						PlayerDatabase.GameplayPossession = "P2RD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						PlayerDatabase.GameplayPossession = "P2RD3";
					}
				}
			}

			// Update Intimidating Player
			if (RandomizeAnyIntimidation == 1) {
				if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P1C1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P1C2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P1C2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P1C3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P1C3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P1C4";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P2C1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P2C2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P2C2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P2C3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P2C3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P2C4";
					}
				}
			}

			else if (RandomizeAnyIntimidation == 2) {
				if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P1LW1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P1LW2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P1LW2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P1LW3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P1LW3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P1LW4";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P2LW1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P2LW2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P2LW2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P2LW3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P2LW3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P2LW4";
					}
				}
			}

			else if (RandomizeAnyIntimidation == 3) {
				if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P1RW1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P1RW2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P1RW2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P1RW3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P1RW3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P1RW4";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P2RW1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P2RW2";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P2RW2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P2RW3";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P2RW3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P2RW4";
					}
				}
			}

			else if (RandomizeAnyIntimidation == 4) {
				if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P1LD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P1LD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P1LD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P1LD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P1LD3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P1LD3";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P2LD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P2LD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P2LD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P2LD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P2LD3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P2LD3";
					}
				}
			}

			else if (RandomizeAnyIntimidation == 5) {
				if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P1RD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P1RD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P1RD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P1RD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P1RD3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P1RD3";
					}
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					if (PlayerDatabase.GameplayLine == "F1D1") {
						EnableObjects13.IntimidationPos = "P2RD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D1") {
						EnableObjects13.IntimidationPos = "P2RD1";
					}

					else if (PlayerDatabase.GameplayLine == "F2D2") {
						EnableObjects13.IntimidationPos = "P2RD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D2") {
						EnableObjects13.IntimidationPos = "P2RD2";
					}

					else if (PlayerDatabase.GameplayLine == "F3D3") {
						EnableObjects13.IntimidationPos = "P2RD3";
					}

					else if (PlayerDatabase.GameplayLine == "F4D3") {
						EnableObjects13.IntimidationPos = "P2RD3";
					}
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}

		else if (DefendPlayString == "Inside Shot C: I-C") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1C4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2C4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1C4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2C4";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot C: I-LD") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1C4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2C4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1LD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1LD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2LD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2LD3";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot C: I-LW") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1C4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2C4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1LW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2LW4";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot C: I-RD") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1C4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2C4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1RD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1RD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2RD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2RD3";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot C: I-RW") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1C4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2C4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1RW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2RW4";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot LW: I-C") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1LW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2LW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1C4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2C4";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot LW: I-LD") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1LW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2LW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1LD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1LD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2LD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2LD3";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot LW: I-LW") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1LW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2LW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1LW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2LW4";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot LW: I-RD") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1LW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2LW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1RD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1RD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2RD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2RD3";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot LW: I-RW") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1LW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2LW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1RW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2RW4";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot RW: I-C") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1RW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2RW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1C4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2C1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2C2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2C3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2C4";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot RW: I-LD") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1RW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2RW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1LD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1LD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2LD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2LD3";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot RW: I-LW") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1RW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2RW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1LW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2LW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2LW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2LW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2LW4";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot RW: I-RD") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1RW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2RW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1RD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1RD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2RD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2RD3";
				}
			}
			
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Inside Shot RW: I-RW") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			// Update Current Player
			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1RW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2RW4";
				}
			}

			// Update Intimidating Player
			if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P1RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P1RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P1RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P1RW4";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					EnableObjects13.IntimidationPos = "P2RW1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					EnableObjects13.IntimidationPos = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					EnableObjects13.IntimidationPos = "P2RW2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					EnableObjects13.IntimidationPos = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					EnableObjects13.IntimidationPos = "P2RW3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					EnableObjects13.IntimidationPos = "P2RW4";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}
		
		else if (DefendPlayString == "Outside Shot") {
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene16LoadRun.Scene16Load();
		}
		
		else if (DefendPlayString == "Outside Shot Any") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			RandomizeAnyPlayer = Random.Range(1,6);

			if (RandomizeAnyPlayer == 1) {
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
			}

			else if (RandomizeAnyPlayer == 2) {
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
			}

			else if (RandomizeAnyPlayer == 3) {
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
			}

			else if (RandomizeAnyPlayer == 4) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1LD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2LD3";
					}
				}
			}

			else if (RandomizeAnyPlayer == 5) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD1";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD1";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD2";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD2";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD3";
					}
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					if (PlayerDatabase.GameplayPossession.Contains("P1")) {
						PlayerDatabase.GameplayPossession = "P1RD3";
					}

					else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
						PlayerDatabase.GameplayPossession = "P2RD3";
					}
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene16LoadRun.Scene16Load();
		}
		
		else if (DefendPlayString == "Outside Shot C") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

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

			Scene16LoadRun.Scene16Load();
		}
		
		else if (DefendPlayString == "Outside Shot LD") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			if (PlayerDatabase.GameplayLine == "F1D1") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F2D1") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F2D2") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F3D2") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F3D3") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F4D3") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}
			}
			
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene16LoadRun.Scene16Load();
		}
		
		else if (DefendPlayString == "Outside Shot LW") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

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
			
			Scene16LoadRun.Scene16Load();
		}
		
		else if (DefendPlayString == "Outside Shot RD") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			if (PlayerDatabase.GameplayLine == "F1D1") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F2D1") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F2D2") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F3D2") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F3D3") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}
			}

			else if (PlayerDatabase.GameplayLine == "F4D3") {
				if (PlayerDatabase.GameplayPossession.Contains("P1")) {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}

				else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene16LoadRun.Scene16Load();
		}
		
		else if (DefendPlayString == "Outside Shot RW") {
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

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

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene16LoadRun.Scene16Load();
		}
		
		else if (DefendPlayString == "Penalty") {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "None";

			// Set Penalized Player
			if (PlayerDatabase.P1C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C1";
			}

			else if (PlayerDatabase.P1C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C2";
			}

			else if (PlayerDatabase.P1C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C3";
			}

			else if (PlayerDatabase.P1C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C4";
			}

			else if (PlayerDatabase.P1LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (PlayerDatabase.P1LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (PlayerDatabase.P1LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (PlayerDatabase.P1LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (PlayerDatabase.P1RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (PlayerDatabase.P1RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (PlayerDatabase.P1RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (PlayerDatabase.P1RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (PlayerDatabase.P1LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (PlayerDatabase.P1LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (PlayerDatabase.P1LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (PlayerDatabase.P1RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			else if (PlayerDatabase.P1RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			else if (PlayerDatabase.P1RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			else if (PlayerDatabase.P2C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C1";
			}

			else if (PlayerDatabase.P2C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C2";
			}

			else if (PlayerDatabase.P2C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C3";
			}

			else if (PlayerDatabase.P2C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C4";
			}

			else if (PlayerDatabase.P2LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (PlayerDatabase.P2LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (PlayerDatabase.P2LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (PlayerDatabase.P2LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (PlayerDatabase.P2RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (PlayerDatabase.P2RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (PlayerDatabase.P2RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (PlayerDatabase.P2RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (PlayerDatabase.P2LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (PlayerDatabase.P2LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (PlayerDatabase.P2LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (PlayerDatabase.P2RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}

			else if (PlayerDatabase.P2RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}

			else if (PlayerDatabase.P2RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}

			// Go to Penalty Scene
			EnableObjects09.DefendingPlayerString = "None";
			PlayerDatabase.GameplayGoalScorer = "None";
			Scene19LoadRun.Scene19Load();
		}
		
		else if (DefendPlayString == "Takes Away Puck") {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "None";

			// Set Defending Player
			if (PlayerDatabase.P1C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C1";
			}

			else if (PlayerDatabase.P1C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C2";
			}

			else if (PlayerDatabase.P1C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C3";
			}

			else if (PlayerDatabase.P1C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C4";
			}

			else if (PlayerDatabase.P1LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (PlayerDatabase.P1LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (PlayerDatabase.P1LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (PlayerDatabase.P1LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (PlayerDatabase.P1RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (PlayerDatabase.P1RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (PlayerDatabase.P1RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (PlayerDatabase.P1RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (PlayerDatabase.P1LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (PlayerDatabase.P1LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (PlayerDatabase.P1LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (PlayerDatabase.P1RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			else if (PlayerDatabase.P1RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			else if (PlayerDatabase.P1RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			else if (PlayerDatabase.P2C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C1";
			}

			else if (PlayerDatabase.P2C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C2";
			}

			else if (PlayerDatabase.P2C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C3";
			}

			else if (PlayerDatabase.P2C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C4";
			}

			else if (PlayerDatabase.P2LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (PlayerDatabase.P2LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (PlayerDatabase.P2LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (PlayerDatabase.P2LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (PlayerDatabase.P2RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (PlayerDatabase.P2RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (PlayerDatabase.P2RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (PlayerDatabase.P2RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (PlayerDatabase.P2LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (PlayerDatabase.P2LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (PlayerDatabase.P2LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (PlayerDatabase.P2RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}

			else if (PlayerDatabase.P2RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}

			else if (PlayerDatabase.P2RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}

			// Go to Take Away Scene
			EnableObjects09.DefendingPlayerString = "None";
			EnableObjects24.TakeAwayContinue = "Pick";
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene24LoadRun.Scene24Load();
		}
		
		else if (DefendPlayString == "Takes Away, Inside Shot: I-C") {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "None";

			// Set Defending Player
			if (PlayerDatabase.P1C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C1";
			}

			else if (PlayerDatabase.P1C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C2";
			}

			else if (PlayerDatabase.P1C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C3";
			}

			else if (PlayerDatabase.P1C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C4";
			}

			else if (PlayerDatabase.P1LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (PlayerDatabase.P1LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (PlayerDatabase.P1LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (PlayerDatabase.P1LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (PlayerDatabase.P1RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (PlayerDatabase.P1RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (PlayerDatabase.P1RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (PlayerDatabase.P1RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (PlayerDatabase.P1LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (PlayerDatabase.P1LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (PlayerDatabase.P1LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (PlayerDatabase.P1RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			else if (PlayerDatabase.P1RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			else if (PlayerDatabase.P1RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			else if (PlayerDatabase.P2C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C1";
			}

			else if (PlayerDatabase.P2C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C2";
			}

			else if (PlayerDatabase.P2C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C3";
			}

			else if (PlayerDatabase.P2C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C4";
			}

			else if (PlayerDatabase.P2LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (PlayerDatabase.P2LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (PlayerDatabase.P2LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (PlayerDatabase.P2LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (PlayerDatabase.P2RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (PlayerDatabase.P2RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (PlayerDatabase.P2RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (PlayerDatabase.P2RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (PlayerDatabase.P2LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (PlayerDatabase.P2LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (PlayerDatabase.P2LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (PlayerDatabase.P2RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}

			else if (PlayerDatabase.P2RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}

			else if (PlayerDatabase.P2RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}

			// Go to Take Away Scene
			EnableObjects09.DefendingPlayerString = "None";
			EnableObjects24.TakeAwayContinue = "Next";
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene24LoadRun.Scene24Load();
		}
		
		else if (DefendPlayString == "Takes Away, Inside Shot: I-LD") {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "None";

			// Set Defending Player
			if (PlayerDatabase.P1C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C1";
			}

			else if (PlayerDatabase.P1C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C2";
			}

			else if (PlayerDatabase.P1C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C3";
			}

			else if (PlayerDatabase.P1C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C4";
			}

			else if (PlayerDatabase.P1LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (PlayerDatabase.P1LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (PlayerDatabase.P1LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (PlayerDatabase.P1LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (PlayerDatabase.P1RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (PlayerDatabase.P1RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (PlayerDatabase.P1RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (PlayerDatabase.P1RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (PlayerDatabase.P1LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (PlayerDatabase.P1LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (PlayerDatabase.P1LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (PlayerDatabase.P1RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			else if (PlayerDatabase.P1RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			else if (PlayerDatabase.P1RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			else if (PlayerDatabase.P2C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C1";
			}

			else if (PlayerDatabase.P2C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C2";
			}

			else if (PlayerDatabase.P2C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C3";
			}

			else if (PlayerDatabase.P2C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C4";
			}

			else if (PlayerDatabase.P2LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (PlayerDatabase.P2LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (PlayerDatabase.P2LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (PlayerDatabase.P2LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (PlayerDatabase.P2RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (PlayerDatabase.P2RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (PlayerDatabase.P2RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (PlayerDatabase.P2RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (PlayerDatabase.P2LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (PlayerDatabase.P2LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (PlayerDatabase.P2LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (PlayerDatabase.P2RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}

			else if (PlayerDatabase.P2RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}

			else if (PlayerDatabase.P2RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}

			// Go to Take Away Scene
			EnableObjects09.DefendingPlayerString = "None";
			EnableObjects24.TakeAwayContinue = "Next";
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene24LoadRun.Scene24Load();
		}
		
		else if (DefendPlayString == "Takes Away, Inside Shot: I-LW") {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "None";

			// Set Defending Player
			if (PlayerDatabase.P1C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C1";
			}

			else if (PlayerDatabase.P1C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C2";
			}

			else if (PlayerDatabase.P1C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C3";
			}

			else if (PlayerDatabase.P1C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C4";
			}

			else if (PlayerDatabase.P1LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (PlayerDatabase.P1LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (PlayerDatabase.P1LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (PlayerDatabase.P1LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (PlayerDatabase.P1RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (PlayerDatabase.P1RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (PlayerDatabase.P1RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (PlayerDatabase.P1RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (PlayerDatabase.P1LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (PlayerDatabase.P1LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (PlayerDatabase.P1LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (PlayerDatabase.P1RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			else if (PlayerDatabase.P1RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			else if (PlayerDatabase.P1RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			else if (PlayerDatabase.P2C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C1";
			}

			else if (PlayerDatabase.P2C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C2";
			}

			else if (PlayerDatabase.P2C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C3";
			}

			else if (PlayerDatabase.P2C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C4";
			}

			else if (PlayerDatabase.P2LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (PlayerDatabase.P2LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (PlayerDatabase.P2LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (PlayerDatabase.P2LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (PlayerDatabase.P2RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (PlayerDatabase.P2RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (PlayerDatabase.P2RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (PlayerDatabase.P2RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (PlayerDatabase.P2LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (PlayerDatabase.P2LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (PlayerDatabase.P2LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (PlayerDatabase.P2RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}

			else if (PlayerDatabase.P2RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}

			else if (PlayerDatabase.P2RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}

			// Go to Take Away Scene
			EnableObjects09.DefendingPlayerString = "None";
			EnableObjects24.TakeAwayContinue = "Next";
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene24LoadRun.Scene24Load();
		}
		
		else if (DefendPlayString == "Takes Away, Inside Shot: I-RD") {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "None";

			// Set Defending Player
			if (PlayerDatabase.P1C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C1";
			}

			else if (PlayerDatabase.P1C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C2";
			}

			else if (PlayerDatabase.P1C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C3";
			}

			else if (PlayerDatabase.P1C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C4";
			}

			else if (PlayerDatabase.P1LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (PlayerDatabase.P1LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (PlayerDatabase.P1LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (PlayerDatabase.P1LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (PlayerDatabase.P1RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (PlayerDatabase.P1RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (PlayerDatabase.P1RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (PlayerDatabase.P1RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (PlayerDatabase.P1LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (PlayerDatabase.P1LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (PlayerDatabase.P1LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (PlayerDatabase.P1RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			else if (PlayerDatabase.P1RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			else if (PlayerDatabase.P1RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			else if (PlayerDatabase.P2C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C1";
			}

			else if (PlayerDatabase.P2C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C2";
			}

			else if (PlayerDatabase.P2C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C3";
			}

			else if (PlayerDatabase.P2C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C4";
			}

			else if (PlayerDatabase.P2LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (PlayerDatabase.P2LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (PlayerDatabase.P2LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (PlayerDatabase.P2LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (PlayerDatabase.P2RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (PlayerDatabase.P2RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (PlayerDatabase.P2RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (PlayerDatabase.P2RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (PlayerDatabase.P2LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (PlayerDatabase.P2LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (PlayerDatabase.P2LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (PlayerDatabase.P2RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}

			else if (PlayerDatabase.P2RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}

			else if (PlayerDatabase.P2RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}

			// Go to Take Away Scene
			EnableObjects09.DefendingPlayerString = "None";
			EnableObjects24.TakeAwayContinue = "Next";
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene24LoadRun.Scene24Load();
		}
		
		else if (DefendPlayString == "Takes Away, Inside Shot: I-RW") {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "None";

			// Set Defending Player
			if (PlayerDatabase.P1C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C1";
			}

			else if (PlayerDatabase.P1C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C2";
			}

			else if (PlayerDatabase.P1C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C3";
			}

			else if (PlayerDatabase.P1C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C4";
			}

			else if (PlayerDatabase.P1LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (PlayerDatabase.P1LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (PlayerDatabase.P1LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (PlayerDatabase.P1LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (PlayerDatabase.P1RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (PlayerDatabase.P1RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (PlayerDatabase.P1RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (PlayerDatabase.P1RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (PlayerDatabase.P1LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (PlayerDatabase.P1LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (PlayerDatabase.P1LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (PlayerDatabase.P1RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			else if (PlayerDatabase.P1RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			else if (PlayerDatabase.P1RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			else if (PlayerDatabase.P2C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C1";
			}

			else if (PlayerDatabase.P2C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C2";
			}

			else if (PlayerDatabase.P2C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C3";
			}

			else if (PlayerDatabase.P2C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C4";
			}

			else if (PlayerDatabase.P2LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (PlayerDatabase.P2LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (PlayerDatabase.P2LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (PlayerDatabase.P2LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (PlayerDatabase.P2RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (PlayerDatabase.P2RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (PlayerDatabase.P2RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (PlayerDatabase.P2RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (PlayerDatabase.P2LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (PlayerDatabase.P2LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (PlayerDatabase.P2LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (PlayerDatabase.P2RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}

			else if (PlayerDatabase.P2RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}

			else if (PlayerDatabase.P2RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}

			// Go to Take Away Scene
			EnableObjects09.DefendingPlayerString = "None";
			EnableObjects24.TakeAwayContinue = "Next";
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene24LoadRun.Scene24Load();
		}
		
		else if (DefendPlayString == "Takes Away, Outside Shot") {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "None";

			// Set Defending Player
			if (PlayerDatabase.P1C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C1";
			}

			else if (PlayerDatabase.P1C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C2";
			}

			else if (PlayerDatabase.P1C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C3";
			}

			else if (PlayerDatabase.P1C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C4";
			}

			else if (PlayerDatabase.P1LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (PlayerDatabase.P1LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (PlayerDatabase.P1LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (PlayerDatabase.P1LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (PlayerDatabase.P1RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (PlayerDatabase.P1RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (PlayerDatabase.P1RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (PlayerDatabase.P1RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (PlayerDatabase.P1LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (PlayerDatabase.P1LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (PlayerDatabase.P1LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (PlayerDatabase.P1RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			else if (PlayerDatabase.P1RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			else if (PlayerDatabase.P1RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			else if (PlayerDatabase.P2C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C1";
			}

			else if (PlayerDatabase.P2C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C2";
			}

			else if (PlayerDatabase.P2C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C3";
			}

			else if (PlayerDatabase.P2C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C4";
			}

			else if (PlayerDatabase.P2LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (PlayerDatabase.P2LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (PlayerDatabase.P2LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (PlayerDatabase.P2LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (PlayerDatabase.P2RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (PlayerDatabase.P2RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (PlayerDatabase.P2RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (PlayerDatabase.P2RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (PlayerDatabase.P2LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (PlayerDatabase.P2LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (PlayerDatabase.P2LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (PlayerDatabase.P2RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}

			else if (PlayerDatabase.P2RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}

			else if (PlayerDatabase.P2RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}

			// Go to Take Away Scene
			EnableObjects09.DefendingPlayerString = "None";
			EnableObjects24.TakeAwayContinue = "Next";
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene24LoadRun.Scene24Load();
		}
		
		else if (DefendPlayString == "Takes Away, Outside Shot Only") {
			PlayerDatabase.GameplayAssistB = "None";
			PlayerDatabase.GameplayAssistA = "None";
			
			// Set Defending Player
			if (PlayerDatabase.P1C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C1";
			}

			else if (PlayerDatabase.P1C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C2";
			}

			else if (PlayerDatabase.P1C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C3";
			}

			else if (PlayerDatabase.P1C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1C4";
			}

			else if (PlayerDatabase.P1LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW1";
			}

			else if (PlayerDatabase.P1LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW2";
			}

			else if (PlayerDatabase.P1LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW3";
			}

			else if (PlayerDatabase.P1LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LW4";
			}

			else if (PlayerDatabase.P1RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW1";
			}

			else if (PlayerDatabase.P1RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW2";
			}

			else if (PlayerDatabase.P1RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW3";
			}

			else if (PlayerDatabase.P1RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RW4";
			}

			else if (PlayerDatabase.P1LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD1";
			}

			else if (PlayerDatabase.P1LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD2";
			}

			else if (PlayerDatabase.P1LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1LD3";
			}

			else if (PlayerDatabase.P1RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD1";
			}

			else if (PlayerDatabase.P1RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD2";
			}

			else if (PlayerDatabase.P1RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P1RD3";
			}

			else if (PlayerDatabase.P2C1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C1";
			}

			else if (PlayerDatabase.P2C2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C2";
			}

			else if (PlayerDatabase.P2C3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C3";
			}

			else if (PlayerDatabase.P2C4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2C4";
			}

			else if (PlayerDatabase.P2LW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW1";
			}

			else if (PlayerDatabase.P2LW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW2";
			}

			else if (PlayerDatabase.P2LW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW3";
			}

			else if (PlayerDatabase.P2LW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LW4";
			}

			else if (PlayerDatabase.P2RW1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW1";
			}

			else if (PlayerDatabase.P2RW2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW2";
			}

			else if (PlayerDatabase.P2RW3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW3";
			}

			else if (PlayerDatabase.P2RW4 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RW4";
			}

			else if (PlayerDatabase.P2LD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD1";
			}

			else if (PlayerDatabase.P2LD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD2";
			}

			else if (PlayerDatabase.P2LD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2LD3";
			}

			else if (PlayerDatabase.P2RD1 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD1";
			}

			else if (PlayerDatabase.P2RD2 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD2";
			}

			else if (PlayerDatabase.P2RD3 == EnableObjects09.DefendingPlayerString) {
				PlayerDatabase.GameplayPossession = "P2RD3";
			}

			// Go to Take Away Scene
			EnableObjects09.DefendingPlayerString = "None";
			EnableObjects24.TakeAwayContinue = "Next";
			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene24LoadRun.Scene24Load();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}