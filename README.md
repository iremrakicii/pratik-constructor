# BabyClass C# Projesi

Bu projede, bir `BabyClass` sınıfı oluşturularak, bebeklerin isim ve soyisim bilgilerini tutan bir yapı tasarlanmıştır. Bebek nesneleri hem parametreli hem de parametresiz olarak oluşturulabilir ve doğum zamanı, bebek nesnesi oluşturulduğu anda otomatik olarak atanır.

## Proje İçeriği

### BabyClass Sınıfı

`BabyClass`, bir bebeğin adını, soyadını ve doğum tarihini temsil eden bir sınıftır. İki farklı yapıcı (constructor) sunar:
1. Parametresiz yapıcı: Bebek nesnesi oluşturulduğunda doğum tarihini alır.
2. Parametreli yapıcı: Bebek ismi ve soyismi alır ve doğum tarihi atanır.

#### Özellikler (Properties)
- `AddName`: Bebeğin ismini saklar ve alır.
- `AddSurname`: Bebeğin soyadını saklar ve alır.
- `AddBirthDate`: Bebeğin doğum tarihini saklar ve alır (bu, bebek nesnesi oluşturulduğu anı temsil eder).

### Kullanım

Program, iki farklı yöntemle `BabyClass` nesnesi oluşturarak bebek bilgilerini ekranda yazdırır.

- **Parametreli Yapıcı ile Kullanım:**
  ```csharp
  BabyClass bebek = new BabyClass("Ayşe", "Öztürk");

- **Parametresiz Yapıcı ile Kullanım:** 
csharp

BabyClass bebek1 = new BabyClass();
bebek1.AddName = "Ahmet";
bebek1.AddSurname = "Ertürk";

## Kullandığım Araçlar ve Teknolojiler
Programlama Dili: C# IDE: Visual Studio
