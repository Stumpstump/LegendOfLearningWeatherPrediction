using UnityEngine;
using System.Collections;
using LoLSDK;

public class Object : MonoBehaviour {

    public bool beenClicked;

    public string description;
    public GameManager gm;
    
    
    public bool baro;
    public bool therm;
    public bool anem;
    public bool humid;
    public bool rain;
    public bool dop;

    public GameObject barometer;
    public GameObject thermometer;
    public GameObject anememe;
    public GameObject humidity;
    public GameObject raingauge;
    public GameObject doppler;

	// Use this for initialization
	void Start () {
        
        if (baro == true){
        description = "To calibrate your barometer, click and drag the black pointer and move your mouse left or right until it points to the current air pressure. Then, click on the red pointer and align it with the black one. Generally, the lower the air pressure the colder and worse the weather is. The higher air pressure is generally warmer and better weather.";
        
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Clicked(){
        LOLSDK.Instance.PlaySound("FX/click1.mp3");
        gm.UpdateDB(description);
        if (gm.miniGame == false){
       

                

                if (baro == true){
                    barometer.gameObject.SetActive(true);
                    
                    gm.miniGame = true;
                    
                    
                }

                else if (therm == true){
                    thermometer.gameObject.SetActive(true);
                    
                    gm.miniGame = true;
                    
                }

                else if (anem == true){
                    anememe.gameObject.SetActive(true);
                    
                    gm.miniGame = true;
                    
                }

                else if (humid == true){
                    humidity.gameObject.SetActive(true);
                    
                    gm.miniGame = true;
                    
                }

                else if (rain == true){
                    raingauge.gameObject.SetActive(true);
                    
                    gm.miniGame = true;
                    
                }

                else if (dop == true){
                    doppler.gameObject.SetActive(true);
                    
                    gm.miniGame = true;
                    
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
    
          if (rain == true){
            raingauge.gameObject.SetActive(false);                    
            gm.miniGame = false;      
        }

          if (dop == true){
            doppler.gameObject.SetActive(false);                    
            gm.miniGame = false;      
        }

        if (beenClicked == false){
                        gm.ProgressUpdate();
                        beenClicked = true;
                    }
    
    }
}
