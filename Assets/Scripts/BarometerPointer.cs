using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarometerPointer : MonoBehaviour {

    private float mOffset = 0;
    
    private float tOffset;
    
    private float newpos;

    public bool locked;

    public GameObject pointer;

    

    public bool done;

   
    
	// Use this for initialization
	void Start () {
    
    locked = true;
    pointer.transform.eulerAngles = new Vector3(0, 0, Random.Range(-132f,134f));
    
    
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (locked == false){
            if (Mathf.Abs(gameObject.transform.eulerAngles.z - pointer.transform.eulerAngles.z) < 1.5){
                locked = true;
                done = true;
                
                

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
