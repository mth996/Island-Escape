# Island-Escape
An Endless runner game made for PC
here are the scripts I was responsible
Game Object Type: Audio
Function: To play the background music once the player character and non-playable character starts running
The audio source component of the camera is obtained by the “backgroundMusic” variable, then the “initialDelay()” function is called. In the function, the script waits for the same amount of initial delay as the player controller script when the initial animations of the character and non-playable character are playing then begins to play the background music.
Game Object Type: HUD
Function: Displays the score of the player on the screen
Description: 
As the game starts the score manager checks score every instance then the function changeScore is called where the score changes only when the player collects the metalnuts where each metal nut has a point which gets added to the total score. For determining the metal nut points, the metalnuts from the player script is called.  
Game Object(s): Main Menu
Description: 
As the application starts, MainMenuScene/Scene0 is called. When the Start button is pressed the SceneManager.LoadScene() function is called where an active scene from the build index is called and 1 is added to it which calls the next scene that is the game scene. When the Quit button is pressed the application.quit function is called and the application quits.
Object Manipulation 5
Game Object(s): Game Over Screen
Function: Restart And Quit
Description: 
As the player dies the end game function in game manager is called the GameOverScene/Scene2 is called which calls another function SceneManager.LoadScene() where active scene from the build index is called and 1 is added to it which calls the next scene that is the game over scene. When the Restart button is pressed the SceneManager.LoadScene() function is called where the active scene from the build index is called and 1 is subtracted to it which calls the game level scene. When the Quit button is pressed the application.quit function is called and the application quits. The score of the player is also displayed on the game over screen.

