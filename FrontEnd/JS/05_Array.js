/*
ARRAY

*/


// const isimler = ["Tarık","Engin","Ali","Aleyna","Nursena","Serdar"]
// console.log(isimler)
/*
Push() -> Diziye eleman eklemek için kullanılır
*/

// isimler.push("Mehmet")
// isimler.push("Bilinmeyen Kişi")
// console.log(isimler)

/*

Pop()-> Diziden en sonuncu elemanı çıkarmak için kullanılır

*/


// isimler.pop()

// console.log(isimler)

/*
Shift()-> ilk elemanı siler

*/

// isimler.shift()
// console.log(isimler)

/*

UnShift()-> Dizinin başına bir veya daha fazla eleman ekler
*/

// isimler.unshift("1.Yeni Kişi","2.Yeni Kişi")
// console.log(isimler)


/*

concat()-> İki veya daha fazla diziyi birleştirir


*/


// const sayilar1 = [10,80,20]
// const sayilar2 = [11,50,91]

// const sayilar3 = sayilar1.concat(sayilar2)

// console.log(sayilar3)


/*

slice()

Dizinin belirli bir kısmını alır ve yeni bir dizi oluşturur.
*/

// const sayilar1 = [10,80,20,60,70,100,150]

// const bolunmusDizi = sayilar1.slice(1,3)

// console.log(bolunmusDizi)


/*
foreach()

*/

// var sayilar1 = [10,80,20,60,70,100,150]
// // sayilar1.forEach(sayi=>console.log("Sayi:",sayi))


// // const sayilar1 = [10,80,20,60,70,100,150]
// // console.log(sayilar1.indexOf(20))

// //console.log("Verilen eleman içeriliyor mu ?",sayilar1.includes(80))


// sayilar1.sort((a,b)=>a-b)

// console.log(sayilar1)


//var isimler1 = ["Tarık","Berke","Engin","Muhammet","Aleyna"]

// isimler1.sort()

// console.log(isimler1)

// isimler1.reverse()

// console.log(isimler1)

// console.log("Bulunan isim"+isimler1.find(isim=>isim=="Tarık"))



/* Every() */
// var yaslar = [20,100,80,10]

// if(yaslar.every(yas=>yas>=18)){
//     console.log("Herkes Ehliyet alabilir")
// }else{
//     console.log("Bazı kullanıcılar ehliyet alamaz.")
// }

