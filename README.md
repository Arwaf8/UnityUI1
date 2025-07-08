# Tech UI Assessment – Savvy Games Group (Steer Elite Internship Program 2025)

This Unity project is submitted as part of the Skills Assessment for the Tech UI Track in the Steer Elite Internship Program offered by Savvy Games Group.

## Position Applied
Tech UI Intern

---

## Objective

Recreate the UI shown in the assessment PDF using the Unity UI framework only (no UI Toolkit or IMGUI). The goal is to demonstrate technical UI skills such as layout design, interaction, hover behavior, and UI animation.

---

## Features Implemented

- Three aligned UI buttons
  - Vertically centered with consistent spacing
  - Use of safe area to support various screen sizes
- Hover Effects:
  - Gray outline becomes orange when hovered
  - Button background changes from gray to white on hover
  - Button label text changes color on hover
- Pointer Hand Icon:
  - Appears and moves to align next to the hovered button
  - Includes slight idle movement animation via script
  - Disappears when the pointer is not hovering over any button
  - Header Panel ("Intro to"):
  - Positioned at the top of the screen
  - Moves up and down subtly using a scripted animation for visual interest

---

## Note on Animation

An idle animation effect was originally attempted using Unity's Animator system, but due to undesired behavior, a custom script-based motion was used instead to simulate the idle movement for the "Intro to" panel and pointer hand.

This approach ensures smooth runtime behavior while meeting the visual expectations of the assessment.

---

## Bonus Features

- Safe area logic using Screen.safeArea to support notched and rounded displays
- Scripted idle movement for hand pointer and header panel
- Organized scene hierarchy and reusable components

---

## Project Structure

- Assets/: All images, UI prefabs, and scripts
- Scenes/Main.unity: Main scene for the UI assessment
- Scripts/: Contains scripts for hover detection, pointer motion, and safe area handling
- Animations/: (Attempted Animator setup not used in final version)

---

## How to Run the Project

1. Open the project using Unity Hub (Unity 2021.3 or newer recommended)
2. Open the Main scene
3. Enter Play Mode to test:
   - Hover over buttons
   - Observe pointer, outline, and header animations

---

## GitHub Repository

[👉 Click here to view the project on GitHub](https://github.com/Arwaf8/UnityUI1)

---

## Author:

Name: Arwa Fahad Alhassani 
Position: Tech UI Intern Applicant  
Company: Savvy Games Group  
Assessment: Steer Elite Internship Program 2025  
Email: arwafahad86@gmail.com

---

Submission Notes:

- Delivered before the assessment deadline
- All features in the PDF are implemented as required or enhanced
