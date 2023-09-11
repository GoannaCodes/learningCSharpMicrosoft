using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] {90, 86, 87, 98, 100};
int[] andrewScores = new int[] {92, 89, 81, 96, 90};
int[] emmaScores = new int[] {90, 85, 87, 98, 68};
int[] loganScores = new int[] {90, 95, 87, 88, 96};

//student names
string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};

int[] studentScores = new int[10];

//Write report header to console
Console.WriteLine("Student\t\tGrade\n");


foreach (string name in studentNames){
    string currentName = name;
    if (currentName == "Sophia")
        studentScores = sophiaScores;
    else if (currentName == "Andrew")
        studentScores = andrewScores;
    else if (currentName == "Emma")
        studentScores = emmaScores;
    else if (currentName == "Logan")
        studentScores = loganScores;
    
    //initialise/reset sum of scored assignments
    int sumAssignmentScores = 0;

    //initialise/reset calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    foreach(int score in studentScores){
        //add exam score to sum
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores)/currentAssignments;
    Console.WriteLine($"{currentName}\t\t{currentStudentGrade}\t?");
}




Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
