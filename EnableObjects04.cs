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
using System.Linq;

public class EnableObjects04 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Image ContinueButton;

	// Select Line Objects
	public Image SetLW1Button;
	public Image SetC1Button;
	public Image SetRW1Button;
	public Image SetLW2Button;
	public Image SetC2Button;
	public Image SetRW2Button;
	public Image SetLW3Button;
	public Image SetC3Button;
	public Image SetRW3Button;
	public Image SetLW4Button;
	public Image SetC4Button;
	public Image SetRW4Button;
	public Image SetLD1Button;
	public Image SetRD1Button;
	public Image SetLD2Button;
	public Image SetRD2Button;
	public Image SetLD3Button;
	public Image SetRD3Button;
	public Image SetGButton;
	public Text SetLW1Text;
	public Text SetC1Text;
	public Text SetRW1Text;
	public Text SetLW2Text;
	public Text SetC2Text;
	public Text SetRW2Text;
	public Text SetLW3Text;
	public Text SetC3Text;
	public Text SetRW3Text;
	public Text SetLW4Text;
	public Text SetC4Text;
	public Text SetRW4Text;
	public Text SetLD1Text;
	public Text SetRD1Text;
	public Text SetLD2Text;
	public Text SetRD2Text;
	public Text SetLD3Text;
	public Text SetRD3Text;
	public Text SetGText;
	public Image DefaultLinesButton;

	// Player Select Objects
	public Image PlayerSelectBackground;
	public Text SelectPlayerTitle;
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
	public Image PlayerStats01;
	public Image PlayerStats02;
	public Image PlayerStats03;
	public Image PlayerStats04;
	public Image PlayerStats05;
	public Image PlayerStats06;
	public Image PlayerStats07;
	public Image PlayerStats08;
	public Image PlayerStats09;
	public Image PlayerStats10;
	public Image PlayerStats11;
	public Image PlayerStats12;
	public Image StatsBackButton;

	// Player Card Objects
	public Image PlayerCardBackground;
	public Text PlayerNameTitle;
	public Text OffenseText;
	public Text DefenseText;
	public Text PenaltyText;
	public Text BreakawayText;
	public Text IntimidationText;
	public Text FaceoffText;
	public Text PositionsText;
	public Image StatsScroll;
	public Image StatsView;
	public Text OutsideShotTitle;
	public Text OutsideShot02;
	public Text OutsideShot03;
	public Text OutsideShot04;
	public Text OutsideShot05;
	public Text OutsideShot06;
	public Text OutsideShot07;
	public Text OutsideShot08;
	public Text OutsideShot09;
	public Text OutsideShot10;
	public Text OutsideShot11;
	public Text OutsideShot12;
	public Text InsideShotTitle;
	public Text InsideShot02;
	public Text InsideShot03;
	public Text InsideShot04;
	public Text InsideShot05;
	public Text InsideShot06;
	public Text InsideShot07;
	public Text InsideShot08;
	public Text InsideShot09;
	public Text InsideShot10;
	public Text InsideShot11;
	public Text InsideShot12;
	public Text RebBreakShotTitle;
	public Text RebBreakShot02;
	public Text RebBreakShot03;
	public Text RebBreakShot04;
	public Text RebBreakShot05;
	public Text RebBreakShot06;
	public Text RebBreakShot07;
	public Text RebBreakShot08;
	public Text RebBreakShot09;
	public Text RebBreakShot10;
	public Text RebBreakShot11;
	public Text RebBreakShot12;
	public Text PassingTitle;
	public Text PassingA;
	public Text PassingB;
	public Text PassingC;
	public Text PassingD;
	public Text PassingE;
	public Text PassingFG;
	public Text PassingH;
	public Text PassingI;
	public Text PassingJ;
	public Text PassingK;
	public Text PassingL;
	public Text DefendingTitle;
	public Text Defending01;
	public Text Defending02;
	public Text Defending03;
	public Text Defending04;
	public Text Defending05;
	public Text Defending06;
	public Text Defending07;
	public Text Defending11;
	public Text Defending12;
	public Text Defending13;
	public Text Defending14;
	public Text ScrollNoteText;
	public Image PlayerSetBackButton;
	public Image PlayerSetButton;

	// Goalie Select Objects
	public Image GoalieSelectBackground;
	public Text SelectGoalieTitle;
	public Text GoalieText01;
	public Text GoalieText02;
	public Text GoalieText03;
	public Text GoalieText04;
	public Text GoalieText05;
	public Text GoalieText06;
	public Text GoalieText07;
	public Image GoalieStats01;
	public Image GoalieStats02;
	public Image GoalieStats03;
	public Image GoalieStats04;
	public Image GoalieStats05;
	public Image GoalieStats06;
	public Image GoalieStats07;
	public Image GoalieStatsBackButton;

	// Goalie Card Objects
	public Image GoalieCardBackground;
	public Text GoalieNameTitle;
	public Text GoalieRatingTitle;
	public Text GoalieRating02;
	public Text GoalieRating03;
	public Text GoalieRating04;
	public Text GoalieRating05;
	public Text GoalieRating06;
	public Text GoalieRating07;
	public Text GoalieRating08;
	public Text GoalieRating09;
	public Text GoalieRating10;
	public Text GoalieRating11;
	public Text GoalieRating12;
	public Image GoalieSetBackButton;
	public Image GoalieSetButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ShowingPlayerInfoInt;
	public static string ShowingPlayerInfoString;
	public static int GettingPlayerInts;
	public static string ShowingPlayerPositions;

	public static List<string> PlayerListFullLW = new List<string>();
	public static List<string> PlayerListFullC = new List<string>();
	public static List<string> PlayerListFullRW = new List<string>();
	public static List<string> PlayerListFullLD = new List<string>();
	public static List<string> PlayerListFullRD = new List<string>();
	public static List<string> PlayerListFullG = new List<string>();

	public static List<string> PlayerListLW = new List<string>();
	public static List<string> PlayerListC = new List<string>();
	public static List<string> PlayerListRW = new List<string>();
	public static List<string> PlayerListLD = new List<string>();
	public static List<string> PlayerListRD = new List<string>();
	public static List<string> PlayerListG = new List<string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ShowingPlayerInfoInt = 0;
		ShowingPlayerPositions = "None";
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (ShowingPlayerInfoInt == 0) {
			EnableMainObjects();
			EnableSelectLineObjects();
			DisablePlayerSelectObjects();
			DisablePlayerCardObjects();
			DisableGoalieStatsObjects();
			DisableGoalieCardObjects();
		}

		else if (ShowingPlayerInfoInt == 1) {
			EnableMainObjects();
			EnableSelectLineObjects();
			EnablePlayerSelectObjects();
			DisablePlayerCardObjects();
			DisableGoalieStatsObjects();
			DisableGoalieCardObjects();
		}

		else if (ShowingPlayerInfoInt == 2) {
			EnableMainObjects();
			EnableSelectLineObjects();
			EnablePlayerCardObjects();
			DisablePlayerSelectObjects();
			DisableGoalieStatsObjects();
			DisableGoalieCardObjects();
		}

		else if (ShowingPlayerInfoInt == 3) {
			EnableMainObjects();
			EnableSelectLineObjects();
			EnableGoalieStatsObjects();
			DisablePlayerSelectObjects();
			DisablePlayerCardObjects();
			DisableGoalieCardObjects();
		}

		else if (ShowingPlayerInfoInt == 4) {
			EnableMainObjects();
			EnableSelectLineObjects();
			EnableGoalieCardObjects();
			DisablePlayerSelectObjects();
			DisablePlayerCardObjects();
			DisableGoalieStatsObjects();
		}

		UpdatingPlayerNames();
		UpdatingPlayerInfo();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBJECT FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ContinueButton.enabled = true;
	}

	public void EnableSelectLineObjects() {
		DefaultLinesButton.enabled = true;
		UpdatePlayerSelectButtons();
	}

	public void EnablePlayerSelectObjects() {
		PlayerSelectBackground.enabled = true;
		SelectPlayerTitle.enabled = true;
		PlayerText01.enabled = true;
		PlayerText02.enabled = true;
		PlayerText03.enabled = true;
		PlayerText04.enabled = true;
		PlayerText05.enabled = true;
		PlayerText06.enabled = true;
		PlayerText07.enabled = true;
		PlayerText08.enabled = true;
		PlayerText09.enabled = true;
		PlayerText10.enabled = true;
		PlayerText11.enabled = true;
		PlayerText12.enabled = true;
		PlayerStats01.enabled = true;
		PlayerStats02.enabled = true;
		PlayerStats03.enabled = true;
		PlayerStats04.enabled = true;
		PlayerStats05.enabled = true;
		PlayerStats06.enabled = true;
		PlayerStats07.enabled = true;
		PlayerStats08.enabled = true;
		PlayerStats09.enabled = true;
		PlayerStats10.enabled = true;
		PlayerStats11.enabled = true;
		PlayerStats12.enabled = true;
		StatsBackButton.enabled = true;
	}

	public void EnablePlayerCardObjects() {
		PlayerCardBackground.enabled = true;
		PlayerNameTitle.enabled = true;
		OffenseText.enabled = true;
		DefenseText.enabled = true;
		PenaltyText.enabled = true;
		BreakawayText.enabled = true;
		IntimidationText.enabled = true;
		FaceoffText.enabled = true;
		PositionsText.enabled = true;
		StatsScroll.enabled = true;
		StatsView.enabled = true;
		OutsideShotTitle.enabled = true;
		OutsideShot02.enabled = true;
		OutsideShot03.enabled = true;
		OutsideShot04.enabled = true;
		OutsideShot05.enabled = true;
		OutsideShot06.enabled = true;
		OutsideShot07.enabled = true;
		OutsideShot08.enabled = true;
		OutsideShot09.enabled = true;
		OutsideShot10.enabled = true;
		OutsideShot11.enabled = true;
		OutsideShot12.enabled = true;
		InsideShotTitle.enabled = true;
		InsideShot02.enabled = true;
		InsideShot03.enabled = true;
		InsideShot04.enabled = true;
		InsideShot05.enabled = true;
		InsideShot06.enabled = true;
		InsideShot07.enabled = true;
		InsideShot08.enabled = true;
		InsideShot09.enabled = true;
		InsideShot10.enabled = true;
		InsideShot11.enabled = true;
		InsideShot12.enabled = true;
		RebBreakShotTitle.enabled = true;
		RebBreakShot02.enabled = true;
		RebBreakShot03.enabled = true;
		RebBreakShot04.enabled = true;
		RebBreakShot05.enabled = true;
		RebBreakShot06.enabled = true;
		RebBreakShot07.enabled = true;
		RebBreakShot08.enabled = true;
		RebBreakShot09.enabled = true;
		RebBreakShot10.enabled = true;
		RebBreakShot11.enabled = true;
		RebBreakShot12.enabled = true;
		PassingTitle.enabled = true;
		PassingA.enabled = true;
		PassingB.enabled = true;
		PassingC.enabled = true;
		PassingD.enabled = true;
		PassingE.enabled = true;
		PassingFG.enabled = true;
		PassingH.enabled = true;
		PassingI.enabled = true;
		PassingJ.enabled = true;
		PassingK.enabled = true;
		PassingL.enabled = true;
		DefendingTitle.enabled = true;
		Defending01.enabled = true;
		Defending02.enabled = true;
		Defending03.enabled = true;
		Defending04.enabled = true;
		Defending05.enabled = true;
		Defending06.enabled = true;
		Defending07.enabled = true;
		Defending11.enabled = true;
		Defending12.enabled = true;
		Defending13.enabled = true;
		Defending14.enabled = true;
		ScrollNoteText.enabled = true;
		PlayerSetBackButton.enabled = true;
		PlayerSetButton.enabled = true;
	}

	public void EnableGoalieStatsObjects() {
		GoalieSelectBackground.enabled = true;
		SelectGoalieTitle.enabled = true;
		GoalieText01.enabled = true;
		GoalieText02.enabled = true;
		GoalieText03.enabled = true;
		GoalieText04.enabled = true;
		GoalieText05.enabled = true;
		GoalieText06.enabled = true;
		GoalieText07.enabled = true;
		GoalieStats01.enabled = true;
		GoalieStats02.enabled = true;
		GoalieStats03.enabled = true;
		GoalieStats04.enabled = true;
		GoalieStats05.enabled = true;
		GoalieStats06.enabled = true;
		GoalieStats07.enabled = true;
		GoalieStatsBackButton.enabled = true;
	}

	public void EnableGoalieCardObjects() {
		GoalieCardBackground.enabled = true;
		GoalieNameTitle.enabled = true;
		GoalieRatingTitle.enabled = true;
		GoalieRating02.enabled = true;
		GoalieRating03.enabled = true;
		GoalieRating04.enabled = true;
		GoalieRating05.enabled = true;
		GoalieRating06.enabled = true;
		GoalieRating07.enabled = true;
		GoalieRating08.enabled = true;
		GoalieRating09.enabled = true;
		GoalieRating10.enabled = true;
		GoalieRating11.enabled = true;
		GoalieRating12.enabled = true;
		GoalieSetBackButton.enabled = true;
		GoalieSetButton.enabled = true;
	}

