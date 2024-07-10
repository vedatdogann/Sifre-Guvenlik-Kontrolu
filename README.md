# Şifre Güvenlik Kontrolü

Bu proje, girilen şifrenin güvenlik seviyesini kontrol eden bir C# programıdır. Şifre, belirli kriterlere göre değerlendirilir ve bir güvenlik puanı atanır.

## Kullanım

Programı çalıştırmak için aşağıdaki adımları izleyin:

1. **Proje dosyalarını klonlayın:**

2. **Proje dizinine gidin ve projeyi çalıştırın:**

3. **Programın kullanıcı arayüzü:**

    Program çalıştırıldığında, kullanıcıdan bir şifre girmesi istenir ve şifrenin güvenlik seviyesi analiz edilir. Sonuçlar ekrana yazdırılır.

    ```plaintext
    Şifre Güvenlik Kontrolü
    Lütfen Şifrenizi Girin:
    Girilen Şifre: [şifre]
    Toplam Karakter Sayısı: [toplam karakter sayısı]
    Toplam Büyük Harf Sayısı: [büyük harf sayısı]
    Toplam Küçük Harf Sayısı: [küçük harf sayısı]
    Toplam Rakam Sayısı: [rakam sayısı]
    Toplam Özel Karakter Sayısı: [özel karakter sayısı]
    [Mesaj]
    ```

## Şifre Değerlendirme Kriterleri

Şifre, aşağıdaki kriterlere göre değerlendirilmektedir:

- **Boşluk Kontrolü:** Şifre içinde boşluk karakteri bulunmamalıdır.
- **Uzunluk Kontrolü:** Şifre en az 9 karakter uzunluğunda olmalıdır.
- **Büyük Harf:** Şifre en az bir büyük harf içermelidir.
- **Küçük Harf:** Şifre en az bir küçük harf içermelidir.
- **Rakam:** Şifre en az bir rakam içermelidir.
- **Özel Karakter:** Şifre en az bir özel karakter içermelidir.

## Güvenlik Puanı

Şifre, yukarıdaki kriterlere göre değerlendirilir ve toplam güvenlik puanı atanır:

- Büyük harf sayısı, küçük harf sayısı, rakam sayısı ve özel karakter sayısına göre puan verilir.
- Toplam puan 100 üzerinden hesaplanır.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

