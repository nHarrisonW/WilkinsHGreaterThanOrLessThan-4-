//N. Harrison Wilkins
//10-18-2022
//GitHub Project Part 4 - GREATER, LESS THAN, OR EQUAL TO
//this project will compare two different numbers declared by the user and will let the user know which number is greater than the other, or if they are equal too
//PEER REVIEW IS IN README

Console.Clear();

//all variables regarding this project will be defined here
bool isNum, isNumTwo;
string numOne, numTwo;
int intNumOne = 0;
int intNumTwo = 0;


Console.WriteLine("HELLO! ITS SO NICE TO SEE YOU AGAIN!");
do{
    isNum = false;
    isNumTwo = false;
    while(!isNum){
    Console.WriteLine("ENTER A NUMBER!");

    numOne = (Console.ReadLine());
    isNum = int.TryParse(numOne, out intNumOne);

    if(isNum == false){
        Console.WriteLine("I STRICTLY ACCEPT NUMBERS! TRY AGAIN");
    }

    }
    while(!isNumTwo){
    Console.WriteLine("ENTER A NUMBER!");

    numTwo = (Console.ReadLine());
    
    isNumTwo = int.TryParse(numTwo, out intNumTwo);

    if(isNumTwo == false){

        Console.WriteLine("I STRICTLY ACCEPT NUMBERS! TRY AGAIN");
    }

    }
    if( intNumOne > intNumTwo){
        Console.WriteLine(intNumOne + " IS GREATER THAN " + intNumTwo + "!");
        Console.WriteLine("ENTER \"Y\" TO TRY AGAIN OR ENTER ANY KEY TO EXIT");
    }
        if(intNumOne < intNumTwo){
        Console.WriteLine(intNumOne + " IS LESS THAN " + intNumTwo + "!");
        Console.WriteLine("ENTER \"Y\" TO TRY AGAIN OR ENTER ANY KEY TO EXIT");
    }
        if(intNumOne == intNumTwo){
        Console.WriteLine(intNumOne + " IS EQUAL TO " + intNumTwo + "!");
        Console.WriteLine("ENTER \"Y\" TO TRY AGAIN OR ENTER ANY KEY TO EXIT");
    }

    
}while(Console.ReadLine().ToUpper() == "Y");


    
