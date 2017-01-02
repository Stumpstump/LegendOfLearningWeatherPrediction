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
    public GameManager gm;
	// Use this for initialization
	void Start () {
        proper = false;
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
	
        if (proper == true){
            display.text = gm.windSpeed.ToString();
            proper = false;
        }
	}

     private IEnumerator CycleNumbers() {
        
            yield return new WaitForSeconds(0.2f);
            display.text = Random.Range(1000,9999).ToString();
    }

    public void MPHtoKMH(){
         //manually have values here
        display.text = (float.Parse(display.text) * 1.609344f).ToString();
    }
    public void KMHtoMPH(){
        display.text = (float.Parse(display.text) / 1.609344f).ToString();

    }
    
}
