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
       
        if (ap == 2){
            airP.text = (960).ToString();
            }
        else if (ap == 3){
            airP.text = (970).ToString();
            }
        else if (ap == 4){
            airP.text = (980).ToString();
            }
        else if (ap == 5){
            airP.text = (990).ToString();
            }
        else if (ap == 6){
            airP.text = (1000).ToString();
            }
        else if (ap == 7){
            airP.text = (1010).ToString();
            }
        else if (ap == 8){
            airP.text = (1020).ToString();
            }
        else if (ap == 9){
            airP.text = (1030).ToString();
            }
        else if (ap == 10){
            airP.text = (1040).ToString();
            }
        
        
        locked = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(gameObject.transform.eulerAngles.z);
     if (locked == false){
            
            
            if (ap == 2){
                if (gameObject.transform.eulerAngles.z - 107f < 1.5f && gameObject.transform.eulerAngles.z - 107f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,80f);
                    targetAngleHigh = new Vector3(0,0,125f);
                }
            }
            else if (ap == 3){
                if (gameObject.transform.eulerAngles.z - 78f < 1.5f && gameObject.transform.eulerAngles.z - 78f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,50f);
                    targetAngleHigh = new Vector3(0,0,105f);
                }
            }
            else if (ap == 4){
                if (gameObject.transform.eulerAngles.z - 48f < 1.5f && gameObject.transform.eulerAngles.z - 48f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,24f);
                    targetAngleHigh = new Vector3(0,0,70f);
                }
            }
            else if (ap == 5){
                if (gameObject.transform.eulerAngles.z  - 25f < 1.5f && gameObject.transform.eulerAngles.z - 25f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,0f);
                    targetAngleHigh = new Vector3(0,0,50f);
                }
            }
            else if (ap == 6){
                if (gameObject.transform.eulerAngles.z  - 0 < 1.5f && gameObject.transform.eulerAngles.z - 0 > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,-25f);
                    targetAngleHigh = new Vector3(0,0,25f);
                }
            }
            else if (ap == 7){
                if (gameObject.transform.eulerAngles.z  - 330f < 1.5f && gameObject.transform.eulerAngles.z - 330f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,310f);
                    targetAngleHigh = new Vector3(0,0,350f);
                }
            }
            else if (ap == 8){
                if (gameObject.transform.eulerAngles.z - 309 < 1.5f && gameObject.transform.eulerAngles.z - 309f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,280f);
                    targetAngleHigh = new Vector3(0,0,330f);
                }
            }
            else if (ap == 9){
                if (gameObject.transform.eulerAngles.z  - 283f < 1.5f && gameObject.transform.eulerAngles.z - 283f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,260f);
                    targetAngleHigh = new Vector3(0,0,300f);
                }
            }
             else if (ap == 10){
                if (gameObject.transform.eulerAngles.z  - 253f < 1.5f && gameObject.transform.eulerAngles.z - 253f > -1.5f){
                    locked = true;
                    redPointer.locked = false;
                    targetAngleLow = new Vector3(0,0,230f);
                    targetAngleHigh = new Vector3(0,0,270f);
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
                }
                if (pressure == false){
                        
                        currentAngle = new Vector3(0,0, Mathf.LerpAngle(transform.eulerAngles.z, targetAngleLow.z, Time.deltaTime));
             
                        transform.eulerAngles = currentAngle;
                        done.interactable = true;
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
