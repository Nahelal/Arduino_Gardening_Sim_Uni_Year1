#include<Uduino.h>



int button = 2;   //button

int waterValue = 0;   //water 
#define POWER_PIN  7   
#define SIGNAL_PIN A5

void setup()
{
  // put your setup code here, to run once:
  pinMode(button, INPUT);   //button
  digitalWrite(button, HIGH);
  Serial.begin(9600);

  pinMode(POWER_PIN, OUTPUT);   //water 
  digitalWrite(POWER_PIN, LOW);
  
}


void loop() 
{
    // put your main code here, to run repeatedly:


      buttonInp();
      waterInp();
      lightInp();


}

//button
void buttonInp()
{
  if (digitalRead(button)==LOW)
  {
    Serial.println("Button is pressed");
  }
  delay(1000);
}
  
  //water
void waterInp()
{
  digitalWrite(POWER_PIN, HIGH);  
  delay(10);                      
  waterValue = analogRead(SIGNAL_PIN); 
  digitalWrite(POWER_PIN, LOW);   
  Serial.print("Water sensor value: ");
  Serial.println(waterValue);
  delay(1000);
}

//light
void lightInp()
{
  int analogValue = analogRead(A0);
  Serial.print("Analog reading: ");
  Serial.print(analogValue);   

  if (analogValue < 120)
  {
    Serial.println(" - Dark");
  } 
    else if (analogValue < 800)
    {
    Serial.println(" - Bright");
  } 
  else
  {
    Serial.println(" - Very bright");
  }
  delay(500);
}
