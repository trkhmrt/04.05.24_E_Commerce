import React from 'react'

// export default function (props)  {
//   return (
//     <div>
//       <h1>MERHABA Ben {props.ad},yaşım {props.yas}</h1>
//     </div>
//   )
// }


// const  Mesaj = (props)=>{
//   return (
//     <div>
//       <h1>MERHABA Ben {props.ad},yaşım {props.yas}</h1>
//     </div>
//   )
// }

// export default Mesaj 




const  Mesaj = ({ad="İsim gönderilmedi",yas="Yaş bilgisi boş"})=>{
  return (
    <div>
      <h1>MERHABA Ben {ad},yaşım {yas}</h1>
    </div>
  )
}

export default Mesaj 