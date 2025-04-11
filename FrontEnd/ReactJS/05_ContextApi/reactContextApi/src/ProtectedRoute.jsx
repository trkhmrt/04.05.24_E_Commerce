import React, {useContext} from 'react';
import {Navigate} from 'react-router-dom';
import {AuthContext} from "./AuthProvider.jsx";

const ProtectedRoute = ({children}) => {
    const {check} = useContext(AuthContext)


        if(check !== "true"){
         return  <Navigate to="/" />
        }

        return children

};

export default ProtectedRoute;