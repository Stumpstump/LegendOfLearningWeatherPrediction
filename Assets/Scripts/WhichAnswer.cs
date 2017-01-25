using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WhichAnswer : MonoBehaviour {

    public bool right;
    public bool wrong1;
    public bool wrong2;
    public bool wrong3;

    public MCQuestion q;

    public Text RdesBox;
    public Text WdesBox;
    

	// Use this for initialization
	void Start () {
    
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    

    public void Activate(){
    GetComponent<Button>().interactable = true;
        if (right == true){
            RdesBox.text = q.rightT;
           

        }

        else if (wrong1 == true){
            WdesBox.text = q.wrongT1;

        }

        else if (wrong2 == true){
            WdesBox.text = q.wrongT2;
        }
        
        else if (wrong3 == true){
            WdesBox.text = q.wrongT3;
    
        }

           
    }

    public void Reset(){
            right = false;
            wrong1 = false;
            wrong2 = false;
            wrong3 = false;

    }

    public void Disable(){
        if (wrong1 == true || wrong2 == true || wrong3 == true){
            GetComponent<Button>().interactable = false;

        }


    }
}
