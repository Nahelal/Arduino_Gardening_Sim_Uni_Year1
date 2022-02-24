# **COMP 140 game controller proposal** 

#### **LW260328**



### Idea summary
For my game controller project, i want to create a fast paced gardening simulator which resembles the game 'bop-it'. This is going to be through having three different input types which corespond to three basic need for a plant. This will be a watering can using a moisture sensor, a bottle of nutrients, which will have a button, and finally, a sun which will use the thermal sensor. The player will be looking at a 2D game interface, which i will use unity to create, where there will be the plant, the next input wanted from the player, and the players current score. As the player chooses the correct input to help the plant grow, the LED lights around the planter will turn green and the plant on the 2D interface will grow. If the player selects the wrong input, the LED lights will turn red and the player will lose one life. If the player loses all 3 lives, the game ends and their score is printed on the screen. If the player score is higher than any of the top five current scores, it is added to the leaderboard on the main menu screen of the game.


### Controller design
There will be three small controllers in order to play my game, these being the watering can, nutrients and sun. The three sensors will be hidden amongst the three coresponding controllers, which will be 3D printed to create a clean look. The planter will also be 3D printed and will be additionally used to hide all of the elecronic components like the Arduino and most of the wires. These will still be accessible through the base of the planter so i can still get to it if needed. This also makes the game controller more portable and less breakable when in use.


### User stories
+ Create script for the input sensors and their interaction with the game interface which will be between the Arduino and Uduino in unity.
+ Work on making the 2D game interface in unity.
+ Work on creating the Arduino circuit connecting all three inputs for the controllers together.
+ Practice 3d modelling certain components that will need to be 3D printed for my game controller.
+ Print components such as the planter, which will be holding the Arduino when the game controller is complete.
+ Find people to playtest the controller to see if there are any problems or bugs i havent found or considered.


### Key Components
+ Arduino
+ LEDs in two colours
+ Button
+ Moisture sensor 
+ Thermal sensor 
+ Longer wires





