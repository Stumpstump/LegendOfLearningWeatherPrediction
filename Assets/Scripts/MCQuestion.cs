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
            Debug.Log(randy);
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
        currentAPT.text = gm.airPressure.ToString();

        futureAPT.text = gm.predictAirPressure.ToString();
        question.text = "What will the weather be like tomorrow based on the data you collect?";

        if (gm.Scene1 == true){
        answers.rightAnswer = "Tomorrow will be a cold rainy day.";
        rightT = "Tomorrow's weather turned out to be exactly what you said! Great job! When the air pressure drops significantly it indicates that bad weather is coming. This includes fast wind speeds, a drop in temperature, and rainy weather.";
        answers.wrongAnswer1 = "Tomorrow will be a hot rainy day.";
        answers.wrongAnswer2 = "Tomorrow will be a cold dry calm day.";
        answers.wrongAnswer3 = "Tomorrow will be a hot dry day.";
        wrongT1 = "Tomorrow's weather turned out to be exactly what you said! Great job! When the air pressure drops significantly it indicates that bad weather is coming. This includes fast wind speeds, a drop in temperature, and rainy weather.";
        wrongT2 = "Tomorrow's weather turned out to be exactly what you said! Great job! When the air pressure drops significantly it indicates that bad weather is coming. This includes fast wind speeds, a drop in temperature, and rainy weather.";
        wrongT3 = "Tomorrow's weather turned out to be exactly what you said! Great job! When the air pressure drops significantly it indicates that bad weather is coming. This includes fast wind speeds, a drop in temperature, and rainy weather.";

        }
        if (gm.Scene2 == true){

            answers.rightAnswer = "Tomorrow will be a hot sunny calm day.";
        rightT = "Tomorrow's weather turned out to be exactly what you said! Great job! The air pressure stayed the same, which means that the weather stayed about the same.";
        answers.wrongAnswer1 = "Tomorrow will be a cold rainy day.";
        answers.wrongAnswer2 = "Tomorrow will be a cold dry calm day.";
        answers.wrongAnswer3 = "Tomorrow will be a hot rainy day.";
        wrongT1 = "Oh no, your prediction was wrong. Tomorrow turned out to be a hot sunny calm day. Let's look over the data again. The air pressure stayed the same. This means that no significant weather changes are coming. The temperature, wind speed, and humidity will all stay about the same. Next time you can use that information to make a better prediction. ";
        wrongT2 = "Oh no, your prediction was wrong. Tomorrow turned out to be a hot sunny calm day. Let's look over the data again. The air pressure stayed the same. This means that no significant weather changes are coming. The temperature, wind speed, and humidity will all stay about the same. Next time you can use that information to make a better prediction. ";
        wrongT3 = "Oh no, your prediction was wrong. Tomorrow turned out to be a hot sunny calm day. Let's look over the data again. The air pressure stayed the same. This means that no significant weather changes are coming. The temperature, wind speed, and humidity will all stay about the same. Next time you can use that information to make a better prediction. ";

        }
        if (gm.Scene3 == true){

            answers.rightAnswer = "Tomorrow will be a cool cloudy windy day";
        rightT = "Tomorrow's weather turned out to be exactly what you said! Great job! The air pressure went up meaning that the weather got a bit warmer and is starting to clear up.";
        answers.wrongAnswer1 = "Tomorrow will be a hot sunny calm day.";
        answers.wrongAnswer2 = "Tomorrow will be a cold dry calm day.";
        answers.wrongAnswer3 = "Tomorrow will be a hot rainy day.";
        wrongT1 = "Your prediction was inccorect. Tomorrow turned out to be a cool windy day. Let's look over the data again. The air pressure went up a little bit. This indicates that the weather is getting better. Higher air pressure indicates that warmer weather is on its way and that weather is becoming more clear. Next time you can use that information to make a better prediction.  ";
        wrongT2 = "Your prediction was inccorect. Tomorrow turned out to be a cool windy day. Let's look over the data again. The air pressure went up a little bit. This indicates that the weather is getting better. Higher air pressure indicates that warmer weather is on its way and that weather is becoming more clear. Next time you can use that information to make a better prediction.  ";
        wrongT3 = "Your prediction was inccorect. Tomorrow turned out to be a cool windy day. Let's look over the data again. The air pressure went up a little bit. This indicates that the weather is getting better. Higher air pressure indicates that warmer weather is on its way and that weather is becoming more clear. Next time you can use that information to make a better prediction.  ";

        }

    }

    //Current weather

    void Question1(){

        currentTempT.text ="88°F";
        currentWindT.text ="5 MPH";
        currentHumidityT.text ="15%";
        currentAPT.text ="1033";

        question.text ="Based on the given data, what is the current weather like? Choose the closest answer.";

        answers.rightAnswer = "A hot dry day with a clear sky";
        rightT = "Correct! High temperature, low humidity, and high air pressure point to a hot dry day with a clear sky.";
        answers.wrongAnswer1 = "A hot humid day and cloudy skies";
        answers.wrongAnswer2 = "A hot stormy day";
        answers.wrongAnswer3 = "A cool stormy day";

        wrongT1 = "Incorrect. The humidity level is only 15%, which is low. Try again.";
        wrongT2 = "Incorrect. It is a hot day, but take another look at the air pressure.";
        wrongT3 = "Incorrect. The temprature is fairly hot and the humidity is low.";

    }

    void Question2(){

        currentTempT.text ="62°F";
        currentWindT.text ="23 MPH";
        currentHumidityT.text ="77%";
        currentAPT.text ="977";

        question.text ="Based on the given data, what is the current weather like? Choose the closest answer.";
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
        currentAPT.text ="998";

        question.text ="Based on the given data, what is the current weather like? Choose the closest answer.";
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
        currentAPT.text ="1031";

        futureTempT.text ="55°F";
        futureWindT.text ="22 MPH";
        futureHumidityT.text ="41%";
        futureAPT.text ="981";

        question.text ="Compare the current data and the future data. How did the weather change from current to future conditions?";
        rightT = "Correct! Good job.";
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
        currentAPT.text ="974";

        futureTempT.text ="88°F";
        futureWindT.text ="7 MPH";
        futureHumidityT.text ="43%";
        futureAPT.text ="1011";

        question.text ="Compare the current data and the future data. How did the weather change from current to future conditions?";
        rightT = "Correct! Good job.";
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
        currentAPT.text ="1001";
    
        futureTempT.text ="89°F";
        futureWindT.text ="7 MPH";
        futureHumidityT.text ="64%";
        futureAPT.text ="1004";

        question.text ="Compare the current data and the future data. How did the weather change from current to future conditions?";
        rightT = "Correct! Good job.";
        answers.rightAnswer = "It stayed the same";
        answers.wrongAnswer1 = "It went from a hot dry day to a cool stormy day";
        answers.wrongAnswer2 = "It went from a cool stormy day to a hot dry day";
        answers.wrongAnswer3 = "It went from a hot dry day to a hot stormy day";

        wrongT1 = "Incorrect. Check the data on the second day again.";
        wrongT2 = "Incorrect. Check the data on the first day again.";
        wrongT3 = "Incorrect. Check the air pressure of the second day.";

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
        rightT = "Correct! Based on the air pressure and higher humidity, one can assume that the weather went from calm to stormy.";
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
        currentAPT.text ="978";

        futureTempT.text ="73°F";
        futureWindT.text ="13 MPH";
        futureHumidityT.text ="41%";
        futureAPT.text ="996";

        //Missing rationale
        question.text ="You have been provided what kind of weather will happen tomorrow. Based on that information, what was the temperature?";
        rightT = "";
        answers.rightAnswer = "64°F";
        answers.wrongAnswer1 = "33°F";
        answers.wrongAnswer2 = "78°F";
        answers.wrongAnswer3 = "91°F";

        wrongT1 = "";
        wrongT2 = "";
        wrongT3 = "";

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
        rightT = "Correct! The temperature, wind speed, and humidity all stayed the same. This indicates that there was no change in air pressure.";
        answers.rightAnswer = "1024";
        answers.wrongAnswer1 = "961";
        answers.wrongAnswer2 = "1041";
        answers.wrongAnswer3 = "989";
    
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
        currentAPT.text ="1030";


        futureTempT.text ="";
        futureWindT.text ="";
        futureHumidityT.text ="";
        futureAPT.text ="1025";
    
        question.text ="Based on the current weather data and predicted air pressure, what will be tomorrow's forecast?";
        rightT = "Correct! There was not a change in the air pressure, which indicates that the weather has not changed much. The day before was was hot, dry, and calm, so the day after should be too.";
        answers.rightAnswer = "Tomorrow will be a hot dry calm day";
        answers.wrongAnswer1 = "Tomorrow will be a cold dry calm day";
        answers.wrongAnswer2 = "Tomorrow will be a cold stormy day";
        answers.wrongAnswer3 = "Tomorrow will be a hot stormy day";
    
        wrongT1 = "Incorrect. Usually the lower the air pressure is the colder it gets. Look at the air pressure again.";
        wrongT2 = "Incorrect. Look at the air pressure of the second day.";
        wrongT3 = "Incorrect. Look at the air pressure of the second day.";
    }

    void Question11(){

        currentTempT.text ="83°F";
        currentWindT.text ="5 MPH";
        currentHumidityT.text ="68%";
        currentAPT.text ="1024";

       
        futureAPT.text ="982";
         futureTempT.text ="";
        futureWindT.text ="";
        futureHumidityT.text ="";

        question.text ="Based on the current weather data and predicted air pressure, what will be tomorrow's forecast?";
        rightT = "Correct! The air pressure went from high to low indicating that bad weather is on its way. The high humidity also indicates a high chance of rain.";
        answers.rightAnswer = "Tomorrow will be a cool stormy day";
        answers.wrongAnswer1 = "Tomorrow will be a cold dry calm day";
        answers.wrongAnswer2 = "Tomorrow will be a hot dry calm day";
        answers.wrongAnswer3 = "Tomorrow will be a hot stormy day";

        wrongT1 = "Incorrect. Look at the air pressure and humidity again.";
        wrongT2 = "Incorrect. Look at the air pressure again.";
        wrongT3 = "Incorrect. Look at the air pressure again.";
    }

    void Question12(){

        currentTempT.text ="55°F";
        currentWindT.text ="23 MPH";
        currentHumidityT.text ="88%";
        currentAPT.text ="972";

       
        futureAPT.text ="1017";
         futureTempT.text ="";
        futureWindT.text ="";
        futureHumidityT.text ="";

        question.text ="Based on the current weather data and predicted air pressure, what will be tomorrow's forecast?";
        rightT = "Correct. The air pressure went up dramatically indicating that warmer, clearer weather was on its way.";
        answers.rightAnswer = "Tomorrow will be a warm calm day";
        answers.wrongAnswer1 = "Tomorrow will be a hot dry calm day";
        answers.wrongAnswer2 = "The weather will stay the same";
        answers.wrongAnswer3 = "Tomorrow will be a hot stormy day";

        wrongT1 = "Incorrect. Look at the air pressure again.";
        wrongT2 = "Incorrect. Look at the air pressure again.";
        wrongT3 = "Incorrect. Look at the air pressure again.";

    }
}
