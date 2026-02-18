# GDIM32 In Class Activities


## Week1

### Activity 1
 Do your work early, don't wait until the last minute to do your homework, so if you run into buges and issues, you still have time to reach for help.

### Activity 2
Q1. x = 10

Q2. x = 2

Q3. print "hello world" every frame in the console

Q4. MonoBehavior

Q5. When the program start, it print x = 10

Q6. ("x = + x ) is Parameter

Q7. It should not write as Transform.Translate(_direction);  
we need some object that translate, for transform to transform.

Q8.change it to _playerTransform.Translate(_direction)

### Activity 3
[MG1 break-down & Week 1 Activity 3](https://docs.google.com/document/d/1y5LOXHts-EvqE00ku0UjBCC5AgohWl3lteMNVPOctuo/edit?tab=t.0)


## Week2

### Activity 1 
Week2 MG2 breakdown
<img width="1049" height="632" alt="Screenshot 2026-01-13 174954" src="https://github.com/user-attachments/assets/61c6a70d-0643-41a8-8cc4-c5d10542d4a4" />

### Activity 2
MG2 in class:

[Link of github commit](https://github.com/UCI-GDIM32-W25/mg2-kaseywan1112/commit/f40aefbdbe9b63acb470b886e457b81b0fda92da)



## Week3

### Activity 0-2
Partner Name: Allen Gu

### Activity 3
1. A finite state machine will be useful in this project when we code about the animation of those pigeons. We can set different stages of the pigeon, like idle, fly, and fly away. When we use a finite state machine, the stages will be organized. 
2. The inheritance will be used in the question mark and exclamation mark on the pigeons when the player gets closer, so no matter what kind of pigeon they will both be affected by the player because of inheritance; the pigeons are in the same category. 

<img width="1186" height="676" alt="010d6e0acc4f9a4aac48ea4fd73c451" src="https://github.com/user-attachments/assets/03427994-a971-4f23-b849-29261e565fb8" />


## Week 4

### Activity 0
Partner Name: Allen Gu

### Activity 1
1. I added like 7 locator object, and it only show the last locator object, like Locator(7), so it only have one locator when we start the game. 

### Activity 2

<img width="1635" height="585" alt="4721df6f85f31b478389f8a944f30d0" src="https://github.com/user-attachments/assets/882505d8-960c-4b92-8173-1441ea85da2a" />


### Activity 3

[MG4 in-classCommit](https://github.com/kaseywan1112/HW4/commit/f8bf7b7f39fc16e6e0f36ac2c523f02c845a5ef2)

I forked on GitHub and created a Unity file that I can work on, and I added the pixel art of the birds and the pipe in the assets. Added a player script, coding the player(bird). 


## Week 5

### Activity 1

In my case, I might keep it the same, because these codes have been split into many separate ones, I think it will be to change and debug, or adding new stuff in the future. 

### Activity 2

In W5_Demo2, EnemyStats and ItemW5Demo2 are model, EnemyW5Demo2 and PlayerW5Demo2 are controller and DialogueBubble and InventoryUI are view.

### Activity 3
#### Scenario 1
rhythm game:
The beat change to code is to use the Inheritance with polymorphism, make a perfab and the singleton will be the start timing and the music. use a script object that check the player hit the beat for perfect, good great or bad, different type of beat will be the Finite State Machine, like hold beat or quick tap beat.
#### Scenario 2
Team shooter game:
In the shooting game, a model will be the stats of the player or enemy, the bullet, the health, the score of the player, and for the view part, is the HUD, or the scoreboard, the controller will be the control of the character of the player or the game. 
#### Scenario 3
Stardew Valley:
The Inheritance will be helpful for the plant systems, and the Finite state machine will used for the state of the plant will be, for example, like the plant growing, still a seed, or already have outcomes. State Machine will be helpful for the whole state of the plantes.
### Activity 4
Attendance: Yaokun Wan, Allen Ray Hu, Tiancheng Li.

Proposal:[First Draft_in-class](https://docs.google.com/document/d/1fnsY2dn8RalB8GGQmQtA4OftlRL5nsa3st6-GqeGGi8/edit?tab=t.0)


## Week 6

### Activity 1

#### Gizmos

In our final project, I think we can use Gizmo to show player's movement, how prop's moving, directions when there is a physical collision.

#### Profiling

Not only in our final project, but most of the work that I think we can use profiling to test our game if there is a lag or losing frames. And we can use profiling to test different ways for better function of game. Just like the class example, the circle rigid body runs better in the capybara game. 

#### Breakpoints

I think this one we can use not only in our final project, but most of the project in the furture. Breakpoitns can make you game kind of pause at the moment, so you can check how your code work or is you mechanic doing okay. 

### Acitivity 2

Attendance: Yaokun Wan, Allen Ray Hu, Tiancheng Li.

Proposal: [Fixed-Draft Proposal](https://docs.google.com/document/d/1fnsY2dn8RalB8GGQmQtA4OftlRL5nsa3st6-GqeGGi8/edit?tab=t.0#heading=h.y4j3q551ojs1)


## Week 7 

### Activity 1

1. private Vector3 _raycastStart calculates the srarting point of the raycasting. It switches the object position to the world postion. This is a read-only property that is like a getter. It prevents the data stored in it from being modified.
2. private Vector3 _raycastDir creates a vector pointing to the player character. It is also a property for the same reason. 
3. private void UpdateState () updates the finite state machine by using if() statement and the HasLineOfSightToPlayer() method, which initializes the bool return value to false, projects raycast using Physics.Raycast(), and then checks if the player is in sight by checking the tag.
4. Physics.SphereCast() is used to create a spherecast in HasCloseObstacles () method. This method is used to check if there are close obstacles in the area and return the bool value. If there is, _spherecastHitLocation is modified.
5. OnDrawGizmos() draws the raycast and changes the color according to _hasLineOfSightToPlayer on gizmos; it also draws the area of the spherecast on Gizmos. This is important because it helps the developers see these elements in the scene.
### Activity 2

Attendance: Yaokun Wan, Allen Ray Hu, Tiancheng Li.

### Activity 3

![WeChat Image_20260217182344](https://github.com/user-attachments/assets/6b3fb07e-fb4a-430a-ab79-c454dacf9d83)

### Activity 4

[Assign Initial Tasks](https://docs.google.com/document/d/1rLxHEqQ7WVbr2whNHvd6AkNOCeKE-MZJDp9sczpUW1g/edit?tab=t.0)

### Activity 5

[Github Commit](https://github.com/TianchengLiRed/GDIM32-Final/commit/3aac12c0b574d60fbef1b8b27f9d1b4083c639e8)

We create the player controller movement, camara move with the player and the ground, we worked on the time system, item system and the task system a bit, we are working on different task now, I will looking for the art sources that we can use so we can build a office. 
