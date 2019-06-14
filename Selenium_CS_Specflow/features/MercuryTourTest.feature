Feature: MercuryTour Demo Testing

  Scenario: MercuryTour Book Flights
    Given url opened with browser "chrome"
    When enter user id as "mercury"
    And enter password as "mercury"
    And click login
    Then select flight form exists