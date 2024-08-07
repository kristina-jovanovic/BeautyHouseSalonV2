import logo from './logo.svg';
import './App.css';
import NavBar from './components/NavBar';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import HomePage from './components/HomePage';
import TypesOfService from './components/TypesOfService';
import Services from './components/Services';

function App() {
  return (
    <BrowserRouter className="App">
      <NavBar />
      <HomePage />
      <TypesOfService />
      <Services />
    </BrowserRouter>

  );
}

export default App;
