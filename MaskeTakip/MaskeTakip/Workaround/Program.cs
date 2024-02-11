

public class Program
{
    private static void Main(string[] args)
    {
        static void SelamVer()
        {
            Console.WriteLine("merhaba");
            SelamVer();
            SelamVer();
            SelamVer();
        }
       
        Person person1 = new Person();
        person1.FirstName = "Muhammed Ertuğrul";
        person1.LastName = "Yanardağ";
        person1.DateOfBirthYear = 1993;
        person1.NationalIdentity = 41167744420;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);
    }
        
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}
