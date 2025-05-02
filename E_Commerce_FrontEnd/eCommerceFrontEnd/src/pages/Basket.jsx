import React, {useEffect, useState} from 'react';
import axios from 'axios'
import {Link} from "react-router-dom";
const Basket = () => {
    const [customerInfo, setCustomerInfo] = useState(JSON.parse(localStorage.getItem("customerInfo")))
    const [basketDetail, setBasketDetail] = useState([]);
    const [basketId,setBasketId] = useState(customerInfo.customerActiveBasketId)

    useEffect(() => {

        const getBasketByBasketId = async () => {
            const basketResponse = await axios.get(`http://localhost:5107/Basket/getBasketDetailsByBasketId/${basketId}`)
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
        <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8 bg-red-500">
            <h1 className="text-3xl font-bold ">SEPET</h1>
            <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3  gap-6">
                {/*ÜRÜNLERİN LİSTELENDİĞİ YER*/}
                <div className="bg-white text-black md:col-span-2 rounded-xl border p-4 space-y-10">
                    {basketDetail.map((item,index) => (
                        <div key={index} className="bg-white text-black md:col-span-2 rounded-xl border p-4 space-y-10">
                            <div className="flex items-center justify-between border-b pb-3">

                                <div className="flex items-center space-x-10 ">
                                    <div className="w-20 bg-white border rounded p-1">
                                        <img  src="https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg"/>
                                    </div>
                                    <div>
                                        <h3>{item.productName}</h3>
                                        <p>{item.productPrice}₺</p>
                                    </div>
                                </div>
                                <div className="flex items-center space-x-3">
                                    <input
                                        value={item.productQuantity}
                                        placeholder="Adet"
                                        className="w-16 border rounded px-2 py-1 text-center"
                                    />
                                    <p>{10*120} ₺</p>
                                    <button onClick={()=>handleDeleteProductToBasket(item.basketDetailId)} className="text-red-600 hover:text-red-800">SİL</button>
                                </div>
                            </div>
                        </div>
                    ))}

                </div>
                <div className="bg-gray-700  rounded-xl border p-4 space-y-10">
                    {/*SEPET ÖZETİNİN GÖRÜNTÜLENDİĞİ YER*/}
                    <h3 className="text-xl font-bold mb-4">Sepet Özeti</h3>
                    <div className="flex justify-between mb-2  bg-red-500">
                        <span>Ürün Toplamı</span>
                        <span>120 ₺</span>
                    </div>
                    <div className="flex justify-between mb-2 bg-red-500">
                        <span>KARGO</span>
                        <span>50₺</span>
                    </div>
                    <div className="flex justify-between bg-red-500">
                        <span>KDV</span>
                        <span>%18 KDV</span>
                    </div>
                    <div className="border-t flex justify-between pt-2 font-bold text-lg">
                        <span>Toplam</span>
                        <span>1000 ₺</span>
                    </div>
                    <button className="bg-red-600 hover:bg-red-800 text-white w-full py-3 rounded-xl mt-4">
                        Sepeti Onayla
                    </button>
                </div>
            </div>

        </div>
    );
};

export default Basket;