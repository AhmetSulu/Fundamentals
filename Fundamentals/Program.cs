while (true)
{
    // Kullanıcıya hangi programı çalıştırmak istediğini sorar ve seçenekleri gösterir
    Console.WriteLine("Hangi programı çalıştırmak istersiniz?");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
    Console.WriteLine("2 - Hesap Makinesi");
    Console.WriteLine("3 - Ortalama Hesaplama");
    Console.WriteLine("------------------------------------------------");
    Console.Write("Seçiminiz :");
    string? input = Console.ReadLine();

    // Kullanıcı girdisini int'e çevirmeye çalışır
    if (!int.TryParse(input, out int choice))
    {
        // Geçersiz giriş durumunda hata mesajı verir ve döngüyü devam ettirir
        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
        continue;
    }

    // Kullanıcının seçimine göre ilgili programı çalıştırır
    switch (choice)
    {
        case 1:
            RastgeleSayıBulmaOyunu();
            break;
        case 2:
            HesapMakinesi();
            break;
        case 3:
            OrtalamaHesaplama();
            break;
        default:
            // Geçersiz seçim durumunda hata mesajı verir
            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            break;
    }
}

static void RastgeleSayıBulmaOyunu()
{
    // Rastgele bir sayı üretir (1 ile 100 arasında)
    Random random = new Random();
    int rndNumber = random.Next(1, 101);
    int tahminHakki = 5; // Kullanıcının 5 tahmin hakkı vardır
    Console.WriteLine("1 ile 100 arasında bir sayı tuttum 5 hakkın var bilebilecek misin?");

    // Kullanıcının tahmin yapmasını sağlayan döngü
    while (tahminHakki > 0)
    {
        Console.Write("Tahmininiz: ");
        string? tahminInput = Console.ReadLine();

        // Kullanıcı girdisini int'e çevirmeye çalışır
        if (!int.TryParse(tahminInput, out int userGuess))
        {
            // Geçersiz giriş durumunda hata mesajı verir ve döngüyü devam ettirir
            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
            continue;
        }

        // Kullanıcının tahmini doğru ise tebrik eder ve döngüyü sonlandırır
        if (userGuess == rndNumber)
        {
            Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
            return;
        }
        else if (userGuess > rndNumber)
        {
            // Kullanıcının tahmini büyükse yönlendirir
            Console.WriteLine("Daha düşük bir sayı giriniz");
        }
        else
        {
            // Kullanıcının tahmini küçükse yönlendirir
            Console.WriteLine("Daha büyük bir sayı giriniz");
        }

        // Tahmin hakkını azaltır ve kalan hakkı bildirir
        tahminHakki--;
        Console.WriteLine($"Kalan tahmin hakkınız: {tahminHakki}");
    }

    // Tahmin hakkı dolduğunda doğru sayıyı bildirir
    Console.WriteLine($"Maalesef, tahmin hakkınız doldu. Doğru sayı: {rndNumber}");





}

static void HesapMakinesi()
{
    // İlk sayıyı kullanıcıdan alır
    Console.Write("İlk sayıyı giriniz: ");
    string? num1Input = Console.ReadLine();

    // Kullanıcı girdisini double'a çevirmeye çalışır
    if (!double.TryParse(num1Input, out double num1))
    {
        // Geçersiz giriş durumunda hata mesajı verir ve fonksiyonu sonlandırır
        Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
        return;
    }

    // İkinci sayıyı kullanıcıdan alır
    Console.Write("İkinci sayıyı giriniz: ");
    string? num2Input = Console.ReadLine();

    // Kullanıcı girdisini double'a çevirmeye çalışır
    if (!double.TryParse(num2Input, out double num2))
    {
        // Geçersiz giriş durumunda hata mesajı verir ve fonksiyonu sonlandırır
        Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
        return;
    }

    // Kullanıcının yapmak istediği işlemi alır
    Console.WriteLine("Yapmak istediğiniz işlemi seçin: (+, -, *, /)");
    string? processInput = Console.ReadLine();

    // İşlem girişini kontrol eder
    if (string.IsNullOrEmpty(processInput) || processInput.Length != 1)
    {
        // Geçersiz işlem durumunda hata mesajı verir ve fonksiyonu sonlandırır
        Console.WriteLine("Geçersiz işlem.");
        return;
    }

    char process = processInput[0];
    double result = 0;

    // İşleme göre hesaplamayı yapar
    switch (process)
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            // Sıfıra bölme kontrolü yapar
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                // Sıfıra bölme hatası durumunda mesaj verir ve fonksiyonu sonlandırır
                Console.WriteLine("Hata: Sıfıra bölme hatası.");
                return;
            }
            break;
        default:
            // Geçersiz işlem durumunda hata mesajı verir ve fonksiyonu sonlandırır
            Console.WriteLine("Geçersiz işlem.");
            return;
    }
    // Hesaplama sonucunu gösterir
    Console.WriteLine($"Sonuç: {result}");








}

static void OrtalamaHesaplama()
{
    // Birinci ders notunu kullanıcıdan alır
    Console.Write("Birinci ders notunu giriniz: ");
    string? grade1Input = Console.ReadLine();

    // Kullanıcı girdisini double'a çevirmeye çalışır ve notun geçerli olup olmadığını kontrol eder
    if (!double.TryParse(grade1Input, out double grade1) || grade1 < 0 || grade1 > 100)
    {
        // Geçersiz not durumunda hata mesajı verir ve fonksiyonu sonlandırır
        Console.WriteLine("Geçersiz not. Program sonlandırılıyor.");
        return;
    }

    // İkinci ders notunu kullanıcıdan alır
    Console.Write("İkinci ders notunu giriniz: ");
    string? grade2Input = Console.ReadLine();

    // Kullanıcı girdisini double'a çevirmeye çalışır ve notun geçerli olup olmadığını kontrol eder
    if (!double.TryParse(grade2Input, out double grade2) || grade2 < 0 || grade2 > 100)
    {
        // Geçersiz not durumunda hata mesajı verir ve fonksiyonu sonlandırır
        Console.WriteLine("Geçersiz not. Program sonlandırılıyor.");
        return;
    }

    // Üçüncü ders notunu kullanıcıdan alır
    Console.Write("Üçüncü ders notunu giriniz: ");
    string? grade3Input = Console.ReadLine();

    // Kullanıcı girdisini double'a çevirmeye çalışır ve notun geçerli olup olmadığını kontrol eder
    if (!double.TryParse(grade3Input, out double grade3) || grade3 < 0 || grade3 > 100)
    {
        // Geçersiz not durumunda hata mesajı verir ve fonksiyonu sonlandırır
        Console.WriteLine("Geçersiz not. Program sonlandırılıyor.");
        return;
    }

    // Notların ortalamasını hesaplar
    double average = (grade1 + grade2 + grade3) / 3;
    Console.WriteLine($"Ortalama: {average}");

    char latterGrade;

    // Ortalama nota göre harf notunu belirler
    if (average >= 90)
        latterGrade = 'A';
    else if (average >= 85)
        latterGrade = 'B';
    else if (average >= 80)
        latterGrade = 'B';
    else if (average >= 75)
        latterGrade = 'C';
    else if (average >= 70)
        latterGrade = 'C';
    else if (average >= 65)
        latterGrade = 'D';
    else if (average >= 60)
        latterGrade = 'D';
    else if (average >= 55)
        latterGrade = 'F';
    else
        latterGrade = 'F';

    // Harf notunu kullanıcıya gösterir
    Console.WriteLine($"Harf Notu: {latterGrade}");
}