    string[] names = new string[3];

    for (var i = 0; i < names.Length; i++)
    { 
         //Prints and wants input 3 times and stores the input in array "names"
         Console.WriteLine("Give me a name.");
         names[i] = Console.ReadLine();
         
    }
    
    foreach (string value in names) 
    {
         //prints out the value in the array after each other on the same line
         Console.Write($"{value}, ");
    }
