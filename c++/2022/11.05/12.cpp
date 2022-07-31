#include<bits/stdc++.h>
#include <ctime>
using namespace std;

int dayNumber(int day, int month, int year)
{
 
    static int t[] = { 0, 3, 2, 5, 0, 3, 5, 1,
                       4, 6, 2, 4 };
    year -= month < 3;
    return ( year + year/4 - year/100 +
             year/400 + t[month-1] + day) % 7;
}

string getMonthName(int monthNumber)
{
    string months[] = {"January", "February", "March",
                       "April", "May", "June",
                       "July", "August", "September",
                       "October", "November", "December"
                      };
 
    return (months[monthNumber]);
}

int numberOfDays (int monthNumber, int year)
{
    // January
    if (monthNumber == 0)
        return (31);
 
    // February
    if (monthNumber == 1)
    {
        if (year % 400 == 0 ||
                (year % 4 == 0 && year % 100 != 0))
            return (29);
        else
            return (28);
    }
 
    // March
    if (monthNumber == 2)
        return (31);
 
    // April
    if (monthNumber == 3)
        return (30);
 
    // May
    if (monthNumber == 4)
        return (31);
 
    // June
    if (monthNumber == 5)
        return (30);
 
    // July
    if (monthNumber == 6)
        return (31);
 
    // August
    if (monthNumber == 7)
        return (31);
 
    // September
    if (monthNumber == 8)
        return (30);
 
    // October
    if (monthNumber == 9)
        return (31);
 
    // November
    if (monthNumber == 10)
        return (30);
 
    // December
    if (monthNumber == 11)
        return (31);
}

void printCalendar(int year)
{
    printf ("         Calendar - %d\n\n", year);
    int days;
 
    // Index of the day from 0 to 6
    int current = dayNumber (1, 1, year);
    
    for (int i = 0; i < 12; i++)
    {
        days = numberOfDays (i, year);
 
        // Print the current month name
        printf("\n  ------------%s-------------\n",
               getMonthName (i).c_str());
 
        // Print the columns
        printf("  Sun  Mon  Tue  Wed  Thu  Fri  Sat\n");
 
        // Print appropriate spaces
        int k;
        for (k = 0; k < current; k++)
            printf("     ");
 
        for (int j = 1; j <= days; j++)
        {
            printf("%5d", j);
 
            if (++k > 6)
            {
                k = 0;
                printf("\n");
            }
        }
 
        if (k)
            printf("\n");
 
        current = k;
    }
 
    return;
}
 
void printNow()
{
    std::time_t t = std::time(0);   // get time now
    std::tm* now = std::localtime(&t);
    std::cout << (now->tm_year + 1900) << '-' 
         << (now->tm_mon + 1) << '-'
         <<  now->tm_mday
         << "\n";
}

void displayDayOfWeek(int d, int m, int y)
{
    static int t[] = { 0, 3, 2, 5, 0, 3,
                       5, 1, 4, 6, 2, 4 };
    y -= m < 3;
    int orderNo = ( y + y / 4 - y / 100 +
             y / 400 + t[m - 1] + d) % 7;

    string months[] = {"Monday", "Tuesday", "Wednesday",
                    "Thursday", "Friday", "Saturday",
                    "Sunday"
                    };
    
    cout << months[orderNo];
}

void displayDays(int month, int year)
{
    int days = numberOfDays (month, year);
    int k = 0;
    for (int j = 1; j <= days; j++)
    {
        printf("%5d", j);

        if (++k > 6)
        {
            k = 0;
            printf("\n");
        }
    }
}

void main_loop(string str)
{
    if (str.length() == 10)
    {
        int year = stoi(str.substr(0,4));
        int month = stoi(str.substr(5,2));
        int day = stoi(str.substr(8,2));
        displayDayOfWeek(day, month, year);
    }
    else if (str.length() == 7)
    {
        int year = stoi(str.substr(0,4));
        int month = stoi(str.substr(5,2));
        displayDays(month, year);
    }
    else if (str.length() == 4)
    {
        printCalendar(stoi(str));
    }
    else if (str == "now")
    {
        printNow();
    }
    else
    {
        cout << "incorrect input";
    }
}

int main()
{
    string name; 
    getline(cin, name); 
    main_loop(name);
    return 0;
}