using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MCButton : MonoBehaviour {

    public string rightAnswer;
    public string wrongAnswer1;
    public string wrongAnswer2;

    public string rightDes;
    public string wrongDes;

    
    public GameObject popup;
    public Text title;
    public Text desBox;
    

    public Button choice1;
    public Button choice2;
    public Button choice3;
    private int whichButton;

    public GameManager gm;

	// Use this for initialization
	void Start () {

        popup.SetActive(false);
	
        whichButton = Random.Range (1,4);
        if (whichButton == 1){
            choice1.GetComponentInChildren<Text>().text = rightAnswer;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer2;

            SetCorrect(choice1);
            SetIncorrect(choice2);
            SetIncorrect(choice3);
        }
        if (whichButton == 2){
            choice2.GetComponentInChildren<Text>().text = rightAnswer;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer2;

            SetCorrect(choice2);
            SetIncorrect(choice1);
            SetIncorrect(choice3);
        }
        if (whichButton == 3){
            choice3.GetComponentInChildren<Text>().text = rightAnswer;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer2;

            SetCorrect(choice3);
            SetIncorrect(choice2);
            SetIncorrect(choice1);
        }
	}
	
	
    void SetCorrect(Button button){
    button.onClick.AddListener(delegate { RightAnswer(); });

    }

    void SetIncorrect(Button button){
        button.onClick.AddListener(delegate { WrongAnswer(); });

    }

    void RightAnswer(){
        desBox.text = rightDes;
        gm.ProgressUpdate();
        choice1.interactable = false;
        choice2.interactable = false;
        choice3.interactable = false;
        popup.SetActive(true);
        title.text = "Nice Job!";
    }

    void WrongAnswer(){

        desBox.text = wrongDes;
        gm.ProgressUpdate();
        choice1.interactable = false;
        choice2.interactable = false;
        choice3.interactable = false;
        popup.SetActive(true);
        title.text = "Not quite!";
    }
}
