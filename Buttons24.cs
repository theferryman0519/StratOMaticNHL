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

public class Buttons24 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button PickActionButton;
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
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Gameplay
	public GameplayPickAction RunGameplayPickActionRun;

	// Scene Change
	public SceneChange Scene13LoadRun;
	public SceneChange Scene16LoadRun;
	public SceneChange Scene17LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// PickActionButton
		Button PickActionButtonClick = PickActionButton.GetComponent<Button>();
		PickActionButtonClick.onClick.AddListener(PickActionButtonClicking);

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
	public void PickActionButtonClicking() {
		if (EnableObjects24.TakeAwayContinue == "Pick") {
			GameplayDefend.DefendPlayString = "None";
			RunGameplayPickActionRun.RunGameplayPickAction();
		}

		else if (EnableObjects24.TakeAwayContinue == "Next") {
			if (GameplayDefend.DefendPlayString == "Takes Away, Inside Shot: I-C") {
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

				GameplayDefend.DefendPlayString = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene13LoadRun.Scene13Load();
			}

			else if (GameplayDefend.DefendPlayString == "Takes Away, Inside Shot: I-LD") {
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

				GameplayDefend.DefendPlayString = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene13LoadRun.Scene13Load();
			}
			
			else if (GameplayDefend.DefendPlayString == "Takes Away, Inside Shot: I-LW") {
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

				GameplayDefend.DefendPlayString = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene13LoadRun.Scene13Load();
			}

			else if (GameplayDefend.DefendPlayString == "Takes Away, Inside Shot: I-RD") {
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

				GameplayDefend.DefendPlayString = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene13LoadRun.Scene13Load();
			}

			else if (GameplayDefend.DefendPlayString == "Takes Away, Inside Shot: I-RW") {
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

				GameplayDefend.DefendPlayString = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene13LoadRun.Scene13Load();
			}

			else if (GameplayDefend.DefendPlayString == "Takes Away, Outside Shot") {
				GameplayDefend.DefendPlayString = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene16LoadRun.Scene16Load();
			}

			else if (GameplayDefend.DefendPlayString == "Takes Away, Outside Shot Only") {
				GameplayDefend.DefendPlayString = "None";
				PlayerDatabase.GameplayAssistA = "None";
				PlayerDatabase.GameplayAssistB = "None";
				PlayerDatabase.GameplayGoalScorer = PlayerDatabase.GameplayPossession;
				Scene17LoadRun.Scene17Load();
			}
		}
	}

	public void PlayerBackButtonClicking() {
		EnableObjects24.ShowingOverlayInt = 0;
	}

	public void P1CClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects24.ShowingOverlayString = "P1C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects24.ShowingOverlayString = "P1C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects24.ShowingOverlayString = "P1C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects24.ShowingOverlayString = "P1C4";
		}
	}

	public void P1LWClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects24.ShowingOverlayString = "P1LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects24.ShowingOverlayString = "P1LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects24.ShowingOverlayString = "P1LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects24.ShowingOverlayString = "P1LW4";
		}
	}

	public void P1RWClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects24.ShowingOverlayString = "P1RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects24.ShowingOverlayString = "P1RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects24.ShowingOverlayString = "P1RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects24.ShowingOverlayString = "P1RW4";
		}
	}

	public void P1LDClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects24.ShowingOverlayString = "P1LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects24.ShowingOverlayString = "P1LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects24.ShowingOverlayString = "P1LD3";
		}
	}

	public void P1RDClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects24.ShowingOverlayString = "P1RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects24.ShowingOverlayString = "P1RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects24.ShowingOverlayString = "P1RD3";
		}
	}

	public void P1GClicking() {
		EnableObjects24.ShowingOverlayInt = 1;
		EnableObjects24.ShowingOverlayString = "P1G";
	}

	public void P2CClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects24.ShowingOverlayString = "P2C1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects24.ShowingOverlayString = "P2C2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects24.ShowingOverlayString = "P2C3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects24.ShowingOverlayString = "P2C4";
		}
	}

	public void P2LWClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects24.ShowingOverlayString = "P2LW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects24.ShowingOverlayString = "P2LW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects24.ShowingOverlayString = "P2LW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects24.ShowingOverlayString = "P2LW4";
		}
	}

	public void P2RWClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if (PlayerDatabase.GameplayLine == "F1D1") {
			EnableObjects24.ShowingOverlayString = "P2RW1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D1") || (PlayerDatabase.GameplayLine == "F2D2")) {
			EnableObjects24.ShowingOverlayString = "P2RW2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D2") || (PlayerDatabase.GameplayLine == "F3D3")) {
			EnableObjects24.ShowingOverlayString = "P2RW3";
		}

		else if (PlayerDatabase.GameplayLine == "F4D3") {
			EnableObjects24.ShowingOverlayString = "P2RW4";
		}
	}

	public void P2LDClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects24.ShowingOverlayString = "P2LD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects24.ShowingOverlayString = "P2LD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects24.ShowingOverlayString = "P2LD3";
		}
	}

	public void P2RDClicking() {
		EnableObjects24.ShowingOverlayInt = 1;

		if ((PlayerDatabase.GameplayLine == "F1D1") || (PlayerDatabase.GameplayLine == "F2D1")) {
			EnableObjects24.ShowingOverlayString = "P2RD1";
		}

		else if ((PlayerDatabase.GameplayLine == "F2D2") || (PlayerDatabase.GameplayLine == "F3D2")) {
			EnableObjects24.ShowingOverlayString = "P2RD2";
		}

		else if ((PlayerDatabase.GameplayLine == "F3D3") || (PlayerDatabase.GameplayLine == "F4D3")) {
			EnableObjects24.ShowingOverlayString = "P2RD3";
		}
	}

	public void P2GClicking() {
		EnableObjects24.ShowingOverlayInt = 1;
		EnableObjects24.ShowingOverlayString = "P2G";
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}