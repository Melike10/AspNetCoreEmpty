

var builder = WebApplication.CreateBuilder(args);
// 1 Controllerlar ve geri d�n�lecek servisi ekliyorum.
// https://medium.com/@connektteacher/how-to-addcontroller-vs-addmvc-vs-addcontrollerswithviews-vs-addrazorpages-84adc7501020
//https://www.tektutorialshub.com/asp-net-core/addcontroller-vs-addmvc-vs-addcontrollerswithviews-vs-addrazorpages/
// YUkar�daki kaynaklardan g�rece�imiz �zere AddControllerWithViews ; razor pages deste�i d���nda her t�rl� deste�i sa�lar.


// Controller ve View'lar�n kullan�laca��n� belirtiyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Static dosyalar� (CSS, JS, img) kullanmay� sa�lar
app.UseStaticFiles();

// HTTPS y�nlendirmesi: HTTP'den gelen istekler HTTPS'ye y�nlendirilir
app.UseHttpsRedirection();

// Routing mekanizmas�n� aktif hale getirir
app.UseRouting();

// Authorization'� aktif eder
app.UseAuthorization();

// Default olarak a��lacak olan sayfa ve y�nlendirme yap�land�rmas�
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();


/*
 * MVC mimarisi �u �ekilde �al���r: Taray�c�dan View sayfas�na istek yap�ld���nda, View katman� Controller�a gider. Controller iste�i ger�ekle�tirmek �zere Model katman�na gider. Daha sonra Model'den al�nan veriler, View�a g�nderilerek istenilen verilerin g�r�nt�lenmesi sa�lan�r. En basit anlamda MVC, bir uygulamay� �� alana ay�rma �abas�d�r. 
 * 
 Model: MVC mimarisi i�inde verilerin tutuldu�u, veri taban�na eri�imin sa�land���, t�m data i�lemlerinin ger�ekle�ti�i yer model katman�d�r. Veriler burada i�lenir ve sorgular� burada yap�l�r. Di�er yandan somut nesnelerin bilgisayar ortamda anlamla�t�r�lmas� yani modellenmesi anlam�na gelir. Bunlar veri, dosya veya basit nesneler de olabilir. �rne�in bir m��teri web sitesine kay�t oldu�unda onunla ilgili isim, ya�, cinsiyet ve konum gibi bilgiler modelde tutulur. 
 *

View: View, Model katman�n�n g�rselle�tirilmi�, kullan�c�n�n uygulamay� g�rd��� halidir. Kullan�c�n�n g�rebilece�i her �ey View katman�ndad�r.  Metin kutular�, men�ler gibi t�m UI bile�enlerini i�erir. Html, Css, Javascript gibi aray�z teknolojilerinden yararlan�r. 

WwwRoot : Css, Javascript dosyalar�, resimler gibi, browser �n ula�mas� gereken t�m dosyalar�m� koyaca��m�z yerdir.
 
*
Controller: Model ve View katmanlar� aras�ndaki i�lemleri ger�ekle�tirir. Yani View katman�ndan ald��� veri taban� i�lemleri ve hesaplamalar gibi t�m i�lemleri Model katman�na ta��r. Bir nevi arada k�pr� g�revi g�r�r. 

 
 */

/*
 

1. builder.Build()
Bu metot, ASP.NET Core uygulamas�n�n pipeline��n� (veri ak���n�) olu�turur ve gerekli servislerin haz�r hale getirilmesini sa�lar.

ASP.NET Core uygulamalar�nda WebApplicationBuilder s�n�f� ile bir yap�land�r�c� (builder) olu�turulur. Bu yap�land�r�c�, �e�itli servislerin (�rne�in, logging, configuration, dependency injection) eklenmesini ve ayarlanmas�n� sa�lar.

builder.Build() metodu �a�r�ld���nda, yap�land�r�c�da tan�mlanan servisler ve ayarlar kullan�larak bir WebApplication nesnesi olu�turulur. Bu a�amada uygulama �al��t�r�labilir hale gelir, ancak hen�z ba�lat�lmam��t�r.

Yani, bu metodun amac�, uygulaman�n �al��t�r�lmaya haz�r olmas�n� sa�lamak i�in gerekli t�m bile�enleri derlemektir.

2. app.Run()
Bu metot, uygulaman�n ba�lat�lmas� ve sunucunun gelen HTTP isteklerini dinlemeye ba�lamas� i�in kullan�l�r.

app.Run() metodu �a�r�ld���nda, uygulama art�k HTTP isteklerini kar��layabilir hale gelir. Bu metodun �a�r�lmas�yla uygulama, belirtilen pipeline�� kullanarak gelen t�m istekleri i�ler.

K�saca app.Run(), uygulaman�n ana d�ng�s�n� ba�lat�r ve sunucunun �al��mas�na olanak tan�r. Genellikle uygulaman�n sonunda �a�r�l�r ve uygulama �al��maya devam etti�i s�rece bu metot kesintisiz olarak �al���r.
app.Run() ile sunucu ba�lat�l�r ve uygulama istekleri dinlemeye ba�lar.
 */
