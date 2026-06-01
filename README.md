# 🎭 Kültür Sanat Organizasyon Sistemi

## 📌 Proje Hakkında

Bu proje, kültür ve sanat etkinliklerinin yönetimini kolaylaştırmak amacıyla geliştirilmiş bir organizasyon sistemidir. Kullanıcılar etkinlikleri görüntüleyebilir, bilet işlemlerini gerçekleştirebilir ve organizasyon süreçlerini takip edebilir.

## 🚀 Özellikler

- Etkinlik yönetimi
- Bilet satış işlemleri
- Koltuk yönetimi
- Bilet fiyatlandırma
- İade işlemleri
- Veritabanı kayıt ve sorgulama işlemleri

## 🛠 Kullanılan Teknolojiler

- C#
- ASP.NET
- MySQL
- Entity Framework
- Visual Studio

## 🗄 Veritabanı

Projenin veritabanı dosyası `Database` klasörü içerisinde bulunmaktadır.

```sql
kultursanatorgnizasyon.sql
```

Bu dosya MySQL üzerinde çalıştırılarak veritabanı oluşturulabilir.

## ⚙ Kurulum

1. Projeyi klonlayın:

```bash
git clone https://github.com/busraaisik/KulturSanatOraganizasyon.git
```

2. MySQL üzerinde SQL dosyasını çalıştırın.
3. Connection String ayarlarını düzenleyin.
4. Visual Studio ile çözümü açın.
5. Projeyi çalıştırın.

## 👩‍💻 Geliştiriciler

- Büşra Işık
- Proje Ekibi

## 📂 Proje Yapısı

- KulturSanat.BLL → İş katmanı
- KulturSanat.DAL → Veri erişim katmanı
- KulturSanat.Entity → Varlık sınıfları
- KültürSanatOrganizasyon → Kullanıcı arayüzü
- Database → Veritabanı dosyaları