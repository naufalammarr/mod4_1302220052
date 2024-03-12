using tp_mod4_1302220052;

internal class Program
{
    private static void Main(string[] args)
    {
        
        kodepos kodePosObj = new kodepos();

        string kodePosBatununggal = kodePosObj.GetKodePos("Batununggal");
        string kodePosKujangSari = kodePosObj.GetKodePos("Kujangsari");
        string kodePosKujangSamoja = kodePosObj.GetKodePos("Samoja");

        Console.WriteLine("Kode Pos Batununggal: " + kodePosBatununggal);
        Console.WriteLine("Kode Pos Kujangsari: " + kodePosKujangSari);
        Console.WriteLine("Kode Pos Samoja: " + kodePosKujangSamoja);
        Console.WriteLine("");

    }
}
  