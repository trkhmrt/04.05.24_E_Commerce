import axios from 'axios';


export const changeBasketStatus = async (basketInfo)=>{
    return await axios.post(`http://localhost:5107/Basket/changeBasketStatus`,basketInfo)
}


