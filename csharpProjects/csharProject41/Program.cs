

double Total = 0;
double MinimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for(int i = 0; i < items.Length; i++)
{
    Total += GetDiscountedPrice(i);
}
if(TotalMeetsMinimum())
{
    Total -= 5.00;
}

Console.WriteLine($"Total : {FormatDecimal(Total)}");
double GetDiscountedPrice (int itemindex)
{
    return items[itemindex] * (1 - discounts[itemindex]) ;
}
bool TotalMeetsMinimum ()
{
    return Total >= MinimumSpend;
}
string FormatDecimal (double input)
{
    return input.ToString().Substring(0,5);
}