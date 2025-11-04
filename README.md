# in-class-activities

## Devlogs

Hello World! lalalalalalalal!!! i am sick :( that is not lala

### W1

Write your W1 activity Devlog here.

### W2
The r, g, and b variables are floats and not integers, strings or booleans, because an integer is a whole number
and the r, g, b values are not whole numbers. Strings are text and booleans are either true or false, none of these
data types applies to what the r, g, b values are. Similarily, the bounce variable is an integer because it is a whole
number and not the other types of data. To be honest, I didn't really see what the error specifically noted but I just 
compared the existing statement to my understanding based on the lecture. This lead to me adding a semicolon at the end
of the line.

Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

### W3

The input parameters would be the player sanity level as a float data type. There is no output/void return because there
is no operated on and returned value.

A class is a kitchen and the member variables inside of it are ingredients or tools present inside of the kitchen, the member methods 
are the cooking techniques that are able to be used inside the kitchen based on the ingredients and tools. You can also borrow and
use tools from another kitchen, or class. The resulting dish, or component functionality, is made from this kitchen. 

I think that the balls get extremely bright in the Scene if they bounce too many times because the brightness is based
off the amount of times bounced so as the amount of bounces increases, so does the brightness.

### W4
 Declaring a private boolean member variable called _isGrounded that has the value of true.

 If statement checking for 2 conditions, the member method (because it has parantheses) that 
 has the argument of the space key, that checks if the space key is down, of the Input class 
 and checking the value of the member variable _isGrounded value.

 Sets the boolean variable to false.

 Table # 16 :D

 We added Rigidbodies to the cat and the soccer ball while having Is Trigger on for the goal. We did this because the cat and soccer ball were going to be physically impacted
 by collision and the goal would have the ball pass through it, unlike the cat and ball, but also trigger a reaction. 
One of the issues when I first tested my game was that my cat was floating. I fixed it by adjusting the size and placement of the capsule collider so that it did not create a 
large space underneath the cat that would have it floating. 

### W5
Activity 1: My question was on clarifying how references worked when it came to accessing methods from getting scripts or classes through GetComponent. The answer was that references store
the script that is returned from GetComponent as a variable. When you use the variable storing it, you would have a . between it and the method being used just like a normal class.

Activity 2: Make Monobehavior Class that will be connected to the Deer GameObject. There will be a SerializeField member variable that will represent the Transform component of the Deer by using 
GetComponent<>. There will be another variable that will use a similar reference and GetComponent statement to get the NavMeshAgent component which will use the SetDestination() 
method inside it The method would have Start() because we need it to happen when the game begins. We do not need to write our own methods we are mostly giving parameters to 
preexisitng methods.

### W6

Class Resource Guide:
Assigned to math, but I jumped around.
[link](https://docs.google.com/document/d/1_FuPSWqTkXPrMthJ3fE3VoS7TKVECOjqZArYk2FPLWk/edit?usp=sharing)

Pair Programming Plan:
Add script component to all bat objects.
Have a SerializeField float member variable for speed.
Have a vector variable representing player position.
Public methods that change value of enabled to false and true to get the bats to stop chasing the player.
Will also need Update() method to continue chasing player when enabled is true that will use transform.position.


## Open-Source Assets

### W1

* Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727
* Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153
