// Задача 19. Напишите программу, которая будет проверять является ли введенное число/строка палиндромом.
Console.Clear();// clear console
Console.WriteLine("This programm checks if the entered number is palindrome.");
Console.Write("Enter your string or number: ");
string? userNumber=Console.ReadLine();
PalindromeDetect(userNumber);// call function




void PalindromeDetect (string? userString)
{
int lenght = userString.Length;// find the lenght of the entered string
   for (int index=0; index<(lenght/2); index++)
       {
           if (userString[index]==userString[lenght-index-1]) // if symbols are equal to each other then next step else interrupt this function
               {
                   Console.WriteLine($"The symbol {userString[index]} is equal to the symbol {userString[lenght-index-1]}");
               }
          else
               {
                   Console.WriteLine($"The symbol {userString[index]} is not equal to the symbol {userString[lenght-index-1]}");
                   Console.WriteLine($"The entered string {userString} is not palindrome.");
                   return;
               }
       }
Console.WriteLine($"The entered string {userString} is palindrome.");
}
