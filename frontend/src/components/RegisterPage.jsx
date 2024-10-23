import React, { useEffect, useState } from 'react'
import icon from '../resources/makeover.png'
import { Button, Modal } from 'react-bootstrap';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

function RegisterPage({ addToken, addUser, token }) {

    let navigate = useNavigate();
    const [message, setMessage] = useState('');

    useEffect(() => {
        if (token != null) {
            navigate('/');
        }
    })

    const [userData, setUserData] = useState({
        ime: '',
        prezime: '',
        datumRodjenja: '',
        brojTelefona: '',
        email: '',
        korisnickoIme: '',
        lozinka: ''
    });
    function handleInput(e) {
        // console.log(e);
        let newUserData = userData;
        newUserData[e.target.name] = e.target.value;
        // console.log(newUserData);
        setUserData(newUserData);
    }
    function handleRegister(e) {
        e.preventDefault();
        if (userData.ime === '' || userData.prezime === '' || userData.datumRodjenja === '' || userData.brojTelefona === '' || userData.email === ''
            || userData.korisnickoIme === '' || userData.lozinka === ''
        ) {
            setMessage('Sva polja su obavezna!');
            handleShow();
        }
        else {
            userData.datumRodj = new Date(userData.datumRodj);

            let config = {
                method: 'post',
                maxBodyLength: Infinity,
                url: 'api/Auth/Register',
                data: userData,
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
                        navigate('/');
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

    return (
        <section className="h-100 gradient-form bg-dark"
            style={{ padding: "5rem 0" }}
        >
            <div className="container py-5 h-100" >
                <div className="row d-flex justify-content-center align-items-center h-100">
                    <div className="col-xl-10">
                        <div className="card rounded-3 text-black bg-light">
                            <div className="row g-0">
                                <div className="col-lg-8">
                                    <div className="card-body p-md-5 mx-md-4">

                                        <div className="text-center">
                                            <h4 className="mt-1 mb-5 pb-1"
                                            >BEAUTY HOUSE</h4>
                                        </div>

                                        <form onSubmit={handleRegister}>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <input type="text" id="form2Example11" className="form-control"
                                                    placeholder="Unesi svoje ime" onInput={(e) => handleInput(e)} name="ime" />
                                                <label className="form-label" htmlFor="form2Example11">Ime</label>
                                            </div>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <input type="text" id="form2Example12" className="form-control"
                                                    placeholder="Unesi svoje prezime" onInput={(e) => handleInput(e)} name="prezime" />
                                                <label className="form-label" htmlFor="form2Example12">Prezime</label>
                                            </div>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <input type="date" id="form2Example13" className="form-control"
                                                    placeholder="dd-mm-yyyy" onInput={(e) => handleInput(e)} name="datumRodjenja" />
                                                <label className="form-label" htmlFor="form2Example13">Datum rođenja</label>
                                            </div>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <input type="text" id="form2Example14" className="form-control" pattern="06[0-9]{7,8}"
                                                    placeholder="Unesi svoj broj telefona" onInput={(e) => handleInput(e)} name="brojTelefona" />
                                                <label className="form-label" htmlFor="form2Example14">Broj telefona</label>
                                            </div>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <input type="email" id="form2Example15" className="form-control"
                                                    placeholder="Unesi svoju email adresu" onInput={(e) => handleInput(e)} name="email" />
                                                <label className="form-label" htmlFor="form2Example15">Email adresa</label>
                                            </div>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <input type="text" id="form2Example16" className="form-control"
                                                    placeholder="Unesi svoje korisničko ime" onInput={(e) => handleInput(e)} name="korisnickoIme" />
                                                <label className="form-label" htmlFor="form2Example16">Korisničko ime</label>
                                            </div>

                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <input type="password" id="form2Example17" className="form-control"
                                                    placeholder='Unesi svoju lozinku' onInput={(e) => handleInput(e)} name="lozinka" />
                                                <label className="form-label" htmlFor="form2Example17">Lozinka</label>
                                            </div>

                                            <div className="text-center pt-1 mb-5 pb-1">
                                                <button type="submit" data-mdb-button-init data-mdb-ripple-init className="btn btn-primary btn-block fa-lg mb-3"
                                                    style={{ display: "block", width: "100%" }} onClick={handleRegister}>REGISTRUJ SE</button>
                                            </div>
                                        </form>
                                    </div>
                                </div>
                                <div className="col-lg-4 d-flex align-items-center round-edges" style={{ backgroundColor: "#ff6eb7" }}>
                                    <div className="text-white px-3 py-4">
                                        <div style={{ textAlign: "center" }}>
                                            <img src={icon}
                                                style={{ width: "185px", display: "inline-block" }} alt="logo" />
                                        </div>
                                        <h4 className="mb-4">Više od običnog salona!</h4>
                                        <p className="small mb-0">Znamo da prava lepota dolazi iznutra, ali nije na odmet da zablistaš i sa spolja!</p>
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

export default RegisterPage
