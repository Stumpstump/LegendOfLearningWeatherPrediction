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

    public bool TestScene;
	// Use this for initialization
	void Start () {

    temperature = 0;
     if (endbutton != null){
    endbutton.interactable = false;
        }
        
	
	}
	
	// Update is called once per frame
	void Update () {
         if (slide == false){
            timer += 0.5f * Time.deltaTime;
            if (timer >= 0.5f){
                slide = true;
            }

        }
        if (slide == true){
            timerFloat += Time.deltaTime;
            temp.value = Mathf.Lerp(-9f, temperature, timerFloat);
            if (endbutton != null){
    endbutton.interactable = true;
        }
        }
	
	}


    public void Reset(){
    timer = 0.3f;
    timerFloat = 0;
    temperature = gm.temp;
    slide = false;

    }
}
