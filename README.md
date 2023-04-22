# Sohbet Uygulaması V3.0

## FireBase Uygulama Bağımlılıkları
- FireBaseAuthentication.net
- FireBaseDatabase.net
- FireBaseStorage.net

Kaynak https://github.com/step-up-labs

## Config.xml dosyası içeriği
FireBase ile projemiz arasındaki bazı öznel verilerin gizlenmesi gereklidir. Gizlemek içinde Config.xml dosyası ile gizliyoruz
gizlediğimiz veriler şimdilik :  ApiKey , AuthDomain
Örnek olarak:
```
<?xml version="1.0" encoding="utf-8" ?> 
<FireBaseAuth>
	
	<AuthDomain>domain_Kısmı</AuthDomain>
	<ApiKey>apikey_Kısmı</ApiKey>
	
</FireBaseAuth>
```	