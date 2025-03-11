/*
Objects

Javascriptte objeler anahtar-değer(Key-Value) çiftlerinden oluşan veri yapılarıdır.

*/


var ogrenci = {

    isim:"Tarık",
    yas:28,
    kimlikNo:123456789

}
//1.YÖNTEM
// console.log(ogrenci.isim)
// console.log(ogrenci.yas)
// console.log(ogrenci.kimlikNo)


//2.YÖNTEM
// console.log(ogrenci["isim"])
// console.log(ogrenci["yas"])
// console.log(ogrenci["kimlikNo"])



// console.log(ogrenci)

// //Var olan bir anahtarın değerini güncelleme
// ogrenci.isim = "Muhammed"

// console.log(ogrenci)

// //Nesneye yeni bir özellik ekleme
// ogrenci.ortalama = 95

// console.log(ogrenci)




//NESNE İÇİNDE NESNE

// var araba = {
//     marka:"BMW",
//     model:"1997",
//     renk:"Sarı",
//     ureticiFirma:{
//         firmaAdi:"Borusan",
//         uretimYeri:"İstanbul"
//     }
// }


// console.log(araba.marka)
// console.log(`${araba.ureticiFirma.firmaAdi} ${araba.ureticiFirma.uretimYeri}`)
// console.log(araba["ureticiFirma"]["firmaAdi"])




//NESNE İÇERİSİNDE METOT TANIMLAMA

// var urun = {
//     marka:"Eti",
//     tür:"Çikolata",
//     fiyat:60,
//     bilgiler: function(message=""){
//         console.log(`${this.marka} ${this.tür}'nın fiyatı ${this.fiyat} Tl'dir.\n${message}!!`)
//     }
// }


// urun.bilgiler()


// urun.fiyat = 100

// urun.bilgiler()

// urun["fiyat"] = 120

// urun.bilgiler()

// urun.bilgiler("Bu fiyatı kaçırmayın")
