using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DumbFrigginButtons : MonoBehaviour {

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Button1(){
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button1.image.color = Color.blue;

    }

    public void Button2(){
        button1.interactable = false;
        button3.interactable = false;
        button4.interactable = false;

    }

    public void Button3(){
        button2.interactable = false;
        button1.interactable = false;
        button4.interactable = false;

    }

    public void Button4(){
        button2.interactable = false;
        button3.interactable = false;
        button1.interactable = false;

    }
}
