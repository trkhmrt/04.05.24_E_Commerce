import './App.css'
import {BrowserRouter as Router, Route, Routes} from "react-router-dom";
import Home from "./pages/Home.jsx";
import Contact from "./pages/Contact.jsx";
import About from "./pages/About.jsx";
import Products from "./pages/Products.jsx";
import Product from "./pages/Product.jsx";

function App() {


  return (

   <Router>
       <Routes>
            <Route path="/Contact" element={<Contact/>}/>
            <Route path="/" exact element={<Home/>} />
            <Route path="/About" element={<About/>}/>
            <Route path="/Products" element={<Products/>}/>
           <Route path="/Product/:id" element={<Product/>}/>
       </Routes>
   </Router>

  )
}

export default App
