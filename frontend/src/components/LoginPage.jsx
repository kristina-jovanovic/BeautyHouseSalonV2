import React, { useEffect, useState } from 'react'
import icon from '../resources/makeover.png'
import photo from '../resources/login.jpg'
import { useNavigate } from 'react-router-dom';
import axios from 'axios';
import { Button, Modal } from 'react-bootstrap';

function LoginPage({ addToken, addUser, token }) {

    let navigate = useNavigate();
    const [message, setMessage] = useState('');

    useEffect(() => {
        if (token != null) {
            navigate('/');
        }
    })

    const [userData, setUserData] = useState({
        username: '',
        password: ''
    });
    function handleInput(e) {
        // console.log(e);
        let newUserData = userData;
        newUserData[e.target.name] = e.target.value;
        // console.log(newUserData);
        setUserData(newUserData);
    }

    function handleLogin(e) {
        e.preventDefault();
        if (userData.username === '' || userData.password === '') {
            setMessage('Sva polja su obavezna!');
            handleShow();
        }
        else {

            const loginData = {
                korisnickoIme: userData.username,
                lozinka: userData.password
            };

            let config = {
                method: 'post',
                maxBodyLength: Infinity,
                url: 'api/Auth/Login',
                data: loginData,
                headers: {
                    'Content-Type': 'application/json' // Osigurava da server prepozna da saljem JSON
                }
            };

            axios.request(config)
                .then((response) => {
                    // console.log(JSON.stringify(response.data));
                    if (response.data.success === true) {
                        window.sessionStorage.setItem("auth_token", response.data.jwtToken);
                        addToken(response.data.jwtToken);
                        addUser(response.data.user);
                    }
                    else {
                        setMessage(response.data.message);
                        handleShow();
                    }
                })
                .catch((error) => {
                    console.log(error);
                    setMessage(error.message);
                    handleShow();
                });
        }
    }

    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    const register = () => navigate('/register');

    return (
        <section className="h-100 gradient-form"
            style={{ padding: 0 }}
        >
            <div className="container py-5 h-100" >
                <div className="row d-flex justify-content-center align-items-center h-100">
                    <div className="col-xl-10">
                        <div className="card rounded-3 text-black bg-light">
                            <div className="row g-0">
                                <div className="col-lg-6">
                                    <div className="card-body p-md-5 mx-md-4">

                                        <div className="text-center">
                                            <img src={icon}
                                                style={{ width: "185px" }} alt="logo" />
                                            <h4 className="mt-1 mb-5 pb-1"
                                            // style={{color:"#ff6eb7"}}
                                            >BEAUTY HOUSE</h4>
                                        </div>

                                        <form onSubmit={handleLogin}>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <input type="text" id="form2Example11" className="form-control"
                                                    placeholder="Unesi svoje korisničko ime" onInput={(e) => handleInput(e)} name="username" />
                                                <label className="form-label" htmlFor="form2Example11">Korisničko ime</label>
                                            </div>

                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <input type="password" id="form2Example22" className="form-control"
                                                    placeholder='Unesi svoju lozinku' onInput={(e) => handleInput(e)} name="password" />
                                                <label className="form-label" htmlFor="form2Example22">Lozinka</label>
                                            </div>

                                            <div className="text-center pt-1 mb-5 pb-1">
                                                <button type="submit" data-mdb-button-init data-mdb-ripple-init className="btn btn-primary btn-block fa-lg mb-3"
                                                    style={{ display: "block", width: "100%" }} onClick={handleLogin}>PRIJAVI SE</button>
                                            </div>

                                        </form>
                                        <div className="d-flex align-items-center justify-content-center pb-4">
                                            <p className="mb-0 me-2">Nemaš nalog?</p>
                                            <button type="button" data-mdb-button-init data-mdb-ripple-init className="btn btn-outline-primary" onClick={register} >Registruj se</button>
                                        </div>

                                    </div>
                                </div>
                                <div className="col-lg-6 d-flex align-items-center" style={{ backgroundColor: "#ff6eb7" }}>
                                    <div className="text-white px-3 py-4 p-md-5 mx-md-4">
                                        <h4 className="mb-4">We are more than just a company</h4>
                                        <p className="small mb-0">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                                            tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud
                                            exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <Modal show={show} onHide={handleClose} >
                <Modal.Header closeButton>
                    <Modal.Title>Greška</Modal.Title>
                </Modal.Header>
                <Modal.Body>{message}</Modal.Body>
                <Modal.Footer>
                    <Button variant="primary" onClick={() => {
                        handleClose();
                    }}>
                        OK
                    </Button>
                </Modal.Footer>
            </Modal>
        </section>
    )
}

export default LoginPage
