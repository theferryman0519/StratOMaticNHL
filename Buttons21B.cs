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

public class Buttons21B : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Buttons
	public Button MainMenuButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int UpdateWins;
	public static int UpdateLosses;
	public static int UpdateTies;
	public static string WentIntoOvertime;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public SceneChange Scene02LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// MainMenuButton
		Button MainMenuButtonClick = MainMenuButton.GetComponent<Button>();
		MainMenuButtonClick.onClick.AddListener(MainMenuButtonClicking);

		UpdateWins = 0;
		UpdateLosses = 0;
		UpdateTies = 0;
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
	public void MainMenuButtonClicking() {
		UpdatePlayerRecord();
		StartCoroutine(UpdatingPlayerRecord());
	}

	public void UpdatePlayerRecord() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			if (System.Int32.Parse(PlayerDatabase.GameplayP1Score) > System.Int32.Parse(PlayerDatabase.GameplayP2Score)) {
				UpdateWins = System.Int32.Parse(PlayerDatabase.PlayerComputerWins);
				UpdateWins = UpdateWins + 1;
				PlayerDatabase.PlayerComputerWins = UpdateWins.ToString();
			}

			else if (System.Int32.Parse(PlayerDatabase.GameplayP2Score) > System.Int32.Parse(PlayerDatabase.GameplayP1Score)) {
				UpdateLosses = System.Int32.Parse(PlayerDatabase.PlayerComputerLosses);
				UpdateLosses = UpdateLosses + 1;
				PlayerDatabase.PlayerComputerLosses = UpdateLosses.ToString();
			}

			else {
				UpdateTies = System.Int32.Parse(PlayerDatabase.PlayerComputerOvertimes);
				UpdateTies = UpdateTies + 1;
				PlayerDatabase.PlayerComputerOvertimes = UpdateTies.ToString();
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			if (System.Int32.Parse(PlayerDatabase.GameplayP1Score) > System.Int32.Parse(PlayerDatabase.GameplayP2Score)) {
				UpdateWins = System.Int32.Parse(PlayerDatabase.PlayerFranchiseWins);
				UpdateWins = UpdateWins + 1;
				PlayerDatabase.PlayerFranchiseWins = UpdateWins.ToString();
			}

			else if (System.Int32.Parse(PlayerDatabase.GameplayP2Score) > System.Int32.Parse(PlayerDatabase.GameplayP1Score)) {
				UpdateLosses = System.Int32.Parse(PlayerDatabase.PlayerFranchiseLosses);
				UpdateLosses = UpdateLosses + 1;
				PlayerDatabase.PlayerFranchiseLosses = UpdateLosses.ToString();
			}

			else {
				UpdateTies = System.Int32.Parse(PlayerDatabase.PlayerFranchiseOvertimes);
				UpdateTies = UpdateTies + 1;
				PlayerDatabase.PlayerFranchiseOvertimes = UpdateTies.ToString();
			}
		}
	}

	public IEnumerator UpdatingPlayerRecord() {
		if (PlayerDatabase.CurrentFranchiseSelect == 1) {
			WWWForm UpdatingPlayerRecordForm = new WWWForm();
			UpdatingPlayerRecordForm.AddField("PlayerUsername", PlayerDatabase.PlayerUsername);
			UpdatingPlayerRecordForm.AddField("PlayerComputerWins", PlayerDatabase.PlayerComputerWins);
			UpdatingPlayerRecordForm.AddField("PlayerComputerLosses", PlayerDatabase.PlayerComputerLosses);
			UpdatingPlayerRecordForm.AddField("PlayerComputerOvertimes", PlayerDatabase.PlayerComputerOvertimes);

			using (UnityWebRequest UpdatingPlayerRecordWWW = UnityWebRequest.Post("http://www.theferryman.org/StratOMatic/PHPUpdateCPURecord.php", UpdatingPlayerRecordForm)) {
				yield return UpdatingPlayerRecordWWW.SendWebRequest();
				
				if ((UpdatingPlayerRecordWWW.result == UnityWebRequest.Result.ConnectionError) || (UpdatingPlayerRecordWWW.result == UnityWebRequest.Result.ProtocolError)) {
					Debug.Log(UpdatingPlayerRecordWWW.error);
				}
				
				else {
					if (UpdatingPlayerRecordWWW.downloadHandler.text != "Unable to view database") {
						Scene02LoadRun.Scene02Load();
					}
					
					else {
						// Do Nothing
					}
				}
			}
		}

		else if (PlayerDatabase.CurrentFranchiseSelect == 2) {
			WWWForm UpdatingPlayerRecordForm = new WWWForm();
			UpdatingPlayerRecordForm.AddField("PlayerUsername", PlayerDatabase.PlayerUsername);
			UpdatingPlayerRecordForm.AddField("PlayerFranchiseWins", PlayerDatabase.PlayerFranchiseWins);
			UpdatingPlayerRecordForm.AddField("PlayerFranchiseLosses", PlayerDatabase.PlayerFranchiseLosses);
			UpdatingPlayerRecordForm.AddField("PlayerFranchiseOvertimes", PlayerDatabase.PlayerFranchiseOvertimes);

			using (UnityWebRequest UpdatingPlayerRecordWWW = UnityWebRequest.Post("http://www.theferryman.org/StratOMatic/PHPUpdateCPUFranchiseRecord.php", UpdatingPlayerRecordForm)) {
				yield return UpdatingPlayerRecordWWW.SendWebRequest();
				
				if ((UpdatingPlayerRecordWWW.result == UnityWebRequest.Result.ConnectionError) || (UpdatingPlayerRecordWWW.result == UnityWebRequest.Result.ProtocolError)) {
					Debug.Log(UpdatingPlayerRecordWWW.error);
				}
				
				else {
					if (UpdatingPlayerRecordWWW.downloadHandler.text != "Unable to view database") {
						Scene02LoadRun.Scene02Load();
					}
					
					else {
						// Do Nothing
					}
				}
			}
		}

		yield return new WaitForSeconds(0.5f);
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}