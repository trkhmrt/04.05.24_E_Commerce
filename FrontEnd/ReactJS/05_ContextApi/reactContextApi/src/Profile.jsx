import React, {useContext} from 'react';
import {ThemeContext} from "./ThemeProvider.jsx";

const Profile = () => {
    const {theme} = useContext(ThemeContext)

    const style={
        backgroundColor : theme === "light" ? "beige" : "black",
        color : theme === "dark" ? "white" : "black"
    }

    return (
        <div style ={style}>
            <h1>Profile PAGE</h1>
        </div>
    );
};

export default Profile;