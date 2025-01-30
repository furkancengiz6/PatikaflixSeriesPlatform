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
## 📺 Girilen Diziler ve Çıktılar

### 🎬 **Kullanıcı Girişi**

---

### 📋 **Tüm Diziler Listesi**
| #️⃣ | Dizi Adı          | Yapım Yılı | Türü            | Yönetmen       | Platform   |
|----|------------------|------------|----------------|--------------|-----------|
| 1️⃣  | **Avrupa Yakası** | 2004       | 🎭 **Komedi**   | Yüksel Aksu   | Kanal D   |
| 2️⃣  | **Arka Sokaklar** | 2006       | 🎭 **Polisiye, Dram** | Orhan Oğuz  | Kanal D   |

---

### 🎭 **Komedi Dizileri**
| #️⃣ | Dizi Adı         | Türü       | Yönetmen      |
|----|-----------------|-----------|-------------|
| 🎭  | **Avrupa Yakası** | Komedi    | Yüksel Aksu |

---

✔ **Not:**  
- Komedi dizileri yalnızca **türüne göre filtrelenmiş** ve **isim sırasına göre** sıralanmıştır.  
- Tüm dizilerde **yönetmen ve platform bilgileri** yer almaktadır.  

---
