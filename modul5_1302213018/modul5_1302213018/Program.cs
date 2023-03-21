using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Program {
    public static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(21);
        data.PrintAllData();
    }


}
public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }
    public void AddNewData(T newdata)
    {
  
    this.inputDates.Add(DateTime.Now);
    this.storedData.Add(newdata);
    }
    public void PrintAllData()
    {
        for(int i = 0; i < this.inputDates.Count; i++)
        {
            Console.WriteLine("Data " + i + " berisi " + this.storedData[i] + " yang disimpan pada waktu UTC : " + this.inputDates[i]);
        }
    }
}


