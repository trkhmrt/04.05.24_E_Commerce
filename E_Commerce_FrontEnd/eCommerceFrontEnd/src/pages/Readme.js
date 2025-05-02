import React from "react";
import {Link} from "react-router-dom";
import {routeAddress} from "../constants/routes/RouteAddress.js";

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


