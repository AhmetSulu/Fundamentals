# Temel C# Uygulamaları Koleksiyonu

Bu proje, temel C# uygulamalarını içeren bir koleksiyondur. Üç farklı program içerir:

1. **Rastgele Sayı Bulma Oyunu:** Kullanıcıya rastgele bir sayı verilir ve kullanıcı bu sayıyı tahmin etmeye çalışır.
2. **Hesap Makinesi:** Kullanıcı iki sayı girer ve basit matematiksel işlemler (toplama, çıkarma, çarpma, bölme) gerçekleştirir.
3. **Ortalama Hesaplama:** Kullanıcıdan üç ders notu alır ve bu notların ortalamasını hesaplayarak harf notunu belirler.

## Gereksinimler

- .NET Core 3.1 veya daha yeni bir sürüm
- Bir C# destekleyen IDE (Visual Studio, Visual Studio Code vb.)

## Kullanım

### Rastgele Sayı Bulma Oyunu
Program çalıştırıldığında, kullanıcıdan 1 ile 100 arasında bir sayı tahmin etmesi istenir. Kullanıcının 5 tahmin hakkı vardır. Program, tahminlerin doğru olup olmadığına göre kullanıcıyı bilgilendirir.

### Hesap Makinesi
Kullanıcı iki sayı girer ve hangi matematiksel işlemi yapmak istediğini belirtir. Program, belirtilen işlemi gerçekleştirir ve sonucu ekrana yazdırır.

### Ortalama Hesaplama
Kullanıcıdan üç ders notu girilmesi istenir. Notların ortalaması hesaplanır ve bir harf notu ile birlikte ekrana yazdırılır.

## Kullanılan Teknolojiler

- **Dil:** C#

## Kullanılan Yapılar ve Fonksiyonlar

- **Döngüler:** `while`, `switch-case`
- **Koşul İfadeleri:** `if-else`
- **Kullanıcı Girdisi:** `Console.ReadLine()`
- **Girdi Doğrulama:** `int.TryParse()`, `double.TryParse()`
- **Rastgele Sayı Üretimi:** `Random.Next()`
- **Matematiksel İşlemler:** Toplama (+), çıkarma (-), çarpma (*), bölme (/)

## Kurulum

1. **Depoyu Klonlayın:**
    ```sh
    git clone https://github.com/kullanici_adi/temel-csharp-uygulamalari.git
    ```
2. **Projeyi açın:**
    - Bir C# destekleyen IDE ile proje dosyasını açın.
3. **Gereksinimleri yükleyin:**
    - .NET Core 3.1 veya daha yeni bir sürüm kurulu olmalıdır.
4. **Projeyi çalıştırın:**
    - IDE içerisinden veya komut satırından `dotnet run` komutunu kullanarak projeyi çalıştırabilirsiniz.

## Katkıda Bulunma

1. **Fork** edin (https://github.com/kullanici_adi/temel-csharp-uygulamalari/fork)
2. **Yeni bir dal oluşturun** (`git checkout -b ozellik-adi`)
3. **Değişikliklerinizi commit edin** (`git commit -am 'Yeni bir özellik ekledim'`)
4. **Dalınıza push edin** (`git push origin ozellik-adi`)
5. **Bir Pull Request oluşturun**

