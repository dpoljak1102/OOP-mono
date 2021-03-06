import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
//import App from './App';
import * as serviceWorker from './serviceWorker';

import 'bootstrap/dist/css/bootstrap.min.css';
import Navbar from './Navbar';
import HomeSection from './components/Home-section';
import Box from './components/Box';
import Autors from './components/Autors';
import Footer from './components/Footer';
import Explore from './components/Explore';


ReactDOM.render(
  <React.StrictMode>
    <Navbar />
    <HomeSection />
    <Autors />
    <Box />
    <Explore />
    <Footer />
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