// --------------- DISABLING OBJECT FUNCTIONS ---------------
	public void DisableMainObjects() {
		BackgroundImage.enabled = false;
		TitleText.enabled = false;
		ContinueButton.enabled = false;
	}

	public void DisableSelectLineObjects() {
		SetLW1Button.enabled = false;
		SetC1Button.enabled = false;
		SetRW1Button.enabled = false;
		SetLW2Button.enabled = false;
		SetC2Button.enabled = false;
		SetRW2Button.enabled = false;
		SetLW3Button.enabled = false;
		SetC3Button.enabled = false;
		SetRW3Button.enabled = false;
		SetLW4Button.enabled = false;
		SetC4Button.enabled = false;
		SetRW4Button.enabled = false;
		SetLD1Button.enabled = false;
		SetRD1Button.enabled = false;
		SetLD2Button.enabled = false;
		SetRD2Button.enabled = false;
		SetLD3Button.enabled = false;
		SetRD3Button.enabled = false;
		SetGButton.enabled = false;
		SetLW1Text.enabled = false;
		SetC1Text.enabled = false;
		SetRW1Text.enabled = false;
		SetLW2Text.enabled = false;
		SetC2Text.enabled = false;
		SetRW2Text.enabled = false;
		SetLW3Text.enabled = false;
		SetC3Text.enabled = false;
		SetRW3Text.enabled = false;
		SetLW4Text.enabled = false;
		SetC4Text.enabled = false;
		SetRW4Text.enabled = false;
		SetLD1Text.enabled = false;
		SetRD1Text.enabled = false;
		SetLD2Text.enabled = false;
		SetRD2Text.enabled = false;
		SetLD3Text.enabled = false;
		SetRD3Text.enabled = false;
		SetGText.enabled = false;
		DefaultLinesButton.enabled = false;
	}

	public void DisablePlayerSelectObjects() {
		PlayerSelectBackground.enabled = false;
		SelectPlayerTitle.enabled = false;
		PlayerText01.enabled = false;
		PlayerText02.enabled = false;
		PlayerText03.enabled = false;
		PlayerText04.enabled = false;
		PlayerText05.enabled = false;
		PlayerText06.enabled = false;
		PlayerText07.enabled = false;
		PlayerText08.enabled = false;
		PlayerText09.enabled = false;
		PlayerText10.enabled = false;
		PlayerText11.enabled = false;
		PlayerText12.enabled = false;
		PlayerStats01.enabled = false;
		PlayerStats02.enabled = false;
		PlayerStats03.enabled = false;
		PlayerStats04.enabled = false;
		PlayerStats05.enabled = false;
		PlayerStats06.enabled = false;
		PlayerStats07.enabled = false;
		PlayerStats08.enabled = false;
		PlayerStats09.enabled = false;
		PlayerStats10.enabled = false;
		PlayerStats11.enabled = false;
		PlayerStats12.enabled = false;
		StatsBackButton.enabled = false;
	}

	public void DisablePlayerCardObjects() {
		PlayerCardBackground.enabled = false;
		PlayerNameTitle.enabled = false;
		OffenseText.enabled = false;
		DefenseText.enabled = false;
		PenaltyText.enabled = false;
		BreakawayText.enabled = false;
		IntimidationText.enabled = false;
		FaceoffText.enabled = false;
		PositionsText.enabled = false;
		StatsScroll.enabled = false;
		StatsView.enabled = false;
		OutsideShotTitle.enabled = false;
		OutsideShot02.enabled = false;
		OutsideShot03.enabled = false;
		OutsideShot04.enabled = false;
		OutsideShot05.enabled = false;
		OutsideShot06.enabled = false;
		OutsideShot07.enabled = false;
		OutsideShot08.enabled = false;
		OutsideShot09.enabled = false;
		OutsideShot10.enabled = false;
		OutsideShot11.enabled = false;
		OutsideShot12.enabled = false;
		InsideShotTitle.enabled = false;
		InsideShot02.enabled = false;
		InsideShot03.enabled = false;
		InsideShot04.enabled = false;
		InsideShot05.enabled = false;
		InsideShot06.enabled = false;
		InsideShot07.enabled = false;
		InsideShot08.enabled = false;
		InsideShot09.enabled = false;
		InsideShot10.enabled = false;
		InsideShot11.enabled = false;
		InsideShot12.enabled = false;
		RebBreakShotTitle.enabled = false;
		RebBreakShot02.enabled = false;
		RebBreakShot03.enabled = false;
		RebBreakShot04.enabled = false;
		RebBreakShot05.enabled = false;
		RebBreakShot06.enabled = false;
		RebBreakShot07.enabled = false;
		RebBreakShot08.enabled = false;
		RebBreakShot09.enabled = false;
		RebBreakShot10.enabled = false;
		RebBreakShot11.enabled = false;
		RebBreakShot12.enabled = false;
		PassingTitle.enabled = false;
		PassingA.enabled = false;
		PassingB.enabled = false;
		PassingC.enabled = false;
		PassingD.enabled = false;
		PassingE.enabled = false;
		PassingFG.enabled = false;
		PassingH.enabled = false;
		PassingI.enabled = false;
		PassingJ.enabled = false;
		PassingK.enabled = false;
		PassingL.enabled = false;
		DefendingTitle.enabled = false;
		Defending01.enabled = false;
		Defending02.enabled = false;
		Defending03.enabled = false;
		Defending04.enabled = false;
		Defending05.enabled = false;
		Defending06.enabled = false;
		Defending07.enabled = false;
		Defending11.enabled = false;
		Defending12.enabled = false;
		Defending13.enabled = false;
		Defending14.enabled = false;
		ScrollNoteText.enabled = false;
		PlayerSetBackButton.enabled = false;
		PlayerSetButton.enabled = false;
	}

	public void DisableGoalieStatsObjects() {
		GoalieSelectBackground.enabled = false;
		SelectGoalieTitle.enabled = false;
		GoalieText01.enabled = false;
		GoalieText02.enabled = false;
		GoalieText03.enabled = false;
		GoalieText04.enabled = false;
		GoalieText05.enabled = false;
		GoalieText06.enabled = false;
		GoalieText07.enabled = false;
		GoalieStats01.enabled = false;
		GoalieStats02.enabled = false;
		GoalieStats03.enabled = false;
		GoalieStats04.enabled = false;
		GoalieStats05.enabled = false;
		GoalieStats06.enabled = false;
		GoalieStats07.enabled = false;
		GoalieStatsBackButton.enabled = false;
	}

	public void DisableGoalieCardObjects() {
		GoalieCardBackground.enabled = false;
		GoalieNameTitle.enabled = false;
		GoalieRatingTitle.enabled = false;
		GoalieRating02.enabled = false;
		GoalieRating03.enabled = false;
		GoalieRating04.enabled = false;
		GoalieRating05.enabled = false;
		GoalieRating06.enabled = false;
		GoalieRating07.enabled = false;
		GoalieRating08.enabled = false;
		GoalieRating09.enabled = false;
		GoalieRating10.enabled = false;
		GoalieRating11.enabled = false;
		GoalieRating12.enabled = false;
		GoalieSetBackButton.enabled = false;
		GoalieSetButton.enabled = false;
	}

