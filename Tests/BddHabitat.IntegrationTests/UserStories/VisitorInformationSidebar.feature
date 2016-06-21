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