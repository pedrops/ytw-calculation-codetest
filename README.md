# YTW calculation project pedrops

## Request
Requested code and knowledgement challenge 04/19/2024
Author: Pedro Monzon

## Features

- Backend project IMTC.CodeTest
- Backend project IMTC.CodeTest.App
- Backend project IMTC.CodeTest.Application
- Backend project IMTC.CodeTest.Domain
- Frontend bond-search
- Frontend services

## App Description
This project connects a backend(net 7) and frontend(angular 17) with a simple call.
The main idea was to enrich ==YtwCalculator== class.

For this purpose there are some design patterns that were applied like:
- CQRS
- Mediator
- Dependency Injection

A data base interaction was not created for the moment but for testing purposes a cached data was stablished inside ==BondService== class.

## Testing
For testing purposes, both projects should be initialized.

## Backend: build and run (dotnet run)

A swagger module is displayed with a get and a post endpoints. (See next image: https://ibb.co/Xsptd6T)
- For get, "bond 1" is good example to search
    * This endpoint collects the bond filtering by the name
- For post, this is a good example for the body:
   {
    "name": "bond 1",
    "faceValue": 5000,
    "couponRate": 50,
    "maturityDate": "2024-04-22T06:15:10.939Z",
    "couponType": 1,
    "bondType": 1
    }
    * That was the post process for ytw calculation.
     
**    Please consider this is just an approximation of the response, this project do not have the intend of resolve any real calculation for ytw, this is just randomizing the calculations with the idea to just test the app flow.

## Frontend: build and run (ng serve)
An html app is beind displayed, there is a "search" ("buscar"), text/button to find a bond from the backend. (See next image: https://ibb.co/BZWh8Rv)
- Search: "bond 2" is good example to search
- Bond information will be displayed
- Calculate jwt ("Calcular jwt") which will make the post call with the object obtained with the previous search.
