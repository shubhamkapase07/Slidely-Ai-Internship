Download Executable

https://drive.google.com/file/d/1wDTtoHpbSRzw4GDy3Ci-tf77q7j2af8n/view?usp=sharing

* Download and extract the Zip file
* Run the application

Video Demonstration

https://youtu.be/GRmXa91vgsI

Features
* Create New Submission: Enter Name, Email, Phone Number, GitHub repo link, and manage a stopwatch.
* View Submissions: Navigate through previously submitted entries.
* Keyboard Shortcuts: Use Ctrl + S to submit forms.

Components

* Desktop App (Visual Basic): Manages UI and form submission.
* Backend Server (Express with TypeScript): Provides API endpoints for data storage.

Full Fledged Installation

Running the Desktop App
* Clone this repository.
* Open the project in Visual Studio.
* Build and run the application.
  
Running the Backend Server (server.ts)
* Clone the backend repository from [Backend Repository URL].
* Navigate to the project directory.
* Install dependencies: npm install.
* Build TypeScript: npm run build.
* Start the server: npm start.

Note Run the Server First and then the Desktop app

Usage
* Create New Submission: Fill in form fields and submit using the "Submit" button or Ctrl + S.
* View Submissions: Navigate through entries using "Previous" and "Next" buttons.

API Endpoints
* GET /ping: Checks server status.
* POST /submit: Saves new submissions.
* GET /read?index=<index>: Retrieves submission at specified index.

Technologies Used
* Desktop App: Visual Basic, Visual Studio
* Backend Server: Express, TypeScript
* Database: JSON file (db.json)
