import React,{useContext} from 'react';
import {ThemeContext} from "./ThemeProvider.jsx";
import {Link} from "react-router-dom";
import {AuthContext} from "./AuthProvider.jsx";

const Home = () => {

    const {theme,changeTheme} = useContext(ThemeContext)
    const {check,changeCheck} = useContext(AuthContext)
    console.log(check)
    const style={
        backgroundColor : theme === "light" ? "beige" : "black",
        color : theme === "dark" ? "white" : "black"
    }

    return (
        <div style={style}>
            <h1>HOME PAGE</h1>
            <button onClick={changeTheme}>Temayı değiştir</button>
            <button onClick={changeCheck}>Login</button>
            <a><Link to="/profile">Profile git</Link></a>
        </div>
    );
};

export default Home;