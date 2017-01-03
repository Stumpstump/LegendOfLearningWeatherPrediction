using LoLSDK;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour  {
    

    //Which stage the game is in
    public bool stage1;
    public bool stage2;

    public Text db;
    public bool miniGame;

    public float temp;
    public int airPressure;
    public bool isAirPressureLow;
    public float humidity;
    public float windSpeed;

    //Progress the student has made
    public int progress; 


	// Use this for initialization
	void Start () {
	 LOLSDK.Init ("stump.weathergame");
     progress = 0;
    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Call when changing dialogue shown
    public void UpdateDB(string newtext){
    
        db.text = newtext;        

    }

    public void ProgressUpdate (){
        progress += 1;
        LOLSDK.Instance.SubmitProgress(0, progress, 11);        
    
    }

        
}
