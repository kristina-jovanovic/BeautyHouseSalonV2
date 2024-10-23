import React, { useEffect, useState } from 'react'
import OneTypeOfService from './OneTypeOfService'
import axios from 'axios';
import Loader from './Loader';

function TypesOfService() {
    const [loading, setLoading] = useState(true);

    const [typesOfService, setTypesOfService] = useState();
    useEffect(() => {
        if (typesOfService == null) {
            let config = {
                method: 'get',
                maxBodyLength: Infinity,
                url: 'api/TipoviUsluga'
            };

            axios.request(config)
                .then((response) => {
                    // console.log(JSON.stringify(response.data));
                    setTypesOfService(response.data);
                    setLoading(false);
                })
                .catch((error) => {
                    console.log(error);
                });

        }

    }, [typesOfService]);

    let icons = [
        "fa-wand-sparkles",
        "fa-scissors",
        "fa-paintbrush",
        "fa-hand-sparkles",
        "fa-spray-can-sparkles",
    ];

    return (
        <div>
            <section className="page-section" id="services">
                <div className="container">
                    <div className="text-center">
                        <h2 className="section-heading text-uppercase">Tipovi usluga</h2>
                        <h3 className="section-subheading text-muted">Pogledaj šta te sve očekuje u našem salonu.</h3>
                    </div>
                    {loading ? (
                        <div className='d-flex justify-content-center align-items-center'>
                            <Loader />
                        </div>
                    ) : (
                        <div className="row text-center">
                            {typesOfService?.map((type, index) => (
                                <OneTypeOfService
                                    type={type}
                                    key={type.tipUslugeID}
                                    iconClass={icons[index]}
                                />
                            ))}
                        </div>
                    )}
                </div>
            </section>

        </div>
    )
}

export default TypesOfService
