import React,{useState} from 'react';
import axios from "axios";
import {routeAddress} from '../constants/routes/RouteAddress.js'
import {useNavigate} from "react-router-dom";
import {useAuth} from "../context/AuthContext.jsx";

const Login = () => {
    const navigate = useNavigate()
    const [username , setUsername] = useState('')
    const [password , setPassword] = useState('')
    const {login} = useAuth()

    const handleLogin = async () =>{
        console.log({"userMail":username,"password":password})
        try{
            const response = await axios.post("http://localhost:5107/Auth/customerLogin", {"userMail":username,"password":password})
            console.log(response)

            const customerInfo = {
                "accessToken" : response.data.accessToken,
                "userId" : response.data.user.userId,
                "userEmail" :  response.data.user.customerMail,
                "customerId": response.data.user.customerId,
                "customerActiveBasketId" : response.data.user.customerActiveBasketId
            }
            login(customerInfo)
            navigate(routeAddress.Home)

        }
        catch(error){
            console.log(error.response.data)
        }

    }

    return (
        <div className="min-h-screen flex items-center justify-center bg-gradient-to-b from-gray-100 to-gray-500">
            <div className="bg-white shadow-xl rounded-2xl w-full p-8 max-w-md space-y-14">
                <h2 className="text-gray-800 text-3xl font-bold mb-6">Giriş Yap</h2>
                <div className="mb-1">
                    <label className="text-sm text-gray-600 mb-1">Username</label>
                    <input

                        className="w-full px-4 border rounded-lg focus:outline-none focus:border-blue-500 focus:ring-2 text-gray-600 mb-2"
                        onChange={(e) => setUsername(e.target.value)}
                    />
                </div>
                <div>
                    <label className="text-sm text-gray-600 mb-1">Password</label>
                    <input
                        className="w-full px-4 border rounded-lg focus:outline-none focus:border-blue-500 focus:ring-2 text-gray-600 mb-2"
                        type="password"
                        onChange={(e) => setPassword(e.target.value)}
                    />
                </div>
                <button className="w-full bg-blue-600 py-2 rounded-lg hover:bg-blue-700 border-none" onClick={handleLogin}>LOGİN</button>
            </div>
        </div>
    );
};

export default Login;