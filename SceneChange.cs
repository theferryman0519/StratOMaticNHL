using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class SceneChange : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// List of Scenes
    public static string Scene00 = "00FerrymanScene";
	public static string Scene01 = "01MainScene";
	public static string Scene01B = "01BLogInSignUp";
	public static string Scene01C = "01CLogSignError";
	public static string Scene02 = "02MenuScene";
	public static string Scene03 = "03TeamSelect";
	public static string Scene04 = "04LineupSelect";
	public static string Scene05 = "05GameplayReady";
	public static string Scene06 = "06GameFaceoff";
	public static string Scene07 = "07GameFaceoffWin";
	public static string Scene08 = "08GameGoalieRebound";
	public static string Scene09 = "09GameDefend";
	public static string Scene10 = "10GameGoal";
	public static string Scene10B = "10BGameGoalGood";
	public static string Scene10C = "10CGameGoalSave";
	public static string Scene11 = "11GameGoalieRating";
	public static string Scene12 = "12GameInsideShot";
	public static string Scene12B = "12BGameInsideShotAfter";
	public static string Scene13 = "13GameIntimidation";
	public static string Scene14 = "14GameLineChange";
	public static string Scene15 = "15GameLosePuck";
	public static string Scene16 = "16GameOutsideOptions";
	public static string Scene17 = "17GameOutsideShot";
	public static string Scene17B = "17BGameOutsideShotAfter";
	public static string Scene18 = "18GamePassing";
	public static string Scene18B = "18BGamePassingAfter";
	public static string Scene19 = "19GamePenalty";
	public static string Scene19B = "19BGamePenaltyGood";
	public static string Scene19C = "19CGamePenaltyBad";
    public static string Scene19D = "19DGamePenaltyPlays";
    public static string Scene19E = "19EGamePenaltyShots";
    public static string Scene19F = "19FGamePenaltySave";
    public static string Scene19G = "19GGamePenaltyGoal";
    public static string Scene19H = "19HGamePenaltyEnd";
	public static string Scene20 = "20GamePenetration";
	public static string Scene21 = "21GamePeriodOver";
	public static string Scene21B = "21BGameGameOver";
	public static string Scene22 = "22GameReboundShot";
	public static string Scene22B = "22BGameReboundShotAfter";
	public static string Scene23 = "23GameSave";
	public static string Scene24 = "24GameTakeAway";
	public static string Scene25 = "25GameTakeActionCard";
	public static string Scene26 = "26GameShootout";
	public static string Scene26B = "26BGameShootoutShots";
	public static string Scene26C = "26CGameShootoutSave";
	public static string Scene26D = "26DGameShootoutGoal";
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
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
// --------------- SCENE CHANGE FUNCTION ---------------
	// Load Scene00 - Ferryman Scene
	public void Scene00Load() {
		SceneManager.LoadScene(Scene00);
	}

	// Load Scene01 - Main Scene
	public void Scene01Load() {
		SceneManager.LoadScene(Scene01);
	}

	// Load Scene01B - Log In / Sign Up Scene
	public void Scene01BLoad() {
		SceneManager.LoadScene(Scene01B);
	}

	// Load Scene01C - Log In / Sign Up Error Scene
	public void Scene01CLoad() {
		SceneManager.LoadScene(Scene01C);
	}

	// Load Scene02 - Menu Scene
	public void Scene02Load() {
		SceneManager.LoadScene(Scene02);
	}

	// Load Scene03 - Team Select Scene
	public void Scene03Load() {
		SceneManager.LoadScene(Scene03);
	}

	// Load Scene04 - Lineup Select Scene
	public void Scene04Load() {
		SceneManager.LoadScene(Scene04);
	}

	// Load Scene05 - Gameplay Ready Scene
	public void Scene05Load() {
		SceneManager.LoadScene(Scene05);
	}

	// Load Scene06 - Game Faceoff Scene
	public void Scene06Load() {
		SceneManager.LoadScene(Scene06);
	}

	// Load Scene07 - Game Faceoff Win Scene
	public void Scene07Load() {
		SceneManager.LoadScene(Scene07);
	}

	// Load Scene08 - Game Goalie Rebound Scene
	public void Scene08Load() {
		SceneManager.LoadScene(Scene08);
	}

	// Load Scene09 - Game Defend Scene
	public void Scene09Load() {
		SceneManager.LoadScene(Scene09);
	}

	// Load Scene10 - Game Goal Scene
	public void Scene10Load() {
		SceneManager.LoadScene(Scene10);
	}

	// Load Scene10B - Game Goal Good Scene
	public void Scene10BLoad() {
		SceneManager.LoadScene(Scene10B);
	}

	// Load Scene10C - Game Goal Save Scene
	public void Scene10CLoad() {
		SceneManager.LoadScene(Scene10C);
	}

	// Load Scene11 - Game Goalie Rating Scene
	public void Scene11Load() {
		SceneManager.LoadScene(Scene11);
	}

	// Load Scene12 - Game Inside Shot Scene
	public void Scene12Load() {
		SceneManager.LoadScene(Scene12);
	}

	// Load Scene12B - Game Inside Shot After Scene
	public void Scene12BLoad() {
		SceneManager.LoadScene(Scene12B);
	}

	// Load Scene13 - Game Intimidation Scene
	public void Scene13Load() {
		SceneManager.LoadScene(Scene13);
	}

	// Load Scene14 - Game Line Change Scene
	public void Scene14Load() {
		SceneManager.LoadScene(Scene14);
	}

	// Load Scene15 - Game Lose Puck Scene
	public void Scene15Load() {
		SceneManager.LoadScene(Scene15);
	}

	// Load Scene16 - Game Outside Options Scene
	public void Scene16Load() {
		SceneManager.LoadScene(Scene16);
	}

	// Load Scene17 - Game Outside Shot Scene
	public void Scene17Load() {
		SceneManager.LoadScene(Scene17);
	}

	// Load Scene17B - Game Outside Shot After Scene
	public void Scene17BLoad() {
		SceneManager.LoadScene(Scene17B);
	}

	// Load Scene18 - Game Passing Scene
	public void Scene18Load() {
		SceneManager.LoadScene(Scene18);
	}

	// Load Scene18B - Game Passing After Scene
	public void Scene18BLoad() {
		SceneManager.LoadScene(Scene18B);
	}

	// Load Scene19 - Game Penalty Scene
	public void Scene19Load() {
		SceneManager.LoadScene(Scene19);
	}

	// Load Scene19B - Game Penalty Good Scene
	public void Scene19BLoad() {
		SceneManager.LoadScene(Scene19B);
	}

	// Load Scene19C - Game Penalty Bad Scene
	public void Scene19CLoad() {
		SceneManager.LoadScene(Scene19C);
	}

    // Load Scene19D - Game Penalty Plays Scene
	public void Scene19DLoad() {
		SceneManager.LoadScene(Scene19D);
	}

    // Load Scene19E - Game Penalty Shots Scene
	public void Scene19ELoad() {
		SceneManager.LoadScene(Scene19E);
	}

    // Load Scene19F - Game Penalty Save Scene
	public void Scene19FLoad() {
		SceneManager.LoadScene(Scene19F);
	}

    // Load Scene19G - Game Penalty Goal Scene
	public void Scene19GLoad() {
		SceneManager.LoadScene(Scene19G);
	}

    // Load Scene19H - Game Penalty End Scene
	public void Scene19HLoad() {
		SceneManager.LoadScene(Scene19H);
	}

	// Load Scene20 - Game Penetration Scene
	public void Scene20Load() {
		SceneManager.LoadScene(Scene20);
	}

	// Load Scene21 - Game Period Over Scene
	public void Scene21Load() {
		SceneManager.LoadScene(Scene21);
	}

	// Load Scene21B - Game Game Over Scene
	public void Scene21BLoad() {
		SceneManager.LoadScene(Scene21B);
	}

	// Load Scene22 - Game Rebound Shot Scene
	public void Scene22Load() {
		SceneManager.LoadScene(Scene22);
	}

	// Load Scene22B - Game Rebound Shot After Scene
	public void Scene22BLoad() {
		SceneManager.LoadScene(Scene22B);
	}

	// Load Scene23 - Game Save Scene
	public void Scene23Load() {
		SceneManager.LoadScene(Scene23);
	}

	// Load Scene24 - Game Take Away Scene
	public void Scene24Load() {
		SceneManager.LoadScene(Scene24);
	}

	// Load Scene25 - Game Take Action Card Scene
	public void Scene25Load() {
		SceneManager.LoadScene(Scene25);
	}

	// Load Scene26 - Game Shootout Scene
	public void Scene26Load() {
		SceneManager.LoadScene(Scene26);
	}

	// Load Scene26B - Game Shootout Shots Scene
	public void Scene26BLoad() {
		SceneManager.LoadScene(Scene26B);
	}

	// Load Scene26C - Game Shootout Save Scene
	public void Scene26CLoad() {
		SceneManager.LoadScene(Scene26C);
	}

	// Load Scene26D - Game Shootout Goal Scene
	public void Scene26DLoad() {
		SceneManager.LoadScene(Scene26D);
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}