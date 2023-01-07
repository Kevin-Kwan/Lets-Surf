# Game Design Document (./Game Design Document.pdf)

Kevin Kwan
10/30/2020
Game Design 4th Period

## LET’S SURF!

## Overview:

SURF! is a competitive, singleplayer, first-person3D speedrun maze platformer game. You, the player,will
traverse through different levels and maps with theuse of gadgets and special movement called “surfing”to
arrive at specific locations in the shortest amountof time. However, there will be many obstacles thathinder
you from just simply walking to your destination.Certain hindrances like the walls will cause instantdeath
when touched, preventing you from reaching your goal.Get creative, discover the fastest path, use physicsand
movement, and challenge yourself in order to reachyour destination in the fastest time possible!

```
This game was inspired by CS:GO surfing and borrowssimilar physics and concepts such as movement. There
will be ramps and slopes and other obstacles in thelevels that the player can use. The knife in thisscreenshot
IS NOT TO BE INCLUDED IN THE FINAL GAME.
```

```
This is the Start Menu of the game. Simple, yet pleasingwith complimentary background music.
```
_The game features many different levels showcasingnew movement techniques and varying difficulty. Thelevel
selection screen allows for easy navigation when choosingwhat level to come back to and play._


```
The unique “launch ramp,” out of many other kindsof ramps, is showcased here from Level 8 in the game.
```
_The player is currently in the process of “surfing”by using the physics of the game and the sloped surfacesto
reach the end goal which is marked in yellow (Level4)._


## Genre

The genre of the game is a first-person 3D speedrunmaze platformer game that borrows the physics and
movements from VALVE’s CS:GO and concepts from CS:GO’ssurf gamemode in order to travel through the
maze/obstacle course of the level through the useof extreme physics. The player must use the surroundingsand
slopes provided in the levels in order to get frompoint A to point B without dying in the shortestamount of
time possible. The player’s control of their movementis crucial in order to get to certain parts of themap and
perform complicated air maneuvers in order to buildup enough speed and momentum in order to skillfully
traverse the map efficiently. There are many pathsthat the player can use to get to their specificdestination so
the player can get creative and choose the best andfastest way for them to get there. Of course, therewill be
obstacles that will try to hinder the player fromwinning.

## Theme

While there is no set theme/setting to the whole game,the semi-realistic settings of the levels are thelevels
themselves that are designed and laid out. The level/mapitself contains where all the gameplay is occurringand
each of them can be compared similarly to an obstaclecourse. However, certain sets of levels can varyin terms
of theme. For example, levels 1-10 will feature asky setting/theme where the player is jumping andsurfing
around high up in the air above the clouds. If theplayer falls, of course, they die. For future levels,other themes
for levels may include a school setting, a differentindoor setting, an outer space setting, and more.

## Visual Aesthetics

The game has a semi-realistic aesthetic of the modernworld with textures, lighting, and reflections basedoff of
the looks of the real-world. Depending on the themeof the level, extra lighting effects or colors maybe
included. The game is also played in a very smoothand satisfying first person view due to the surfing
movement in the 3D world.

## Sound Design

The game features licensed, empowering backgroundmusic for different themes of levels. The game alsohas
sound effects such as when the player begins a runand starts the timer, when the player finishes thelevel, and


when the player dies from falling into the void. In future updates, there will also be a wind sound when you’re
travelling super fast through the air, player soundswhen you jump like when you jump and land on a surface,
sounds when you walk on surfaces, and more. The gamewill also feature directional sounds that come from
sources in the player surroundings.

## Goal

In each “level,” there will be a different goal whereyou have a start point and you must get to a certainend
location without dying in the fastest time possiblein one run. For example, for one “level,” you mustsurf to
build up enough momentum in order to fling yourselfin a direction across a large gap toward the finisharea.
For the next “level,” you have to strafe and dodgearound a wall using the speed built up by surfingto get to the
other side where the finish area is. You can use thesurroundings of your space in order to aid your movementto
get to your destination. You can challenge yourselfto get the fastest time possible in each level. Ina possible
future update, you will also be able to compete againstyour friends or other people who play the game totry to
beat their best time for a level.

## Mechanics

