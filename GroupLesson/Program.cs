using System.Text;

string words = "A text or texting is another way of describing text messaging." ;

string [] arr=words.Split(' ');

A a=new A();
a.S(arr);
//int count = 0;

Console.WriteLine(a.S(arr));

class A
{

    public string S(string[] str)
    {
        StringBuilder myTest = new StringBuilder();
        StringBuilder dublicate = new StringBuilder();
        //string[] arr = str.ToString().Split(" ");
        for (int i = 0; i < str.Length; i++)
        {
            foreach (var item in str[i])
            {
                if (myTest.ToString().IndexOf(item.ToString()) == -1)
                {
                    myTest.Append(item);
                }
                else
                {
                    dublicate.Append(item);
                }

            }

        }
        return dublicate.ToString();
    }
}