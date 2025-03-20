using System;
public class pemrosesData() { 
    public T DapatkanNilaiTerbesar<T>(T nil, T lai, T a) {
        dynamic b = nil;
        dynamic c = lai;
        dynamic d = a;
        dynamic terbesar = b;
        if (Convert.ToInt32(terbesar) < Convert.ToInt32(c))
        {
            terbesar = c;
        }
        if (Convert.ToInt32(terbesar) < Convert.ToInt32(d))
        {
            terbesar = d;
        }

        return terbesar;
    }
}

public class SimpleDataBase<T> {
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();

    }

    public void addNewData(T data) {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void printAllData() {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("\ndata inputan: " + storedData[i]);
            Console.WriteLine("tanggal : " + inputDates[i]);
        }
    }
}


public class program() {
    public static void Main() {
        String in1, in2, in3;
        pemrosesData proses = new pemrosesData();

        Console.WriteLine("masukkan nilai pertama: ");
        in1 = Console.ReadLine();
        Console.WriteLine("masukkan nilai kedua: ");
        in2 = Console.ReadLine();
        Console.WriteLine("masukkan nilai ketiga: ");
        in3 = Console.ReadLine();
        Console.WriteLine("nilai terbesar: " + proses.DapatkanNilaiTerbesar(in1, in2, in3));

        SimpleDataBase<int> dataBase = new SimpleDataBase<int>();
        dataBase.addNewData(12);
        dataBase.addNewData(34);
        dataBase.addNewData(56);
        dataBase.printAllData();
    }
}