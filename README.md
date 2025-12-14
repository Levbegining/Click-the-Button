# Click the Button 🎮

![C#](https://img.shields.io/badge/C%23-.NET-blue)
![WinForms](https://img.shields.io/badge/UI-WinForms-lightgrey)
![Status](https://img.shields.io/badge/status-finished-brightgreen)

A fast-paced WinForms game where you need to click a moving button as many times as possible within 30 seconds.  
Built with C# and Windows Forms.

---

## 🧠 What this project demonstrates
- Event-driven programming in WinForms
- Working with timers and time-based logic
- Randomized UI behavior (position and color)
- Basic game state management
- Handling user input in real time

---

## 🚀 Features
- Random button movement on every click
- Random button colors
- 30-second timed gameplay
- Best score tracking
- Restart screen
- Clean and minimal UI
- Fully written in C# WinForms

---

## 🧩 Architecture Notes
- Single WinForms Form
- Game flow controlled via UI state and boolean flags
- System.Windows.Forms.Timer for game timing
- Button position and color randomized on each click
- UI updates executed on the main thread

---

## 🕹 How to Play
1. Launch the game.
2. Tick the checkbox to start.
3. Click the moving button as fast as you can.
4. When the 30-second timer ends, your result is shown.
5. Press **Restart** to play again.

---

## 📷 Screenshots

**Start screen**  
<img width="230" height="112" alt="Gameplay screenshot" src="https://github.com/user-attachments/assets/7e2b049e-3152-46e8-8e07-96c9fa9b6da5" />

**Gameplay**  
<img width="638" height="257" alt="Снимок экрана 2025-11-29 в 23 48 23" src="https://github.com/user-attachments/assets/d89fb005-76d7-4f03-8bd3-5d71ad540d5a" />

**End screen**  
<img width="217" height="138" alt="Снимок экрана 2025-11-29 в 23 48 42" src="https://github.com/user-attachments/assets/a2e5c214-707e-4a6d-abab-8ba163c4b6c6" />

---

## 🔧 Build & Run

### Requirements
- .NET Desktop Runtime / SDK
- Visual Studio with WinForms support

## Run locally
1. Clone the repository:
   ```bash
   git clone https://github.com/LevShapovalov/Click-the-Button.git
   ```
2. Open the .csproj file in Visual Studio.
3. Press F5 to build and run the project.

## 🏗 Technologies Used
- C#
- .NET WinForms
- Windows Forms Designer
- Randomized UI logic


## 📌 Project Status
✔ Finished

### 🔧 Possible future improvements
- Difficulty levels
- Sound effects
- Leaderboard