The main mechanic that this game features is called“surfing.” Whenever you hit/land on a slope, youstart
sliding down it. However, if you move your characteragainst the direction that you are sliding down,you will
be able to hug the surface for longer and use thattime to use the rest of the sloped platform to changethe
direction you are going, build momentum, and continuemoving along the platform. Basically, you slide against
a slope, similar to wall running, but you use thatmomentum and with the help of physics to controlyour
movement to launch yourself and fly to the next platform,turn around corners, etc. In the future, you willalso
be able to use a grappling hook to grab onto a wallor the ceiling in order to swing yourself acrossgaps and
around corners. You cannot climb walls, and the onlytime you will be running or jumping will be at thestart of
a level. Left and right movement and coordinationwith mouse movement are crucial in order to succeedin this
game. Game physics and gravity also play a big rolein impacting your movement.


## Controls

The keyboard controls are W, to move your characterforward, S, to move your character backward, A, tomove
your character left, D, to move your character right, and space, to make your character jump. You use your
mouse in different directions to move your cameraor character’s view around based on the directionthat your
mouse moves. When on a slope, the A and D keys willbe the only keys that you need to surf. For example,if
the slope of a platform is going down to the right,you want to hold left on your keyboard to counteractit and
hug the surface of the slope. The mouse cursor willbe used in the Main Menu and Level Selection screenin
order for the player to click and select certain options.In any level, hitting M will send the player backto the
Main Menu and hitting P will send the player to theLevel Selection Screen. R will allow for the playerto restart
a level, and F will send the player to the next levelonce they have completed the current level. For
Debugging/Dev Tools, L can be used to reset a currentlevel’s best time, B can be used to load the previous
level in terms of index, and N can be used to loadthe next level in terms of index. For the grapplinghook,
which will be a future addition, left clicking willfire out a rope to attach to a surface if it is closeenough to the
player (since the rope is limited by length and raycastswill be used to check) and letting go of left clickwill
detach the rope.

## Players

This game is currently available for single-playerand will later be available for online competitive
multiple-player. The player can get a feel for themaps, learn how to surf, practice surfing, and challenge
themselves by playing single player in order to beattheir best times. The objectives and levels willbe the same
for both single and multiplayer. In multiplayer, youwill be able to challenge other players in real lifeto
compare best times and see who can beat the levelsthe fastest. Collisions against other players willbe disabled
to prevent sabotage and you can also race againsttheir ghosts. You can also compare techniques andpaths of
other players as well. A ranking system for each levelwill display the top 10 people who got the fastesttime for
that level.


## Enemies/Hazards

So far, the current hazards in this game feature thevoid of the world that will kill and reset the playerwhenever
the player falls into it, surfaces and areas like walls and out-of-bounds areas that will kill and restart you on
contact, and obstacles such as walls to impede yourmovement and path of navigation. The levels’ designsand
layouts are also technically a hazard, because itis dependent on you to control the player in sucha way to
prevent yourself from colliding into walls, figureout where your destination is in the levels, performdifficult
maneuvers, and determine what the best, fastest pathto get to the destination is. While there are nocurrent
enemies, AI surfers may be added in the future tochase the player down and kill/reset them with contact.

## Future Enhancements/Bug Fixes

While I have mentioned many potential and ongoinggame features in the earlier sections, the most upcoming
enhancements include retexturing the levels, revampingthe tutorial, making a better UI system with a popup
message displaying each level’s objectives, and makingfull levels that feature everything that the playerhas
learned from levels 1 through 9. There may also bea return to the idea of incorporating a map of GSMSTin
some of the levels.

## Technical References

CS:GO Best Surf Maps (Screenshot) -
https://www.dbltap.com/posts/6311635-csgo-surf-servers-best-servers-to-play
Frames Per Second Counter in Unity -http://wiki.unity3d.com/index.php/FramesPerSecond
CS:GO Movement and Physics Ported to Unity-
https://github.com/AwesomeX/Fragsurf-Character-Controller/tree/master/Source/Fragsurf
ModifiedCS:GO Movement and Physics Ported to Unity-
https://github.com/Olezen/UnitySourceMovement/tree/master/Modified%20fragsurf
Cloud Development and Testing in Unity -https://github.com/SebLague/Clouds
C# Timers -https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer
Unity Scene-Specific High Scores using PlayerPreferences-
https://answers.unity.com/questions/1447020/scene-specific-high-score.html


Brackeys: START MENU in Unity -https://www.youtube.com/watch?v=zc8ac_qUXQY
Textures/Materials -https://opengameart.org/textures/all
Unity Documentation -https://docs.unity3d.com/Manual/index.html
Unity Play Music Across Scenes -
https://answers.unity.com/questions/1392654/background-music-loops-without-restarting-on-playe.html
Background Music -https://lickd.co/
3D Modeling Software -https://www.blender.org/


