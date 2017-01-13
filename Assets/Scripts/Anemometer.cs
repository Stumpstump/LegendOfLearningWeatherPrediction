using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Anemometer : MonoBehaviour {

    private IEnumerator numbergenerate;
    public bool generate;
    private bool generating;
    private float sec;
    public Text display;
    
    private bool proper;
     private bool on;
    public GameManager gm;
    public Button endbutton;
        private bool mph;
        
	// Use this for initialization
	void Start () {
        display.gameObject.SetActive(false);
        proper = false;
        generate = false;
        on = false;
        endbutton.interactable = false;
        mph = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (generate == true){
            StartCoroutine(CycleNumbers());
            sec += 1 * Time.deltaTime;
            if (sec >= 1.5){
                generate = false;
                proper = true;
            }
        }
	
        if (proper == true){
            if (mph == true){

            display.text = gm.windSpeedM.ToString() + " MPH"; 
            }
            else if (mph == false){
                display.text = gm.windSpeedK.ToString() + " KPH"; 
            }
            endbutton.interactable = true;
            
        }
	}

        
     private IEnumerator CycleNumbers() {
        
            yield return new WaitForSeconds(0.2f);
            display.text = Random.Range(100,999).ToString();
    }

    public void MPHtoKMH(){
         //manually have values here
        if (proper == true){
        mph = false;
        }
    }
    public void KMHtoMPH(){
        if (proper == true){
        mph = true;
        }
    }

    public void TurnOn(){
        if (on == false){
        display.GetComponent<Text>().text = "000";
        display.gameObject.SetActive(true);
        generate = true;
        on = true;
        }

        else if (on == true){
        display.gameObject.SetActive(false);
        generate = false;
        on = false;
        proper = false;
        sec = 0;
        
        }

        
    }
    
}
