namespace FinalProject2;
class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, double> dict_entree = new Dictionary<string, double>();
        dict_entree.Add("Cheese Pizza", 11.25);
        dict_entree.Add("Peparoni Pizza", 12.30);
        dict_entree.Add("Sausage Pizza", 13.25);
        dict_entree.Add("Veg Pizza", 12.50);
        // print food-price of all entree items
        int entree_index = 0;
        foreach(var item in dict_entree){
            Console.WriteLine($"{entree_index} - {item.Key} - {item.Value}");
            entree_index++;
        }

        Console.WriteLine("******* Welcome To Village Pizza ************");


        Console.WriteLine("-->Select Entree: ");
        int selected_entree_index = Convert.ToInt16(Console.ReadLine());
        // select a food item and print it name/price
        string entree_name = dict_entree.ElementAt(selected_entree_index).Key;
        double entree_price = dict_entree.ElementAt(selected_entree_index).Value;
        Console.WriteLine($"Selected Item: {entree_name} - {entree_price}");
        
        // selcet an entree to remove
        Console.WriteLine("-->Select Entree to remove: ");
        int removed_entree_index = Convert.ToInt16(Console.ReadLine());
        string selected_item_key = dict_entree.ElementAt(removed_entree_index).Key;
        dict_entree.Remove(selected_item_key);

        // reset item index and print current dict_entree. We can see the selected item is removed
        entree_index = 0;
        foreach(var item in dict_entree){
            Console.WriteLine($"{entree_index} - {item.Key} - {item.Value}");
            entree_index++;
        }
    }





    //}
}
