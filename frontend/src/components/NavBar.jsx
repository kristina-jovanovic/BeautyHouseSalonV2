import React, { useEffect, useState } from 'react'
import logo from '../resources/BeautyHouseLogo.png'
import { Outlet, useNavigate } from 'react-router-dom'
import Footer from './Footer';
import { Button, Modal } from 'react-bootstrap';

function NavBar({ token, addToken, addUser }) {
    let navigate = useNavigate();

    function handleLogout() {
        window.sessionStorage.setItem("auth_token", null);
        addToken(null);
        addUser(null);
        // navigate('/');
    }

    // pratimo stanje da li je navbar zatvoren, tj toggle button 'ugasen', na pocetku jeste
    const [isNavCollapsed, setIsNavCollapsed] = useState(true);

    useEffect(() => {
        // Navbar shrink function
        const handleNavbarShrink = () => {
            const navbarCollapsible = document.body.querySelector('#mainNav');
            if (!navbarCollapsible) {
                return;
            }
            if (window.scrollY === 0) {
                navbarCollapsible.classList.remove('navbar-shrink');
            } else {
                navbarCollapsible.classList.add('navbar-shrink');
            }
        };

        // Shrink the navbar when the page is scrolled
        window.addEventListener('scroll', handleNavbarShrink);

        //  Activate Bootstrap scrollspy on the main nav element - kako skrolujes tako postaje aktivan item u navbaru onaj na kome se trenutno nalazis
        const mainNav = document.body.querySelector('#mainNav');
        if (mainNav) {
            new window.bootstrap.ScrollSpy(document.body, {
                target: '#mainNav',
                rootMargin: '0px 0px -40%',
            });
        }

        return () => {
            window.removeEventListener('scroll', handleNavbarShrink);
        };
    }, []);

    //postavljamo stanje na suprotno od sadasnjeg, kada se (ponovo) klikne na toggle dugme
    const handleNavCollapse = () => setIsNavCollapsed(!isNavCollapsed);

    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
                <div className="container">
                    <a className="navbar-brand" href="#page-top">Beauty House</a>
                    <button
                        className="navbar-toggler"
                        type="button"
                        aria-controls="navbarSupportedContent"
                        aria-expanded={!isNavCollapsed}
                        aria-label="Toggle navigation"
                        onClick={handleNavCollapse}
                    >
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className={`${isNavCollapsed ? 'collapse' : 'show'} navbar-collapse`} id="navbarSupportedContent">
                        <ul className="navbar-nav text-uppercase ms-auto py-4 py-lg-0">
                            {/* na klik bilo koje stavke iz menija, prebacicemo se na taj deo stranice i meni ce se zatvoriti jer smo ubacili handleNavCollapse,
                        tj. u ovom slucaju simuliramo klik na toggle button */}
                            <li className="nav-item"><a className="nav-link" href="#services" onClick={handleNavCollapse}>Tipovi usluga</a></li>
                            <li className="nav-item"><a className="nav-link" href="#portfolio" onClick={handleNavCollapse}>Usluge</a></li>
                            <li className="nav-item"><a className="nav-link" href="#about" onClick={handleNavCollapse}>O nama</a></li>
                            <li className="nav-item"><a className="nav-link" href="#team" onClick={handleNavCollapse}>Tim</a></li>
                            {token == null ? (<li className="nav-item"><a className="nav-link" href="/login">Prijavi se</a></li>) : (
                                <li className="nav-item"><a className="nav-link" onClick={handleShow} style={{cursor:"pointer"}}>Odjavi se</a></li>
                            )}
                        </ul>
                    </div>
                </div>
            </nav>
            <Modal show={show} onHide={handleClose} >
                <Modal.Header closeButton>
                    <Modal.Title>Upozorenje</Modal.Title>
                </Modal.Header>
                <Modal.Body>Da li si sigurna da želiš da se odjaviš?</Modal.Body>
                <Modal.Footer>
                    <Button variant="outline-primary" onClick={() => {
                        handleLogout();
                        handleClose();
                        navigate('/');
                    }}>
                        Da
                    </Button>
                    <Button variant="primary" onClick={() => {
                        handleClose();
                    }}>
                        Ne
                    </Button>
                </Modal.Footer>
            </Modal>
            <Outlet />
            <Footer />
        </div>
    );

}

export default NavBar
