using UnityEngine;
using System.Collections;
using LoLSDK;

public class Object : MonoBehaviour {

    public bool beenClicked;
    public bool important;
    public string description;
    public GameManager gm;
    
    
    public bool baro;
    public bool therm;
    public bool anem;
    public bool humid;

    public GameObject barometer;
    public GameObject thermometer;
    public GameObject anememe;
    public GameObject humidity;

	// Use this for initialization
	void Start () {
        
        if (baro == true){
        description = "This is a barometer. A barometer is an instrument used to measure atmospheric pressure. To calibrate your barometer, click and drag the black pointer and move your mouse left or right until it points to the current air pressure. Then, click on the red pointer and align it with the black one.";
        
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Clicked(){
        LOLSDK.Instance.PlaySound("FX/click1.mp3");
        gm.UpdateDB(description);
        if (gm.miniGame == false){
            if (important == true && beenClicked == false){

                if (baro == true){
                    barometer.gameObject.SetActive(true);
                    beenClicked = true;
                    gm.miniGame = true;
                    
                }

                else if (therm == true){
                    thermometer.gameObject.SetActive(true);
                    beenClicked = true;
                    gm.miniGame = true;
                    
                }

                else if (anem == true){
                    anememe.gameObject.SetActive(true);
                    beenClicked = true;
                    gm.miniGame = true;
                    
                }

                else if (humid == true){
                    humidity.gameObject.SetActive(true);
                    beenClicked = true;
                    gm.miniGame = true;
                    
                }
                
            }

            else if (important == false && beenClicked == false){
                beenClicked = true;
                gm.ProgressUpdate();
            }
        }

            
    }

    public void FinishMinigame(){
            LOLSDK.Instance.PlaySound("FX/click1.mp3");
        if (baro == true){
                    barometer.gameObject.SetActive(false);                    
                    gm.miniGame = false;                    
                }
        if (therm == true){
            thermometer.gameObject.SetActive(false);                    
            gm.miniGame = false;      
        }

        if (humid == true){
            humidity.gameObject.SetActive(false);                    
            gm.miniGame = false;      
        }

        if (anem == true){
            anememe.gameObject.SetActive(false);                    
            gm.miniGame = false;      
        }

     gm.ProgressUpdate();
    
    }
}
