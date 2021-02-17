using System;

class MainClass {
  public static void Main (string[] args) {
    Pirate pirateOne = new Pirate(); //goes to the class Pirate to make a new varible
    Job pirateJob = new Job(); //goes to the class Job to make a new varible
    Ship theShip = new Ship(); //goes to the class Ship to make a new Varible
    pirateOne.BeardVolume = 5; //set value of beard volume
    pirateOne.MissingLimbs = 12; //set value of missing limbs
    pirateJob.CrewRole = "Captain"; //set value of crew Crew Role
    pirateJob.SkilledIn = "Sword"; // set value of skilled in
    theShip.NumOfCannons = 5; //set value the number of cannons on the ship
    theShip.SpeedOfShip = 40; //sets the max speed of the ship

    //Prints out all the values set in a funny paragraph
    Console.WriteLine($"\nHello I am a pirate.\nI have a voluminous beard that measures {pirateOne.BeardVolume} cubic feet.\nI have fought in many battles and succumbed to scurvy numerous times.\nThis has led to my {pirateOne.MissingLimbs} missing limbs.\nThe job that I have is {pirateJob.CrewRole} and I am proud of my job.\nI have fought in many battles and the weapon that I am skilled at is a {pirateJob.SkilledIn}.\nThe ship that I am on has to have weapons for battle and it has {theShip.NumOfCannons} cannons.\nThe ship is also needs to be fast and the highest it can go is {theShip.SpeedOfShip} mph");
  }
}
class Pirate
{
  public int BeardVolume {get;set;}
  public int MissingLimbs {get;set;}
}
class Job
{
  public string CrewRole {get;set;}
  public string SkilledIn {get;set;} 
}
class Ship
{
  public int NumOfCannons {get;set;}
  public int SpeedOfShip {get;set;}
}