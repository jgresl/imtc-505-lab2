# imtc-505-lab2

## Theme
This project uses a Halloween theme found on the Unity asset store at https://assetstore.unity.com/packages/3d/props/poly-halloween-236625


## Interactable Events

### Character movement
The user is able to walk around using the left controller joystick and turn the camera with the right controller thumbstick. The user is unable to walk through solid objects and gravity keeps them on the ground. 

#### How it works:
I added a locomotion system to the XR Origin camera offset. It has a child object called Move that holds the continuous move provider component and uses the left hand move input for reference. There is another child object that holds the the continuous turn provider component and uses the right hand turn input for reference.

### Pumpkin Smash!
There is a desk with 3 pumkins on it and they are lit (jack-o-laterns). If the user picks any of the pumpkins up and drops them, the light inside will be extinguished.

#### How it works:
The pumpkins are created using prefabs from the theme assets. They have a grab interactable component that runs the `ChangeMesh` script which updates the pumkins mesh filter to the unlit version after the user releases it.

### Ghost Visit
There is a podium with a severed hand on it. If the user touches it, a ghost will appear along with a spooky sound and a text message (printed 1 character at a time). 

#### How it works:
The ghost and hand are created using prefabs from the theme assets. The hand has a grab interactable component that runs the `DisplayGhost` script which updates sets the ghost active property to true and then takes the hard coded string value to create an array of characters in order to build a new string in each iteration of the for loop. The generated string is updated continuously in the using a coroutine.


### Teleport to enclosed graveyard
The message from the ghost tells the user to find the book of evil. Hint... it's sitting on the book stand inside the enclosed graveyard with no entrance.

#### How it works:
The locomotion system also has a child object called Teleportation Provider that holds the teleportation provider component and uses the right hand grip button to move to wherever the reticle is pointed. 


### Flying Book of Evil
Once the book of evil is picked up and released, it will float over top of it's book stand in a rotating around in a magical way.

#### How it works:
The book stand and book of evil are created using prefabs from the theme assets. The book of evil has a grab interactable component that runs the `FlyingBook` script which updates the books transform position and make it revolve around the assigned target - which is the book stand.

