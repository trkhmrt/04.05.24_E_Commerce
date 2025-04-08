import './App.css'
import { useState } from 'react'
import { ShowHide } from './ShowHide'
import { Input } from './Input'
import Map from './Map'

function App() {
  
  const [count,setCount] = useState(0)
  const [check,setCheck] = useState(false)
  //  const sayiyi_arttir = () => {
  //   count++
  //   console.log("Count:"+count)
  //  } 

  const sayiyi_arttir_state_ile =()=>{
    setCount(count+1)
   
  }
  const sayiyi_azalt_state_ile =()=>{
    setCount(count-1)
   
  }
  
  


  return (
    <>
    
      <h1>Count:{count}</h1>
      <button onClick={sayiyi_arttir_state_ile}>ARTTIR</button>
      <button onClick={sayiyi_azalt_state_ile}>AZALT</button>
      <button onClick={()=>setCount(count+3)}>3 ARTTIR</button>

      {/*  */}
      <button onClick={()=>setCheck(!check)}>{check == true ? "Gizle" : "Göster"}</button>
      {check && <ShowHide/>} 
      <Input/>
      <Map/>

      

    </>
  )
}

export default App
