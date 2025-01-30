using PatikaflixSeriesPlatform.Models;

List<Series> series = new List<Series>();


//Dizi ekleme işlemi    
while (true)
{
    Series newSeries = new Series();

    Console.WriteLine("Dizi adını giriniz: ");
    newSeries.Name = Console.ReadLine();

    Console.WriteLine("Dizi türünü giriniz: ");
    newSeries.SeriesType = Console.ReadLine();

    Console.WriteLine("Yapım yılını giriniz: ");
    newSeries.YearOfProduction = int.Parse(Console.ReadLine());

    Console.WriteLine("Yayınlanmaya Başlama Yılı: ");
    newSeries.StartYear = int.Parse(Console.ReadLine());

    Console.WriteLine("Yönetmeni giriniz: ");
    newSeries.Director = Console.ReadLine();

    Console.WriteLine("Dizinin yayınlandığı platformu giriniz: ");
    newSeries.Platform = Console.ReadLine();

    series.Add(newSeries);


    Console.WriteLine("Yeni bir dizi eklemek ister misiniz? (E/H): ");

    string answer = Console.ReadLine().ToUpper();

    if(answer != "E")
    {
        break;
    }
}

Console.WriteLine("\n----- TÜM DİZİLER -----");

foreach (var item in series)
{
    Console.WriteLine($"Dizi Adı: {item.Name}");
    Console.WriteLine($"Dizi Türü: {item.SeriesType}");
    Console.WriteLine($"Yapım Yılı: {item.YearOfProduction}");
    Console.WriteLine($"Yayınlanmaya Başlama Yılı: {item.StartYear}");
    Console.WriteLine($"Yönetmen: {item.Director}");
    Console.WriteLine($"Yayınlandığı Platform: {item.Platform}");
    Console.WriteLine("************************************");
}

var onlyComedySeries = series.Where(s => s.SeriesType.ToLower().Contains("komedi")).ToList();

List<ComedySeries> comedySeries = new List<ComedySeries>();

foreach (var item in onlyComedySeries)
{
    comedySeries.Add(new ComedySeries
    {
        Name = item.Name,
        SeriesType = item.SeriesType,
        Director = item.Director,

    });
}

//Sıralama

comedySeries = comedySeries.OrderBy(s => s.Name).ThenBy(s => s.Director).ToList();

