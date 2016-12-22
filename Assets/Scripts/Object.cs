using UnityEngine;
using System.Collections;
using LoLSDK;

public class Object : MonoBehaviour {

    public bool beenClicked;
    public bool important;
    public string description;
    public GameManager gm;

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Clicked(){

        gm.UpdateDB(description);
        beenClicked = true;
    
    }
}
