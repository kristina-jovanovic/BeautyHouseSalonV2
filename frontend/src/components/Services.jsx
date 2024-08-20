import React, { useEffect, useState } from 'react'
import OneService from './OneService'
import Loader from './Loader'
import axios from 'axios';

function Services({ addService }) {
    const [loading, setLoading] = useState(true);
    const [notFound, setNotFound] = useState(false);

    const [services, setServices] = useState();
    const [serviceChunks, setServiceChunks] = useState();

    // Function to split services into groups of six
    const chunkServices = (arr, chunkSize) => {
        let result = [];
        for (let i = 0; i < arr.length; i += chunkSize) {
            result.push(arr.slice(i, i + chunkSize));
        }
        return result;
    };

    function vratiSveUsluge() {
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

    const [filter, setFilter] = useState('');
    function handleInput(e) {
        setNotFound(false);
        let newFilter = filter;
        newFilter = e.target.value;
        // console.log("newFilter "+ newFilter);
        // console.log("filter "+ filter);
        setFilter(newFilter);
        setLoading(true);

        e.preventDefault();
        if (newFilter === '') {
            vratiSveUsluge();
        }
        else {
            let config = {
                method: 'get',
                maxBodyLength: Infinity,
                url: `api/Usluge?filterQuery=${newFilter}`
            };

            axios.request(config)
                .then((response) => {
                    // console.log(JSON.stringify(response.data));
                    if (response.data.notFound) {
                        setNotFound(true);
                    }
                    setServices(response.data.usluge);
                    setLoading(false);
                })
                .catch((error) => {
                    console.log(error);
                });
        }
    }

    useEffect(() => {
        if (services == null) {
            vratiSveUsluge();
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
                <form className="d-flex" style={{ marginTop: '1rem', marginBottom: '1rem', alignItems: 'center', justifyContent: 'center' }}>
                    <input className="form-control search" type="search" placeholder="Pretraži usluge po nazivu ili tipu usluge" aria-label="Search"
                        onInput={handleInput} name='filter' />
                    <button type="submit" className="btn btn-outline-primary" disabled><i className="fa-solid fa-magnifying-glass"></i></button>
                </form>
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
                        ) : (notFound ? (
                            <div class="alert alert-danger" role="alert">
                                Ni jedna usluga nije pronađena za unetu pretragu.
                            </div>) : (
                            serviceChunks?.map((chunk, index) => (
                                <div className={`carousel-item ${index === 0 ? 'active' : ''}`} key={index}>
                                    <div className="row">
                                        {chunk.map((service) => (
                                            <OneService service={service} addService={addService} key={service.uslugaId} />
                                        ))}
                                    </div>
                                </div>
                            )))
                        )}
                    </div>
                </div>
            </div>
        </section>
    )
}

export default Services
