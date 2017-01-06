using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MCQuestion : MonoBehaviour {

   /*  public float currentTemp;
    public float currentWind;
    public float currentHumidity;
    public float currentAP;
    
    public float futureTemp;
    public float futureWind;
    public float futureHumidity;
    public float futureAP; */

    public Text currentTempT;
    public Text currentWindT;
    public Text currentHumidityT;
    public Text currentAPT;
    
    public Text futureTempT;
    public Text futureWindT;
    public Text futureHumidityT;
    public Text futureAPT;

    public Text question;

    public MCButton answers;

    public bool set1;
    public bool set2;
    public bool set3;
    public bool set4;

    public GameObject victorypanel;

	// Use this for initialization
	void Start () {
	
       
            int randy = Random.Range(1,4);
            if (randy == 1){
                Question1();
            }
            if (randy == 2){
                Question2();
            }
            if (randy == 3){
                Question3();
            }
            answers.UpdateAnswers();
        

         
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CycleQuestion(){

        if (set1 == true){
            set1 = false;
            set2 = true;
            int randy = Random.Range(4,7);
            if (randy == 4){
                Question4();
            }
            if (randy == 5){
                Question5();
            }
            if (randy == 6){
                Question6();
            }
        }

        else if (set2 == true){
            set2 = false;
            set3 = true;
             int randy = Random.Range(7,10);
            if (randy == 7){
                Question7();
            }
            if (randy == 8){
                Question8();
            }
            if (randy == 9){
                Question9();
            }   
        }

        else if (set3 == true){
            set3 = false;
            set4 = true;
             int randy = Random.Range(10,13);
            if (randy == 10){
                Question10();
            }
            if (randy == 11){
                Question11();
            }
            if (randy == 12){
                Question12();
            }
        }

        else if (set4 == true){
            victorypanel.SetActive(true);
        }
        
            answers.UpdateAnswers();

        }

    //Current weather

    void Question1(){

        currentTempT.text ="88°F";
        currentWindT.text ="5";
        currentHumidityT.text ="15";
        currentAPT.text ="1033";

        question.text ="Based on the given data, what is the current weather like? Choose the closest answer.";

        answers.rightAnswer = "A hot dry day with a clear sky";
        answers.wrongAnswer1 = "A hot humid day and cloudy skies";
        answers.wrongAnswer2 = "A hot stormy day";
        answers.wrongAnswer3 = "A cool stormy day";

    }

    void Question2(){

        currentTempT.text ="62°F";
        currentWindT.text ="23 MPH";
        currentHumidityT.text ="77";
        currentAPT.text ="977";

        question.text ="Based on the given data, what is the current weather like? Choose the closest answer.";

        answers.rightAnswer = "A cool stormy day";
        answers.wrongAnswer1 = "A hot stormy day";
        answers.wrongAnswer2 = "A hot dry day with a clear sky";
        answers.wrongAnswer3 = "A hot humid day and cloudy skies";

    }

    void Question3(){

        currentTempT.text ="92°F";
        currentWindT.text ="9 MPH";
        currentHumidityT.text ="68";
        currentAPT.text ="998";

        question.text ="Based on the given data, what is the current weather like? Choose the closest answer.";

        answers.rightAnswer = "A hot humid day and cloudy skies";
        answers.wrongAnswer1 = "A cool stormy day";
        answers.wrongAnswer2 = "A hot stormy day";
        answers.wrongAnswer3 = "A hot dry day with a clear sky";

    }

////////////////////////////////

    //Current and future weather

    void Question4(){

        currentTempT.text ="86°F";
        currentWindT.text ="7 MPH";
        currentHumidityT.text ="16%";
        currentAPT.text ="1031";

        futureTempT.text ="55°F";
        futureWindT.text ="22 MPH";
        futureHumidityT.text ="41%";
        futureAPT.text ="981";

        question.text ="Compare the current data and the future data. How did the weather change from current to future conditions?";

        answers.rightAnswer = "It went from a hot dry day to a cool stormy day";
        answers.wrongAnswer1 = "It went from a cool stormy day to a hot dry day";
        answers.wrongAnswer2 = "It went from a hot dry day to a hot stormy day";
        answers.wrongAnswer3 = "It stayed the same";

    }

    void Question5(){

        currentTempT.text ="61°F";
        currentWindT.text ="20 MPH";
        currentHumidityT.text ="73%";
        currentAPT.text ="974";

        futureTempT.text ="88°F";
        futureWindT.text ="7 MPH";
        futureHumidityT.text ="43%";
        futureAPT.text ="1011";

        question.text ="Compare the current data and the future data. How did the weather change from current to future conditions?";

        answers.rightAnswer = "It went from a cool stormy day to a hot dry day";
        answers.wrongAnswer1 = "It went from a hot dry day to a cool stormy day";
        answers.wrongAnswer2 = "It went from a hot dry day to a hot stormy day";
        answers.wrongAnswer3 = "It stayed the same";

    }

    void Question6(){

        currentTempT.text ="91°F";
        currentWindT.text ="11 MPH";
        currentHumidityT.text ="70%";
        currentAPT.text ="1001";

        futureTempT.text ="89°F";
        futureWindT.text ="7 MPH";
        futureHumidityT.text ="64%";
        futureAPT.text ="1004";

        question.text ="Compare the current data and the future data. How did the weather change from current to future conditions?";

        answers.rightAnswer = "It stayed the same";
        answers.wrongAnswer1 = "It went from a hot dry day to a cool stormy day";
        answers.wrongAnswer2 = "It went from a cool stormy day to a hot dry day";
        answers.wrongAnswer3 = "It went from a hot dry day to a hot stormy day";

    }

////////////////////////////////

    //Results and fill in missing

    void Question7(){

        currentTempT.text ="70°F";
        currentWindT.text ="?";
        currentHumidityT.text ="31%";
        currentAPT.text ="1010";

        futureTempT.text ="48°F";
        futureWindT.text ="26 MPH";
        futureHumidityT.text ="88%";
        futureAPT.text ="985";

        question.text ="You have been provided what kind of weather will happen tomorrow. Based on that information, what was the wind speed?";

        answers.rightAnswer = "5 MPH";
        answers.wrongAnswer1 = "20 MPH";
        answers.wrongAnswer2 = "34 MPH";
        answers.wrongAnswer3 = "23 MPH";

    }

    void Question8(){

        currentTempT.text ="?";
        currentWindT.text ="19 MPH";
        currentHumidityT.text ="69%";
        currentAPT.text ="978";

        futureTempT.text ="73°F";
        futureWindT.text ="13 MPH";
        futureHumidityT.text ="41%";
        futureAPT.text ="996";

        question.text ="You have been provided what kind of weather will happen tomorrow. Based on that information, what was the temperature?";

        answers.rightAnswer = "64°F";
        answers.wrongAnswer1 = "33°F";
        answers.wrongAnswer2 = "78°F";
        answers.wrongAnswer3 = "91°F";

    }
 
    void Question9(){

        currentTempT.text ="89°F";
        currentWindT.text ="9 MPH";
        currentHumidityT.text ="65%";
        currentAPT.text ="?";

        futureTempT.text ="90°F";
        futureWindT.text ="8 MPH";
        futureHumidityT.text ="64%";
        futureAPT.text ="1025";

        question.text ="You have been provided what kind of weather will happen tomorrow. Based on that information, what was the air pressure?";

        answers.rightAnswer = "1024";
        answers.wrongAnswer1 = "961";
        answers.wrongAnswer2 = "1041";
        answers.wrongAnswer3 = "989";

    }

////////////////////////////////

    //Current weather + future AP

    void Question10(){


    }

    void Question11(){


    }

    void Question12(){


    }
}
