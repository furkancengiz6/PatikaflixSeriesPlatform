# 📺 Patikaflix Series Platform

Patikaflix Series Platform, kullanıcının dizi bilgilerini girerek liste oluşturmasını sağlayan **C# Console** tabanlı bir uygulamadır.  
Girilen diziler kaydedilir, ardından **tüm diziler ve sadece komedi türündeki diziler** sıralı şekilde ekrana yazdırılır.  

## 🚀 Proje Özellikleri
- Kullanıcı **dizi adı, yapım yılı, türü, yönetmeni ve platformu** girerek liste oluşturabilir.
- Kullanıcı **istediği kadar dizi ekleyebilir** ve işlem tamamlandığında liste ekrana yazdırılır.
- **Komedi türündeki diziler** ayrıca filtrelenerek sıralı bir şekilde gösterilir.
- LINQ sorguları kullanılarak dizileri **türüne ve yönetmen adına göre sıralama** yapılır.
- Nesne yönelimli programlama (OOP) prensiplerine uygun olarak geliştirilmiştir.

## 📌 Kullanılan Teknolojiler
- **C#**  
- **.NET Core Console**  
- **LINQ (Language Integrated Query)**  

## 📂 Proje Yapısı
```plaintext
PatikaflixSeriesPlatform
│── Program.cs
│── Dizi.cs
│── KomediDizisi.cs
│── README.md
```
## 🖥️ Örnek Çıktı
Dizi Adı: Avrupa Yakası
Yapım Yılı: 2004
Türü: Komedi
Yayınlanmaya Başlama Yılı: 2004
Yönetmen: Yüksel Aksu
Yayınlandığı Platform: Kanal D
Yeni bir dizi eklemek istiyor musunuz? (E/H): E

Dizi Adı: Arka Sokaklar
Yapım Yılı: 2006
Türü: Polisiye, Dram
Yayınlanmaya Başlama Yılı: 2006
Yönetmen: Orhan Oğuz
Yayınlandığı Platform: Kanal D
Yeni bir dizi eklemek istiyor musunuz? (E/H): H

----- TÜM DİZİLER -----
1️⃣ Avrupa Yakası (2004) - Tür: Komedi, Yönetmen: Yüksel Aksu, Platform: Kanal D
2️⃣ Arka Sokaklar (2006) - Tür: Polisiye, Dram, Yönetmen: Orhan Oğuz, Platform: Kanal D

----- KOMEDİ DİZİLERİ -----
🎭 Avrupa Yakası - Tür: Komedi, Yönetmen: Yüksel Aksu
