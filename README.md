## Applied-Project-4th-Year

# Description:
A C# Application for my 4th year project as part of a team.
Within this project we created a Brain Training game called BrainWorks using Universal Windows within Visual Studio 2015. The Application is written in C# using Microsoft Expression Blend for the design of the games (Storyboards). We also have created a website written in Golang with a HTML/Javascript/Bootstrap frontend that connects to the Universal Application to pull scores into the website using SQLite/Easy Tables on Azure. Golang pulls in the scores from the UWP Application using a JSON GET request to the table on Azure. Golang also connects to a MySQL database on Azure to deal with Login/SignUp to the website. The UWP Application also makes use of SlashDb (/db) API to pull in a list of users registered with our website.

Within this game we have 4 different areas of learning: Attention, Problem-Solving, Memory and Speed.

Within Attention you will find 3 games that are aimed at improving your attention:

1. Everything has a Porpoise: Try to click all of the Porpoise only once to progress to the next level. The porpoise move around the screen using a storyboard created in Blend. The number of Porpoise start out small but grow as the levels progress making it difficult to distinguish which ones you may have already clicked. Click the same porpoise twice and you end the game. Your score is then written to a textbox which is then sent to the SQLite database by pressing a button. The score is displayed in the app along with previous scores you may have saved. You can also refresh the database by pressing a button.
2. Picture Perfect: Look at a picture carefully, then choose which item was in the picture you just looked at by clicking on the right button. Click the wrong one and the game ends. Your score is then recorded in the SQLite database.
3. Total Recall: Using a dictionary in C# to store all of the possible words, the user must enter in as many words as they can think of starting with whatever letters are displayed at that current time. Get 15 words to progress in levels. Enter in the wrong word and you will not get any points. There is a dispatcher Timer to decide when the game ends. Progress in levels to begin the timer again. Let the timer run out befire getting the 5 words then the game ends and the score is recorded in the database.

Within Speed you will find 3 games that are aimed at improving your Speed:

1. Foal Shadow:
2. Go With The BufFlow:
3. Spot the Difference:

Within Problem-Solving you will find 3 games that are aimed at improving your Problem-Solving Skills:

1. Higher or Lower:
2. Manic Maths:
3. Quick RPG:

Within Memory you will find 1 game that is aimed at improving your Memory:

1. Sequential:
