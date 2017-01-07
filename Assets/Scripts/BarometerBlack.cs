using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarometerBlack : MonoBehaviour {

     public int ap;
     public Text airP;
     private float mOffset = 0;
    
    private float tOffset;
    
    private float newpos;

    public bool locked;

    public BarometerPointer redPointer;

    public bool pressure; //false = high, true = low
    public Text futureAP;

    private Vector3 targetAngleHigh;
    private Vector3 targetAngleLow;
    private Vector3 currentAngle;

    private float timer = 0;
    public Button done;
    public GameManager gm;


   
	// Use this for initialization
	void Start () {

        done.interactable = false;

        ap = gm.airPressure;
        pressure = gm.isAirPressureLow;
       
        
         if (gm.airPressure == 994){
            ap = 5;
            airP.text = (994).ToString();
            }
               else if (gm.airPressure == 1007){
                ap = 7;
            airP.text = (1007).ToString();
            }
        
        else if (gm.airPressure == 1028){
            ap = 9;
            airP.text = (1028).ToString();
            } 
        
        futureAP.enabled = false;
        
        
        locked = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(gameObject.transform.eulerAngles.z);
     if (locked == false){
            
            
            ///Scenario 3
             if (ap == 5){
                if (gameObject.transform.eulerAngles.z  - 25f < 1.5f && gameObject.transform.eulerAngles.z - 25f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,-28f);
                    
                }
            }
            
            ///Scenario 1
            else if (ap == 7){
                if (gameObject.transform.eulerAngles.z  - 330f < 1.5f && gameObject.transform.eulerAngles.z - 330f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    
                    targetAngleHigh = new Vector3(0,0,93f);
                }
            }
            
            //Scenario 2
            else if (ap == 9){
                if (gameObject.transform.eulerAngles.z  - 283f < 1.5f && gameObject.transform.eulerAngles.z - 283f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    pressure = true;
                    targetAngleHigh = new Vector3(0,0,-102f);
                }
            }
             
            
            
            }
    
            if (redPointer.done == true){
                timer += 1 * Time.deltaTime;
                if (timer >= 1.0f){
                if (pressure == true){
                        
                        currentAngle = new Vector3(0,0, Mathf.LerpAngle(transform.eulerAngles.z, targetAngleHigh.z, Time.deltaTime));
             
                        transform.eulerAngles = currentAngle;
                        done.interactable = true;
                        futureAP.enabled = true;
                        futureAP.text = gm.predictAirPressure.ToString();
                }
                if (pressure == false){
                        
                        currentAngle = new Vector3(0,0, Mathf.LerpAngle(transform.eulerAngles.z, targetAngleLow.z, Time.deltaTime));
             
                        transform.eulerAngles = currentAngle;
                        done.interactable = true;
                        futureAP.enabled = true;
                        futureAP.text = gm.predictAirPressure.ToString();
                }
            }
        }
                
            }

        
	
	

     public void MouseClick () // When clicked
    {
        tOffset = transform.eulerAngles.z;
        mOffset = Input.mousePosition.x; // record where the cursor was when the object was clicked
    }
     
    public void MouseDrag () // For every frame the mouse is still down
    {
        if (locked == false){
            newpos = (Input.mousePosition.x - mOffset) + tOffset; // Set the rotation to (how far the mouse has moved) + where we were
            gameObject.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, newpos);
        }
    }

}
