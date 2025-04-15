import React, {useEffect, useState} from 'react';
import {useParams} from "react-router-dom";
import axios from "axios";

const ProductDetail = () => {
    const {productId} =  useParams();
    const [product, setProduct] = useState({});

    useEffect(() => {
        getProductDetails()
    },[])

    const getProductDetails = async () => {
        try{
            const response = await axios.get(`http://localhost:5107/Product/getProductById/${productId}`);
            setProduct(response.data);
            console.log(response.data)
        }
        catch(error){
            console.log(error.response.data)
        }
    }
    return (
        <div>
            <h1>{product.productName}</h1>
            <p>Fiyat:{product.productPrice}</p>
            <p>Ürün Açıklaması:{product.productDescription}</p>
            <p>Resim Yolu:{product.Image}</p>
            <p>ID:{product.productId}</p>
            <button>Sepet Ekle</button>
        </div>
    );
};

export default ProductDetail;