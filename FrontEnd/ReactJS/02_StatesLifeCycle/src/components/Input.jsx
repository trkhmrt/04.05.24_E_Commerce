import React from 'react'
import { useState } from 'react'

export const Input = () => {

   const [inputValue,setInputValue] = useState("TARIK")

   const handleChange = (e) => {
        setInputValue(e.target.value)
   } 


  return (
    
    <div style={{width:'500px',height:'400px',backgroundColor:"beige"}}>
    <input type="text" value={inputValue} onChange={handleChange} ></input>
    <p>{inputValue}</p>
    </div>

  )
}
