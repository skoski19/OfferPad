## Welcome!

Welcome to the final step of the application for QA Automation Tester at OfferPad!

What we want to see is your ability to work with Selenium. We are currently using an older automation system and are looking for someone to create the framework to move us towards a fully automated QA system.

## Contact information

* We are available for any questions that you have during this test. Don't be afraid to reach out to us! In fact, we would love it if you did.
You can contact us at michael.robinson@offerpad.com and/or stjepan.rajko@offerpad.com, either via Skype or email.

If you reach out via Skype, you may need the latest desktop version of Skype (we have Skype for Business accounts and regular Skype may have trouble connecting to us) - you can download it from https://www.skype.com/en/get-skype/, in the dropdown choose _Get classic Skype_.

## Business Process

Here's a description of the business process for new customers:

Customers who wish to sell their house to us navigate to our main page. They enter their home address, and then they are shown five forms which ask them details about the property they are trying to sell. These pages use text field inputs and dropdown boxes.

Your task will be to create a handful of tests for the initial customer offer pages.

Here is the URL to a copy of the offer page that you can use for testing: https://opautomatedqa-1012-web.azurewebsites.net/

## Project Setup
Please contact stjepan.rajko@offerpad.com with your GitHub username to receive an invitation to a GitHub repository.
If you don't have a GitHub account you can create one at https://github.com/join.

This repository has some basic Selenium calls with references to the Selenium framework,
and is implemented as a c# Visual Studio project. Use this code as the basis for your test case development.

It is easiest to work with this repository / project on Windows.  If you need to use a different OS, please let us know.

Working with this repository will require basic knowledge of git - you will need to clone the repository locally,
commit your changes as you work on them, and push your changes back to GitHub when you finish.  If you are not familiar
with git and can use some help getting started, please reach out to us.

To run the project, you will need Visual Studio.  You can download _Visual Studio Community 2017_
from https://www.visualstudio.com/downloads/.  When asked about Workflows during the installation, you can choose _.NET Desktop Development_.

You will also need to have the Chrome browser installed. You can download it from https://www.google.com/chrome/browser.

Once you have installed Visual Studio and cloned the repository, open the `OfferPadTest.sln` solution file
at the root of the repository.  This solution contains a minimal test project that you can use
as a starting point.

* From the _Test_ menu, choose _Run_ > _All Tests_ - this should install some dependencies, and then run two tests.
 You should notice Chrome opening the OfferPad page.  Both tests should pass (green).

The initial test project has a single test file (`TestHomePage.cs`) with two very basic tests inside it.
How you evolve the project is up to you - show us how you like to organize tests and any other code you use!

## Automation Tests

Here are the parameters for the automation test:

* Create executable Selenium test cases for the offer page, pretending that customers will be using this page to enter information about their homes. Your tests should do a standard QA pass on the pages: make sure that the page loads, that the fields work, etc. There are many other things that you can test as well, such as negative tests. Show us your QA muscles!

* There is no direct due date on this test. We realize that you are working another job and we want to make it easier on your schedule to get this done. We leave it up to you to discern how long it should take to complete this task and how much you need to put into the test to show us what you are capable of.

* When you are finished, please push your work to GitHub and send us an email.
