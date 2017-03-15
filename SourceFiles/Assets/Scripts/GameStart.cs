using UnityEngine;
using System.Collections;
using LoLSDK;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	LOLSDK.Init ("stump.weathergame");
    SceneManager.LoadScene ("Main");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
