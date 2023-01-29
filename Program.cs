string[] inputArray = {"1234", "1567", "-2", "computer science", "1", "-1", ":)"};

int resArraySize = 0;
int resArrayIn = 0;

for (int i = 0; i < inputArray.Length; i++)
    if (inputArray[i].Length <= 3) 
        resArraySize++;

string[] finishArray = new string[resArraySize];

for (int i = 0; i < inputArray.Length; i++)
    if (inputArray[i].Length <= 3)
        finishArray[resArrayIn++] = inputArray[i];

Console.Write(" ");
for (int i = 0; i < finishArray.Length; i++)
    Console.Write(finishArray[i] + ((i != finishArray.Length-1) ? ", " : ""));



