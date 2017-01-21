using UnityEngine;
using System.Collections;

public class FrigginButtons : MonoBehaviour {

        public bool beenClicked;
        public GameManager gm;
	// Use this for initialization
	void Start () {
        beenClicked = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Clicked(){
        if (beenClicked == false){
        gm.ProgressUpdate();
        beenClicked = true;

        }
    }
}
