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

    map1.gameObject.SetActive(false);
    map2.gameObject.SetActive(false);
    map3.gameObject.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Activate(){

        if (gm.Scene1 == true){
            map1.gameObject.SetActive(true);
        }
        else if (gm.Scene2 == true){
            map2.gameObject.SetActive(true); 
        }
        else if (gm.Scene3 == true){
            map3.gameObject.SetActive(true);
        }

    }
}
