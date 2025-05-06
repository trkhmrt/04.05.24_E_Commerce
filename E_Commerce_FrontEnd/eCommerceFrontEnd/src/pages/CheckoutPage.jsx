import React, {useState} from 'react';
import {checkout} from "../services/CheckoutService.js";

const CheckoutPage = ({bfi}) => {

    const [cardNumber, setCardNumber] = useState('');
    const [basketFinalInfo, setBasketFinalInfo] = useState(bfi);

    const handleCheckout = async () => {
         basketFinalInfo.cardNumber = cardNumber
        setBasketFinalInfo(basketFinalInfo)
        await checkout(basketFinalInfo)
    }

    return (
        <div className="bg-red-300 w-max-7xl">
            <label>{bfi.customerId}</label>
            <label>Card Numarası</label>
            <input
                onChange={(e) => setCardNumber(e.target.value)}
            />
            <button onClick={handleCheckout}>Ödemeyi Yap</button>
        </div>
    );
};

export default CheckoutPage;