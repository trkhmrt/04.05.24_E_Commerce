import React, {useEffect, useState} from 'react';
import axios from 'axios'
import {Link} from "react-router-dom";
const Basket = () => {

    const [basketDetail, setBasketDetail] = useState([]);

    useEffect(() => {

        const getBasketByBasketId = async () => {
            const basketResponse = await axios.get("http://localhost:5107/Basket/getBasketDetailsByCustomerId/43125")
            setBasketDetail(basketResponse.data)
            console.log(basketResponse)
        }

        getBasketByBasketId()

    },[])


    const handleDeleteProductToBasket = async (basketDetailId) => {
        const response = await axios.post("http://localhost:5107/Basket/deleteProductToBasketByProductId",
            {
            "basketId": 9002,
            "customerId": 43125,
            "basketDetailId": basketDetailId
        }
        )

        const newBasketDetail = basketDetail.filter((bd) => bd.basketDetailId !== basketDetailId)
        setBasketDetail(newBasketDetail)

        console.log(response)

    }



    return (
        <div>
            <h1>BASKET SAYFASI</h1>
            {basketDetail.map((item) => (
                <div key={item.basketDetailId}>
                    <p>Ürün Adı:{item.productName}</p>
                    <p>ID:{item.productId}</p>
                    <p>Fiyat:{item.productPrice}₺</p>
                    <p>Adet:{item.productQuantity}</p>
                    <button onClick={()=>handleDeleteProductToBasket(item.basketDetailId)}>SİL</button>
                </div>
            ))}


        </div>
    );
};

export default Basket;