//Samuel Laguna
//10-19-22
//We are going to mini challnge 2 in a diffrent way but get the same answer. 
//Peer Review: 


Console.Clear();

    bool playAgain = true;
bool end = false;

int num1 = 0;
int num2 = 0;
bool numberOne = false;
bool numberTwo = false;
while(playAgain){
Console.WriteLine("We are going to be adding two number together");
Console.WriteLine("Enter your first number please");
while(!numberOne)
{
    numberOne = Int32.TryParse(Console.ReadLine(), out num1);
    if(numberOne == false)
    {
        Console.WriteLine("Not a number");
    }
    else
    {
        numberOne = true;
    }
}
while(!numberTwo){
Console.WriteLine("Please enter your second number");
numberTwo = Int32.TryParse(Console.ReadLine(), out num2);
if(numberTwo == false)
{
    Console.WriteLine("This is not a number");

}else
{
    numberTwo = true;
}
}
Console.WriteLine("Your sum is " + (num1 + num2));

        Console.WriteLine("PlayAgain to try again, end to end");
    string ending = Console.ReadLine();
   if (ending == "end"){
    playAgain = false;
      
   }else{
    end = true;
   }

}
