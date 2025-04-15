import React, {useEffect, useState} from 'react';
import axios from "axios";
import {Link} from "react-router-dom";

const Products = () => {

    const [products, setProducts] = useState([]);

    useEffect(() => {
        getProducts()

    }, []);

    const getProducts = async ()=>{
        try{
            const response = await axios.get("http://localhost:5107/Product/getProducts")
            setProducts(response.data);
            console.log(response.data)
        }
        catch(error){
            console.log(error.response.data)
        }
    }

    return (
        <div>
            {products.map((product, index) => (
                <div key={index}>
                    <h1>{product.productName}</h1>
                    <p>Fiyat:{product.productPrice}</p>
                    <p>Ürün Açıklaması:{product.productDescription}</p>
                    <p>Resim Yolu:{product.Image}</p>
                    <p>ID:{product.productId}</p>
                    <button>Sepet Ekle</button>
                    <a><Link to={`/productDetail/${product.productId}`}>
                        Ürünü İncele
                    </Link></a>
                </div>
            ))}
        </div>
    );
};

export default Products;