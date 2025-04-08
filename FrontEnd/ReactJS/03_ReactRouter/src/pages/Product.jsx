import React from 'react';
import {useParams} from "react-router-dom";

const Product = () => {
    const urunDetaylar = [
        {id:1,"urunad":"ayakkabı","fiyat":100,"kategori":"Giyim","AltKategori":"Alt giyim","Renk":"Siyah"},
        {id:2,"urunad":"gömlek","fiyat":200,"kategori":"Giyim","AltKategori":"Üst giyim","Renk":"Mavi"},
    ]

    const {id} = useParams();

    const productDetail = urunDetaylar.find((urun)=>urun.id == id)

    return (
        <div style={{width: '600px', height: '500px', backgroundColor: 'beige'}}>
            <h1>Urun ID:{productDetail.id}</h1>
            <p>Fiyat:{productDetail.urunad}</p>
            <p>Fiyat:{productDetail.fiyat}</p>
            <p>Kategori:{productDetail.kategori}</p>
            <p>Altkategori:{productDetail.AltKategori}</p>
            <p>Renk:{productDetail.Renk}</p>
        </div>
    );
};

export default Product;