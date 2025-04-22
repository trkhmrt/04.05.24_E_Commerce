import './App.css'
import {routeAddress} from './constants/routes/RouteAddress.js'
import {BrowserRouter, Route, Routes} from "react-router-dom";
import HomePage from "./pages/HomePage.jsx";
import Login from "./pages/Login.jsx";
import ProductDetail from "./pages/ProductDetail.jsx";
import Basket from "./pages/Basket.jsx";


function App() {


    return (
        <>
            <BrowserRouter>
                <Routes>
                    <Route path={routeAddress.Home} element={<HomePage/>}/>
                    <Route path="/login" element={<Login/>}/>
                    <Route path="/productDetail/:productId" element={<ProductDetail/>}/>
                    <Route path={routeAddress.Basket} element={<Basket/>}/>
                </Routes>
            </BrowserRouter>
        </>
    )
}

export default App
