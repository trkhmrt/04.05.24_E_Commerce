import './App.css'
import {routeAddress} from './constants/routes/RouteAddress.js'
import {BrowserRouter, Route, Routes} from "react-router-dom";
import HomePage from "./pages/HomePage.jsx";
import Login from "./pages/Login.jsx";
import ProductDetail from "./pages/ProductDetail.jsx";
import Basket from "./pages/Basket.jsx";
import NotFound from "./pages/NotFound.jsx";
import Layout from "./layout/Layout.jsx";
import AuthProvider from "./context/AuthContext.jsx";
import GuestRoute from "./routes/GuestRoute.jsx";


function App() {


    return (
        <>
            <AuthProvider>
            <BrowserRouter>
                <Routes>

                    <Route path="/login" element={
                        <GuestRoute>
                            <Login/>
                        </GuestRoute>



                    }/>
                    <Route element={<Layout/>}>

                    <Route path={routeAddress.Home} element={<HomePage/>}/>
                    <Route path="/productDetail/:productId" element={<ProductDetail/>}/>
                    <Route path={routeAddress.Basket} element={<Basket/>}/>
                    <Route path="*" element={<NotFound/>}/>
                    </Route>
                </Routes>
            </BrowserRouter>
            </AuthProvider>
        </>
    )
}

export default App
