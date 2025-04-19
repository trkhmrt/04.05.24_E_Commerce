import React from 'react';
import Products from "./Products.jsx";
import Navbar from "../components/Navbar.jsx";

const HomePage = () => {
    return (
        <>
             <Navbar></Navbar>
            <Products></Products>
        </>
    );
};

export default HomePage;