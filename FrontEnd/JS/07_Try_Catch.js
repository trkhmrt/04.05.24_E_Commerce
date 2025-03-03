/* TRYCATH HATA AYIKLAMA */

// try{
//     var sonuc = 10/0
//     console.log(sonuc)
// }catch(error){
//     //console.error("Bir hata oluştu",error.message)
//     console.log("Bir hata oluştu",error.message)
//}





/* Kendi hatalarımızı kendimiz oluşturabiliriz */

// try{
//    throw new Error("Bu bir hata mesajıdır.")
// }catch(error){
//     //console.error("Bir hata oluştu",error.message)
//     console.log("Bir hata oluştu",error.message)
// }finally{
//     console.log("Ben finally'yim her şartta çalışırım.")
// }



// function yasKontrolu(yas){
//     if(yas<18){
//         throw new Error("18 yaşından küçüksünüz")
//     }
//     else{
//         console.log("Ehliyet alabilirsiniz.")
//     }
// }

// try{
//     console.log(yasKontrolu(20))
// }
// catch(error){
//     console.log(error.message)
// }


/* HATA TÜRLERİ */

/* Reference Error */
//Tanımlanmmaış değişkenlerde referans error hatası alınır.
// try{
//   console.log(isim)
// }catch(error){
//   console.log(error.message)
// }


/* TypeError */

// try{
//     var num = null
//     console.log(num.toUpperCase())
// }catch(error){
//     console.log(error.message)
// }

/* RangeError */

// try{
//     var dizi = new Array(-1)
//     console.log(dizi.length)
// }catch(error){
//     console.log("Dikkatli ol "+error.message)
// }