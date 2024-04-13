using static System.Console;
using static System.Convert;
using static System.Math;


int n;
int[] arr1 = new int[3005];
int mx = 0,res=0;
Array.Clear(arr1, 0, 3001);
n = ToInt32(ReadLine());
string str1 = ReadLine();

var arr2 = str1.Split(" ");

for(int i = 0; i < n; i++)
{
    arr1[ToInt32(arr2[i])]++;
    mx = Max(mx, ToInt32(arr2[i]));
}



for(int i = 0;i <= mx+1; i++)
{
    if (arr1[i] == 0 && i != 0)
    {
        res = i; 
        break;
    }
}

WriteLine(res);