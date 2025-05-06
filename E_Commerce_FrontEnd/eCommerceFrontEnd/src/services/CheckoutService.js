import axios from 'axios';

export const checkout = async (basketInfo)=>{
    return await axios.post(`http://localhost:5107/Payment/createPayment`,basketInfo)
}

