# in-class-activities
## Devlogs
### W1
Hello World!

### W2
The r, g, and b variables are floats because they are numbers and have decimal points/are not whole integers.

The _bounce variable is an int because it is assigned whole integers and will never have a decimal point.

The line of code was missing a semicolon at the end of the line.

### W3
Table: 11
The parameters would be an integer to check the current level of friendship and a boolean the check whether or not the player knows the character's secret. The return would be a string of the character's response.

1. We can think of classes as a student that can become a teacher assistant, or component. Within your student, you can teach them how to do different skill, which are methods, using knowledge that your student already knows, which are member variables.

2. I think that the balls got extremely bright because the code we uncommented in step 9 changed the ball's saturation. Depending on their speed, the saturation gets set really high which causes the ball to become bright.

### W4
Table 11
Line 17 declares a boolean member variable called "_isGrounded" and sets it to true. Line 28 is the start of an if statement that checks if the player pressed space and if the _isGrounded member variable is true. The if statement makes the cat jump. Line 32 sets "_isGrounded" to false. The "_isGrounded" variable is meant to show whether or not the cat is on the ground.

1. The objects I gave rigid bodies to were the cat and the soccerball because we needed those to have physics, the cat needs to be able to jump and have gravity and the ball needs to be able to get kicked around and bounce. The goal has the is Trigger checked because we just want the collider to check whether or not the ball passed it. The goal did not need a physical collider.
2. When I started testing my code, everything worked as intended on the first try. I did have some issues figuring out some parts of the code. For example, when making the OnTriggerEnter method, I forgot to declare what the method would return so I just had to add void since it doesn't return anything.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 