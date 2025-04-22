import React,{useState} from 'react';
import axios from "axios";
import {routeAddress} from '../constants/routes/RouteAddress.js'
import {useNavigate} from "react-router-dom";

const Login = () => {
    const navigate = useNavigate()
    const [username , setUsername] = useState('')
    const [password , setPassword] = useState('')

    const handleLogin = async () =>{
        console.log({"userMail":username,"password":password})
        try{
            const response = await axios.post("http://localhost:5107/Auth/login", {"userMail":username,"password":password})
            localStorage.setItem("accesToken", response.data.accessToken)
            localStorage.setItem("userId", response.data.user.userId)
            localStorage.setItem("userEmail", response.data.user.userEmailToken)
            navigate(routeAddress.Home)
            console.log(response)
        }
        catch(error){
            console.log(error.response.data)
        }

    }

    return (
        <div>
            <h1>Login Page</h1>
            <input
                placeholder="username"
                onChange={(e) => setUsername(e.target.value)}
            />

            <input
                placeholder="password"
                type="password"
                onChange={(e) => setPassword(e.target.value)}
            />
            <button onClick={handleLogin}>LOGİN</button>
        </div>
    );
};

export default Login;