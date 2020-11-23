# Welcome to VRLehre

This project aims to support learning from a statistics-class with playful vr-games. There are different scenes testing different kinds of knowledge. 
The implementaion is for Oculus Quest. You can download the scene's apk to play them on your Oculus. 
If you are familiar in unity you can use the different scenes and modify the content.

# Overview of the different Scenes

## Dataplotter Scene:
In the Dataplotter Scene the player is situated in the Room which now has a big window through which the player can see two concrete islands floating in space. On one of the Islands there is a Capsule. This Levels task is to prevent the Capsule from falling from the Island and help it reach the next Island by building a “Bridge”. The Bridge is a plotted Dataset: The player can choose a plotting type by clicking a button (choose scatterplot, barchart, invertedbarchart) and select one of the provided datasets. The Datasets can be inspected by inserting one of the floppy discs in the Computer. 
On Button Click the currently inserted Dataset is plotted. The Player has three attempts to choose the right dataset + plot combination. Each time a button is pressed, one attempt is counted. As the right solution is plotted the Capsule starts moving over the created bridge.
If the right solution is not plotted within 3 attempts, the Capsule starts moving anyways and falls from the platform.
Implementation:
Each button has a Collider attached, where  “isTrigger” is checked. For every Button there is a special script that needs to be assigned: The Barchart Button needs the PlotBarchart.cs. The Scatterplot Button needs the PlotScatterplot.cs. The InvertedBarchart needs the PlotInvertedBarchart.cs.
Those Scripts register if the Trigger is entered and then call a function from PlotterScript.cs Script respectively. Plotterscript.cs needs to be attached to CDCollider. It reads the tag of the inserted floppy disc with the box collider set to “is Trigger”. Every floppydisk has a Tag (“Tile 1” etc.) that is converted into an index in “void OnTriggerEnter” Function. The index is later used to take the correct dataset for plotting data using. 

The heart of the dataplotter scene: Plotterscript.cs
This script takes data and plotts them in different ways into the VR environment. The script is a modified version of Penn State University Big Data Social Science Fellows. Thanks a lot for your work and detailed description! All details for the plotter implementation can be found in their blog: 
https://sites.psu.edu/bdssblog/2017/04/06/basic-data-visualization-in-unity-scatterplot-creation/

In the Plotterscript.cs there are some added sections of code:
Providing different datasets to the player: The player can choose between four datasets that are represented by floppy discs on the table. If a floppy disk is inserted into the computer its Tag its converted into an index by this function from the Plotterscript.cs

In the ShowBarchart Function this index is then used to choose the right dataset as inputdata

Chart Types: Asking for Object Names
In this Scene the Player finds a device that works like a 3D-Printer. Next to it there is the “solution image”, the shape that should be recognized by it’s name. The Player can choose a Button to print one out of several shapes. This is a nice task to check vocabulary. The scene is easy to adapt to your own items, if you have them as 3d-model. You can either use modelling software to produce your own or find 3D Models on the Internet.
How to adapt the Scene: Objects, insert your custom models. Make sure they are having Rigid Body, Box Collider and OVR Grabbable Component (see example for reference).
Also, make sure to set all the objects inactive by unchecking the box next to the objects name in the Inspector. This is to ensure they will just appear on Button click. Change Button Description: In MashineCanvas, click TextButton1 etc and change Text in Inspector.

Settings for objects 
Change Button Text to “Bevölkerungspyramide”
Pipeline Task 
Great for every kind of cloze. The Player is asked to put the little handles into place to create links between the right text components. Wrong Texts should stay unlinked. Just use the slotPrefab to build your own Puzzle. The text should not be too long. 
This Scene is created for Players standing and moving small steps to the front or side. This set up is creating a real immersion and possibility to interaction. Even though it is programmed for standing Players, everything can be reached by seated Players as well. If you find anything too distant, you can easily change the arrangement in the unity editor.

## Puzzle Task
This is another implementation of cloze in VR. Now  the player has several text components on puzzle pieces to fit them into the text shown on the table (or wall). This is suitable for longer Texts, but make sure that the slots are placed within the Players reach. You can choose between Table Set up and Wall set up. 
To customize this Scene for your Texts…

## Bild Puzzle
This is very similar to Puzzle Task but operates with images instead of text. To customize this Scene change material of slots.

## Balance Task
A playful task for multiple-choice-questions. This scene consists of an old-fashioned balance with two weighting pans. But it is not balanced! In the left pans are weights that cannot be changed. Next to the balance the player finds balls that contain different answers to a question displayed above the balance. The player can grab these balls and put on a computer to read out the answers. The right answers ought to be set in the left pan of the balance. If all right answers are chosen, the balance is balanced and the player succeeded.
The Balance works with two Scripts: LeftHolderScript.cs detects collisions of the Anserball-Gameobjects with the Left Holder of the balance and calls the scaleBalance(float weight) function in Balance Script. BalanceScript moves the positions of left and right handle. Each AnswerBall is assigned a tag (“Tile1”, “Tile2”) that allows setting different weights in LeftHolderScript.
Note for Developers: The Colliders for the left tray can be found at the down-most position in balance hierarchy.
The text on AnswerBalls can be changed by changing its material. The question posed to the user can be changed by altering text in the canvas object.

