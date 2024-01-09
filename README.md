# Proje Adı

Bu proje, Engin Demiroğ'un yazılım geliştirme kampının sonucunda C# + Angular ile n katmanlı mimari kullanılarak backend kısmı yazılmıştır. Proje, solid prensiplerine, CRUD operasyonlarına ve clean code'a özen gösterilerek, local bir veritabanı kullanılarak bir e-ticaret sitesi oluşturmayı amaçlamaktadır.

## Proje Yapısı ve Katmanlar

Proje, aşağıdaki ana katmanlardan oluşmaktadır:

- **Core:** Temel yapıları, genel araçları ve çeşitli yardımcı sınıfları içerir.
- **DataAccess:** Veritabanı işlemleri için data access katmanını içerir. Entity Framework kullanılmıştır.
- **Business:** İş kuralları, servisler ve iş mantığı içerir.
- **Entities:** Veritabanı tablolarını temsil eden entity sınıflarını içerir.
- **WebAPI:** Kullanıcı arayüzü olmayan, sadece HTTP API sağlayan katmanı içerir.

## Kullanılan Teknolojiler

Proje geliştirilirken aşağıdaki teknolojiler kullanılmıştır:

- **Autofac:** Bağımlılık enjeksiyonu için kullanılmıştır.
- **FluentValidation:** Giriş doğrulama kuralları için kullanılmıştır.
- **JWT Authentication:** JSON Web Token tabanlı kimlik doğrulama sistemi.
- **Entity Framework Core:** Hafif ve esnek bir ORM sistemi olarak kullanılmıştır.
- **Swagger:** API dokümantasyonunu oluşturmak için kullanılmıştır.
- **Aspect-Oriented Programming (AOP):** İş mantığına yönelik cross-cutting concerns'leri ele almak için kullanılan AOP prensiplerini içerir.

## Kurulum ve Çalıştırma

### Geliştirme Ortamını Hazırlama

Projeyi açmak için Visual Studio veya başka bir IDE kullanabilirsiniz.

### Projeyi Çalıştırma

Projeyi çalıştırarak geliştirme sunucusunu başlatın.

### API Endpoint'lerini Keşfetme

Projeyi çalıştırdıktan sonra, API endpoint'lerini keşfetmek için tarayıcınızı kullanabilir veya Swagger API Documentation sayfasını ziyaret edebilirsiniz.

## API Kullanımı

Proje, kullanıcılarının aşağıdaki işlemleri gerçekleştirmesine olanak tanır:

- **Ürün listesini görüntüleme**
- **Kategoriye göre ürün listesini görüntüleme**
- ...

API kullanımı ile ilgili daha fazla bilgiye API Dokümantasyonu sayfasından ulaşabilirsiniz.
