﻿using UnityEngine;
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

  

    //Rationales
    public string rightT;
    public string wrongT1;
    public string wrongT2;
    public string wrongT3;

    public MCButton answers;

    public bool set1;
    public bool set2;
    public bool set3;
    public bool set4;

    public WhichAnswer answer1;
    public WhichAnswer answer2;
    public WhichAnswer answer3;
    public WhichAnswer answer4;

    public GameObject victorypanel;

    public GameManager gm;

	// Use this for initialization
	void Start () {
	
       
           if (set1 == true){
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
            gm.ProgressUpdate();
            answers.UpdateAnswers();
            answer1.Activate();
            answer2.Activate();
            answer3.Activate();
            answer4.Activate();
        }

        

    public void FinalQuestion1(){

        currentTempT.text = gm.temp + "°F";
        currentWindT.text = gm.windSpeedM + " MPH";
        currentHumidityT.text = gm.humidity.ToString() + "%";
        currentAPT.text = gm.airPressure.ToString() + "Mb";

        futureAPT.text = gm.predictAirPressure.ToString() + "Mb";
        question.text = "What will the weather be like tomorrow based on the data you collect?";

        if (gm.Scene1 == true){
        answers.rightAnswer = "Tomorrow will be a cold rainy day.";
        rightT = "Tomorrow's weather turned out to be exactly what you said! Great job! When the air pressure drops significantly it indicates that bad weather is coming. This includes fast wind speeds, a drop in temperature, and rainy weather.";
        answers.wrongAnswer1 = "Tomorrow will be a hot rainy day.";
        answers.wrongAnswer2 = "Tomorrow will be a cold dry calm day.";
        answers.wrongAnswer3 = "Tomorrow will be a hot dry day.";
        wrongT1 = "Oh darn, your prediction was wrong. Tomorrow turned out to be a cold rainy day.  The air pressure dropped significantly, indicating bad weather is coming. This includes faster wind speed and a drop in temperature. In this case it was also humid outside, meaning a much higher chance of rain. Next time you can use that information to make a better prediction. ";
        wrongT2 = "Oh darn, your prediction was wrong. Tomorrow turned out to be a cold rainy day.  The air pressure dropped significantly, indicating bad weather is coming. This includes faster wind speed and a drop in temperature. In this case it was also humid outside, meaning a much higher chance of rain. Next time you can use that information to make a better prediction. ";
        wrongT3 = "Oh darn, your prediction was wrong. Tomorrow turned out to be a cold rainy day.  The air pressure dropped significantly, indicating bad weather is coming. This includes faster wind speed and a drop in temperature. In this case it was also humid outside, meaning a much higher chance of rain. Next time you can use that information to make a better prediction. ";
        }
        else if (gm.Scene2 == true){

            answers.rightAnswer = "Tomorrow will be a hot sunny calm day.";
        rightT = "Tomorrow's weather turned out to be exactly what you said! Great job! The air pressure stayed the same, which means that the weather stayed about the same.";
        answers.wrongAnswer1 = "Tomorrow will be a cold rainy day.";
        answers.wrongAnswer2 = "Tomorrow will be a cold dry calm day.";
        answers.wrongAnswer3 = "Tomorrow will be a hot rainy day.";
        wrongT1 = "Oh no, your prediction was wrong. Tomorrow turned out to be a hot sunny calm day. Let's look over the data again. The air pressure stayed the same. This means that no significant weather changes are coming. The temperature, wind speed, and humidity will all stay about the same. Next time you can use that information to make a better prediction. ";
        wrongT2 = "Oh no, your prediction was wrong. Tomorrow turned out to be a hot sunny calm day. Let's look over the data again. The air pressure stayed the same. This means that no significant weather changes are coming. The temperature, wind speed, and humidity will all stay about the same. Next time you can use that information to make a better prediction. ";
        wrongT3 = "Oh no, your prediction was wrong. Tomorrow turned out to be a hot sunny calm day. Let's look over the data again. The air pressure stayed the same. This means that no significant weather changes are coming. The temperature, wind speed, and humidity will all stay about the same. Next time you can use that information to make a better prediction. ";

        }
        else if (gm.Scene3 == true){

            answers.rightAnswer = "Tomorrow will be a cool dry calm day";
        rightT = "Tomorrow's weather turned out to be exactly what you said! Great job! The air pressure went up a little bit. This indicates that the weather is getting better. Higher air pressure indicates that warmer weather is on its way. However, the increase was not significant enough to make the weather hot.";
        answers.wrongAnswer1 = "Tomorrow will be a hot sunny calm day.";
        answers.wrongAnswer2 = "Tomorrow will be a cold windy rainy day.";
        answers.wrongAnswer3 = "Tomorrow will be a hot rainy day.";
        wrongT1 = "Your prediction was incorrect. Tomorrow turned out to be a cool windy day. Let's look over the data again. The air pressure went up a little bit. This indicates that the weather is getting better. Higher air pressure indicates that warmer weather is on its way. Next time you can use that information to make a better prediction.  ";
        wrongT2 = "Your prediction was incorrect. Tomorrow turned out to be a cool windy day. Let's look over the data again. The air pressure went up a little bit. This indicates that the weather is getting better. Higher air pressure indicates that warmer weather is on its way. Next time you can use that information to make a better prediction.  ";
        wrongT3 = "Your prediction was incorrect. Tomorrow turned out to be a cool windy day. Let's look over the data again. The air pressure went up a little bit. This indicates that the weather is getting better. Higher air pressure indicates that warmer weather is on its way. Next time you can use that information to make a better prediction.  ";

        }

    }

    //Current weather

    void Question1(){

        currentTempT.text ="88°F";
        currentWindT.text ="5 MPH";
        currentHumidityT.text ="15%";
        currentAPT.text ="1033 Mb";

        question.text = "Describe what the Day One weather is like. Choose the closest answer.";

        answers.rightAnswer = "A hot dry day with a clear sky";
        rightT = "Correct! High temperature, low humidity, and high air pressure point to a hot dry day with a clear sky.";
        answers.wrongAnswer1 = "A hot humid day and cloudy skies";
        answers.wrongAnswer2 = "A hot stormy day";
        answers.wrongAnswer3 = "A cool stormy day";

        wrongT1 = "Incorrect. The humidity level is only 15%, which is low. Try again.";
        wrongT2 = "Incorrect. It is a hot day, but take another look at the air pressure.";
        wrongT3 = "Incorrect. The temperature is fairly hot and the humidity is low.";

    }

    void Question2(){

        currentTempT.text ="62°F";
        currentWindT.text ="23 MPH";
        currentHumidityT.text ="77%";
        currentAPT.text ="977 Mb";

        question.text = "Describe what the Day One weather is like. Choose the closest answer.";
        rightT = "Correct! Mild temperatures, high humidity, fast wind speeds, and low air pressure all point to a cool stormy day.";
        answers.rightAnswer = "A cool stormy day";
        answers.wrongAnswer1 = "A hot stormy day";
        answers.wrongAnswer2 = "A hot dry day with a clear sky";
        answers.wrongAnswer3 = "A hot humid day and cloudy skies";

        wrongT1 = "Incorrect. It's not quite hot outside.";
        wrongT2 = "Incorrect. Take a look at the temperature again. Also, note how the humidity is very high.";
        wrongT3 = "Incorrect. Check the temperature and the air pressure again. ";

    }

    void Question3(){

        currentTempT.text ="92°F";
        currentWindT.text ="9 MPH";
        currentHumidityT.text ="68%";
        currentAPT.text ="998 Mb";

        question.text = "Describe what the day one weather is like. Choose the closest answer.";
        rightT = "Correct! High temperature, high humidity, and mild air pressure point to a hot humid day.";
        answers.rightAnswer = "A hot humid day and cloudy skies";
        answers.wrongAnswer1 = "A cool stormy day";
        answers.wrongAnswer2 = "A hot stormy day";
        answers.wrongAnswer3 = "A hot dry day with a clear sky";

        wrongT1 = "Incorrect. Take another look at the temperature";
        wrongT2 = "Incorrect, but close. It is a hot day with lots of humidity, but check the air pressure again.";
        wrongT3 = "Incorrect. Check the humidity again as well as the air pressure.";

    }

////////////////////////////////

    //Current and future weather

    void Question4(){

        currentTempT.text ="86°F";
        currentWindT.text ="7 MPH";
        currentHumidityT.text ="16%";
        currentAPT.text ="1031 Mb";

        futureTempT.text ="55°F";
        futureWindT.text ="22 MPH";
        futureHumidityT.text ="41%";
        futureAPT.text ="981 Mb";

        question.text = "Compare the day one data and the day two data. How did the weather change between them?";
        rightT = "Correct! Great job! It went from a hot dry day to a cool stormy day";
        answers.rightAnswer = "It went from a hot dry day to a cool stormy day";
        answers.wrongAnswer1 = "It went from a cool stormy day to a hot dry day";
        answers.wrongAnswer2 = "It went from a hot dry day to a hot stormy day";
        answers.wrongAnswer3 = "It stayed the same";

        wrongT1 = "Incorrect. Check the temperatures and  the humidity again.";
        wrongT2 = "Incorrect. Check the data on the second day again.";
        wrongT3 = "Incorrect. Look over the data again.";

    }

    void Question5(){

        currentTempT.text ="61°F";
        currentWindT.text ="20 MPH";
        currentHumidityT.text ="73%";
        currentAPT.text ="974 Mb";

        futureTempT.text ="88°F";
        futureWindT.text ="7 MPH";
        futureHumidityT.text ="43%";
        futureAPT.text ="1011 Mb";

        question.text = "Compare the day one data and the day two data. How did the weather change between them?";
        rightT = "Correct! Great job! It went from a cool stormy day to a hot dry day.";
        answers.rightAnswer = "It went from a cool stormy day to a hot dry day";
        answers.wrongAnswer1 = "It went from a hot dry day to a cool stormy day";
        answers.wrongAnswer2 = "It went from a hot dry day to a hot stormy day";
        answers.wrongAnswer3 = "It stayed the same";

        wrongT1 = "Incorrect. Check the temperatures and  the humidity again.";
        wrongT2 = "Incorrect. Check the temperature, humidity, and air pressure in the first day again.";
        wrongT3 = "Incorrect. Look over the data again.";

    }

    void Question6(){

        currentTempT.text ="91°F";
        currentWindT.text ="11 MPH";
        currentHumidityT.text ="70%";
        currentAPT.text ="1001 Mb";
    
        futureTempT.text ="89°F";
        futureWindT.text ="7 MPH";
        futureHumidityT.text ="64%";
        futureAPT.text ="1004 Mb";

        question.text = "Compare the day one data and the day two data. How did the weather change between them?";
        rightT = "Correct! Great job! The air pressure did not change, meaning the weather did not either.";
        answers.rightAnswer = "It stayed the same";
        answers.wrongAnswer1 = "It went from a hot dry day to a cool stormy day";
        answers.wrongAnswer2 = "It went from a cool stormy day to a hot dry day";
        answers.wrongAnswer3 = "It went from a hot dry day to a hot stormy day";

        wrongT1 = "Incorrect. Compare the temperatures again.";
        wrongT2 = "Incorrect. Compare the wind speed again.";
        wrongT3 = "Incorrect. Compare the air pressure again.";

    }

////////////////////////////////

    //Results and fill in missing

    void Question7(){

        currentTempT.text ="70°F";
        currentWindT.text ="?";
        currentHumidityT.text ="31%";
        currentAPT.text ="1010 Mb";

        futureTempT.text ="48°F";
        futureWindT.text ="26 MPH";
        futureHumidityT.text ="88%";
        futureAPT.text ="985 Mb";

        question.text = "You have been given the weather for Day Two. Based on that information, what was the wind speed on Day One?";
        rightT = "Correct! Based on the air pressure and higher humidity, you can assume that the weather went from calm to stormy.";
        answers.rightAnswer = "5 MPH";
        answers.wrongAnswer1 = "20 MPH";
        answers.wrongAnswer2 = "34 MPH";
        answers.wrongAnswer3 = "23 MPH";

        wrongT1 = "Incorrect. Look at the difference in air pressure.";
        wrongT2 = "Incorrect. Look at the difference in humidity.";
        wrongT3 = "Incorrect. Look at the difference in air pressure or humidity.";

    }

    void Question8(){

        currentTempT.text ="?";
        currentWindT.text ="19 MPH";
        currentHumidityT.text ="69%";
        currentAPT.text ="978 Mb";

        futureTempT.text ="73°F";
        futureWindT.text ="13 MPH";
        futureHumidityT.text ="41%";
        futureAPT.text ="996 Mb";

        //Missing rationale
        question.text = "You have been given the weather for Day Two. Based on that information, what was the temperature on Day One?";
        rightT = "Correct! The air pressure dropped a good amount. This usually means that colder weather is coming through.";
        answers.rightAnswer = "64°F";
        answers.wrongAnswer1 = "33°F";
        answers.wrongAnswer2 = "78°F";
        answers.wrongAnswer3 = "91°F";

        wrongT1 = "Incorrect. Look at the difference in air pressure. The temperature does not drop that dramatically.";
        wrongT2 = "Incorrect. Look at the difference in air pressure again. Did the air pressure stay the same?";
        wrongT3 = "Incorrect. Look at the difference in air pressure. What happens to the temperature when air pressure drops?";

    }
 
    void Question9(){

        currentTempT.text ="89°F";
        currentWindT.text ="9 MPH";
        currentHumidityT.text ="65%";
        currentAPT.text ="?";

        futureTempT.text ="90°F";
        futureWindT.text ="8 MPH";
        futureHumidityT.text ="64%";
        futureAPT.text ="1025 Mb";

        question.text = "You have been given the weather for Day Two. Based on that information, what was the air pressure on Day One?";
        rightT = "Correct! The temperature, wind speed, and humidity all stayed the same. This indicates that there was no change in air pressure.";
        answers.rightAnswer = "1024 Mb";
        answers.wrongAnswer1 = "961 Mb";
        answers.wrongAnswer2 = "1041 Mb";
        answers.wrongAnswer3 = "989 Mb";
    
        wrongT1 = "Incorrect. Look at the difference in the temperature.";
        wrongT2 = "Incorrect. Look at the difference in humidity.";
        wrongT3 = "Incorrect. Look at the difference in wind speed.";

    }

////////////////////////////////

    //Current weather + future AP

    void Question10(){

        currentTempT.text ="90°F";
        currentWindT.text ="8 MPH";
        currentHumidityT.text ="33%";
        currentAPT.text ="1030 Mb";


        futureTempT.text ="";
        futureWindT.text ="";
        futureHumidityT.text ="";
        futureAPT.text ="1025 Mb";
    
        question.text = "Based on the information what will be the forecast on day two?";
        rightT = "Correct! There was not a change in the air pressure, indicating that the weather has not changed much. The day before was was a hot, dry, calm day and so should the day after.";
        answers.rightAnswer = "Tomorrow will be a hot dry calm day";
        answers.wrongAnswer1 = "Tomorrow will be a cold dry calm day";
        answers.wrongAnswer2 = "Tomorrow will be a cold stormy day";
        answers.wrongAnswer3 = "Tomorrow will be a hot stormy day";
    
        wrongT1 = "Incorrect. Compare the air pressure again. Is 1025 air pressure warmer or colder weather?";
        wrongT2 = "Incorrect. Compare the air pressure again. Is 1025 air pressure clear or stormy weather?";
        wrongT3 = "Incorrect. Compare the air pressure again.";
    }

    void Question11(){

        currentTempT.text ="83°F";
        currentWindT.text ="5 MPH";
        currentHumidityT.text ="68%";
        currentAPT.text ="1024 Mb";

       
        futureAPT.text ="982 Mb";
         futureTempT.text ="";
        futureWindT.text ="";
        futureHumidityT.text ="";

        question.text = "Based on the information what will be the forecast on day two?";
        rightT = "Correct! The air pressure went from high to low indicating that bad weather is on its way. The high humidity also indicates a high chance of rain.";
        answers.rightAnswer = "Tomorrow will be a cool stormy day";
        answers.wrongAnswer1 = "Tomorrow will be a cold dry calm day";
        answers.wrongAnswer2 = "Tomorrow will be a hot dry calm day";
        answers.wrongAnswer3 = "Tomorrow will be a hot stormy day";

        wrongT1 = "Incorrect. Look at the air pressure and humidity again. The air pressure dropped dramatically.";
        wrongT2 = "Incorrect. What happens when the air pressure drops? Does it get colder or warmer?";
        wrongT3 = "Incorrect. What happens when the air pressure drops? Does it get colder or warmer?";
    }

    void Question12(){

        currentTempT.text ="55°F";
        currentWindT.text ="23 MPH";
        currentHumidityT.text ="88%";
        currentAPT.text ="972 Mb";

       
        futureAPT.text ="1017 Mb";
         futureTempT.text ="";
        futureWindT.text ="";
        futureHumidityT.text ="";

        question.text = "Based on the information what will be the forecast on day two?";
        rightT = "Correct. The air pressure went up dramatically indicating that warmer, clearer weather was on its way.";
        answers.rightAnswer = "Tomorrow will be a warm calm day";
        answers.wrongAnswer1 = "Tomorrow will be a hot dry calm day";
        answers.wrongAnswer2 = "The weather will stay the same";
        answers.wrongAnswer3 = "Tomorrow will be a hot stormy day";

        wrongT1 = "Incorrect.Compare the air pressure again and look at the starting temperature.";
        wrongT2 = "Incorrect. Compare the air pressure again.";
        wrongT3 = "Incorrect.Compare the air pressure again and look at the starting temperature..";

    }
}
