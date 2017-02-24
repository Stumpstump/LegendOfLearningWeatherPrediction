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

    public Vector3 targetAngleHigh;
    private Vector3 targetAngleLow;
    private Vector3 currentAngle;

    public float timer = 0;
    public Button done;
    public GameManager gm;


   
	// Use this for initialization
	void Start () {

        if (done != null){
    done.interactable = false;
        }

        ap = gm.airPressure;
        pressure = false;
       
        
        
        
        if (futureAP != null){
        futureAP.enabled = false;
        }
        
        
        locked = true;
	
	}
	
	// Update is called once per frame
	void Update () {
        
     if (locked == false){
            
           /*  if (ap == 2){
                    targetAngleHigh= new Vector3(0,0,0f);
                    
                }
            
            
            ///Scenario 3
             if (ap == 5){
              
                    targetAngleHigh= new Vector3(0,0,-28f);
                    
                
            }
            
            ///Scenario 1
            else if (ap == 7){
                
                    targetAngleHigh = new Vector3(0,0,93f);
                
            }
            
            //Scenario 2
            else if (ap == 9){
                
                    targetAngleHigh = new Vector3(0,0,-102f);
                
            } */
             
            
            
            }
    
            if (redPointer.done == true){
                timer += 1 * Time.deltaTime;
                if (timer >= 0.6f){
            
                        
                        currentAngle = new Vector3(0,0, Mathf.LerpAngle(transform.eulerAngles.z, targetAngleHigh.z, Time.deltaTime));
             
                        transform.eulerAngles = currentAngle;
                        if (done != null){
    done.interactable = true;
        }
                        if (futureAP != null){

                        futureAP.enabled = true;
                        }
                       
                
                
            }
        }
                
            }

        
	
	

     /* public void MouseClick () // When clicked
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
    } */

}
