import React,{useState} from 'react';
import axios from "axios";

const Login = () => {

    const [username , setUsername] = useState('')
    const [password , setPassword] = useState('')

    const handleLogin = async () =>{
        console.log({"userMail":username,"password":password})

        try{
            const response = await axios.post("http://localhost:5107/Auth/login", {"userMail":username,"password":password})
            console.log(response.data.jwtToken)
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