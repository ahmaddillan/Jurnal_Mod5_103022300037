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

       Console.WriteLine("nilai terbesar: " + proses.DapatkanNilaiTerbesar(in1,in2,in3));
    }
}