using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Thermometer : MonoBehaviour {

    public Slider temp;
    public bool slide;
    public float temperature;
    public GameManager gm;
    private float timerFloat;


	// Use this for initialization
	void Start () {

    temperature = gm.temp;
        
	
	}
	
	// Update is called once per frame
	void Update () {
         
        if (slide == true){
            timerFloat += Time.deltaTime;
            temp.value = Mathf.Lerp(-9f, temperature, timerFloat);
        }
	
	}


}
