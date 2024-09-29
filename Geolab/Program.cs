/*დაწერე პროგრამა, რომელიც For ციკლის გამოყენებით დაბეჭდავს ყველა ლუწ რიცხვს 1-დან 50-მდე.


for (int i=1; i<+50; i++)
{
    if(i%2 == 0)
    {
        Console.WriteLine(i + " ");
    }
} */





/*დაწერე პროგრამა, რომელიც While ციკლის გამოყენებით 5-ჯერ მოსთხოვს მომხმარებელს შეიყვანოს რიცხვი და დაბეჭდავს ამ რიცხვების ჯამს.
int counter = 0;
int sum = 0;

while (counter < 5)
{
    Console.WriteLine("enter number: ");
    int num=int.Parse(Console.ReadLine());
    
    sum += num;
    counter++;
  


}
Console.WriteLine($"Sum is: { sum}");*/

/*დაწერე პროგრამა, რომელიც მომხმარებელს სთხოვს შეიყვანოს 10-ზე ნაკლები რიცხვი და სანამ რიცხვი არ იქნება 10-ზე ნაკლები, ისევ მოითხოვს მონაცემის შეყვანას (Do-While ციკლის გამოყენებით).
int num;
do
{
    Console.Write("Enter number less than 10:");
    num = int.Parse(Console.ReadLine());
}
while (num >= 10); */

/*დაწერე პროგრამა, რომელიც დაბეჭდავს ვარსკვლავების (*) სამკუთხედს შემდეგი ფორმით:
★ 
★★ 
★★★ 
★★★★ 
★★★★★
for(int i=0; i<5; i++)
{
    for(int j=0; j<=i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/

/*დაწერე პროგრამა, რომელიც For ციკლის გამოყენებით დაბეჭდავს რიცხვებს 1-დან 100-მდე, მაგრამ:
თუ რიცხვი იყოფა 3-ზე, დაბეჭდოს "Fizz"
თუ რიცხვი იყოფა 5-ზე, დაბეჭდოს "Buzz"
თუ რიცხვი იყოფა 3-სა და 5-ზე ერთდროულად, დაბეჭდოს "FizzBuzz"




for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write("Fizz ");
    }
    else if (i % 5 == 0)
    {    
        Console.Write("Buzz ");
    }
    else if(i%3==0 )
    {
        Console.Write("FizzBuzz ");
    }
    else
    {
        Console.Write(i + " ");
    }
}
*/

/*დაწერე პროგრამა, რომელიც მომხმარებელს სთხოვს შეიყვანოს პროდუქტების ფასი. ყველა შეყვანის შემდეგ პროგრამამ მომხმარებელს უნდა ჰკითხოს სურს თუ არა გაგრძელება.
თუ მომხმარებელი შეიყვანს “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო ფასის შემოყვანა. ბოლოს პროგრამამ უნდა დაბეჭდოს შეყვანილი პროდუქტების საერთო ღირებულება.

string answer;
decimal sum = 0;
while (true)
{
    Console.Write("Please enter price: ");
    decimal num = decimal.Parse(Console.ReadLine());
    sum += num;
    Console.WriteLine($"Total: {sum}");

    Console.Write("Press y or yes if you want to continue: ");
    answer = Console.ReadLine();

    if (answer != "yes" && answer != "y")
    {
        break;
    }
}  */

/*დაწერე პროგრამა, რომელიც მოსწავლის ქულების შეყვანისას გამოთვლის საშუალო ქულას.
პროგრამამ უნდა სთხოვოს მომხმარებელს შეიყვანოს მოსწავლის ქულები. ქულის შეყვანის შემდეგ პროგრამამ უნდა ჰკითხოს სურს თუ არა გაგრძელება.
თუ მომხმარებელი შეიყვანს “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო ქულის შეყვანა.
ბოლოს პროგრამამ უნდა დაბეჭდოს საშუალო ქულა (შეყვანილი ქულების საშუალო არითმეტიკული). 



string answer;
float sum = 0;
float Counter = 0;

while (true)
{
    Console.Write("Enter point: ");
     var input =Console.ReadLine();
    if(float.TryParse(input, out float grade)){
        sum += grade;
        Counter++;
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
    float average;
    average = sum / Counter;
    Console.WriteLine($"Average point is: {average}");
    Console.Write("Press y or yes if you want to continue: ");
    answer = Console.ReadLine();
    if (answer != "yes" && answer != "y")
    {
        break;
    }

}
*/
/*დაწერე პროგრამა, რომელიც საბანკო ანგარიშის ტრანზაქციებს ამუშავებს. პროგრამა მომხმარებელს სთხოვს შეიყვანოს ტრანზაქციის ტიპი (შემოსავალი ან ხარჯი) და თანხა. 
ინფორმაციის  შეყვანის შემდეგ პროგრამამ უნდა ჰკითხოს სურს თუ არა გაგრძელება.
 თუ მომხმარებელი შეიყვანს “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო ტრანზაქციის ტიპის და თანხის შეყვანა. საბოლოოდ პროგრამამ უნდა დაბეჭდოს ხარჯების ჯამი,
 შემოსავლების ჯამი და ანგარიშის ბალანსი.*/

string TransactionType;
decimal amounth;
decimal TotalIncome = 0;
decimal TotalOutcome = 0;

while (true)
{
    
    Console.Write("Enter transaction type (in or out): ");
    TransactionType = Console.ReadLine();
    if (TransactionType == "in")
    {
        Console.Write("Enter amounth: ");
        amounth = decimal.Parse(Console.ReadLine());
        TotalIncome += amounth;
    }
    else if (TransactionType == "out")
    {
        Console.Write("Enter amounth: ");
        amounth = decimal.Parse(Console.ReadLine());
        TotalOutcome += amounth;
    }
    else
    {
        Console.WriteLine("Make sure to type either in or out ");
    }
    Console.WriteLine($"Total income= {TotalIncome} ");
    Console.WriteLine($"Total outcome = {TotalOutcome}");
    decimal balance = TotalIncome - TotalOutcome;
    Console.WriteLine($"Your balance = {balance}");
    Console.Write("if you want to continue press y or yes. ");
    var input= Console.ReadLine();

    if(input !="y" && input != "yes")
    {
        break;
    }
            
    
    
}



