import React from 'react'
import { useNavigate } from 'react-router-dom';

function OneService({ service, addService }) {
    let navigate = useNavigate();

    function rezervisi(e) {
        e.preventDefault();
        addService(service);
        navigate('/reservation');
    }

    return (
        <div className="col-lg-4 col-sm-6 mb-4">
            <div className="portfolio-item">
                <a className="portfolio-link"
                //  data-bs-toggle="modal" href="#portfolioModal1"
                >
                    <div className="portfolio-hover">
                        <div className="portfolio-hover-content">
                            <button className="btn btn-primary text-uppercase"
                                // style={{ cursor: "pointer" }} 
                                onClick={rezervisi}>Rezerviši</button>
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
                    {/* <div className="portfolio-caption-subheading text-muted">{service.tipUsluge.nazivTipaUsluge}</div> */}
                    <p style={{margin:0}}>Cena: {service.cena} €</p>
                    <p style={{margin:0}}>Trajanje termina: {service.trajanjeUMinutima} minuta</p>
                </div>
            </div>
        </div>
    )
}

export default OneService
