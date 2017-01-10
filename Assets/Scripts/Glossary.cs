using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Glossary : MonoBehaviour {

    public Text description;
    public Text thisDescription;
    public Text title;
    public string name;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Whoop(){

        description.text = thisDescription.text;
        title.text = name;
    }
 
    public void Reset(){

        title.text = "Glossary";
        description.text = "Click the terms on the left to read a definition!";

    }
}
