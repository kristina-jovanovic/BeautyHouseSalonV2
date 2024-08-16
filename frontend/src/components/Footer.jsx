import React from 'react'
import { Link } from 'react-router-dom'

function Footer() {
    return (
        <footer className="footer py-4 bg-light">
            <div className="container">
                <div className="row align-items-center">
                    <div className="col-lg-4 text-lg-start" style={{ fontWeight: "bold" }}>Copyright © BEAUTY HOUSE 2024</div>
                    <div className="col-lg-4 my-3 my-lg-0">
                        <a className="btn btn-dark btn-social mx-2" href="mailto:beauty.house.salon24@gmail.com" aria-label="Twitter"><i className="fa-solid fa-envelope"></i></a>
                        <a className="btn btn-dark btn-social mx-2" href="https://www.instagram.com/beautyhouse_belgrade/?hl=en" aria-label="Twitter"><i className="fa-brands fa-instagram"></i></a>
                        <a className="btn btn-dark btn-social mx-2" href="https://maps.app.goo.gl/VpzkhBM8neHsBBEq7" aria-label="Location"><i className="fa-solid fa-location-dot"></i></a>
                    </div>
                    <div className="col-lg-4 text-lg-end">
                        <Link className="link-dark text-decoration-none text-uppercase me-3 bold" to="/reservation" style={{ fontWeight: "bold" }}>Napravi rezervaciju</Link>
                    </div>
                </div>
            </div>
        </footer>
    )
}

export default Footer
