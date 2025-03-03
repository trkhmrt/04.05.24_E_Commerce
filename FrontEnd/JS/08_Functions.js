/* Functions */


/* 
js de method tanımlaması

function metot_adi(){

}

*/


// function sayHello(name){
//     console.log(name+" Hoşgeldiniz!!!")
// }


// sayHello("Tarık")



/* Geri Değer döndüren metotlarda tip belirtilmez.Ne verilirse onu geri döndürür. */
// function geriMesajDondur(){
//     return "Merhaba Tarık"
// }


// var mesaj = geriMesajDondur()

// console.log(mesaj)



/* CALLBACK FUNCTION */


function islem(callback){
    console.log("islem metoduna ait islemler.")
    callback()
}


function ikinciMetot(){
    console.log("İkinci metoda ait işlemler.")
}


islem(ikinciMetot)





//PROMT İLE KULLANICIDAN VERİ OKUMA
// var sayi = prompt("Selam değer giriniz")
// console.log(sayi)