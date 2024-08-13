import React from 'react'

function Footer() {
    return (
        <footer className="footer py-4 bg-light">
            <div className="container">
                <div className="row align-items-center">
                    <div className="col-lg-4 text-lg-start">Copyright © BEAUTY HOUSE 2024</div>
                    <div className="col-lg-4 my-3 my-lg-0">
                        <a className="btn btn-dark btn-social mx-2" href="mailto:beauty.house.salon24@gmail.com" aria-label="Twitter"><i className="fa-solid fa-envelope"></i></a>
                        <a className="btn btn-dark btn-social mx-2" href="https://www.instagram.com/beautyhouse_belgrade/?hl=en" aria-label="Twitter"><i className="fa-brands fa-instagram"></i></a>
                        <a className="btn btn-dark btn-social mx-2" href="https://maps.app.goo.gl/VpzkhBM8neHsBBEq7" aria-label="Location"><i className="fa-solid fa-location-dot"></i></a>
                    </div>
                    <div className="col-lg-4 text-lg-end">
                        <a className="link-dark text-decoration-none me-3" href="#!">Napravi rezervaciju</a>
                    </div>
                </div>
            </div>
        </footer>
    )
}

export default Footer
