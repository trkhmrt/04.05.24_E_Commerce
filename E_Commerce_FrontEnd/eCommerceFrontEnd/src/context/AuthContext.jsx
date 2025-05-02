import {createContext, useContext, useEffect, useState} from 'react';
import {Navigate, useNavigate} from "react-router-dom";


const AuthContext = createContext()

const AuthProvider = ({children}) => {

    const [isAuthenticated, setIsAuthenticated] = useState(false);


    const login = (customerInfo) => {
        //
        localStorage.setItem("customerInfo",JSON.stringify(customerInfo))
        console.log(customerInfo)
        setIsAuthenticated(true)

    }

    const logout = () => {
        localStorage.clear()
        setIsAuthenticated(false)
    }

    useEffect(() => {
        const authStatus = localStorage.getItem("auth")
        setIsAuthenticated(authStatus === "true")
    }, []);



    return (
      <AuthContext.Provider value={{isAuthenticated,login,logout}}>
          {children}
      </AuthContext.Provider>
    );
};

export default AuthProvider;

export const useAuth = () => useContext(AuthContext)