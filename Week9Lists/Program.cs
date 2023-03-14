string folderPath = @"C:\data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppinglist = new List<string>();
myShoppinglist.Count();

if (File.Exists(filePath))
{
    
    myShoppinglist = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppinglist);
    

}
else
{
   File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppinglist = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppinglist);
}




static List<string> GetItemsFromUser()
{
    List<string> userList= new List<string>();


while (true)
{
    Console.WriteLine("Add an item (add)/ exit (exit)");
    string userchoice = Console.ReadLine();

    if (userchoice == "add")
    {
        Console.WriteLine("Enter an item.");
        string userItem = Console.ReadLine();
        userList.Add(userItem);
    }
    else
    {
        Console.WriteLine("Bye!");
        break;
    }

}
return userList;
}


static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}


