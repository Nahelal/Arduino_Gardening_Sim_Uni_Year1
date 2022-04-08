#include <Uduino.h>

//light sensor for sun model

//light level will be measured and if it is over a certain calibrated level, the output will change
int light_input = analogRead(A0);

void setup() 
{
  Serial.begin(9600);
}

void loop() 
{

  //----------SUN----------
  Serial.print("Light level: ");
  Serial.print(light_input);   

  //if sun is facing down, output is 'dark'
  //if sun is facing up, output is 'light'
  if (light_input < 100)
  {
    Serial.println(" DARK");
  } 
  else 
  {
    Serial.println(" LIGHT");
  }

  delay(500);


}
