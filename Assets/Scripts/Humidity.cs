using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LoLSDK;
public class Humidity : MonoBehaviour {

    public GameObject humidity;
    private IEnumerator numbergenerate;
    private bool generate;
    private bool generating;
    private float sec;
    
    private bool proper;
    public GameManager gm;
    
    private bool on;
    public Button endbutton;
    public bool TestScene;

	// Use this for initialization
	void Start () {
        
        if (TestScene == false){
        on = false;
        humidity.gameObject.SetActive(false);
        proper = false;
        }
        else if (TestScene == true){
            on = true;
            generate = false;
            proper = true;
            humidity.gameObject.SetActive(true);
        }
        if (endbutton != null){
    endbutton.interactable = false;
        }
	
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
	
        if (proper == true && generate == false){
                ShowNumbers();
            
        }
	
	}

    public void ShowNumbers(){
            humidity.GetComponent<Text>().text = gm.humidity.ToString() + "%";
            if (endbutton != null){
    endbutton.interactable = true;
        }
            
    }
    public void TurnOn(){
        if (on == false){
        humidity.GetComponent<Text>().text = "0000%";
        humidity.gameObject.SetActive(true);
        generate = true;
        on = true;
        }

        else if (on == true){
        humidity.gameObject.SetActive(false);
        generate = false;
        on = false;
        proper = false;
        sec = 0;
        
        }

        LOLSDK.Instance.PlaySound("FX/click1.mp3");
    }

    public void Reset() {

        humidity.GetComponent<Text>().text = gm.humidity.ToString() + ".00%";
    }

    private IEnumerator CycleNumbers() {
        
            yield return new WaitForSeconds(0.2f);
            humidity.GetComponent<Text>().text = Random.Range(1000,9999).ToString() + "%";
    }
}
