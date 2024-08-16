import logo from './logo.svg';
import './App.css';
import NavBar from './components/NavBar';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import HomePage from './components/HomePage';
import LoginPage from './components/LoginPage';
import { useState } from 'react';
import RegisterPage from './components/RegisterPage';
import ReservationPage from './components/ReservationPage';

function App() {

  const [token, setToken] = useState();

  function addToken(auth_token) {
    setToken(auth_token);
  }
  const [user, setUser] = useState();
  function addUser(user) {
    setUser(user);
  }

  return (
    <BrowserRouter className="App">
      <Routes>
        <Route path='/' element={<NavBar addToken={addToken} addUser={addUser} token={token} />}>
          <Route path='/' element={<HomePage />} />
          <Route path='/reservation' element={<ReservationPage />} />
          <Route path='/login' element={<LoginPage addToken={addToken} addUser={addUser} token={token} />} />
          <Route path='/register' element={<RegisterPage addToken={addToken} addUser={addUser} token={token} />} />
        </Route>

      </Routes>



    </BrowserRouter>

  );
}

export default App;
