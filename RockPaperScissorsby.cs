

const string Rock = "Rock";
const string Paper = "Paper";
const string Scissorsby = "Scissorsb";

Console.Write("[R]ock, [P]aper, [S]cissorsby  :");
string playerMove = (Console.ReadLine());

if (playerMove == "R" || playerMove == "r")
    playerMove = "Rock";
else if (playerMove == "P" || playerMove == "p")
    playerMove = "Paper";
else if (playerMove == "S" || playerMove == "s")
    playerMove = "Scissorsb";
else
    Console.WriteLine("Wrong Choice");

Random random = new Random();
int compRandomNum = random.Next(1, 4);

String computerMove;
if (compRandomNum ==1 )
    computerMove = "Rock";
else if (compRandomNum == 2)
    computerMove = "Paper";
else if (compRandomNum == 3)
    computerMove = "Scissorsb";


