using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Humidity : MonoBehaviour {

    public GameObject humidity;
    private IEnumerator numbergenerate;
    private bool generate;
    private bool generating;
    private float sec;
    
    private bool proper;
    public GameManager gm;
    
    private bool on;

	// Use this for initialization
	void Start () {
        humidity.gameObject.SetActive(false);
        proper = false;
        on = false;
	
	}
	
	// Update is called once per frame
	void Update () {

    if (generate == true){
            StartCoroutine(CycleNumbers());
            sec += 1 * Time.deltaTime;
            if (sec >= 2.5){
                generate = false;
                proper = true;
            }
        }
	
        if (proper == true && generate == false){
            humidity.GetComponent<Text>().text = gm.humidity.ToString() + "%";
            
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

        
    }

    private IEnumerator CycleNumbers() {
        
            yield return new WaitForSeconds(0.2f);
            humidity.GetComponent<Text>().text = Random.Range(1000,9999).ToString() + "%";
    }
}
