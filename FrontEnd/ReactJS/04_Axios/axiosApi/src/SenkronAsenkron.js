function senkronFonskyion(){
    console.log("1-Senkron Fonkiyon")
}

async function asenkronFonskyion(){
    console.log("2-Asenkron Fonskiyon çalıştı")
    await new Promise(resolve => setTimeout(resolve, 4000));
    console.log("3-Asenkron Fonskiyon bitti")
}
console.log("0-Kodlar çalışmaya başladı")
senkronFonskyion()
asenkronFonskyion()
console.log("4-Kod bitti")