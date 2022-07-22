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

public class GameplayLosePuck : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int RandomizeAnyIntimidation;
	public static int RandomizeSplitNumber;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene12LoadRun;
	public SceneChange Scene13LoadRun;
	public SceneChange Scene16LoadRun;
	public SceneChange Scene17LoadRun;
	public SceneChange Scene22LoadRun;
	public SceneChange Scene25LoadRun;
	
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
    public void RunGameplayLosePuck() {
		if (EnableObjects15.AfterLosingPuckString == "Lose Puck to Any") {
			Scene25LoadRun.Scene25Load();
		}

		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck to C") {
			Scene25LoadRun.Scene25Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck to LD") {
			Scene25LoadRun.Scene25Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck to LW") {
			Scene25LoadRun.Scene25Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck to RD") {
			Scene25LoadRun.Scene25Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck to RW") {
			Scene25LoadRun.Scene25Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot Any: I-Any") {
			RandomizeAnyIntimidation = Random.Range(1,6);

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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot C: I-C") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot C: I-LD") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot C: I-LW") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot C: I-RD") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot C: I-RW") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot LW: I-C") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot LW: I-LD") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot LW: I-LW") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot LW: I-RD") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot LW: I-RW") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot RW: I-C") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot RW: I-LD") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot RW: I-LW") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot RW: I-RD") {
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
			
			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Inside Shot RW: I-RW") {
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

			Scene13LoadRun.Scene13Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Outside Shot Any") {
			Scene16LoadRun.Scene16Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Outside Shot C") {
			Scene16LoadRun.Scene16Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Outside Shot LD") {
			Scene16LoadRun.Scene16Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Outside Shot LW") {
			Scene16LoadRun.Scene16Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Outside Shot RD") {
			Scene16LoadRun.Scene16Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose, Outside Shot RW") {
			Scene16LoadRun.Scene16Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck - Inside Any") {
			Scene12LoadRun.Scene12Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck - Outside Only C") {
			Scene17LoadRun.Scene17Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck - Outside Only LW") {
			Scene17LoadRun.Scene17Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck - Outside Only RW") {
			Scene17LoadRun.Scene17Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck - Outside Only LD") {
			Scene17LoadRun.Scene17Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck - Outside Only RD") {
			Scene17LoadRun.Scene17Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck - Outside Only Any") {
			Scene17LoadRun.Scene17Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck - Any") {
			Scene25LoadRun.Scene25Load();
		}
		
		else if (EnableObjects15.AfterLosingPuckString == "Lose Puck Any - Breakaway") {
			RandomizeSplitNumber = Random.Range(1,6);

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

			Scene22LoadRun.Scene22Load();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}