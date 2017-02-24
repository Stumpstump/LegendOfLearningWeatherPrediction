using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CloudMove : MonoBehaviour {

    public float speed;
    private Vector3 newpos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.GetComponent<RectTransform>().localPosition.x > -588f){
        newpos = new Vector3((gameObject.GetComponent<RectTransform>().position.x - speed), gameObject.GetComponent<RectTransform>().position.y, gameObject.GetComponent<RectTransform>().position.z);
        gameObject.GetComponent<RectTransform>().position = Vector3.Lerp (gameObject.GetComponent<RectTransform>().position, newpos, Time.deltaTime);
        }
        else if (gameObject.GetComponent<RectTransform>().localPosition.x <= -588f){
            gameObject.GetComponent<RectTransform>().localPosition = new Vector3(153f, gameObject.GetComponent<RectTransform>().localPosition.y, gameObject.GetComponent<RectTransform>().localPosition.z);
        }
	
	}
}
