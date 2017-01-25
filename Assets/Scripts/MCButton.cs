using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using LoLSDK;

public class MCButton : MonoBehaviour {

    public string rightAnswer;
    public string wrongAnswer1;
    public string wrongAnswer2;
    public string wrongAnswer3;

   

    
    public GameObject rightPopup;
    public GameObject wrongPopup;
    
    

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
	
        whichButton = Random.Range(1,5);
        if (whichButton == 1){
            choice1.GetComponentInChildren<Text>().text = rightAnswer;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice1);
            choice1.GetComponent<WhichAnswer>().right = true;
            SetIncorrect(choice2);
            choice2.GetComponent<WhichAnswer>().wrong1 = true;
            SetIncorrect(choice3);
            choice3.GetComponent<WhichAnswer>().wrong2 = true;
            SetIncorrect(choice4);
            choice4.GetComponent<WhichAnswer>().wrong3 = true;
        }
        else if (whichButton == 2){
            choice2.GetComponentInChildren<Text>().text = rightAnswer;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            choice2.GetComponent<WhichAnswer>().right = true;
            SetCorrect(choice2);
            SetIncorrect(choice1);
            choice1.GetComponent<WhichAnswer>().wrong2 = true;
            SetIncorrect(choice3);
            choice3.GetComponent<WhichAnswer>().wrong1 = true;
            SetIncorrect(choice4);
            choice4.GetComponent<WhichAnswer>().wrong3 = true;
        
        }
        else if (whichButton == 3){
            choice3.GetComponentInChildren<Text>().text = rightAnswer;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

             choice3.GetComponent<WhichAnswer>().right = true;
            SetCorrect(choice3);
            SetIncorrect(choice2);
            choice2.GetComponent<WhichAnswer>().wrong2 = true;
            SetIncorrect(choice1);  
            choice1.GetComponent<WhichAnswer>().wrong1 = true;
            SetIncorrect(choice4);
            choice4.GetComponent<WhichAnswer>().wrong3 = true;
        }

        else if (whichButton == 4){
            choice4.GetComponentInChildren<Text>().text = rightAnswer;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer3;

             choice4.GetComponent<WhichAnswer>().right = true;
            SetCorrect(choice4);
            SetIncorrect(choice2);
            choice2.GetComponent<WhichAnswer>().wrong3 = true;
            SetIncorrect(choice1);
            choice1.GetComponent<WhichAnswer>().wrong1 = true;
            SetIncorrect(choice3);
            choice3.GetComponent<WhichAnswer>().wrong2 = true;
        }
	}
	
    public void UpdateAnswers(){
    choice1.GetComponent<WhichAnswer>().Reset();
    choice2.GetComponent<WhichAnswer>().Reset();
    choice3.GetComponent<WhichAnswer>().Reset();
    choice4.GetComponent<WhichAnswer>().Reset();
    
    whichButton = Random.Range (1,5);
        if (whichButton == 1){
            choice1.GetComponentInChildren<Text>().text = rightAnswer;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            SetCorrect(choice1);
            choice1.GetComponent<WhichAnswer>().right = true;
            SetIncorrect(choice2);
            choice2.GetComponent<WhichAnswer>().wrong1 = true;
            SetIncorrect(choice3);
            choice3.GetComponent<WhichAnswer>().wrong2 = true;
            SetIncorrect(choice4);
            choice4.GetComponent<WhichAnswer>().wrong3 = true;
        }
        else if (whichButton == 2){
            choice2.GetComponentInChildren<Text>().text = rightAnswer;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

            choice2.GetComponent<WhichAnswer>().right = true;
            SetCorrect(choice2);
            SetIncorrect(choice1);
            choice1.GetComponent<WhichAnswer>().wrong2 = true;
            SetIncorrect(choice3);
            choice3.GetComponent<WhichAnswer>().wrong1 = true;
            SetIncorrect(choice4);
            choice4.GetComponent<WhichAnswer>().wrong3 = true;
        
        }
        else if (whichButton == 3){
            choice3.GetComponentInChildren<Text>().text = rightAnswer;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice4.GetComponentInChildren<Text>().text = wrongAnswer3;

             choice3.GetComponent<WhichAnswer>().right = true;
            SetCorrect(choice3);
            SetIncorrect(choice2);
            choice2.GetComponent<WhichAnswer>().wrong2 = true;
            SetIncorrect(choice1);  
            choice1.GetComponent<WhichAnswer>().wrong1 = true;
            SetIncorrect(choice4);
            choice4.GetComponent<WhichAnswer>().wrong3 = true;
        }

        else if (whichButton == 4){
            choice4.GetComponentInChildren<Text>().text = rightAnswer;
            choice1.GetComponentInChildren<Text>().text = wrongAnswer1;
            choice3.GetComponentInChildren<Text>().text = wrongAnswer2;
            choice2.GetComponentInChildren<Text>().text = wrongAnswer3;

             choice4.GetComponent<WhichAnswer>().right = true;
            SetCorrect(choice4);
            SetIncorrect(choice2);
            choice2.GetComponent<WhichAnswer>().wrong3 = true;
            SetIncorrect(choice1);
            choice1.GetComponent<WhichAnswer>().wrong1 = true;
            SetIncorrect(choice3);
            choice3.GetComponent<WhichAnswer>().wrong2 = true;
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
               
        
        LOLSDK.Instance.PlaySound("FX/click1.mp3");
        rightPopup.SetActive(true);
        wrongPopup.SetActive(false);
        
        
    }

    void WrongAnswer(){

        //WdesBox.text = wrongDes;
        
       LOLSDK.Instance.PlaySound("FX/click1.mp3");
        wrongPopup.SetActive(true);
        rightPopup.SetActive(false);
        
        
        
    }
}
