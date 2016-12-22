using LoLSDK;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager> {
      public static GameManager Instance;

    //Which stage the game is in
    public bool stage1;
    public bool stage2;

    public Text db;


	// Use this for initialization
	void Start () {
	 LOLSDK.Init ("stump.weathergame");
    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Call when changing dialogue shown
    public void UpdateDB(string newtext){
    
        db.text = newtext;        

    }
}
