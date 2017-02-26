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

      ////////////Crap in scene

    public Text displayTemp;
    public Text displayWind;
    public Text displayHumid;
    public Text displayAPC;
    public Text displayAPF;

    public float predictTemp;
    public int predictAirPressure;
    public float predictHumidity;
    public float predictWind;

    public bool Scene1;
    public bool Scene2;
    public bool Scene3;

    public Text tempy;
    public Text windy;
    public Text humidy;
    public Text apy;
    public Text apyp;

    public GameObject stage15done;


    
    //Progress the student has made
    public int progress; 

    public Animator animator;


	// Use this for initialization
	void Start () {
	 
     progress = 0;
     animator.enabled = false;
     Scene1 = false;
     Scene2 = false;
     Scene3 = false;
    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Finish(){
        LOLSDK.Instance.CompleteGame();
        /* SceneManager.LoadScene ("Main");
        progress = 0;
        LOLSDK.Instance.PlaySound("FX/click1.mp3");
        LOLSDK.Instance.StopSound( "Music/birdy.mp3"); */

    }

    public void TriggerPredict(){
        int randy = Random.Range(1,4);
        if (randy == 1){
                Predict1();
                tempy.text = temp.ToString();
                apy.text = airPressure.ToString();
                windy.text = windSpeedM.ToString();
                humidy.text = humidity.ToString();
                apyp.text = predictAirPressure.ToString();
                Scene1 = true;
                Scene2 = false;
                Scene3 = false;

            }
        if (randy == 2){
                Predict2();
                tempy.text = temp.ToString();
                apy.text = airPressure.ToString();
                windy.text = windSpeedM.ToString();
                humidy.text = humidity.ToString();
                apyp.text = predictAirPressure.ToString();
                Scene2 = true;
                Scene3 = false; 
                Scene1 = false;
            }
        if (randy == 3){
                Predict3();
                tempy.text = temp.ToString();
                apy.text = airPressure.ToString();
                windy.text = windSpeedM.ToString();
                humidy.text = humidity.ToString();
                apyp.text = predictAirPressure.ToString();
                Scene3 = true;
                Scene2 = false;
                Scene1 = false;
            }

    }

    public void Predict1(){
         temp = 68f;
        airPressure = 1007;
        humidity = 35;
        windSpeedM = 13;
       
        isAirPressureLow = true;

      
        predictAirPressure = 966;
       

    }

    public void Predict2(){
         temp = 79f;
        airPressure = 1028;
        humidity = 15;
        windSpeedM = 6f;
       
        isAirPressureLow = true;

    
        predictAirPressure = 1038;
      

    }

    public void Predict3(){

         temp = 54f;
        airPressure = 994;
        humidity = 10f;
        windSpeedM = 15f;
        
        isAirPressureLow = true;

  
        predictAirPressure = 1012;
        
    }

    public void Scenario1(){
        //Cold rain windy
        temp = 55f;
        airPressure = 985;
        humidity = 88f;
        windSpeedM = 18f;
        windSpeedK = 29f;
        isAirPressureLow = true;

        predictTemp = 44f;
        predictAirPressure = 966;
        predictHumidity = 50f;
        predictWind = 26f;
      

       

     }


    public void Scenario2(){
        //Hot sunny calm
        temp = 94f;
        airPressure = 1038;
        humidity = 22f;
        windSpeedM = 4f;
        windSpeedK = 6.4f;
        isAirPressureLow = false;

        predictTemp = 85f;
        predictAirPressure = 1038;
        predictHumidity = 15f;
        predictWind = 10f;
       

       
    }


    public void Scenario3(){
        //Cool, cloudy, dry, windy
        temp = 42f;
        airPressure = 960;
        humidity = 65f;
        windSpeedM = 11f;
        windSpeedK = 17.7f;
        isAirPressureLow = false;

        predictTemp = 63f;
        predictAirPressure = 1012;
        predictHumidity = 25f;
        predictWind = 18f;
      


    }

    public void Scenario4(){
        //Warm rain 
        temp = 68f;
        airPressure = 1003;
        humidity = 67f;
        windSpeedM = 9f;
        windSpeedK = 14.5f;
        isAirPressureLow = true;

        predictTemp = 44f;
        predictAirPressure = 966;
        predictHumidity = 50f;
        predictWind = 26f;
      

       

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
        LOLSDK.Instance.SubmitProgress(0, progress, 15);  
        if (progress == 6){
            animator.enabled = true;

        }
        if (progress == 10){
            stage15done.SetActive(true);
        }
    
    }

    public void StartGame(){
        stage1 = true;
        Scene1 = false;
        Scene2 = false;
        Scene3 = false;
        stage1panel.SetActive(true);
         menuPanel.SetActive(false);
        LOLSDK.Instance.PlaySound( "Music/birdy.mp3", true, true);

    }

    public void Pause (){
        Time.timeScale = 0;
        LOLSDK.Instance.PlaySound("FX/click1.mp3");
        }

    public void Resume(){
        Time.timeScale = 1f;
        LOLSDK.Instance.PlaySound("FX/click1.mp3");
    }

    public void Restart(){
        SceneManager.LoadScene ("Main");
        progress = 0;
        LOLSDK.Instance.PlaySound("FX/click1.mp3");
        LOLSDK.Instance.StopSound( "Music/birdy.mp3");
       
       
        
    }

    public void StartStage2(){
        LOLSDK.Instance.StopSound( "Music/birdy.mp3");
    }

    

        
}
