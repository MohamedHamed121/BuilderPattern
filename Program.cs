using BuilderPattern;

Console.WriteLine("####################################################################");
Console.WriteLine("##################### THE GREATE PIZZA SHOP ########################");
Console.WriteLine("####################### HELLO AND WELCOME ##########################");
Console.WriteLine("####################################################################");
Console.WriteLine("##################### welcome to our pizza shop ####################");
Console.WriteLine("################ choose your prefared ingridiants ?? ###############");
Console.WriteLine("############ 1: Vegaetables 2: nuts 3: SeaFood 4: cheese ###########");
Console.WriteLine("########## 5: Exotic 6: Herbs 7: Meats 8: Souce 9: Spices###########");

var order = Console.ReadLine();
PizzaBuilder pizza = new PizzaBuilder();

for (int i = 0; i < order?.Length; i++)
{
    switch (order[i])
    {
        case '1':
            pizza.SetVegetables();
            break;
        case '2':
            pizza.SetNuts();
            break;
        case '3':
            pizza.SetSeaFood();
            break;
        case '4':
            pizza.SetChese();
            break;
        case '5':
            pizza.SetExotic();
            break;
        case '6':
            pizza.SetHerbs();
            break;
        case '7':
            pizza.SetMeats();
            break;
        case '8':
            pizza.SetSouce();
            break;
        case '9':
            pizza.SetSpices();
            break;
        default:
            Console.WriteLine("thanks");
            break;
    }
}


Console.WriteLine("########### YOUR PRODUCT IS READY#######################");
Console.WriteLine($"you have chosen the pizza with {pizza.GetProduct()}");



