using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LoLSDK;

public class Glossary : MonoBehaviour {

    public Text description;
    public Text thisDescription;
    public Text title;
    public string name;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Whoop(){

        description.text = thisDescription.text;
        title.text = name;
        LOLSDK.Instance.PlaySound("FX/click1.mp3");
    }
 
    public void Reset(){
        LOLSDK.Instance.PlaySound("FX/click1.mp3");
        title.text = "Glossary";
        description.text = "Click the terms on the left to read a definition!";

    }
}
