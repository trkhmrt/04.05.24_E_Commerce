import React from 'react';
import {Link} from "react-router-dom";

const Products = () => {
    const urunler = [
        {id:1,"urunad":"ayakkabı","fiyat":100},
        {id:2,"urunad":"gömlek","fiyat":200},
    ]

    return (
        <div>
            <table>
                <tr>
                    <th>
                        Urun adi
                    </th>
                    <th>
                        urun Fiyatı
                    </th>
                </tr>
                {urunler.map((urun) => (
                    <tr key={urun.id}>
                        UrunAd:{urun.urunad}-Fiyat:{urun.fiyat}₺
                        <a><Link to={`/Product/${urun.id}`}>Ürün Detay</Link></a>
                    </tr>


                ))}

            </table>
        </div>
    );
};

export default Products;