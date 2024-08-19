import React, { useEffect, useState } from 'react'
import OneService from './OneService'
import Loader from './Loader'
import axios from 'axios';

function Services({addService}) {
    const [loading, setLoading] = useState(true);

    const [serviceChunks, setServiceChunks] = useState();

    // Function to split services into groups of six
    const chunkServices = (arr, chunkSize) => {
        let result = [];
        for (let i = 0; i < arr.length; i += chunkSize) {
            result.push(arr.slice(i, i + chunkSize));
        }
        return result;
    };

    const [services, setServices] = useState();
    useEffect(() => {
        if (services == null) {
            let config = {
                method: 'get',
                maxBodyLength: Infinity,
                url: 'api/Usluge'
            };

            axios.request(config)
                .then((response) => {
                    // console.log(JSON.stringify(response.data));
                    setServices(response.data);
                    setLoading(false);
                })
                .catch((error) => {
                    console.log(error);
                });
        }
        else {
            setServiceChunks(chunkServices(services, 6));
        }

    }, [services]);

    return (
        <section className="page-section bg-light" id="portfolio">
            <div className="container">
                <div className="text-center">
                    <h2 className="section-heading text-uppercase">Usluge</h2>
                    <h3 className="section-subheading text-muted">Izaberi i zakaži tretman za sebe.</h3>
                </div>
                <div id="carouselExampleIndicators" className="carousel slide">
                    <div className="carousel-indicators" style={{ marginBottom: 0 }}>
                        {serviceChunks?.map((chunk, index) => (
                            <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to={index} className={`bg-dark ${index === 0 ? "active" : ""}`} aria-current={index === 0 ? "true" : "false"} aria-label={`Slide ${index + 1}`}></button>
                        ))}
                    </div>
                    <div className="carousel-inner">
                        {loading ? (
                            <div className='d-flex justify-content-center align-items-center'>
                                <Loader />
                            </div>
                        ) : (
                            serviceChunks?.map((chunk, index) => (
                                <div className={`carousel-item ${index === 0 ? 'active' : ''}`} key={index}>
                                    <div className="row">
                                        {chunk.map((service) => (
                                            <OneService service={service} addService={addService} key={service.uslugaId} />
                                        ))}
                                    </div>
                                </div>
                            ))
                        )}
                    </div>
                </div>
            </div>
        </section>
    )
}

export default Services
