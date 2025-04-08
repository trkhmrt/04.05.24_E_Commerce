import React from 'react';
import {Link} from "react-router-dom";

const Home = () => {
    return (
        <div style={{backgroundColor: 'black'}}>
            <h1>ANASAYFA</h1>
            <ul>
                <li>
                    <a>
                        <Link to="/Contact">Contact</Link>
                    </a>
                </li>
                <li>
                    <a>
                        <Link to="/About">About</Link>
                    </a>
                </li>
                <li>
                    <a>
                        <Link to="/Products">Products</Link>
                    </a>
                </li>
            </ul>



        </div>
    );
};

export default Home;