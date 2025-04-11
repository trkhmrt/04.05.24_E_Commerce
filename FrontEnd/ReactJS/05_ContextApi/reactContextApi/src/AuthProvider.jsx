import React, {useState,createContext} from 'react';

export const AuthContext = createContext()

const AuthProvider = ({children}) => {

    const [check,setCheck] = useState(localStorage.getItem("auth"))

    const changeCheck = () => {
        setCheck("true");
        localStorage.setItem("auth","true")
    }


    return (
        <AuthContext.Provider value={{check,changeCheck}}>
            {children}
        </AuthContext.Provider>
    );

};

export default AuthProvider;