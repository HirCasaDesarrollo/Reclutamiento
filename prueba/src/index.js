import React from 'react';
import ReactDOM from 'react-dom';
import 'bootstrap/dist/css/bootstrap.min.css';
import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
import '../node_modules/bootstrap/dist/js/bootstrap.min.js';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom'
import Menu from '../src/View/Menu';

ReactDOM.render(
  <React.StrictMode>
    <Menu />
  </React.StrictMode>,

  
  document.getElementById('root')
);



reportWebVitals();