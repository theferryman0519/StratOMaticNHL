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

public class GameplayPickAction : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ActionCardNumber;
	public static string DeterminedAction;
	public static int AddingPlayNumber;
	public static int RandomizeAnyPlayer;
	public static int RandomizeAnyIntimidation;
	public static int RandomizeSplitNumber;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene09LoadRun;
	public SceneChange Scene13LoadRun;
	public SceneChange Scene14LoadRun;
	public SceneChange Scene15LoadRun;
	public SceneChange Scene16LoadRun;
	public SceneChange Scene17LoadRun;
	public SceneChange Scene18LoadRun;
	public SceneChange Scene21LoadRun;
	public SceneChange Scene22LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ActionCardNumber = 0;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- GAMEPLAY FUNCTIONS ---------------
	public void RunGameplayPickAction() {
		// Check Play Number
		CheckingPlayNumber();
	}

	public void RunPickAction() {
		// Add Play Number
		AddingPlayNumber = System.Int32.Parse(PlayerDatabase.GameplayPlay);
		AddingPlayNumber = AddingPlayNumber + 1;
		PlayerDatabase.GameplayPlay = AddingPlayNumber.ToString();

		CheckingLineChange();
	}

	public void PickActionCard() {
		// Randomize Action Card Number
		ActionCardNumber = Random.Range(1,10003);

		// Determine Action
		if ((ActionCardNumber >= 1) && (ActionCardNumber < 251)) {
			DeterminedAction = "Lose Puck - Inside Any";
			Scene15LoadRun.Scene15Load();
		}

		else if ((ActionCardNumber >= 251) && (ActionCardNumber < 668)) {
			DeterminedAction = "Lose Puck - Outside Only C";
			Scene15LoadRun.Scene15Load();
		}

		else if ((ActionCardNumber >= 668) && (ActionCardNumber < 1085)) {
			DeterminedAction = "Lose Puck - Outside Only LW";
			Scene15LoadRun.Scene15Load();
		}

		else if ((ActionCardNumber >= 1085) && (ActionCardNumber < 1502)) {
			DeterminedAction = "Lose Puck - Outside Only RW";
			Scene15LoadRun.Scene15Load();
		}

		else if ((ActionCardNumber >= 1502) && (ActionCardNumber < 1648)) {
			DeterminedAction = "Lose Puck - Outside Only LD";
			Scene15LoadRun.Scene15Load();
		}

		else if ((ActionCardNumber >= 1648) && (ActionCardNumber < 1794)) {
			DeterminedAction = "Lose Puck - Outside Only RD";
			Scene15LoadRun.Scene15Load();
		}

		else if ((ActionCardNumber >= 1794) && (ActionCardNumber < 2148)) {
			DeterminedAction = "Lose Puck - Outside Only Any";
			Scene15LoadRun.Scene15Load();
		}

		else if ((ActionCardNumber >= 2148) && (ActionCardNumber < 2419)) {
			DeterminedAction = "Defending 01";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 2419) && (ActionCardNumber < 2669)) {
			DeterminedAction = "Defending 02";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 2669) && (ActionCardNumber < 2982)) {
			DeterminedAction = "Defending 03";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 2982) && (ActionCardNumber < 3315)) {
			DeterminedAction = "Defending 04";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 3315) && (ActionCardNumber < 3628)) {
			DeterminedAction = "Defending 05";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 3628) && (ActionCardNumber < 4149)) {
			DeterminedAction = "Defending 06";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 4149) && (ActionCardNumber < 4482)) {
			DeterminedAction = "Defending 07";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 4482) && (ActionCardNumber < 4815)) {
			DeterminedAction = "Defending 08";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 4815) && (ActionCardNumber < 5169)) {
			DeterminedAction = "Defending 09";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 5169) && (ActionCardNumber < 5502)) {
			DeterminedAction = "Defending 10";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 5502) && (ActionCardNumber < 5815)) {
			DeterminedAction = "Defending 11";
			Scene09LoadRun.Scene09Load();
		}

		else if ((ActionCardNumber >= 5815) && (ActionCardNumber < 6482)) {
			DeterminedAction = "Lose Puck - Any";
			Scene15LoadRun.Scene15Load();
		}

		else if ((ActionCardNumber >= 6482) && (ActionCardNumber < 6565)) {
			DeterminedAction = "Inside RD - Intimidation LD";
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1RD1";
					EnableObjects13.IntimidationPos = "P2LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1RD1";
					EnableObjects13.IntimidationPos = "P2LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1RD2";
					EnableObjects13.IntimidationPos = "P2LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1RD2";
					EnableObjects13.IntimidationPos = "P2LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1RD3";
					EnableObjects13.IntimidationPos = "P2LD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1RD3";
					EnableObjects13.IntimidationPos = "P2LD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2RD1";
					EnableObjects13.IntimidationPos = "P1LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2RD1";
					EnableObjects13.IntimidationPos = "P1LD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2RD2";
					EnableObjects13.IntimidationPos = "P1LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2RD2";
					EnableObjects13.IntimidationPos = "P1LD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2RD3";
					EnableObjects13.IntimidationPos = "P1LD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2RD3";
					EnableObjects13.IntimidationPos = "P1LD3";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}

		else if ((ActionCardNumber >= 6565) && (ActionCardNumber < 6648)) {
			DeterminedAction = "Inside LD - Intimidation RD";
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			if (PlayerDatabase.GameplayPossession.Contains("P1")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P1LD1";
					EnableObjects13.IntimidationPos = "P2RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P1LD1";
					EnableObjects13.IntimidationPos = "P2RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P1LD2";
					EnableObjects13.IntimidationPos = "P2RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P1LD2";
					EnableObjects13.IntimidationPos = "P2RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P1LD3";
					EnableObjects13.IntimidationPos = "P2RD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P1LD3";
					EnableObjects13.IntimidationPos = "P2RD3";
				}
			}

			else if (PlayerDatabase.GameplayPossession.Contains("P2")) {
				if (PlayerDatabase.GameplayLine == "F1D1") {
					PlayerDatabase.GameplayPossession = "P2LD1";
					EnableObjects13.IntimidationPos = "P1RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D1") {
					PlayerDatabase.GameplayPossession = "P2LD1";
					EnableObjects13.IntimidationPos = "P1RD1";
				}

				else if (PlayerDatabase.GameplayLine == "F2D2") {
					PlayerDatabase.GameplayPossession = "P2LD2";
					EnableObjects13.IntimidationPos = "P1RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D2") {
					PlayerDatabase.GameplayPossession = "P2LD2";
					EnableObjects13.IntimidationPos = "P1RD2";
				}

				else if (PlayerDatabase.GameplayLine == "F3D3") {
					PlayerDatabase.GameplayPossession = "P2LD3";
					EnableObjects13.IntimidationPos = "P1RD3";
				}

				else if (PlayerDatabase.GameplayLine == "F4D3") {
					PlayerDatabase.GameplayPossession = "P2LD3";
					EnableObjects13.IntimidationPos = "P1RD3";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene13LoadRun.Scene13Load();
		}

		else if ((ActionCardNumber >= 6648) && (ActionCardNumber < 7065)) {
			DeterminedAction = "Inside Any - Intimidation Any";
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

		else if ((ActionCardNumber >= 7065) && (ActionCardNumber < 7315)) {
			DeterminedAction = "Outside Only - Any";
			RandomizeAnyPlayer = Random.Range(1,6);
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			if (RandomizeAnyPlayer == 1) {
				// P1
				if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P1C1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P1C2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P1C3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P1C4";
				}

				// P2
				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P2C1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P2C2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P2C3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P2C4";
				}
			}

			else if (RandomizeAnyPlayer == 2) {
				// P1
				if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P1LW1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P1LW2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P1LW3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P1LW4";
				}

				// P2
				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P2LW1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P2LW2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P2LW3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P2LW4";
				}
			}

			else if (RandomizeAnyPlayer == 3) {
				// P1
				if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P1RW1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P1RW2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P1RW3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P1RW4";
				}

				// P2
				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P2RW1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P2RW2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P2RW3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P2RW4";
				}
			}

			else if (RandomizeAnyPlayer == 4) {
				// P1
				if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P1LD1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P1LD2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P1LD3";
				}

				// P2
				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P2LD1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P2LD2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P2LD3";
				}
			}

			else if (RandomizeAnyPlayer == 5) {
				// P1
				if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P1RD1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P1RD2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P1")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P1RD3";
				}

				// P2
				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F1D1")) {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D1")) {
					PlayerDatabase.GameplayPossession = "P2RD1";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F2D2")) {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D2")) {
					PlayerDatabase.GameplayPossession = "P2RD2";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F3D3")) {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}

				else if ((PlayerDatabase.GameplayPossession.Contains("P2")) && (PlayerDatabase.GameplayLine == "F4D3")) {
					PlayerDatabase.GameplayPossession = "P2RD3";
				}
			}

			PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
			Scene17LoadRun.Scene17Load();
		}

		else if ((ActionCardNumber >= 7315) && (ActionCardNumber < 7482)) {
			DeterminedAction = "Passing A";
			Scene18LoadRun.Scene18Load();
		}

		else if ((ActionCardNumber >= 7482) && (ActionCardNumber < 7649)) {
			DeterminedAction = "Passing B";
			Scene18LoadRun.Scene18Load();
		}

		else if ((ActionCardNumber >= 7649) && (ActionCardNumber < 7816)) {
			DeterminedAction = "Passing C";
			Scene18LoadRun.Scene18Load();
		}

		else if ((ActionCardNumber >= 7816) && (ActionCardNumber < 8149)) {
			DeterminedAction = "Passing D";
			Scene18LoadRun.Scene18Load();
		}

		else if ((ActionCardNumber >= 8149) && (ActionCardNumber < 8482)) {
			DeterminedAction = "Passing E";
			Scene18LoadRun.Scene18Load();
		}

		else if ((ActionCardNumber >= 8482) && (ActionCardNumber < 8815)) {
			DeterminedAction = "Passing F";
			Scene18LoadRun.Scene18Load();
		}

		else if ((ActionCardNumber >= 8815) && (ActionCardNumber < 8982)) {
			DeterminedAction = "Passing G";
			Scene18LoadRun.Scene18Load();
		}

		else if ((ActionCardNumber >= 8982) && (ActionCardNumber < 9149)) {
			DeterminedAction = "Passing H";
			Scene18LoadRun.Scene18Load();
		}

		else if ((ActionCardNumber >= 9149) && (ActionCardNumber < 9316)) {
			DeterminedAction = "Passing I";
			Scene18LoadRun.Scene18Load();
		}

		else if ((ActionCardNumber >= 9316) && (ActionCardNumber < 9649)) {
			DeterminedAction = "Lose Puck Any - Breakaway";
			Scene15LoadRun.Scene15Load();
		}

		else if ((ActionCardNumber >= 9649) && (ActionCardNumber < 10003)) {
			DeterminedAction = "Breakaway";
			RandomizeSplitNumber = Random.Range(1,6);
			PlayerDatabase.GameplayAssistB = PlayerDatabase.GameplayAssistA;
			PlayerDatabase.GameplayAssistA = PlayerDatabase.GameplayPossession;

			if (RandomizeSplitNumber == 1) {
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

			else if (RandomizeSplitNumber == 2) {
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

			else if (RandomizeSplitNumber == 3) {
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

			else if (RandomizeSplitNumber == 4) {
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

			else if (RandomizeSplitNumber == 5) {
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
			Scene22LoadRun.Scene22Load();
		}
	}

	public void CheckingPlayNumber() {
		if (EnableObjects14.LineChangeTime == 0) {
			RunPickAction();
		}

		else if (EnableObjects14.LineChangeTime == 2) {
			EnableObjects14.LineChangeTime = 0;
			RunPickAction();
		}

		else if (EnableObjects14.LineChangeTime == 1) {
			EnableObjects14.LineChangeTime = 0;
			RunPickAction();
			// Scene14LoadRun.Scene14Load();
		}
	}

	public void CheckingLineChange() {
		if (PlayerDatabase.GameplayPlay == "10") {
			EnableObjects14.LineChangeTime = 1;
			PickActionCard();
		}

		else if (PlayerDatabase.GameplayPlay == "12") {
			EnableObjects14.LineChangeTime = 1;
			PickActionCard();
		}

		else if (PlayerDatabase.GameplayPlay == "19") {
			EnableObjects14.LineChangeTime = 1;
			PickActionCard();
		}

		else if (PlayerDatabase.GameplayPlay == "25") {
			EnableObjects14.LineChangeTime = 1;
			PickActionCard();
		}

		else if (PlayerDatabase.GameplayPlay == "26") {
			EnableObjects14.LineChangeTime = 1;
			PickActionCard();
		}

		else if (System.Int32.Parse(PlayerDatabase.GameplayPlay) > 30) {
			Scene21LoadRun.Scene21Load();
		}

		else {
			EnableObjects14.LineChangeTime = 0;
			PickActionCard();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}