import React from 'react'

function OneService({ service }) {
    return (
        <div className="col-lg-4 col-sm-6 mb-4">
            <div className="portfolio-item">
                <a className="portfolio-link" data-bs-toggle="modal" href="#portfolioModal1">
                    <div className="portfolio-hover">
                        <div className="portfolio-hover-content">
                            {/* <svg className="svg-inline--fa fa-plus fa-3x" aria-hidden="true" focusable="false" data-prefix="fas" data-icon="plus" role="img" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" data-fa-i2svg=""><path fill="currentColor" d="M240 80c0-17.7-14.3-32-32-32s-32 14.3-32 32V224H32c-17.7 0-32 14.3-32 32s14.3 32 32 32H176V432c0 17.7 14.3 32 32 32s32-14.3 32-32V288H384c17.7 0 32-14.3 32-32s-14.3-32-32-32H240V80z"></path></svg> */}
                            {/* <i className="fas fa-plus fa-3x"></i> */}
                            <p className="text-uppercase">Rezerviši</p>
                        </div>
                    </div>
                    <div style={{
                        backgroundImage: `url(${service.fotografijaUsluge})`,
                        backgroundSize: 'cover', // Osigurava da se slika skalira
                        backgroundPosition: 'center', // Centriranje slike
                        height: '250px',
                        minHeight: '200px'
                    }}>
                    </div>
                    {/* <img className="img-fluid" src={service.fotografijaUsluge} alt="fotografija usluge" /> */}
                </a>
                <div className="portfolio-caption">
                    <div className="portfolio-caption-heading">{service.naziv}</div>
                    <div className="portfolio-caption-subheading text-muted">{service.tipUsluge.nazivTipaUsluge}</div>
                </div>
            </div>
        </div>
    )
}

export default OneService
