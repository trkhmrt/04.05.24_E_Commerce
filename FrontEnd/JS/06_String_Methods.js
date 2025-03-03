/* 
STRING METOTLAR 


*/

/* length  String verinin karakter sayısını verir.*/

// var isim = "Tarık"
// console.log(isim.length)

// /* charAt(index)   belirtilen indexteki karakteri  döndürür.  */

// console.log(isim.charAt(1))

// /* charCodeAt(index) belirtilen indexteki karakterin Unicode(ASCII) değerini döndürür */

// console.log(isim.charCodeAt(1))

// /* at(index)  */

// console.log(isim.at(-5))


/* UpperCase & LowerCase */

// console.log(isim.toUpperCase())
// console.log(isim.toLowerCase())

/* Trim() -> Sağ ve Sol boşlukları temizler */
// var isim = "Tarık     "
// var soyisim = " Hamarat   "
// var yas = "20"

// var isimSoyisim = isim.trimEnd()+soyisim.trimStart()+yas

// console.log(isimSoyisim)


/* Repeat stringi istenilen kez tekrar eder. */

// var mesaj = "Merhaba "
// console.log(mesaj.repeat(3))

/* replace () bir string ifade içindeki belirli bir ifadeyi değiştirir */
// var mesaj = "Dersimize hoşgeldiniz"
// console.log(mesaj.replace("hoşgeldiniz","Hoşgeldiniz arkadaşlar!!!"))



/* STRING ARAMA METOTLARI */

/* INDEXOF() */
var text = "Merhaba Dünya"

// console.log(text.indexOf("a"))

// console.log(text.indexOf("Dünya")) //Kelime bazlı arama yapıldığında kelimenin ilk harfinin başladığı noktanın indeksini bize döndürür.

// console.log(text.indexOf("t")) //Olmayan bir karakterin indeksini arandığında -1 cevabını döndürür.Bu karakter yok anlamına gelir.


/* lastindexof */

//console.log(text.lastIndexOf("Dünya"))

/* Includes() */

// console.log(text.includes("Tar")) //Karakter bazlı yada kelime bazlı arama yapılabilir.Case Sensitive'dir. 

/* StartsWith & EndsWith */

//console.log(text.startsWith("Merh"))
//console.log(text.endsWith("Merhaba Dünya"))


/* KESME METOTLARI */

/* SLICE */

// var text = "Javascript"
// var version = 15

// console.log(text.slice(0,4))
// console.log(text.slice(-6))


/* Substring */

//console.log(text.substring(0,4))


/* STRING ŞABLONLARI */

//console.log(`${text} version:${version}`)
