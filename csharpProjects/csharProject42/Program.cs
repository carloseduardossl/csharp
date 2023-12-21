double usd = 23.73;
double vnd = UsdToVnd(usd);
Console.WriteLine($"${usd} USD = ${vnd} VND.");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD.");

double UsdToVnd(double usd)
{
    double rate = 23500;
    return (double)rate * usd;
}
double VndToUsd(double vnd)
{
    double rate = 23500;
    return vnd / rate;
}
