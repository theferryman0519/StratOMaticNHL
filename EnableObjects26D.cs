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

public class EnableObjects26D : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image BackgroundImage;
	public Text TitleText;
	public Text ActionText;
	public Image ContinueButton;

	// Scoreboard Objects
	public Image ScoreboardBackground;
	public Text P1Score;
	public Text P2Score;
	public Text P1Shots;
	public Text P2Shots;
	public Text Period;
	public Text Play;

	// Goal Horn
	public AudioClip GoalHornClip;
	public AudioSource GoalHorn;
	public float GoalHornVolume;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int RandomGoalSelection;
	public static string RandomGoalString;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		GoalHornVolume = GoalHorn.volume;
		GoalHornVolume = 5.0f;

		EnableMainObjects();
		EnableScoreboardObjects();
		RandomizeGoal();
		PlayGoalHorn();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdatingScoreboard();
		UpdatingActionText();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBEJCTS FUNCTIONS ---------------
	public void EnableMainObjects() {
		BackgroundImage.enabled = true;
		TitleText.enabled = true;
		ActionText.enabled = true;
		ContinueButton.enabled = true;
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
		ContinueButton.enabled = false;
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
		if (EnableObjects26B.ShootoutTurnString == "P1") {
			ActionText.text = EnableObjects26B.ShooterNameP1 + " " + RandomGoalString;
		}

		else if (EnableObjects26B.ShootoutTurnString == "P2") {
			ActionText.text = EnableObjects26B.ShooterNameP2 + " " + RandomGoalString;
		}
	}

	public void RandomizeGoal() {
		RandomGoalSelection = Random.Range(1,5);

		if (RandomGoalSelection == 1) {
			RandomGoalString = "shoots and scores just under the goalie's pads";
		}

		else if (RandomGoalSelection == 2) {
			RandomGoalString = "hits the upper part of the post and the puck crosses the line";
		}

		else if (RandomGoalSelection == 3) {
			RandomGoalString = "scores off a wrist shot that goes off the goalie's stick";
		}

		else if (RandomGoalSelection == 4) {
			RandomGoalString = "slap shots the puck from the dots and it goes in";
		}
	}

	public void PlayGoalHorn() {
		StartCoroutine(PlayingGoalHorn());
	}

	public IEnumerator PlayingGoalHorn() {
		PlaySounds.BackgroundMusicVolume = 0.1f;
		GoalHorn.Play();
		GoalHornVolume = 5.0f;
		yield return new WaitForSeconds(2.0f);
		GoalHornVolume = 0.0f;
		PlaySounds.BackgroundMusicVolume = 3.0f;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}