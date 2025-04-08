import React from 'react'

const Profil = ({name,email,time}) => {
  return (
    <div style={{height:"300px",width:"300px",backgroundColor:"aqua"}}>
        <h1>Hoşgeldin {name}</h1>
        <p>{email}</p>
        <p>Son giriş saati:{time}</p>

    </div>
  )
}

export default Profil