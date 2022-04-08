#include <Uduino.h>

//Water sensor for watering can

//inputs in the arduino
#define water_output   7
#define signal_pin A5
#define trigger_limit 300


//water level that will be adjusted as the water gets higher up on the sensor
int water_level = 0; 

void setup() 
{
  Serial.begin(9600);
  pinMode(water_output, OUTPUT);   
  digitalWrite(water_output, LOW); 

}

//loop for sensor to read water levels as its tilted up
void loop() 
{

   //----------WATERING CAN----------
   //turns sensor on 
   digitalWrite(water_output, HIGH);  
   delay(10);                      
   //reads water level from sensor
   water_level = analogRead(signal_pin);
   //turns sensor off
   digitalWrite(water_output, LOW);   
  
   //outputs water level
   Serial.print("Sensor value: ");
   Serial.println(water_level);

   delay(1000); 




  //if water goes over a certain level, TRIGGER is triggered and becomes true
}
