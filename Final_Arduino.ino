//ARDUINO PROGRAMMING CODE

#include <SoftwareSerial.h>
SoftwareSerial nodemcu(2,3); //ENABLES SERIAL COMMUNICATION BETWEEN NODE MCU
                             // AND ARDUINO. RX PORT OF NODE MCU IS CONNECTED 
                             // WITH PORT 2 OF ARDUINO AND TX PORT OF NODE MCU
                             // IS CONNECTED WITH THE PORT 3 OF ARDUINO

int parking1_slot1_ir_s = 4; //FOR PARKING 1 SLOT 1 TO BE CONNECTED WITH PIN NO. 4 OF ARDUINO
int parking1_slot2_ir_s = 5; //FOR PARKING 1 SLOT 2 TO BE CONNECTED WITH PIN NO. 5 OF ARDUINO
int parking1_slot3_ir_s = 6; //FOR PARKING 1 SLOT 3 TO BE CONNECTED WITH PIN NO. 6 OF ARDUINO

int parking2_slot1_ir_s = 7; //FOR PARKING 2 SLOT 1 TO BE CONNECTED WITH PIN NO. 7 OF ARDUINO
int parking2_slot2_ir_s = 8; //FOR PARKING 2 SLOT 2 TO BE CONNECTED WITH PIN NO. 8 OF ARDUINO
int parking2_slot3_ir_s = 9; //FOR PARKING 2 SLOT 3 TO BE CONNECTED WITH PIN NO. 9 OF ARDUINO

String sensor1; //DECLARAION OF SIX SENSOR STATUS VARIABLES FOR DESKTOP APPLICATION
String sensor2; //THEIR VALUES WILL BE SENT TO VB.NET IN ORDER TO COMPRIHEND THE SENSOR STATUS
String sensor3; 
String sensor4; 
String sensor5; 
String sensor6; 

String sensorA; //DECLARATION OF SIX SENSOR STATUS VARIABLES FOR MOBILE APPLICAITON
String sensorB; //THEIR VALUES WILL BE SENT TO BLYNK APPLICATION IN ORDER TO COMPRIHEND THE SENSOR
String sensorC; //STATUS
String sensorD; 
String sensorE; 
String sensorF; 

void p1slot1(); //PREDECLARATIONO OF THE SUB FUNCTION WHICH WILL BE CALLED LATER ON
void p1slot2(); //THE SUB FUNCTIONS ARE NAMED AS PER THE PARKING LOT AND ITS SLOTS
void p1slot3(); //RESPECTIVELY
void p2slot1();
void p2slot2();
void p2slot3();


String cdata =""; // VARIABLE DECLARED FOR COMPLETE DATA OF SENSORS STATUS FOR DESKTOP
String ddata=""; // VARIABLE DECLARD FOR COMPLETE DATA OF SENSORS STATUS FOR MOBILE


void setup()
{
Serial.begin(9600); //FOR THE DISPLAY OF DESIRED OUTPUT IN SERIAL MONITOR
                    // KEEPINT THE BAUD RATE 9600


pinMode(parking1_slot1_ir_s, INPUT); //TAKING INPUT FROM THE SENSOR LOCATED IN PARKING 1 SLOT 1
pinMode(parking1_slot2_ir_s, INPUT); //TAKING INPUT FROM THE SENSOR LOCATED IN PARKING 1 SLOT 2
pinMode(parking1_slot3_ir_s, INPUT); //TAKING INPUT FROM THE SENSOR LOCATED IN PARKING 1 SLOT 3

pinMode(parking2_slot1_ir_s, INPUT); //TAKING INPUT FROM THE SENSOR LOCATED IN PARKING 2 SLOT 1
pinMode(parking2_slot2_ir_s, INPUT); //TAKING INPUT FROM THE SENSOR LOCATED IN PARKING 2 SLOT 2
pinMode(parking2_slot3_ir_s, INPUT); //TAKING INPUT FROM THE SENSOR LOCATED IN PARKING 2 SLOT 3

                                    // pinMode syntax: pinMode(arduino pin number, input/output)

}


