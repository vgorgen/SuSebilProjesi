# C# Console Application: Water Cooler Project - Readme

## Introduction
This project was assigned to me to deepen my understanding of the Observer Pattern within the scope of Object-Oriented Programming through the use of events. 
The goal was to demonstrate the practical application of events and to grasp the essentials of the Observer Pattern.

Project Overview
The project involves a simple water cooler system simulated through a C# console application. Here's how I approached the task:

- Step 1: Water Tank Class
I started by creating a WaterTank class, which acts as the central component of our water cooler. 
This class manages the water level and notifies other parts of the system when changes occur.

- Step 2: Temperature Control
Next, I implemented a temperature control system by developing a TemperatureControl class. 
This component ensures that the water remains at a desired temperature, crucial for the functionality of our simulated cooler.

- Step 3: Cup Control
To allow users to select the size of the cup, I created a CupControl class. 
This functionality lets the user determine how much water is dispensed each time, adjusting the water level in the tank accordingly.

- Step 4: Console Interface
Finally, I developed the console interface, which serves as the user interaction layer. 
It allows users to interact with the system, select cup sizes, and check the water temperature.

#### Learning Objectives
- Events: Implement and handle custom events in C# to model real-world interactions in software.
- Observer Pattern: Utilize this design pattern to manage dependencies and notifications between different components of the application.

This project was designed as a part of a learning exercise to better understand how event-driven programming and design patterns 
like Observer can be applied in practical scenarios. Each component was built to interact seamlessly, 
demonstrating the dynamic capabilities of events in managing system state and behaviors.

##

![image](https://github.com/user-attachments/assets/f7efb5e8-bd67-44dd-8d81-85295060460e)

### User Interface
The console interface of the Water Cooler project is straightforward and user-friendly, designed to facilitate easy interaction with the system. Here is a brief rundown of the options available to the user:


### Menu Options
1. Su Ekle: Add water to the tank.
2. Su Sıcaklığını Ayarla: Set the desired temperature of the water.
3. Sıcaklığı Göster: Display the current water temperature.
4. Bardak Seçimi: Choose the size of the cup.
5. Su Doldur: Dispense water into the selected cup.
6. Çıkış: Exit the application.

##

![image](https://github.com/user-attachments/assets/5a466f49-0104-4e8d-9ed6-27a3936178e8)

Here is an example of the interactive console in action, demonstrating how the application responds to user input, 
updates the water level, and displays relevant messages. This sequence showcases the event-driven nature of the system and how events are handled.


### Example Breakdown
#### Menu Display: The main menu is displayed, prompting the user to choose an action.
- Adding Water: The user chooses to add water ('Su Ekle'). Each press of the specified key increases the water amount by 5 units, showcasing the immediate response of the system.
- Event Handling: Whenever water is added, an event triggers that updates the water amount and prints the new level along with an "EventHandler" notification, indicating that the event was processed.
- Real-time Feedback: Each action provides real-time feedback in the console, including confirmation of key presses ("Key is pressed") and updates on the water level.
- Exiting: The user selects 'Çıkış' to exit the application, which returns to the main menu.

##

![image](https://github.com/user-attachments/assets/16c91943-39df-4a10-83ed-98b979417d61)

The screenshot below illustrates the process of adjusting the water temperature within the application. This feature allows users to customize the temperature of the water according to their preferences.


### How It Works
#### Selecting Temperature Adjustment: 
From the main menu, the user selects option 2 ('Su Sıcaklığını Ayarla') to adjust the temperature of the water.
##### Choosing Temperature: The user is then prompted to select a desired temperature setting from the following options:
- Sıcak: Hot
- Ilık: Warm
- Soğuk: Cold

#### Event Notification: Upon selecting an option, an event is triggered indicating that the temperature setting has been changed. 
The EventHandler shows a message confirming the change.

#### Current Temperature Display: The console immediately reflects the change and displays the updated temperature as 'Soğuk' (Cold).


##

![image](https://github.com/user-attachments/assets/a8be6986-4890-4c64-8e1b-bbb14fffcfdc)
### Cup Selection Feature
The screenshot below demonstrates the cup selection feature of our water cooler console application. 
This feature allows users to choose a cup size that best fits their needs.
### How It Works
#### Selecting Cup Adjustment: 
From the main menu, the user selects option 4 ('Bardak Seçimi') to adjust the selection of cup.
##### Choosing Cup: The user is then prompted to select a desired cup setting from the following options:
- Küçük: Small
- Orta: Middle
- Büyük: Large

#### Event Notification: Upon selecting an option, an event is triggered indicating that the cup setting has been changed. 
The EventHandler shows a message confirming the change.

## 

![image](https://github.com/user-attachments/assets/d9336ea3-9a1d-4a7b-bce0-c9da7421fd5f)

### Water Dispensing Feature

The screenshot below illustrates the water dispensing process in our water cooler console application. 
This interactive feature showcases how users can fill their selected cup with water at their chosen temperature.


#### Detailed Interaction
- Starting the Dispensing Process:
The user selects '5. Su Doldur' from the main menu to begin the water dispensing process.

- Setting Preferences:
The user is prompted to confirm the previously set temperature (Cold) and the selected cup size (Medium, 200 ml).
The user is asked to confirm the start of the dispensing process by entering 'E' (Yes).
- Dispensing and Event Handling:
The application displays a message "Su dolduruluyor lütfen bekleyiniz!" indicating that the dispensing is underway.
The system periodically checks if the key is pressed to trigger water dispensing.
Each press adds a defined amount of water (10 ml in this case) and updates the water level through an event handler, which also updates the display to show the new water level.
This process continues until the total amount reaches the size of the cup (200 ml).

## Credits
- Veysel Gorgen
  
|     | 
| --- | 
| ![Veysel Görgen](https://avatars.githubusercontent.com/u/92218276?s=400&u=fc273166491e26ed615ab53bca7820f43b9f230e&v=4)<br />**Veysel Görgen**<br />[💻 ⚠️ 🐛](https://github.com/amplication/amplication/commits?author=vgorgen) |
## END
