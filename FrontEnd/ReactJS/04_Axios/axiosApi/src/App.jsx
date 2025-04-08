import './App.css'
import {useEffect, useState} from "react";
import axios from "axios";

function App() {
    //https://fakestoreapi.com/products/1
    const [product,setProduct] = useState({});
    useEffect(() => {
     // const fetchProducts = async () => {
     //     try{
     //         const response = await axios.get("https://fakestoreapi.com/products/1")
     //         setProduct(response.data);
     //     }catch(e){
     //         console.log(e.message)
     //         console.log("Veri çekilemedi")
     //     }

         const postProduct = async () => {
             try{
                 const product = { title: 'New Product', price: 29.99 }
                 const product2 = { title: 'Product2', price: 1009.99 }
                 const response = await axios.post("https://fakestoreapi.com/products",product)
                 const response2 = await axios.post("https://fakestoreapi.com/products",product2)
                 setProduct(response.data);
                 setProduct(response2.data);
             }catch(e){
                 console.log(e.message)
                 console.log("Veri gönderilemedi")
             }
     }

     //fetchProducts();
        postProduct()
    },[])


  return (
    <>
      <div>
          <h1>Title:{product.title}</h1>
          <p>Description:{product.description}</p>
          <img width={"300px"} height={"300px"} src={product.image}/>
          <p>Category:{product.category}</p>
          <p>Price:{product.price}₺</p>
      </div>
    </>
  )
}

export default App
