# Dicitoy-Games-Staj-projesi
Filtrelemede kullanılacak masa özellikleri Bahis Aralığı ve Masa Tipi’ dir.
Bahis Aralığı; 200$ - 5.000$ arası olabilir.
Masa Tipi; Hızlı, Teke Tek ve/veya Rövanşlı olarak seçilebilmektedir. Oyuncu masa tipi
özelliklerinden her birini ayrı veya aynı anda seçebilir ya da hiçbirini seçmeyebilir. Örneğin; bir
masa sadece Rövanş Masa tipinde olabilir veya hem Hızlı hem de Rövanşlı olabilir. Oyuncu bu
filtrede Evet olarak işaretlemediği masa tipteki masaları görüntülememelidir.
Oyuncuyu eşlemek için kullanacağınız masa listesi List<Object> tipinde farklı masa özelliklerini
içerecek şekilde sizin tarafınızdan hazırlanmalıdır. Hazırlayacağınız uygulama kullanıcıdan masa
özellikleriyle ilgili input aldığında (Örneğin; Bahis:1 .000$, Hızlı:Evet, Teke Tek:Hayır, Rövanş:Evet)
filtreleme fonksiyonunuz masa listesinden istenilen özelliklere uygun masaları çıktı olarak
vermelidir.
Masa özelliklerini görsel olarak kodlama zorunluluğu yoktur. İstenilen programlama dili tercih
edilebilir. Uygun masaları bulurken Linq gibi yardımcı kütüphaneler kullanılmamalıdır.
Bonus; Masa Tipi ’ni tek bir Integer değer kullanarak ifade edebilir misiniz?
İpucu: Bitflag nedir?






The required specifications for filtering are the Bet Range and Table Type. The Bet Range can be between $200 and $5,000. The Table Type can be selected as Fast, One-on-One, and/or Rematch. The player can choose each of these table types separately or together, or choose none of them. For example, a table can only be of the Rematch Table type, or it can be both Fast and Rematch. The player should not be able to view tables of table types that are not marked as "Yes" in this filter. The list of tables that you will use to match the player should be prepared by you as a List type including different table specifications. When your application receives input from the user regarding table specifications (e.g., Bet: $1,000, Fast: Yes, One-on-One: No, Rematch: Yes), your filtering function should output tables that match the desired specifications from the table list. There is no requirement to visually code the table specifications. The preferred programming language can be used. When finding suitable tables, helper libraries such as Linq should not be used. Bonus: Can you express the Table Type using a single integer value? Hint: What is a Bitflag?
