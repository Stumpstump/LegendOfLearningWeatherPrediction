using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyboardStuff : MonoBehaviour {

 public bool running = true;
  public string kBoardString = "";
 
 private string tempString = "";
 private TouchScreenKeyboard keyboard;
 private bool iskBoardOpen = false;
 public Text urgh;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (running == true){

        plshalp();
        
        }

	}

    public void turnoff (){

    running = false;
    }

    public void plshalp(){
          if ( !iskBoardOpen ) 
         {
             keyboard = TouchScreenKeyboard.Open( tempString, TouchScreenKeyboardType.Default);
             iskBoardOpen = true;
         }
         
         if ( keyboard.done ) 
         {
             kBoardString = keyboard.text;
             tempString = "";
             iskBoardOpen = false;
         }
         else
         {
             urgh.text = keyboard.text;
         }

        }
}
