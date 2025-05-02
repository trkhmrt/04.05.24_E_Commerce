import React, {useEffect, useState} from 'react';
import axios from "axios";
import {Link} from "react-router-dom";

const Products = () => {

    const [customerInfo, setCustomerInfo] = useState(JSON.parse(localStorage.getItem("customerInfo")))
    const [products, setProducts] = useState([]);
    const [basketId,setBasketId] = useState(customerInfo.customerActiveBasketId)


    useEffect(() => {
        getProducts()



    }, []);

    const getProducts = async () => {
        try {
            const response = await axios.get("http://localhost:5107/Product/getProducts")
            setProducts(response.data);
            console.log(response.data)
        } catch (error) {
            console.log(error.response.data)
        }
    }

    const handleAddProductToBasket = async (productId) => {
        const response = await axios.get(`http://localhost:5107/Basket/addProductToBasket/${basketId}/${productId}`)
    }

    return (
        <div className="max-w-6xl mx-auto grid grid-cols-1 md:grid-cols-4 bg-red-500 p-4 gap-6">
            {/*Kategoriler*/}
            <div className="col-span-1 bg-white rounded-xl p-4 shadow">
            <h1 className="text-xl">Kategoriler</h1>
                <div>
                    <button className="w-full text-left text-gray-800">Alt Giyim</button>
                    <button className="w-full text-left text-gray-800">Alt Giyim</button>

                </div>
            </div>

            {/*Ürünler*/}
            <div className="col-span-1 md:col-span-3 bg-yellow-400 rounded-xl bg-white rounded-xl p-4 shadow">
                <h2 className="text-xl font-bold mb-4">Ürünler</h2>
                <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-4">
                    {products.map((product, index) => (
                        <div key={index} className="border rounded p-4 hover:shadow ">
                            <h3 className="text-lg font-semibold">{product.productName}</h3>
                            <p className="text-sm text-gray-500 mt-1">{product.productDescription}</p>
                            <p className="text-sm text-gray-500 mt-1">{product.productPrice}</p>
                            <button onClick={()=>handleAddProductToBasket(product.productId)}>Sepete Ekle</button>
                            <a><Link to={`/productDetail/${product.productId}`}>
                                Ürünü İncele
                            </Link></a>
                        </div>
                    ))}
                </div>
            </div>
        </div>
    );
};

export default Products;