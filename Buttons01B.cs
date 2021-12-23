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

public class Buttons01B : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button LogInButton;
	public Button SignUpButton;

	public Text LogInUserText;
	public Text SignUpUserText;
	public Text SignUpNameText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int LogSignErrorInt;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene02LoadRun;
	public SceneChange Scene01CLoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		LogSignErrorInt = 0;

		// LogInButton
		Button LogInButtonClick = LogInButton.GetComponent<Button>();
		LogInButtonClick.onClick.AddListener(LogInButtonClicking);

		// SignUpButton
		Button SignUpButtonClick = SignUpButton.GetComponent<Button>();
		SignUpButtonClick.onClick.AddListener(SignUpButtonClicking);
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
	public void LogInButtonClicking() {
		PlayerDatabase.PlayerUsername = LogInUserText.text;
		StartCoroutine(CheckUserName());
	}

	public void SignUpButtonClicking() {
		PlayerDatabase.PlayerUsername = SignUpUserText.text;
		PlayerDatabase.PlayerFirstName = SignUpNameText.text;
		StartCoroutine(CheckSignUpUserName());
	}

// --------------- IENUMERATOR FUNCTIONS ---------------
	public IEnumerator CheckUserName() {
		WWWForm CheckUserNameForm = new WWWForm();
		CheckUserNameForm.AddField("PlayerUsername", PlayerDatabase.PlayerUsername);

		using (UnityWebRequest CheckUserNameWWW = UnityWebRequest.Post("http://www.theferryman.org/StratOMatic/PHPCheckingLogIn.php", CheckUserNameForm)) {
            yield return CheckUserNameWWW.SendWebRequest();
            
			if ((CheckUserNameWWW.result == UnityWebRequest.Result.ConnectionError) || (CheckUserNameWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(CheckUserNameWWW.error);
            }
            
            else {
                if (CheckUserNameWWW.downloadHandler.text != "Unable to view database") {
					// Collect JSON Array Strings
					string jsonArrayString = CheckUserNameWWW.downloadHandler.text;
                    string jsonArrayStringA = jsonArrayString.Replace('"', ' ');
                    string jsonArrayStringB = jsonArrayStringA.Replace('{', ' ');
                    string jsonArrayStringC = jsonArrayStringB.Replace('}', ' ');
                    string jsonArrayStringD = jsonArrayStringC.Replace(']', ' ');
                    string jsonArrayStringE = jsonArrayStringD.Replace('[', ' ');
                    string[] jsonArrayStringTwo = jsonArrayStringE.Split(',', ':');

					// Load Player Information
					PlayerDatabase.PlayerFirstName = jsonArrayStringTwo[3].Trim().ToString();
					PlayerDatabase.PlayerComputerWins = jsonArrayStringTwo[5].Trim().ToString();
					PlayerDatabase.PlayerComputerLosses = jsonArrayStringTwo[7].Trim().ToString();
					PlayerDatabase.PlayerComputerOvertimes = jsonArrayStringTwo[9].Trim().ToString();
					PlayerDatabase.PlayerFranchiseWins = jsonArrayStringTwo[11].Trim().ToString();
					PlayerDatabase.PlayerFranchiseLosses = jsonArrayStringTwo[13].Trim().ToString();
					PlayerDatabase.PlayerFranchiseOvertimes = jsonArrayStringTwo[15].Trim().ToString();

					// Go to Main Menu Scene
					Scene02LoadRun.Scene02Load();
                }
                
                else {
					// Go to Error Scene
					LogSignErrorInt = 1;
					Scene01CLoadRun.Scene01CLoad();
                }
            }
        }

		yield return new WaitForSeconds(0.5f);
	}

	public IEnumerator CheckSignUpUserName() {
		WWWForm CheckSignUpUserNameForm = new WWWForm();
		CheckSignUpUserNameForm.AddField("PlayerUsername", PlayerDatabase.PlayerUsername);

		using (UnityWebRequest CheckSignUpUserNameWWW = UnityWebRequest.Post("http://www.theferryman.org/StratOMatic/PHPCheckingLogIn.php", CheckSignUpUserNameForm)) {
            yield return CheckSignUpUserNameWWW.SendWebRequest();
            
			if ((CheckSignUpUserNameWWW.result == UnityWebRequest.Result.ConnectionError) || (CheckSignUpUserNameWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(CheckSignUpUserNameWWW.error);
            }
            
            else {
                if (CheckSignUpUserNameWWW.downloadHandler.text != "Unable to view database") {
					// Go to Error Scene
					LogSignErrorInt = 2;
					Scene01CLoadRun.Scene01CLoad();
                }
                
                else {
					// Start Up Set Info Coroutine
					StartCoroutine(SetSignUpInfo());
                }
            }
        }

		yield return new WaitForSeconds(0.5f);
	}

	public IEnumerator SetSignUpInfo() {
		WWWForm SetSignUpInfoForm = new WWWForm();
		SetSignUpInfoForm.AddField("PlayerUsername", PlayerDatabase.PlayerUsername);
		SetSignUpInfoForm.AddField("PlayerFirstName", PlayerDatabase.PlayerFirstName);

		using (UnityWebRequest SetSignUpInfoWWW = UnityWebRequest.Post("http://www.theferryman.org/StratOMatic/PHPSettingSignUp.php", SetSignUpInfoForm)) {
            yield return SetSignUpInfoWWW.SendWebRequest();
            
			if ((SetSignUpInfoWWW.result == UnityWebRequest.Result.ConnectionError) || (SetSignUpInfoWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(SetSignUpInfoWWW.error);
            }
            
            else {
                if (SetSignUpInfoWWW.downloadHandler.text != "Unable to view database") {
					// Set Player Information
					PlayerDatabase.PlayerComputerWins = "0";
					PlayerDatabase.PlayerComputerLosses = "0";
					PlayerDatabase.PlayerComputerOvertimes = "0";
					PlayerDatabase.PlayerFranchiseWins = "0";
					PlayerDatabase.PlayerFranchiseLosses = "0";
					PlayerDatabase.PlayerFranchiseOvertimes = "0";

					// Go to Main Menu Scene
					Scene02LoadRun.Scene02Load();
                }
                
                else {
					// Do Nothing
                }
            }
        }

		yield return new WaitForSeconds(0.5f);
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}