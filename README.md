# 🎓 Özel Öğrenci Okul Otomasyonu

**Özel Öğrenci Okul Otomasyonu**, eğitim kurumlarının günlük operasyonlarını dijitalleştirmek, öğrenci ve personel takibini kolaylaştırmak ve finansal süreçleri yönetmek için tasarlanmış kapsamlı bir Windows masaüstü uygulamasıdır. **C#** ve **.NET Framework** altyapısı üzerine inşa edilmiş olup, **DevExpress** kütüphaneleri ile modern ve kullanıcı dostu bir arayüz sunar.

---

## 🚀 Öne Çıkan Özellikler

### 👥 Öğrenci ve Veli Yönetimi
*   Detaylı öğrenci kayıt ve profil yönetimi.
*   Veli iletişim bilgileri ve geçmiş kayıtlar.
*   Öğrenci gelişim raporlaması.

### 📅 Akademik Takvim ve Planlama
*   **Akıllı Ders Programı**: Yapay zeka destekli ders programı oluşturma ve optimizasyon.
*   **Takvim Entegrasyonu**: Haftalık ve aylık ders programı görünümü.
*   Öğretmen müsaitlik durumu takibi.

### 💰 Finansal Yönetim
*   **Fatura ve Tahsilat**: Öğrenci ücretlendirme, taksitlendirme ve ödeme takibi.
*   **Raporlama**: Gelir/Gider dengesi ve ödenmemiş bakiye uyarıları.

### 👨‍🏫 Personel Yönetimi
*   Öğretmen atamaları ve branş yönetimi.
*   Ders yükü takibi.

---

## 🛠 Teknoloji Yığını

Bu proje aşağıdaki güçlü teknolojiler kullanılarak geliştirilmiştir:

*   **Programlama Dili**: C#
*   **Framework**: .NET Framework 4.7.2
*   **Arayüz (UI)**: DevExpress v24.1 (WinForms)
*   **Veritabanı**: Microsoft SQL Server
*   **ORM / Veri Erişimi**: ADO.NET / Custom SQL Helpers

---

## ⚙️ Kurulum ve Başlangıç

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

### Gereksinimler
*   Visual Studio 2019 veya daha yeni sürüm.
*   .NET Framework 4.7.2 SDK.
*   SQL Server (Express veya tam sürüm).
*   DevExpress WinForms Components (v24.1).

### Adım Adım Kurulum

1.  **Projeyi Klonlayın**
    ```bash
    git clone https://github.com/ugurboz/Ozel-Ogrenci-Okul-Otomasyonu.git
    ```

2.  **Veritabanını Hazırlayın**
    *   SQL Server Management Studio (SSMS) üzerinden yeni bir veritabanı oluşturun (Örn: `OkulOtomasyonDb`).
    *   Proje dizinindeki `SetupDatabase.sql` dosyasını çalıştırarak gerekli tabloları oluşturun.

3.  **Bağlantı Ayarlarını Yapılandırın**
    *   `sqlYardimcisi.cs` veya `App.config` dosyasındaki *ConnectionString* değerini kendi sunucu bilgilerinizle güncelleyin.

4.  **Derleme ve Çalıştırma**
    *   Projeyi Visual Studio ile açın.
    *   Solution Explorer üzerinden **Restore NuGet Packages** işlemi yapın.
    *   `F5` tuşuna basarak uygulamayı başlatın.

---

## 🤝 Katkıda Bulunma

Projeye katkıda bulunmak istiyorsanız:
1.  Bu repoyu Fork'layın.
2.  Yeni bir özellik dalı (feature branch) oluşturun (`git checkout -b ozellik/YeniOzellik`).
3.  Değişikliklerinizi commit'leyin (`git commit -m 'Yeni özellik eklendi'`).
4.  Dalı push'layın (`git push origin ozellik/YeniOzellik`).
5.  Bir Pull Request oluşturun.

---

## 📄 Lisans

Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır. Detaylar için lisans dosyasına bakınız.