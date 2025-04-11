import React, {useState,createContext} from 'react';

export const ThemeContext = createContext()

const ThemeProvider = ({children}) => {

    const [theme,setTheme] = useState("light")

    const changeTheme = () => {
        setTheme(value => value === "light" ? "dark" : "light");
    }


    return (
       <ThemeContext.Provider value={{theme,changeTheme}}>
           {children}
       </ThemeContext.Provider>
    );

};

export default ThemeProvider;