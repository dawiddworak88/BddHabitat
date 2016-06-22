# Behavior-driven Development in .NET

## Introduction

Good communication between business and development is one of the biggest predictors of project success. It is proved by The Standish Group CHAOS report that identifies user involvement (15.9%), executive management support (13.9%) and clearly stated requirements (13.0%) as the greatest factors of project success or failure. Behavior-driven development(BDD)is a software development process that significantly improves communication between business and IT by elevating TDD to the next level and filling a gap between user stories, their acceptance criteria and developed code.

## Description

The solution demonstrates fundamentals of Behavior-driven Development in the .NET world. To show the BDD in action the Habitat is used - a Sitecore solution example built on a modular architecture. More information about how to set up Habitat you'll find on the [Habitat Getting Started](https://github.com/Sitecore/Habitat/wiki/01-Getting-Started) page.

It uses SpecFlow, Selenium and the Page Object design pattern to document and test the following user story:

	Feature: As a visitor
		I want to see duration of my visit on pages in milliseconds
		In order to have very precise information about my visit

	Scenario: Preview duration of a visit on More Info page
		Given David opened the Home page
		And he clicked More Info item on the main navigation
		And he read More Info page content for 5500 milliseconds
		And he scrolled up the page
		And he clicked the logo
		And he opened the visitor information sidebar
		And he clicked the Refresh button on the visitor information sidebar
		When he clicks the Engagement tab on the information sidebar
		Then his recent visit on the More Info page is present on the list
		And he can read the duration of his visit on More Info page in milliseconds

## Execute Tests

To run the solution without any code changes, make sure that [Firefox 46.01](https://ftp.mozilla.org/pub/firefox/releases/46.0.1/win64/en-GB/) is installed on your machine and automatic updates are disabled for the time being. The Selenium 2.53.0 is compatible and works well with this version of Firefox. [SpecFlow](https://visualstudiogallery.msdn.microsoft.com/c74211e7-cb6e-4dfa-855d-df0ad4a37dd6) and [NUnit 3 Test Runner](https://visualstudiogallery.msdn.microsoft.com/0da0f6bd-9bb6-4ae3-87a8-537788622f2d) should be installed on your machine as Visual Studio extensions.

The test with fail with a default Sitecore Habitat solution because it displays visit duration in minutes and seconds. [Set up](https://github.com/Sitecore/Habitat/wiki/01-Getting-Started) a [modified Habitat solution](https://github.com/dawiddworak88/Habitat) to execute the test successfully.