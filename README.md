# CodeFirstDemo API

Bu proje, **Entity Framework Core** kullanarak **Code First** yaklaşımı ile **SQL Server** veritabanına bağlanan bir ASP.NET Core Web API uygulamasıdır.

## 🚀 Proje Açıklaması
Bu proje ile **Movie** ve **Game** tablolarını içeren bir veritabanı oluşturulmaktadır. API üzerinden bu tablolara CRUD (Create, Read, Update, Delete) işlemleri yapılabilir.

## 🛠️ Kurulum Adımları
### 1️⃣ **Projeyi Çalıştırmak İçin Gerekli Bağımlılıkları Yükleyin**

Öncelikle aşağıdaki paketleri yükleyin:

```sh
 dotnet add package Microsoft.EntityFrameworkCore
 dotnet add package Microsoft.EntityFrameworkCore.SqlServer
 dotnet add package Microsoft.EntityFrameworkCore.Design
 dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### 2️⃣ **Veritabanı Bağlantısını Yapılandırın**
📂 **appsettings.json** dosyanızı şu şekilde düzenleyin:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=EKIN;Database=PatikaCodeFirstDb1;Trusted_Connection=True;TrustServerCertificate=True"
}
```

📂 **Program.cs** dosyanızda `DbContext` yapılandırmasını şu şekilde ayarlayın:
```csharp
builder.Services.AddDbContext<PatikaFirstDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

### 3️⃣ **Migration (Göç) ve Veritabanı Güncelleme İşlemleri**
Veritabanı tablolarını oluşturmak için aşağıdaki komutları çalıştırın:
```sh
 dotnet ef migrations add InitialCreate
 dotnet ef database update
```
✅ **Bu işlem sonunda veritabanınızda `Movies` ve `Games` tabloları oluşturulmuş olacak.**

### 4️⃣ **Projeyi Çalıştırma**
Projeyi çalıştırmak için şu komutu kullanın:
```sh
 dotnet run
```
📌 API **Swagger UI** üzerinden test edilebilir:
🔗 `https://localhost:7021/swagger/index.html`

---

## 📌 **API Kullanımı**
### 🎬 **Movie Endpoints**
| HTTP Metodu | Endpoint | Açıklama |
|------------|---------|----------|
| **GET** | `/api/Movie` | Tüm filmleri getirir |
| **POST** | `/api/Movie` | Yeni bir film ekler |

### 🎮 **Game Endpoints**
| HTTP Metodu | Endpoint | Açıklama |
|------------|---------|----------|
| **GET** | `/api/Game` | Tüm oyunları getirir |
| **POST** | `/api/Game` | Yeni bir oyun ekler |

### **📌 Örnek API İstekleri**
**Yeni bir Film eklemek için:**
```json
POST /api/Movie
{
  "title": "INTERSTELLAR",
  "genre": "SCIENCE FICTION",
  "releaseYear": 2014
}
```

**Yeni bir Oyun eklemek için:**
```json
POST /api/Game
{
  "name": "The Witcher 3",
  "platform": "PC",
  "rating": 9.0
}
```

---

## ❌ **Hata Giderme**
🔹 Eğer `dotnet ef` komutu çalışmıyorsa şu komutu çalıştırın:
```sh
 dotnet tool install --global dotnet-ef
```

🔹 Eğer veriler kaydedilmiyorsa `SaveChanges()` çağrısını kontrol edin:
```csharp
_context.SaveChanges();
```

🔹 **Bağlantı hatası alıyorsanız**, `appsettings.json` içindeki `ConnectionStrings` değerinin doğru olup olmadığını kontrol edin.

