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

  const [service, setService] = useState();
  function addService(service) {
    setService(service);
  }

  return (
    <BrowserRouter className="App">
      <Routes>
        <Route path='/' element={<NavBar addToken={addToken} addUser={addUser} token={token} addService={addService}/>}>
          <Route path='/' element={<HomePage addService={addService}/>} />
          <Route path='/reservation' element={<ReservationPage token={token} user={user} service={service} addService={addService}/>} />
          <Route path='/login' element={<LoginPage addToken={addToken} addUser={addUser} token={token} />} />
          <Route path='/register' element={<RegisterPage addToken={addToken} addUser={addUser} token={token} />} />
        </Route>

      </Routes>



    </BrowserRouter>

  );
}

export default App;
