Feature: TrendyolTest
	Müşteri olarak trendyol sitesine login olunur ve senaryodaki adımlar gerçekleştirilir.

Background: OpenBrowser
    * Chrome browser ayağa kaldırılır
Scenario: AddAndRemoveTheProductToFavorites
	* 'https://www.trendyol.com/' sitesine gidilir
	* Popup kapatılır
	* Giriş Yap butonuna tıklanır
	* E-posta adresi 'your_email' olarak girilir
	* Şifre 'your_password' olarak girilir
	* Giriş yap butonuna tıklanır
	* Login olduktan sonra çıkan popup kapatılır
	* Arama alanına 'samsung' yazılarak aratılır
	* Rastgele bir ürün seçilerek detay sayfası açılır
	* Detay sayfasında ürün favorilere eklenir
	* Favoriler sayfasına gidilerek ürünün olup olmadığı kontrol edilir
	* Ürün favorilerden çıkarılır
	* Ürünün favorilerde olmadığı doğrulanır