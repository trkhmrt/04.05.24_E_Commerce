import {useState} from 'react';
import {Link, useNavigate} from "react-router-dom";
import {routeAddress} from "../constants/routes/RouteAddress.js";
import {useAuth} from "../context/AuthContext.jsx";
const Navbar = () => {
    const [openMenu, setOpenMenu] = useState(false);
    const [dropdownOpen,setDropdownOpen] = useState(false);
    const navigate = useNavigate()
    const [isAuthentificated, setIsAuthentificated] = useState(localStorage.getItem("auth"));
    const {logout} = useAuth()

    const handleLogOut = () =>{
        logout()
        navigate("/login")
    }

    return (

         <>
             <nav className="bg-white shadow-md sticky top-0  right-0 left-0 px-4">
                 <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
                     <div className="flex justify-between items-center h-16">
                         {/*LOGO*/}
                         <div>
                             <a className="text-xl font-bold text-indigo-600 hover:text-blue-600">E-COMMERCE</a>
                         </div>

                         {/*MASAÜSTÜ GÖRÜNÜMÜ*/}
                         <div className="hidden md:flex space-x-6 items-center">
                             <a className="text-gray-700 hover:text-blue-600" href="/">ANASAYFA</a>
                             <div className="relative" onMouseEnter={()=>setDropdownOpen(true)} onMouseLeave={()=>setDropdownOpen(false)}>
                                 <button className="text-gray-700 hover:text-indigo-600">Ürünler</button>
                                 <div className={`absolute top-full  w-50 bg-white rounded shadow-lg border transition-all transform duration-300 ease-in-out ${dropdownOpen ? 'max-h-96 opacity-100' : 'max-h-0 opacity-0'}`}>
                                     <a className="block px-4 py-2 text-indigo-600">Elektronik</a>
                                     <a className="block px-4 py-2 text-indigo-600">Giyim</a>
                                     <a className="block px-4 py-2 text-indigo-600">Eğlence</a>
                                 </div>


                             </div>

                             <a className="text-gray-700 hover:text-blue-600">Hakkımızda</a>
                             <a className="text-gray-700 hover:text-blue-600">İletişim</a>
                             <Link className="text-gray-700 hover:text-blue-600" to={routeAddress.Basket}>Sepet</Link>
                             {isAuthentificated ? (
                                     <button className="text-black" onClick={()=>handleLogOut()}>Çıkış Yap</button>
                             ):
                                 (
                                 <button className="text-black" onClick={()=>navigate("/login")}>Giriş Yap</button>
                             )
                             }

                         </div>



                         {/*MOBİL GÖRÜNÜMÜ*/}
                         <div className="md:hidden flex items-center">
                             <button className="text-gray-700 focus:outline-none bg-red-600" onClick={()=>setOpenMenu(!openMenu)}>
                                 <svg className="w-6 h-6" stroke="stroke-blue-600" fill="none" viewBox="0 0 30 30">
                                     <path
                                         strokeLinecap="round"
                                         strokeLinejoin="round"
                                         stroke="2"
                                         d = {openMenu ? 'M6 18L18 6M6 6l12 12' : 'M4 6h16M4 12h16M4 18h16'}

                                     />
                                 </svg>
                             </button>
                         </div>
                     </div>
                 </div>
                 {openMenu && (
                     <div className="md:hidden p-4 space-y-2">
                         <a className="block text-gray-700">ANASAYFA</a>
                         <a className="block text-gray-700">ÜRÜNLER</a>
                         <a className="block text-gray-700">HAKKIMIZDA</a>
                         <a className="block text-gray-700">İLETİŞİM</a>
                     </div>
                 )}

             </nav>
         </>
);



};


export default Navbar;