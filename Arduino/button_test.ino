#include <Uduino.h>

//button push input

const int button_input = 7;      

int old_state = LOW;  
int new_state;                

void setup()
{
  Serial.begin(9600);
  pinMode(button_input, INPUT_PULLUP);
}

void loop() 
{
  //----------BUTTON----------
  
  //checks if button is being pushed down or not
  new_state = digitalRead(button_input);

  if(old_state == HIGH && new_state == LOW)
  {
    Serial.println("On");
  }
  else if(old_state == LOW && new_state == HIGH)
  {
    Serial.println("Off");
  }

  // saves new button input over previous in 'old_state'
  old_state = new_state;
}
