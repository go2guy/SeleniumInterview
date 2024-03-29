# Introduction 
This code is used to test the skillset of C#/Selenium for candidates.  It tests their ability to debug broken tests in Visual Studio
(hopefully using breakpoints, inspecting use devtools...etc.
This code is functional checked in to the repo.


#Setup the failed tests
Once you have checked out the repository modify the following to make tests fail.
1. JenkinsPage line 7 modify the text to be Jenkins Test vice Jenkins.  This tests their ability to recognize the element locator is wrong.
2. JenkinsTests line 29 modify assert and change word Easy to Hard.  This tests their ability to fix the assert.