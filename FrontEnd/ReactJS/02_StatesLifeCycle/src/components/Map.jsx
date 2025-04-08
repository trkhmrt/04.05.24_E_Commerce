import React from 'react'

const Map = () => {

    const ogrenciler = [
        {id:1,isim:"Ali"},
        {id:2,isim:"Tarık"},
        {id:3,isim:"Aleyna"},
        {id:4,isim:"Engin"},
        {id:5,isim:"Nursena"}
    ]

  return (
    <div>
        <ul>
            {ogrenciler.map(ogrenci=>(
                <li key={ogrenci.id}>{ogrenci.isim}</li>
            ))}
        </ul>
    </div>
  )
}

export default Map
