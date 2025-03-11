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


// function islem(callback){
//     console.log("islem metoduna ait islemler.")
//     callback()
// }


// function ikinciMetot(){
//     console.log("İkinci metoda ait işlemler.")
// }


//islem(ikinciMetot)



/* 

ARROW FUNCTION 
ES6 ile gelen bir özelliktir.

*/

// const MesajYazdir = () =>{
//     return "Merhaba Dünya"
// }


// console.log(MesajYazdir())




// const MesajYazdir = (mesaj) =>{
//     return mesaj
// }


// console.log(MesajYazdir("Selamlar gençler.Hayırlı iftarlar"))


// const toplama = (a,b) => a + b 


// console.log(toplama(20,30))

// const mesaj = () => console.log("Parametresiz versiyon")

// mesaj()


// const mesaj2 = () => {return console.log("Parametresiz versiyon 2")}

// mesaj2()

//PROMT İLE KULLANICIDAN VERİ OKUMA
// var sayi = prompt("Selam değer giriniz")
// console.log(sayi)