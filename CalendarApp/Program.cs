using CalendarApp.Entities;

Console.WriteLine("Calendar App");

Meeting meeting1 = new()
{
    Title = "YetGen Jump & Akbank Backend Planlama Toplantısı",
    Details =new List<string>()
    { 
        "Katılımcıların alım süreçleri konuşulacak", 
        "Akbank'tan gelen mail konuşulacak" 
    },
    StartTime= new DateTime(2023, 09, 18, 19, 00, 00 ),
    FinishTime= new DateTime(2023, 09, 18, 19, 00, 00 ),
    Guests = new() { "hakan@deneme.com", "mehmet@deneme.com"},
};
Todo todo1 = new()
{
    Title = "Katılımcı geri bildirimlerini teslim et",
    Details = new List<string>()
    {
        "Değerlendirme sonuçlarının anonimleştirilmesi",
        "grafik oluşturulması",
    },
    StartTime = new DateTime(2023, 09, 20, 21, 00, 00),
    FinishTime = new DateTime(2023, 09, 20, 20, 00, 00),
    Importance = "High Priority",

};



