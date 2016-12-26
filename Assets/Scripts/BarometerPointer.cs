using UnityEngine;
using System.Collections;

public class BarometerPointer : MonoBehaviour {

    private float mOffset = 0;
    private float tOffset;
    
    private float newpos;
    
	// Use this for initialization
	void Start () {
    tOffset = transform.eulerAngles.z;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

        public void MouseClick () // When clicked
    {
        tOffset = transform.eulerAngles.z;
        mOffset = Input.mousePosition.x; // record where the cursor was when the object was clicked
    }
     
    public void MouseDrag () // For every frame the mouse is still down
    {
        newpos = (Input.mousePosition.x - mOffset) + tOffset; // Set the rotation to (how far the mouse has moved) + where we were
         gameObject.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, newpos);
    }

    
}
