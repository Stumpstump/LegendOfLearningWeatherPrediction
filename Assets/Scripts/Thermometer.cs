using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Thermometer : MonoBehaviour {

    public Slider temp;
    public bool slide;
    public float temperature;
    public GameManager gm;
    private float timerFloat;
    private float timer = 0;
    public Button endbutton;
	// Use this for initialization
	void Start () {

    temperature = gm.temp;
    endbutton.interactable = false;
        
	
	}
	
	// Update is called once per frame
	void Update () {
         if (slide == false){
            timer += 1f * Time.deltaTime;
            if (timer >= 1f){
                slide = true;
            }

        }
        if (slide == true){
            timerFloat += Time.deltaTime;
            temp.value = Mathf.Lerp(-9f, temperature, timerFloat);
            endbutton.interactable = true;
        }
	
	}


}
