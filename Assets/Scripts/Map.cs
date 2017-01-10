using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Map : MonoBehaviour {

    public Image map1;
    public Image map2;
    public Image map3;

    public GameManager gm;
    

	// Use this for initialization
	void Start () {

    map1.enabled = false;   
    map2.enabled = false;
    map3.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Activate(){

        if (gm.Scene1 == true){
            map1.enabled = true;   
        }
        else if (gm.Scene2 == true){
            map2.enabled = true;   
        }
        else if (gm.Scene3 == true){
            map3.enabled = true;   
        }

    }
}