// --------------- UPDATING OBJECT FUNCTIONS ---------------
	public void UpdatingPlayerNames() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			// Gather Player Lists
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersANA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersANA[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersANA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersANA[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersANA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersANA[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersANA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersANA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersANA[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersANA[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersANA[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersANA[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersANA[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersANA[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersANA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersANA[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersANA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersANA[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersANA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersANA[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersANA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersANA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersANA[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersANA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersANA[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersANA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersANA[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersANA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersANA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersANA[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersANA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersANA[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersANA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersANA[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersANA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesANA.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesANA[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ARI") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersARI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersARI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersARI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersARI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersARI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersARI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersARI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersARI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersARI[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersARI[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersARI[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersARI[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersARI[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersARI[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersARI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersARI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersARI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersARI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersARI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersARI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersARI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersARI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersARI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersARI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersARI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersARI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersARI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersARI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersARI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersARI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersARI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersARI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersARI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersARI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersARI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesARI.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesARI[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBOS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBOS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersBOS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBOS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersBOS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBOS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersBOS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBOS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBOS[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersBOS[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBOS[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersBOS[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBOS[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersBOS[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBOS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBOS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersBOS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBOS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersBOS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBOS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersBOS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBOS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBOS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersBOS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBOS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersBOS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBOS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersBOS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBOS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBOS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersBOS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBOS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersBOS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBOS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersBOS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesBOS.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesBOS[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBUF.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBUF[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersBUF[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBUF[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersBUF[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBUF[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersBUF[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBUF.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBUF[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersBUF[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBUF[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersBUF[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBUF[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersBUF[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBUF.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBUF[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersBUF[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBUF[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersBUF[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBUF[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersBUF[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBUF.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBUF[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersBUF[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBUF[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersBUF[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBUF[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersBUF[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersBUF.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersBUF[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersBUF[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersBUF[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersBUF[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersBUF[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersBUF[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesBUF.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesBUF[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCAL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCAL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAL[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersCAL[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCAL[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCAL[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCAL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCAL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCAL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCAL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCAL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCAL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesCAL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesCAL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAR[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCAR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAR[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCAR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAR[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAR[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersCAR[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAR[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCAR[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAR[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCAR[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAR[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCAR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAR[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCAR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAR[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAR[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCAR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAR[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCAR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAR[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCAR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCAR[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCAR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCAR[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCAR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCAR[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesCAR.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesCAR[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCHI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCHI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCHI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCHI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCHI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCHI[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersCHI[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCHI[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCHI[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCHI[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCHI[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCHI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCHI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCHI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCHI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCHI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCHI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCHI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCHI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCHI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCHI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCHI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCHI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCHI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCHI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCHI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesCHI.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesCHI[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCOL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCOL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCOL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCOL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCOL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCOL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCOL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCOL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCOL[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersCOL[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCOL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCOL[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCOL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCOL[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCOL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCOL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCOL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCOL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCOL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCOL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCOL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCOL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCOL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCOL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCOL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCOL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCOL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCOL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCOL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCOL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCOL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCOL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCOL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCOL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCOL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesCOL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesCOL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCBJ.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCBJ[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCBJ[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCBJ[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCBJ[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCBJ[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersCBJ[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCBJ.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCBJ[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersCBJ[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCBJ[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCBJ[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCBJ[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersCBJ[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCBJ.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCBJ[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCBJ[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCBJ[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCBJ[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCBJ[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersCBJ[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCBJ.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCBJ[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCBJ[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCBJ[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCBJ[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCBJ[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersCBJ[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersCBJ.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersCBJ[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCBJ[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersCBJ[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCBJ[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersCBJ[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersCBJ[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesCBJ.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesCBJ[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDAL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersDAL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDAL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersDAL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDAL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersDAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDAL[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersDAL[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDAL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersDAL[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDAL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersDAL[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDAL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersDAL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDAL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersDAL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDAL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersDAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDAL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersDAL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDAL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersDAL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDAL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersDAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDAL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDAL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersDAL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDAL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersDAL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDAL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersDAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesDAL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesDAL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDET.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDET[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersDET[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDET[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersDET[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDET[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersDET[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDET.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDET[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersDET[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDET[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersDET[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDET[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersDET[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDET.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDET[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersDET[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDET[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersDET[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDET[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersDET[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDET.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDET[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersDET[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDET[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersDET[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDET[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersDET[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersDET.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersDET[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersDET[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersDET[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersDET[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersDET[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersDET[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesDET.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesDET[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersEDM.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersEDM[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersEDM[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersEDM[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersEDM[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersEDM[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersEDM[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersEDM.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersEDM[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersEDM[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersEDM[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersEDM[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersEDM[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersEDM[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersEDM.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersEDM[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersEDM[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersEDM[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersEDM[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersEDM[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersEDM[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersEDM.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersEDM[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersEDM[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersEDM[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersEDM[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersEDM[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersEDM[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersEDM.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersEDM[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersEDM[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersEDM[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersEDM[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersEDM[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersEDM[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesEDM.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesEDM[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersFLA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersFLA[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersFLA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersFLA[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersFLA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersFLA[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersFLA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersFLA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersFLA[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersFLA[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersFLA[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersFLA[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersFLA[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersFLA[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersFLA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersFLA[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersFLA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersFLA[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersFLA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersFLA[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersFLA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersFLA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersFLA[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersFLA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersFLA[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersFLA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersFLA[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersFLA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersFLA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersFLA[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersFLA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersFLA[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersFLA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersFLA[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersFLA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesFLA.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesFLA[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersLAK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersLAK[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersLAK[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersLAK[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersLAK[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersLAK[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersLAK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersLAK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersLAK[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersLAK[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersLAK[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersLAK[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersLAK[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersLAK[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersLAK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersLAK[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersLAK[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersLAK[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersLAK[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersLAK[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersLAK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersLAK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersLAK[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersLAK[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersLAK[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersLAK[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersLAK[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersLAK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersLAK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersLAK[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersLAK[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersLAK[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersLAK[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersLAK[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersLAK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesLAK.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesLAK[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MIN") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMIN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMIN[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersMIN[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMIN[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersMIN[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMIN[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersMIN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMIN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMIN[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersMIN[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMIN[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersMIN[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMIN[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersMIN[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMIN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMIN[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersMIN[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMIN[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersMIN[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMIN[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersMIN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMIN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMIN[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersMIN[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMIN[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersMIN[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMIN[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersMIN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMIN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMIN[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersMIN[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMIN[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersMIN[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMIN[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersMIN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesMIN.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesMIN[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMON.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMON[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMON[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMON[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMON.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMON[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMON[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMON[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMON.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMON[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMON[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMON[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMON.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMON[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMON[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMON[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersMON.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersMON[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersMON[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersMON[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersMON[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesMON.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesMON[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNAS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNAS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNAS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNAS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNAS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNAS[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersNAS[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNAS[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersNAS[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNAS[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersNAS[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNAS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNAS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNAS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNAS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNAS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNAS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNAS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNAS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNAS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNAS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNAS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNAS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNAS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNAS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNAS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesNAS.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesNAS[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNJD.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNJD[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNJD[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNJD[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNJD[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNJD[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNJD[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNJD.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNJD[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersNJD[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNJD[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersNJD[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNJD[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersNJD[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNJD.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNJD[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNJD[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNJD[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNJD[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNJD[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNJD[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNJD.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNJD[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNJD[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNJD[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNJD[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNJD[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNJD[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNJD.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNJD[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNJD[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNJD[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNJD[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNJD[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNJD[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesNJD.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesNJD[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNYI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNYI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNYI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYI[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersNYI[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYI[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersNYI[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYI[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersNYI[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNYI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNYI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNYI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNYI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNYI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNYI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNYI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNYI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNYI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesNYI.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesNYI[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYR[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNYR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYR[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNYR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYR[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersNYR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYR[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersNYR[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYR[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersNYR[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYR[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersNYR[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYR[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNYR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYR[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNYR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYR[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersNYR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYR[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNYR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYR[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNYR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYR[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersNYR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersNYR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersNYR[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNYR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersNYR[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNYR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersNYR[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersNYR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesNYR.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesNYR[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersOTT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersOTT[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersOTT[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersOTT[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersOTT[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersOTT[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersOTT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersOTT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersOTT[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersOTT[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersOTT[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersOTT[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersOTT[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersOTT[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersOTT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersOTT[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersOTT[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersOTT[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersOTT[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersOTT[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersOTT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersOTT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersOTT[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersOTT[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersOTT[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersOTT[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersOTT[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersOTT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersOTT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersOTT[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersOTT[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersOTT[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersOTT[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersOTT[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersOTT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesOTT.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesOTT[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPHI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersPHI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPHI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersPHI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPHI[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersPHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPHI[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersPHI[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPHI[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersPHI[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPHI[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersPHI[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPHI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersPHI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPHI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersPHI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPHI[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersPHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPHI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersPHI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPHI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersPHI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPHI[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersPHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPHI.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPHI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersPHI[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPHI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersPHI[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPHI[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersPHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesPHI.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesPHI[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPIT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPIT[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersPIT[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPIT[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersPIT[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPIT[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersPIT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPIT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPIT[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersPIT[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPIT[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersPIT[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPIT[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersPIT[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPIT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPIT[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersPIT[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPIT[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersPIT[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPIT[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersPIT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPIT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPIT[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersPIT[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPIT[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersPIT[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPIT[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersPIT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersPIT.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersPIT[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersPIT[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersPIT[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersPIT[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersPIT[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersPIT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesPIT.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesPIT[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSTL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSTL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersSTL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSTL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersSTL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSTL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersSTL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSTL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSTL[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersSTL[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSTL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersSTL[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSTL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersSTL[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSTL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSTL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersSTL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSTL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersSTL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSTL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersSTL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSTL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSTL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersSTL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSTL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersSTL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSTL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersSTL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSTL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSTL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersSTL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSTL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersSTL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSTL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersSTL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesSTL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesSTL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSJS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSJS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersSJS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSJS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersSJS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSJS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersSJS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSJS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSJS[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersSJS[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSJS[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersSJS[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSJS[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersSJS[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSJS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSJS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersSJS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSJS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersSJS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSJS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersSJS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSJS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSJS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersSJS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSJS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersSJS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSJS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersSJS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSJS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSJS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersSJS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSJS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersSJS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSJS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersSJS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesSJS.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesSJS[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SEA") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSEA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSEA[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersSEA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSEA[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersSEA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSEA[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersSEA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSEA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSEA[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersSEA[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSEA[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersSEA[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSEA[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersSEA[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSEA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSEA[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersSEA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSEA[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersSEA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSEA[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersSEA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSEA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSEA[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersSEA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSEA[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersSEA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSEA[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersSEA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersSEA.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersSEA[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersSEA[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersSEA[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersSEA[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersSEA[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersSEA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesSEA.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesSEA[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTBL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTBL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersTBL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTBL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersTBL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTBL[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersTBL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTBL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTBL[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersTBL[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTBL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersTBL[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTBL[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersTBL[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTBL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTBL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersTBL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTBL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersTBL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTBL[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersTBL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTBL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTBL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersTBL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTBL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersTBL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTBL[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersTBL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTBL.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTBL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersTBL[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTBL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersTBL[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTBL[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersTBL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesTBL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesTBL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTOR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTOR[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersTOR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTOR[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersTOR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTOR[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersTOR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTOR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTOR[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersTOR[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTOR[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersTOR[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTOR[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersTOR[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTOR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTOR[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersTOR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTOR[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersTOR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTOR[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersTOR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTOR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTOR[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersTOR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTOR[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersTOR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTOR[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersTOR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersTOR.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersTOR[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersTOR[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersTOR[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersTOR[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersTOR[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersTOR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesTOR.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesTOR[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVAN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVAN[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersVAN[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVAN[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersVAN[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVAN[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersVAN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVAN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVAN[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersVAN[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVAN[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersVAN[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVAN[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersVAN[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVAN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVAN[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersVAN[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVAN[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersVAN[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVAN[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersVAN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVAN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVAN[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersVAN[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVAN[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersVAN[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVAN[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersVAN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVAN.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVAN[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersVAN[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVAN[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersVAN[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVAN[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersVAN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesVAN.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesVAN[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VGK") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVGK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVGK[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersVGK[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVGK[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersVGK[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVGK[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersVGK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVGK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVGK[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersVGK[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVGK[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersVGK[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVGK[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersVGK[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVGK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVGK[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersVGK[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVGK[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersVGK[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVGK[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersVGK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVGK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVGK[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersVGK[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVGK[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersVGK[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVGK[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersVGK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersVGK.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersVGK[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersVGK[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersVGK[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersVGK[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersVGK[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersVGK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesVGK.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesVGK[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWAS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersWAS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWAS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersWAS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWAS[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersWAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWAS[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersWAS[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWAS[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersWAS[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWAS[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersWAS[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWAS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersWAS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWAS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersWAS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWAS[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersWAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWAS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersWAS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWAS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersWAS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWAS[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersWAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWAS.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWAS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersWAS[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWAS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersWAS[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWAS[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersWAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesWAS.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesWAS[Index]);
					}
				}
			}
			
			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWPG.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWPG[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersWPG[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWPG[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersWPG[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWPG[Index]] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.SkatersWPG[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWPG.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWPG[Index]] == "C") {
							PlayerListFullC.Add(PlayerDatabase.SkatersWPG[Index]);
						}

						// if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWPG[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersWPG[Index]);
						// }

						// if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWPG[Index]] == "C") {
						// 	PlayerListFullC.Add(PlayerDatabase.SkatersWPG[Index]);
						// }
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWPG.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWPG[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersWPG[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWPG[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersWPG[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWPG[Index]] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.SkatersWPG[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWPG.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWPG[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersWPG[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWPG[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersWPG[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWPG[Index]] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.SkatersWPG[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.SkatersWPG.Length; Index++) {
						if (StatsPosA.PlayerStatsPosA[PlayerDatabase.SkatersWPG[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersWPG[Index]);
						}

						if (StatsPosB.PlayerStatsPosB[PlayerDatabase.SkatersWPG[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersWPG[Index]);
						}

						if (StatsPosC.PlayerStatsPosC[PlayerDatabase.SkatersWPG[Index]] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.SkatersWPG[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.GoaliesWPG.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.GoaliesWPG[Index]);
					}
				}
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			// Gather Franchise Player Lists
			if (PlayerDatabase.PlayerChosenTeam == "ANA") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersANA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersANA[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersANA[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersANA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersANA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersANA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersANA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersANA[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersANA[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersANA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersANA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersANA[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersANA[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersANA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersANA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersANA[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersANA[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersANA[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersANA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesANA.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesANA[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "ATL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersATL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersATL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersATL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersATL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersATL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersATL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersATL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersATL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersATL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersATL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersATL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersATL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersATL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersATL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersATL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersATL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersATL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersATL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersATL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesATL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesATL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BOS") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBOS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBOS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBOS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBOS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBOS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersBOS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersBOS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesBOS.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesBOS[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "BUF") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBUF.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBUF.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBUF.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBUF.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersBUF.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersBUF[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersBUF[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesBUF.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesBUF[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesCAL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesCAL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CAR") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesCAR.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesCAR[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CHI") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesCHI.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesCHI[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "COL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCOL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCOL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCOL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCOL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCOL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCOL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCOL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesCOL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesCOL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "CBJ") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCBJ.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCBJ.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCBJ.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCBJ.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersCBJ.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersCBJ[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersCBJ[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesCBJ.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesCBJ[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DAL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDAL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersDAL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersDAL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesDAL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesDAL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "DET") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDET.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersDET[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersDET[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersDET[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDET.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersDET[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDET.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersDET[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersDET[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersDET[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDET.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersDET[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersDET[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersDET[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersDET.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersDET[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersDET[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersDET[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersDET[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesDET.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesDET[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "EDM") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersEDM.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersEDM.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersEDM.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersEDM.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersEDM.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersEDM[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersEDM[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesEDM.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesEDM[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "FLA") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersFLA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersFLA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersFLA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersFLA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersFLA.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersFLA[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersFLA[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesFLA.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesFLA[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "HAR") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersHAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersHAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersHAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersHAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersHAR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersHAR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersHAR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesHAR.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesHAR[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "LAK") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersLAK.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersLAK.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersLAK.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersLAK.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersLAK.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersLAK[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersLAK[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesLAK.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesLAK[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNS") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMNS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersMNS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesMNS.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesMNS[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MNW") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNW.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNW.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNW.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNW.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMNW.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMNW[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersMNW[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesMNW.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesMNW[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "MON") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMON.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersMON[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersMON[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMON.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMON.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersMON[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersMON[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMON.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersMON[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersMON[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersMON.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersMON[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersMON[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersMON[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersMON[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesMON.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesMON[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NAS") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesNAS.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesNAS[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NJD") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNJD.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNJD.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNJD.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNJD.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNJD.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNJD[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNJD[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesNJD.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesNJD[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYI") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNYI[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNYI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesNYI.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesNYI[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "NYR") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersNYR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersNYR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersNYR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesNYR.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesNYR[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "OTT") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersOTT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersOTT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersOTT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersOTT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersOTT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersOTT[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersOTT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesOTT.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesOTT[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHI") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHI.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPHI[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersPHI[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesPHI.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesPHI[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PHO") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHO.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHO.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHO.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHO.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPHO.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPHO[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersPHO[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesPHO.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesPHO[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "PIT") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPIT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPIT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPIT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPIT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersPIT.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersPIT[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersPIT[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesPIT.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesPIT[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "QUE") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersQUE.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersQUE.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersQUE.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersQUE.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersQUE.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersQUE[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersQUE[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesQUE.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesQUE[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "STL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSTL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSTL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSTL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSTL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSTL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersSTL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersSTL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesSTL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesSTL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "SJS") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSJS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSJS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSJS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSJS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersSJS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersSJS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersSJS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesSJS.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesSJS[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TBL") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTBL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTBL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTBL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTBL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTBL.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersTBL[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersTBL[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesTBL.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesTBL[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "TOR") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTOR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTOR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTOR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTOR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersTOR.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersTOR[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersTOR[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesTOR.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesTOR[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "VAN") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersVAN.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersVAN.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersVAN.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersVAN.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersVAN.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersVAN[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersVAN[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesVAN.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesVAN[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WAS") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWAS.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersWAS[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersWAS[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesWAS.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesWAS[Index]);
					}
				}
			}

			else if (PlayerDatabase.PlayerChosenTeam == "WPG") {
				if (ShowingPlayerPositions == "LW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWPG.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "LW") {
							PlayerListFullLW.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "C") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWPG.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "C") {
							PlayerListFullC.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RW") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWPG.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "RW") {
							PlayerListFullRW.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "LD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWPG.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "LD") {
							PlayerListFullLD.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "RD") {
					for (int Index = 0; Index < PlayerDatabase.FrSkatersWPG.Length; Index++) {
						if (StatsPosA.FrPlayerStatsPosA[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}

						if (StatsPosB.FrPlayerStatsPosB[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}

						if (StatsPosC.FrPlayerStatsPosC[PlayerDatabase.FrSkatersWPG[Index] + PlayerDatabase.PlayerChosenTeam] == "RD") {
							PlayerListFullRD.Add(PlayerDatabase.FrSkatersWPG[Index]);
						}
					}
				}

				else if (ShowingPlayerPositions == "G") {
					for (int Index = 0; Index < PlayerDatabase.FrGoaliesWPG.Length; Index++) {
						PlayerListFullG.Add(PlayerDatabase.FrGoaliesWPG[Index]);
					}
				}
			}
		}

		// Remove Duplicates
		PlayerListLW = PlayerListFullLW.Distinct().ToList();
		PlayerListC = PlayerListFullC.Distinct().ToList();
		PlayerListRW = PlayerListFullRW.Distinct().ToList();
		PlayerListLD = PlayerListFullLD.Distinct().ToList();
		PlayerListRD = PlayerListFullRD.Distinct().ToList();
		PlayerListG = PlayerListFullG.Distinct().ToList();

		RemoveSelectedPlayers();
		RemoveSelectedGoalie();

		// Showing Player Names
		if ((ShowingPlayerPositions == "LW") && (ShowingPlayerInfoInt == 1)) {
			if (PlayerListLW.Count == 12) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText04.text = PlayerListLW[3];
				PlayerText05.text = PlayerListLW[4];
				PlayerText06.text = PlayerListLW[5];
				PlayerText07.text = PlayerListLW[6];
				PlayerText08.text = PlayerListLW[7];
				PlayerText09.text = PlayerListLW[8];
				PlayerText10.text = PlayerListLW[9];
				PlayerText11.text = PlayerListLW[10];
				PlayerText12.text = PlayerListLW[11];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = true;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = true;
			}

			else if (PlayerListLW.Count == 11) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText04.text = PlayerListLW[3];
				PlayerText05.text = PlayerListLW[4];
				PlayerText06.text = PlayerListLW[5];
				PlayerText07.text = PlayerListLW[6];
				PlayerText08.text = PlayerListLW[7];
				PlayerText09.text = PlayerListLW[8];
				PlayerText10.text = PlayerListLW[9];
				PlayerText11.text = PlayerListLW[10];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 10) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText04.text = PlayerListLW[3];
				PlayerText05.text = PlayerListLW[4];
				PlayerText06.text = PlayerListLW[5];
				PlayerText07.text = PlayerListLW[6];
				PlayerText08.text = PlayerListLW[7];
				PlayerText09.text = PlayerListLW[8];
				PlayerText10.text = PlayerListLW[9];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 9) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText04.text = PlayerListLW[3];
				PlayerText05.text = PlayerListLW[4];
				PlayerText06.text = PlayerListLW[5];
				PlayerText07.text = PlayerListLW[6];
				PlayerText08.text = PlayerListLW[7];
				PlayerText09.text = PlayerListLW[8];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 8) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText04.text = PlayerListLW[3];
				PlayerText05.text = PlayerListLW[4];
				PlayerText06.text = PlayerListLW[5];
				PlayerText07.text = PlayerListLW[6];
				PlayerText08.text = PlayerListLW[7];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 7) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText04.text = PlayerListLW[3];
				PlayerText05.text = PlayerListLW[4];
				PlayerText06.text = PlayerListLW[5];
				PlayerText07.text = PlayerListLW[6];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 6) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText04.text = PlayerListLW[3];
				PlayerText05.text = PlayerListLW[4];
				PlayerText06.text = PlayerListLW[5];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 5) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText04.text = PlayerListLW[3];
				PlayerText05.text = PlayerListLW[4];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 4) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText04.text = PlayerListLW[3];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 3) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText03.text = PlayerListLW[2];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 2) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText02.text = PlayerListLW[1];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLW.Count == 1) {
				PlayerText01.text = PlayerListLW[0];
				PlayerText01.enabled = true;
				PlayerText02.enabled = false;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = false;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}
		}

		else if ((ShowingPlayerPositions == "C") && (ShowingPlayerInfoInt == 1)) {
			if (PlayerListC.Count == 12) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText04.text = PlayerListC[3];
				PlayerText05.text = PlayerListC[4];
				PlayerText06.text = PlayerListC[5];
				PlayerText07.text = PlayerListC[6];
				PlayerText08.text = PlayerListC[7];
				PlayerText09.text = PlayerListC[8];
				PlayerText10.text = PlayerListC[9];
				PlayerText11.text = PlayerListC[10];
				PlayerText12.text = PlayerListC[11];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = true;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = true;
			}

			else if (PlayerListC.Count == 11) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText04.text = PlayerListC[3];
				PlayerText05.text = PlayerListC[4];
				PlayerText06.text = PlayerListC[5];
				PlayerText07.text = PlayerListC[6];
				PlayerText08.text = PlayerListC[7];
				PlayerText09.text = PlayerListC[8];
				PlayerText10.text = PlayerListC[9];
				PlayerText11.text = PlayerListC[10];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 10) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText04.text = PlayerListC[3];
				PlayerText05.text = PlayerListC[4];
				PlayerText06.text = PlayerListC[5];
				PlayerText07.text = PlayerListC[6];
				PlayerText08.text = PlayerListC[7];
				PlayerText09.text = PlayerListC[8];
				PlayerText10.text = PlayerListC[9];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 9) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText04.text = PlayerListC[3];
				PlayerText05.text = PlayerListC[4];
				PlayerText06.text = PlayerListC[5];
				PlayerText07.text = PlayerListC[6];
				PlayerText08.text = PlayerListC[7];
				PlayerText09.text = PlayerListC[8];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 8) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText04.text = PlayerListC[3];
				PlayerText05.text = PlayerListC[4];
				PlayerText06.text = PlayerListC[5];
				PlayerText07.text = PlayerListC[6];
				PlayerText08.text = PlayerListC[7];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 7) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText04.text = PlayerListC[3];
				PlayerText05.text = PlayerListC[4];
				PlayerText06.text = PlayerListC[5];
				PlayerText07.text = PlayerListC[6];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 6) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText04.text = PlayerListC[3];
				PlayerText05.text = PlayerListC[4];
				PlayerText06.text = PlayerListC[5];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 5) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText04.text = PlayerListC[3];
				PlayerText05.text = PlayerListC[4];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 4) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText04.text = PlayerListC[3];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 3) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText03.text = PlayerListC[2];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 2) {
				PlayerText01.text = PlayerListC[0];
				PlayerText02.text = PlayerListC[1];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListC.Count == 1) {
				PlayerText01.text = PlayerListC[0];
				PlayerText01.enabled = true;
				PlayerText02.enabled = false;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = false;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}
		}

		else if ((ShowingPlayerPositions == "RW") && (ShowingPlayerInfoInt == 1)) {
			if (PlayerListRW.Count == 12) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText04.text = PlayerListRW[3];
				PlayerText05.text = PlayerListRW[4];
				PlayerText06.text = PlayerListRW[5];
				PlayerText07.text = PlayerListRW[6];
				PlayerText08.text = PlayerListRW[7];
				PlayerText09.text = PlayerListRW[8];
				PlayerText10.text = PlayerListRW[9];
				PlayerText11.text = PlayerListRW[10];
				PlayerText12.text = PlayerListRW[11];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = true;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = true;
			}

			else if (PlayerListRW.Count == 11) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText04.text = PlayerListRW[3];
				PlayerText05.text = PlayerListRW[4];
				PlayerText06.text = PlayerListRW[5];
				PlayerText07.text = PlayerListRW[6];
				PlayerText08.text = PlayerListRW[7];
				PlayerText09.text = PlayerListRW[8];
				PlayerText10.text = PlayerListRW[9];
				PlayerText11.text = PlayerListRW[10];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 10) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText04.text = PlayerListRW[3];
				PlayerText05.text = PlayerListRW[4];
				PlayerText06.text = PlayerListRW[5];
				PlayerText07.text = PlayerListRW[6];
				PlayerText08.text = PlayerListRW[7];
				PlayerText09.text = PlayerListRW[8];
				PlayerText10.text = PlayerListRW[9];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 9) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText04.text = PlayerListRW[3];
				PlayerText05.text = PlayerListRW[4];
				PlayerText06.text = PlayerListRW[5];
				PlayerText07.text = PlayerListRW[6];
				PlayerText08.text = PlayerListRW[7];
				PlayerText09.text = PlayerListRW[8];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 8) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText04.text = PlayerListRW[3];
				PlayerText05.text = PlayerListRW[4];
				PlayerText06.text = PlayerListRW[5];
				PlayerText07.text = PlayerListRW[6];
				PlayerText08.text = PlayerListRW[7];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 7) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText04.text = PlayerListRW[3];
				PlayerText05.text = PlayerListRW[4];
				PlayerText06.text = PlayerListRW[5];
				PlayerText07.text = PlayerListRW[6];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 6) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText04.text = PlayerListRW[3];
				PlayerText05.text = PlayerListRW[4];
				PlayerText06.text = PlayerListRW[5];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 5) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText04.text = PlayerListRW[3];
				PlayerText05.text = PlayerListRW[4];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 4) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText04.text = PlayerListRW[3];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 3) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText03.text = PlayerListRW[2];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 2) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText02.text = PlayerListRW[1];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRW.Count == 1) {
				PlayerText01.text = PlayerListRW[0];
				PlayerText01.enabled = true;
				PlayerText02.enabled = false;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = false;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}
		}

		else if ((ShowingPlayerPositions == "LD") && (ShowingPlayerInfoInt == 1)) {
			if (PlayerListLD.Count == 12) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText04.text = PlayerListLD[3];
				PlayerText05.text = PlayerListLD[4];
				PlayerText06.text = PlayerListLD[5];
				PlayerText07.text = PlayerListLD[6];
				PlayerText08.text = PlayerListLD[7];
				PlayerText09.text = PlayerListLD[8];
				PlayerText10.text = PlayerListLD[9];
				PlayerText11.text = PlayerListLD[10];
				PlayerText12.text = PlayerListLD[11];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = true;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = true;
			}

			else if (PlayerListLD.Count == 11) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText04.text = PlayerListLD[3];
				PlayerText05.text = PlayerListLD[4];
				PlayerText06.text = PlayerListLD[5];
				PlayerText07.text = PlayerListLD[6];
				PlayerText08.text = PlayerListLD[7];
				PlayerText09.text = PlayerListLD[8];
				PlayerText10.text = PlayerListLD[9];
				PlayerText11.text = PlayerListLD[10];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 10) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText04.text = PlayerListLD[3];
				PlayerText05.text = PlayerListLD[4];
				PlayerText06.text = PlayerListLD[5];
				PlayerText07.text = PlayerListLD[6];
				PlayerText08.text = PlayerListLD[7];
				PlayerText09.text = PlayerListLD[8];
				PlayerText10.text = PlayerListLD[9];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 9) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText04.text = PlayerListLD[3];
				PlayerText05.text = PlayerListLD[4];
				PlayerText06.text = PlayerListLD[5];
				PlayerText07.text = PlayerListLD[6];
				PlayerText08.text = PlayerListLD[7];
				PlayerText09.text = PlayerListLD[8];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 8) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText04.text = PlayerListLD[3];
				PlayerText05.text = PlayerListLD[4];
				PlayerText06.text = PlayerListLD[5];
				PlayerText07.text = PlayerListLD[6];
				PlayerText08.text = PlayerListLD[7];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 7) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText04.text = PlayerListLD[3];
				PlayerText05.text = PlayerListLD[4];
				PlayerText06.text = PlayerListLD[5];
				PlayerText07.text = PlayerListLD[6];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 6) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText04.text = PlayerListLD[3];
				PlayerText05.text = PlayerListLD[4];
				PlayerText06.text = PlayerListLD[5];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 5) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText04.text = PlayerListLD[3];
				PlayerText05.text = PlayerListLD[4];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 4) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText04.text = PlayerListLD[3];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 3) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText03.text = PlayerListLD[2];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 2) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText02.text = PlayerListLD[1];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListLD.Count == 1) {
				PlayerText01.text = PlayerListLD[0];
				PlayerText01.enabled = true;
				PlayerText02.enabled = false;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = false;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}
		}

		else if ((ShowingPlayerPositions == "RD") && (ShowingPlayerInfoInt == 1)) {
			if (PlayerListRD.Count == 12) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText04.text = PlayerListRD[3];
				PlayerText05.text = PlayerListRD[4];
				PlayerText06.text = PlayerListRD[5];
				PlayerText07.text = PlayerListRD[6];
				PlayerText08.text = PlayerListRD[7];
				PlayerText09.text = PlayerListRD[8];
				PlayerText10.text = PlayerListRD[9];
				PlayerText11.text = PlayerListRD[10];
				PlayerText12.text = PlayerListRD[11];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = true;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = true;
			}

			else if (PlayerListRD.Count == 11) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText04.text = PlayerListRD[3];
				PlayerText05.text = PlayerListRD[4];
				PlayerText06.text = PlayerListRD[5];
				PlayerText07.text = PlayerListRD[6];
				PlayerText08.text = PlayerListRD[7];
				PlayerText09.text = PlayerListRD[8];
				PlayerText10.text = PlayerListRD[9];
				PlayerText11.text = PlayerListRD[10];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = true;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = true;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 10) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText04.text = PlayerListRD[3];
				PlayerText05.text = PlayerListRD[4];
				PlayerText06.text = PlayerListRD[5];
				PlayerText07.text = PlayerListRD[6];
				PlayerText08.text = PlayerListRD[7];
				PlayerText09.text = PlayerListRD[8];
				PlayerText10.text = PlayerListRD[9];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = true;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = true;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 9) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText04.text = PlayerListRD[3];
				PlayerText05.text = PlayerListRD[4];
				PlayerText06.text = PlayerListRD[5];
				PlayerText07.text = PlayerListRD[6];
				PlayerText08.text = PlayerListRD[7];
				PlayerText09.text = PlayerListRD[8];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = true;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = true;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 8) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText04.text = PlayerListRD[3];
				PlayerText05.text = PlayerListRD[4];
				PlayerText06.text = PlayerListRD[5];
				PlayerText07.text = PlayerListRD[6];
				PlayerText08.text = PlayerListRD[7];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = true;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = true;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 7) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText04.text = PlayerListRD[3];
				PlayerText05.text = PlayerListRD[4];
				PlayerText06.text = PlayerListRD[5];
				PlayerText07.text = PlayerListRD[6];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = true;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = true;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 6) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText04.text = PlayerListRD[3];
				PlayerText05.text = PlayerListRD[4];
				PlayerText06.text = PlayerListRD[5];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = true;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = true;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 5) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText04.text = PlayerListRD[3];
				PlayerText05.text = PlayerListRD[4];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = true;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = true;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 4) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText04.text = PlayerListRD[3];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = true;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = true;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 3) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText03.text = PlayerListRD[2];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = true;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = true;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 2) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText02.text = PlayerListRD[1];
				PlayerText01.enabled = true;
				PlayerText02.enabled = true;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = true;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}

			else if (PlayerListRD.Count == 1) {
				PlayerText01.text = PlayerListRD[0];
				PlayerText01.enabled = true;
				PlayerText02.enabled = false;
				PlayerText03.enabled = false;
				PlayerText04.enabled = false;
				PlayerText05.enabled = false;
				PlayerText06.enabled = false;
				PlayerText07.enabled = false;
				PlayerText08.enabled = false;
				PlayerText09.enabled = false;
				PlayerText10.enabled = false;
				PlayerText11.enabled = false;
				PlayerText12.enabled = false;
				PlayerStats01.enabled = true;
				PlayerStats02.enabled = false;
				PlayerStats03.enabled = false;
				PlayerStats04.enabled = false;
				PlayerStats05.enabled = false;
				PlayerStats06.enabled = false;
				PlayerStats07.enabled = false;
				PlayerStats08.enabled = false;
				PlayerStats09.enabled = false;
				PlayerStats10.enabled = false;
				PlayerStats11.enabled = false;
				PlayerStats12.enabled = false;
			}
		}

		else if ((ShowingPlayerPositions == "G") && (ShowingPlayerInfoInt == 3)) {
			if (PlayerListG.Count == 7) {
				GoalieText01.text = PlayerListG[0];
				GoalieText02.text = PlayerListG[1];
				GoalieText03.text = PlayerListG[2];
				GoalieText04.text = PlayerListG[3];
				GoalieText05.text = PlayerListG[4];
				GoalieText06.text = PlayerListG[5];
				GoalieText07.text = PlayerListG[6];
				GoalieText01.enabled = true;
				GoalieText02.enabled = true;
				GoalieText03.enabled = true;
				GoalieText04.enabled = true;
				GoalieText05.enabled = true;
				GoalieText06.enabled = true;
				GoalieText07.enabled = true;
				GoalieStats01.enabled = true;
				GoalieStats02.enabled = true;
				GoalieStats03.enabled = true;
				GoalieStats04.enabled = true;
				GoalieStats05.enabled = true;
				GoalieStats06.enabled = true;
				GoalieStats07.enabled = true;
			}

			else if (PlayerListG.Count == 6) {
				GoalieText01.text = PlayerListG[0];
				GoalieText02.text = PlayerListG[1];
				GoalieText03.text = PlayerListG[2];
				GoalieText04.text = PlayerListG[3];
				GoalieText05.text = PlayerListG[4];
				GoalieText06.text = PlayerListG[5];
				GoalieText01.enabled = true;
				GoalieText02.enabled = true;
				GoalieText03.enabled = true;
				GoalieText04.enabled = true;
				GoalieText05.enabled = true;
				GoalieText06.enabled = true;
				GoalieText07.enabled = false;
				GoalieStats01.enabled = true;
				GoalieStats02.enabled = true;
				GoalieStats03.enabled = true;
				GoalieStats04.enabled = true;
				GoalieStats05.enabled = true;
				GoalieStats06.enabled = true;
				GoalieStats07.enabled = false;
			}

			else if (PlayerListG.Count == 5) {
				GoalieText01.text = PlayerListG[0];
				GoalieText02.text = PlayerListG[1];
				GoalieText03.text = PlayerListG[2];
				GoalieText04.text = PlayerListG[3];
				GoalieText05.text = PlayerListG[4];
				GoalieText01.enabled = true;
				GoalieText02.enabled = true;
				GoalieText03.enabled = true;
				GoalieText04.enabled = true;
				GoalieText05.enabled = true;
				GoalieText06.enabled = false;
				GoalieText07.enabled = false;
				GoalieStats01.enabled = true;
				GoalieStats02.enabled = true;
				GoalieStats03.enabled = true;
				GoalieStats04.enabled = true;
				GoalieStats05.enabled = true;
				GoalieStats06.enabled = false;
				GoalieStats07.enabled = false;
			}

			else if (PlayerListG.Count == 4) {
				GoalieText01.text = PlayerListG[0];
				GoalieText02.text = PlayerListG[1];
				GoalieText03.text = PlayerListG[2];
				GoalieText04.text = PlayerListG[3];
				GoalieText01.enabled = true;
				GoalieText02.enabled = true;
				GoalieText03.enabled = true;
				GoalieText04.enabled = true;
				GoalieText05.enabled = false;
				GoalieText06.enabled = false;
				GoalieText07.enabled = false;
				GoalieStats01.enabled = true;
				GoalieStats02.enabled = true;
				GoalieStats03.enabled = true;
				GoalieStats04.enabled = true;
				GoalieStats05.enabled = false;
				GoalieStats06.enabled = false;
				GoalieStats07.enabled = false;
			}

			else if (PlayerListG.Count == 3) {
				GoalieText01.text = PlayerListG[0];
				GoalieText02.text = PlayerListG[1];
				GoalieText03.text = PlayerListG[2];
				GoalieText01.enabled = true;
				GoalieText02.enabled = true;
				GoalieText03.enabled = true;
				GoalieText04.enabled = false;
				GoalieText05.enabled = false;
				GoalieText06.enabled = false;
				GoalieText07.enabled = false;
				GoalieStats01.enabled = true;
				GoalieStats02.enabled = true;
				GoalieStats03.enabled = true;
				GoalieStats04.enabled = false;
				GoalieStats05.enabled = false;
				GoalieStats06.enabled = false;
				GoalieStats07.enabled = false;
			}

			else if (PlayerListG.Count == 2) {
				GoalieText01.text = PlayerListG[0];
				GoalieText02.text = PlayerListG[1];
				GoalieText01.enabled = true;
				GoalieText02.enabled = true;
				GoalieText03.enabled = false;
				GoalieText04.enabled = false;
				GoalieText05.enabled = false;
				GoalieText06.enabled = false;
				GoalieText07.enabled = false;
				GoalieStats01.enabled = true;
				GoalieStats02.enabled = true;
				GoalieStats03.enabled = false;
				GoalieStats04.enabled = false;
				GoalieStats05.enabled = false;
				GoalieStats06.enabled = false;
				GoalieStats07.enabled = false;
			}

			else if (PlayerListG.Count == 1) {
				GoalieText01.text = PlayerListG[0];
				GoalieText01.enabled = true;
				GoalieText02.enabled = false;
				GoalieText03.enabled = false;
				GoalieText04.enabled = false;
				GoalieText05.enabled = false;
				GoalieText06.enabled = false;
				GoalieText07.enabled = false;
				GoalieStats01.enabled = true;
				GoalieStats02.enabled = false;
				GoalieStats03.enabled = false;
				GoalieStats04.enabled = false;
				GoalieStats05.enabled = false;
				GoalieStats06.enabled = false;
				GoalieStats07.enabled = false;
			}
		}

		UpdatePlayerSelectButtons();
	}

	public void RemoveSelectedPlayers() {
		// P1LW1
		if ((PlayerDatabase.P1LW1 != "None") && (PlayerDatabase.P1LW1 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1LW1)) {
				PlayerListLW.Remove(PlayerDatabase.P1LW1);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1LW1)) {
				PlayerListC.Remove(PlayerDatabase.P1LW1);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1LW1)) {
				PlayerListRW.Remove(PlayerDatabase.P1LW1);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1LW1)) {
				PlayerListLD.Remove(PlayerDatabase.P1LW1);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1LW1)) {
				PlayerListRD.Remove(PlayerDatabase.P1LW1);
			}
		}

		// P1LW2
		if ((PlayerDatabase.P1LW2 != "None") && (PlayerDatabase.P1LW2 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1LW2)) {
				PlayerListLW.Remove(PlayerDatabase.P1LW2);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1LW2)) {
				PlayerListC.Remove(PlayerDatabase.P1LW2);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1LW2)) {
				PlayerListRW.Remove(PlayerDatabase.P1LW2);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1LW2)) {
				PlayerListLD.Remove(PlayerDatabase.P1LW2);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1LW2)) {
				PlayerListRD.Remove(PlayerDatabase.P1LW2);
			}
		}

		// P1LW3
		if ((PlayerDatabase.P1LW3 != "None") && (PlayerDatabase.P1LW3 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1LW3)) {
				PlayerListLW.Remove(PlayerDatabase.P1LW3);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1LW3)) {
				PlayerListC.Remove(PlayerDatabase.P1LW3);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1LW3)) {
				PlayerListRW.Remove(PlayerDatabase.P1LW3);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1LW3)) {
				PlayerListLD.Remove(PlayerDatabase.P1LW3);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1LW3)) {
				PlayerListRD.Remove(PlayerDatabase.P1LW3);
			}
		}

		// P1LW4
		if ((PlayerDatabase.P1LW4 != "None") && (PlayerDatabase.P1LW4 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1LW4)) {
				PlayerListLW.Remove(PlayerDatabase.P1LW4);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1LW4)) {
				PlayerListC.Remove(PlayerDatabase.P1LW4);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1LW4)) {
				PlayerListRW.Remove(PlayerDatabase.P1LW4);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1LW4)) {
				PlayerListLD.Remove(PlayerDatabase.P1LW4);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1LW4)) {
				PlayerListRD.Remove(PlayerDatabase.P1LW4);
			}
		}

		// P1C1
		if ((PlayerDatabase.P1C1 != "None") && (PlayerDatabase.P1C1 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1C1)) {
				PlayerListLW.Remove(PlayerDatabase.P1C1);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1C1)) {
				PlayerListC.Remove(PlayerDatabase.P1C1);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1C1)) {
				PlayerListRW.Remove(PlayerDatabase.P1C1);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1C1)) {
				PlayerListLD.Remove(PlayerDatabase.P1C1);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1C1)) {
				PlayerListRD.Remove(PlayerDatabase.P1C1);
			}
		}

		// P1C2
		if ((PlayerDatabase.P1C2 != "None") && (PlayerDatabase.P1C2 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1C2)) {
				PlayerListLW.Remove(PlayerDatabase.P1C2);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1C2)) {
				PlayerListC.Remove(PlayerDatabase.P1C2);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1C2)) {
				PlayerListRW.Remove(PlayerDatabase.P1C2);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1C2)) {
				PlayerListLD.Remove(PlayerDatabase.P1C2);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1C2)) {
				PlayerListRD.Remove(PlayerDatabase.P1C2);
			}
		}

		// P1C3
		if ((PlayerDatabase.P1C3 != "None") && (PlayerDatabase.P1C3 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1C3)) {
				PlayerListLW.Remove(PlayerDatabase.P1C3);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1C3)) {
				PlayerListC.Remove(PlayerDatabase.P1C3);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1C3)) {
				PlayerListRW.Remove(PlayerDatabase.P1C3);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1C3)) {
				PlayerListLD.Remove(PlayerDatabase.P1C3);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1C3)) {
				PlayerListRD.Remove(PlayerDatabase.P1C3);
			}
		}

		// P1C4
		if ((PlayerDatabase.P1C4 != "None") && (PlayerDatabase.P1C4 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1C4)) {
				PlayerListLW.Remove(PlayerDatabase.P1C4);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1C4)) {
				PlayerListC.Remove(PlayerDatabase.P1C4);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1C4)) {
				PlayerListRW.Remove(PlayerDatabase.P1C4);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1C4)) {
				PlayerListLD.Remove(PlayerDatabase.P1C4);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1C4)) {
				PlayerListRD.Remove(PlayerDatabase.P1C4);
			}
		}

		// P1RW1
		if ((PlayerDatabase.P1RW1 != "None") && (PlayerDatabase.P1RW1 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1RW1)) {
				PlayerListLW.Remove(PlayerDatabase.P1RW1);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1RW1)) {
				PlayerListC.Remove(PlayerDatabase.P1RW1);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1RW1)) {
				PlayerListRW.Remove(PlayerDatabase.P1RW1);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1RW1)) {
				PlayerListLD.Remove(PlayerDatabase.P1RW1);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1RW1)) {
				PlayerListRD.Remove(PlayerDatabase.P1RW1);
			}
		}

		// P1RW2
		if ((PlayerDatabase.P1RW2 != "None") && (PlayerDatabase.P1RW2 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1RW2)) {
				PlayerListLW.Remove(PlayerDatabase.P1RW2);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1RW2)) {
				PlayerListC.Remove(PlayerDatabase.P1RW2);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1RW2)) {
				PlayerListRW.Remove(PlayerDatabase.P1RW2);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1RW2)) {
				PlayerListLD.Remove(PlayerDatabase.P1RW2);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1RW2)) {
				PlayerListRD.Remove(PlayerDatabase.P1RW2);
			}
		}

		// P1RW3
		if ((PlayerDatabase.P1RW3 != "None") && (PlayerDatabase.P1RW3 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1RW3)) {
				PlayerListLW.Remove(PlayerDatabase.P1RW3);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1RW3)) {
				PlayerListC.Remove(PlayerDatabase.P1RW3);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1RW3)) {
				PlayerListRW.Remove(PlayerDatabase.P1RW3);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1RW3)) {
				PlayerListLD.Remove(PlayerDatabase.P1RW3);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1RW3)) {
				PlayerListRD.Remove(PlayerDatabase.P1RW3);
			}
		}

		// P1RW4
		if ((PlayerDatabase.P1RW4 != "None") && (PlayerDatabase.P1RW4 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1RW4)) {
				PlayerListLW.Remove(PlayerDatabase.P1RW4);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1RW4)) {
				PlayerListC.Remove(PlayerDatabase.P1RW4);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1RW4)) {
				PlayerListRW.Remove(PlayerDatabase.P1RW4);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1RW4)) {
				PlayerListLD.Remove(PlayerDatabase.P1RW4);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1RW4)) {
				PlayerListRD.Remove(PlayerDatabase.P1RW4);
			}
		}

		// P1LD1
		if ((PlayerDatabase.P1LD1 != "None") && (PlayerDatabase.P1LD1 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1LD1)) {
				PlayerListLW.Remove(PlayerDatabase.P1LD1);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1LD1)) {
				PlayerListC.Remove(PlayerDatabase.P1LD1);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1LD1)) {
				PlayerListRW.Remove(PlayerDatabase.P1LD1);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1LD1)) {
				PlayerListLD.Remove(PlayerDatabase.P1LD1);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1LD1)) {
				PlayerListRD.Remove(PlayerDatabase.P1LD1);
			}
		}

		// P1LD2
		if ((PlayerDatabase.P1LD2 != "None") && (PlayerDatabase.P1LD2 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1LD2)) {
				PlayerListLW.Remove(PlayerDatabase.P1LD2);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1LD2)) {
				PlayerListC.Remove(PlayerDatabase.P1LD2);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1LD2)) {
				PlayerListRW.Remove(PlayerDatabase.P1LD2);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1LD2)) {
				PlayerListLD.Remove(PlayerDatabase.P1LD2);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1LD2)) {
				PlayerListRD.Remove(PlayerDatabase.P1LD2);
			}
		}

		// P1LD3
		if ((PlayerDatabase.P1LD3 != "None") && (PlayerDatabase.P1LD3 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1LD3)) {
				PlayerListLW.Remove(PlayerDatabase.P1LD3);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1LD3)) {
				PlayerListC.Remove(PlayerDatabase.P1LD3);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1LD3)) {
				PlayerListRW.Remove(PlayerDatabase.P1LD3);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1LD3)) {
				PlayerListLD.Remove(PlayerDatabase.P1LD3);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1LD3)) {
				PlayerListRD.Remove(PlayerDatabase.P1LD3);
			}
		}

		// P1RD1
		if ((PlayerDatabase.P1RD1 != "None") && (PlayerDatabase.P1RD1 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1RD1)) {
				PlayerListLW.Remove(PlayerDatabase.P1RD1);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1RD1)) {
				PlayerListC.Remove(PlayerDatabase.P1RD1);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1RD1)) {
				PlayerListRW.Remove(PlayerDatabase.P1RD1);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1RD1)) {
				PlayerListLD.Remove(PlayerDatabase.P1RD1);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1RD1)) {
				PlayerListRD.Remove(PlayerDatabase.P1RD1);
			}
		}

		// P1RD2
		if ((PlayerDatabase.P1RD2 != "None") && (PlayerDatabase.P1RD2 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1RD2)) {
				PlayerListLW.Remove(PlayerDatabase.P1RD2);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1RD2)) {
				PlayerListC.Remove(PlayerDatabase.P1RD2);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1RD2)) {
				PlayerListRW.Remove(PlayerDatabase.P1RD2);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1RD2)) {
				PlayerListLD.Remove(PlayerDatabase.P1RD2);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1RD2)) {
				PlayerListRD.Remove(PlayerDatabase.P1RD2);
			}
		}

		// P1RD3
		if ((PlayerDatabase.P1RD3 != "None") && (PlayerDatabase.P1RD3 != "")) {
			if (PlayerListLW.Contains(PlayerDatabase.P1RD3)) {
				PlayerListLW.Remove(PlayerDatabase.P1RD3);
			}

			if (PlayerListC.Contains(PlayerDatabase.P1RD3)) {
				PlayerListC.Remove(PlayerDatabase.P1RD3);
			}

			if (PlayerListRW.Contains(PlayerDatabase.P1RD3)) {
				PlayerListRW.Remove(PlayerDatabase.P1RD3);
			}

			if (PlayerListLD.Contains(PlayerDatabase.P1RD3)) {
				PlayerListLD.Remove(PlayerDatabase.P1RD3);
			}

			if (PlayerListRD.Contains(PlayerDatabase.P1RD3)) {
				PlayerListRD.Remove(PlayerDatabase.P1RD3);
			}
		}
	}

	public void RemoveSelectedGoalie() {
		if ((PlayerDatabase.P1G != "None") && (PlayerDatabase.P1G != "")) {
			if (PlayerListG.Contains(PlayerDatabase.P1G)) {
				PlayerListG.Remove(PlayerDatabase.P1G);
			}
		}
	}

	public void UpdatingPlayerInfo() {
		PlayerNameTitle.text = ShowingPlayerInfoString;

		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (ShowingPlayerInfoInt == 2) {
				OffenseText.text = "Offense: " + StatsOffense.PlayerStatsOffense[ShowingPlayerInfoString];
				DefenseText.text = "Defense: " + StatsDefense.PlayerStatsDefense[ShowingPlayerInfoString];
				PenaltyText.text = "Penalty: " + StatsPenalty.PlayerStatsPenalty[ShowingPlayerInfoString];
				BreakawayText.text = "Breakaway: " + StatsBreakaway.PlayerStatsBreakaway[ShowingPlayerInfoString];
				IntimidationText.text = "Intimidation: " + StatsIntimidation.PlayerStatsIntimidation[ShowingPlayerInfoString];
				FaceoffText.text = "Faceoff: " + StatsFaceoff.PlayerStatsFaceoff[ShowingPlayerInfoString];

				if ((StatsPosA.PlayerStatsPosA[ShowingPlayerInfoString] != "") && (StatsPosB.PlayerStatsPosB[ShowingPlayerInfoString] == "") && (StatsPosC.PlayerStatsPosC[ShowingPlayerInfoString] == "")) {
					PositionsText.text = "Positions: " + StatsPosA.PlayerStatsPosA[ShowingPlayerInfoString];
				}

				else if ((StatsPosA.PlayerStatsPosA[ShowingPlayerInfoString] != "") && (StatsPosB.PlayerStatsPosB[ShowingPlayerInfoString] != "") && (StatsPosC.PlayerStatsPosC[ShowingPlayerInfoString] == "")) {
					PositionsText.text = "Positions: " + StatsPosA.PlayerStatsPosA[ShowingPlayerInfoString] + " / " + StatsPosB.PlayerStatsPosB[ShowingPlayerInfoString];
				}

				else if ((StatsPosA.PlayerStatsPosA[ShowingPlayerInfoString] != "") && (StatsPosB.PlayerStatsPosB[ShowingPlayerInfoString] != "") && (StatsPosC.PlayerStatsPosC[ShowingPlayerInfoString] != "")) {
					PositionsText.text = "Positions: " + StatsPosA.PlayerStatsPosA[ShowingPlayerInfoString] + " / " + StatsPosB.PlayerStatsPosB[ShowingPlayerInfoString] + " / " + StatsPosC.PlayerStatsPosC[ShowingPlayerInfoString];
				}
				
				OutsideShot02.text = "2) " + StatsOutside02.PlayerStatsOutside02[ShowingPlayerInfoString];
				OutsideShot03.text = "3) " + StatsOutside03.PlayerStatsOutside03[ShowingPlayerInfoString];
				OutsideShot04.text = "4) " + StatsOutside04.PlayerStatsOutside04[ShowingPlayerInfoString];
				OutsideShot05.text = "5) " + StatsOutside05.PlayerStatsOutside05[ShowingPlayerInfoString];
				OutsideShot06.text = "6) " + StatsOutside06.PlayerStatsOutside06[ShowingPlayerInfoString];
				OutsideShot07.text = "7) " + StatsOutside07.PlayerStatsOutside07[ShowingPlayerInfoString];
				OutsideShot08.text = "8) " + StatsOutside08.PlayerStatsOutside08[ShowingPlayerInfoString];
				OutsideShot09.text = "9) " + StatsOutside09.PlayerStatsOutside09[ShowingPlayerInfoString];
				OutsideShot10.text = "10) " + StatsOutside10.PlayerStatsOutside10[ShowingPlayerInfoString];
				OutsideShot11.text = "11) " + StatsOutside11.PlayerStatsOutside11[ShowingPlayerInfoString];
				OutsideShot12.text = "12) " + StatsOutside12.PlayerStatsOutside12[ShowingPlayerInfoString];
				InsideShot02.text = "2) " + StatsInside02.PlayerStatsInside02[ShowingPlayerInfoString];
				InsideShot03.text = "3) " + StatsInside03.PlayerStatsInside03[ShowingPlayerInfoString];
				InsideShot04.text = "4) " + StatsInside04.PlayerStatsInside04[ShowingPlayerInfoString];
				InsideShot05.text = "5) " + StatsInside05.PlayerStatsInside05[ShowingPlayerInfoString];
				InsideShot06.text = "6) " + StatsInside06.PlayerStatsInside06[ShowingPlayerInfoString];
				InsideShot07.text = "7) " + StatsInside07.PlayerStatsInside07[ShowingPlayerInfoString];
				InsideShot08.text = "8) " + StatsInside08.PlayerStatsInside08[ShowingPlayerInfoString];
				InsideShot09.text = "9) " + StatsInside09.PlayerStatsInside09[ShowingPlayerInfoString];
				InsideShot10.text = "10) " + StatsInside10.PlayerStatsInside10[ShowingPlayerInfoString];
				InsideShot11.text = "11) " + StatsInside11.PlayerStatsInside11[ShowingPlayerInfoString];
				InsideShot12.text = "12) " + StatsInside12.PlayerStatsInside12[ShowingPlayerInfoString];
				RebBreakShot02.text = "2) " + StatsRebBreak02.PlayerStatsRebBreak02[ShowingPlayerInfoString];
				RebBreakShot03.text = "3) " + StatsRebBreak03.PlayerStatsRebBreak03[ShowingPlayerInfoString];
				RebBreakShot04.text = "4) " + StatsRebBreak04.PlayerStatsRebBreak04[ShowingPlayerInfoString];
				RebBreakShot05.text = "5) " + StatsRebBreak05.PlayerStatsRebBreak05[ShowingPlayerInfoString];
				RebBreakShot06.text = "6) " + StatsRebBreak06.PlayerStatsRebBreak06[ShowingPlayerInfoString];
				RebBreakShot07.text = "7) " + StatsRebBreak07.PlayerStatsRebBreak07[ShowingPlayerInfoString];
				RebBreakShot08.text = "8) " + StatsRebBreak08.PlayerStatsRebBreak08[ShowingPlayerInfoString];
				RebBreakShot09.text = "9) " + StatsRebBreak09.PlayerStatsRebBreak09[ShowingPlayerInfoString];
				RebBreakShot10.text = "10) " + StatsRebBreak10.PlayerStatsRebBreak10[ShowingPlayerInfoString];
				RebBreakShot11.text = "11) " + StatsRebBreak11.PlayerStatsRebBreak11[ShowingPlayerInfoString];
				RebBreakShot12.text = "12) " + StatsRebBreak12.PlayerStatsRebBreak12[ShowingPlayerInfoString];
				PassingA.text = "A) " + StatsPassingA.PlayerStatsPassingA[ShowingPlayerInfoString];
				PassingB.text = "B) " + StatsPassingB.PlayerStatsPassingB[ShowingPlayerInfoString];
				PassingC.text = "C) " + StatsPassingC.PlayerStatsPassingC[ShowingPlayerInfoString];
				PassingD.text = "D) " + StatsPassingD.PlayerStatsPassingD[ShowingPlayerInfoString];
				PassingE.text = "E) " + StatsPassingE.PlayerStatsPassingE[ShowingPlayerInfoString];
				PassingFG.text = "F/G) " + StatsPassingF.PlayerStatsPassingF[ShowingPlayerInfoString];
				PassingH.text = "H) " + StatsPassingH.PlayerStatsPassingH[ShowingPlayerInfoString];
				PassingI.text = "I) " + StatsPassingI.PlayerStatsPassingI[ShowingPlayerInfoString];
				PassingJ.text = "J) " + StatsPassingJ.PlayerStatsPassingJ[ShowingPlayerInfoString];
				PassingK.text = "K) " + StatsPassingK.PlayerStatsPassingK[ShowingPlayerInfoString];
				PassingL.text = "L) " + StatsPassingL.PlayerStatsPassingL[ShowingPlayerInfoString];
				Defending01.text = "1) " + StatsDefending01.PlayerStatsDefending01[ShowingPlayerInfoString];
				Defending02.text = "2) " + StatsDefending02.PlayerStatsDefending02[ShowingPlayerInfoString];
				Defending03.text = "3) " + StatsDefending03.PlayerStatsDefending03[ShowingPlayerInfoString];
				Defending04.text = "4) " + StatsDefending04.PlayerStatsDefending04[ShowingPlayerInfoString];
				Defending05.text = "5) " + StatsDefending05.PlayerStatsDefending05[ShowingPlayerInfoString];
				Defending06.text = "6) " + StatsDefending06.PlayerStatsDefending06[ShowingPlayerInfoString];

				if ((StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString] == "Penalty") && (StatsDefending08.PlayerStatsDefending08[ShowingPlayerInfoString] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[ShowingPlayerInfoString] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[ShowingPlayerInfoString] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString] == "Penalty")) {
					Defending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString];
					Defending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString];
				}

				else if ((StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[ShowingPlayerInfoString] == "Penalty") && (StatsDefending09.PlayerStatsDefending09[ShowingPlayerInfoString] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[ShowingPlayerInfoString] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString] == "Penalty")) {
					Defending07.text = "7) " + StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString];
					Defending11.text = "8-11) " + StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString];
				}

				else if ((StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[ShowingPlayerInfoString] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[ShowingPlayerInfoString] == "Penalty") && (StatsDefending10.PlayerStatsDefending10[ShowingPlayerInfoString] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString] == "Penalty")) {
					Defending07.text = "7-8) " + StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString];
					Defending11.text = "9-11) " + StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString];
				}

				else if ((StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[ShowingPlayerInfoString] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[ShowingPlayerInfoString] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[ShowingPlayerInfoString] == "Penalty") && (StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString] == "Penalty")) {
					Defending07.text = "7-9) " + StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString];
					Defending11.text = "10-11) " + StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString];
				}

				else if ((StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString] != "Penalty") && (StatsDefending08.PlayerStatsDefending08[ShowingPlayerInfoString] != "Penalty") && (StatsDefending09.PlayerStatsDefending09[ShowingPlayerInfoString] != "Penalty") && (StatsDefending10.PlayerStatsDefending10[ShowingPlayerInfoString] != "Penalty") && (StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString] == "Penalty")) {
					Defending07.text = "7-10) " + StatsDefending07.PlayerStatsDefending07[ShowingPlayerInfoString];
					Defending11.text = "11) " + StatsDefending11.PlayerStatsDefending11[ShowingPlayerInfoString];
				}
				
				Defending12.text = "12) " + StatsDefending12.PlayerStatsDefending12[ShowingPlayerInfoString];
				Defending13.text = "13) " + StatsDefending13.PlayerStatsDefending13[ShowingPlayerInfoString];
				Defending14.text = "14) " + StatsDefending14.PlayerStatsDefending14[ShowingPlayerInfoString];
			}

			else if (ShowingPlayerInfoInt == 4) {
				GoalieRating02.text = "2) " + GStatsGoalieRating02.PlayerGStatsGoalieRating02[ShowingPlayerInfoString];
				GoalieRating03.text = "3) " + GStatsGoalieRating03.PlayerGStatsGoalieRating03[ShowingPlayerInfoString];
				GoalieRating04.text = "4) " + GStatsGoalieRating04.PlayerGStatsGoalieRating04[ShowingPlayerInfoString];
				GoalieRating05.text = "5) " + GStatsGoalieRating05.PlayerGStatsGoalieRating05[ShowingPlayerInfoString];
				GoalieRating06.text = "6) " + GStatsGoalieRating06.PlayerGStatsGoalieRating06[ShowingPlayerInfoString];
				GoalieRating07.text = "7) " + GStatsGoalieRating07.PlayerGStatsGoalieRating07[ShowingPlayerInfoString];
				GoalieRating08.text = "8) " + GStatsGoalieRating08.PlayerGStatsGoalieRating08[ShowingPlayerInfoString];
				GoalieRating09.text = "9) " + GStatsGoalieRating09.PlayerGStatsGoalieRating09[ShowingPlayerInfoString];
				GoalieRating10.text = "10) " + GStatsGoalieRating10.PlayerGStatsGoalieRating10[ShowingPlayerInfoString];
				GoalieRating11.text = "11) " + GStatsGoalieRating11.PlayerGStatsGoalieRating11[ShowingPlayerInfoString];
				GoalieRating12.text = "12) " + GStatsGoalieRating12.PlayerGStatsGoalieRating12[ShowingPlayerInfoString];
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (ShowingPlayerInfoInt == 2) {
				OffenseText.text = "Offense: " + StatsOffense.FrPlayerStatsOffense[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				DefenseText.text = "Defense: " + StatsDefense.FrPlayerStatsDefense[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PenaltyText.text = "Penalty: " + StatsPenalty.FrPlayerStatsPenalty[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				BreakawayText.text = "Breakaway: " + StatsBreakaway.FrPlayerStatsBreakaway[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				IntimidationText.text = "Intimidation: " + StatsIntimidation.FrPlayerStatsIntimidation[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				FaceoffText.text = "Faceoff: " + StatsFaceoff.FrPlayerStatsFaceoff[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];

				if ((StatsPosA.FrPlayerStatsPosA[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "") && (StatsPosB.FrPlayerStatsPosB[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "") && (StatsPosC.FrPlayerStatsPosC[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "")) {
					PositionsText.text = "Positions: " + StatsPosA.FrPlayerStatsPosA[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				}

				else if ((StatsPosA.FrPlayerStatsPosA[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "") && (StatsPosB.FrPlayerStatsPosB[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "") && (StatsPosC.FrPlayerStatsPosC[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "")) {
					PositionsText.text = "Positions: " + StatsPosA.FrPlayerStatsPosA[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] + " / " + StatsPosB.FrPlayerStatsPosB[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				}

				else if ((StatsPosA.FrPlayerStatsPosA[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "") && (StatsPosB.FrPlayerStatsPosB[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "") && (StatsPosC.FrPlayerStatsPosC[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "")) {
					PositionsText.text = "Positions: " + StatsPosA.FrPlayerStatsPosA[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] + " / " + StatsPosB.FrPlayerStatsPosB[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] + " / " + StatsPosC.FrPlayerStatsPosC[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				}
				
				OutsideShot02.text = "2) " + StatsOutside02.FrPlayerStatsOutside02[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot03.text = "3) " + StatsOutside03.FrPlayerStatsOutside03[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot04.text = "4) " + StatsOutside04.FrPlayerStatsOutside04[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot05.text = "5) " + StatsOutside05.FrPlayerStatsOutside05[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot06.text = "6) " + StatsOutside06.FrPlayerStatsOutside06[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot07.text = "7) " + StatsOutside07.FrPlayerStatsOutside07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot08.text = "8) " + StatsOutside08.FrPlayerStatsOutside08[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot09.text = "9) " + StatsOutside09.FrPlayerStatsOutside09[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot10.text = "10) " + StatsOutside10.FrPlayerStatsOutside10[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot11.text = "11) " + StatsOutside11.FrPlayerStatsOutside11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				OutsideShot12.text = "12) " + StatsOutside12.FrPlayerStatsOutside12[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot02.text = "2) " + StatsInside02.FrPlayerStatsInside02[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot03.text = "3) " + StatsInside03.FrPlayerStatsInside03[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot04.text = "4) " + StatsInside04.FrPlayerStatsInside04[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot05.text = "5) " + StatsInside05.FrPlayerStatsInside05[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot06.text = "6) " + StatsInside06.FrPlayerStatsInside06[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot07.text = "7) " + StatsInside07.FrPlayerStatsInside07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot08.text = "8) " + StatsInside08.FrPlayerStatsInside08[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot09.text = "9) " + StatsInside09.FrPlayerStatsInside09[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot10.text = "10) " + StatsInside10.FrPlayerStatsInside10[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot11.text = "11) " + StatsInside11.FrPlayerStatsInside11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				InsideShot12.text = "12) " + StatsInside12.FrPlayerStatsInside12[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot02.text = "2) " + StatsRebBreak02.FrPlayerStatsRebBreak02[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot03.text = "3) " + StatsRebBreak03.FrPlayerStatsRebBreak03[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot04.text = "4) " + StatsRebBreak04.FrPlayerStatsRebBreak04[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot05.text = "5) " + StatsRebBreak05.FrPlayerStatsRebBreak05[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot06.text = "6) " + StatsRebBreak06.FrPlayerStatsRebBreak06[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot07.text = "7) " + StatsRebBreak07.FrPlayerStatsRebBreak07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot08.text = "8) " + StatsRebBreak08.FrPlayerStatsRebBreak08[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot09.text = "9) " + StatsRebBreak09.FrPlayerStatsRebBreak09[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot10.text = "10) " + StatsRebBreak10.FrPlayerStatsRebBreak10[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot11.text = "11) " + StatsRebBreak11.FrPlayerStatsRebBreak11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				RebBreakShot12.text = "12) " + StatsRebBreak12.FrPlayerStatsRebBreak12[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingA.text = "A) " + StatsPassingA.FrPlayerStatsPassingA[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingB.text = "B) " + StatsPassingB.FrPlayerStatsPassingB[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingC.text = "C) " + StatsPassingC.FrPlayerStatsPassingC[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingD.text = "D) " + StatsPassingD.FrPlayerStatsPassingD[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingE.text = "E) " + StatsPassingE.FrPlayerStatsPassingE[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingFG.text = "F/G) " + StatsPassingF.FrPlayerStatsPassingF[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingH.text = "H) " + StatsPassingH.FrPlayerStatsPassingH[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingI.text = "I) " + StatsPassingI.FrPlayerStatsPassingI[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingJ.text = "J) " + StatsPassingJ.FrPlayerStatsPassingJ[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingK.text = "K) " + StatsPassingK.FrPlayerStatsPassingK[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				PassingL.text = "L) " + StatsPassingL.FrPlayerStatsPassingL[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				Defending01.text = "1) " + StatsDefending01.FrPlayerStatsDefending01[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				Defending02.text = "2) " + StatsDefending02.FrPlayerStatsDefending02[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				Defending03.text = "3) " + StatsDefending03.FrPlayerStatsDefending03[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				Defending04.text = "4) " + StatsDefending04.FrPlayerStatsDefending04[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				Defending05.text = "5) " + StatsDefending05.FrPlayerStatsDefending05[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				Defending06.text = "6) " + StatsDefending06.FrPlayerStatsDefending06[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];

				if ((StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
					Defending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
					Defending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				}

				else if ((StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
					Defending07.text = "7) " + StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
					Defending11.text = "8-11) " + StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				}

				else if ((StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
					Defending07.text = "7-8) " + StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
					Defending11.text = "9-11) " + StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				}

				else if ((StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
					Defending07.text = "7-9) " + StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
					Defending11.text = "10-11) " + StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				}

				else if ((StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending08.FrPlayerStatsDefending08[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending09.FrPlayerStatsDefending09[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending10.FrPlayerStatsDefending10[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] != "Penalty") && (StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam] == "Penalty")) {
					Defending07.text = "7-10) " + StatsDefending07.FrPlayerStatsDefending07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
					Defending11.text = "11) " + StatsDefending11.FrPlayerStatsDefending11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				}
				
				Defending12.text = "12) " + StatsDefending12.FrPlayerStatsDefending12[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				Defending13.text = "13) " + StatsDefending13.FrPlayerStatsDefending13[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				Defending14.text = "14) " + StatsDefending14.FrPlayerStatsDefending14[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
			}

			else if (ShowingPlayerInfoInt == 4) {
				GoalieRating02.text = "2) " + GStatsGoalieRating02.FrPlayerGStatsGoalieRating02[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating03.text = "3) " + GStatsGoalieRating03.FrPlayerGStatsGoalieRating03[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating04.text = "4) " + GStatsGoalieRating04.FrPlayerGStatsGoalieRating04[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating05.text = "5) " + GStatsGoalieRating05.FrPlayerGStatsGoalieRating05[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating06.text = "6) " + GStatsGoalieRating06.FrPlayerGStatsGoalieRating06[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating07.text = "7) " + GStatsGoalieRating07.FrPlayerGStatsGoalieRating07[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating08.text = "8) " + GStatsGoalieRating08.FrPlayerGStatsGoalieRating08[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating09.text = "9) " + GStatsGoalieRating09.FrPlayerGStatsGoalieRating09[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating10.text = "10) " + GStatsGoalieRating10.FrPlayerGStatsGoalieRating10[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating11.text = "11) " + GStatsGoalieRating11.FrPlayerGStatsGoalieRating11[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
				GoalieRating12.text = "12) " + GStatsGoalieRating12.FrPlayerGStatsGoalieRating12[ShowingPlayerInfoString + PlayerDatabase.PlayerChosenTeam];
			}
		}

		UpdatingBoldTexts();
	}

	public void UpdatingBoldTexts() {
		// Outside Shots
		if ((OutsideShot02.text.Contains("Goal")) || (OutsideShot02.text.Contains("Goal+")) || (OutsideShot02.text.Contains("G. Rating+")) || (OutsideShot02.text.Contains("G. Rating"))) {
			OutsideShot02.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot02.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot03.text.Contains("Goal")) || (OutsideShot03.text.Contains("Goal+")) || (OutsideShot03.text.Contains("G. Rating+")) || (OutsideShot03.text.Contains("G. Rating"))) {
			OutsideShot03.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot03.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot04.text.Contains("Goal")) || (OutsideShot04.text.Contains("Goal+")) || (OutsideShot04.text.Contains("G. Rating+")) || (OutsideShot04.text.Contains("G. Rating"))) {
			OutsideShot04.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot04.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot05.text.Contains("Goal")) || (OutsideShot05.text.Contains("Goal+")) || (OutsideShot05.text.Contains("G. Rating+")) || (OutsideShot05.text.Contains("G. Rating"))) {
			OutsideShot05.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot05.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot06.text.Contains("Goal")) || (OutsideShot06.text.Contains("Goal+")) || (OutsideShot06.text.Contains("G. Rating+")) || (OutsideShot06.text.Contains("G. Rating"))) {
			OutsideShot06.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot06.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot07.text.Contains("Goal")) || (OutsideShot07.text.Contains("Goal+")) || (OutsideShot07.text.Contains("G. Rating+")) || (OutsideShot07.text.Contains("G. Rating"))) {
			OutsideShot07.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot07.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot08.text.Contains("Goal")) || (OutsideShot08.text.Contains("Goal+")) || (OutsideShot08.text.Contains("G. Rating+")) || (OutsideShot08.text.Contains("G. Rating"))) {
			OutsideShot08.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot08.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot09.text.Contains("Goal")) || (OutsideShot09.text.Contains("Goal+")) || (OutsideShot09.text.Contains("G. Rating+")) || (OutsideShot09.text.Contains("G. Rating"))) {
			OutsideShot09.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot09.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot10.text.Contains("Goal")) || (OutsideShot10.text.Contains("Goal+")) || (OutsideShot10.text.Contains("G. Rating+")) || (OutsideShot10.text.Contains("G. Rating"))) {
			OutsideShot10.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot10.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot11.text.Contains("Goal")) || (OutsideShot11.text.Contains("Goal+")) || (OutsideShot11.text.Contains("G. Rating+")) || (OutsideShot11.text.Contains("G. Rating"))) {
			OutsideShot11.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot11.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((OutsideShot12.text.Contains("Goal")) || (OutsideShot12.text.Contains("Goal+")) || (OutsideShot12.text.Contains("G. Rating+")) || (OutsideShot12.text.Contains("G. Rating"))) {
			OutsideShot12.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			OutsideShot12.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		// Inside Shots
		if ((InsideShot02.text.Contains("Goal")) || (InsideShot02.text.Contains("Goal+")) || (InsideShot02.text.Contains("G. Rating+")) || (InsideShot02.text.Contains("G. Rating"))) {
			InsideShot02.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot02.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot03.text.Contains("Goal")) || (InsideShot03.text.Contains("Goal+")) || (InsideShot03.text.Contains("G. Rating+")) || (InsideShot03.text.Contains("G. Rating"))) {
			InsideShot03.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot03.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot04.text.Contains("Goal")) || (InsideShot04.text.Contains("Goal+")) || (InsideShot04.text.Contains("G. Rating+")) || (InsideShot04.text.Contains("G. Rating"))) {
			InsideShot04.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot04.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot05.text.Contains("Goal")) || (InsideShot05.text.Contains("Goal+")) || (InsideShot05.text.Contains("G. Rating+")) || (InsideShot05.text.Contains("G. Rating"))) {
			InsideShot05.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot05.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot06.text.Contains("Goal")) || (InsideShot06.text.Contains("Goal+")) || (InsideShot06.text.Contains("G. Rating+")) || (InsideShot06.text.Contains("G. Rating"))) {
			InsideShot06.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot06.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot07.text.Contains("Goal")) || (InsideShot07.text.Contains("Goal+")) || (InsideShot07.text.Contains("G. Rating+")) || (InsideShot07.text.Contains("G. Rating"))) {
			InsideShot07.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot07.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot08.text.Contains("Goal")) || (InsideShot08.text.Contains("Goal+")) || (InsideShot08.text.Contains("G. Rating+")) || (InsideShot08.text.Contains("G. Rating"))) {
			InsideShot08.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot08.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot09.text.Contains("Goal")) || (InsideShot09.text.Contains("Goal+")) || (InsideShot09.text.Contains("G. Rating+")) || (InsideShot09.text.Contains("G. Rating"))) {
			InsideShot09.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot09.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot10.text.Contains("Goal")) || (InsideShot10.text.Contains("Goal+")) || (InsideShot10.text.Contains("G. Rating+")) || (InsideShot10.text.Contains("G. Rating"))) {
			InsideShot10.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot10.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot11.text.Contains("Goal")) || (InsideShot11.text.Contains("Goal+")) || (InsideShot11.text.Contains("G. Rating+")) || (InsideShot11.text.Contains("G. Rating"))) {
			InsideShot11.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot11.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((InsideShot12.text.Contains("Goal")) || (InsideShot12.text.Contains("Goal+")) || (InsideShot12.text.Contains("G. Rating+")) || (InsideShot12.text.Contains("G. Rating"))) {
			InsideShot12.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			InsideShot12.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		// Rebound / Breakaway Shots
		if ((RebBreakShot02.text.Contains("Goal")) || (RebBreakShot02.text.Contains("Goal+")) || (RebBreakShot02.text.Contains("G. Rating+")) || (RebBreakShot02.text.Contains("G. Rating"))) {
			RebBreakShot02.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot02.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot03.text.Contains("Goal")) || (RebBreakShot03.text.Contains("Goal+")) || (RebBreakShot03.text.Contains("G. Rating+")) || (RebBreakShot03.text.Contains("G. Rating"))) {
			RebBreakShot03.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot03.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot04.text.Contains("Goal")) || (RebBreakShot04.text.Contains("Goal+")) || (RebBreakShot04.text.Contains("G. Rating+")) || (RebBreakShot04.text.Contains("G. Rating"))) {
			RebBreakShot04.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot04.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot05.text.Contains("Goal")) || (RebBreakShot05.text.Contains("Goal+")) || (RebBreakShot05.text.Contains("G. Rating+")) || (RebBreakShot05.text.Contains("G. Rating"))) {
			RebBreakShot05.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot05.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot06.text.Contains("Goal")) || (RebBreakShot06.text.Contains("Goal+")) || (RebBreakShot06.text.Contains("G. Rating+")) || (RebBreakShot06.text.Contains("G. Rating"))) {
			RebBreakShot06.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot06.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot07.text.Contains("Goal")) || (RebBreakShot07.text.Contains("Goal+")) || (RebBreakShot07.text.Contains("G. Rating+")) || (RebBreakShot07.text.Contains("G. Rating"))) {
			RebBreakShot07.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot07.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot08.text.Contains("Goal")) || (RebBreakShot08.text.Contains("Goal+")) || (RebBreakShot08.text.Contains("G. Rating+")) || (RebBreakShot08.text.Contains("G. Rating"))) {
			RebBreakShot08.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot08.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot09.text.Contains("Goal")) || (RebBreakShot09.text.Contains("Goal+")) || (RebBreakShot09.text.Contains("G. Rating+")) || (RebBreakShot09.text.Contains("G. Rating"))) {
			RebBreakShot09.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot09.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot10.text.Contains("Goal")) || (RebBreakShot10.text.Contains("Goal+")) || (RebBreakShot10.text.Contains("G. Rating+")) || (RebBreakShot10.text.Contains("G. Rating"))) {
			RebBreakShot10.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot10.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot11.text.Contains("Goal")) || (RebBreakShot11.text.Contains("Goal+")) || (RebBreakShot11.text.Contains("G. Rating+")) || (RebBreakShot11.text.Contains("G. Rating"))) {
			RebBreakShot11.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot11.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((RebBreakShot12.text.Contains("Goal")) || (RebBreakShot12.text.Contains("Goal+")) || (RebBreakShot12.text.Contains("G. Rating+")) || (RebBreakShot12.text.Contains("G. Rating"))) {
			RebBreakShot12.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			RebBreakShot12.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		// Goalie Ratiing
		if ((GoalieRating02.text.Contains("Goal")) || (GoalieRating02.text.Contains("Goal+")) || (GoalieRating02.text.Contains("G. Rating+")) || (GoalieRating02.text.Contains("G. Rating"))) {
			GoalieRating02.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating02.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating03.text.Contains("Goal")) || (GoalieRating03.text.Contains("Goal+")) || (GoalieRating03.text.Contains("G. Rating+")) || (GoalieRating03.text.Contains("G. Rating"))) {
			GoalieRating03.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating03.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating04.text.Contains("Goal")) || (GoalieRating04.text.Contains("Goal+")) || (GoalieRating04.text.Contains("G. Rating+")) || (GoalieRating04.text.Contains("G. Rating"))) {
			GoalieRating04.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating04.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating05.text.Contains("Goal")) || (GoalieRating05.text.Contains("Goal+")) || (GoalieRating05.text.Contains("G. Rating+")) || (GoalieRating05.text.Contains("G. Rating"))) {
			GoalieRating05.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating05.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating06.text.Contains("Goal")) || (GoalieRating06.text.Contains("Goal+")) || (GoalieRating06.text.Contains("G. Rating+")) || (GoalieRating06.text.Contains("G. Rating"))) {
			GoalieRating06.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating06.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating07.text.Contains("Goal")) || (GoalieRating07.text.Contains("Goal+")) || (GoalieRating07.text.Contains("G. Rating+")) || (GoalieRating07.text.Contains("G. Rating"))) {
			GoalieRating07.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating07.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating08.text.Contains("Goal")) || (GoalieRating08.text.Contains("Goal+")) || (GoalieRating08.text.Contains("G. Rating+")) || (GoalieRating08.text.Contains("G. Rating"))) {
			GoalieRating08.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating08.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating09.text.Contains("Goal")) || (GoalieRating09.text.Contains("Goal+")) || (GoalieRating09.text.Contains("G. Rating+")) || (GoalieRating09.text.Contains("G. Rating"))) {
			GoalieRating09.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating09.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating10.text.Contains("Goal")) || (GoalieRating10.text.Contains("Goal+")) || (GoalieRating10.text.Contains("G. Rating+")) || (GoalieRating10.text.Contains("G. Rating"))) {
			GoalieRating10.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating10.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating11.text.Contains("Goal")) || (GoalieRating11.text.Contains("Goal+")) || (GoalieRating11.text.Contains("G. Rating+")) || (GoalieRating11.text.Contains("G. Rating"))) {
			GoalieRating11.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating11.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}

		if ((GoalieRating12.text.Contains("Goal")) || (GoalieRating12.text.Contains("Goal+")) || (GoalieRating12.text.Contains("G. Rating+")) || (GoalieRating12.text.Contains("G. Rating"))) {
			GoalieRating12.color = new Color(0.3086062f, 0.7340186f, 0.8962264f, 1.0f);
		}

		else {
			GoalieRating12.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		}
	}

	public void UpdatePlayerSelectButtons() {
		// P1LW1
		if ((PlayerDatabase.P1LW1 == "None") || (PlayerDatabase.P1LW1 == "")) {
			SetLW1Button.enabled = true;
			SetLW1Text.enabled = false;
		}

		else {
			SetLW1Button.enabled = false;
			SetLW1Text.enabled = true;
			SetLW1Text.text = PlayerDatabase.P1LW1.Replace(" ", "\n");
		}

		// P1LW2
		if ((PlayerDatabase.P1LW2 == "None") || (PlayerDatabase.P1LW2 == "")) {
			SetLW2Button.enabled = true;
			SetLW2Text.enabled = false;
		}

		else {
			SetLW2Button.enabled = false;
			SetLW2Text.enabled = true;
			SetLW2Text.text = PlayerDatabase.P1LW2.Replace(" ", "\n");
		}

		// P1LW3
		if ((PlayerDatabase.P1LW3 == "None") || (PlayerDatabase.P1LW3 == "")) {
			SetLW3Button.enabled = true;
			SetLW3Text.enabled = false;
		}

		else {
			SetLW3Button.enabled = false;
			SetLW3Text.enabled = true;
			SetLW3Text.text = PlayerDatabase.P1LW3.Replace(" ", "\n");
		}

		// P1LW4
		if ((PlayerDatabase.P1LW4 == "None") || (PlayerDatabase.P1LW4 == "")) {
			SetLW4Button.enabled = true;
			SetLW4Text.enabled = false;
		}

		else {
			SetLW4Button.enabled = false;
			SetLW4Text.enabled = true;
			SetLW4Text.text = PlayerDatabase.P1LW4.Replace(" ", "\n");
		}

		// P1C1
		if ((PlayerDatabase.P1C1 == "None") || (PlayerDatabase.P1C1 == "")) {
			SetC1Button.enabled = true;
			SetC1Text.enabled = false;
		}

		else {
			SetC1Button.enabled = false;
			SetC1Text.enabled = true;
			SetC1Text.text = PlayerDatabase.P1C1.Replace(" ", "\n");
		}

		// P1C2
		if ((PlayerDatabase.P1C2 == "None") || (PlayerDatabase.P1C2 == "")) {
			SetC2Button.enabled = true;
			SetC2Text.enabled = false;
		}

		else {
			SetC2Button.enabled = false;
			SetC2Text.enabled = true;
			SetC2Text.text = PlayerDatabase.P1C2.Replace(" ", "\n");
		}

		// P1C3
		if ((PlayerDatabase.P1C3 == "None") || (PlayerDatabase.P1C3 == "")) {
			SetC3Button.enabled = true;
			SetC3Text.enabled = false;
		}

		else {
			SetC3Button.enabled = false;
			SetC3Text.enabled = true;
			SetC3Text.text = PlayerDatabase.P1C3.Replace(" ", "\n");
		}

		// P1C4
		if ((PlayerDatabase.P1C4 == "None") || (PlayerDatabase.P1C4 == "")) {
			SetC4Button.enabled = true;
			SetC4Text.enabled = false;
		}

		else {
			SetC4Button.enabled = false;
			SetC4Text.enabled = true;
			SetC4Text.text = PlayerDatabase.P1C4.Replace(" ", "\n");
		}

		// P1RW1
		if ((PlayerDatabase.P1RW1 == "None") || (PlayerDatabase.P1RW1 == "")) {
			SetRW1Button.enabled = true;
			SetRW1Text.enabled = false;
		}

		else {
			SetRW1Button.enabled = false;
			SetRW1Text.enabled = true;
			SetRW1Text.text = PlayerDatabase.P1RW1.Replace(" ", "\n");
		}

		// P1RW2
		if ((PlayerDatabase.P1RW2 == "None") || (PlayerDatabase.P1RW2 == "")) {
			SetRW2Button.enabled = true;
			SetRW2Text.enabled = false;
		}

		else {
			SetRW2Button.enabled = false;
			SetRW2Text.enabled = true;
			SetRW2Text.text = PlayerDatabase.P1RW2.Replace(" ", "\n");
		}

		// P1RW3
		if ((PlayerDatabase.P1RW3 == "None") || (PlayerDatabase.P1RW3 == "")) {
			SetRW3Button.enabled = true;
			SetRW3Text.enabled = false;
		}

		else {
			SetRW3Button.enabled = false;
			SetRW3Text.enabled = true;
			SetRW3Text.text = PlayerDatabase.P1RW3.Replace(" ", "\n");
		}

		// P1RW4
		if ((PlayerDatabase.P1RW4 == "None") || (PlayerDatabase.P1RW4 == "")) {
			SetRW4Button.enabled = true;
			SetRW4Text.enabled = false;
		}

		else {
			SetRW4Button.enabled = false;
			SetRW4Text.enabled = true;
			SetRW4Text.text = PlayerDatabase.P1RW4.Replace(" ", "\n");
		}

		// P1LD1
		if ((PlayerDatabase.P1LD1 == "None") || (PlayerDatabase.P1LD1 == "")) {
			SetLD1Button.enabled = true;
			SetLD1Text.enabled = false;
		}

		else {
			SetLD1Button.enabled = false;
			SetLD1Text.enabled = true;
			SetLD1Text.text = PlayerDatabase.P1LD1.Replace(" ", "\n");
		}

		// P1LD2
		if ((PlayerDatabase.P1LD2 == "None") || (PlayerDatabase.P1LD2 == "")) {
			SetLD2Button.enabled = true;
			SetLD2Text.enabled = false;
		}

		else {
			SetLD2Button.enabled = false;
			SetLD2Text.enabled = true;
			SetLD2Text.text = PlayerDatabase.P1LD2.Replace(" ", "\n");
		}

		// P1LD3
		if ((PlayerDatabase.P1LD3 == "None") || (PlayerDatabase.P1LD3 == "")) {
			SetLD3Button.enabled = true;
			SetLD3Text.enabled = false;
		}

		else {
			SetLD3Button.enabled = false;
			SetLD3Text.enabled = true;
			SetLD3Text.text = PlayerDatabase.P1LD3.Replace(" ", "\n");
		}

		// P1RD1
		if ((PlayerDatabase.P1RD1 == "None") || (PlayerDatabase.P1RD1 == "")) {
			SetRD1Button.enabled = true;
			SetRD1Text.enabled = false;
		}

		else {
			SetRD1Button.enabled = false;
			SetRD1Text.enabled = true;
			SetRD1Text.text = PlayerDatabase.P1RD1.Replace(" ", "\n");
		}

		// P1RD2
		if ((PlayerDatabase.P1RD2 == "None") || (PlayerDatabase.P1RD2 == "")) {
			SetRD2Button.enabled = true;
			SetRD2Text.enabled = false;
		}

		else {
			SetRD2Button.enabled = false;
			SetRD2Text.enabled = true;
			SetRD2Text.text = PlayerDatabase.P1RD2.Replace(" ", "\n");
		}

		// P1RD3
		if ((PlayerDatabase.P1RD3 == "None") || (PlayerDatabase.P1RD3 == "")) {
			SetRD3Button.enabled = true;
			SetRD3Text.enabled = false;
		}

		else {
			SetRD3Button.enabled = false;
			SetRD3Text.enabled = true;
			SetRD3Text.text = PlayerDatabase.P1RD3.Replace(" ", "\n");
		}

		// P1G
		if ((PlayerDatabase.P1G == "None") || (PlayerDatabase.P1G == "")) {
			SetGButton.enabled = true;
			SetGText.enabled = false;
		}

		else {
			SetGButton.enabled = false;
			SetGText.enabled = true;
			SetGText.text = PlayerDatabase.P1G.Replace(" ", "\n");
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}