import logo from './logo.svg';
import './App.css';
import NavBar from './components/NavBar';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import HomePage from './components/HomePage';
import TypesOfService from './components/TypesOfService';
import Services from './components/Services';
import Team from './components/Team';
import AboutPage from './components/AboutPage';

function App() {
  return (
    <BrowserRouter className="App">
      <NavBar />
      <HomePage />
      <TypesOfService />
      <Services />
      <AboutPage />
      <Team />
    </BrowserRouter>

  );
}

export default App;
