using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarometerPointer : MonoBehaviour {

    private float mOffset = 0;
    
    private float tOffset;
    
    private float newpos;

    public bool locked;

    public GameObject pointer;

    public Text currentAP;
    public Text futureAP;

    public bool done;

   
    
	// Use this for initialization
	void Start () {
    
    locked = true;
    
    done = false;
    pointer.transform.eulerAngles = new Vector3(0, 0, Random.Range(-132f,134f));
    
    
	
	}
	
	// Update is called once per frame
	void Update () {
	
        
	}

    

    public void Scene1(){
        pointer.transform.eulerAngles = new Vector3(0, 0, 38f);
        transform.eulerAngles = new Vector3(0,0,38f);
        if (currentAP != false && futureAP != false){
            currentAP.text = "985";
            futureAP.text = "1000";
        }
        pointer.GetComponent<BarometerBlack>().ap = 2;
        pointer.GetComponent<BarometerBlack>().targetAngleHigh= new Vector3(0,0,0f);
        done = true;
        locked = true;
        pointer.GetComponent<BarometerBlack>().timer = 0;
        

    }
    public void Scene2(){
        pointer.transform.eulerAngles = new Vector3(0, 0, -99f);
        transform.eulerAngles = new Vector3(0,0,-99f);
        pointer.GetComponent<BarometerBlack>().ap = 9;
        pointer.GetComponent<BarometerBlack>().targetAngleHigh= new Vector3(0,0,-75f);
         if (currentAP != false && futureAP != false){
            currentAP.text = "1038";
            futureAP.text = "1029";
        }
        locked = true;
        done = true;
        pointer.GetComponent<BarometerBlack>().timer = 0;
    }
    public void Scene3(){
        pointer.transform.eulerAngles = new Vector3(0, 0, 109f);
        transform.eulerAngles = new Vector3(0,0,109f);
        pointer.GetComponent<BarometerBlack>().ap = 5;
        pointer.GetComponent<BarometerBlack>().targetAngleHigh= new Vector3(0,0,28f);
         if (currentAP != false && futureAP != false){
            currentAP.text = "960";
            futureAP.text = "988";
        }
        locked = true;
        done = true;
        pointer.GetComponent<BarometerBlack>().timer = 0;
    }
    public void Scene4(){
        pointer.transform.eulerAngles = new Vector3(0, 0, 2f);
        transform.eulerAngles = new Vector3(0,0,2f);
        pointer.GetComponent<BarometerBlack>().ap = 7;
        pointer.GetComponent<BarometerBlack>().targetAngleHigh= new Vector3(0,0,93f);
         if (currentAP != false && futureAP != false){
            currentAP.text = "1003";
            futureAP.text = "965";
        }
        locked = true;
        done = true;
        pointer.GetComponent<BarometerBlack>().timer = 0;
    }
    
}
