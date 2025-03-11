
import  Hosgeldin  from './components/Hosgeldin'
import Sepet from './components/Sepet' 
import './App.css'
import Profil from './components/Profil'


function App() {

  const urun1="Ayakkabı"
  const urun2="Playstation"
  const urun3="Gömlek"


  const isim = "Muhammed"
  const mail = "muhammed@gmail.com"
  const zaman = new Date().toLocaleDateString()
  const yas = "30"

  return (
    <>
      <Profil name={isim} email={mail} time={zaman} ></Profil>
      <Sepet p1={urun1} p2={urun2} p3={urun3}></Sepet>
      <Hosgeldin ad={isim} yas={yas} />
    </>
  )

}


export default App
