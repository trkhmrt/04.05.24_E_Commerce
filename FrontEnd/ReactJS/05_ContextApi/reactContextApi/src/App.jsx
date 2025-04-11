import './App.css'
import ThemeProvider from "./ThemeProvider.jsx";
import Home from "./Home.jsx";
import {BrowserRouter, Route, Routes} from "react-router-dom";
import Profile from "./Profile.jsx";
import AuthProvider from "./AuthProvider.jsx";
import React from "react";
import ProtectedRoute from "./ProtectedRoute.jsx";

function App() {
    {/*
    ContextApi Nedir ?

    State management(State yönetimi) kolaylaştırır.
    Herhangi bir componentte üretilen veriyi proplar ile bir componentten diğerine taşımak gibi(Zincirleme) zahmetli yol yerine tek bir yapı üzerinden veriyi  alt componentlerin her birine dağıtır.

    Ne zaman Kullanılır ?

    Tema , dil , kullanıcı bilgisi , oturum durumu  kontrolleri için.

    Prop drilling(Bir bileşenden diğerine gereksiz veri geçirme) yaşanıyorsa

    */}




  return (
    <>
      <ThemeProvider>
          <AuthProvider>
          <BrowserRouter>
              <Routes>
                  <Route path="/" exact element={<Home/>}></Route>
                  <Route path="/profile" element={
                      <ProtectedRoute>
                          <Profile/>
                      </ProtectedRoute>
                  }
                  />


              </Routes>
          </BrowserRouter>
          </AuthProvider>
      </ThemeProvider>

    </>
  )
}

export default App
