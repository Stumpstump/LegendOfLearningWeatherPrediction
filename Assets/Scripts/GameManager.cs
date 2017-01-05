using LoLSDK;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour  {
    

    //Which stage the game is in
    public bool stage1;
    public bool stage2;

    public Text descriptionBox;
    public bool miniGame;

    public float temp;
    public int airPressure;
    public bool isAirPressureLow;
    public float humidity;
    public float windSpeed;

    public MCButton multipleChoice1;
    public MCButton multipleChoice2;
    public MCButton multipleChoice3;
    //Progress the student has made
    public int progress; 

    public bool balloonFall;


	// Use this for initialization
	void Start () {
	 LOLSDK.Init ("stump.weathergame");
     progress = 0;
     balloonFall = false;
    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Call when changing dialogue shown
    public void UpdateDB(string newtext){
    
        descriptionBox.text = newtext;        

    }

    public void ProgressUpdate (){
        progress += 1;
        LOLSDK.Instance.SubmitProgress(0, progress, 11);  
        if (progress == 6){
            balloonFall = true;

        }
    
    }

    public void Pause (){
        Time.timeScale = 0;

        }

    public void Resume(){
        Time.timeScale = 1f;
    }

    public void Restart(){
        SceneManager.LoadScene ("_Init");
    }

        
}
