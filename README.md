# Festicket
# Instructions

INSTRUCTIONS ON HOW TO EXECUTE TEST SCENARIOS

1 Ensure you have Visual Studio 2017 installed

2 Download everything from https://github.com/Olasumbo26 to your computer

3 Double click on Visual Studio to open

4 Click on file on top left hand side

5 Click on Project/Solution

6 Navigate to the downloaded folder Festicket1

7 Double click on Festicket.sln

8 Click on Test -> windows -> Test explorer

9 Go to Test explorer window and expand Festicket icon

10 Expand Festicket.Feature

11 Expand LoginFeature

12 You will see Valid Login scenario

13 To run the Valid Login Scenario- Right click on Valid Login and click on run selected tests

15 The Login Scenerio should pass after you run it

# Analysis

## Issues I came accross and how I overcame it

1 There was always difficulty navigating to the site when running the automation script
I was able to apply wait time which is thread.sleep to give time to locate the URL
2 There was difficulty in locating the elements while running the scripts too, also I
apply wait time to give it time to locate all the elements

## If I was given more time what I will do differently
1 I will try all the locators to see which one will best to run the script
2 I will try to write code for all the 3 tasks and do much more

## Other test cases I would automate are
1 I will automate negative testing by putting wrong email or password to see if it will accept it
2 I will automate API to investigate the breaking of the code
3 I will automate registration test cases to see the process from the the beginning
4 I will automate payment test cases because its one of the most important part of the business
5 I will automate regression testing to see if all the components work together

## Dependencies used
1 I declare pageobject in the step definition so that I will be able to call it anywhere
2 I created constructor which is also  the name of the class steps

## Resources Used
1 Selenium Webdriver
2 NUnit
3 Specflow
4 Chrome Browser
5 Visual studio
