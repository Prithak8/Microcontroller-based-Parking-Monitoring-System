//NODEMCU 8266 PROGRAMMING (ARDUINO_IDE)


//INITIALIZATION OF REQUIRED LIBRARIES
#define BLYNK_PRINT Serial
#include <ESP8266WiFi.h>
#include <BlynkSimpleEsp8266.h>
#include <SoftwareSerial.h>


char auth[] = "h7N5_B-fz7K_51qODgI9pgWBx2zE8IG4"; //AUTHENTICATION TOKEN GENERATED FROM BLYNK APP



char ssid[] = " << Enter ssid >> ";   // WiFi credentials.
char pass[] = " << Enter password >> ";       // Password set in " " for open networks.

BlynkTimer timer;  //Declaratin of in-built blynk timer for syncronization purposes


String myString; // complete message from arduino, which consistors of snesors data
char rdata;      // received charactors

int firstVal, secondVal,thirdVal; // sensors 

int led1,led2,led3,led4,led5,led6; //variables declared for the LEDs present in Blynk app widgets

// This function sends Arduino's up time every second to Virtual Pin (1).
// In the app, Widget's reading frequency should be set to PUSH. 
// This indicates how often we send data to blynk app

void myTimerEvent()
{
  Blynk.virtualWrite(V1, millis() / 1000);
}


void setup()
{
  BlynkTimer timer;
  Serial.begin(9600);    //ACTIVATES SERIAL COMMUNICATION WITH BAUD RATE AS 9600
  Blynk.begin(auth, ssid, pass);   // INBUILT FUNCTION THAT ENABLES THE CONNECTION BETWEEN 
                                   // THE CODE HERE AND BLYNK APPLICATION
    
    //call of each time day and user defined function (sensorvalueX)
    timer.setInterval(1000L,sensorvalue1); // timer.setInterval(time,user-defined function), takes
                                           // in the delayed time and the user defined function as
                                           // its input. here, sersorvalue1 is a user defined funtion
                                           // defined below 
    timer.setInterval(1000L,sensorvalue2); 
    timer.setInterval(1000L,sensorvalue3);
    timer.setInterval(1000L,sensorvalue4);
    timer.setInterval(1000L,sensorvalue5);
    timer.setInterval(1000L,sensorvalue6);
}


void loop()
{
   if (Serial.available() == 0 ) // TRIGGERS THIS CONDITION IF NOD MCU MODULE HASN'T RECEIVED ANY DATA 
                                 
   {
      Blynk.run();               //INITIATES BLYNK APP
      timer.run();               // Initiates BlynkTimer
   }
   
  if (Serial.available() > 0 ) // TRIGGERS THIS CONDITION IF NOD MCU HAS RECEIVED DATA
  {
    rdata = Serial.read();     // reads out the first available byte from the serial receive buffer.
    myString = myString+ rdata; // ADD EACH CHARACTER WITH MYSTRING TO MAKE COMPLETE MESSAGE
   Serial.print(rdata);         // PRINTS THE FIRST AVAILABLE BYTE TO SERIAL PORT
   
    if( rdata == '\n')          // CONDITION MAKES SURE IF THE ENTIRE MESSAGE IS RECIEVED
    {
      Serial.println(myString); // DISPLAYS THE COLLECTIVE STATUS TO THE SERIAL MONITOR
      Serial.println("hello");  //this shows in serial monitor means the code is working properly
      
      
      // THE ENTIRE MESSAGE RECEIVED IS SPLITTED BY USING getValue function
      String l = getValue(myString, ',', 0);
      String m = getValue(myString, ',', 1);
      String n = getValue(myString, ',', 2);
      String o = getValue(myString, ',', 3);
      String p = getValue(myString, ',', 4);
      String q = getValue(myString, ',', 5);

      // these leds represents the leds used in Blynk application
      // We convert the spliited values to integers
      led1 = l.toInt();
      led2 = m.toInt();
      led3 = n.toInt();
      led4 = o.toInt();
      led5 = p.toInt();
      led6 = q.toInt();

      myString = "";   //reset myString for new data

    }
  }
}


//These sub-functions below are used to send the values stored to LED X of blynk app
                                // by the way of its degisnated virtual pins X (V-X)
void sensorvalue1()
{
int sdata = led1;
  // You can send any value at any time.
  Blynk.virtualWrite(V10, sdata);

}
void sensorvalue2()
{
int sdata = led2;
  // You can send any value at any time.
  Blynk.virtualWrite(V11, sdata);

}

void sensorvalue3()
{
int sdata = led3;
  // You can send any value at any time.
  Blynk.virtualWrite(V12, sdata);

}

void sensorvalue4()
{
int sdata = led4;
  // You can send any value at any time.
  Blynk.virtualWrite(V13, sdata);

}

void sensorvalue5()
{
int sdata = led5;
  // You can send any value at any time.
   Blynk.virtualWrite(V14, sdata);

}

void sensorvalue6()
{
int sdata = led6;
  // You can send any value at any time.
  Blynk.virtualWrite(V15, sdata);
}

//HERE getValue is a user-defined function that takes the parameters
// data, separator and index. It helps to separate the screen message
// using comma (,) as the delimiter

String getValue(String data, char separator, int index)
{
    int found = 0;
    int strIndex[] = { 0, -1 };
    int maxIndex = data.length() - 1;

    for (int i = 0; i <= maxIndex && found <= index; i++) {
        if (data.charAt(i) == separator || i == maxIndex) {
            found++;
            strIndex[0] = strIndex[1] + 1;
            strIndex[1] = (i == maxIndex) ? i+1 : i;
        }
    }
    return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}
