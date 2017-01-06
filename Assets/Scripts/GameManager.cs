using LoLSDK;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour  {
    

    //Which stage the game is in
    public bool stage1;
    public bool stage2;

    public GameObject menuPanel;
    public GameObject stage1panel;
    public GameObject stage2panel;

    public Text descriptionBox;
    public bool miniGame;

    public float temp;
    public int airPressure;
    public bool isAirPressureLow;
    public float humidity;
    public float windSpeedM;
    public float windSpeedK;

    public float predictTemp;
    public int predictAirPressure;
    public float predictHumidity;
    public float predictWind;

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

    public void Scenario1(){
        //Cold rain windy
        temp = 68f;
        airPressure = 1007;
        humidity = 35f;
        windSpeedM = 13f;
        windSpeedK = 20.92f;
        isAirPressureLow = true;

        predictTemp = 44f;
        predictAirPressure = 966;
        predictHumidity = 50f;
        predictWind = 26f;
        

     }


    public void Scenario2(){
        //Hot sunny calm
        temp = 79f;
        airPressure = 1028;
        humidity = 15f;
        windSpeedM = 10f;
        windSpeedK = 16.09f;
        isAirPressureLow = false;

        predictTemp = 85f;
        predictAirPressure = 1038;
        predictHumidity = 15f;
        predictWind = 10f;
        
    }


    public void Scenario3(){
        //Cool, cloudy, dry, windy
        temp = 54f;
        airPressure = 994;
        humidity = 10f;
        windSpeedM = 15f;
        windSpeedK = 24.14f;
        isAirPressureLow = false;

        predictTemp = 63f;
        predictAirPressure = 1012;
        predictHumidity = 25f;
        predictWind = 18f;
        

    }
    //Call when changing dialogue shown
    public void UpdateDB(string newtext){
    
        descriptionBox.text = newtext;        

    }

    public void ButtonClickNoise(){
        LOLSDK.Instance.PlaySound("FX/click1.mp3");

    }

    public void ProgressUpdate (){
        progress += 1;
        LOLSDK.Instance.SubmitProgress(0, progress, 11);  
        if (progress == 6){
            balloonFall = true;

        }
    
    }

    public void StartGame(){
        stage1 = true;
        stage1panel.SetActive(true);
         menuPanel.SetActive(false);
        LOLSDK.Instance.PlaySound( "Music/birdy.mp3", true, true);

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
