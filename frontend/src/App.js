import logo from './logo.svg';
import './App.css';
import NavBar from './components/NavBar';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import HomePage from './components/HomePage';

function App() {
  return (
    <BrowserRouter className="App">
      <Routes>
        <Route path='/' element={<NavBar />}>
          <Route path='/' element={<HomePage />} />
        </Route>

      </Routes>



    </BrowserRouter>

  );
}

export default App;