void loop(){

//CALLING THE SUB FUNCTIONS OF EACH PARKING SLOTS TO CHECK ON ITS STATUS:

//PARKINT LOT 1
p1slot1(); 
p1slot2();
p1slot3(); 

//PARKING LOT 2
p2slot1();
p2slot2();
p2slot3();

   //INORDER TO GET THE ENTIRE DATA STATUS OF THE SENSORS FOR DESKTOP APPLICATION. (cdata)
   cdata = cdata + sensor1 +"," + sensor2 + ","+ sensor3 +","+ sensor4 + "," + sensor5 + "," + sensor6 +","; 
                                                                            // comma will be used a delimeter

   //INORDER TO GET THE ENTIRE DATA STATUS OF THE SENSORS FOR MOBILE APPLICATION. (ddata)
   ddata = ddata + sensorA +"," + sensorB + ","+ sensorC +","+ sensorD + "," + sensorE + "," + sensorF +",";
                                                                            // comma will be used a delimeter
   
   Serial.println(cdata); //TO PRINT ON SERIAL MONITOR 
   Serial.println(ddata); //TO PRINT ON SERIAL MONITOR
   nodemcu.println(ddata); //TO SEND THE ddata TO NODE MCU ESP 8266 WIFI MODULE

   delay(2000); // enables a delay of 2 seconds for syncronization of the timer of desktop and mobile apps
   
   cdata = ""; //empting the collective sensor data 
   ddata = ""; //empting the collective sensor data 
   
//AGAIN RESETTING ALL THE PARKING LOT SENSOR STATUS TO HIGH FOR ANOTHER SET OF DATA ENTRY
digitalWrite(parking1_slot1_ir_s, HIGH); 
digitalWrite(parking1_slot2_ir_s, HIGH); 
digitalWrite(parking1_slot3_ir_s, HIGH);

digitalWrite(parking2_slot1_ir_s, HIGH);
digitalWrite(parking2_slot2_ir_s, HIGH);
digitalWrite(parking2_slot3_ir_s, HIGH);

                                    //NOTE: SENSOR STATUS IS HIGH WHEN THERE IS NO VEHICLE IN FRONT OF SENSOR
                                    //      IT IS LOW WHEN THERE IS CAR IN FRONT OF THE SENSOR
}

//PXslotX is a user defined function, it has no return type and it doesn not take any argument as the input.
//if there is a car infront of the sensor it gives digital logic 0, and if no car then it give digital logic 1,
//depending on this, then we store pXsXon or pXsXoff.
//for the desktop app and 255 or 0 for the mobile app indication


//SUB-FUNCTIONS


void p1slot1() // parkng 1 slot1
{
  if( digitalRead(parking1_slot1_ir_s) == LOW) 
  {
  sensor1 = "p1s1on"; // parking1 slot1 (desktop app)
  sensorA = "255";    // parking1 slot1 (mobile app)
 delay(200); 
  }
  if( digitalRead(parking1_slot1_ir_s) == HIGH)
{
  sensor1 ="p1s1off"; // parking1 slot1 (desktop app)
  sensorA = "0";      // parking1 slot1 (mobile app)  
 delay(200);  
}
}


void p1slot2() // parkng 1 slot2
{
  if( digitalRead(parking1_slot2_ir_s) == LOW) 
  {
  sensor2 = "p1s2on"; // parking1 slot2 (desktop app)
  sensorB = "255";  // parking1 slot2 (mobile app)
 delay(200); 
  }
  if( digitalRead(parking1_slot2_ir_s) == HIGH)
{
  sensor2 ="p1s2off"; // parking1 slot1 (desktop app)
  sensorB = "0";      // parking1 slot2 (mobile app)
 delay(200);  
}
}


void p1slot3() // parkng 1 slot3
{
  if( digitalRead(parking1_slot3_ir_s) == LOW) 
  {
  sensor3 = "p1s3on"; // parking1 slot3 (desktop app)
  sensorC = "255";  // parking1 slot3 (mobile app)
 delay(200); 
  }
  if( digitalRead(parking1_slot3_ir_s) == HIGH)
{
  sensor3 ="p1s3off"; // parking1 slot3 (desktop app)
  sensorC = "0";      // parking1 slot3 (mobile app)
 delay(200);  
}
}


void p2slot1() // parkng 2 slot1
{
  if( digitalRead(parking2_slot1_ir_s) == LOW) 
  {
  sensor4 = "p2s1on"; // parking2 slot1 (desktop app)
  sensorD = "255"; // parking2 slot1 (mobile app)
 delay(200); 
  }
  if( digitalRead(parking2_slot1_ir_s) == HIGH)
{
  sensor4 ="p2s1off"; // parking2 slot1 (desktop app)
  sensorD = "0";      // parking2 slot1 (mobile app)
 delay(200);  
}
}


void p2slot2() // parkng 2 slot2
{
  if( digitalRead(parking2_slot2_ir_s) == LOW) 
  {
  sensor5 = "p2s2on"; // parking2 slot2 (desktop app)
  sensorE = "255";  // parking2 slot2 (mobile app)
 delay(200); 
  }
  if( digitalRead(parking2_slot2_ir_s) == HIGH)
{
  sensor5 ="p2s2off"; // parking2 slot2 (desktop app)
  sensorE = "0";      // parking2 slot2 (mobile app)
 delay(200);  
}
}


void p2slot3() // parkng 2 slot3
{
  if( digitalRead(parking2_slot3_ir_s) == LOW) 
  {
  sensor6 = "p2s3on"; // parking2 slot3 (desktop app)
  sensorF = "255";  // parking2 slot3 (mobile app)
 delay(200); 
  }
  if( digitalRead(parking2_slot3_ir_s) == HIGH)
{
  sensor6 ="p2s3off"; // parking2 slot3 (desktop app)
  sensorF = "0";      //parking2 slot3 (mobile app)
 delay(200);  
}
}
