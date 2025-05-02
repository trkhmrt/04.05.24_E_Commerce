import React from 'react';
import {useAuth} from "../context/AuthContext.jsx";
import {Navigate} from "react-router-dom";

const GuestRoute = ({children}) => {

    const {isAuthenticated} = useAuth()

    return !isAuthenticated ? children : <Navigate to="/" />
};

export default GuestRoute;