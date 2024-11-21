# 🚀 STOK TAKİP OTOMASYONU

Bu proje, C#, ADO.NET ve MSSQL teknolojileri ile geliştirilmiş bir stok takip otomasyonudur. Uygulama, ürün, müşteri, satış ve kategori verilerinin yönetilmesini sağlar. Kullanıcılar, ürün ekleme, güncelleme, satış işlemleri ve stok durumunu takip edebilir.

💸 **Satış Sayfası**
---

• Satış sayfası, kullanıcıların satış işlemleri gerçekleştirmesine olanak tanıyan merkezi bir modüldür. Bu sayfa, müşteri ve ürün işlemleriyle birlikte, satış işlemlerinin yönetilmesini sağlar.

• Satış yaparken, mevcut müşteri listesi üzerinden seçilecek müşteri kolayca bulunabilir. Müşteri seçildikten sonra, ilgili satış işlemi bu müşteriye atanır.

• Satış sayfasında, yeni ürün eklemek mümkündür. Barkod numarasına göre  ürün adı, miktarı, satış fiyatı ve toplam fiyatı hesaplanıp veritabanına eklenebilir.

• Tüm yapılan satışların toplam fiyatı, genel toplam olarak hesaplanır ve ekranda görüntülenir.

• Yanlış girilen bir satış işlemi sil buton aracılığıyla sistemden silinebilir.

• Henüz gerçekleşmemiş bir satış işlemi, satış iptal butonu ile iptal edilebilir. Bu işlem kullanıcıya satışın tamamlanmadan iptal edilmesine olanak tanır.

• Tüm bilgilerin doğruluğundan emin olduktan sonra, "Satış Yap" butonuna tıklanarak işlem tamamlanır ve satış kaydedilir.

👤 **Müşteri Ekleme**
---

• Müşteri Ekleme sayfası, yeni bir müşteri kaydı oluşturmak için kullanılan bir modüldür. Kullanıcılar, bu sayfada gerekli müşteri bilgilerini girerek veritabanına yeni müşteri kaydı ekleyebilirler.

👥 **Müşteri Listeleme**
---

• Sisteme kaydedilen tüm müşterilerin bilgileri düzenli bir şekilde listelenir. Kullanıcılar, bu liste üzerinden her bir müşteriye ait bilgilere ulaşabilir.

• Liste üzerinde her bir müşterinin bilgileri, "Güncelle" butonu ile düzenlenebilir.

• Kullanıcı, yanlış veya gereksiz olan müşteri kayıtlarını "Sil" butonunu kullanarak sistemden silebilir. 

• Kullanıcı, listede bulunan müşteriler arasında hızlıca arama yapabilmek için TC kimlik numarasını kullanabilir. Bu sayede belirli bir müşteriye ait bilgilere hızlıca ulaşmak mümkündür.

📦 **Ürün Ekleme Sayfası**
---

• Ürün Ekleme sayfası, iki ana işlevi içerir: Yeni Ürün Ekleme ve Var Olan Ürün Ekleme

• Yeni ürün eklerken, kullanıcıdan barkod numarası, kategori seçimi, marka seçimi, ürün adı, miktar, alış fiyatı ve satış fiyatı alınır.

• Var ürün eklerken, barkod numarasına göre ürün bilgileri gelerek eklenebilir.

📝 **Ürün Listeleme**
---

• Ürün Listeleme sayfası, sisteme kaydedilen tüm ürünlerin görüntülenmesini sağlar. 

• Listelenen ürünlerden birinin bilgileri "Güncelle" butonu ile düzenlenebilir.

• Kullanıcı, listeden bir ürünü "Sil" butonunu kullanarak sistemden silebilir.

•  Seçilen kategoriye ait ürünlerin marka bilgileri güncellenebilir.

• Kullanıcı, her bir ürünün barkod numarasını girerek hızlı bir şekilde arama yapabilir ve ilgili ürüne ulaşabilir.

📋 **Satış Listeleme**
---

• Satış yapıldığında, bu satışlar Satış Listeleme sayfasında otomatik olarak gösterilir.

📂 **Kategori Sayfası**
---

• Kategori Sayfası, ürünlerin kategori bazında düzenlenmesini sağlar. Bu sayfa, kullanıcıların ürünleri belirli kategoriler altında gruplayabilmesine olanak tanır. 

🌟 **Marka Sayfası**
---

• Marka Sayfası, belirli bir kategoriye göre markaların eklenmesini sağlar.

📍 **Uygulamaya Ait Bazı Görseller**
---

**Satış Sayfası**

![Ekran Alıntısı](https://github.com/user-attachments/assets/5f8aec47-f732-45e1-ad1a-5c706f9e8f4c)

**Müşteri Ekleme**

![Ekran Alıntısı 1](https://github.com/user-attachments/assets/1ec54dfc-faf0-4d01-ad5e-49704bf7ae97)

**Müşteri Listeleme**

![Ekran Alıntısı 2](https://github.com/user-attachments/assets/1b3ceb40-d4ff-4744-9dfa-f9286b79d61e)

**Ürün Ekleme Sayfası**

![Ekran Alıntısı 3](https://github.com/user-attachments/assets/14bcca15-e99c-41ff-a504-e0a16e42855f)

**Ürün Listeleme Sayfası**

![Ekran Alıntısı 4](https://github.com/user-attachments/assets/2289ea69-ba6b-4ebe-b670-5941fba15118)

**Satış Listeleme**

![Ekran Alıntısı 5](https://github.com/user-attachments/assets/787e1240-15de-49ee-a550-5a4b67a53acf)

**Kategori Sayfası**

![Ekran Alıntısı 6](https://github.com/user-attachments/assets/23dcd64c-b109-4ed5-8746-66522db1ec61)

**Marka Sayfası**

![Ekran Alıntısı 7](https://github.com/user-attachments/assets/3e339fd0-ec9d-42f2-a6f8-03761f1daca0)