# Overview of used prefabs
The Computer Prefab
The Computer displays information to the user. It is using a 3D Model by Raven Bones (see sources documentation for detailed credits). I modified it to create different Versions for the different scenes. One has just the CD Slot to enter Objects, another has a smaller screen and a big output space beneath and is supposed to work as a kind of 3D-Printer.

The Control Panel Prefab
This shows the clock, sitting on the table in most of the scenes. You can individually set the time for every Scene by opening ControlPanel > Timer in the Inspector and changing the Start Time Minutes value. Make sure to save your changes File> Save.

Player Help with A & B Button:
FurtherInfo: This Script is part of the SceneSetUp Prefab. It enables the player to show helpful further text information on Pressing the A or B Buttons of the left controller. The text can be altered in the Inspector to provide suitable info for the player if scenes are changed.


# Settings

## Teleportaion
Teleportation Implementierung:

I chose Teleportation for implementing movement, as recommended by oculus best practices to prevent motion sickness (https://developer.oculus.com/design/book-bp/ ).
Follow the advices marked red and the set up should be completed in just a few seconds. Further documentation is for a better understanding.
Thanks a lot to valem, whose youtube Tutorial i was following for the Set Up of my Teleportation Prefab (https://www.youtube.com/watch?v=r1kF0PhwQ8E&t=287s) .
Using the My_Teleport_Everywhere Prefab it is important to make sure everything is well connected. Therefore click on the Prefab in the Hierarchy Tab to open its settings in the Inspector. The Prefab has several Components attached. Let’s take a closer look at them.
Locomotion Controller (Script)
This connects the Movement to your Player. Click on the circles next to the empty fields to assign Camera and Controllers.
Locomotion Teleport (Script)
This manages what the player can do during the different stages of teleportation. There are no settings needed to be changed. The Collision Type is Sphere instead of the initial point for better performance, and the Collision Radius is set small (to 0.1).
Teleport Input Handler Avatar Touch (Script)
This is an interesting part! Here you can assign Controller Buttons to the Teleportation. If you change the buttons from right to left controller make sure to change the following settings in other components accordingly:
In Teleport Orientation Handler Thumbstick (Script) change Thumbstick from R Touch to L Touch. Make sure to select only one, if you want only one hand to be able to teleport. 
Teleport Target Handler Physical (Script)
Here you can assign the Layers the player is able to teleport to. If “Aim Collision Layer Mask” is set to Default the player can teleport everywhere. If you select a special Layer for teleportation you must assign this layer to some objects. Therefore create a 3D Object and open it. In the Inspector set Layer to the Layer that can be teleported to. You can create new Layers by clicking on Add Layer. It is important that the Object has a Collider! If there is no Collider the Teleportation Laser won’t transform to the Circle with the Arrow. See teleportbeam prefab for Setup.
Teleport Aim Visual Laser (Script)
Script that makes the line to point at locations visible.
Teleport Orientation Handler Thumbstick (Script)
This makes the laser line appear from the selected Thumbstick (left or right hand).
Teleport Transition Blink (Script)
If you can select an area to go to in your game but your player is not moving you have problems with this script. There is a bug (a mistake in software implementation) in the Script provided by the Oculus Integration. If you see the Fader Option, that’s good. That means you have the repaired script version that I found online. Just click on the right circle to select Center Eye Anchor. If you do not see the Fader Option change the Component to Teleport Transition Instant (Script): 
Left click on Teleport Transition Blink (Script) and click delete
Click “Add Component” at the bottom. Search for Teleport Transition Instant and click to add it to the Prefab.
Teleport Aim Handler Laser (Script)
There is nothing to change here.

## Set Timer
There is a ticking clock on top of the table. The Time for each Level can be set in the Inspector (Table > ControlPanel > Timer). If the Timer is not shown, make sure that the slots Countdown Display 1 and Countdown Display 2 are referenced by the Canvas Objects within Display>TimerCanvas.
If you want to pause the Timer from another Script you can add the following line of code.
(It is also used in Dataplotter Scene to stop the timer if the Capsule moves over the plotted data).

## Lighting:

Skybox is replaced by a Color which is more cost efficient. If you prefer a sky image, it is recommended for VR to use a Skydome instead of a Skybox.
You may adjust settings in: Window > Rendering > Lighting Settings

## Sound:

Sound is an important means to create successful immersion but unfortunately due to lack of time not much used in the project. Added sound sources are warmly welcomed ;)

# Sources

## 3D Models
RAWoldTV by Raven Bones (https://sketchfab.com/3d-models/old-tv-a0637a0b7d60445ca7ccde2d742bc79a)
Balance by K Wang (https://sketchfab.com/3d-models/balance-ce59047d61334abc85a41c9c3b59c8d0)
WeightSingle by EDPlus (https://sketchfab.com/3d-models/weight-5653e279455c4d5bbfb1ee15865d5cb5)

## Music
CC Twisterium: Hi-Tech Link: https://www.freebackgroundtracks.net/free-music/
Downloaded 14.10.2019
