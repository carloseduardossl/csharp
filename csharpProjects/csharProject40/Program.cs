string[,] corporate =
{
    {"Robert", "Bavin"} , {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinna", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody","Dysaty"},
    {"Shay","Lawrence"},{"daren","Valdes"}
};

string exertnalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    DisplayEmail(first: corporate[i, 0], corporate[i, 1]);
}
for (int i = 0; i < external.GetLength(0); i++)
{
    DisplayEmail(first: external[i, 0], last: external[i, 1], domain: exertnalDomain);
}

void DisplayEmail(string first, string last, string domain = "contosco.com")
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}