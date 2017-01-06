using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MCButton : MonoBehaviour {

    public string rightAnswer;
    public string wrongAnswer1;
    public string wrongAnswer2;
    public string wrongAnswer3;

    public string rightDes;
    public string wrongDes;

    
    public GameObject rightPopup;
    public GameObject wrongPopup;
    public Text RdesBox;
    public Text WdesBox;
    

    public Button choice1;
    public Button choice2;
    public Button choice3;
    public Button choice4;
    private int whichButton;

    public GameManager gm;

	// Use this for initialization
	void Start () {

        wrongPopup.SetActive(false);
        rightPopup.SetActive(false);
	
        whichButton = Random.Range (1,5);
        if (whichButton == 1){
            choice1.GetComponentInChildren<Text>().text = rightAnswer;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice1);
            SetIncorrect(choice2);
            SetIncorrect(choice3);
            SetIncorrect(choice4);
        }
        if (whichButton == 2){
            choice2.GetComponentInChildren<Text>().text = rightAnswer;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice2);
            SetIncorrect(choice1);
            SetIncorrect(choice3);
            SetIncorrect(choice4);
        }
        if (whichButton == 3){
            choice3.GetComponentInChildren<Text>().text = rightAnswer;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice3);
            SetIncorrect(choice2);
            SetIncorrect(choice1);
            SetIncorrect(choice4);
        }

        if (whichButton == 4){
            choice4.GetComponentInChildren<Text>().text = rightAnswer;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice4);
            SetIncorrect(choice2);
            SetIncorrect(choice1);
            SetIncorrect(choice3);
        }
	}
	
    public void UpdateAnswers(){

    whichButton = Random.Range (1,5);
        if (whichButton == 1){
            choice1.GetComponentInChildren<Text>().text = rightAnswer;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice1);
            SetIncorrect(choice2);
            SetIncorrect(choice3);
            SetIncorrect(choice4);
        }
        if (whichButton == 2){
            choice2.GetComponentInChildren<Text>().text = rightAnswer;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice2);
            SetIncorrect(choice1);
            SetIncorrect(choice3);
            SetIncorrect(choice4);
        }
        if (whichButton == 3){
            choice3.GetComponentInChildren<Text>().text = rightAnswer;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice3);
            SetIncorrect(choice2);
            SetIncorrect(choice1);
            SetIncorrect(choice4);
        }

        if (whichButton == 4){
            choice4.GetComponentInChildren<Text>().text = rightAnswer;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice4);
            SetIncorrect(choice2);
            SetIncorrect(choice1);
            SetIncorrect(choice3);
        }


    }
	
    void SetCorrect(Button button){
    button.onClick.RemoveListener(delegate { WrongAnswer(); });
    button.onClick.RemoveListener(delegate { RightAnswer(); });
    button.onClick.AddListener(delegate { RightAnswer(); });

    }

    void SetIncorrect(Button button){
        button.onClick.RemoveListener(delegate { RightAnswer(); });
        button.onClick.RemoveListener(delegate { WrongAnswer(); });
        button.onClick.AddListener(delegate { WrongAnswer(); });

    }

    void RightAnswer(){
        RdesBox.text = rightDes;
        gm.ProgressUpdate();
        
        rightPopup.SetActive(true);
        wrongPopup.SetActive(false);
        
    }

    void WrongAnswer(){

        WdesBox.text = wrongDes;
        
       
        wrongPopup.SetActive(true);
        rightPopup.SetActive(false);
        
    }
}
